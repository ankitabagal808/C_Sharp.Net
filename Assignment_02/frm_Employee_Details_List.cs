using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Employee_Mgt_System
{
    public partial class frm_Employee_Details_List : Form
    {
        public frm_Employee_Details_List()
        {
            InitializeComponent();
        }

        private void btn_Add_Employee_Click(object sender, EventArgs e)
        {
            frm_Add_Employee_Information obj = new frm_Add_Employee_Information();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();
            Obj.Show();
            this.Hide();
        }
        private void frm_Employee_Details_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_App_DBDataSet.Employees_Information' table. You can move, or remove it, as needed.
            this.employees_InformationTableAdapter.Fill(this.employee_App_DBDataSet.Employees_Information);

            lbl_Username.Text = Common_Content.Log_Username;
        }
    }
}
