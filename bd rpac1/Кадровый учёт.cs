using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd_rpac1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database7DataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.database7DataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database7DataSet.Образование". При необходимости она может быть перемещена или удалена.
            this.образованиеTableAdapter.Fill(this.database7DataSet.Образование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database7DataSet.График". При необходимости она может быть перемещена или удалена.
            this.графикTableAdapter.Fill(this.database7DataSet.График);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database7DataSet.Кадровый_учёт_сотрудников". При необходимости она может быть перемещена или удалена.
            this.кадровый_учёт_сотрудниковTableAdapter.Fill(this.database7DataSet.Кадровый_учёт_сотрудников);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            кадровыйУчётСотрудниковBindingSource.EndEdit();
            кадровый_учёт_сотрудниковTableAdapter.Update(database7DataSet);
        }

        private void кадровыйУчётСотрудниковBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }
    }
}
