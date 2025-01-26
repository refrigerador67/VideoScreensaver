using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VideoScreensaver
{
    public partial class ConfigForm: Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void SaveConfig()
        {
            // Create or get existing Registry subkey
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\VideoScreensaver");
            key.SetValue("FilePath", fileTextBox.Text); // Set value to the textbox

            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fileTextBox.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\VideoScreensaver");
            fileTextBox.Text = (string)key.GetValue("FilePath");
        }
    }
}
