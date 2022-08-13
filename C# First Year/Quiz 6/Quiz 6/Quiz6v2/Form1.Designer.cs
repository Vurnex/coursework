namespace Quiz6v2
{
    partial class Form1
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
            this.valueList = new System.Windows.Forms.ListBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.buttonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valueList
            // 
            this.valueList.FormattingEnabled = true;
            this.valueList.ItemHeight = 16;
            this.valueList.Location = new System.Drawing.Point(15, 18);
            this.valueList.Name = "valueList";
            this.valueList.Size = new System.Drawing.Size(106, 132);
            this.valueList.TabIndex = 0;
            this.valueList.SelectedIndexChanged += new System.EventHandler(this.valueList_SelectedIndexChanged);
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(12, 178);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(83, 17);
            this.valueLabel.TabIndex = 1;
            this.valueLabel.Text = "Value Label";
            this.valueLabel.Visible = false;
            this.valueLabel.Click += new System.EventHandler(this.valueLabel_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(15, 238);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(106, 29);
            this.testButton.TabIndex = 2;
            this.testButton.Text = "Test Button";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            this.testButton.MouseLeave += new System.EventHandler(this.testButton_MouseLeave);
            // 
            // buttonLabel
            // 
            this.buttonLabel.AutoSize = true;
            this.buttonLabel.Location = new System.Drawing.Point(12, 297);
            this.buttonLabel.Name = "buttonLabel";
            this.buttonLabel.Size = new System.Drawing.Size(88, 17);
            this.buttonLabel.TabIndex = 3;
            this.buttonLabel.Text = "Button Label";
            this.buttonLabel.Visible = false;
            this.buttonLabel.Click += new System.EventHandler(this.buttonLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(239, 349);
            this.Controls.Add(this.buttonLabel);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.valueList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox valueList;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label buttonLabel;
    }
}

