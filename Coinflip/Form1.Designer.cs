﻿namespace Coinflip
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGuess = new System.Windows.Forms.Label();
            this.radTails = new System.Windows.Forms.RadioButton();
            this.radHeads = new System.Windows.Forms.RadioButton();
            this.btnFlip = new System.Windows.Forms.Button();
            this.picCoin = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGuess);
            this.groupBox1.Controls.Add(this.radTails);
            this.groupBox1.Controls.Add(this.radHeads);
            this.groupBox1.Controls.Add(this.btnFlip);
            this.groupBox1.Controls.Add(this.picCoin);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coin";
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(154, 330);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(99, 15);
            this.lblGuess.TabIndex = 5;
            this.lblGuess.Text = "Your Guess Was...";
            // 
            // radTails
            // 
            this.radTails.AutoSize = true;
            this.radTails.Location = new System.Drawing.Point(206, 299);
            this.radTails.Name = "radTails";
            this.radTails.Size = new System.Drawing.Size(47, 19);
            this.radTails.TabIndex = 4;
            this.radTails.TabStop = true;
            this.radTails.Text = "Tails";
            this.radTails.UseVisualStyleBackColor = true;
            // 
            // radHeads
            // 
            this.radHeads.AutoSize = true;
            this.radHeads.Location = new System.Drawing.Point(100, 299);
            this.radHeads.Name = "radHeads";
            this.radHeads.Size = new System.Drawing.Size(58, 19);
            this.radHeads.TabIndex = 3;
            this.radHeads.TabStop = true;
            this.radHeads.Text = "Heads";
            this.radHeads.UseVisualStyleBackColor = true;
            // 
            // btnFlip
            // 
            this.btnFlip.Location = new System.Drawing.Point(161, 348);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(75, 23);
            this.btnFlip.TabIndex = 2;
            this.btnFlip.Text = "Flip!";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // picCoin
            // 
            this.picCoin.Location = new System.Drawing.Point(100, 100);
            this.picCoin.Name = "picCoin";
            this.picCoin.Size = new System.Drawing.Size(200, 200);
            this.picCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoin.TabIndex = 1;
            this.picCoin.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(180, 86);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(38, 15);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnFlip;
        private PictureBox picCoin;
        private Label lblResult;
        private RadioButton radTails;
        private RadioButton radHeads;
        private Label lblGuess;
    }
}