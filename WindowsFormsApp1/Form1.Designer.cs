namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.PictureBox2 = new System.Windows.Forms.PictureBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
			this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.使用帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// PictureBox1
			// 
			this.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.PictureBox1.Location = new System.Drawing.Point(12, 39);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(256, 256);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			this.PictureBox1.WaitOnLoad = true;
			this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
			// 
			// PictureBox2
			// 
			this.PictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.PictureBox2.Location = new System.Drawing.Point(12, 301);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new System.Drawing.Size(256, 256);
			this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox2.TabIndex = 0;
			this.PictureBox2.TabStop = false;
			this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Label1.Location = new System.Drawing.Point(88, 160);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(105, 15);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "点击选择图片1";
			this.Label1.Click += new System.EventHandler(this.Label1_Click);
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Label2.Location = new System.Drawing.Point(88, 422);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(105, 15);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "点击选择图片2";
			this.Label2.Click += new System.EventHandler(this.Label2_Click);
			// 
			// histogramBox1
			// 
			this.histogramBox1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.histogramBox1.Location = new System.Drawing.Point(329, 39);
			this.histogramBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.histogramBox1.Name = "histogramBox1";
			this.histogramBox1.Size = new System.Drawing.Size(513, 234);
			this.histogramBox1.TabIndex = 5;
			// 
			// histogramBox2
			// 
			this.histogramBox2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.histogramBox2.Location = new System.Drawing.Point(329, 301);
			this.histogramBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.histogramBox2.Name = "histogramBox2";
			this.histogramBox2.Size = new System.Drawing.Size(513, 234);
			this.histogramBox2.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(525, 276);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "图片1灰度直方图";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(525, 538);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "图片2灰度直方图";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1061, 28);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 帮助ToolStripMenuItem
			// 
			this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
			this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
			this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
			this.帮助ToolStripMenuItem.Text = "帮助";
			// 
			// 使用帮助ToolStripMenuItem
			// 
			this.使用帮助ToolStripMenuItem.Name = "使用帮助ToolStripMenuItem";
			this.使用帮助ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
			this.使用帮助ToolStripMenuItem.Text = "使用帮助";
			this.使用帮助ToolStripMenuItem.Click += new System.EventHandler(this.使用帮助ToolStripMenuItem_Click);
			// 
			// 关于ToolStripMenuItem
			// 
			this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
			this.关于ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
			this.关于ToolStripMenuItem.Text = "关于";
			this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(919, 479);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(130, 56);
			this.button1.TabIndex = 9;
			this.button1.Text = "计算相似度";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(875, 108);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(174, 23);
			this.progressBar1.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(872, 134);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 15);
			this.label5.TabIndex = 11;
			this.label5.Text = "点击开始计算";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(871, 218);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "label6";
			this.label6.Visible = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(871, 296);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 20);
			this.label7.TabIndex = 12;
			this.label7.Text = "label7";
			this.label7.Visible = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label8.Location = new System.Drawing.Point(871, 374);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 20);
			this.label8.TabIndex = 12;
			this.label8.Text = "label8";
			this.label8.Visible = false;
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1061, 569);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.histogramBox2);
			this.Controls.Add(this.histogramBox1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.PictureBox2);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "图像相似度";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private Emgu.CV.UI.HistogramBox histogramBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 使用帮助ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
	}
}

