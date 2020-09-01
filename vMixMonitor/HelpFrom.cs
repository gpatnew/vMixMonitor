using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vMixMonitor
{
     class  HelpFrom
    {
        Form form1 = new Form();
        public void CreateForm()
        {
            // Create a new instance of the form.
            
            form1.Height = 600;
            form1.Width = 1000;
            // Create two buttons to use as the accept and cancel buttons.
            Button button1 = new Button();
            button1.Click += Button1_Click;
            TextBox helpText = new TextBox();

            helpText.Text = ReadHelpDoc();
            helpText.ScrollBars = ScrollBars.Vertical;
            helpText.Width = form1.Width - 40;
            helpText.Height = form1.Height - 160;
            helpText.Location = new Point(20, 20);
            helpText.Multiline = true;
            // Set the text of button1 to "OK".
            button1.Text = "OK";
        
            // Set the position of the button on the form.
            button1.Location = new Point(580, 500);
            // Set the text of button2 to "Cancel".
            
            // Set the caption bar text of the form.   
            form1.Text = "Help";
            // Display a help button on the form.
            form1.HelpButton = true;

            // Define the border style of the form to a dialog box.
            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            form1.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            form1.MinimizeBox = false;
            // Set the accept button of the form to button1.
            form1.AcceptButton = button1;
            
            // Set the start position of the form to the center of the screen.
            form1.StartPosition = FormStartPosition.CenterScreen;

            // Add button1 to the form.
            form1.Controls.Add(button1);
            // Add button2 to the form.
            form1.Controls.Add(helpText);
            
            // Display the form as a modal dialog box.
            form1.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            form1.Close();
        }

        private string ReadHelpDoc()
        {
            var dirPath = string.Format(@"{0}\help\instructions.txt", AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("\\bin")));
            string helpContent = System.IO.File.ReadAllText(dirPath); ;
            return helpContent;
        }
    }
}
