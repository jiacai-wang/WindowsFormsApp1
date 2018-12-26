using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		//两个不同的OpenFileDialog用来弹出选择文件的对话框，对应图片1和图片2
		OpenFileDialog pic1_fd = new OpenFileDialog();
		OpenFileDialog pic2_fd = new OpenFileDialog();

		public Form1()
		{
			InitializeComponent();
			pic1_fd.FileName = null;
			pic2_fd.FileName = null;
		}

		//计算file1和file2图片的相似度
		private void CalcPicSim(String file1, String file2)
		{
			label6.Visible = false;
			label7.Visible = false;
			label8.Visible = false;
			double sim1 = 0;
			double sim2 = 0;
			double sim3 = 0;
			progressBar1.Value = 0;
			progressBar1.Refresh();
			if (file1.Length >0 && file2.Length>0)
			{
				Bitmap bmp1 = new Bitmap(file1);
				Bitmap bmp2 = new Bitmap(file2);
				ulong[] GrayArray1 = new ulong[256];
				ulong[] GrayArray2 = new ulong[256];
				label5.Visible = true;
				label5.Text = "图1像素统计";
				label5.Refresh();
				GrayArray1 = CalcGrayArray(bmp1);
				progressBar1.Value = 33;
				label5.Text += "√\n图2像素统计";
				label5.Refresh();
				GrayArray2 = CalcGrayArray(bmp2);
				progressBar1.Value = 66;
				label5.Text += "√\n像素点数组相似度";
				label5.Refresh();
				sim1 = CalcSimBhat(GrayArray1, GrayArray2);
				progressBar1.Value = 77;
				progressBar1.Refresh();
				sim2 = CalcSimCos(GrayArray1, GrayArray2);
				progressBar1.Value = 88;
				progressBar1.Refresh();
				sim3 = CalcSimChannelBhat(bmp1, bmp2);
				progressBar1.Value = 100;
				progressBar1.Refresh();
				label5.Text += "√\n●计算完毕。";
				label5.Refresh();
				label6.Text = "灰度巴氏相似度：\n●" + ((int)(sim1 * 100)).ToString() + "%"+"\n两图片";
				if (sim1 >= 0.99) label6.Text += "相同";
				else if (sim1 > 0.95) label6.Text += "几乎一致";
				else if (sim1 > 0.8) label6.Text += "高度相似";
				else if (sim1 > 0.5) label6.Text += "略相似";
				else if (sim1 > 0.3) label6.Text += "可能相似";
				else label6.Text += "不相关";
				label6.Visible = true;
				label6.Refresh();

				label7.Text = "灰度余弦相似度：\n●" + ((int)(sim2 * 100)).ToString() + "%" + "\n两图片";
				if (sim2 >= 0.99) label7.Text += "相同";
				else if (sim2 > 0.95) label7.Text += "几乎一致";
				else if (sim2 > 0.8) label7.Text += "高度相似";
				else if (sim2 > 0.5) label7.Text += "略相似";
				else if (sim2 > 0.3) label7.Text += "可能相似";
				else label7.Text += "不相关";
				label7.Visible = true;
				label7.Refresh();

				label8.Text = "分通道余弦相似度：\n●" + ((int)(sim3 * 100)).ToString() + "%" + "\n两图片";
				if (sim3 >= 0.99) label8.Text += "相同";
				else if (sim3 > 0.95) label8.Text += "几乎一致";
				else if (sim3 > 0.8) label8.Text += "高度相似";
				else if (sim3 > 0.5) label8.Text += "略相似";
				else if (sim3 > 0.3) label8.Text += "可能相似";
				else label8.Text += "不相关";
				label8.Visible = true;
				label8.Refresh();
			}
			else MessageBox.Show("请选择图片");
		}

		//返回位图的灰度值数组
		//Gray = (R*299 + G*587 + B*114 + 500) / 1000
		//Gray = R*0.299 + G*0.587 + B*0.114
		private ulong[] CalcGrayArray(Bitmap bmp)
		{
			ulong[] GrayArray = new ulong[256];
			int Gray = 0;
			Color color = new Color();
			for (int x = 0; x < bmp.Width; x++)
			{
				for (int y = 0; y < bmp.Height; y++)
				{
					color = bmp.GetPixel(x, y);
					Gray = (color.R * 299 + color.G * 587 + color.B * 114 + 500) * color.A / 255000;
					//Gray = (color.R + color.G + color.B) / 3 * color.A / 255;
					if (Gray >= 0 && Gray < 256) GrayArray[Gray]++;
					else MessageBox.Show("r " + color.R + " g" + color.G + " b" + color.B + " a" + color.A + " Gray" + Gray, "数据错误");
				}
				if (x % (bmp.Width / 33)==0) progressBar1.Increment(1);
				progressBar1.Refresh();
			}
			return GrayArray;
		}

		//返回数组的相似度,巴氏系数法
		//D(p,q)=-ln(BC(p,q))
		//BC(p,q)=SUM{sqrt[p(x)q(x)]}
		private double CalcSimBhat(ulong[] array1, ulong[] array2)
		{
			double Similarity = 0;
			ulong sum1 = 0, sum2 = 0;
			for (int x = 0; x < array1.Length; x++)
			{
				sum1 += array1[x];
				sum2 += array2[x];
			}
			for (int x = 0; x < array1.Length; x++)
			{
				Similarity += Math.Sqrt((double)array1[x] / (double)sum1 * (double)array2[x] / (double)sum2);
			}
			return Similarity;
		}

		//返回数组的相似度，余弦相似度算法
		//cos(θ)=SUM(Xi*Yi)/(sqrt(SUM(Xi²))*(sqrt(SUM(Yi²))
		private double CalcSimCos(ulong[] array1, ulong[] array2)
		{
//			double Distance = 0;
			double Similarity = 0;
			double SumX2 = 0, SumY2 = 0, SumXY = 0;
			for (int i = 0; i < array1.Length; i++)
			{
				SumX2 += array1[i] * array1[i];
				SumY2 += array2[i] * array2[i];
				SumXY += array1[i] * array2[i];
			}
			//Distance = SumXY / (Math.Sqrt(SumX2) * Math.Sqrt(SumY2));
			//Similarity = Math.Pow(Math.E, -Distance);
			Similarity = SumXY / (Math.Sqrt(SumX2) * Math.Sqrt(SumY2));
			return Similarity;
		}


		//返回数组的相似度，分通道的巴氏距离相似度算法
		//D(p,q)=-ln(BC(p,q))
		//BC(p,q)=SUM{sqrt[p(x)q(x)]}
		private double CalcSimChannelBhat(Bitmap bmp1, Bitmap bmp2)
		{
			double Similarity = 0;
			ulong[] ColorArrayR1 = new ulong[256];
			ulong[] ColorArrayR2 = new ulong[256];
			ulong[] ColorArrayG1 = new ulong[256];
			ulong[] ColorArrayG2 = new ulong[256];
			ulong[] ColorArrayB1 = new ulong[256];
			ulong[] ColorArrayB2 = new ulong[256];
			int depthR = 0;
			int depthG = 0;
			int depthB = 0;
			Color color = new Color();
			for (int x = 0; x < bmp1.Width; x++)
			{
				for (int y = 0; y < bmp1.Height; y++)
				{
					color = bmp1.GetPixel(x, y);
					depthR = color.R * color.A / 255;
					depthG = color.G * color.A / 255;
					depthB = color.B * color.A / 255;
					if (depthR >= 0 && depthR < 256 && depthG >= 0 && depthG < 256 && depthB >= 0 && depthB < 256)
					{
						ColorArrayR1[depthR]++;
						ColorArrayG1[depthG]++;
						ColorArrayB1[depthB]++;
					}
					else MessageBox.Show("r " + color.R + " g" + color.G + " b" + color.B + " a" + color.A, "数据错误");
				}
				if (x % (bmp1.Width / 6) == 0) progressBar1.Increment(1);
			}
			for (int x = 0; x < bmp2.Width; x++)
			{
				for (int y = 0; y < bmp2.Height; y++)
				{
					color = bmp2.GetPixel(x, y);
					depthR = color.R * color.A / 255;
					depthG = color.G * color.A / 255;
					depthB = color.B * color.A / 255;
					if (depthR >= 0 && depthR < 256 && depthG >= 0 && depthG < 256 && depthB >= 0 && depthB < 256)
					{
						ColorArrayR2[depthR]++;
						ColorArrayG2[depthG]++;
						ColorArrayB2[depthB]++;
					}
					else MessageBox.Show("r " + color.R + " g" + color.G + " b" + color.B + " a" + color.A, "数据错误");
				}
				if (x % (bmp2.Width / 6) == 0) progressBar1.Increment(1);
				progressBar1.Refresh();
			}
			Similarity = Math.Max(CalcSimCos(ColorArrayR1, ColorArrayR2), Math.Max(CalcSimCos(ColorArrayG1, ColorArrayG2), CalcSimCos(ColorArrayB1, ColorArrayB2)));
//			MessageBox.Show(CalcSimCos(ColorArrayR1, ColorArrayR2) + "\n" + CalcSimCos(ColorArrayG1, ColorArrayG2) + "\n" + CalcSimCos(ColorArrayB1, ColorArrayB2));
			return Similarity;
		}


		//支持文件拖放功能
		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.All;
			else
				e.Effect = DragDropEffects.None;
		}

		//处理文件拖放事件
		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			//以下代码尝试将拖放事件的文件路径打开为图片，并更新到PictureBox2，同时刷新histogramBox2的直方图。打开失败则弹窗提示。
			string filePath = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
			try
			{
				pic2_fd.FileName = filePath;
				PictureBox2.ImageLocation = pic2_fd.FileName;
				//图片更新到PictureBox后隐藏提示label
				Label2.Visible = false;
				//清除历史直方图
				histogramBox2.ClearHistogram();
				//用Gray模式打开图片并以256为范围生成直方图
				histogramBox2.GenerateHistograms(new Image<Gray, Byte>(pic2_fd.FileName), 256);
				//更新到显示窗口
				histogramBox2.Refresh();
			}
			catch
			{
				MessageBox.Show("图片读入失败！", "警告：");
			}
		}

		//PictureBox1的点击事件，弹出选择文件窗口，过滤器设置为图片后缀
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			pic1_fd.Title = "选择第一张图像";
			pic1_fd.Filter = "图片(*.PNG; *.BMP; *.JPG; *.GIF); *.ICO| *.PNG; *.BMP; *.JPG; *.GIF;  *.ICO| All files(*.*) | *.*";
			if (pic1_fd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					PictureBox1.ImageLocation = pic1_fd.FileName;
					Label1.Visible = false;
					histogramBox1.ClearHistogram();
					histogramBox1.GenerateHistograms(new Image<Gray, Byte>(pic1_fd.FileName), 256);
					histogramBox1.Refresh();
				}
				catch
				{
					MessageBox.Show("图片读入失败！","警告：");
				}
			}
			pic1_fd.Dispose();
				
		}

		private void PictureBox2_Click(object sender, EventArgs e)
		{
			pic2_fd.Title = "选择第二张图像";
			pic2_fd.Filter = "图片(*.PNG; *.BMP; *.JPG; *.GIF); *.ICO| *.PNG; *.BMP; *.JPG; *.GIF;  *.ICO| All files(*.*) | *.*";
			if (pic2_fd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					PictureBox2.ImageLocation = pic2_fd.FileName;
					Label2.Visible = false;
					histogramBox2.ClearHistogram();
					histogramBox2.GenerateHistograms(new Image<Gray, Byte>(pic2_fd.FileName), 256);
					histogramBox2.Refresh();
				}
				catch
				{
					MessageBox.Show("图片读入失败！","警告：");
				}
			}
			pic2_fd.Dispose();
		}

		//Label的点击事件由PictureBox点击事件处理
		private void Label1_Click(object sender, EventArgs e)
		{
			PictureBox1_Click(sender,e);
		}

		private void Label2_Click(object sender, EventArgs e)
		{
			PictureBox2_Click(sender, e);
		}

		private void 使用帮助ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("※ 点击以选择图片1和图片2，程序会自动计算两张图片的相似度。\n※ 再次点击可更换待对比的图片。\n※ 拖放操作将自动替换图片2。");
		}

		private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("王家才 Email: jiacai_wang@qq.com\n王思杭 Email: 582284712@qq.com", "关于作者：");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			CalcPicSim(pic1_fd.FileName, pic2_fd.FileName);
		}
	}
}
