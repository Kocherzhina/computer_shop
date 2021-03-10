using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class tablefrm : Form
    {
        
        public tablefrm()
        {
            InitializeComponent();
        }

        private void pCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.makerProdBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st01DataSet);

        }

        private void tablefrm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st01DataSet.makerProd". При необходимости она может быть перемещена или удалена.
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private DataGridViewColumn COL;
        private void button1_Click(object sender, EventArgs e)
        { 
            COL = new System.Windows.Forms.DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn4;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn6;
                    break;
            }
            if (radioButton1.Checked)
                makerProdDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Ascending);
            else
                makerProdDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            makerProdBindingSource.Filter = "maker='" + comboBox1 + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            makerProdBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < makerProdDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < makerProdDataGridView.RowCount - 1; j++)
                {
                    makerProdDataGridView[i, j].Style.BackColor = Color.White;
                    makerProdDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < makerProdDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < makerProdDataGridView.RowCount - 1; j++)
                {
                    if (makerProdDataGridView[i,
                    j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        makerProdDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        makerProdDataGridView[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void makerProdDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pCBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void makerProdDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
