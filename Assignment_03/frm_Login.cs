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

namespace Student_Mgt_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=desktop-emuiakl\mssqlserver01;Initial Catalog=Student_Mgt_System_DB;Integrated Security=True;Pooling=False");
        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if(Con.State != ConnectionState.Closed)
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

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Login_Information Where Username =@UNm And Password =@Pwd";

            Cmd.Parameters.Add("UNm", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if(Cnt>0)
            {
                MessageBox.Show("Login Successfull !!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Common_Content.Log_UserName = "Welcome " + tb_Username.Text;

                MDI_Shivaji_University_Student_App  Obj = new MDI_Shivaji_University_Student_App();
                Obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Invalid Username Or Password !!";
                lbl_Note.ForeColor = Color.Red;
            }

            tb_Username.Text = "";
            tb_Password.Text = "";

            tb_Username.Focus();

            Con_Close();
        }
    }
}
