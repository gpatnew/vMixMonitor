using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vMixMonitor
{
    public sealed class SingleInstance
    {
        public static bool AlreadyRunning()
        {
            bool isRunning = false;

            try
            {
                Process currentProcess = Process.GetCurrentProcess();

                foreach (var p in Process.GetProcesses())
                {
                    if (p.Id != currentProcess.Id)
                    {
                        if (p.Id != currentProcess.Id) // Check running process   
                        {
                            if (p.ProcessName.Equals(currentProcess.ProcessName) == true)
                            {
                                isRunning = true;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error(e, "error");
            }
            return isRunning;
        }
           
    }
}
