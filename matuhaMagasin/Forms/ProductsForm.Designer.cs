namespace matuhaMagasin
{
    partial class ProductsForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.amountProductText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.editProductsButton = new System.Windows.Forms.Button();
            this.addProductsButton = new System.Windows.Forms.Button();
            this.idProductsLabel = new System.Windows.Forms.Label();
            this.editLabel1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.priceProductText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalPriceSuppliesText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idProductText = new System.Windows.Forms.TextBox();
            this.idSuppliersText = new System.Windows.Forms.TextBox();
            this.editSuppliesButton = new System.Windows.Forms.Button();
            this.addSuppliesButton = new System.Windows.Forms.Button();
            this.idSuppliesLabel = new System.Windows.Forms.Label();
            this.editLabel2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.amountSuppliesText = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.deleteProductsButton = new System.Windows.Forms.Button();
            this.deleteSuppliesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Количество :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Название :";
            // 
            // amountProductText
            // 
            this.amountProductText.Location = new System.Drawing.Point(541, 162);
            this.amountProductText.Name = "amountProductText";
            this.amountProductText.Size = new System.Drawing.Size(190, 22);
            this.amountProductText.TabIndex = 21;
            this.amountProductText.TextChanged += new System.EventHandler(this.amountProductText_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(541, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 22);
            this.textBox1.TabIndex = 20;
            // 
            // editProductsButton
            // 
            this.editProductsButton.BackColor = System.Drawing.Color.SteelBlue;
            this.editProductsButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editProductsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editProductsButton.Location = new System.Drawing.Point(640, 257);
            this.editProductsButton.Name = "editProductsButton";
            this.editProductsButton.Size = new System.Drawing.Size(92, 40);
            this.editProductsButton.TabIndex = 17;
            this.editProductsButton.Text = "Изменить";
            this.editProductsButton.UseVisualStyleBackColor = false;
            this.editProductsButton.Click += new System.EventHandler(this.editProductsButton_Click);
            // 
            // addProductsButton
            // 
            this.addProductsButton.BackColor = System.Drawing.Color.SteelBlue;
            this.addProductsButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProductsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addProductsButton.Location = new System.Drawing.Point(541, 257);
            this.addProductsButton.Name = "addProductsButton";
            this.addProductsButton.Size = new System.Drawing.Size(92, 40);
            this.addProductsButton.TabIndex = 16;
            this.addProductsButton.Text = "Добавить";
            this.addProductsButton.UseVisualStyleBackColor = false;
            this.addProductsButton.Click += new System.EventHandler(this.addProductsButton_Click);
            // 
            // idProductsLabel
            // 
            this.idProductsLabel.AutoSize = true;
            this.idProductsLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProductsLabel.Location = new System.Drawing.Point(650, 43);
            this.idProductsLabel.Name = "idProductsLabel";
            this.idProductsLabel.Size = new System.Drawing.Size(29, 35);
            this.idProductsLabel.TabIndex = 15;
            this.idProductsLabel.Text = "0";
            this.idProductsLabel.Visible = false;
            // 
            // editLabel1
            // 
            this.editLabel1.AutoSize = true;
            this.editLabel1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLabel1.Location = new System.Drawing.Point(535, 43);
            this.editLabel1.Name = "editLabel1";
            this.editLabel1.Size = new System.Drawing.Size(109, 35);
            this.editLabel1.TabIndex = 14;
            this.editLabel1.Text = "Edit  ID :";
            this.editLabel1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(517, 426);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Цена :";
            // 
            // priceProductText
            // 
            this.priceProductText.Location = new System.Drawing.Point(541, 206);
            this.priceProductText.Name = "priceProductText";
            this.priceProductText.Size = new System.Drawing.Size(190, 22);
            this.priceProductText.TabIndex = 24;
            this.priceProductText.TextChanged += new System.EventHandler(this.priceProductText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1311, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Итоговая цена :";
            // 
            // totalPriceSuppliesText
            // 
            this.totalPriceSuppliesText.Location = new System.Drawing.Point(1311, 257);
            this.totalPriceSuppliesText.Name = "totalPriceSuppliesText";
            this.totalPriceSuppliesText.Size = new System.Drawing.Size(190, 22);
            this.totalPriceSuppliesText.TabIndex = 35;
            this.totalPriceSuppliesText.TextChanged += new System.EventHandler(this.totalPriceSuppliesText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1311, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "ID продукта :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1311, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "ID поставщика :";
            // 
            // idProductText
            // 
            this.idProductText.Location = new System.Drawing.Point(1311, 162);
            this.idProductText.Name = "idProductText";
            this.idProductText.Size = new System.Drawing.Size(190, 22);
            this.idProductText.TabIndex = 32;
            this.idProductText.TextChanged += new System.EventHandler(this.idProductText_TextChanged);
            // 
            // idSuppliersText
            // 
            this.idSuppliersText.Location = new System.Drawing.Point(1311, 118);
            this.idSuppliersText.Name = "idSuppliersText";
            this.idSuppliersText.Size = new System.Drawing.Size(190, 22);
            this.idSuppliersText.TabIndex = 31;
            this.idSuppliersText.TextChanged += new System.EventHandler(this.idSuppliesText_TextChanged);
            // 
            // editSuppliesButton
            // 
            this.editSuppliesButton.BackColor = System.Drawing.Color.SteelBlue;
            this.editSuppliesButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editSuppliesButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editSuppliesButton.Location = new System.Drawing.Point(1410, 349);
            this.editSuppliesButton.Name = "editSuppliesButton";
            this.editSuppliesButton.Size = new System.Drawing.Size(92, 40);
            this.editSuppliesButton.TabIndex = 30;
            this.editSuppliesButton.Text = "Изменить";
            this.editSuppliesButton.UseVisualStyleBackColor = false;
            this.editSuppliesButton.Click += new System.EventHandler(this.editSuppliesButton_Click);
            // 
            // addSuppliesButton
            // 
            this.addSuppliesButton.BackColor = System.Drawing.Color.SteelBlue;
            this.addSuppliesButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSuppliesButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addSuppliesButton.Location = new System.Drawing.Point(1311, 349);
            this.addSuppliesButton.Name = "addSuppliesButton";
            this.addSuppliesButton.Size = new System.Drawing.Size(92, 40);
            this.addSuppliesButton.TabIndex = 29;
            this.addSuppliesButton.Text = "Добавить";
            this.addSuppliesButton.UseVisualStyleBackColor = false;
            this.addSuppliesButton.Click += new System.EventHandler(this.addSuppliesButton_Click);
            // 
            // idSuppliesLabel
            // 
            this.idSuppliesLabel.AutoSize = true;
            this.idSuppliesLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idSuppliesLabel.Location = new System.Drawing.Point(1420, 43);
            this.idSuppliesLabel.Name = "idSuppliesLabel";
            this.idSuppliesLabel.Size = new System.Drawing.Size(29, 35);
            this.idSuppliesLabel.TabIndex = 28;
            this.idSuppliesLabel.Text = "0";
            this.idSuppliesLabel.Visible = false;
            // 
            // editLabel2
            // 
            this.editLabel2.AutoSize = true;
            this.editLabel2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLabel2.Location = new System.Drawing.Point(1305, 43);
            this.editLabel2.Name = "editLabel2";
            this.editLabel2.Size = new System.Drawing.Size(109, 35);
            this.editLabel2.TabIndex = 27;
            this.editLabel2.Text = "Edit  ID :";
            this.editLabel2.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(743, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(556, 426);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1311, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "Количество :";
            // 
            // amountSuppliesText
            // 
            this.amountSuppliesText.Location = new System.Drawing.Point(1311, 206);
            this.amountSuppliesText.Name = "amountSuppliesText";
            this.amountSuppliesText.Size = new System.Drawing.Size(190, 22);
            this.amountSuppliesText.TabIndex = 37;
            this.amountSuppliesText.TextChanged += new System.EventHandler(this.amountSuppliesText_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1311, 298);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 22);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // deleteProductsButton
            // 
            this.deleteProductsButton.BackColor = System.Drawing.Color.Brown;
            this.deleteProductsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteProductsButton.Location = new System.Drawing.Point(639, 314);
            this.deleteProductsButton.Name = "deleteProductsButton";
            this.deleteProductsButton.Size = new System.Drawing.Size(92, 40);
            this.deleteProductsButton.TabIndex = 40;
            this.deleteProductsButton.Text = "Удалить";
            this.deleteProductsButton.UseVisualStyleBackColor = false;
            this.deleteProductsButton.Click += new System.EventHandler(this.deleteProductsButton_Click);
            // 
            // deleteSuppliesButton
            // 
            this.deleteSuppliesButton.BackColor = System.Drawing.Color.Brown;
            this.deleteSuppliesButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteSuppliesButton.Location = new System.Drawing.Point(1409, 406);
            this.deleteSuppliesButton.Name = "deleteSuppliesButton";
            this.deleteSuppliesButton.Size = new System.Drawing.Size(92, 40);
            this.deleteSuppliesButton.TabIndex = 41;
            this.deleteSuppliesButton.Text = "Удалить";
            this.deleteSuppliesButton.UseVisualStyleBackColor = false;
            this.deleteSuppliesButton.Click += new System.EventHandler(this.deleteSuppliesButton_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 523);
            this.Controls.Add(this.deleteSuppliesButton);
            this.Controls.Add(this.deleteProductsButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.amountSuppliesText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalPriceSuppliesText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.idProductText);
            this.Controls.Add(this.idSuppliersText);
            this.Controls.Add(this.editSuppliesButton);
            this.Controls.Add(this.addSuppliesButton);
            this.Controls.Add(this.idSuppliesLabel);
            this.Controls.Add(this.editLabel2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceProductText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.amountProductText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.editProductsButton);
            this.Controls.Add(this.addProductsButton);
            this.Controls.Add(this.idProductsLabel);
            this.Controls.Add(this.editLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductsForm";
            this.Text = "Products and Supplies";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amountProductText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button editProductsButton;
        private System.Windows.Forms.Button addProductsButton;
        private System.Windows.Forms.Label idProductsLabel;
        private System.Windows.Forms.Label editLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox priceProductText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox idProductText;
        private System.Windows.Forms.TextBox idSuppliersText;
        private System.Windows.Forms.Button editSuppliesButton;
        private System.Windows.Forms.Button addSuppliesButton;
        private System.Windows.Forms.Label idSuppliesLabel;
        private System.Windows.Forms.Label editLabel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox amountSuppliesText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button deleteProductsButton;
        private System.Windows.Forms.Button deleteSuppliesButton;
        private System.Windows.Forms.TextBox totalPriceSuppliesText;
    }
}