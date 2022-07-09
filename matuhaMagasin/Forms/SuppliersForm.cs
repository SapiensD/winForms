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
    public partial class SuppliersForm : Form
    {
        public SuppliersForm()
        {
            InitializeComponent();
            update();
        }
        private void update()
        {
            dataGridView1.DataSource = dataBase.dbGetListSuppliers();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                label1.Visible = true;
                label2.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                label2.Visible = true;
                textBox1.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            dataBase.dbInsertSuppliers(textBox1.Text);
            update();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            dataBase.dbUpdateSuppliers(label2.Text, textBox1.Text);
            update();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            dataBase.dbDeleteSuppliers(label2.Text);
            update();
        }

        private void SuppliersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
