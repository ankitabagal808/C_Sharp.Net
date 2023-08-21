using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Student_Mgt_System
{
    public partial class MDI_Shivaji_University_Student_App : Form
    {
        public MDI_Shivaji_University_Student_App()
        {
            InitializeComponent();
        }

        private void MDI_Shivaji_University_Student_App_Load(object sender, EventArgs e)
        {
            lbl_UserName.Text = Common_Content.Log_UserName;
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details Obj = new frm_Add_Student_Details();
            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details Obj = new frm_Search_Student_Details();
            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Student_Details Obj = new frm_Update_Student_Details();
            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_All_Student_List Obj = new frm_View_All_Student_List();
            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Course Obj = new frm_Add_Course();
            Obj.MdiParent = this;
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
        }

        private void coursesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Course_List Obj = new frm_Course_List();
            Obj.MdiParent = this;
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.Exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want To Logout ??", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                Obj.Show();
                this.Hide();
            }

        }
    }
}
