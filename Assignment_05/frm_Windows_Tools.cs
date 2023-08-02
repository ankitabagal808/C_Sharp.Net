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
    public partial class frm_Use_Windows_Controls : Form
    {
       
        public frm_Use_Windows_Controls()
        {
            InitializeComponent();
        }

        private void frm_Use_Windows_Controls_Load(object sender, EventArgs e)
        {
            tb_Employee_Name.Focus();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (Char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool flag = false;

            if (tb_Employee_Name.Text != "")
            {
                Result = tb_Employee_Name.Text;
                if (cmb_Employee_Department.Text != "")
                {
                    Result += " From   " + cmb_Employee_Department.Text + " Department is  ";
                    if(rb_Male.Checked == true)
                    {
                        Result += rb_Male.Text + " Candidate ,Prefers Shift Timing";
                    }
                   else if (rb_Female.Checked == true)
                    {
                        Result += rb_Female.Text + " Candidate, Prefers Shift Timing";
                    }
                    else
                    {
                        MessageBox.Show("Select Gender Of Employee");
                        flag = true;
                    }

                    if (rb_Morning.Checked == true)
                    {
                        Result += rb_Morning.Text + ".";
                    }
                    else if (rb_Evening .Checked == true)
                    {
                        Result += rb_Evening.Text + ".";
                    }
                    else if (rb_Night.Checked == true)
                    {
                        Result += rb_Night.Text + ".";
                    }
                    else
                    {
                        MessageBox.Show("Select Shift Time Of Employee");
                        flag = true;
                    }
                }
                else
                {
                    MessageBox.Show("Select Department Of Employee");
                    flag = true;
                }
            }
            else
            {
                MessageBox.Show("Enter Name  Of Employee");
                flag = true;
            }

            if(flag==false)
            {
                tb_Output.Text = Result;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Employee_Name.Clear();
            tb_Output.Clear();
            cmb_Employee_Department.SelectedIndex = -1;

            rb_Male.Checked = false;
            rb_Female.Checked = false;

            rb_Morning.Checked = false;
            rb_Evening.Checked = false;
            rb_Night.Checked = false;
        }
    }
}
