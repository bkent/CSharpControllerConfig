using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using Tamir.SharpSsh;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static string host, user, pass;
        public Form1()
        {
            InitializeComponent();
            //host = "192.168.0.128";
            user = "root";
            pass = "root";
            DefaultIP.Text = "10.0.1.230";
            DefaultGW.Text = "10.0.1.1";
            DefaultSN.Text = "255.255.255.0";
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (DefaultIP.Text == "" ||
                DefaultGW.Text == "" ||
                DefaultSN.Text == "" ||
                NewIP.Text == "" ||
                NewGW.Text == "" ||
                NewSN.Text == ""
                )
            {
                MessageBox.Show("All variables must have a value","Error");
                return;
            }
            
            host = DefaultIP.Text;

            string fileName = string.Empty;
            fileName = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(fileName);
            fileInfo.Attributes = FileAttributes.Temporary;

            string fullPath = Path.GetTempFileName();

            StreamWriter streamWriter = File.AppendText(fullPath);
            streamWriter.WriteLine(Properties.Resources.rc);
            streamWriter.Flush();
            streamWriter.Close();

            //MessageBox.Show(fullPath);

            string local = fullPath, remote = "disk/etc/rc";

            ReplaceInFile(local, "10.0.1.230", DefaultIP.Text);
            ReplaceInFile(local, "255.255.255.0", DefaultSN.Text);
            ReplaceInFile(local, "10.0.1.1", DefaultGW.Text);

            ReplaceInFile(local, DefaultIP.Text, NewIP.Text);
            ReplaceInFile(local, DefaultSN.Text, NewSN.Text);
            ReplaceInFile(local, DefaultGW.Text, NewGW.Text);
            try
            {
                Scp scp = new Scp();
                scp.To(local, host, remote, user, pass);
            }
            catch
            {
                string error = "Cannot connect to controller at " + DefaultIP.Text;
                MessageBox.Show(error, "Error");
                return;
            }
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }

            MessageBox.Show("You must reboot the controller for IP changes to take effect.", "Important");
        }

        /// <summary>
        /// Replaces text in a file.
        /// </summary>
        /// <param name="filePath">Path of the text file.</param>
        /// <param name="searchText">Text to search for.</param>
        /// <param name="replaceText">Text to replace the search text.</param>
        static public void ReplaceInFile(string filePath, string searchText, string replaceText)
        {
            StreamReader reader = new StreamReader(filePath);
            string content = reader.ReadToEnd();
            reader.Close();

            content = Regex.Replace(content, searchText, replaceText);

            StreamWriter writer = new StreamWriter(filePath);
            writer.Write(content);
            writer.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RebButton_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure you wish to reboot?", "Warning", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                host = DefaultIP.Text;
                SshStream ssh = new SshStream(host, user, pass);
                string command = "reboot";
                ssh.Write(command);
            }
        }

    }
}
