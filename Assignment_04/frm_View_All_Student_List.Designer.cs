
namespace _02_Student_Mgt_System
{
    partial class frm_View_All_Student_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_View_All_Student_List = new System.Windows.Forms.Label();
            this.dgv_View_All_Student_List = new System.Windows.Forms.DataGridView();
            this.student_Mgt_System_DBDataSet = new _02_Student_Mgt_System.Student_Mgt_System_DBDataSet();
            this.studentsInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_InformationTableAdapter = new _02_Student_Mgt_System.Student_Mgt_System_DBDataSetTableAdapters.Students_InformationTableAdapter();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Student_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Mgt_System_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_All_Student_List
            // 
            this.lbl_View_All_Student_List.AutoSize = true;
            this.lbl_View_All_Student_List.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_View_All_Student_List.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_All_Student_List.Location = new System.Drawing.Point(210, 9);
            this.lbl_View_All_Student_List.Name = "lbl_View_All_Student_List";
            this.lbl_View_All_Student_List.Size = new System.Drawing.Size(503, 67);
            this.lbl_View_All_Student_List.TabIndex = 1;
            this.lbl_View_All_Student_List.Text = "View All Student List";
            // 
            // dgv_View_All_Student_List
            // 
            this.dgv_View_All_Student_List.AllowUserToAddRows = false;
            this.dgv_View_All_Student_List.AllowUserToDeleteRows = false;
            this.dgv_View_All_Student_List.AutoGenerateColumns = false;
            this.dgv_View_All_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_All_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_All_Student_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_View_All_Student_List.DataSource = this.studentsInformationBindingSource;
            this.dgv_View_All_Student_List.Location = new System.Drawing.Point(2, 95);
            this.dgv_View_All_Student_List.Name = "dgv_View_All_Student_List";
            this.dgv_View_All_Student_List.ReadOnly = true;
            this.dgv_View_All_Student_List.RowHeadersWidth = 62;
            this.dgv_View_All_Student_List.RowTemplate.Height = 28;
            this.dgv_View_All_Student_List.Size = new System.Drawing.Size(973, 618);
            this.dgv_View_All_Student_List.TabIndex = 2;
            // 
            // student_Mgt_System_DBDataSet
            // 
            this.student_Mgt_System_DBDataSet.DataSetName = "Student_Mgt_System_DBDataSet";
            this.student_Mgt_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsInformationBindingSource
            // 
            this.studentsInformationBindingSource.DataMember = "Students_Information";
            this.studentsInformationBindingSource.DataSource = this.student_Mgt_System_DBDataSet;
            // 
            // students_InformationTableAdapter
            // 
            this.students_InformationTableAdapter.ClearBeforeFill = true;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "RollNo";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "RollNo";
            this.rollNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile No";
            this.mobileNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_View_All_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.dgv_View_All_Student_List);
            this.Controls.Add(this.lbl_View_All_Student_List);
            this.Name = "frm_View_All_Student_Details";
            this.Text = "View All Student Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Student_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Mgt_System_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsInformationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_All_Student_List;
        private System.Windows.Forms.DataGridView dgv_View_All_Student_List;
        private Student_Mgt_System_DBDataSet student_Mgt_System_DBDataSet;
        private System.Windows.Forms.BindingSource studentsInformationBindingSource;
        private Student_Mgt_System_DBDataSetTableAdapters.Students_InformationTableAdapter students_InformationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}