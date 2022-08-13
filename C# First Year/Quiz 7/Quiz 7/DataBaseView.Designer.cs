namespace Quiz_7
{
    partial class DataBaseView
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersDatabaseDataSet = new Quiz_7.CustomersDatabaseDataSet();
            this.customerTableTableAdapter = new Quiz_7.CustomersDatabaseDataSetTableAdapters.CustomerTableTableAdapter();
            this.viewTableButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.showNumsButton = new System.Windows.Forms.Button();
            this.showNumsList = new System.Windows.Forms.ListBox();
            this.phoneNumsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.customerPhoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(678, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "customerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "customerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "customerAddress";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "customerAddress";
            this.customerAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            this.customerAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerPhoneDataGridViewTextBoxColumn
            // 
            this.customerPhoneDataGridViewTextBoxColumn.DataPropertyName = "customerPhone";
            this.customerPhoneDataGridViewTextBoxColumn.HeaderText = "customerPhone";
            this.customerPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerPhoneDataGridViewTextBoxColumn.Name = "customerPhoneDataGridViewTextBoxColumn";
            this.customerPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerTableBindingSource
            // 
            this.customerTableBindingSource.DataMember = "CustomerTable";
            this.customerTableBindingSource.DataSource = this.customersDatabaseDataSet;
            // 
            // customersDatabaseDataSet
            // 
            this.customersDatabaseDataSet.DataSetName = "CustomersDatabaseDataSet";
            this.customersDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableTableAdapter
            // 
            this.customerTableTableAdapter.ClearBeforeFill = true;
            // 
            // viewTableButton
            // 
            this.viewTableButton.Location = new System.Drawing.Point(47, 201);
            this.viewTableButton.Name = "viewTableButton";
            this.viewTableButton.Size = new System.Drawing.Size(177, 55);
            this.viewTableButton.TabIndex = 1;
            this.viewTableButton.Text = "Load Customer Data";
            this.viewTableButton.UseVisualStyleBackColor = true;
            this.viewTableButton.Click += new System.EventHandler(this.viewTableButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(297, 201);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(163, 55);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showNumsButton
            // 
            this.showNumsButton.Location = new System.Drawing.Point(559, 201);
            this.showNumsButton.Name = "showNumsButton";
            this.showNumsButton.Size = new System.Drawing.Size(166, 55);
            this.showNumsButton.TabIndex = 4;
            this.showNumsButton.Text = "Show Phone Numbers";
            this.showNumsButton.UseVisualStyleBackColor = true;
            this.showNumsButton.Click += new System.EventHandler(this.showNumsButton_Click);
            // 
            // showNumsList
            // 
            this.showNumsList.FormattingEnabled = true;
            this.showNumsList.ItemHeight = 16;
            this.showNumsList.Location = new System.Drawing.Point(294, 319);
            this.showNumsList.Name = "showNumsList";
            this.showNumsList.Size = new System.Drawing.Size(198, 148);
            this.showNumsList.TabIndex = 5;
            // 
            // phoneNumsLabel
            // 
            this.phoneNumsLabel.AutoSize = true;
            this.phoneNumsLabel.Location = new System.Drawing.Point(294, 296);
            this.phoneNumsLabel.Name = "phoneNumsLabel";
            this.phoneNumsLabel.Size = new System.Drawing.Size(110, 17);
            this.phoneNumsLabel.TabIndex = 6;
            this.phoneNumsLabel.Text = "Phone Numbers";
            this.phoneNumsLabel.Visible = false;
            // 
            // DataBaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 491);
            this.Controls.Add(this.phoneNumsLabel);
            this.Controls.Add(this.showNumsList);
            this.Controls.Add(this.showNumsButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.viewTableButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataBaseView";
            this.Text = "Database View";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomersDatabaseDataSet customersDatabaseDataSet;
        private System.Windows.Forms.BindingSource customerTableBindingSource;
        private CustomersDatabaseDataSetTableAdapters.CustomerTableTableAdapter customerTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button viewTableButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showNumsButton;
        private System.Windows.Forms.ListBox showNumsList;
        private System.Windows.Forms.Label phoneNumsLabel;
    }
}

