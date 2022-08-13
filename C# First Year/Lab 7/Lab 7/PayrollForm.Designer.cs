namespace Lab_7
{
    partial class PayRollGUI
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
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.SSNLabel = new System.Windows.Forms.Label();
            this.hourlyPayLabel = new System.Windows.Forms.Label();
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.fedTaxLabel = new System.Windows.Forms.Label();
            this.stateTaxLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.fullNameText = new System.Windows.Forms.TextBox();
            this.ssnText = new System.Windows.Forms.TextBox();
            this.hourlyPayText = new System.Windows.Forms.TextBox();
            this.hoursWorkedText = new System.Windows.Forms.TextBox();
            this.netPayLabel = new System.Windows.Forms.Label();
            this.displayGrossPay = new System.Windows.Forms.Label();
            this.displayFedTax = new System.Windows.Forms.Label();
            this.displayStateTax = new System.Windows.Forms.Label();
            this.displayNetPay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(115, 28);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(75, 17);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // SSNLabel
            // 
            this.SSNLabel.AutoSize = true;
            this.SSNLabel.Location = new System.Drawing.Point(31, 68);
            this.SSNLabel.Name = "SSNLabel";
            this.SSNLabel.Size = new System.Drawing.Size(159, 17);
            this.SSNLabel.TabIndex = 1;
            this.SSNLabel.Text = "Social Security Number:";
            // 
            // hourlyPayLabel
            // 
            this.hourlyPayLabel.AutoSize = true;
            this.hourlyPayLabel.Location = new System.Drawing.Point(75, 111);
            this.hourlyPayLabel.Name = "hourlyPayLabel";
            this.hourlyPayLabel.Size = new System.Drawing.Size(115, 17);
            this.hourlyPayLabel.TabIndex = 2;
            this.hourlyPayLabel.Text = "Hourly Pay Rate:";
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Location = new System.Drawing.Point(17, 158);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(173, 17);
            this.hoursWorkedLabel.TabIndex = 3;
            this.hoursWorkedLabel.Text = "Number of Hours Worked:";
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.AutoSize = true;
            this.grossPayLabel.Location = new System.Drawing.Point(27, 269);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(78, 17);
            this.grossPayLabel.TabIndex = 4;
            this.grossPayLabel.Text = "Gross Pay:";
            // 
            // fedTaxLabel
            // 
            this.fedTaxLabel.AutoSize = true;
            this.fedTaxLabel.Location = new System.Drawing.Point(15, 308);
            this.fedTaxLabel.Name = "fedTaxLabel";
            this.fedTaxLabel.Size = new System.Drawing.Size(87, 17);
            this.fedTaxLabel.TabIndex = 5;
            this.fedTaxLabel.Text = "Federal Tax:";
            // 
            // stateTaxLabel
            // 
            this.stateTaxLabel.AutoSize = true;
            this.stateTaxLabel.Location = new System.Drawing.Point(27, 354);
            this.stateTaxLabel.Name = "stateTaxLabel";
            this.stateTaxLabel.Size = new System.Drawing.Size(72, 17);
            this.stateTaxLabel.TabIndex = 6;
            this.stateTaxLabel.Text = "State Tax:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(94, 209);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(134, 32);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate Payroll";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // fullNameText
            // 
            this.fullNameText.Location = new System.Drawing.Point(195, 23);
            this.fullNameText.Name = "fullNameText";
            this.fullNameText.Size = new System.Drawing.Size(107, 22);
            this.fullNameText.TabIndex = 8;
            // 
            // ssnText
            // 
            this.ssnText.Location = new System.Drawing.Point(195, 63);
            this.ssnText.Name = "ssnText";
            this.ssnText.Size = new System.Drawing.Size(107, 22);
            this.ssnText.TabIndex = 9;
            // 
            // hourlyPayText
            // 
            this.hourlyPayText.Location = new System.Drawing.Point(195, 108);
            this.hourlyPayText.Name = "hourlyPayText";
            this.hourlyPayText.Size = new System.Drawing.Size(107, 22);
            this.hourlyPayText.TabIndex = 10;
            // 
            // hoursWorkedText
            // 
            this.hoursWorkedText.Location = new System.Drawing.Point(195, 155);
            this.hoursWorkedText.Name = "hoursWorkedText";
            this.hoursWorkedText.Size = new System.Drawing.Size(107, 22);
            this.hoursWorkedText.TabIndex = 11;
            // 
            // netPayLabel
            // 
            this.netPayLabel.AutoSize = true;
            this.netPayLabel.Location = new System.Drawing.Point(31, 398);
            this.netPayLabel.Name = "netPayLabel";
            this.netPayLabel.Size = new System.Drawing.Size(62, 17);
            this.netPayLabel.TabIndex = 12;
            this.netPayLabel.Text = "Net Pay:";
            // 
            // displayGrossPay
            // 
            this.displayGrossPay.AutoSize = true;
            this.displayGrossPay.Location = new System.Drawing.Point(104, 269);
            this.displayGrossPay.Name = "displayGrossPay";
            this.displayGrossPay.Size = new System.Drawing.Size(124, 17);
            this.displayGrossPay.TabIndex = 13;
            this.displayGrossPay.Text = "Display Gross Pay";
            this.displayGrossPay.Visible = false;
            // 
            // displayFedTax
            // 
            this.displayFedTax.AutoSize = true;
            this.displayFedTax.Location = new System.Drawing.Point(104, 308);
            this.displayFedTax.Name = "displayFedTax";
            this.displayFedTax.Size = new System.Drawing.Size(133, 17);
            this.displayFedTax.TabIndex = 14;
            this.displayFedTax.Text = "Display Federal Tax";
            this.displayFedTax.Visible = false;
            // 
            // displayStateTax
            // 
            this.displayStateTax.AutoSize = true;
            this.displayStateTax.Location = new System.Drawing.Point(104, 354);
            this.displayStateTax.Name = "displayStateTax";
            this.displayStateTax.Size = new System.Drawing.Size(118, 17);
            this.displayStateTax.TabIndex = 15;
            this.displayStateTax.Text = "Display State Tax";
            this.displayStateTax.Visible = false;
            // 
            // displayNetPay
            // 
            this.displayNetPay.AutoSize = true;
            this.displayNetPay.Location = new System.Drawing.Point(104, 398);
            this.displayNetPay.Name = "displayNetPay";
            this.displayNetPay.Size = new System.Drawing.Size(108, 17);
            this.displayNetPay.TabIndex = 16;
            this.displayNetPay.Text = "Display Net Pay";
            this.displayNetPay.Visible = false;
            // 
            // PayRollGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.displayNetPay);
            this.Controls.Add(this.displayStateTax);
            this.Controls.Add(this.displayFedTax);
            this.Controls.Add(this.displayGrossPay);
            this.Controls.Add(this.netPayLabel);
            this.Controls.Add(this.hoursWorkedText);
            this.Controls.Add(this.hourlyPayText);
            this.Controls.Add(this.ssnText);
            this.Controls.Add(this.fullNameText);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.stateTaxLabel);
            this.Controls.Add(this.fedTaxLabel);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Controls.Add(this.hourlyPayLabel);
            this.Controls.Add(this.SSNLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Name = "PayRollGUI";
            this.Text = "Payroll Form";
            this.Load += new System.EventHandler(this.PayRollGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label SSNLabel;
        private System.Windows.Forms.Label hourlyPayLabel;
        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.Label fedTaxLabel;
        private System.Windows.Forms.Label stateTaxLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox fullNameText;
        private System.Windows.Forms.TextBox ssnText;
        private System.Windows.Forms.TextBox hourlyPayText;
        private System.Windows.Forms.TextBox hoursWorkedText;
        private System.Windows.Forms.Label netPayLabel;
        private System.Windows.Forms.Label displayGrossPay;
        private System.Windows.Forms.Label displayFedTax;
        private System.Windows.Forms.Label displayStateTax;
        private System.Windows.Forms.Label displayNetPay;
    }
}

