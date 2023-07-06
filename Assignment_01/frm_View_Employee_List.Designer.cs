
namespace Employee_Mgt_System
{
    partial class frm_Employee_List
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
            this.lbl_Employee_Details_List = new System.Windows.Forms.Label();
            this.dgv_Employee_View_List = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_App_DBDataSet = new Employee_Mgt_System.Employee_App_DBDataSet();
            this.employee_InformationTableAdapter = new Employee_Mgt_System.Employee_App_DBDataSetTableAdapters.Employee_InformationTableAdapter();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Add_Employee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_View_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_App_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Employee_Details_List
            // 
            this.lbl_Employee_Details_List.AutoSize = true;
            this.lbl_Employee_Details_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Employee_Details_List.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Employee_Details_List.Font = new System.Drawing.Font("Mongolian Baiti", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Details_List.Location = new System.Drawing.Point(200, 9);
            this.lbl_Employee_Details_List.Name = "lbl_Employee_Details_List";
            this.lbl_Employee_Details_List.Size = new System.Drawing.Size(539, 61);
            this.lbl_Employee_Details_List.TabIndex = 0;
            this.lbl_Employee_Details_List.Text = "Employee Details List";
            // 
            // dgv_Employee_View_List
            // 
            this.dgv_Employee_View_List.AutoGenerateColumns = false;
            this.dgv_Employee_View_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Employee_View_List.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Employee_View_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee_View_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn});
            this.dgv_Employee_View_List.DataSource = this.employeeInformationBindingSource;
            this.dgv_Employee_View_List.Location = new System.Drawing.Point(-14, 73);
            this.dgv_Employee_View_List.Name = "dgv_Employee_View_List";
            this.dgv_Employee_View_List.RowHeadersWidth = 62;
            this.dgv_Employee_View_List.RowTemplate.Height = 28;
            this.dgv_Employee_View_List.Size = new System.Drawing.Size(991, 502);
            this.dgv_Employee_View_List.TabIndex = 1;
            this.dgv_Employee_View_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Employee_View_List_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "D_O_B";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "D_O_B";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            // 
            // employeeInformationBindingSource
            // 
            this.employeeInformationBindingSource.DataMember = "Employee_Information";
            this.employeeInformationBindingSource.DataSource = this.employee_App_DBDataSet;
            // 
            // employee_App_DBDataSet
            // 
            this.employee_App_DBDataSet.DataSetName = "Employee_App_DBDataSet";
            this.employee_App_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_InformationTableAdapter
            // 
            this.employee_InformationTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Logout.Location = new System.Drawing.Point(837, -1);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(118, 36);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Add_Employee
            // 
            this.btn_Add_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Employee.Location = new System.Drawing.Point(352, 581);
            this.btn_Add_Employee.Name = "btn_Add_Employee";
            this.btn_Add_Employee.Size = new System.Drawing.Size(199, 46);
            this.btn_Add_Employee.TabIndex = 1;
            this.btn_Add_Employee.Text = "Add Employee";
            this.btn_Add_Employee.UseVisualStyleBackColor = true;
            this.btn_Add_Employee.Click += new System.EventHandler(this.btn_Add_Employee_Click);
            // 
            // frm_Employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.btn_Add_Employee);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.dgv_Employee_View_List);
            this.Controls.Add(this.lbl_Employee_Details_List);
            this.Name = "frm_Employee_List";
            this.Text = "Employee List";
            this.Load += new System.EventHandler(this.frm_Employee_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_View_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_App_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_Details_List;
        private System.Windows.Forms.DataGridView dgv_Employee_View_List;
        private Employee_App_DBDataSet employee_App_DBDataSet;
        private System.Windows.Forms.BindingSource employeeInformationBindingSource;
        private Employee_App_DBDataSetTableAdapters.Employee_InformationTableAdapter employee_InformationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Add_Employee;
    }
}