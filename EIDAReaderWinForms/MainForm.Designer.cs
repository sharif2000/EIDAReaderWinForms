namespace EIDAReaderWinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.txtMaritalStatus = new System.Windows.Forms.TextBox();
            this.lblQualificationLevelDescriptionArabic = new System.Windows.Forms.Label();
            this.txtQualificationLevelDescriptionArabic = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.txtIssueDate = new System.Windows.Forms.TextBox();
            this.txtNationalityAr = new System.Windows.Forms.TextBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.picPhotography = new System.Windows.Forms.PictureBox();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSaveToSP = new System.Windows.Forms.Button();
            this.btnReadCard = new System.Windows.Forms.Button();
            this.txtArabicFullName = new System.Windows.Forms.TextBox();
            this.lblArabicFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.tblContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblPassportCountryDescriptionArabic = new System.Windows.Forms.Label();
            this.lblMotherFullNameArabic = new System.Windows.Forms.Label();
            this.txtMotherFullNameArabic = new System.Windows.Forms.TextBox();
            this.lblMobilePhoneNumber = new System.Windows.Forms.Label();
            this.lblResidentPhoneNumber = new System.Windows.Forms.Label();
            this.lblLandPhoneNo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPOBox = new System.Windows.Forms.Label();
            this.lblDegreeDescriptionArabic = new System.Windows.Forms.Label();
            this.txtDegreeDescriptionArabic = new System.Windows.Forms.TextBox();
            this.txtMobilePhoneNumber = new System.Windows.Forms.TextBox();
            this.txtResidentPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtLandPhoneNo = new System.Windows.Forms.TextBox();
            this.txtPOBox = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassportExpiryDate = new System.Windows.Forms.Label();
            this.lblPassportIssueDate = new System.Windows.Forms.Label();
            this.lblPassportNumber = new System.Windows.Forms.Label();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.txtPassportIssueDate = new System.Windows.Forms.TextBox();
            this.txtPassportExpiryDate = new System.Windows.Forms.TextBox();
            this.txtPassportCountryDescriptionArabic = new System.Windows.Forms.TextBox();
            this.lblCompanyNameArabic = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.txtCompanyNameArabic = new System.Windows.Forms.TextBox();
            this.lblEmirateDescriptionArabic = new System.Windows.Forms.Label();
            this.lblCityDescriptionArabic = new System.Windows.Forms.Label();
            this.txtEmirateDescriptionArabic = new System.Windows.Forms.TextBox();
            this.txtCityDescriptionArabic = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPhotography)).BeginInit();
            this.tblContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDNumber.Location = new System.Drawing.Point(421, 354);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.ReadOnly = true;
            this.txtIDNumber.Size = new System.Drawing.Size(250, 20);
            this.txtIDNumber.TabIndex = 23;
            this.txtIDNumber.TabStop = false;
            // 
            // txtSex
            // 
            this.txtSex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSex.Location = new System.Drawing.Point(421, 246);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(250, 20);
            this.txtSex.TabIndex = 30;
            this.txtSex.TabStop = false;
            // 
            // lblSex
            // 
            this.lblSex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(760, 250);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 13);
            this.lblSex.TabIndex = 15;
            this.lblSex.Text = "النوع";
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Location = new System.Drawing.Point(706, 196);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(83, 13);
            this.lblMaritalStatus.TabIndex = 16;
            this.lblMaritalStatus.Text = "الحالة الاجتماعية";
            // 
            // txtMaritalStatus
            // 
            this.txtMaritalStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaritalStatus.Location = new System.Drawing.Point(421, 192);
            this.txtMaritalStatus.Name = "txtMaritalStatus";
            this.txtMaritalStatus.ReadOnly = true;
            this.txtMaritalStatus.Size = new System.Drawing.Size(250, 20);
            this.txtMaritalStatus.TabIndex = 31;
            this.txtMaritalStatus.TabStop = false;
            // 
            // lblQualificationLevelDescriptionArabic
            // 
            this.lblQualificationLevelDescriptionArabic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQualificationLevelDescriptionArabic.AutoSize = true;
            this.lblQualificationLevelDescriptionArabic.Location = new System.Drawing.Point(315, 250);
            this.lblQualificationLevelDescriptionArabic.Name = "lblQualificationLevelDescriptionArabic";
            this.lblQualificationLevelDescriptionArabic.Size = new System.Drawing.Size(79, 13);
            this.lblQualificationLevelDescriptionArabic.TabIndex = 14;
            this.lblQualificationLevelDescriptionArabic.Text = "مستوى التعليم";
            // 
            // txtQualificationLevelDescriptionArabic
            // 
            this.txtQualificationLevelDescriptionArabic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtQualificationLevelDescriptionArabic.Location = new System.Drawing.Point(26, 246);
            this.txtQualificationLevelDescriptionArabic.Name = "txtQualificationLevelDescriptionArabic";
            this.txtQualificationLevelDescriptionArabic.ReadOnly = true;
            this.txtQualificationLevelDescriptionArabic.Size = new System.Drawing.Size(250, 20);
            this.txtQualificationLevelDescriptionArabic.TabIndex = 32;
            this.txtQualificationLevelDescriptionArabic.TabStop = false;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDateOfBirth.Location = new System.Drawing.Point(421, 165);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.ReadOnly = true;
            this.txtDateOfBirth.Size = new System.Drawing.Size(250, 20);
            this.txtDateOfBirth.TabIndex = 29;
            this.txtDateOfBirth.TabStop = false;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(728, 169);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(61, 13);
            this.lblDateOfBirth.TabIndex = 10;
            this.lblDateOfBirth.Text = "تاريخ الميلاد";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Location = new System.Drawing.Point(736, 358);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(53, 13);
            this.lblIDNumber.TabIndex = 8;
            this.lblIDNumber.Text = "رقم الهوية";
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtExpiryDate.Location = new System.Drawing.Point(421, 408);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.ReadOnly = true;
            this.txtExpiryDate.Size = new System.Drawing.Size(250, 20);
            this.txtExpiryDate.TabIndex = 28;
            this.txtExpiryDate.TabStop = false;
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIssueDate.Location = new System.Drawing.Point(421, 381);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.ReadOnly = true;
            this.txtIssueDate.Size = new System.Drawing.Size(250, 20);
            this.txtIssueDate.TabIndex = 27;
            this.txtIssueDate.TabStop = false;
            // 
            // txtNationalityAr
            // 
            this.txtNationalityAr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNationalityAr.Location = new System.Drawing.Point(421, 219);
            this.txtNationalityAr.Name = "txtNationalityAr";
            this.txtNationalityAr.ReadOnly = true;
            this.txtNationalityAr.Size = new System.Drawing.Size(250, 20);
            this.txtNationalityAr.TabIndex = 26;
            this.txtNationalityAr.TabStop = false;
            // 
            // lblNationality
            // 
            this.lblNationality.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(743, 223);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(46, 13);
            this.lblNationality.TabIndex = 25;
            this.lblNationality.Text = "الجنسية";
            // 
            // picPhotography
            // 
            this.picPhotography.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPhotography.Location = new System.Drawing.Point(146, 84);
            this.picPhotography.Name = "picPhotography";
            this.tblContainer.SetRowSpan(this.picPhotography, 6);
            this.picPhotography.Size = new System.Drawing.Size(130, 154);
            this.picPhotography.TabIndex = 24;
            this.picPhotography.TabStop = false;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(692, 412);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(97, 13);
            this.lblExpiryDate.TabIndex = 11;
            this.lblExpiryDate.Text = "تاريخ انتهاء الصلاحية";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(726, 385);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(63, 13);
            this.lblIssueDate.TabIndex = 12;
            this.lblIssueDate.Text = "تاريخ الإصدار";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(355, 14);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "الحالة :";
            // 
            // btnSaveToSP
            // 
            this.btnSaveToSP.BackColor = System.Drawing.Color.Azure;
            this.btnSaveToSP.Location = new System.Drawing.Point(567, 3);
            this.btnSaveToSP.Name = "btnSaveToSP";
            this.tblContainer.SetRowSpan(this.btnSaveToSP, 3);
            this.btnSaveToSP.Size = new System.Drawing.Size(104, 68);
            this.btnSaveToSP.TabIndex = 5;
            this.btnSaveToSP.Text = "حفظ بقاعدة البيانات";
            this.btnSaveToSP.UseVisualStyleBackColor = false;
            this.btnSaveToSP.Click += new System.EventHandler(this.btnSaveToSP_Click);
            // 
            // btnReadCard
            // 
            this.btnReadCard.BackColor = System.Drawing.Color.Azure;
            this.btnReadCard.Location = new System.Drawing.Point(685, 3);
            this.btnReadCard.Name = "btnReadCard";
            this.tblContainer.SetRowSpan(this.btnReadCard, 3);
            this.btnReadCard.Size = new System.Drawing.Size(104, 68);
            this.btnReadCard.TabIndex = 4;
            this.btnReadCard.Text = "البدء بقراءة بيانات البطاقة";
            this.btnReadCard.UseVisualStyleBackColor = false;
            this.btnReadCard.Click += new System.EventHandler(this.btnReadCard_Click);
            // 
            // txtArabicFullName
            // 
            this.txtArabicFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtArabicFullName.Location = new System.Drawing.Point(421, 84);
            this.txtArabicFullName.Name = "txtArabicFullName";
            this.txtArabicFullName.ReadOnly = true;
            this.txtArabicFullName.Size = new System.Drawing.Size(250, 20);
            this.txtArabicFullName.TabIndex = 2;
            this.txtArabicFullName.TabStop = false;
            // 
            // lblArabicFullName
            // 
            this.lblArabicFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblArabicFullName.AutoSize = true;
            this.lblArabicFullName.Location = new System.Drawing.Point(719, 88);
            this.lblArabicFullName.Name = "lblArabicFullName";
            this.lblArabicFullName.Size = new System.Drawing.Size(70, 13);
            this.lblArabicFullName.TabIndex = 1;
            this.lblArabicFullName.Text = "الاسم العربى";
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFullName.Location = new System.Drawing.Point(421, 111);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(250, 20);
            this.txtFullName.TabIndex = 3;
            this.txtFullName.TabStop = false;
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(707, 115);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(82, 13);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "الاسم الانجليزى";
            // 
            // tblContainer
            // 
            this.tblContainer.ColumnCount = 4;
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblContainer.Controls.Add(this.lblPassportCountryDescriptionArabic, 0, 19);
            this.tblContainer.Controls.Add(this.lblFullName, 0, 4);
            this.tblContainer.Controls.Add(this.txtFullName, 1, 4);
            this.tblContainer.Controls.Add(this.lblArabicFullName, 0, 3);
            this.tblContainer.Controls.Add(this.txtArabicFullName, 1, 3);
            this.tblContainer.Controls.Add(this.btnReadCard, 0, 0);
            this.tblContainer.Controls.Add(this.btnSaveToSP, 1, 0);
            this.tblContainer.Controls.Add(this.lblStatus, 2, 0);
            this.tblContainer.Controls.Add(this.picPhotography, 3, 3);
            this.tblContainer.Controls.Add(this.txtDateOfBirth, 1, 6);
            this.tblContainer.Controls.Add(this.lblDateOfBirth, 0, 6);
            this.tblContainer.Controls.Add(this.lblMotherFullNameArabic, 0, 5);
            this.tblContainer.Controls.Add(this.txtMotherFullNameArabic, 1, 5);
            this.tblContainer.Controls.Add(this.lblMaritalStatus, 0, 7);
            this.tblContainer.Controls.Add(this.txtMaritalStatus, 1, 7);
            this.tblContainer.Controls.Add(this.lblNationality, 0, 8);
            this.tblContainer.Controls.Add(this.txtNationalityAr, 1, 8);
            this.tblContainer.Controls.Add(this.lblSex, 0, 9);
            this.tblContainer.Controls.Add(this.txtSex, 1, 9);
            this.tblContainer.Controls.Add(this.lblQualificationLevelDescriptionArabic, 2, 9);
            this.tblContainer.Controls.Add(this.txtQualificationLevelDescriptionArabic, 3, 9);
            this.tblContainer.Controls.Add(this.lblExpiryDate, 0, 15);
            this.tblContainer.Controls.Add(this.txtExpiryDate, 1, 15);
            this.tblContainer.Controls.Add(this.lblIssueDate, 0, 14);
            this.tblContainer.Controls.Add(this.txtIssueDate, 1, 14);
            this.tblContainer.Controls.Add(this.lblIDNumber, 0, 13);
            this.tblContainer.Controls.Add(this.txtIDNumber, 1, 13);
            this.tblContainer.Controls.Add(this.lblMobilePhoneNumber, 0, 10);
            this.tblContainer.Controls.Add(this.lblResidentPhoneNumber, 0, 11);
            this.tblContainer.Controls.Add(this.lblLandPhoneNo, 0, 12);
            this.tblContainer.Controls.Add(this.lblEmail, 2, 12);
            this.tblContainer.Controls.Add(this.lblPOBox, 2, 11);
            this.tblContainer.Controls.Add(this.lblDegreeDescriptionArabic, 2, 10);
            this.tblContainer.Controls.Add(this.txtDegreeDescriptionArabic, 3, 10);
            this.tblContainer.Controls.Add(this.txtMobilePhoneNumber, 1, 10);
            this.tblContainer.Controls.Add(this.txtResidentPhoneNumber, 1, 11);
            this.tblContainer.Controls.Add(this.txtLandPhoneNo, 1, 12);
            this.tblContainer.Controls.Add(this.txtPOBox, 3, 11);
            this.tblContainer.Controls.Add(this.txtEmail, 3, 12);
            this.tblContainer.Controls.Add(this.lblPassportExpiryDate, 0, 18);
            this.tblContainer.Controls.Add(this.lblPassportIssueDate, 0, 17);
            this.tblContainer.Controls.Add(this.lblPassportNumber, 0, 16);
            this.tblContainer.Controls.Add(this.txtPassportNumber, 1, 16);
            this.tblContainer.Controls.Add(this.txtPassportIssueDate, 1, 17);
            this.tblContainer.Controls.Add(this.txtPassportExpiryDate, 1, 18);
            this.tblContainer.Controls.Add(this.txtPassportCountryDescriptionArabic, 1, 19);
            this.tblContainer.Controls.Add(this.lblCompanyNameArabic, 2, 14);
            this.tblContainer.Controls.Add(this.lblOccupation, 2, 13);
            this.tblContainer.Controls.Add(this.txtOccupation, 3, 13);
            this.tblContainer.Controls.Add(this.txtCompanyNameArabic, 3, 14);
            this.tblContainer.Controls.Add(this.lblEmirateDescriptionArabic, 2, 15);
            this.tblContainer.Controls.Add(this.lblCityDescriptionArabic, 2, 16);
            this.tblContainer.Controls.Add(this.txtEmirateDescriptionArabic, 3, 15);
            this.tblContainer.Controls.Add(this.txtCityDescriptionArabic, 3, 16);
            this.tblContainer.Controls.Add(this.txtStatus, 2, 1);
            this.tblContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblContainer.Location = new System.Drawing.Point(0, 0);
            this.tblContainer.Name = "tblContainer";
            this.tblContainer.RowCount = 21;
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblContainer.Size = new System.Drawing.Size(792, 573);
            this.tblContainer.TabIndex = 0;
            // 
            // lblPassportCountryDescriptionArabic
            // 
            this.lblPassportCountryDescriptionArabic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassportCountryDescriptionArabic.AutoSize = true;
            this.lblPassportCountryDescriptionArabic.Location = new System.Drawing.Point(725, 520);
            this.lblPassportCountryDescriptionArabic.Name = "lblPassportCountryDescriptionArabic";
            this.lblPassportCountryDescriptionArabic.Size = new System.Drawing.Size(64, 13);
            this.lblPassportCountryDescriptionArabic.TabIndex = 50;
            this.lblPassportCountryDescriptionArabic.Text = "مكان الإصدار";
            // 
            // lblMotherFullNameArabic
            // 
            this.lblMotherFullNameArabic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMotherFullNameArabic.AutoSize = true;
            this.lblMotherFullNameArabic.Location = new System.Drawing.Point(740, 142);
            this.lblMotherFullNameArabic.Name = "lblMotherFullNameArabic";
            this.lblMotherFullNameArabic.Size = new System.Drawing.Size(49, 13);
            this.lblMotherFullNameArabic.TabIndex = 34;
            this.lblMotherFullNameArabic.Text = "اسم الأم";
            // 
            // txtMotherFullNameArabic
            // 
            this.txtMotherFullNameArabic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMotherFullNameArabic.Location = new System.Drawing.Point(421, 138);
            this.txtMotherFullNameArabic.Name = "txtMotherFullNameArabic";
            this.txtMotherFullNameArabic.ReadOnly = true;
            this.txtMotherFullNameArabic.Size = new System.Drawing.Size(250, 20);
            this.txtMotherFullNameArabic.TabIndex = 35;
            this.txtMotherFullNameArabic.TabStop = false;
            // 
            // lblMobilePhoneNumber
            // 
            this.lblMobilePhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMobilePhoneNumber.AutoSize = true;
            this.lblMobilePhoneNumber.Location = new System.Drawing.Point(734, 277);
            this.lblMobilePhoneNumber.Name = "lblMobilePhoneNumber";
            this.lblMobilePhoneNumber.Size = new System.Drawing.Size(55, 13);
            this.lblMobilePhoneNumber.TabIndex = 36;
            this.lblMobilePhoneNumber.Text = "رقم الجوال";
            // 
            // lblResidentPhoneNumber
            // 
            this.lblResidentPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblResidentPhoneNumber.AutoSize = true;
            this.lblResidentPhoneNumber.Location = new System.Drawing.Point(721, 304);
            this.lblResidentPhoneNumber.Name = "lblResidentPhoneNumber";
            this.lblResidentPhoneNumber.Size = new System.Drawing.Size(68, 13);
            this.lblResidentPhoneNumber.TabIndex = 37;
            this.lblResidentPhoneNumber.Text = "تليفون المنزل";
            // 
            // lblLandPhoneNo
            // 
            this.lblLandPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLandPhoneNo.AutoSize = true;
            this.lblLandPhoneNo.Location = new System.Drawing.Point(720, 331);
            this.lblLandPhoneNo.Name = "lblLandPhoneNo";
            this.lblLandPhoneNo.Size = new System.Drawing.Size(69, 13);
            this.lblLandPhoneNo.TabIndex = 38;
            this.lblLandPhoneNo.Text = "تليفون العمل ";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(313, 331);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 13);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "البريد الالكترونى";
            // 
            // lblPOBox
            // 
            this.lblPOBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPOBox.AutoSize = true;
            this.lblPOBox.Location = new System.Drawing.Point(326, 304);
            this.lblPOBox.Name = "lblPOBox";
            this.lblPOBox.Size = new System.Drawing.Size(68, 13);
            this.lblPOBox.TabIndex = 39;
            this.lblPOBox.Text = "صندوق البريد";
            // 
            // lblDegreeDescriptionArabic
            // 
            this.lblDegreeDescriptionArabic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDegreeDescriptionArabic.AutoSize = true;
            this.lblDegreeDescriptionArabic.Location = new System.Drawing.Point(309, 277);
            this.lblDegreeDescriptionArabic.Name = "lblDegreeDescriptionArabic";
            this.lblDegreeDescriptionArabic.Size = new System.Drawing.Size(85, 13);
            this.lblDegreeDescriptionArabic.TabIndex = 41;
            this.lblDegreeDescriptionArabic.Text = "المؤهل الدراسى";
            // 
            // txtDegreeDescriptionArabic
            // 
            this.txtDegreeDescriptionArabic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDegreeDescriptionArabic.Location = new System.Drawing.Point(26, 273);
            this.txtDegreeDescriptionArabic.Name = "txtDegreeDescriptionArabic";
            this.txtDegreeDescriptionArabic.ReadOnly = true;
            this.txtDegreeDescriptionArabic.Size = new System.Drawing.Size(250, 20);
            this.txtDegreeDescriptionArabic.TabIndex = 42;
            this.txtDegreeDescriptionArabic.TabStop = false;
            // 
            // txtMobilePhoneNumber
            // 
            this.txtMobilePhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMobilePhoneNumber.Location = new System.Drawing.Point(421, 273);
            this.txtMobilePhoneNumber.Name = "txtMobilePhoneNumber";
            this.txtMobilePhoneNumber.ReadOnly = true;
            this.txtMobilePhoneNumber.Size = new System.Drawing.Size(250, 20);
            this.txtMobilePhoneNumber.TabIndex = 43;
            this.txtMobilePhoneNumber.TabStop = false;
            // 
            // txtResidentPhoneNumber
            // 
            this.txtResidentPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtResidentPhoneNumber.Location = new System.Drawing.Point(421, 300);
            this.txtResidentPhoneNumber.Name = "txtResidentPhoneNumber";
            this.txtResidentPhoneNumber.ReadOnly = true;
            this.txtResidentPhoneNumber.Size = new System.Drawing.Size(250, 20);
            this.txtResidentPhoneNumber.TabIndex = 44;
            this.txtResidentPhoneNumber.TabStop = false;
            // 
            // txtLandPhoneNo
            // 
            this.txtLandPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLandPhoneNo.Location = new System.Drawing.Point(421, 327);
            this.txtLandPhoneNo.Name = "txtLandPhoneNo";
            this.txtLandPhoneNo.ReadOnly = true;
            this.txtLandPhoneNo.Size = new System.Drawing.Size(250, 20);
            this.txtLandPhoneNo.TabIndex = 45;
            this.txtLandPhoneNo.TabStop = false;
            // 
            // txtPOBox
            // 
            this.txtPOBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPOBox.Location = new System.Drawing.Point(26, 300);
            this.txtPOBox.Name = "txtPOBox";
            this.txtPOBox.ReadOnly = true;
            this.txtPOBox.Size = new System.Drawing.Size(250, 20);
            this.txtPOBox.TabIndex = 46;
            this.txtPOBox.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.Location = new System.Drawing.Point(26, 327);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(250, 20);
            this.txtEmail.TabIndex = 47;
            this.txtEmail.TabStop = false;
            // 
            // lblPassportExpiryDate
            // 
            this.lblPassportExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassportExpiryDate.AutoSize = true;
            this.lblPassportExpiryDate.Location = new System.Drawing.Point(692, 493);
            this.lblPassportExpiryDate.Name = "lblPassportExpiryDate";
            this.lblPassportExpiryDate.Size = new System.Drawing.Size(97, 13);
            this.lblPassportExpiryDate.TabIndex = 51;
            this.lblPassportExpiryDate.Text = "تاريخ انتهاء الصلاحية";
            // 
            // lblPassportIssueDate
            // 
            this.lblPassportIssueDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassportIssueDate.AutoSize = true;
            this.lblPassportIssueDate.Location = new System.Drawing.Point(726, 466);
            this.lblPassportIssueDate.Name = "lblPassportIssueDate";
            this.lblPassportIssueDate.Size = new System.Drawing.Size(63, 13);
            this.lblPassportIssueDate.TabIndex = 49;
            this.lblPassportIssueDate.Text = "تاريخ الإصدار";
            // 
            // lblPassportNumber
            // 
            this.lblPassportNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassportNumber.AutoSize = true;
            this.lblPassportNumber.Location = new System.Drawing.Point(711, 439);
            this.lblPassportNumber.Name = "lblPassportNumber";
            this.lblPassportNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPassportNumber.TabIndex = 48;
            this.lblPassportNumber.Text = "رقم جواز السفر";
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassportNumber.Location = new System.Drawing.Point(421, 435);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.ReadOnly = true;
            this.txtPassportNumber.Size = new System.Drawing.Size(250, 20);
            this.txtPassportNumber.TabIndex = 52;
            this.txtPassportNumber.TabStop = false;
            // 
            // txtPassportIssueDate
            // 
            this.txtPassportIssueDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassportIssueDate.Location = new System.Drawing.Point(421, 462);
            this.txtPassportIssueDate.Name = "txtPassportIssueDate";
            this.txtPassportIssueDate.ReadOnly = true;
            this.txtPassportIssueDate.Size = new System.Drawing.Size(250, 20);
            this.txtPassportIssueDate.TabIndex = 53;
            this.txtPassportIssueDate.TabStop = false;
            // 
            // txtPassportExpiryDate
            // 
            this.txtPassportExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassportExpiryDate.Location = new System.Drawing.Point(421, 489);
            this.txtPassportExpiryDate.Name = "txtPassportExpiryDate";
            this.txtPassportExpiryDate.ReadOnly = true;
            this.txtPassportExpiryDate.Size = new System.Drawing.Size(250, 20);
            this.txtPassportExpiryDate.TabIndex = 54;
            this.txtPassportExpiryDate.TabStop = false;
            // 
            // txtPassportCountryDescriptionArabic
            // 
            this.txtPassportCountryDescriptionArabic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassportCountryDescriptionArabic.Location = new System.Drawing.Point(421, 516);
            this.txtPassportCountryDescriptionArabic.Name = "txtPassportCountryDescriptionArabic";
            this.txtPassportCountryDescriptionArabic.ReadOnly = true;
            this.txtPassportCountryDescriptionArabic.Size = new System.Drawing.Size(250, 20);
            this.txtPassportCountryDescriptionArabic.TabIndex = 55;
            this.txtPassportCountryDescriptionArabic.TabStop = false;
            // 
            // lblCompanyNameArabic
            // 
            this.lblCompanyNameArabic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCompanyNameArabic.AutoSize = true;
            this.lblCompanyNameArabic.Location = new System.Drawing.Point(335, 385);
            this.lblCompanyNameArabic.Name = "lblCompanyNameArabic";
            this.lblCompanyNameArabic.Size = new System.Drawing.Size(59, 13);
            this.lblCompanyNameArabic.TabIndex = 56;
            this.lblCompanyNameArabic.Text = "مكان العمل";
            // 
            // lblOccupation
            // 
            this.lblOccupation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(353, 358);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(41, 13);
            this.lblOccupation.TabIndex = 57;
            this.lblOccupation.Text = "الوظيفة";
            // 
            // txtOccupation
            // 
            this.txtOccupation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOccupation.Location = new System.Drawing.Point(26, 354);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.ReadOnly = true;
            this.txtOccupation.Size = new System.Drawing.Size(250, 20);
            this.txtOccupation.TabIndex = 58;
            this.txtOccupation.TabStop = false;
            // 
            // txtCompanyNameArabic
            // 
            this.txtCompanyNameArabic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCompanyNameArabic.Location = new System.Drawing.Point(26, 381);
            this.txtCompanyNameArabic.Name = "txtCompanyNameArabic";
            this.txtCompanyNameArabic.ReadOnly = true;
            this.txtCompanyNameArabic.Size = new System.Drawing.Size(250, 20);
            this.txtCompanyNameArabic.TabIndex = 59;
            this.txtCompanyNameArabic.TabStop = false;
            // 
            // lblEmirateDescriptionArabic
            // 
            this.lblEmirateDescriptionArabic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmirateDescriptionArabic.AutoSize = true;
            this.lblEmirateDescriptionArabic.Location = new System.Drawing.Point(318, 412);
            this.lblEmirateDescriptionArabic.Name = "lblEmirateDescriptionArabic";
            this.lblEmirateDescriptionArabic.Size = new System.Drawing.Size(76, 13);
            this.lblEmirateDescriptionArabic.TabIndex = 60;
            this.lblEmirateDescriptionArabic.Text = "الإقامة (الإمارة)";
            // 
            // lblCityDescriptionArabic
            // 
            this.lblCityDescriptionArabic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCityDescriptionArabic.AutoSize = true;
            this.lblCityDescriptionArabic.Location = new System.Drawing.Point(314, 439);
            this.lblCityDescriptionArabic.Name = "lblCityDescriptionArabic";
            this.lblCityDescriptionArabic.Size = new System.Drawing.Size(80, 13);
            this.lblCityDescriptionArabic.TabIndex = 61;
            this.lblCityDescriptionArabic.Text = "الإقامة (المدينة)";
            // 
            // txtEmirateDescriptionArabic
            // 
            this.txtEmirateDescriptionArabic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmirateDescriptionArabic.Location = new System.Drawing.Point(26, 408);
            this.txtEmirateDescriptionArabic.Name = "txtEmirateDescriptionArabic";
            this.txtEmirateDescriptionArabic.ReadOnly = true;
            this.txtEmirateDescriptionArabic.Size = new System.Drawing.Size(250, 20);
            this.txtEmirateDescriptionArabic.TabIndex = 62;
            this.txtEmirateDescriptionArabic.TabStop = false;
            // 
            // txtCityDescriptionArabic
            // 
            this.txtCityDescriptionArabic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCityDescriptionArabic.Location = new System.Drawing.Point(26, 435);
            this.txtCityDescriptionArabic.Name = "txtCityDescriptionArabic";
            this.txtCityDescriptionArabic.ReadOnly = true;
            this.txtCityDescriptionArabic.Size = new System.Drawing.Size(250, 20);
            this.txtCityDescriptionArabic.TabIndex = 63;
            this.txtCityDescriptionArabic.TabStop = false;
            // 
            // txtStatus
            // 
            this.tblContainer.SetColumnSpan(this.txtStatus, 2);
            this.txtStatus.Location = new System.Drawing.Point(4, 30);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.tblContainer.SetRowSpan(this.txtStatus, 2);
            this.txtStatus.Size = new System.Drawing.Size(390, 42);
            this.txtStatus.TabIndex = 64;
            this.txtStatus.TabStop = false;
            this.txtStatus.Text = "";
            this.txtStatus.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtStatus_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.tblContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قارئ بطاقة الهوية";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPhotography)).EndInit();
            this.tblContainer.ResumeLayout(false);
            this.tblContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.TextBox txtMaritalStatus;
        private System.Windows.Forms.Label lblQualificationLevelDescriptionArabic;
        private System.Windows.Forms.TextBox txtQualificationLevelDescriptionArabic;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.TextBox txtIssueDate;
        private System.Windows.Forms.TextBox txtNationalityAr;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.PictureBox picPhotography;
        private System.Windows.Forms.TableLayoutPanel tblContainer;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblArabicFullName;
        private System.Windows.Forms.TextBox txtArabicFullName;
        private System.Windows.Forms.Button btnReadCard;
        private System.Windows.Forms.Button btnSaveToSP;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblMotherFullNameArabic;
        private System.Windows.Forms.TextBox txtMotherFullNameArabic;
        private System.Windows.Forms.Label lblMobilePhoneNumber;
        private System.Windows.Forms.Label lblResidentPhoneNumber;
        private System.Windows.Forms.Label lblLandPhoneNo;
        private System.Windows.Forms.Label lblPOBox;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDegreeDescriptionArabic;
        private System.Windows.Forms.TextBox txtDegreeDescriptionArabic;
        private System.Windows.Forms.TextBox txtMobilePhoneNumber;
        private System.Windows.Forms.TextBox txtResidentPhoneNumber;
        private System.Windows.Forms.TextBox txtLandPhoneNo;
        private System.Windows.Forms.TextBox txtPOBox;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassportCountryDescriptionArabic;
        private System.Windows.Forms.Label lblPassportExpiryDate;
        private System.Windows.Forms.Label lblPassportIssueDate;
        private System.Windows.Forms.Label lblPassportNumber;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.TextBox txtPassportIssueDate;
        private System.Windows.Forms.TextBox txtPassportExpiryDate;
        private System.Windows.Forms.TextBox txtPassportCountryDescriptionArabic;
        private System.Windows.Forms.Label lblCompanyNameArabic;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.TextBox txtCompanyNameArabic;
        private System.Windows.Forms.Label lblEmirateDescriptionArabic;
        private System.Windows.Forms.Label lblCityDescriptionArabic;
        private System.Windows.Forms.TextBox txtEmirateDescriptionArabic;
        private System.Windows.Forms.TextBox txtCityDescriptionArabic;
        private System.Windows.Forms.RichTextBox txtStatus;
    }
}

