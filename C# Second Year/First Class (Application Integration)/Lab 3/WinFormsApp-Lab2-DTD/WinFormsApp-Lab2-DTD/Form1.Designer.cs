
namespace WinFormsApp_Lab2_DTD
{
    partial class validationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.validateButton = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.validateButtonXSD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "XML Validation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // validateButton
            // 
            this.validateButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.validateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.validateButton.Location = new System.Drawing.Point(220, 92);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(130, 40);
            this.validateButton.TabIndex = 1;
            this.validateButton.Text = "Validate (DTD)";
            this.validateButton.UseVisualStyleBackColor = false;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(153, 165);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(442, 226);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.Text = "";
            // 
            // validateButtonXSD
            // 
            this.validateButtonXSD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.validateButtonXSD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.validateButtonXSD.Location = new System.Drawing.Point(411, 92);
            this.validateButtonXSD.Name = "validateButtonXSD";
            this.validateButtonXSD.Size = new System.Drawing.Size(128, 40);
            this.validateButtonXSD.TabIndex = 4;
            this.validateButtonXSD.Text = "Validate (XSD)";
            this.validateButtonXSD.UseVisualStyleBackColor = false;
            this.validateButtonXSD.Click += new System.EventHandler(this.validateButtonXSD_Click);
            // 
            // validationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.validateButtonXSD);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.label1);
            this.Name = "validationForm";
            this.Text = "Validation Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Button validateButtonXSD;
    }
}

