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

namespace _02_Student_Mgt_System
{
    public partial class frm_Add_Course : Form
    {
        public frm_Add_Course()
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

       
        void Auto_Incr()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Course_List";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Course Id) from Course_List";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }

            else
            {
                Cnt = 1;
            }

            tb_Course_ID.Text = Convert.ToString(Cnt);

            Con_Close();
        }

        void Clear_Controls()
        {
            tb_Course_Name.Clear();
            Auto_Incr();
        }

        private void frm_Add_Course_Load(object sender, EventArgs e)
        {
            Auto_Incr();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Course_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Course_List Values(@Id, @Nm)";

                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Course_ID.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.NVarChar).Value = tb_Course_Name.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Course Inserted Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
                Auto_Incr();
            }
            else
            {
                MessageBox.Show("Fill The Course Field !!", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Course_Name.Focus();
            }

            Con_Close();
        }
    }
}
