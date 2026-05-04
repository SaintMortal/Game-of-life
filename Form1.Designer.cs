
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
            this.NextStephandle.Location = new System.Drawing.Point(713, 12);
            this.NextStephandle.Name = "NextStephandle";
            this.NextStephandle.Size = new System.Drawing.Size(75, 23);
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
            this.ScoreLabel.Location = new System.Drawing.Point(735, 67);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(13, 15);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "0";
            this.ScoreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoopTriger
            // 
            this.LoopTriger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoopTriger.BackColor = System.Drawing.Color.White;
            this.LoopTriger.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LoopTriger.FlatAppearance.BorderSize = 0;
            this.LoopTriger.ForeColor = System.Drawing.Color.Black;
            this.LoopTriger.Location = new System.Drawing.Point(713, 41);
            this.LoopTriger.Name = "LoopTriger";
            this.LoopTriger.Size = new System.Drawing.Size(75, 23);
            this.LoopTriger.TabIndex = 2;
            this.LoopTriger.Tag = "1";
            this.LoopTriger.Text = "Loop";
            this.LoopTriger.UseVisualStyleBackColor = false;
            this.LoopTriger.Click += new System.EventHandler(this.button2_Click);
            // 
            // SpeedSlider
            // 
            this.SpeedSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedSlider.Location = new System.Drawing.Point(601, 12);
            this.SpeedSlider.Maximum = 1000;
            this.SpeedSlider.Minimum = 50;
            this.SpeedSlider.Name = "SpeedSlider";
            this.SpeedSlider.Size = new System.Drawing.Size(106, 45);
            this.SpeedSlider.TabIndex = 3;
            this.SpeedSlider.TickFrequency = 50;
            this.SpeedSlider.Value = 50;
            this.SpeedSlider.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpeedSlider);
            this.Controls.Add(this.LoopTriger);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.NextStephandle);
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
