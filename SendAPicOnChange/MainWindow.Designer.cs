namespace SendAPicOnChange
{
    partial class MainWindow
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
            this.trackTolerance = new System.Windows.Forms.TrackBar();
            this.tbTolerance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAccuracy = new System.Windows.Forms.TextBox();
            this.trackAccuracy = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.CheckForChange = new System.Windows.Forms.Timer(this.components);
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.lbTimestamp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackAccuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackTolerance
            // 
            this.trackTolerance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackTolerance.Location = new System.Drawing.Point(15, 28);
            this.trackTolerance.Maximum = 128;
            this.trackTolerance.MaximumSize = new System.Drawing.Size(217, 45);
            this.trackTolerance.MinimumSize = new System.Drawing.Size(217, 45);
            this.trackTolerance.Name = "trackTolerance";
            this.trackTolerance.Size = new System.Drawing.Size(217, 45);
            this.trackTolerance.TabIndex = 0;
            this.trackTolerance.ValueChanged += new System.EventHandler(this.trackTolerance_ValueChanged);
            // 
            // tbTolerance
            // 
            this.tbTolerance.Location = new System.Drawing.Point(73, 2);
            this.tbTolerance.Name = "tbTolerance";
            this.tbTolerance.Size = new System.Drawing.Size(39, 20);
            this.tbTolerance.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tolerance";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 470);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Accuracy";
            // 
            // tbAccuracy
            // 
            this.tbAccuracy.Location = new System.Drawing.Point(293, 2);
            this.tbAccuracy.Name = "tbAccuracy";
            this.tbAccuracy.Size = new System.Drawing.Size(39, 20);
            this.tbAccuracy.TabIndex = 5;
            // 
            // trackAccuracy
            // 
            this.trackAccuracy.Location = new System.Drawing.Point(238, 28);
            this.trackAccuracy.Maximum = 100;
            this.trackAccuracy.MaximumSize = new System.Drawing.Size(217, 45);
            this.trackAccuracy.Minimum = 1;
            this.trackAccuracy.MinimumSize = new System.Drawing.Size(217, 45);
            this.trackAccuracy.Name = "trackAccuracy";
            this.trackAccuracy.Size = new System.Drawing.Size(217, 45);
            this.trackAccuracy.TabIndex = 4;
            this.trackAccuracy.Value = 50;
            this.trackAccuracy.ValueChanged += new System.EventHandler(this.trackAccuracy_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(458, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Framerate";
            this.label4.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(516, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(461, 28);
            this.trackBar1.Maximum = 30;
            this.trackBar1.MaximumSize = new System.Drawing.Size(217, 45);
            this.trackBar1.Minimum = 1;
            this.trackBar1.MinimumSize = new System.Drawing.Size(217, 45);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(217, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 1;
            this.trackBar1.Visible = false;
            // 
            // CheckForChange
            // 
            this.CheckForChange.Interval = 5000;
            this.CheckForChange.Tick += new System.EventHandler(this.CheckForChange_Tick);
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Location = new System.Drawing.Point(797, 2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 11;
            this.btStart.Text = "&Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStop.Location = new System.Drawing.Point(797, 31);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 11;
            this.btStop.Text = "Sto&p";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // lbTimestamp
            // 
            this.lbTimestamp.Location = new System.Drawing.Point(797, 57);
            this.lbTimestamp.Name = "lbTimestamp";
            this.lbTimestamp.Size = new System.Drawing.Size(75, 16);
            this.lbTimestamp.TabIndex = 12;
            this.lbTimestamp.Text = "--:--:--";
            this.lbTimestamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lbTimestamp);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAccuracy);
            this.Controls.Add(this.trackAccuracy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTolerance);
            this.Controls.Add(this.trackTolerance);
            this.Name = "Form1";
            this.Text = "CamSpammer";
            ((System.ComponentModel.ISupportInitialize)(this.trackTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackAccuracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackTolerance;
        private System.Windows.Forms.TextBox tbTolerance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAccuracy;
        private System.Windows.Forms.TrackBar trackAccuracy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer CheckForChange;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label lbTimestamp;
    }
}

