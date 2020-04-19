namespace FloatingBit
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.closeLabel = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.CountDownLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeLabel
            // 
            resources.ApplyResources(this.closeLabel, "closeLabel");
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // hourLabel
            // 
            resources.ApplyResources(this.hourLabel, "hourLabel");
            this.hourLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hourLabel.Name = "hourLabel";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Name = "label4";
            // 
            // minutesLabel
            // 
            resources.ApplyResources(this.minutesLabel, "minutesLabel");
            this.minutesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minutesLabel.Name = "minutesLabel";
            // 
            // CountDownLabel
            // 
            resources.ApplyResources(this.CountDownLabel, "CountDownLabel");
            this.CountDownLabel.Name = "CountDownLabel";
            this.CountDownLabel.Click += new System.EventHandler(this.CountDownLabel_Click);
            // 
            // TimeLabel
            // 
            resources.ApplyResources(this.TimeLabel, "TimeLabel");
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // secondsLabel
            // 
            resources.ApplyResources(this.secondsLabel, "secondsLabel");
            this.secondsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.secondsLabel.Name = "secondsLabel";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FloatingBit.Properties.Resources.alarm;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.CountDownLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.closeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label CountDownLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

