using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibVLCSharp.Shared;
using Microsoft.Win32;

namespace VideoScreensaver
{
    public partial class ScreenSaverForm : Form
    {
        public Point mousePos; //Declare Mouse Position variable

        public LibVLC _libvlc;
        public MediaPlayer _player;
        public Media media;

        public ScreenSaverForm(Rectangle Bounds)
        {
            InitializeComponent();
            this.Bounds = Bounds;

            //VLC and video initial
            Core.Initialize();
            _libvlc = new LibVLC("--input-repeat=2");
            _player = new MediaPlayer(_libvlc);
            videoView1.MediaPlayer = _player;
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            TopMost = true;

            string fileName = "";

            //Load the media filepath
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\VideoScreensaver");
            if (key == null)
            {

            }
            else
            {
                fileName = (string)key.GetValue("FilePath");
            }

            // Autoplay video
            _player.Play(new Media(_libvlc, fileName));
 
        }

        // Exit Screensaver when imout from the user is received
        private void videoView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mousePos.IsEmpty)
            {
                // Terminate if mouse is moved a significant distance
                if (Math.Abs(mousePos.X - e.X) > 5 ||
                    Math.Abs(mousePos.Y - e.Y) > 5)
                    Application.Exit();
            }

            // Update current mouse location
            mousePos = e.Location;
        }

        private void videoView1_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }

        private void videoView1_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}
