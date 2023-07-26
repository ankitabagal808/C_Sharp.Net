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
    public partial class frm_Update_Student_Details : Form
    {
        public frm_Update_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=desktop-emuiakl\mssqlserver01;Initial Catalog=Student_Mgt_System_DB;Integrated Security=True;Pooling=False");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
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

        void Clear_Controls()
        {
            tb_RollNo.Text="";
            tb_Name.Text = "";
            tb_MobileNo.Text = "";
            dtp_DOB.Text = "01/06/1990";
            cmb_Course.SelectedIndex = -1;

            tb_RollNo.Focus();
        }

        void Enable_Controls()
        {
            tb_RollNo.Enabled = false;
            tb_Name.Enabled = true;
            tb_MobileNo.Enabled = true;
            dtp_DOB.Enabled = true;
            cmb_Course.Enabled = true;
        }

        void Disable_Controls()
        {
            tb_RollNo.Enabled = true;
            tb_Name.Enabled = false;
            tb_MobileNo.Enabled = false;
            dtp_DOB.Enabled = false;
            cmb_Course.Enabled = false;
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

        private void frm_Update_Student_Details_Load(object sender, EventArgs e)
        {
            tb_RollNo.Focus();
            Disable_Controls();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_RollNo.Text != "")
            {
               SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Select * from Student_Information Where RollNo = @RNo";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_RollNo.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    tb_MobileNo.Text = (Dr["Mobile No"].ToString());
                    dtp_DOB.Text = (Dr["DOB"].ToString());
                    cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));

                    Enable_Controls();
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Name.Text != "" && tb_MobileNo.Text!= "" && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con; ;
                Cmd.CommandText = "Update Student_Information Set Name= @Nm, Mobileno =@MNo,DOB=@DOB,Course = @Course Where RollNo =2RNo";

                Cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_RollNo.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_MobileNo.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date; 
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Succesfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill All The Fields !!", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con_Close();
        }
    }
}
