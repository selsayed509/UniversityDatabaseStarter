namespace UniversityLab
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabSetup = new TabPage();
            tabStudents = new TabPage();
            tabSearch = new TabPage();
            tabAddUpdate = new TabPage();
            tabGrid = new TabPage();
            btnTest = new Button();
            btnLoad = new Button();
            btnLoadObjects = new Button();
            lstStudents = new ListBox();
            lblDetailName = new Label();
            txtDetailName = new TextBox();
            lblDetailCourse = new Label();
            txtDetailCourse = new TextBox();
            lblDetailPhone = new Label();
            txtDetailPhone = new TextBox();
            lblDetailDepartment = new Label();
            txtDetailDepartment = new TextBox();
            lblDetailAge = new Label();
            txtDetailAge = new TextBox();
            lblDeptCount = new Label();
            txtDeptCount = new TextBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lstResults = new ListBox();
            lblStudentIdInput = new Label();
            txtStudentId = new TextBox();
            lblNationalIdInput = new Label();
            txtNationalId = new TextBox();
            lblNameInput = new Label();
            txtName = new TextBox();
            lblDateOfBirthInput = new Label();
            dtpDateOfBirth = new DateTimePicker();
            lblPhoneNumberInput = new Label();
            txtPhoneNumber = new TextBox();
            lblAddressInput = new Label();
            txtAddress = new TextBox();
            lblCourseInput = new Label();
            txtCourse = new TextBox();
            lblDepartmentInput = new Label();
            cboDepartment = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnLoadGrid = new Button();
            btnSave = new Button();
            dgvStudents = new DataGridView();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            tabControl.SuspendLayout();
            tabSetup.SuspendLayout();
            tabStudents.SuspendLayout();
            tabSearch.SuspendLayout();
            tabAddUpdate.SuspendLayout();
            tabGrid.SuspendLayout();
            SuspendLayout();
            //
            // tabControl
            //
            tabControl.Controls.Add(tabSetup);
            tabControl.Controls.Add(tabStudents);
            tabControl.Controls.Add(tabSearch);
            tabControl.Controls.Add(tabAddUpdate);
            tabControl.Controls.Add(tabGrid);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(776, 410);
            tabControl.TabIndex = 0;
            //
            // tabSetup
            //
            tabSetup.Controls.Add(btnTest);
            tabSetup.Location = new Point(4, 29);
            tabSetup.Name = "tabSetup";
            tabSetup.Padding = new Padding(3);
            tabSetup.Size = new Size(768, 377);
            tabSetup.TabIndex = 0;
            tabSetup.Text = "1 Setup";
            tabSetup.UseVisualStyleBackColor = true;
            //
            // tabStudents
            //
            tabStudents.Controls.Add(btnLoad);
            tabStudents.Controls.Add(btnLoadObjects);
            tabStudents.Controls.Add(lstStudents);
            tabStudents.Controls.Add(lblDetailName);
            tabStudents.Controls.Add(txtDetailName);
            tabStudents.Controls.Add(lblDetailCourse);
            tabStudents.Controls.Add(txtDetailCourse);
            tabStudents.Controls.Add(lblDetailPhone);
            tabStudents.Controls.Add(txtDetailPhone);
            tabStudents.Controls.Add(lblDetailDepartment);
            tabStudents.Controls.Add(txtDetailDepartment);
            tabStudents.Controls.Add(lblDetailAge);
            tabStudents.Controls.Add(txtDetailAge);
            tabStudents.Controls.Add(lblDeptCount);
            tabStudents.Controls.Add(txtDeptCount);
            tabStudents.Location = new Point(4, 29);
            tabStudents.Name = "tabStudents";
            tabStudents.Padding = new Padding(3);
            tabStudents.Size = new Size(768, 377);
            tabStudents.TabIndex = 1;
            tabStudents.Text = "2-3 Students";
            tabStudents.UseVisualStyleBackColor = true;
            //
            // tabSearch
            //
            tabSearch.Controls.Add(lblSearch);
            tabSearch.Controls.Add(txtSearch);
            tabSearch.Controls.Add(btnSearch);
            tabSearch.Controls.Add(lstResults);
            tabSearch.Location = new Point(4, 29);
            tabSearch.Name = "tabSearch";
            tabSearch.Padding = new Padding(3);
            tabSearch.Size = new Size(768, 377);
            tabSearch.TabIndex = 2;
            tabSearch.Text = "3 Search";
            tabSearch.UseVisualStyleBackColor = true;
            //
            // tabAddUpdate
            //
            tabAddUpdate.Controls.Add(lblStudentIdInput);
            tabAddUpdate.Controls.Add(txtStudentId);
            tabAddUpdate.Controls.Add(lblNationalIdInput);
            tabAddUpdate.Controls.Add(txtNationalId);
            tabAddUpdate.Controls.Add(lblNameInput);
            tabAddUpdate.Controls.Add(txtName);
            tabAddUpdate.Controls.Add(lblDateOfBirthInput);
            tabAddUpdate.Controls.Add(dtpDateOfBirth);
            tabAddUpdate.Controls.Add(lblPhoneNumberInput);
            tabAddUpdate.Controls.Add(txtPhoneNumber);
            tabAddUpdate.Controls.Add(lblAddressInput);
            tabAddUpdate.Controls.Add(txtAddress);
            tabAddUpdate.Controls.Add(lblCourseInput);
            tabAddUpdate.Controls.Add(txtCourse);
            tabAddUpdate.Controls.Add(lblDepartmentInput);
            tabAddUpdate.Controls.Add(cboDepartment);
            tabAddUpdate.Controls.Add(btnAdd);
            tabAddUpdate.Controls.Add(btnUpdate);
            tabAddUpdate.Location = new Point(4, 29);
            tabAddUpdate.Name = "tabAddUpdate";
            tabAddUpdate.Padding = new Padding(3);
            tabAddUpdate.Size = new Size(768, 377);
            tabAddUpdate.TabIndex = 3;
            tabAddUpdate.Text = "4-5 Add and Update";
            tabAddUpdate.UseVisualStyleBackColor = true;
            //
            // tabGrid
            //
            tabGrid.Controls.Add(btnLoadGrid);
            tabGrid.Controls.Add(btnSave);
            tabGrid.Controls.Add(dgvStudents);
            tabGrid.Location = new Point(4, 29);
            tabGrid.Name = "tabGrid";
            tabGrid.Padding = new Padding(3);
            tabGrid.Size = new Size(768, 377);
            tabGrid.TabIndex = 4;
            tabGrid.Text = "6 Grid";
            tabGrid.UseVisualStyleBackColor = true;
            //
            // btnTest
            //
            btnTest.Location = new Point(20, 20);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(180, 32);
            btnTest.TabIndex = 1;
            btnTest.Text = "Test Connection";
            btnTest.UseVisualStyleBackColor = true;
            //
            // btnLoad
            //
            btnLoad.Location = new Point(20, 15);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(150, 32);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            //
            // btnLoadObjects
            //
            btnLoadObjects.Location = new Point(180, 15);
            btnLoadObjects.Name = "btnLoadObjects";
            btnLoadObjects.Size = new Size(170, 32);
            btnLoadObjects.TabIndex = 3;
            btnLoadObjects.Text = "Load as Objects";
            btnLoadObjects.UseVisualStyleBackColor = true;
            //
            // lstStudents
            //
            lstStudents.Location = new Point(20, 57);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(330, 304);
            lstStudents.TabIndex = 4;
            lstStudents.FormattingEnabled = true;
            //
            // lblDetailName
            //
            lblDetailName.Location = new Point(375, 60);
            lblDetailName.Name = "lblDetailName";
            lblDetailName.Size = new Size(140, 23);
            lblDetailName.TabIndex = 5;
            lblDetailName.Text = "Name:";
            //
            // txtDetailName
            //
            txtDetailName.Location = new Point(520, 57);
            txtDetailName.Name = "txtDetailName";
            txtDetailName.Size = new Size(225, 27);
            txtDetailName.TabIndex = 6;
            txtDetailName.ReadOnly = true;
            //
            // lblDetailCourse
            //
            lblDetailCourse.Location = new Point(375, 105);
            lblDetailCourse.Name = "lblDetailCourse";
            lblDetailCourse.Size = new Size(140, 23);
            lblDetailCourse.TabIndex = 7;
            lblDetailCourse.Text = "Course:";
            //
            // txtDetailCourse
            //
            txtDetailCourse.Location = new Point(520, 102);
            txtDetailCourse.Name = "txtDetailCourse";
            txtDetailCourse.Size = new Size(225, 27);
            txtDetailCourse.TabIndex = 8;
            txtDetailCourse.ReadOnly = true;
            //
            // lblDetailPhone
            //
            lblDetailPhone.Location = new Point(375, 150);
            lblDetailPhone.Name = "lblDetailPhone";
            lblDetailPhone.Size = new Size(140, 23);
            lblDetailPhone.TabIndex = 9;
            lblDetailPhone.Text = "Phone:";
            //
            // txtDetailPhone
            //
            txtDetailPhone.Location = new Point(520, 147);
            txtDetailPhone.Name = "txtDetailPhone";
            txtDetailPhone.Size = new Size(225, 27);
            txtDetailPhone.TabIndex = 10;
            txtDetailPhone.ReadOnly = true;
            //
            // lblDetailDepartment
            //
            lblDetailDepartment.Location = new Point(375, 195);
            lblDetailDepartment.Name = "lblDetailDepartment";
            lblDetailDepartment.Size = new Size(140, 23);
            lblDetailDepartment.TabIndex = 11;
            lblDetailDepartment.Text = "Department:";
            //
            // txtDetailDepartment
            //
            txtDetailDepartment.Location = new Point(520, 192);
            txtDetailDepartment.Name = "txtDetailDepartment";
            txtDetailDepartment.Size = new Size(225, 27);
            txtDetailDepartment.TabIndex = 12;
            txtDetailDepartment.ReadOnly = true;
            //
            // lblDetailAge
            //
            lblDetailAge.Location = new Point(375, 240);
            lblDetailAge.Name = "lblDetailAge";
            lblDetailAge.Size = new Size(140, 23);
            lblDetailAge.TabIndex = 13;
            lblDetailAge.Text = "Age:";
            //
            // txtDetailAge
            //
            txtDetailAge.Location = new Point(520, 237);
            txtDetailAge.Name = "txtDetailAge";
            txtDetailAge.Size = new Size(225, 27);
            txtDetailAge.TabIndex = 14;
            txtDetailAge.ReadOnly = true;
            //
            // lblDeptCount
            //
            lblDeptCount.Location = new Point(375, 285);
            lblDeptCount.Name = "lblDeptCount";
            lblDeptCount.Size = new Size(140, 23);
            lblDeptCount.TabIndex = 15;
            lblDeptCount.Text = "Students in dept:";
            //
            // txtDeptCount
            //
            txtDeptCount.Location = new Point(520, 282);
            txtDeptCount.Name = "txtDeptCount";
            txtDeptCount.Size = new Size(225, 27);
            txtDeptCount.TabIndex = 16;
            txtDeptCount.ReadOnly = true;
            //
            // lblSearch
            //
            lblSearch.Location = new Point(20, 23);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(60, 23);
            lblSearch.TabIndex = 17;
            lblSearch.Text = "Name:";
            //
            // txtSearch
            //
            txtSearch.Location = new Point(85, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(500, 27);
            txtSearch.TabIndex = 18;
            //
            // btnSearch
            //
            btnSearch.Location = new Point(600, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(145, 32);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            //
            // lstResults
            //
            lstResults.Location = new Point(20, 65);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(725, 284);
            lstResults.TabIndex = 20;
            lstResults.FormattingEnabled = true;
            //
            // lblStudentIdInput
            //
            lblStudentIdInput.Location = new Point(20, 18);
            lblStudentIdInput.Name = "lblStudentIdInput";
            lblStudentIdInput.Size = new Size(120, 23);
            lblStudentIdInput.TabIndex = 21;
            lblStudentIdInput.Text = "Student ID:";
            //
            // txtStudentId
            //
            txtStudentId.Location = new Point(145, 15);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(330, 27);
            txtStudentId.TabIndex = 22;
            //
            // lblNationalIdInput
            //
            lblNationalIdInput.Location = new Point(20, 58);
            lblNationalIdInput.Name = "lblNationalIdInput";
            lblNationalIdInput.Size = new Size(120, 23);
            lblNationalIdInput.TabIndex = 23;
            lblNationalIdInput.Text = "National ID:";
            //
            // txtNationalId
            //
            txtNationalId.Location = new Point(145, 55);
            txtNationalId.Name = "txtNationalId";
            txtNationalId.Size = new Size(330, 27);
            txtNationalId.TabIndex = 24;
            //
            // lblNameInput
            //
            lblNameInput.Location = new Point(20, 98);
            lblNameInput.Name = "lblNameInput";
            lblNameInput.Size = new Size(120, 23);
            lblNameInput.TabIndex = 25;
            lblNameInput.Text = "Name:";
            //
            // txtName
            //
            txtName.Location = new Point(145, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(330, 27);
            txtName.TabIndex = 26;
            //
            // lblDateOfBirthInput
            //
            lblDateOfBirthInput.Location = new Point(20, 138);
            lblDateOfBirthInput.Name = "lblDateOfBirthInput";
            lblDateOfBirthInput.Size = new Size(120, 23);
            lblDateOfBirthInput.TabIndex = 27;
            lblDateOfBirthInput.Text = "Date of birth:";
            //
            // dtpDateOfBirth
            //
            dtpDateOfBirth.Location = new Point(145, 135);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(330, 27);
            dtpDateOfBirth.TabIndex = 28;
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            //
            // lblPhoneNumberInput
            //
            lblPhoneNumberInput.Location = new Point(20, 178);
            lblPhoneNumberInput.Name = "lblPhoneNumberInput";
            lblPhoneNumberInput.Size = new Size(120, 23);
            lblPhoneNumberInput.TabIndex = 29;
            lblPhoneNumberInput.Text = "Phone:";
            //
            // txtPhoneNumber
            //
            txtPhoneNumber.Location = new Point(145, 175);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(330, 27);
            txtPhoneNumber.TabIndex = 30;
            //
            // lblAddressInput
            //
            lblAddressInput.Location = new Point(20, 218);
            lblAddressInput.Name = "lblAddressInput";
            lblAddressInput.Size = new Size(120, 23);
            lblAddressInput.TabIndex = 31;
            lblAddressInput.Text = "Address:";
            //
            // txtAddress
            //
            txtAddress.Location = new Point(145, 215);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(330, 27);
            txtAddress.TabIndex = 32;
            //
            // lblCourseInput
            //
            lblCourseInput.Location = new Point(20, 258);
            lblCourseInput.Name = "lblCourseInput";
            lblCourseInput.Size = new Size(120, 23);
            lblCourseInput.TabIndex = 33;
            lblCourseInput.Text = "Course:";
            //
            // txtCourse
            //
            txtCourse.Location = new Point(145, 255);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(330, 27);
            txtCourse.TabIndex = 34;
            //
            // lblDepartmentInput
            //
            lblDepartmentInput.Location = new Point(20, 298);
            lblDepartmentInput.Name = "lblDepartmentInput";
            lblDepartmentInput.Size = new Size(120, 23);
            lblDepartmentInput.TabIndex = 35;
            lblDepartmentInput.Text = "Department:";
            //
            // cboDepartment
            //
            cboDepartment.Location = new Point(145, 295);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(330, 27);
            cboDepartment.TabIndex = 36;
            cboDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartment.FormattingEnabled = true;
            //
            // btnAdd
            //
            btnAdd.Location = new Point(500, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 32);
            btnAdd.TabIndex = 37;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = true;
            //
            // btnUpdate
            //
            btnUpdate.Location = new Point(500, 295);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 32);
            btnUpdate.TabIndex = 38;
            btnUpdate.Text = "Update Department";
            btnUpdate.UseVisualStyleBackColor = true;
            //
            // btnLoadGrid
            //
            btnLoadGrid.Location = new Point(20, 15);
            btnLoadGrid.Name = "btnLoadGrid";
            btnLoadGrid.Size = new Size(130, 32);
            btnLoadGrid.TabIndex = 39;
            btnLoadGrid.Text = "Load";
            btnLoadGrid.UseVisualStyleBackColor = true;
            //
            // btnSave
            //
            btnSave.Location = new Point(160, 15);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 32);
            btnSave.TabIndex = 40;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            //
            // dgvStudents
            //
            dgvStudents.Location = new Point(20, 57);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(725, 304);
            dgvStudents.TabIndex = 41;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //
            // lblStatus
            //
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(16, 430);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 42;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 465);
            Controls.Add(lblStatus);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "CMP205 Lab 08: University Database";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            tabSetup.ResumeLayout(false);
            tabSetup.PerformLayout();
            tabStudents.ResumeLayout(false);
            tabStudents.PerformLayout();
            tabSearch.ResumeLayout(false);
            tabSearch.PerformLayout();
            tabAddUpdate.ResumeLayout(false);
            tabAddUpdate.PerformLayout();
            tabGrid.ResumeLayout(false);
            tabGrid.PerformLayout();
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private TabControl tabControl;
        private TabPage tabSetup;
        private TabPage tabStudents;
        private TabPage tabSearch;
        private TabPage tabAddUpdate;
        private TabPage tabGrid;
        private Button btnTest;
        private Button btnLoad;
        private Button btnLoadObjects;
        private ListBox lstStudents;
        private Label lblDetailName;
        private TextBox txtDetailName;
        private Label lblDetailCourse;
        private TextBox txtDetailCourse;
        private Label lblDetailPhone;
        private TextBox txtDetailPhone;
        private Label lblDetailDepartment;
        private TextBox txtDetailDepartment;
        private Label lblDetailAge;
        private TextBox txtDetailAge;
        private Label lblDeptCount;
        private TextBox txtDeptCount;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private ListBox lstResults;
        private Label lblStudentIdInput;
        private TextBox txtStudentId;
        private Label lblNationalIdInput;
        private TextBox txtNationalId;
        private Label lblNameInput;
        private TextBox txtName;
        private Label lblDateOfBirthInput;
        private DateTimePicker dtpDateOfBirth;
        private Label lblPhoneNumberInput;
        private TextBox txtPhoneNumber;
        private Label lblAddressInput;
        private TextBox txtAddress;
        private Label lblCourseInput;
        private TextBox txtCourse;
        private Label lblDepartmentInput;
        private ComboBox cboDepartment;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnLoadGrid;
        private Button btnSave;
        private DataGridView dgvStudents;
        private Label lblStatus;
    }
}
