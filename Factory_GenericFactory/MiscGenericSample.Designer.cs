﻿namespace Factory_GenericFactory5
{
    partial class MiscGenericSample
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
            this.btnUPS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUPS
            // 
            this.btnUPS.Location = new System.Drawing.Point(82, 35);
            this.btnUPS.Name = "btnUPS";
            this.btnUPS.Size = new System.Drawing.Size(75, 23);
            this.btnUPS.TabIndex = 7;
            this.btnUPS.Text = "Sample1";
            this.btnUPS.UseVisualStyleBackColor = true;
            this.btnUPS.Click += new System.EventHandler(this.btnUPS_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sample2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MiscGenericSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUPS);
            this.Name = "MiscGenericSample";
            this.Text = "MiscGenericSample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUPS;
        private System.Windows.Forms.Button button1;
    }
}