using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Mgt_System
{
    public partial class frm_CheckBox_CheckListBox : Form
    {
        public frm_CheckBox_CheckListBox()
        {
            InitializeComponent();
        }

        private void frm_CheckBox_CheckListBox_Load(object sender, EventArgs e)
        {
            tb_Employee_Name.Focus();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool Flag = true, LFlag = true ;

            if (tb_Employee_Name.Text != "")
            {
                Result += tb_Employee_Name.Text + " is From ";
                lbl_Employee_Name_Error.Visible = false;
            }
            else
            {
                lbl_Employee_Name_Error.Text = "Enter Employee Name";
                lbl_Employee_Name_Error.Visible = true;
                Flag = false;
            }

            if(cmb_Employee_Department.Text != "")
            {
                Result += cmb_Employee_Department.Text + " Department";
                lbl_Employee_Department_Error.Visible = false;
            }
            else
            {
                lbl_Employee_Department_Error.Text = "Select Employee Department";
                lbl_Employee_Department_Error.Visible = true;
                Flag = false;
            }

            if(rb_Male.Checked == true)
            {
                Result += " is" + rb_Male.Text + " And his Knowns";
                lbl_Gender_Error.Visible = false;
            }
            else if(rb_Female.Checked == true)
            {
                Result += " is" + rb_Female.Text + " And she has Knowns ";
                lbl_Gender_Error.Visible = false;
            }
            else
            {
                lbl_Gender_Error.Text = "Select Employee Gender";
                lbl_Gender_Error.Visible = true;
                Flag = false;
            }

            if(cb_Marathi.Checked == true)
            {
                Result += cb_Marathi.Text = " , ";
                lbl_Known_Languages_Error.Visible = false;
                LFlag = false;
            }

            if (cb_Hindi.Checked== true)
            {
                 Result +=  cb_Hindi.Text + " , ";
                 lbl_Known_Languages_Error.Visible = false;
                 LFlag = false;
            }

            if (cb_English.Checked == true)
            {
                 Result +=  cb_English.Text + " , ";
                 lbl_Known_Languages_Error.Visible = false;
                 LFlag = false;
            }

            if (cb_French.Checked == true)
            {
                 Result +=  cb_French.Text + ",";
                 lbl_Known_Languages_Error.Visible = false;
                 LFlag = false;
            }
                    
            if(LFlag == true)
            {
                lbl_Known_Languages_Error.Text = "Select Languages";
                lbl_Known_Languages_Error.Visible = true;
                Flag = false;
            }

            int cnt = clb_Hobbies.CheckedItems.Count;

            if(cnt > 0)
            {
                lbl_Hobbies_Error.Visible = false;
                Result += " And Has Hobbies are";

                for (int i = 0; i < clb_Hobbies.Items.Count; i++)
                {
                    if (clb_Hobbies.GetItemChecked(i))
                    {
                        if (cnt > 1)
                        {
                            Result += clb_Hobbies.Items[i] + " , ";
                        }
                        else
                        {
                            Result += clb_Hobbies.Items[i] + ".";
                            break;
                        }

                        cnt--;
                    }
                }
            }
            else
            {
                lbl_Hobbies_Error.Visible = false;
                lbl_Hobbies_Error.Visible = true;
                Flag = false;
            }

            if(Flag == false)
            {
                lbl_Result.Visible = false;
            }
            else
            {
                lbl_Result.Text = Result;
                lbl_Result.Visible = true;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Employee_Name.Clear();
            cmb_Employee_Department.SelectedIndex = -1;

            rb_Male.Checked = false;
            rb_Female.Checked = false;

            cb_Marathi.Checked = false;
            cb_Hindi.Checked = false;
            cb_English.Checked = false;
            cb_French.Checked = false;

            for(int i = 0; i< clb_Hobbies.Items.Count; i++)
            {
                clb_Hobbies.SetItemChecked(i, false);
            }
            lbl_Result.Visible = false;
        }
    }
}
