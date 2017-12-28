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
            this.tblContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblArabicFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtArabicFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnReadCard = new System.Windows.Forms.Button();
            this.btnSaveToSP = new System.Windows.Forms.Button();
            this.tblContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblContainer
            // 
            this.tblContainer.ColumnCount = 4;
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblContainer.Controls.Add(this.btnSaveToSP, 2, 0);
            this.tblContainer.Controls.Add(this.lblFullName, 0, 4);
            this.tblContainer.Controls.Add(this.txtFullName, 1, 4);
            this.tblContainer.Controls.Add(this.lblArabicFullName, 0, 3);
            this.tblContainer.Controls.Add(this.txtArabicFullName, 1, 3);
            this.tblContainer.Controls.Add(this.btnReadCard, 0, 0);
            this.tblContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblContainer.Location = new System.Drawing.Point(0, 0);
            this.tblContainer.Name = "tblContainer";
            this.tblContainer.RowCount = 20;
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblContainer.Size = new System.Drawing.Size(792, 573);
            this.tblContainer.TabIndex = 0;
            // 
            // lblArabicFullName
            // 
            this.lblArabicFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblArabicFullName.AutoSize = true;
            this.lblArabicFullName.Location = new System.Drawing.Point(753, 91);
            this.lblArabicFullName.Name = "lblArabicFullName";
            this.lblArabicFullName.Size = new System.Drawing.Size(36, 13);
            this.lblArabicFullName.TabIndex = 1;
            this.lblArabicFullName.Text = "الاسم";
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFullName.Location = new System.Drawing.Point(421, 116);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(250, 20);
            this.txtFullName.TabIndex = 3;
            this.txtFullName.TabStop = false;
            // 
            // txtArabicFullName
            // 
            this.txtArabicFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtArabicFullName.Location = new System.Drawing.Point(421, 88);
            this.txtArabicFullName.Name = "txtArabicFullName";
            this.txtArabicFullName.ReadOnly = true;
            this.txtArabicFullName.Size = new System.Drawing.Size(250, 20);
            this.txtArabicFullName.TabIndex = 2;
            this.txtArabicFullName.TabStop = false;
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(705, 119);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(84, 13);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "الاسم بالإنجليزية";
            // 
            // btnReadCard
            // 
            this.tblContainer.SetColumnSpan(this.btnReadCard, 2);
            this.btnReadCard.Location = new System.Drawing.Point(612, 3);
            this.btnReadCard.Name = "btnReadCard";
            this.tblContainer.SetRowSpan(this.btnReadCard, 3);
            this.btnReadCard.Size = new System.Drawing.Size(177, 68);
            this.btnReadCard.TabIndex = 4;
            this.btnReadCard.Text = "البدء بقراءة بيانات البطاقة";
            this.btnReadCard.UseVisualStyleBackColor = true;
            this.btnReadCard.Click += new System.EventHandler(this.btnReadCard_Click);
            // 
            // btnSaveToSP
            // 
            this.tblContainer.SetColumnSpan(this.btnSaveToSP, 2);
            this.btnSaveToSP.Location = new System.Drawing.Point(217, 3);
            this.btnSaveToSP.Name = "btnSaveToSP";
            this.tblContainer.SetRowSpan(this.btnSaveToSP, 3);
            this.btnSaveToSP.Size = new System.Drawing.Size(177, 68);
            this.btnSaveToSP.TabIndex = 5;
            this.btnSaveToSP.Text = "حفظ بقاعدة البيانات";
            this.btnSaveToSP.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.tblContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قارئ بطاقة الهوية";
            this.tblContainer.ResumeLayout(false);
            this.tblContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblContainer;
        private System.Windows.Forms.Label lblArabicFullName;
        private System.Windows.Forms.TextBox txtArabicFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnReadCard;
        private System.Windows.Forms.Button btnSaveToSP;
    }
}

