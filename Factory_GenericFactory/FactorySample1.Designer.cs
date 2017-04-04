namespace Factory_GenericFactory
{
    partial class FactorySample1
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
            this.btnFedEx = new System.Windows.Forms.Button();
            this.btnPurolator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUPS
            // 
            this.btnUPS.Location = new System.Drawing.Point(88, 17);
            this.btnUPS.Name = "btnUPS";
            this.btnUPS.Size = new System.Drawing.Size(75, 23);
            this.btnUPS.TabIndex = 0;
            this.btnUPS.Text = "UPS";
            this.btnUPS.UseVisualStyleBackColor = true;
            this.btnUPS.Click += new System.EventHandler(this.btnUPS_Click);
            // 
            // btnFedEx
            // 
            this.btnFedEx.Location = new System.Drawing.Point(88, 62);
            this.btnFedEx.Name = "btnFedEx";
            this.btnFedEx.Size = new System.Drawing.Size(75, 23);
            this.btnFedEx.TabIndex = 1;
            this.btnFedEx.Text = "FedEx";
            this.btnFedEx.UseVisualStyleBackColor = true;
            this.btnFedEx.Click += new System.EventHandler(this.btnFedEx_Click);
            // 
            // btnPurolator
            // 
            this.btnPurolator.Location = new System.Drawing.Point(88, 107);
            this.btnPurolator.Name = "btnPurolator";
            this.btnPurolator.Size = new System.Drawing.Size(75, 23);
            this.btnPurolator.TabIndex = 2;
            this.btnPurolator.Text = "Purolator";
            this.btnPurolator.UseVisualStyleBackColor = true;
            this.btnPurolator.Click += new System.EventHandler(this.btnPurolator_Click);
            // 
            // FactorySample1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.btnPurolator);
            this.Controls.Add(this.btnFedEx);
            this.Controls.Add(this.btnUPS);
            this.Name = "FactorySample1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUPS;
        private System.Windows.Forms.Button btnFedEx;
        private System.Windows.Forms.Button btnPurolator;
    }
}

