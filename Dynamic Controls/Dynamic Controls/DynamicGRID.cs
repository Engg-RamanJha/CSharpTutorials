using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Controls
{
    public partial class DynamicGRID : Form
    {
        public DynamicGRID()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Dropdown Type","ITEM Selection");
            dataGridView1.Columns.Add("Variable", "Variable");
            dataGridView1.Rows.Add();

            //dataGridView1.Rows[1].Cells[0] = new DataGridViewTextBoxCell();
            //DataGridViewTextBoxCell dd = (DataGridViewTextBoxCell)(dataGridView1.Rows[1].Cells[0]);

            dataGridView1.Rows[0].Cells[0] = new DataGridViewComboBoxCell();
            DataGridViewComboBoxCell dgcbc = (DataGridViewComboBoxCell)(dataGridView1.Rows[0].Cells[0]);
            string[] dbc = new string[3] {"Text Box","Check Box","Datetime"};
            dgcbc.DataSource = dbc;
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged += LastColumnComboSelectionChanged;
            }
        }

        private void LastColumnComboSelectionChanged(object sender, EventArgs e)
        {
            var currentcell = dataGridView1.CurrentCellAddress;
            var sendingCB = sender as DataGridViewComboBoxEditingControl;
            
            DataGridViewTextBoxCell cel = (DataGridViewTextBoxCell)dataGridView1.Rows[currentcell.Y].Cells[1];
            cel.Value = sendingCB.EditingControlFormattedValue.ToString();
        }

        private void DynamicGRID_Load(object sender, EventArgs e)
        {

        }
    }
}
