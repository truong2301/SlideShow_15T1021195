namespace SlideShow
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.button1 = new System.Windows.Forms.Button();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hscrollBall = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // picMain
            // 
            this.picMain.Image = global::SlideShow.Properties.Resources._1;
            this.picMain.Location = new System.Drawing.Point(223, 12);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(269, 294);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 1;
            this.picMain.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(188, 34);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(65, 76);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 2;
            this.pic2.TabStop = false;
            this.pic2.Click += new System.EventHandler(this.Pic2_Click);
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(281, 14);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(100, 115);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            this.pic3.Click += new System.EventHandler(this.Pic3_Click);
            this.pic3.DragLeave += new System.EventHandler(this.Pic3_DragLeave);
            // 
            // pic4
            // 
            this.pic4.Location = new System.Drawing.Point(404, 34);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(65, 76);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic4.TabIndex = 2;
            this.pic4.TabStop = false;
            this.pic4.Click += new System.EventHandler(this.Pic4_Click);
            // 
            // pic5
            // 
            this.pic5.Location = new System.Drawing.Point(487, 34);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(65, 76);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic5.TabIndex = 2;
            this.pic5.TabStop = false;
            this.pic5.Click += new System.EventHandler(this.Pic5_Click);
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(103, 34);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(65, 76);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 2;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.Pic1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hscrollBall);
            this.panel1.Controls.Add(this.pic3);
            this.panel1.Controls.Add(this.pic2);
            this.panel1.Controls.Add(this.pic5);
            this.panel1.Controls.Add(this.pic1);
            this.panel1.Controls.Add(this.pic4);
            this.panel1.Location = new System.Drawing.Point(23, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 170);
            this.panel1.TabIndex = 3;
            // 
            // hscrollBall
            // 
            this.hscrollBall.Location = new System.Drawing.Point(103, 132);
            this.hscrollBall.Name = "hscrollBall";
            this.hscrollBall.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hscrollBall.Size = new System.Drawing.Size(449, 10);
            this.hscrollBall.TabIndex = 3;
            this.hscrollBall.Value = 50;
            this.hscrollBall.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HscrollBall_Scroll);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slide Show Image  _ 15T1021195 Tran Cong Truong (Auto SMY)";
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar hscrollBall;
    }
}

