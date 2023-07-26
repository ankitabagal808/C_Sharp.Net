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
    public partial class frm_Search_Student_Details : Form
    {
        public frm_Search_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=desktop-emuiakl\mssqlserver01;Initial Catalog=Student_Mgt_System_DB;Integrated Security=True;Pooling=False");

        void Con_Open()
        {
            if(Con.State!= ConnectionState.Open)
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

        void Clear_Control()
        {
            tb_RollNo.Clear();
            tb_Name.Clear();
            tb_MobileNo.Clear();
            dtp_DOB.Text = "01/06/1990";
            cmb_Course.SelectedIndex = -1;

            tb_RollNo.Focus();
        }


        private void Search_Student_Details_Load(object sender, EventArgs e)
        {
            tb_RollNo.Focus();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (Char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_RollNo.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select * from Student_Information Where RollNo = @RNo";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_RollNo.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if(Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    tb_MobileNo.Text = (Dr["Mobile No"].ToString());
                    dtp_DOB.Text = (Dr["DOB"].ToString());
                    cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));
                }
                else
                {
                    MessageBox.Show("No Student Found With Given Roll Number !!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_RollNo.Clear();
                    tb_RollNo.Focus();
                }
            }
            else
            {
                MessageBox.Show("First Enter Roll Number", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con.Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }
    }
}
