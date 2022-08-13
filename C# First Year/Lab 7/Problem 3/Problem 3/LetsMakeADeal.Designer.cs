namespace Problem_3
{
    partial class LetsMakeADeal
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
            this.doorOne = new System.Windows.Forms.Button();
            this.doorTwo = new System.Windows.Forms.Button();
            this.doorThree = new System.Windows.Forms.Button();
            this.doorOneLabel = new System.Windows.Forms.Label();
            this.doorTwoLabel = new System.Windows.Forms.Label();
            this.doorThreeLabel = new System.Windows.Forms.Label();
            this.nextChoiceLabel1 = new System.Windows.Forms.Label();
            this.nextChoiceLabel2 = new System.Windows.Forms.Label();
            this.nextChoiceLabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doorOne
            // 
            this.doorOne.Location = new System.Drawing.Point(32, 122);
            this.doorOne.Name = "doorOne";
            this.doorOne.Size = new System.Drawing.Size(188, 281);
            this.doorOne.TabIndex = 0;
            this.doorOne.Text = "Door 1";
            this.doorOne.UseVisualStyleBackColor = true;
            this.doorOne.Click += new System.EventHandler(this.doorOne_Click);
            // 
            // doorTwo
            // 
            this.doorTwo.Location = new System.Drawing.Point(296, 122);
            this.doorTwo.Name = "doorTwo";
            this.doorTwo.Size = new System.Drawing.Size(194, 281);
            this.doorTwo.TabIndex = 1;
            this.doorTwo.Text = "Door 2";
            this.doorTwo.UseVisualStyleBackColor = true;
            this.doorTwo.Click += new System.EventHandler(this.doorTwo_Click);
            // 
            // doorThree
            // 
            this.doorThree.Location = new System.Drawing.Point(581, 122);
            this.doorThree.Name = "doorThree";
            this.doorThree.Size = new System.Drawing.Size(194, 281);
            this.doorThree.TabIndex = 2;
            this.doorThree.Text = "Door 3";
            this.doorThree.UseVisualStyleBackColor = true;
            this.doorThree.Click += new System.EventHandler(this.doorThree_Click);
            // 
            // doorOneLabel
            // 
            this.doorOneLabel.AutoSize = true;
            this.doorOneLabel.Location = new System.Drawing.Point(30, 84);
            this.doorOneLabel.Name = "doorOneLabel";
            this.doorOneLabel.Size = new System.Drawing.Size(87, 17);
            this.doorOneLabel.TabIndex = 3;
            this.doorOneLabel.Text = "Door 1 Prize";
            this.doorOneLabel.Visible = false;
            // 
            // doorTwoLabel
            // 
            this.doorTwoLabel.AutoSize = true;
            this.doorTwoLabel.Location = new System.Drawing.Point(293, 84);
            this.doorTwoLabel.Name = "doorTwoLabel";
            this.doorTwoLabel.Size = new System.Drawing.Size(87, 17);
            this.doorTwoLabel.TabIndex = 4;
            this.doorTwoLabel.Text = "Door 2 Prize";
            this.doorTwoLabel.Visible = false;
            // 
            // doorThreeLabel
            // 
            this.doorThreeLabel.AutoSize = true;
            this.doorThreeLabel.Location = new System.Drawing.Point(583, 84);
            this.doorThreeLabel.Name = "doorThreeLabel";
            this.doorThreeLabel.Size = new System.Drawing.Size(87, 17);
            this.doorThreeLabel.TabIndex = 5;
            this.doorThreeLabel.Text = "Door 3 Prize";
            this.doorThreeLabel.Visible = false;
            // 
            // nextChoiceLabel1
            // 
            this.nextChoiceLabel1.AutoSize = true;
            this.nextChoiceLabel1.Location = new System.Drawing.Point(29, 416);
            this.nextChoiceLabel1.Name = "nextChoiceLabel1";
            this.nextChoiceLabel1.Size = new System.Drawing.Size(134, 17);
            this.nextChoiceLabel1.TabIndex = 6;
            this.nextChoiceLabel1.Text = "Next Choice Label 1";
            this.nextChoiceLabel1.Visible = false;
            // 
            // nextChoiceLabel2
            // 
            this.nextChoiceLabel2.AutoSize = true;
            this.nextChoiceLabel2.Location = new System.Drawing.Point(293, 416);
            this.nextChoiceLabel2.Name = "nextChoiceLabel2";
            this.nextChoiceLabel2.Size = new System.Drawing.Size(134, 17);
            this.nextChoiceLabel2.TabIndex = 7;
            this.nextChoiceLabel2.Text = "Next Choice Label 2";
            this.nextChoiceLabel2.Visible = false;
            // 
            // nextChoiceLabel3
            // 
            this.nextChoiceLabel3.AutoSize = true;
            this.nextChoiceLabel3.Location = new System.Drawing.Point(578, 416);
            this.nextChoiceLabel3.Name = "nextChoiceLabel3";
            this.nextChoiceLabel3.Size = new System.Drawing.Size(134, 17);
            this.nextChoiceLabel3.TabIndex = 8;
            this.nextChoiceLabel3.Text = "Next Choice Label 3";
            this.nextChoiceLabel3.Visible = false;
            // 
            // LetsMakeADeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 538);
            this.Controls.Add(this.nextChoiceLabel3);
            this.Controls.Add(this.nextChoiceLabel2);
            this.Controls.Add(this.nextChoiceLabel1);
            this.Controls.Add(this.doorThreeLabel);
            this.Controls.Add(this.doorTwoLabel);
            this.Controls.Add(this.doorOneLabel);
            this.Controls.Add(this.doorThree);
            this.Controls.Add(this.doorTwo);
            this.Controls.Add(this.doorOne);
            this.Name = "LetsMakeADeal";
            this.Text = "Lets Make A Deal";
            this.Load += new System.EventHandler(this.LetsMakeADeal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doorOne;
        private System.Windows.Forms.Button doorTwo;
        private System.Windows.Forms.Button doorThree;
        private System.Windows.Forms.Label doorOneLabel;
        private System.Windows.Forms.Label doorTwoLabel;
        private System.Windows.Forms.Label doorThreeLabel;
        private System.Windows.Forms.Label nextChoiceLabel1;
        private System.Windows.Forms.Label nextChoiceLabel2;
        private System.Windows.Forms.Label nextChoiceLabel3;
    }
}

