
namespace _02_Student_Mgt_System
{
    partial class frm_Course_List
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Mgt_System_DBDataSet1 = new _02_Student_Mgt_System.Student_Mgt_System_DBDataSet1();
            this.lbl_Course_List = new System.Windows.Forms.Label();
            this.course_ListTableAdapter = new _02_Student_Mgt_System.Student_Mgt_System_DBDataSet1TableAdapters.Course_ListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Mgt_System_DBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIdDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(974, 530);
            this.dataGridView1.TabIndex = 0;
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "Course Id";
            this.courseIdDataGridViewTextBoxColumn.HeaderText = "Course Id";
            this.courseIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            this.courseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "Course Name";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "Course Name";
            this.courseNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseListBindingSource
            // 
            this.courseListBindingSource.DataMember = "Course_List";
            this.courseListBindingSource.DataSource = this.student_Mgt_System_DBDataSet1;
            // 
            // student_Mgt_System_DBDataSet1
            // 
            this.student_Mgt_System_DBDataSet1.DataSetName = "Student_Mgt_System_DBDataSet1";
            this.student_Mgt_System_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_Course_List
            // 
            this.lbl_Course_List.AutoSize = true;
            this.lbl_Course_List.Font = new System.Drawing.Font("Mongolian Baiti", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_List.Location = new System.Drawing.Point(339, 20);
            this.lbl_Course_List.Name = "lbl_Course_List";
            this.lbl_Course_List.Size = new System.Drawing.Size(235, 46);
            this.lbl_Course_List.TabIndex = 1;
            this.lbl_Course_List.Text = "Course List";
            // 
            // course_ListTableAdapter
            // 
            this.course_ListTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Course_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.lbl_Course_List);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Course_List";
            this.Text = "Course List";
            this.Load += new System.EventHandler(this.frm_Course_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Mgt_System_DBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Course_List;
        private Student_Mgt_System_DBDataSet1 student_Mgt_System_DBDataSet1;
        private System.Windows.Forms.BindingSource courseListBindingSource;
        private Student_Mgt_System_DBDataSet1TableAdapters.Course_ListTableAdapter course_ListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
    }
}