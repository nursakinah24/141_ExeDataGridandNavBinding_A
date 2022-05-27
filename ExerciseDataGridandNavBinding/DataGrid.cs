using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseDataGridandNavBinding
{
    public partial class DataGrid : Form
    {
        public DataGrid()
        {
            InitializeComponent();
        }

        private void DataGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void btnExitDG_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormDataGrid fDataGrid = new FormDataGrid();
            fDataGrid.labelNIM.Text = this.dataGridView.CurrentRow.Cells[0].Value.ToString();
            fDataGrid.labelName.Text = this.dataGridView.CurrentRow.Cells[1].Value.ToString();
            fDataGrid.labelSex.Text = this.dataGridView.CurrentRow.Cells[2].Value.ToString();
            fDataGrid.labelAddress.Text = this.dataGridView.CurrentRow.Cells[3].Value.ToString();
            fDataGrid.labelPhone.Text = this.dataGridView.CurrentRow.Cells[4].Value.ToString();
            fDataGrid.Show();
            this.Hide();
        }
    }
}
