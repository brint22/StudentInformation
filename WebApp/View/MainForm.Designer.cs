namespace WebApp
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.teFullName = new DevExpress.XtraEditors.TextEdit();
            this.teAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblContactNumber = new DevExpress.XtraEditors.LabelControl();
            this.teGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.gcStudents = new DevExpress.XtraGrid.GridControl();
            this.gvStudents = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.StudentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Age = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContactNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnDisplay = new DevExpress.XtraEditors.SimpleButton();
            this.teContactNumber = new DevExpress.XtraEditors.TextEdit();
            this.teAge = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.teFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teContactNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAge.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teFullName
            // 
            this.teFullName.Location = new System.Drawing.Point(64, 108);
            this.teFullName.Margin = new System.Windows.Forms.Padding(4);
            this.teFullName.Name = "teFullName";
            this.teFullName.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teFullName.Properties.Appearance.Options.UseFont = true;
            this.teFullName.Properties.AutoHeight = false;
            this.teFullName.Size = new System.Drawing.Size(375, 29);
            this.teFullName.TabIndex = 0;
            // 
            // teAddress
            // 
            this.teAddress.Location = new System.Drawing.Point(64, 246);
            this.teAddress.Margin = new System.Windows.Forms.Padding(4);
            this.teAddress.Name = "teAddress";
            this.teAddress.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.teAddress.Properties.Appearance.Options.UseFont = true;
            this.teAddress.Properties.AutoHeight = false;
            this.teAddress.Size = new System.Drawing.Size(375, 29);
            this.teAddress.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(186, 29);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(159, 24);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "STUDENT FORM";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(64, 81);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 23);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Full Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(64, 145);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 23);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Age";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(157, 145);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 23);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Gender";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(64, 219);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(73, 23);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Address";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.lblContactNumber.Appearance.Options.UseFont = true;
            this.lblContactNumber.Location = new System.Drawing.Point(64, 294);
            this.lblContactNumber.Margin = new System.Windows.Forms.Padding(4);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(143, 23);
            this.lblContactNumber.TabIndex = 10;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // teGender
            // 
            this.teGender.Location = new System.Drawing.Point(157, 172);
            this.teGender.Margin = new System.Windows.Forms.Padding(4);
            this.teGender.Name = "teGender";
            this.teGender.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.teGender.Properties.Appearance.Options.UseFont = true;
            this.teGender.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 10.8F);
            this.teGender.Properties.AppearanceDropDown.Options.UseFont = true;
            this.teGender.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teGender.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.teGender.Properties.AutoHeight = false;
            this.teGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teGender.Properties.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.teGender.Size = new System.Drawing.Size(282, 29);
            this.teGender.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Appearance.Options.UseBackColor = true;
            this.btnSubmit.Appearance.Options.UseFont = true;
            this.btnSubmit.Location = new System.Drawing.Point(64, 366);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(375, 28);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gcStudents
            // 
            this.gcStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcStudents.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridLevelNode1.RelationName = "Level1";
            this.gcStudents.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcStudents.Location = new System.Drawing.Point(507, 84);
            this.gcStudents.MainView = this.gvStudents;
            this.gcStudents.Margin = new System.Windows.Forms.Padding(4);
            this.gcStudents.Name = "gcStudents";
            this.gcStudents.Size = new System.Drawing.Size(426, 347);
            this.gcStudents.TabIndex = 13;
            this.gcStudents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStudents});
            // 
            // gvStudents
            // 
            this.gvStudents.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.StudentID,
            this.FullName,
            this.Age,
            this.Gender,
            this.Address,
            this.ContactNumber});
            this.gvStudents.DetailHeight = 431;
            this.gvStudents.GridControl = this.gcStudents;
            this.gvStudents.Name = "gvStudents";
            this.gvStudents.OptionsEditForm.PopupEditFormWidth = 933;
            this.gvStudents.OptionsView.ShowGroupPanel = false;
            // 
            // StudentID
            // 
            this.StudentID.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.8F);
            this.StudentID.AppearanceCell.Options.UseFont = true;
            this.StudentID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.StudentID.AppearanceHeader.Options.UseFont = true;
            this.StudentID.Caption = "Student ID";
            this.StudentID.FieldName = "StudentID";
            this.StudentID.MinWidth = 25;
            this.StudentID.Name = "StudentID";
            this.StudentID.OptionsColumn.AllowEdit = false;
            this.StudentID.Visible = true;
            this.StudentID.VisibleIndex = 0;
            this.StudentID.Width = 59;
            // 
            // FullName
            // 
            this.FullName.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.8F);
            this.FullName.AppearanceCell.Options.UseFont = true;
            this.FullName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.FullName.AppearanceHeader.Options.UseFont = true;
            this.FullName.Caption = "Full Name";
            this.FullName.FieldName = "FullName";
            this.FullName.MinWidth = 25;
            this.FullName.Name = "FullName";
            this.FullName.OptionsColumn.AllowEdit = false;
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 1;
            this.FullName.Width = 89;
            // 
            // Age
            // 
            this.Age.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.8F);
            this.Age.AppearanceCell.Options.UseFont = true;
            this.Age.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.Age.AppearanceHeader.Options.UseFont = true;
            this.Age.Caption = "Age";
            this.Age.FieldName = "Age";
            this.Age.MinWidth = 25;
            this.Age.Name = "Age";
            this.Age.OptionsColumn.AllowEdit = false;
            this.Age.Visible = true;
            this.Age.VisibleIndex = 2;
            this.Age.Width = 39;
            // 
            // Gender
            // 
            this.Gender.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.8F);
            this.Gender.AppearanceCell.Options.UseFont = true;
            this.Gender.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.Gender.AppearanceHeader.Options.UseFont = true;
            this.Gender.Caption = "Gender";
            this.Gender.FieldName = "Gender";
            this.Gender.MinWidth = 25;
            this.Gender.Name = "Gender";
            this.Gender.OptionsColumn.AllowEdit = false;
            this.Gender.Visible = true;
            this.Gender.VisibleIndex = 3;
            this.Gender.Width = 39;
            // 
            // Address
            // 
            this.Address.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.8F);
            this.Address.AppearanceCell.Options.UseFont = true;
            this.Address.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.Address.AppearanceHeader.Options.UseFont = true;
            this.Address.Caption = "Address";
            this.Address.FieldName = "Address";
            this.Address.MinWidth = 25;
            this.Address.Name = "Address";
            this.Address.OptionsColumn.AllowEdit = false;
            this.Address.Visible = true;
            this.Address.VisibleIndex = 4;
            this.Address.Width = 101;
            // 
            // ContactNumber
            // 
            this.ContactNumber.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.8F);
            this.ContactNumber.AppearanceCell.Options.UseFont = true;
            this.ContactNumber.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.ContactNumber.AppearanceHeader.Options.UseFont = true;
            this.ContactNumber.Caption = "Contact Number";
            this.ContactNumber.FieldName = "ContactNumber";
            this.ContactNumber.MinWidth = 25;
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.OptionsColumn.AllowEdit = false;
            this.ContactNumber.Visible = true;
            this.ContactNumber.VisibleIndex = 5;
            this.ContactNumber.Width = 69;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Appearance.Options.UseBackColor = true;
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Location = new System.Drawing.Point(64, 441);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(375, 28);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(64, 481);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(375, 28);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.btnDisplay.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDisplay.Appearance.Options.UseBackColor = true;
            this.btnDisplay.Appearance.Options.UseFont = true;
            this.btnDisplay.Location = new System.Drawing.Point(64, 402);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(375, 28);
            this.btnDisplay.TabIndex = 16;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // teContactNumber
            // 
            this.teContactNumber.Location = new System.Drawing.Point(64, 320);
            this.teContactNumber.Margin = new System.Windows.Forms.Padding(4);
            this.teContactNumber.Name = "teContactNumber";
            this.teContactNumber.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.teContactNumber.Properties.Appearance.Options.UseFont = true;
            this.teContactNumber.Properties.AutoHeight = false;
            this.teContactNumber.Size = new System.Drawing.Size(375, 29);
            this.teContactNumber.TabIndex = 17;
            this.teContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.teContactNumber_KeyPress);
            // 
            // teAge
            // 
            this.teAge.Location = new System.Drawing.Point(64, 172);
            this.teAge.Margin = new System.Windows.Forms.Padding(4);
            this.teAge.Name = "teAge";
            this.teAge.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teAge.Properties.Appearance.Options.UseFont = true;
            this.teAge.Properties.AutoHeight = false;
            this.teAge.Size = new System.Drawing.Size(85, 29);
            this.teAge.TabIndex = 18;
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 559);
            this.Controls.Add(this.teAge);
            this.Controls.Add(this.teContactNumber);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gcStudents);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.teGender);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.teAddress);
            this.Controls.Add(this.teFullName);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Student Information | Insert Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.teFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teContactNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAge.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teFullName;
        private DevExpress.XtraEditors.TextEdit teAddress;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblContactNumber;
        private DevExpress.XtraEditors.ComboBoxEdit teGender;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraGrid.GridControl gcStudents;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStudents;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnDisplay;
        private DevExpress.XtraEditors.TextEdit teContactNumber;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn Age;
        private DevExpress.XtraGrid.Columns.GridColumn Gender;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn ContactNumber;
        private DevExpress.XtraGrid.Columns.GridColumn StudentID;
        private DevExpress.XtraEditors.TextEdit teAge;
    }
}

