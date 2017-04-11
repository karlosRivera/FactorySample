namespace Factory_GenericFactory4
{
    partial class AnotherGenericFactory
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
            this.btnPurolator = new System.Windows.Forms.Button();
            this.btnFedEx = new System.Windows.Forms.Button();
            this.btnUPS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPurolator
            // 
            this.btnPurolator.Location = new System.Drawing.Point(26, 101);
            this.btnPurolator.Name = "btnPurolator";
            this.btnPurolator.Size = new System.Drawing.Size(75, 23);
            this.btnPurolator.TabIndex = 8;
            this.btnPurolator.Text = "Purolator";
            this.btnPurolator.UseVisualStyleBackColor = true;
            this.btnPurolator.Click += new System.EventHandler(this.btnPurolator_Click);
            // 
            // btnFedEx
            // 
            this.btnFedEx.Location = new System.Drawing.Point(26, 56);
            this.btnFedEx.Name = "btnFedEx";
            this.btnFedEx.Size = new System.Drawing.Size(75, 23);
            this.btnFedEx.TabIndex = 7;
            this.btnFedEx.Text = "FedEx";
            this.btnFedEx.UseVisualStyleBackColor = true;
            this.btnFedEx.Click += new System.EventHandler(this.btnFedEx_Click);
            // 
            // btnUPS
            // 
            this.btnUPS.Location = new System.Drawing.Point(26, 11);
            this.btnUPS.Name = "btnUPS";
            this.btnUPS.Size = new System.Drawing.Size(75, 23);
            this.btnUPS.TabIndex = 6;
            this.btnUPS.Text = "UPS";
            this.btnUPS.UseVisualStyleBackColor = true;
            this.btnUPS.Click += new System.EventHandler(this.btnUPS_Click);
            // 
            // AnotherGenericFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(122, 143);
            this.Controls.Add(this.btnPurolator);
            this.Controls.Add(this.btnFedEx);
            this.Controls.Add(this.btnUPS);
            this.Name = "AnotherGenericFactory";
            this.Text = "AnotherGenericFactory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPurolator;
        private System.Windows.Forms.Button btnFedEx;
        private System.Windows.Forms.Button btnUPS;
    }
}