using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generic_list
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<Employer> employers = new List<Employer>();
        Employer employer = new Employer();
        int counter = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            
            employer.Name = textBox1.Text;
            employer.Surname = textBox2.Text;
            employer.Email = textBox3.Text;
            employer.Position = textBox4.Text;
            employer.Salary = Convert.ToInt32(textBox5.Text);
            employer.ID = counter++;
            employers.Add(employer);
            
            
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = employer.Name;
                row.Cells[1].Value = employer.Surname;
                row.Cells[2].Value = employer.Email;
                row.Cells[3].Value = employer.Position;
                row.Cells[4].Value = employer.Salary;
                row.Cells[5].Value = employer.ID;
                dataGridView1.Rows.Add(row);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dataRow = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = dataRow.Cells[1].Value.ToString();
                textBox2.Text = dataRow.Cells[2].Value.ToString();
                textBox3.Text = dataRow.Cells[3].Value.ToString();
                textBox4.Text = dataRow.Cells[4].Value.ToString();
                textBox5.Text = dataRow.Cells[5].Value.ToString();

                int index = dataGridView1.SelectedRows[0].Index;
            }
        }
    }
}
