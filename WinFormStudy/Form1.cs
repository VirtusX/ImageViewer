using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormStudy {
    public partial class MainForm:Form {
        Point MouseMovement;
        Image img;
        public MainForm(string[] args = null) {
            InitializeComponent();
            if(args.Length>0) {
                img = Image.FromFile(args[0]);
                ImageView.Image = img;
                if(img.Height < 600)
                    Height = img.Height + 25;
                if(img.Width < 1200)
                    Width = img.Width;
                if(img.Height > 600 && img.Width > 1200) {
                    Width = 1200;
                    Height = 600;
                    ImageView.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                else
                    ImageView.SizeMode = PictureBoxSizeMode.Normal;
                Rotate.Visible = true;
                }
            }
        

        private void button2_Click(object sender, EventArgs e) {
            Close();
            }

        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            MouseMovement = new Point(e.X, e.Y);
            }

        private void panel1_MouseMove(object sender, MouseEventArgs e) {
            if((e.Button & MouseButtons.Left)!=0) {
                Point delta = new Point(e.X - MouseMovement.X, e.Y - MouseMovement.Y);
                Location = new Point(Location.X + delta.X, Location.Y + delta.Y);
                }
            }

        private void button3_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg";
            if(ofd.ShowDialog() == DialogResult.Cancel)
                return;
            img = Image.FromFile(ofd.FileName);
            ImageView.Image = img;
            if(img.Height < 600)
                Height = img.Height + 25;
            if(img.Width < 1200)
                Width = img.Width;
            if(img.Height > 600 && img.Width > 1200) {
                Width = 1200;
                Height = 600;
                ImageView.SizeMode = PictureBoxSizeMode.Zoom;
                }
            else
                ImageView.SizeMode = PictureBoxSizeMode.Normal;
            Rotate.Visible = true;
            }

        private void button4_Click(object sender, EventArgs e) {
            if(WindowState == FormWindowState.Normal) {
                WindowState = FormWindowState.Maximized;
                Maximize.BackgroundImage = Properties.Resources._320_5121;
                }
            else {
                WindowState = FormWindowState.Normal;
                Maximize.BackgroundImage = Properties.Resources.minicons2_33_5121;
                }
            }

        private void Rotate_Click(object sender, EventArgs e) {
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            ImageView.Image = img;
            var wfactor = (double)img.Width / ImageView.ClientSize.Width;
            var hfactor = (double)img.Height / ImageView.ClientSize.Height;
            var resizeFactor = Math.Max(wfactor, hfactor);
            var imageSize = (int)(img.Width / resizeFactor);
            if(ImageView.Image.Width < ImageView.Image.Height)
                Width = imageSize;
            else
                Width = img.Height;
            }

        private void ProgramName_MouseDown(object sender, MouseEventArgs e) {
            MouseMovement = new Point(e.X, e.Y);
            }

        private void ProgramName_MouseMove(object sender, MouseEventArgs e) {
            if((e.Button & MouseButtons.Left) != 0) {
                Point delta = new Point(e.X - MouseMovement.X, e.Y - MouseMovement.Y);
                Location = new Point(Location.X + delta.X, Location.Y + delta.Y);
                }
            }
        }
    }
