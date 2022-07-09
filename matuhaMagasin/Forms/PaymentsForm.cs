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
    public partial class PaymentsForm : Form
    {
        public PaymentsForm()
        {
            InitializeComponent();
            update();
        }
        private void update()
        {
            dataGridView1.DataSource = dataBase.dbGetListPayments();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textBox = textBox1;
            try
            {
                int a = Convert.ToInt32(textBox.Text);
            }
            catch(Exception ex) 
            {
                textBox.Text = "";
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var textBox = textBox2;
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

        private void addButton_Click(object sender, EventArgs e)
        {
            dataBase.dbInsertPayments(textBox1.Text, Convert.ToDouble(textBox2.Text), dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day);
            update();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            dataBase.dbUpdatePayments(label2.Text, textBox1.Text, Convert.ToDouble(textBox2.Text), dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day);
            update();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            dataBase.dbDeletePayments(label2.Text);
            update();
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
                textBox2.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1[3, e.RowIndex].Value;
            }
        }
    }
}
