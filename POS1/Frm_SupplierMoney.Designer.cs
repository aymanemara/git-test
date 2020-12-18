namespace POS1
{
    partial class Frm_SupplierMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SupplierMoney));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnprint = new DevExpress.XtraEditors.SimpleButton();
            this.btnfind = new DevExpress.XtraEditors.SimpleButton();
            this.CbxSupplier = new DevExpress.XtraEditors.ComboBoxEdit();
            this.RadioSupplier = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.NudMount = new DevExpress.XtraEditors.SpinEdit();
            this.btnpay = new DevExpress.XtraEditors.SimpleButton();
            this.RadioPay = new DevExpress.XtraEditors.RadioGroup();
            this.txttotal = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudMount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioPay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.separatorControl1);
            this.groupControl1.Controls.Add(this.btnprint);
            this.groupControl1.Controls.Add(this.btnfind);
            this.groupControl1.Controls.Add(this.CbxSupplier);
            this.groupControl1.Controls.Add(this.RadioSupplier);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(4, 4);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(617, 90);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "المبالغ المستحقة للموردين";
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.LineThickness = 1;
            this.separatorControl1.Location = new System.Drawing.Point(141, 44);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(1);
            this.separatorControl1.Size = new System.Drawing.Size(3, 31);
            this.separatorControl1.TabIndex = 6;
            // 
            // btnprint
            // 
            this.btnprint.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.btnprint.Appearance.Options.UseFont = true;
            this.btnprint.Appearance.Options.UseTextOptions = true;
            this.btnprint.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnprint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.ImageOptions.Image")));
            this.btnprint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnprint.Location = new System.Drawing.Point(32, 44);
            this.btnprint.Name = "btnprint";
            this.btnprint.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnprint.Size = new System.Drawing.Size(103, 31);
            this.btnprint.TabIndex = 33;
            this.btnprint.Text = "طباعة";
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnfind
            // 
            this.btnfind.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.btnfind.Appearance.Options.UseFont = true;
            this.btnfind.Appearance.Options.UseTextOptions = true;
            this.btnfind.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnfind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnfind.ImageOptions.Image")));
            this.btnfind.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnfind.Location = new System.Drawing.Point(150, 44);
            this.btnfind.Name = "btnfind";
            this.btnfind.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnfind.Size = new System.Drawing.Size(103, 31);
            this.btnfind.TabIndex = 32;
            this.btnfind.Text = "بحث";
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // CbxSupplier
            // 
            this.CbxSupplier.Location = new System.Drawing.Point(259, 43);
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
            this.CbxSupplier.Size = new System.Drawing.Size(149, 32);
            this.CbxSupplier.TabIndex = 31;
            // 
            // RadioSupplier
            // 
            this.RadioSupplier.Location = new System.Drawing.Point(399, 41);
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
            this.RadioSupplier.TabIndex = 30;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.groupControl2.Controls.Add(this.NudMount);
            this.groupControl2.Controls.Add(this.btnpay);
            this.groupControl2.Controls.Add(this.RadioPay);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(4, 357);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(454, 89);
            this.groupControl2.TabIndex = 34;
            // 
            // NudMount
            // 
            this.NudMount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NudMount.Location = new System.Drawing.Point(105, 37);
            this.NudMount.Name = "NudMount";
            this.NudMount.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudMount.Properties.Appearance.Options.UseFont = true;
            this.NudMount.Properties.Appearance.Options.UseTextOptions = true;
            this.NudMount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NudMount.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NudMount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NudMount.Properties.DisplayFormat.FormatString = "0.00";
            this.NudMount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NudMount.Properties.Mask.EditMask = "n2";
            this.NudMount.Size = new System.Drawing.Size(131, 32);
            this.NudMount.TabIndex = 34;
            // 
            // btnpay
            // 
            this.btnpay.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.btnpay.Appearance.Options.UseFont = true;
            this.btnpay.Appearance.Options.UseTextOptions = true;
            this.btnpay.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnpay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnpay.ImageOptions.Image")));
            this.btnpay.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnpay.Location = new System.Drawing.Point(11, 37);
            this.btnpay.Name = "btnpay";
            this.btnpay.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnpay.Size = new System.Drawing.Size(88, 32);
            this.btnpay.TabIndex = 32;
            this.btnpay.Text = "دفــــــع";
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // RadioPay
            // 
            this.RadioPay.Location = new System.Drawing.Point(217, 36);
            this.RadioPay.Name = "RadioPay";
            this.RadioPay.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.RadioPay.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioPay.Properties.Appearance.Options.UseBackColor = true;
            this.RadioPay.Properties.Appearance.Options.UseFont = true;
            this.RadioPay.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RadioPay.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "دفع المبلغ كامل"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "تسديد دفعة")});
            this.RadioPay.Size = new System.Drawing.Size(232, 30);
            this.RadioPay.TabIndex = 30;
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
            this.groupControl3.Location = new System.Drawing.Point(468, 371);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(153, 75);
            this.groupControl3.TabIndex = 34;
            this.groupControl3.Text = "اجمالي المبالغ";
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dg1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg1.ColumnHeadersHeight = 50;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg1.Location = new System.Drawing.Point(9, 103);
            this.dg1.Name = "dg1";
            this.dg1.RowHeadersVisible = false;
            this.dg1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dg1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg1.RowTemplate.Height = 30;
            this.dg1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(612, 259);
            this.dg1.TabIndex = 35;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Order_ID";
            this.Column1.FillWeight = 187.945F;
            this.Column1.HeaderText = "رقم الفاتورة";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Sup_Name";
            this.Column7.FillWeight = 86.29433F;
            this.Column7.HeaderText = "المورد";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "Mount";
            this.Column2.FillWeight = 127.7793F;
            this.Column2.HeaderText = "المبلغ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "Date";
            this.Column3.FillWeight = 48.55451F;
            this.Column3.HeaderText = "التاريخ";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "Dreminder";
            this.Column4.FillWeight = 78.35778F;
            this.Column4.HeaderText = "تاريخ الدفع";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Frm_SupplierMoney
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(628, 454);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Frm_SupplierMoney";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "حسابات الموردين";
            this.Load += new System.EventHandler(this.Frm_SupplierMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudMount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioPay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.RadioGroup RadioSupplier;
        public DevExpress.XtraEditors.ComboBoxEdit CbxSupplier;
        private DevExpress.XtraEditors.SimpleButton btnprint;
        private DevExpress.XtraEditors.SimpleButton btnfind;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnpay;
        private DevExpress.XtraEditors.RadioGroup RadioPay;
        private DevExpress.XtraEditors.SpinEdit NudMount;
        public DevExpress.XtraEditors.TextEdit txttotal;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        public System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}