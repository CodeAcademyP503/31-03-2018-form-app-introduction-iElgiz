﻿namespace CinemaAppTask
{
    partial class Checking
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
            this.SeansBox = new System.Windows.Forms.TextBox();
            this.SeatsBox = new System.Windows.Forms.TextBox();
            this.PayingBox = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SeansBox
            // 
            this.SeansBox.Location = new System.Drawing.Point(12, 130);
            this.SeansBox.Name = "SeansBox";
            this.SeansBox.Size = new System.Drawing.Size(100, 20);
            this.SeansBox.TabIndex = 0;
            // 
            // SeatsBox
            // 
            this.SeatsBox.Location = new System.Drawing.Point(12, 46);
            this.SeatsBox.Name = "SeatsBox";
            this.SeatsBox.Size = new System.Drawing.Size(100, 20);
            this.SeatsBox.TabIndex = 0;
            // 
            // PayingBox
            // 
            this.PayingBox.Location = new System.Drawing.Point(12, 86);
            this.PayingBox.Name = "PayingBox";
            this.PayingBox.Size = new System.Drawing.Size(100, 20);
            this.PayingBox.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(268, 208);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(164, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Yeni Rezervasiya";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sechdiyiniz Yerler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Odenilecek Mebleg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seans";
            // 
            // Checking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.PayingBox);
            this.Controls.Add(this.SeatsBox);
            this.Controls.Add(this.SeansBox);
            this.Name = "Checking";
            this.Text = "Checking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SeansBox;
        private System.Windows.Forms.TextBox SeatsBox;
        private System.Windows.Forms.TextBox PayingBox;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}