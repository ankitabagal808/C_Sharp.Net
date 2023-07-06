using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Mgt_System
{
    public partial class frm_Employee_List : Form
    {
        public frm_Employee_List()
        {
            InitializeComponent();
        }

        private void btn_Add_Employee_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee obj = new frm_Add_New_Employee();
            obj.Show();
            this.Hide();
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();
            Obj.Show();
            this.Hide();
        }

        private void frm_Employee_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_App_DBDataSet.Employee_Information' table. You can move, or remove it, as needed.
            this.employee_InformationTableAdapter.Fill(this.employee_App_DBDataSet.Employee_Information);

        }

        private void dgv_Employee_View_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
