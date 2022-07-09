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
    public partial class Main : Form
    {
        List<string> productsID = new List<string>();
        public string fileName = "D:/report.xlsx";

        public Main()
        {
            InitializeComponent();
            update();
        }
        private void update()
        {
            dataGridView1.DataSource = dataBase.dbGetListProducts();
        }

        private void Main_Load(object sender, EventArgs e) { }
        private void products_suppliesButton_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.ShowDialog();
        }

        private void suppliersButton_Click(object sender, EventArgs e)
        {
            SuppliersForm suppliersForm = new SuppliersForm();
            suppliersForm.ShowDialog();
        }

        private void paymentsButton_Click(object sender, EventArgs e)
        {
            PaymentsForm paymentsForm = new PaymentsForm();
            paymentsForm.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            update();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(dataGridView1[0, e.RowIndex].Value == "⌦︎")
                {
                    productsID.Remove(dataGridView1[1, e.RowIndex].Value.ToString());
                    dataGridView1[0, e.RowIndex].Value = "";
                }
                else
                {
                    productsID.Add(dataGridView1[1, e.RowIndex].Value.ToString());
                    dataGridView1[0, e.RowIndex].Value = "⌦︎";   
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Products = "";
            foreach(var p in productsID)
            {
                Products += "'" + p.ToString() + "' ";
            }
            MessageBox.Show(Products);
            excel.createExcelReport(dataBase.dbGetReport(productsID, dateTimePicker1.Value, dateTimePicker2.Value), fileName);
            MessageBox.Show("экселька готова!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            fileName = openFileDialog1.FileName.ToString();
            //MessageBox.Show("");
        }
    }
}
