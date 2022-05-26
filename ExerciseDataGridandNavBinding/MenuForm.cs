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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            DataGrid dataGrid = new DataGrid();
            dataGrid.Show();
            this.Hide();
        }

        private void btnNavi_Click(object sender, EventArgs e)
        {
            FormDataBinding dataBinding = new FormDataBinding();
            dataBinding.Show();
            this.Hide();
        }

        private void btnExitMenu_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
