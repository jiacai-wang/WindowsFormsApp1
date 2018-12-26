using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog pic1_fd = new OpenFileDialog();
            pic1_fd.Title = "选择第一张图像";
            pic1_fd.Filter = "图片(*.PNG; *.BMP; *.JPG; *.GIF)| *.PNG; *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";
            if (pic1_fd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = pic1_fd.FileName;
                label1.Visible = false;
            }
            pic1_fd.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog pic2_fd = new OpenFileDialog();
            pic2_fd.Title = "选择第二张图像";
            pic2_fd.Filter = "图片(*.PNG; *.BMP; *.JPG; *.GIF)| *.PNG; *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";
            if (pic2_fd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = pic2_fd.FileName;
                label2.Visible = false;
            }
            pic2_fd.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog pic1_fd = new OpenFileDialog();
            pic1_fd.Title = "选择第一张图像";
            pic1_fd.Filter = "图片(*.PNG; *.BMP; *.JPG; *.GIF)| *.PNG; *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";
            if (pic1_fd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = pic1_fd.FileName;
                label1.Visible = false;
            }
            pic1_fd.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog pic2_fd = new OpenFileDialog();
            pic2_fd.Title = "选择第二张图像";
            pic2_fd.Filter = "图片(*.PNG; *.BMP; *.JPG; *.GIF)| *.PNG; *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";
            if (pic2_fd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = pic2_fd.FileName;
                label2.Visible = false;
            }
            pic2_fd.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender,e);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pictureBox2_Click(sender, e);
        }
    }
}
