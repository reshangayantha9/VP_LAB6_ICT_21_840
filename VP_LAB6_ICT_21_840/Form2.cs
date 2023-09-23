using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_LAB6_ICT_21_840
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtTask.Text = "";
            txtDescription.Text = "";
            monthCalendar1.SetDate(DateTime.Now);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTask.Text != "" && txtDescription.Text != "")
            {
                dataGridView1.Rows.Add(false,txtTask.Text, txtDescription.Text, monthCalendar1.SelectionRange.Start.ToString("dd MMM yyyy"));
                clear();
            }
            else
            {
                MessageBox.Show("Invalid argument");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells["Column1"].Value = txtTask.Text;
                dataGridView1.CurrentRow.Cells["Column2"].Value = txtDescription.Text;
                dataGridView1.CurrentRow.Cells["Column3"].Value = monthCalendar1.SelectionRange.Start.ToString("dd MMM yyyy");
                dataGridView1.CurrentRow.Cells["Column4"].Value = false;
                clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            bool isDone = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Column4"].Value);
            if (isDone)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
               
            }
            if (dataGridView1.CurrentRow != null)
            {
               
                    txtTask.Text = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
                    txtDescription.Text = dataGridView1.CurrentRow.Cells["Column2"].Value.ToString();
                    if (DateTime.TryParse(dataGridView1.CurrentRow.Cells["Column3"].Value.ToString(), out DateTime selectedDate))
                    {
                        monthCalendar1.SetDate(selectedDate);
                    }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
