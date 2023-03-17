namespace CellGen.GUI
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            interval = new TrackBar();
            resol = new NumericUpDown();
            ClearBtn = new Button();
            RandomBtn = new Button();
            StopBtn = new Button();
            StartBtn = new Button();
            Ginput = new TextBox();
            Sinput = new TextBox();
            Binput = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            FieldBitmap = new PictureBox();
            Timer = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            GenText = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)interval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FieldBitmap).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(65, 53, 67);
            splitContainer1.Panel1.Controls.Add(GenText);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(interval);
            splitContainer1.Panel1.Controls.Add(resol);
            splitContainer1.Panel1.Controls.Add(ClearBtn);
            splitContainer1.Panel1.Controls.Add(RandomBtn);
            splitContainer1.Panel1.Controls.Add(StopBtn);
            splitContainer1.Panel1.Controls.Add(StartBtn);
            splitContainer1.Panel1.Controls.Add(Ginput);
            splitContainer1.Panel1.Controls.Add(Sinput);
            splitContainer1.Panel1.Controls.Add(Binput);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(FieldBitmap);
            splitContainer1.Size = new Size(2152, 1145);
            splitContainer1.SplitterDistance = 62;
            splitContainer1.TabIndex = 0;
            // 
            // interval
            // 
            interval.Location = new Point(1664, 12);
            interval.Maximum = 500;
            interval.Minimum = 10;
            interval.Name = "interval";
            interval.Size = new Size(208, 90);
            interval.TabIndex = 6;
            interval.Value = 50;
            interval.ValueChanged += interval_ValueChanged;
            // 
            // resol
            // 
            resol.Location = new Point(1400, 14);
            resol.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            resol.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            resol.Name = "resol";
            resol.Size = new Size(240, 39);
            resol.TabIndex = 5;
            resol.Value = new decimal(new int[] { 15, 0, 0, 0 });
            resol.ValueChanged += resol_ValueChanged;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(1229, 15);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(150, 39);
            ClearBtn.TabIndex = 4;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // RandomBtn
            // 
            RandomBtn.Location = new Point(1073, 15);
            RandomBtn.Name = "RandomBtn";
            RandomBtn.Size = new Size(150, 39);
            RandomBtn.TabIndex = 4;
            RandomBtn.Text = "Random";
            RandomBtn.UseVisualStyleBackColor = true;
            RandomBtn.Click += RandomBtn_Click;
            // 
            // StopBtn
            // 
            StopBtn.Location = new Point(917, 15);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(150, 39);
            StopBtn.TabIndex = 4;
            StopBtn.Text = "Stop";
            StopBtn.UseVisualStyleBackColor = true;
            StopBtn.Click += StopBtn_Click;
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(761, 15);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(150, 39);
            StartBtn.TabIndex = 4;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // Ginput
            // 
            Ginput.Location = new Point(527, 15);
            Ginput.Name = "Ginput";
            Ginput.Size = new Size(200, 39);
            Ginput.TabIndex = 3;
            Ginput.Text = "2";
            // 
            // Sinput
            // 
            Sinput.Location = new Point(285, 13);
            Sinput.Name = "Sinput";
            Sinput.Size = new Size(200, 39);
            Sinput.TabIndex = 2;
            Sinput.Text = "23";
            // 
            // Binput
            // 
            Binput.Location = new Point(46, 12);
            Binput.Name = "Binput";
            Binput.Size = new Size(200, 39);
            Binput.TabIndex = 1;
            Binput.Text = "3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(491, 15);
            label3.Name = "label3";
            label3.Size = new Size(30, 32);
            label3.TabIndex = 0;
            label3.Text = "G";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(252, 15);
            label2.Name = "label2";
            label2.Size = new Size(27, 32);
            label2.TabIndex = 0;
            label2.Text = "S";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(28, 32);
            label1.TabIndex = 0;
            label1.Text = "B";
            // 
            // FieldBitmap
            // 
            FieldBitmap.BackColor = Color.FromArgb(45, 39, 39);
            FieldBitmap.Dock = DockStyle.Fill;
            FieldBitmap.Location = new Point(0, 0);
            FieldBitmap.Name = "FieldBitmap";
            FieldBitmap.Size = new Size(2152, 1079);
            FieldBitmap.SizeMode = PictureBoxSizeMode.StretchImage;
            FieldBitmap.TabIndex = 0;
            FieldBitmap.TabStop = false;
            FieldBitmap.MouseDown += MouseDraw;
            FieldBitmap.MouseMove += MouseDraw;
            // 
            // Timer
            // 
            Timer.Interval = 1;
            Timer.Tick += Timer_Tick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(1878, 15);
            label4.Name = "label4";
            label4.Size = new Size(62, 32);
            label4.TabIndex = 1;
            label4.Text = "Gen:";
            // 
            // GenText
            // 
            GenText.AutoSize = true;
            GenText.ForeColor = SystemColors.ControlLightLight;
            GenText.Location = new Point(1946, 16);
            GenText.Name = "GenText";
            GenText.Size = new Size(27, 32);
            GenText.TabIndex = 7;
            GenText.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(2152, 1145);
            Controls.Add(splitContainer1);
            Name = "MainForm";
            Text = "CellGen";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)interval).EndInit();
            ((System.ComponentModel.ISupportInitialize)resol).EndInit();
            ((System.ComponentModel.ISupportInitialize)FieldBitmap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox FieldBitmap;
        private TextBox Ginput;
        private TextBox Sinput;
        private TextBox Binput;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button ClearBtn;
        private Button RandomBtn;
        private Button StopBtn;
        private Button StartBtn;
        private System.Windows.Forms.Timer Timer;
        private TrackBar interval;
        private NumericUpDown resol;
        private Label GenText;
        private Label label4;
    }
}