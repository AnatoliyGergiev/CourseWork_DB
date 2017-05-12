namespace Курсовая_БД_ООП.Forms
{
    partial class DataBaseSelection
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
            this.databaseSelectionList = new System.Windows.Forms.ComboBox();
            this.tableSelectionList = new System.Windows.Forms.ComboBox();
            this.tableColumnsList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // databaseSelectionList
            // 
            this.databaseSelectionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databaseSelectionList.Location = new System.Drawing.Point(41, 45);
            this.databaseSelectionList.Name = "databaseSelectionList";
            this.databaseSelectionList.Size = new System.Drawing.Size(171, 21);
            this.databaseSelectionList.Sorted = true;
            this.databaseSelectionList.TabIndex = 0;
            this.databaseSelectionList.SelectedIndexChanged += new System.EventHandler(this.databaseSelectionList_SelectedIndexChanged);
            // 
            // tableSelectionList
            // 
            this.tableSelectionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableSelectionList.FormattingEnabled = true;
            this.tableSelectionList.Location = new System.Drawing.Point(234, 45);
            this.tableSelectionList.Name = "tableSelectionList";
            this.tableSelectionList.Size = new System.Drawing.Size(171, 21);
            this.tableSelectionList.Sorted = true;
            this.tableSelectionList.TabIndex = 1;
            this.tableSelectionList.SelectedIndexChanged += new System.EventHandler(this.tableSelectionList_SelectedIndexChanged);
            // 
            // tableColumnsList
            // 
            this.tableColumnsList.FormattingEnabled = true;
            this.tableColumnsList.Location = new System.Drawing.Point(41, 88);
            this.tableColumnsList.Name = "tableColumnsList";
            this.tableColumnsList.Size = new System.Drawing.Size(364, 184);
            this.tableColumnsList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Database: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Table:";
            // 
            // DataBaseSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableColumnsList);
            this.Controls.Add(this.tableSelectionList);
            this.Controls.Add(this.databaseSelectionList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DataBaseSelection";
            this.Text = "DataBaseSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox databaseSelectionList;
        private System.Windows.Forms.ComboBox tableSelectionList;
        private System.Windows.Forms.CheckedListBox tableColumnsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}