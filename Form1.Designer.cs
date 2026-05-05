namespace Game_of_live
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NextStephandle = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.LoopTriger = new System.Windows.Forms.Button();
            this.SpeedSlider = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // NextStephandle
            // 
            this.NextStephandle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextStephandle.BackColor = System.Drawing.Color.White;
            this.NextStephandle.Location = new System.Drawing.Point(917, 16);
            this.NextStephandle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NextStephandle.Name = "NextStephandle";
            this.NextStephandle.Size = new System.Drawing.Size(96, 31);
            this.NextStephandle.TabIndex = 0;
            this.NextStephandle.Tag = "1";
            this.NextStephandle.Text = "Step";
            this.NextStephandle.UseVisualStyleBackColor = false;
            this.NextStephandle.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(945, 89);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(18, 20);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "No life!";
            // 
            // LoopTriger
            // 
            this.LoopTriger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoopTriger.BackColor = System.Drawing.Color.White;
            this.LoopTriger.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LoopTriger.FlatAppearance.BorderSize = 0;
            this.LoopTriger.ForeColor = System.Drawing.Color.Black;
            this.LoopTriger.Location = new System.Drawing.Point(917, 55);
            this.LoopTriger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoopTriger.Name = "LoopTriger";
            this.LoopTriger.Size = new System.Drawing.Size(96, 31);
            this.LoopTriger.TabIndex = 2;
            this.LoopTriger.Tag = "1";
            this.LoopTriger.Text = "Start";
            this.LoopTriger.UseVisualStyleBackColor = false;
            this.LoopTriger.Click += new System.EventHandler(this.button2_Click);
            // 
            // SpeedSlider
            // 
            this.SpeedSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedSlider.Location = new System.Drawing.Point(773, 16);
            this.SpeedSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SpeedSlider.Maximum = Constants.MAX_DELAY;
            this.SpeedSlider.Minimum = Constants.MIN_DELAY;
            this.SpeedSlider.Name = "SpeedSlider";
            this.SpeedSlider.Size = new System.Drawing.Size(136, 69);
            this.SpeedSlider.TabIndex = 3;
            this.SpeedSlider.TickFrequency = 50;
            this.SpeedSlider.Value = Constants.DEFAULT_DELAY;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 600);
            this.Controls.Add(this.SpeedSlider);
            this.Controls.Add(this.LoopTriger);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.NextStephandle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextStephandle;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button LoopTriger;
        private System.Windows.Forms.TrackBar SpeedSlider;
    }
}
