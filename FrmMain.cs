using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideShow
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public string Path { get; set; }
        public bool IsStop { get; set; }

        private int numImage { get; set; }
        List<string> ls_Image = new List<string>();
        int dem = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            IsStop = true;
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    Path = folderBrowserDialog.SelectedPath;
                    string[] directories = Directory.GetFiles(Path);
                    if (directories.Length == 0)
                    {
                        MessageBox.Show("Không có ảnh", "Thông Báo!", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        foreach (string item in directories)
                        {
                            if (item.Contains(".png"))
                            {
                                ls_Image.Add(item);
                            }
                        }
                        Run();
                    }

                }
            }
        }
        private void Run()
        {
            if (ls_Image.Count == 0)
            {
                MessageBox.Show("Không có ảnh", "Thông Báo!", MessageBoxButtons.OK);
            }
            else
            {
                numImage = ls_Image.Count;
                picMain.Image = Image.FromFile(ls_Image[0]);
                ShowImage();
            }
        }
        private void ShowImage()
        {
            Thread thread = new Thread(() =>
            {
                while (IsStop)
                {
                    picMain.Image = Image.FromFile(ls_Image[dem]);
                    pic3.Image = Image.FromFile(ls_Image[dem]);

                    Thread.Sleep(3000);
                    dem++;
                    if (dem == numImage)
                    {
                        dem = 0;
                    }
                    if (dem > 0 && ls_Image.Count > 3)
                    {
                        pic2.Image = Image.FromFile(ls_Image[dem - 1]);
                    }
                    if (dem > 1)
                    {
                        pic1.Image = Image.FromFile(ls_Image[dem - 2]);

                    }
                    if (dem <= ls_Image.Count - 3)
                    {
                        pic4.Image = Image.FromFile(ls_Image[dem + 1]);
                        pic5.Image = Image.FromFile(ls_Image[dem + 2]);
                    }
                    else
                    {
                        pic4.Image = Image.FromFile(ls_Image[0]);
                        pic5.Image = Image.FromFile(ls_Image[1]);
                    }


                }
            });
            thread.Start();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Pic3_Click(object sender, EventArgs e)
        {
            Image image = pic3.Image;
            picMain.Image = image;
        }

        private void Pic1_Click(object sender, EventArgs e)
        {
            Image image = pic1.Image;
            picMain.Image = image;
        }

        private void Pic2_Click(object sender, EventArgs e)
        {
            Image image = pic2.Image;
            picMain.Image = image;

        }

        private void Pic4_Click(object sender, EventArgs e)
        {
            Image image = pic4.Image;
            picMain.Image = image;

        }

        private void Pic5_Click(object sender, EventArgs e)
        {
            Image image = pic5.Image;
            picMain.Image = image;
        }

        private void HscrollBall_Scroll(object sender, ScrollEventArgs e)
        {
            if (hscrollBall.Value > 0 && hscrollBall.Value <20)
            {
                Image image = pic5.Image;
                picMain.Image = image;
            }
            if (hscrollBall.Value > 20 && hscrollBall.Value < 40)
            {
                Image image = pic4.Image;
                picMain.Image = image;
            }
            if (hscrollBall.Value > 40 && hscrollBall.Value < 60)
            {
                Image image = pic3.Image;
                picMain.Image = image;
            }
            if (hscrollBall.Value > 60 && hscrollBall.Value < 80)
            {
                Image image = pic2.Image;
                picMain.Image = image;
            }
            if (hscrollBall.Value > 80 && hscrollBall.Value < 100)
            {
                Image image = pic1.Image;
                picMain.Image = image;
            }
        }
        private void LoadClick()
        {

        }
        private void Pic3_DragLeave(object sender, EventArgs e)
        {

        }
    }
}
