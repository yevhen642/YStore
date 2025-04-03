namespace YStore
{
    partial class Form1
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
            button1 = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataTable).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(24, 26);
            button1.Name = "button1";
            button1.Size = new Size(102, 36);
            button1.TabIndex = 1;
            button1.Text = "Products";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(24, 93);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(102, 35);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(164, 93);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(97, 35);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(304, 93);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 35);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button4_Click;
            // 
            // dataTable
            // 
            dataTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTable.Location = new Point(24, 143);
            dataTable.MultiSelect = false;
            dataTable.Name = "dataTable";
            dataTable.RowHeadersVisible = false;
            dataTable.RowHeadersWidth = 43;
            dataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataTable.Size = new Size(760, 322);
            dataTable.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 490);
            Controls.Add(dataTable);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(button1);
            Name = "Form1";
            Text = "ShowDataForm";
            ((System.ComponentModel.ISupportInitialize)dataTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataTable;
    }
}
