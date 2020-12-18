namespace POS1
{
    partial class Frm_BuyReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuyReport));
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.chkdt = new DevExpress.XtraEditors.CheckEdit();
            this.txtorderID = new DevExpress.XtraEditors.TextEdit();
            this.dtto = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chkorderID = new DevExpress.XtraEditors.CheckEdit();
            this.dtfrom = new DevExpress.XtraEditors.DateEdit();
            this.CbxSupplier = new DevExpress.XtraEditors.ComboBoxEdit();
            this.RadioSupplier = new DevExpress.XtraEditors.RadioGroup();
            this.btndel = new DevExpress.XtraEditors.SimpleButton();
            this.btnprint = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txttotal = new DevExpress.XtraEditors.TextEdit();
            this.btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnprintall = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtorderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtto.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkorderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg1.BackgroundColor = System.Drawing.Color.White;
            this.dg1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg1.ColumnHeadersHeight = 50;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Date,
            this.View});
            this.dg1.Location = new System.Drawing.Point(12, 182);
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowHeadersVisible = false;
            this.dg1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dg1.RowTemplate.Height = 40;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(734, 237);
            this.dg1.TabIndex = 10;
            this.dg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Order_ID";
            this.Column1.FillWeight = 131.9797F;
            this.Column1.HeaderText = "رقم الفاتورة";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "Sup_Name";
            this.Column2.FillWeight = 92.00507F;
            this.Column2.HeaderText = "المورد";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "Total_Mount";
            this.Column3.FillWeight = 92.00507F;
            this.Column3.HeaderText = "الاجمالي";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "Paid";
            this.Column4.FillWeight = 92.00507F;
            this.Column4.HeaderText = "المدفوع";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Debit";
            this.Column5.FillWeight = 92.00507F;
            this.Column5.HeaderText = "الباقي";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "التاريخ";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // View
            // 
            this.View.HeaderText = "";
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Text = "عرض";
            this.View.UseColumnTextForButtonValue = true;
            // 
            // btnView
            // 
            this.btnView.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Appearance.Options.UseFont = true;
            this.btnView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnView.ImageOptions.Image")));
            this.btnView.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnView.Location = new System.Drawing.Point(175, 40);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(86, 32);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "عرض";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.CbxSupplier);
            this.groupControl1.Controls.Add(this.RadioSupplier);
            this.groupControl1.Controls.Add(this.btnView);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(12, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(734, 160);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "بحث عن فواتير";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.separatorControl1);
            this.groupControl2.Controls.Add(this.chkdt);
            this.groupControl2.Controls.Add(this.txtorderID);
            this.groupControl2.Controls.Add(this.dtto);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.chkorderID);
            this.groupControl2.Controls.Add(this.dtfrom);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(30, 74);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(673, 77);
            this.groupControl2.TabIndex = 44;
            this.groupControl2.Text = "خيارات البحث";
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.LineThickness = 1;
            this.separatorControl1.Location = new System.Drawing.Point(413, 17);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(19, 56);
            this.separatorControl1.TabIndex = 46;
            // 
            // chkdt
            // 
            this.chkdt.Location = new System.Drawing.Point(325, 33);
            this.chkdt.Name = "chkdt";
            this.chkdt.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkdt.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.chkdt.Properties.Appearance.Options.UseFont = true;
            this.chkdt.Properties.Appearance.Options.UseForeColor = true;
            this.chkdt.Properties.Caption = "الفترة من :";
            this.chkdt.Size = new System.Drawing.Size(87, 29);
            this.chkdt.TabIndex = 44;
            // 
            // txtorderID
            // 
            this.txtorderID.Location = new System.Drawing.Point(438, 30);
            this.txtorderID.Name = "txtorderID";
            this.txtorderID.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorderID.Properties.Appearance.Options.UseFont = true;
            this.txtorderID.Properties.Appearance.Options.UseTextOptions = true;
            this.txtorderID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtorderID.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtorderID.Properties.Mask.EditMask = "f0";
            this.txtorderID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtorderID.Size = new System.Drawing.Size(84, 32);
            this.txtorderID.TabIndex = 38;
            // 
            // dtto
            // 
            this.dtto.EditValue = null;
            this.dtto.Location = new System.Drawing.Point(61, 30);
            this.dtto.Name = "dtto";
            this.dtto.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtto.Properties.Appearance.Options.UseFont = true;
            this.dtto.Properties.Appearance.Options.UseTextOptions = true;
            this.dtto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dtto.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dtto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtto.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtto.Properties.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.dtto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtto.Properties.EditFormat.FormatString = "yyyy/MM/dd";
            this.dtto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtto.Properties.Mask.EditMask = "yyyy/MM/dd";
            this.dtto.Size = new System.Drawing.Size(103, 32);
            this.dtto.TabIndex = 41;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(170, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 25);
            this.labelControl2.TabIndex = 43;
            this.labelControl2.Text = "إلـى :";
            // 
            // chkorderID
            // 
            this.chkorderID.Location = new System.Drawing.Point(524, 33);
            this.chkorderID.Name = "chkorderID";
            this.chkorderID.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkorderID.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.chkorderID.Properties.Appearance.Options.UseFont = true;
            this.chkorderID.Properties.Appearance.Options.UseForeColor = true;
            this.chkorderID.Properties.Caption = "رقم الفاتورة";
            this.chkorderID.Size = new System.Drawing.Size(98, 29);
            this.chkorderID.TabIndex = 37;
            // 
            // dtfrom
            // 
            this.dtfrom.EditValue = null;
            this.dtfrom.Location = new System.Drawing.Point(208, 30);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfrom.Properties.Appearance.Options.UseFont = true;
            this.dtfrom.Properties.Appearance.Options.UseTextOptions = true;
            this.dtfrom.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dtfrom.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dtfrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfrom.Properties.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.dtfrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtfrom.Properties.EditFormat.FormatString = "yyyy/MM/dd";
            this.dtfrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtfrom.Properties.Mask.EditMask = "yyyy/MM/dd";
            this.dtfrom.Size = new System.Drawing.Size(111, 32);
            this.dtfrom.TabIndex = 40;
            // 
            // CbxSupplier
            // 
            this.CbxSupplier.Location = new System.Drawing.Point(267, 40);
            this.CbxSupplier.Name = "CbxSupplier";
            this.CbxSupplier.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSupplier.Properties.Appearance.Options.UseFont = true;
            this.CbxSupplier.Properties.Appearance.Options.UseTextOptions = true;
            this.CbxSupplier.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CbxSupplier.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CbxSupplier.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSupplier.Properties.AppearanceDropDown.Options.UseFont = true;
            this.CbxSupplier.Properties.AppearanceDropDown.Options.UseTextOptions = true;
            this.CbxSupplier.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CbxSupplier.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CbxSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbxSupplier.Size = new System.Drawing.Size(120, 32);
            this.CbxSupplier.TabIndex = 36;
            // 
            // RadioSupplier
            // 
            this.RadioSupplier.Location = new System.Drawing.Point(377, 38);
            this.RadioSupplier.Name = "RadioSupplier";
            this.RadioSupplier.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.RadioSupplier.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioSupplier.Properties.Appearance.Options.UseBackColor = true;
            this.RadioSupplier.Properties.Appearance.Options.UseFont = true;
            this.RadioSupplier.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RadioSupplier.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "كل الموردين"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "مورد محدد")});
            this.RadioSupplier.Size = new System.Drawing.Size(186, 30);
            this.RadioSupplier.TabIndex = 35;
            // 
            // btndel
            // 
            this.btndel.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Appearance.Options.UseFont = true;
            this.btndel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btndel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btndel.ImageOptions.SvgImage")));
            this.btndel.Location = new System.Drawing.Point(355, 18);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(136, 45);
            this.btndel.TabIndex = 14;
            this.btndel.Text = "حذف فاتورة";
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnprint
            // 
            this.btnprint.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.btnprint.Appearance.Options.UseFont = true;
            this.btnprint.Appearance.Options.UseTextOptions = true;
            this.btnprint.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnprint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.ImageOptions.Image")));
            this.btnprint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnprint.Location = new System.Drawing.Point(443, 249);
            this.btnprint.Name = "btnprint";
            this.btnprint.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnprint.Size = new System.Drawing.Size(103, 31);
            this.btnprint.TabIndex = 38;
            this.btnprint.Text = "طباعة";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl3.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.groupControl3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImageOptions.Image")));
            this.groupControl3.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl3.Controls.Add(this.txttotal);
            this.groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl3.Location = new System.Drawing.Point(593, 425);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(153, 75);
            this.groupControl3.TabIndex = 39;
            this.groupControl3.Text = "اجمالي المبلغ";
            // 
            // txttotal
            // 
            this.txttotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txttotal.Location = new System.Drawing.Point(9, 29);
            this.txttotal.Name = "txttotal";
            this.txttotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.txttotal.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txttotal.Properties.Appearance.Options.UseBackColor = true;
            this.txttotal.Properties.Appearance.Options.UseFont = true;
            this.txttotal.Properties.Appearance.Options.UseForeColor = true;
            this.txttotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txttotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txttotal.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txttotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txttotal.Properties.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(139, 36);
            this.txttotal.TabIndex = 36;
            // 
            // btnedit
            // 
            this.btnedit.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Appearance.Options.UseFont = true;
            this.btnedit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.ImageOptions.Image")));
            this.btnedit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnedit.Location = new System.Drawing.Point(218, 18);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(131, 45);
            this.btnedit.TabIndex = 40;
            this.btnedit.Text = "تعديل فاتورة";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.btnprintall);
            this.groupControl4.Controls.Add(this.btndel);
            this.groupControl4.Controls.Add(this.btnedit);
            this.groupControl4.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl4.Location = new System.Drawing.Point(12, 425);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.ShowCaption = false;
            this.groupControl4.Size = new System.Drawing.Size(573, 75);
            this.groupControl4.TabIndex = 45;
            this.groupControl4.Text = "خيارات البحث";
            // 
            // btnprintall
            // 
            this.btnprintall.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintall.Appearance.Options.UseFont = true;
            this.btnprintall.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnprintall.ImageOptions.Image")));
            this.btnprintall.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnprintall.Location = new System.Drawing.Point(81, 18);
            this.btnprintall.Name = "btnprintall";
            this.btnprintall.Size = new System.Drawing.Size(131, 45);
            this.btnprintall.TabIndex = 42;
            this.btnprintall.Text = "طباعة الكل";
            this.btnprintall.Click += new System.EventHandler(this.btnprintall_Click);
            // 
            // Frm_BuyReport
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(755, 507);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Frm_BuyReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تقارير المشتريات";
            this.Load += new System.EventHandler(this.Frm_BuyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtorderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtto.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkorderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txttotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg1;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btndel;
        public DevExpress.XtraEditors.ComboBoxEdit CbxSupplier;
        private DevExpress.XtraEditors.RadioGroup RadioSupplier;
        private DevExpress.XtraEditors.SimpleButton btnprint;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        public DevExpress.XtraEditors.TextEdit txttotal;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtorderID;
        private DevExpress.XtraEditors.DateEdit dtto;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit chkorderID;
        private DevExpress.XtraEditors.DateEdit dtfrom;
        private DevExpress.XtraEditors.SimpleButton btnedit;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnprintall;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private DevExpress.XtraEditors.CheckEdit chkdt;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}