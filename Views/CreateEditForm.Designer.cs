namespace YStore.Views
{
    partial class CreateEditForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbName = new TextBox();
            tbPrice = new TextBox();
            tbDescription = new TextBox();
            tbStockQuantity = new TextBox();
            btnSave = new Button();
            btcCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 75);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 0;
            label1.Text = "ProductId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 122);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 169);
            label3.Name = "label3";
            label3.Size = new Size(36, 17);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 218);
            label4.Name = "label4";
            label4.Size = new Size(74, 17);
            label4.TabIndex = 3;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 269);
            label5.Name = "label5";
            label5.Size = new Size(87, 17);
            label5.TabIndex = 4;
            label5.Text = "StockQuantity";
            // 
            // tbName
            // 
            tbName.Location = new Point(182, 114);
            tbName.Name = "tbName";
            tbName.Size = new Size(231, 25);
            tbName.TabIndex = 5;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(182, 161);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(231, 25);
            tbPrice.TabIndex = 6;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(182, 210);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(231, 25);
            tbDescription.TabIndex = 7;
            // 
            // tbStockQuantity
            // 
            tbStockQuantity.Location = new Point(182, 261);
            tbStockQuantity.Name = "tbStockQuantity";
            tbStockQuantity.Size = new Size(231, 25);
            tbStockQuantity.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(182, 320);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(79, 24);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btcCancel
            // 
            btcCancel.Location = new Point(288, 320);
            btcCancel.Name = "btcCancel";
            btcCancel.Size = new Size(79, 24);
            btcCancel.TabIndex = 10;
            btcCancel.Text = "Cancel";
            btcCancel.UseVisualStyleBackColor = true;
            btcCancel.Click += btcCancel_Click;
            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 398);
            Controls.Add(btcCancel);
            Controls.Add(btnSave);
            Controls.Add(tbStockQuantity);
            Controls.Add(tbDescription);
            Controls.Add(tbPrice);
            Controls.Add(tbName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateEditForm";
            Text = "CreateEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbName;
        private TextBox tbPrice;
        private TextBox tbDescription;
        private TextBox tbStockQuantity;
        private Button btnSave;
        private Button btcCancel;
    }
}