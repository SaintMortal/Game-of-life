
using System;
using System.Drawing;
using System.IO;
using WindowsFormsApp1.Properties;

namespace GameOfLife
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CloseOpenPanelHandle = new System.Windows.Forms.Button();
            this.UiConteiner = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.albelControl = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.InputFormForNaming = new System.Windows.Forms.TextBox();
            this.LoadHandle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.ResetHandle = new System.Windows.Forms.Button();
            this.SpeedSlider = new System.Windows.Forms.TrackBar();
            this.NextStephandle = new System.Windows.Forms.Button();
            this.LoopTriger = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.UiConteiner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseOpenPanelHandle
            // 
            this.CloseOpenPanelHandle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseOpenPanelHandle.BackColor = System.Drawing.Color.White;
            this.CloseOpenPanelHandle.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseOpenPanelHandle.Image = ((System.Drawing.Image)(resources.GetObject("CloseOpenPanelHandle.Image")));
            this.CloseOpenPanelHandle.Location = new System.Drawing.Point(971, 11);
            this.CloseOpenPanelHandle.Name = "CloseOpenPanelHandle";
            this.CloseOpenPanelHandle.Size = new System.Drawing.Size(46, 37);
            this.CloseOpenPanelHandle.TabIndex = 5;
            this.CloseOpenPanelHandle.UseVisualStyleBackColor = false;
            this.CloseOpenPanelHandle.Click += new System.EventHandler(this.CloseOpenPanelHandle_Click);
            // 
            // UiConteiner
            // 
            this.UiConteiner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UiConteiner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UiConteiner.Controls.Add(this.label3);
            this.UiConteiner.Controls.Add(this.label2);
            this.UiConteiner.Controls.Add(this.albelControl);
            this.UiConteiner.Controls.Add(this.SpeedSlider);
            this.UiConteiner.Controls.Add(this.labelMenu);
            this.UiConteiner.Controls.Add(this.InputFormForNaming);
            this.UiConteiner.Controls.Add(this.LoadHandle);
            this.UiConteiner.Controls.Add(this.comboBox1);
            this.UiConteiner.Controls.Add(this.label1);
            this.UiConteiner.Controls.Add(this.Save);
            this.UiConteiner.Controls.Add(this.ResetHandle);
            this.UiConteiner.Controls.Add(this.NextStephandle);
            this.UiConteiner.Controls.Add(this.LoopTriger);
            this.UiConteiner.Location = new System.Drawing.Point(834, 50);
            this.UiConteiner.Name = "UiConteiner";
            this.UiConteiner.Size = new System.Drawing.Size(184, 343);
            this.UiConteiner.TabIndex = 5;
            this.UiConteiner.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(20, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Load Pattern";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(21, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Save Pattern ";
            // 
            // albelControl
            // 
            this.albelControl.AutoSize = true;
            this.albelControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albelControl.ForeColor = System.Drawing.Color.Black;
            this.albelControl.Location = new System.Drawing.Point(46, 28);
            this.albelControl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.albelControl.Name = "albelControl";
            this.albelControl.Size = new System.Drawing.Size(92, 15);
            this.albelControl.TabIndex = 10;
            this.albelControl.Text = "Game Controls ";
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMenu.Location = new System.Drawing.Point(41, 9);
            this.labelMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(101, 20);
            this.labelMenu.TabIndex = 9;
            this.labelMenu.Text = "Game of Life";
            // 
            // InputFormForNaming
            // 
            this.InputFormForNaming.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.InputFormForNaming.Location = new System.Drawing.Point(21, 216);
            this.InputFormForNaming.Name = "InputFormForNaming";
            this.InputFormForNaming.Size = new System.Drawing.Size(143, 20);
            this.InputFormForNaming.TabIndex = 6;
            this.InputFormForNaming.Text = "Pattern Name";
            this.InputFormForNaming.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InputFormForNaming_MouseClick);
            this.InputFormForNaming.TextChanged += new System.EventHandler(this.InputFormForNaming_TextChanged);
            // 
            // LoadHandle
            // 
            this.LoadHandle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadHandle.BackColor = System.Drawing.Color.White;
            this.LoadHandle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LoadHandle.FlatAppearance.BorderSize = 0;
            this.LoadHandle.ForeColor = System.Drawing.Color.Black;
            this.LoadHandle.Location = new System.Drawing.Point(19, 312);
            this.LoadHandle.Name = "LoadHandle";
            this.LoadHandle.Size = new System.Drawing.Size(143, 20);
            this.LoadHandle.TabIndex = 7;
            this.LoadHandle.Tag = "1";
            this.LoadHandle.Text = "Load";
            this.LoadHandle.UseVisualStyleBackColor = false;
            this.LoadHandle.Click += new System.EventHandler(this.LoadHandle_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 287);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Playground Update Speed";
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Save.Location = new System.Drawing.Point(21, 239);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(144, 20);
            this.Save.TabIndex = 5;
            this.Save.Tag = "1";
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ResetHandle
            // 
            this.ResetHandle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetHandle.BackColor = System.Drawing.Color.White;
            this.ResetHandle.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ResetHandle.Location = new System.Drawing.Point(22, 171);
            this.ResetHandle.Name = "ResetHandle";
            this.ResetHandle.Size = new System.Drawing.Size(143, 20);
            this.ResetHandle.TabIndex = 4;
            this.ResetHandle.Tag = "1";
            this.ResetHandle.Text = "Reset Current Playground";
            this.ResetHandle.UseVisualStyleBackColor = false;
            this.ResetHandle.Click += new System.EventHandler(this.ResetHandle_Click);
            // 
            // SpeedSlider
            // 
            this.SpeedSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedSlider.Location = new System.Drawing.Point(21, 78);
            this.SpeedSlider.Maximum = 1000;
            this.SpeedSlider.Minimum = 50;
            this.SpeedSlider.Name = "SpeedSlider";
            this.SpeedSlider.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SpeedSlider.Size = new System.Drawing.Size(143, 45);
            this.SpeedSlider.TabIndex = 3;
            this.SpeedSlider.TickFrequency = 50;
            this.SpeedSlider.Value = 50;
            // 
            // NextStephandle
            // 
            this.NextStephandle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextStephandle.BackColor = System.Drawing.Color.White;
            this.NextStephandle.Location = new System.Drawing.Point(21, 129);
            this.NextStephandle.Name = "NextStephandle";
            this.NextStephandle.Size = new System.Drawing.Size(143, 20);
            this.NextStephandle.TabIndex = 0;
            this.NextStephandle.Tag = "1";
            this.NextStephandle.Text = "Make Next Step";
            this.NextStephandle.UseVisualStyleBackColor = false;
            this.NextStephandle.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoopTriger
            // 
            this.LoopTriger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoopTriger.BackColor = System.Drawing.Color.White;
            this.LoopTriger.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LoopTriger.FlatAppearance.BorderSize = 0;
            this.LoopTriger.ForeColor = System.Drawing.Color.Black;
            this.LoopTriger.Location = new System.Drawing.Point(21, 149);
            this.LoopTriger.Name = "LoopTriger";
            this.LoopTriger.Size = new System.Drawing.Size(143, 20);
            this.LoopTriger.TabIndex = 2;
            this.LoopTriger.Tag = "1";
            this.LoopTriger.Text = "Start The Game";
            this.LoopTriger.UseVisualStyleBackColor = false;
            this.LoopTriger.Click += new System.EventHandler(this.button2_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(917, 24);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(40, 13);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "No life!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 591);
            this.Controls.Add(this.UiConteiner);
            this.Controls.Add(this.CloseOpenPanelHandle);
            this.Controls.Add(this.ScoreLabel);
            this.Name = "Form1";
            this.Text = "Game of life";
            this.UiConteiner.ResumeLayout(false);
            this.UiConteiner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseOpenPanelHandle;
        private System.Windows.Forms.Panel UiConteiner;
        private System.Windows.Forms.Button ResetHandle;
        private System.Windows.Forms.Button NextStephandle;
        private System.Windows.Forms.TrackBar SpeedSlider;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button LoopTriger;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button LoadHandle;
        private System.Windows.Forms.TextBox InputFormForNaming;
        private System.Windows.Forms.Label albelControl;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
