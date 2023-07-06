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
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
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
        void Auto_Incr()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Employee_Information";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Id) from Employee_Information";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 101;
            }
            tb_Id.Text = Convert.ToString(Cnt);

            Con_Close();
        }

        void Clear_Controls()
        {
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.Text = "31-12-2009";
            cmb_Designation.SelectedIndex = -1;

            Auto_Incr();
            tb_Id.Focus();
        }
       
        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Id.Focus();
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (Char)Keys.Back) || (e.KeyChar == (Char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
        
       private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        { 
            Con_Open();

            if(tb_Id.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != ""&& cmb_Designation.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Employee_Information Values(@Id,@Nm,@MobNo,@DOB,@Des)";

                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Id.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Des", SqlDbType.NVarChar).Value = cmb_Designation.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully !!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();

            } 
            else
            {
                MessageBox.Show("First Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();

        }
        private void btn_Employee_List_Click(object sender, EventArgs e)
        {
            frm_Employee_List Obj = new frm_Employee_List();
            Obj.Show();
            this.Hide();
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();
            Obj.Show();
            this.Hide();
        }

        
    }
}

