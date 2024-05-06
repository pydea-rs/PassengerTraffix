namespace PassengerTraffix
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuOptions = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSurveillance = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClearForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.sections = new System.Windows.Forms.SplitContainer();
            this.cbPassengers = new System.Windows.Forms.ComboBox();
            this.btnClear = new BehComponents.ButtonX();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtClosetNumber = new System.Windows.Forms.TextBox();
            this.lblClosetNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cbTargetUnit = new System.Windows.Forms.ComboBox();
            this.checkIsEntering = new System.Windows.Forms.CheckBox();
            this.lblTargetUnit = new System.Windows.Forms.Label();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.checkHasARide = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new BehComponents.ButtonX();
            this.txtVehicleModel = new System.Windows.Forms.TextBox();
            this.lblVehicleModel = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblran = new System.Windows.Forms.Label();
            this.txtPlateIranID = new System.Windows.Forms.TextBox();
            this.txtPlate2ndSection = new System.Windows.Forms.TextBox();
            this.txtPlateLetter = new System.Windows.Forms.TextBox();
            this.txtPlate1stSection = new System.Windows.Forms.TextBox();
            this.lblPlate = new System.Windows.Forms.Label();
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.menuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sections)).BeginInit();
            this.sections.Panel1.SuspendLayout();
            this.sections.Panel2.SuspendLayout();
            this.sections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuOptions
            // 
            this.menuOptions.BackColor = System.Drawing.SystemColors.Control;
            this.menuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.menuOptions.Location = new System.Drawing.Point(0, 0);
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuOptions.Size = new System.Drawing.Size(928, 35);
            this.menuOptions.TabIndex = 21;
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSurveillance,
            this.toolStripSeparator1,
            this.mnuClearForm,
            this.mnuExit});
            this.mnuOptions.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuOptions.Size = new System.Drawing.Size(66, 31);
            this.mnuOptions.Text = "گزینه ها";
            // 
            // mnuSurveillance
            // 
            this.mnuSurveillance.Name = "mnuSurveillance";
            this.mnuSurveillance.Size = new System.Drawing.Size(161, 32);
            this.mnuSurveillance.Text = "نظارت";
            this.mnuSurveillance.Click += new System.EventHandler(this.mnuSurveillanceMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // mnuClearForm
            // 
            this.mnuClearForm.Name = "mnuClearForm";
            this.mnuClearForm.Size = new System.Drawing.Size(161, 32);
            this.mnuClearForm.Text = "پاک کردن فرم";
            this.mnuClearForm.Click += new System.EventHandler(this.mnuClearForm_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(161, 32);
            this.mnuExit.Text = "خروج";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // sections
            // 
            this.sections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sections.Location = new System.Drawing.Point(12, 39);
            this.sections.Name = "sections";
            // 
            // sections.Panel1
            // 
            this.sections.Panel1.Controls.Add(this.cbPassengers);
            this.sections.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // sections.Panel2
            // 
            this.sections.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sections.Panel2.Controls.Add(this.btnClear);
            this.sections.Panel2.Controls.Add(this.pictureBox2);
            this.sections.Panel2.Controls.Add(this.txtClosetNumber);
            this.sections.Panel2.Controls.Add(this.lblClosetNumber);
            this.sections.Panel2.Controls.Add(this.lblLastName);
            this.sections.Panel2.Controls.Add(this.txtLastName);
            this.sections.Panel2.Controls.Add(this.cbTargetUnit);
            this.sections.Panel2.Controls.Add(this.checkIsEntering);
            this.sections.Panel2.Controls.Add(this.lblTargetUnit);
            this.sections.Panel2.Controls.Add(this.txtPhonenumber);
            this.sections.Panel2.Controls.Add(this.lblPhonenumber);
            this.sections.Panel2.Controls.Add(this.checkHasARide);
            this.sections.Panel2.Controls.Add(this.btnSubmit);
            this.sections.Panel2.Controls.Add(this.txtVehicleModel);
            this.sections.Panel2.Controls.Add(this.lblVehicleModel);
            this.sections.Panel2.Controls.Add(this.txtFirstName);
            this.sections.Panel2.Controls.Add(this.lblFirstName);
            this.sections.Panel2.Controls.Add(this.lblran);
            this.sections.Panel2.Controls.Add(this.txtPlateIranID);
            this.sections.Panel2.Controls.Add(this.txtPlate2ndSection);
            this.sections.Panel2.Controls.Add(this.txtPlateLetter);
            this.sections.Panel2.Controls.Add(this.txtPlate1stSection);
            this.sections.Panel2.Controls.Add(this.lblPlate);
            this.sections.Panel2.Controls.Add(this.txtNationalID);
            this.sections.Panel2.Controls.Add(this.lblID);
            this.sections.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sections.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.sections_Panel2_Paint);
            this.sections.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sections.Size = new System.Drawing.Size(904, 414);
            this.sections.SplitterDistance = 297;
            this.sections.TabIndex = 27;
            // 
            // cbPassengers
            // 
            this.cbPassengers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbPassengers.Font = new System.Drawing.Font("Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbPassengers.FormattingEnabled = true;
            this.cbPassengers.Location = new System.Drawing.Point(0, 0);
            this.cbPassengers.MaxDropDownItems = 10;
            this.cbPassengers.Name = "cbPassengers";
            this.cbPassengers.Size = new System.Drawing.Size(296, 439);
            this.cbPassengers.TabIndex = 14;
            this.cbPassengers.TabStop = false;
            this.cbPassengers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbPassengers_KeyDown);
            this.cbPassengers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AutoSelectComboItem);
            // 
            // btnClear
            // 
            this.btnClear.BoldedForeColor = System.Drawing.Color.Blue;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnClear.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClear.HolidayForeColor = System.Drawing.Color.Red;
            this.btnClear.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btnClear.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btnClear.IsBolded = false;
            this.btnClear.IsHoliday = false;
            this.btnClear.IsTrailing = false;
            this.btnClear.Location = new System.Drawing.Point(21, 151);
            this.btnClear.Name = "btnClear";
            this.btnClear.PushedAlways = false;
            this.btnClear.SecondBorderColor = System.Drawing.Color.Red;
            this.btnClear.SecondBorderDistanceToEdge = 3F;
            this.btnClear.SecondBorderWidth = 3F;
            this.btnClear.ShowFirstBorder = true;
            this.btnClear.ShowSecondBorder = false;
            this.btnClear.Size = new System.Drawing.Size(96, 34);
            this.btnClear.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btnClear.TabIndex = 15;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "پاک کردن فرم";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClear.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PassengerTraffix.Properties.Resources.Untitled;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 325);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(595, 2);
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // txtClosetNumber
            // 
            this.txtClosetNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClosetNumber.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtClosetNumber.Location = new System.Drawing.Point(123, 151);
            this.txtClosetNumber.MaxLength = 10;
            this.txtClosetNumber.Name = "txtClosetNumber";
            this.txtClosetNumber.Size = new System.Drawing.Size(94, 34);
            this.txtClosetNumber.TabIndex = 6;
            this.txtClosetNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClosetNumber.TextChanged += new System.EventHandler(this.txtClosetNumber_TextChanged);
            this.txtClosetNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClosetNumber_KeyPress);
            // 
            // lblClosetNumber
            // 
            this.lblClosetNumber.AutoSize = true;
            this.lblClosetNumber.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblClosetNumber.Location = new System.Drawing.Point(230, 154);
            this.lblClosetNumber.Name = "lblClosetNumber";
            this.lblClosetNumber.Size = new System.Drawing.Size(68, 27);
            this.lblClosetNumber.TabIndex = 53;
            this.lblClosetNumber.Text = "شماره کمد";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLastName.Location = new System.Drawing.Point(221, 36);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(77, 27);
            this.lblLastName.TabIndex = 51;
            this.lblLastName.Text = "نام خانوادگی";
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLastName.Location = new System.Drawing.Point(21, 34);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(195, 34);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // cbTargetUnit
            // 
            this.cbTargetUnit.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbTargetUnit.FormattingEnabled = true;
            this.cbTargetUnit.Items.AddRange(new object[] {
            "واحد الف",
            "واحد ب",
            "واحد ج",
            "واحد د",
            "واحد ..."});
            this.cbTargetUnit.Location = new System.Drawing.Point(324, 150);
            this.cbTargetUnit.Name = "cbTargetUnit";
            this.cbTargetUnit.Size = new System.Drawing.Size(192, 35);
            this.cbTargetUnit.TabIndex = 5;
            this.cbTargetUnit.SelectedIndexChanged += new System.EventHandler(this.cbTargetUnit_SelectedIndexChanged);
            this.cbTargetUnit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AutoSelectComboItem);
            // 
            // checkIsEntering
            // 
            this.checkIsEntering.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkIsEntering.BackColor = System.Drawing.Color.SpringGreen;
            this.checkIsEntering.Checked = true;
            this.checkIsEntering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIsEntering.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkIsEntering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkIsEntering.Font = new System.Drawing.Font("Mitra", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkIsEntering.Location = new System.Drawing.Point(409, 224);
            this.checkIsEntering.Name = "checkIsEntering";
            this.checkIsEntering.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkIsEntering.Size = new System.Drawing.Size(110, 40);
            this.checkIsEntering.TabIndex = 7;
            this.checkIsEntering.Text = "ورود";
            this.checkIsEntering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkIsEntering.UseVisualStyleBackColor = false;
            this.checkIsEntering.CheckedChanged += new System.EventHandler(this.checkIsEntering_CheckedChanged);
            // 
            // lblTargetUnit
            // 
            this.lblTargetUnit.AutoSize = true;
            this.lblTargetUnit.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTargetUnit.Location = new System.Drawing.Point(521, 154);
            this.lblTargetUnit.Name = "lblTargetUnit";
            this.lblTargetUnit.Size = new System.Drawing.Size(75, 27);
            this.lblTargetUnit.TabIndex = 44;
            this.lblTargetUnit.Text = "واحد مراجعه";
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhonenumber.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPhonenumber.Location = new System.Drawing.Point(21, 85);
            this.txtPhonenumber.MaxLength = 11;
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(195, 34);
            this.txtPhonenumber.TabIndex = 4;
            this.txtPhonenumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhonenumber.TextChanged += new System.EventHandler(this.txtPhonenumber_TextChanged);
            this.txtPhonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBoxes_KeyPress);
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPhonenumber.Location = new System.Drawing.Point(244, 89);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(36, 27);
            this.lblPhonenumber.TabIndex = 42;
            this.lblPhonenumber.Text = "تلفن";
            // 
            // checkHasARide
            // 
            this.checkHasARide.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkHasARide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkHasARide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkHasARide.Font = new System.Drawing.Font("Mitra", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkHasARide.Location = new System.Drawing.Point(276, 224);
            this.checkHasARide.Name = "checkHasARide";
            this.checkHasARide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkHasARide.Size = new System.Drawing.Size(110, 40);
            this.checkHasARide.TabIndex = 8;
            this.checkHasARide.Text = "پیاده";
            this.checkHasARide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkHasARide.UseVisualStyleBackColor = true;
            this.checkHasARide.CheckedChanged += new System.EventHandler(this.checkHasARide_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BoldedForeColor = System.Drawing.Color.Blue;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnSubmit.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSubmit.HolidayForeColor = System.Drawing.Color.Red;
            this.btnSubmit.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btnSubmit.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btnSubmit.IsBolded = false;
            this.btnSubmit.IsHoliday = false;
            this.btnSubmit.IsTrailing = false;
            this.btnSubmit.Location = new System.Drawing.Point(21, 224);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PushedAlways = false;
            this.btnSubmit.SecondBorderColor = System.Drawing.Color.Red;
            this.btnSubmit.SecondBorderDistanceToEdge = 3F;
            this.btnSubmit.SecondBorderWidth = 3F;
            this.btnSubmit.ShowFirstBorder = true;
            this.btnSubmit.ShowSecondBorder = false;
            this.btnSubmit.Size = new System.Drawing.Size(195, 40);
            this.btnSubmit.Style = BehComponents.ButtonX.ButtonStyles.Green;
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtVehicleModel
            // 
            this.txtVehicleModel.BackColor = System.Drawing.Color.Silver;
            this.txtVehicleModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleModel.Enabled = false;
            this.txtVehicleModel.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtVehicleModel.Location = new System.Drawing.Point(324, 360);
            this.txtVehicleModel.Name = "txtVehicleModel";
            this.txtVehicleModel.Size = new System.Drawing.Size(192, 34);
            this.txtVehicleModel.TabIndex = 9;
            this.txtVehicleModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVehicleModel
            // 
            this.lblVehicleModel.AutoSize = true;
            this.lblVehicleModel.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblVehicleModel.Location = new System.Drawing.Point(521, 362);
            this.lblVehicleModel.Name = "lblVehicleModel";
            this.lblVehicleModel.Size = new System.Drawing.Size(70, 27);
            this.lblVehicleModel.TabIndex = 40;
            this.lblVehicleModel.Text = "مدل خودرو";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFirstName.Location = new System.Drawing.Point(324, 34);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(195, 34);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFirstName.Location = new System.Drawing.Point(556, 36);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(26, 27);
            this.lblFirstName.TabIndex = 39;
            this.lblFirstName.Text = "نام";
            // 
            // lblran
            // 
            this.lblran.AutoSize = true;
            this.lblran.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblran.Location = new System.Drawing.Point(181, 330);
            this.lblran.Name = "lblran";
            this.lblran.Size = new System.Drawing.Size(38, 27);
            this.lblran.TabIndex = 33;
            this.lblran.Text = "ایران";
            // 
            // txtPlateIranID
            // 
            this.txtPlateIranID.BackColor = System.Drawing.Color.Silver;
            this.txtPlateIranID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlateIranID.Enabled = false;
            this.txtPlateIranID.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPlateIranID.Location = new System.Drawing.Point(181, 360);
            this.txtPlateIranID.MaxLength = 2;
            this.txtPlateIranID.Name = "txtPlateIranID";
            this.txtPlateIranID.Size = new System.Drawing.Size(43, 34);
            this.txtPlateIranID.TabIndex = 13;
            this.txtPlateIranID.Tag = "";
            this.txtPlateIranID.TextChanged += new System.EventHandler(this.txtPlateIranID_TextChanged);
            this.txtPlateIranID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBoxes_KeyPress);
            // 
            // txtPlate2ndSection
            // 
            this.txtPlate2ndSection.BackColor = System.Drawing.Color.Silver;
            this.txtPlate2ndSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlate2ndSection.Enabled = false;
            this.txtPlate2ndSection.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPlate2ndSection.Location = new System.Drawing.Point(123, 360);
            this.txtPlate2ndSection.MaxLength = 3;
            this.txtPlate2ndSection.Name = "txtPlate2ndSection";
            this.txtPlate2ndSection.Size = new System.Drawing.Size(43, 34);
            this.txtPlate2ndSection.TabIndex = 12;
            this.txtPlate2ndSection.Tag = "";
            this.txtPlate2ndSection.TextChanged += new System.EventHandler(this.txtPlate2ndSection_TextChanged);
            this.txtPlate2ndSection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBoxes_KeyPress);
            // 
            // txtPlateLetter
            // 
            this.txtPlateLetter.BackColor = System.Drawing.Color.Silver;
            this.txtPlateLetter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlateLetter.Enabled = false;
            this.txtPlateLetter.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPlateLetter.Location = new System.Drawing.Point(81, 360);
            this.txtPlateLetter.MaxLength = 2;
            this.txtPlateLetter.Name = "txtPlateLetter";
            this.txtPlateLetter.Size = new System.Drawing.Size(36, 34);
            this.txtPlateLetter.TabIndex = 11;
            this.txtPlateLetter.TextChanged += new System.EventHandler(this.txtPlateLetter_TextChanged);
            // 
            // txtPlate1stSection
            // 
            this.txtPlate1stSection.BackColor = System.Drawing.Color.Silver;
            this.txtPlate1stSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlate1stSection.Enabled = false;
            this.txtPlate1stSection.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPlate1stSection.Location = new System.Drawing.Point(32, 360);
            this.txtPlate1stSection.MaxLength = 3;
            this.txtPlate1stSection.Name = "txtPlate1stSection";
            this.txtPlate1stSection.Size = new System.Drawing.Size(43, 34);
            this.txtPlate1stSection.TabIndex = 10;
            this.txtPlate1stSection.TextChanged += new System.EventHandler(this.txtPlate1stSection_TextChanged);
            this.txtPlate1stSection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBoxes_KeyPress);
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.BackColor = System.Drawing.SystemColors.Control;
            this.lblPlate.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPlate.Location = new System.Drawing.Point(230, 362);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(41, 27);
            this.lblPlate.TabIndex = 29;
            this.lblPlate.Text = "پلاک";
            // 
            // txtNationalID
            // 
            this.txtNationalID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNationalID.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNationalID.Location = new System.Drawing.Point(324, 84);
            this.txtNationalID.MaxLength = 10;
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size(195, 34);
            this.txtNationalID.TabIndex = 3;
            this.txtNationalID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNationalID.TextChanged += new System.EventHandler(this.txtNationalID_TextChanged);
            this.txtNationalID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBoxes_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblID.Location = new System.Drawing.Point(531, 89);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(51, 27);
            this.lblID.TabIndex = 27;
            this.lblID.Text = "کد ملی";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(928, 467);
            this.Controls.Add(this.sections);
            this.Controls.Add(this.menuOptions);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuOptions;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "  ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuOptions.ResumeLayout(false);
            this.menuOptions.PerformLayout();
            this.sections.Panel1.ResumeLayout(false);
            this.sections.Panel2.ResumeLayout(false);
            this.sections.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sections)).EndInit();
            this.sections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuSurveillance;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.SplitContainer sections;
        private System.Windows.Forms.Label lblTargetUnit;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.CheckBox checkHasARide;
        private BehComponents.ButtonX btnSubmit;
        private System.Windows.Forms.TextBox txtVehicleModel;
        private System.Windows.Forms.Label lblVehicleModel;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblran;
        private System.Windows.Forms.TextBox txtPlateIranID;
        private System.Windows.Forms.TextBox txtPlate2ndSection;
        private System.Windows.Forms.TextBox txtPlateLetter;
        private System.Windows.Forms.TextBox txtPlate1stSection;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.CheckBox checkIsEntering;
        private System.Windows.Forms.ComboBox cbTargetUnit;
        private System.Windows.Forms.ComboBox cbPassengers;
        private System.Windows.Forms.ToolStripMenuItem mnuClearForm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblClosetNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtClosetNumber;
        private System.Windows.Forms.PictureBox pictureBox2;
        private BehComponents.ButtonX btnClear;
    }
}

