using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matuhaMagasin
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            update();
        }

        private void update()
        {
            dataGridView1.DataSource = dataBase.dbGetListProducts();
            dataGridView2.DataSource = dataBase.dbGetListSupplies();
        }

        private void Products_Load(object sender, EventArgs e) { }

        // **** Products **** // 
        private void amountProductText_TextChanged(object sender, EventArgs e)
        {
            var textBox = amountProductText;
            try
            {
                int a = Convert.ToInt32(textBox.Text);
            }
            catch (Exception ex)
            {
                textBox.Text = "";
                MessageBox.Show(ex.Message);
            }
        }
        private void priceProductText_TextChanged(object sender, EventArgs e)
        {
            var textBox = priceProductText;
            try
            {
                double a = Convert.ToDouble(textBox.Text);
            }
            catch (Exception ex)
            {
                textBox.Text = "";
                MessageBox.Show(ex.Message);
            }
        }
        private void addProductsButton_Click(object sender, EventArgs e)
        {
            dataBase.dbInsertProducts(textBox1.Text, Convert.ToInt32(amountProductText.Text), Convert.ToDouble(priceProductText.Text));
            update();
        }

        private void editProductsButton_Click(object sender, EventArgs e)
        {
            dataBase.dbUpdateProducts(idProductsLabel.Text, textBox1.Text, Convert.ToInt32(amountProductText.Text), Convert.ToDouble(priceProductText.Text));
            update();
        }

        private void deleteProductsButton_Click(object sender, EventArgs e)
        {
            dataBase.dbDeleteProducts(idProductsLabel.Text);
            update();
        }


        // **** Supplies **** // 
        private void idSuppliesText_TextChanged(object sender, EventArgs e)
        {
            var textBox = idSuppliersText;
            try
            {
                int a = Convert.ToInt32(textBox.Text);
            }
            catch (Exception ex)
            {
                textBox.Text = "";
                MessageBox.Show(ex.Message);
            }
        }
        private void idProductText_TextChanged(object sender, EventArgs e)
        {
            var textBox = idProductText;
            try
            {
                int a = Convert.ToInt32(textBox.Text);
            }
            catch (Exception ex)
            {
                textBox.Text = "";
                MessageBox.Show(ex.Message);
            }
        }
        private void amountSuppliesText_TextChanged(object sender, EventArgs e)
        {
            var textBox = amountSuppliesText;
            try
            {
                int a = Convert.ToInt32(textBox.Text);
            }
            catch (Exception ex)
            {
                textBox.Text = "";
                MessageBox.Show(ex.Message);
            }
        }
        private void totalPriceSuppliesText_TextChanged(object sender, EventArgs e)
        {
            var textBox = totalPriceSuppliesText;
            try
            {
                double a = Convert.ToDouble(textBox.Text);
            }
            catch (Exception ex)
            {
                textBox.Text = "";
                MessageBox.Show(ex.Message);
            }
        }

        private void addSuppliesButton_Click(object sender, EventArgs e)
        {
            dataBase.dbInsertSupplies(idSuppliersText.Text, idProductText.Text, Convert.ToInt32(amountSuppliesText.Text), Convert.ToDouble(totalPriceSuppliesText.Text), dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day);
            update();
        }

        private void editSuppliesButton_Click(object sender, EventArgs e)
        {
            dataBase.dbUpdateSupplies(idSuppliesLabel.Text, idSuppliersText.Text, idProductText.Text, Convert.ToInt32(amountSuppliesText.Text), Convert.ToDouble(totalPriceSuppliesText.Text), dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day);
            update();
        }

        private void deleteSuppliesButton_Click(object sender, EventArgs e)
        {
            dataBase.dbDeleteSupplies(idSuppliesLabel.Text);
            update();
        }


        // **** DataGridViews **** // 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                editLabel1.Visible = true;
                idProductsLabel.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                idProductsLabel.Visible = true;

                textBox1.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                amountProductText.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                priceProductText.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                editLabel2.Visible = true;
                idSuppliesLabel.Text = dataGridView2[0, e.RowIndex].Value.ToString();
                idSuppliesLabel.Visible = true;

                idSuppliersText.Text = dataGridView2[1, e.RowIndex].Value.ToString();
                idProductText.Text = dataGridView2[2, e.RowIndex].Value.ToString();
                amountSuppliesText.Text = dataGridView2[3, e.RowIndex].Value.ToString();
                totalPriceSuppliesText.Text = dataGridView2[4, e.RowIndex].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView2[5, e.RowIndex].Value;
            }
        }
    }
}
