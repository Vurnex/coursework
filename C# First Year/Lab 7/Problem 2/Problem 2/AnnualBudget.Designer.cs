namespace Problem_2
{
    partial class AnnualBudget
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
            this.websiteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.excelLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // websiteLinkLabel
            // 
            this.websiteLinkLabel.AutoSize = true;
            this.websiteLinkLabel.Location = new System.Drawing.Point(68, 85);
            this.websiteLinkLabel.Name = "websiteLinkLabel";
            this.websiteLinkLabel.Size = new System.Drawing.Size(114, 17);
            this.websiteLinkLabel.TabIndex = 0;
            this.websiteLinkLabel.TabStop = true;
            this.websiteLinkLabel.Text = "Favorite Website";
            this.websiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.websiteLinkLabel_LinkClicked);
            // 
            // excelLinkLabel
            // 
            this.excelLinkLabel.AutoSize = true;
            this.excelLinkLabel.Location = new System.Drawing.Point(68, 154);
            this.excelLinkLabel.Name = "excelLinkLabel";
            this.excelLinkLabel.Size = new System.Drawing.Size(82, 17);
            this.excelLinkLabel.TabIndex = 1;
            this.excelLinkLabel.TabStop = true;
            this.excelLinkLabel.Text = "Excel Sheet";
            this.excelLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.excelLinkLabel_LinkClicked);
            // 
            // AnnualBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 271);
            this.Controls.Add(this.excelLinkLabel);
            this.Controls.Add(this.websiteLinkLabel);
            this.Name = "AnnualBudget";
            this.Text = "Link Labels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel websiteLinkLabel;
        private System.Windows.Forms.LinkLabel excelLinkLabel;
    }
}

