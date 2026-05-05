using System;

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
            this.CloseOpenPanelHandle = new System.Windows.Forms.Button();
            this.UiConteiner = new System.Windows.Forms.Panel();
            this.LoopTriger = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.SpeedSlider = new System.Windows.Forms.TrackBar();
            this.NextStephandle = new System.Windows.Forms.Button();
            this.ResetHandle = new System.Windows.Forms.Button();
            this.UiConteiner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseOpenPanelHandle
            // 
            this.CloseOpenPanelHandle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseOpenPanelHandle.Location = new System.Drawing.Point(972, 7);
            this.CloseOpenPanelHandle.Name = "CloseOpenPanelHandle";
            this.CloseOpenPanelHandle.Size = new System.Drawing.Size(46, 38);
            this.CloseOpenPanelHandle.TabIndex = 5;
            this.CloseOpenPanelHandle.Text = "X\r\n";
            this.CloseOpenPanelHandle.UseVisualStyleBackColor = true;
            this.CloseOpenPanelHandle.Click += new System.EventHandler(this.CloseOpenPanelHandle_Click);
            // 
            // UiConteiner
            // 
            this.UiConteiner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UiConteiner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UiConteiner.Controls.Add(this.ResetHandle);
            this.UiConteiner.Controls.Add(this.NextStephandle);
            this.UiConteiner.Controls.Add(this.SpeedSlider);
            this.UiConteiner.Controls.Add(this.ScoreLabel);
            this.UiConteiner.Controls.Add(this.LoopTriger);
            this.UiConteiner.Location = new System.Drawing.Point(834, 51);
            this.UiConteiner.Name = "UiConteiner";
            this.UiConteiner.Size = new System.Drawing.Size(184, 119);
            this.UiConteiner.TabIndex = 5;
            this.UiConteiner.Visible = false;
            // 
            // LoopTriger
            // 
            this.LoopTriger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoopTriger.BackColor = System.Drawing.Color.White;
            this.LoopTriger.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LoopTriger.FlatAppearance.BorderSize = 0;
            this.LoopTriger.ForeColor = System.Drawing.Color.Black;
            this.LoopTriger.Location = new System.Drawing.Point(115, 55);
            this.LoopTriger.Name = "LoopTriger";
            this.LoopTriger.Size = new System.Drawing.Size(64, 20);
            this.LoopTriger.TabIndex = 2;
            this.LoopTriger.Tag = "1";
            this.LoopTriger.Text = "Start";
            this.LoopTriger.UseVisualStyleBackColor = false;
            this.LoopTriger.Click += new System.EventHandler(this.button2_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(137, 94);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(40, 13);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "No life!";
            // 
            // SpeedSlider
            // 
            this.SpeedSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedSlider.Location = new System.Drawing.Point(18, 4);
            this.SpeedSlider.Maximum = 1000;
            this.SpeedSlider.Minimum = 50;
            this.SpeedSlider.Name = "SpeedSlider";
            this.SpeedSlider.Size = new System.Drawing.Size(91, 45);
            this.SpeedSlider.TabIndex = 3;
            this.SpeedSlider.TickFrequency = 50;
            this.SpeedSlider.Value = 50;
            // 
            // NextStephandle
            // 
            this.NextStephandle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextStephandle.BackColor = System.Drawing.Color.White;
            this.NextStephandle.Location = new System.Drawing.Point(115, 29);
            this.NextStephandle.Name = "NextStephandle";
            this.NextStephandle.Size = new System.Drawing.Size(64, 20);
            this.NextStephandle.TabIndex = 0;
            this.NextStephandle.Tag = "1";
            this.NextStephandle.Text = "Step";
            this.NextStephandle.UseVisualStyleBackColor = false;
            this.NextStephandle.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetHandle
            // 
            this.ResetHandle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetHandle.BackColor = System.Drawing.Color.White;
            this.ResetHandle.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ResetHandle.Location = new System.Drawing.Point(115, 3);
            this.ResetHandle.Name = "ResetHandle";
            this.ResetHandle.Size = new System.Drawing.Size(64, 20);
            this.ResetHandle.TabIndex = 4;
            this.ResetHandle.Tag = "1";
            this.ResetHandle.Text = "Reset";
            this.ResetHandle.UseVisualStyleBackColor = false;
            this.ResetHandle.Click += new System.EventHandler(this.ResetHandle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 390);
            this.Controls.Add(this.UiConteiner);
            this.Controls.Add(this.CloseOpenPanelHandle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UiConteiner.ResumeLayout(false);
            this.UiConteiner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseOpenPanelHandle;
        private System.Windows.Forms.Panel UiConteiner;
        private System.Windows.Forms.Button ResetHandle;
        private System.Windows.Forms.Button NextStephandle;
        private System.Windows.Forms.TrackBar SpeedSlider;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button LoopTriger;
    }
}
