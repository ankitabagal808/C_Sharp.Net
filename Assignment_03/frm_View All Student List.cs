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
    public partial class frm_View_All_Student_List : Form
    {
        public frm_View_All_Student_List()
        {
            InitializeComponent();
        }

        private void frm_View_All_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Mgt_System_DBDataSet.Student_Information' table. You can move, or remove it, as needed.
            this.student_InformationTableAdapter.Fill(this.student_Mgt_System_DBDataSet.Student_Information);

        }
    }
}
