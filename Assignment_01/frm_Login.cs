using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Mgt_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-EMUIAKL\MSSQLSERVER01;Initial Catalog=Employee_App_DB;Integrated Security=True");
        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        private void frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Note.Text = "Enter Valid Username && Password";
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            int cnt = 0;
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (*) from Login_Information Where Username = @Unm And Password = @Pwd";

            Cmd.Parameters.Add("Unm", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (cnt > 0)
            {
                MessageBox.Show("Login Successful", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Add_New_Employee Obj = new frm_Add_New_Employee();
                Obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Incorrect Username Or Password !!!";
                lbl_Note.ForeColor = Color.Red;
            }

            tb_Username.Clear();
            tb_Password.Clear();

            Con_Close();
        }

      
    }
}
