using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using vMixMonitor.Data;
using static vMixMonitor.Data.@enum;

namespace vMixMonitor
{
    /// <summary>
    /// Vmix Calls and parsing
    /// </summary>
    public class vMixHelper
    {
        private bool _streaming = false;

        /// <summary>
        /// Current API DOC
        /// </summary>
        public vmix currentDoc;
        public bool onLine { get; set; }
        /// <summary>
        ///vMix web interface base url
        /// </summary>
        public string baseUrl { get; set; }

        public bool streaming {
            get { return _streaming; }
            set
            {
                _streaming = !Properties.Settings.Default.isTestStream ? value : true;
            }
        }       
        
        /// <summary>
        /// Ketword to locate timer element
        /// </summary>
        public string timerKeyword { get; set; }
        public DateTime endTime { get; internal set; }

        /// <summary>
        /// Volume of the control that is monitored for volume
        /// </summary>
        public decimal audioVolume { get; set; }
        public InputState timerState { get; set; }

        /// <summary>
        /// The active input to the output
        /// </summary>
        public Data.vmixInput activeInput { get; set; }

        public vMixHelper()
        {
            endTime = DateTime.Now;
            baseUrl = Properties.Settings.Default.vMixUrl;
            timerKeyword = Properties.Settings.Default.TimerKeyword;
            RefreshDoc();
            if(currentDoc != null)
            {
                onLine = true;
                SetTimerInfo();
            }
            else
            {
                onLine = false;
            }
        }

        private void SetTimerInfo()
        {
            vmixInput timerInput = null;
            foreach (var item in currentDoc.inputs)
            {
                if(item.title.Contains(timerKeyword))
                {
                    timerInput = item;
                }
            }

            if (timerInput != null)
            {
                if (timerInput.state == @enum.InputState.Running.ToString())
                {
                    timerState = @enum.InputState.Running;
                    endTime = DateTime.Now.AddMilliseconds(-(timerInput.duration - timerInput.position));
                }
                else
                {
                    timerState = @enum.InputState.Paused;
                    endTime = DateTime.Now;
                }
            }
            else
            {
                timerState = @enum.InputState.Missing;
                endTime = DateTime.Now;
            }
        }

        public async void  RefreshDoc()
        {
            Log.Debug("Refresh API Doc");
            currentDoc = await Task.Run(() => ApiDoc());
            if(currentDoc != null)
            {
                streaming = currentDoc.streaming == "True";
                var inputs = currentDoc.inputs.ToList<vmixInput>();
                activeInput = inputs.Find(i => i.number == currentDoc.active);
                try
                {
                    audioVolume = Properties.Settings.Default.IsMasterOutput ? currentDoc.audio.master.volume : inputs.Find(i => i.title.Contains(Properties.Settings.Default.AudiouInput)).volume;
                }
                catch(NullReferenceException ne)
                {
                    Log.Warning(ne, "Can't find the audio input check setup.");
                    audioVolume = -99;
                }
                SetTimerInfo();
            }
            Log.Debug("Done Refresh");
        }

        private vmix ApiDoc()
        {
            var settings = new XmlReaderSettings();
            var doc = new vmix();
            
            try
            {

                Log.Debug("Read API");
                var reader = XmlReader.Create(baseUrl + "/api", settings);
                Log.Debug("serialize");
                XmlSerializer serializer = new XmlSerializer(typeof(vmix));
                doc = (vmix)serializer.Deserialize(reader);
                onLine = true;
            }
            catch(Exception e)
            {
                doc = null;
                onLine = false;
                Log.Error(e, "Reader Error");
            }
            
           
            return doc;
        }
    }
}
