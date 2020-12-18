namespace POS1
{
    partial class Frm_SupplierReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SupplierReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btndel = new DevExpress.XtraEditors.SimpleButton();
            this.btnfind = new DevExpress.XtraEditors.SimpleButton();
            this.CbxSupplier = new DevExpress.XtraEditors.ComboBoxEdit();
            this.RadioSupplier = new DevExpress.XtraEditors.RadioGroup();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txttotal = new DevExpress.XtraEditors.TextEdit();
            this.errorpov1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CbxSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorpov1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.btndel);
            this.groupControl1.Controls.Add(this.btnfind);
            this.groupControl1.Controls.Add(this.CbxSupplier);
            this.groupControl1.Controls.Add(this.RadioSupplier);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(523, 90);
            this.groupControl1.TabIndex = 20;
            this.groupControl1.Text = "تقارير الموردين";
            // 
            // btndel
            // 
            this.btndel.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.btndel.Appearance.Options.UseFont = true;
            this.btndel.Appearance.Options.UseTextOptions = true;
            this.btndel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btndel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndel.ImageOptions.Image")));
            this.btndel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btndel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btndel.ImageOptions.SvgImage")));
            this.btndel.Location = new System.Drawing.Point(8, 48);
            this.btndel.Name = "btndel";
            this.btndel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btndel.Size = new System.Drawing.Size(80, 31);
            this.btndel.TabIndex = 33;
            this.btndel.Text = "حذف";
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnfind
            // 
            this.btnfind.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.btnfind.Appearance.Options.UseFont = true;
            this.btnfind.Appearance.Options.UseTextOptions = true;
            this.btnfind.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnfind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnfind.ImageOptions.Image")));
            this.btnfind.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnfind.Location = new System.Drawing.Point(94, 48);
            this.btnfind.Name = "btnfind";
            this.btnfind.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnfind.Size = new System.Drawing.Size(92, 31);
            this.btnfind.TabIndex = 32;
            this.btnfind.Text = "بحث";
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // CbxSupplier
            // 
            this.CbxSupplier.Location = new System.Drawing.Point(192, 47);
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
            this.CbxSupplier.SelectedIndexChanged += new System.EventHandler(this.CbxSupplier_SelectedIndexChanged);
            // 
            // RadioSupplier
            // 
            this.RadioSupplier.Location = new System.Drawing.Point(332, 45);
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
            this.RadioSupplier.SelectedIndexChanged += new System.EventHandler(this.RadioSupplier_SelectedIndexChanged);
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
            this.dg1.Location = new System.Drawing.Point(3, 102);
            this.dg1.Name = "dg1";
            this.dg1.RowHeadersVisible = false;
            this.dg1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dg1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg1.RowTemplate.Height = 30;
            this.dg1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(523, 259);
            this.dg1.TabIndex = 36;
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
            // Column2
            // 
            this.Column2.DataPropertyName = "Sup_Name";
            this.Column2.FillWeight = 86.29433F;
            this.Column2.HeaderText = "المورد";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "Paid";
            this.Column3.FillWeight = 127.7793F;
            this.Column3.HeaderText = "المبلغ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "Date";
            this.Column4.FillWeight = 48.55451F;
            this.Column4.HeaderText = "التاريخ";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
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
            this.groupControl3.Location = new System.Drawing.Point(373, 370);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(153, 75);
            this.groupControl3.TabIndex = 37;
            this.groupControl3.Text = "اجمالي المبالغ";
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
            // errorpov1
            // 
            this.errorpov1.ContainerControl = this;
            // 
            // Frm_SupplierReport
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(530, 452);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Frm_SupplierReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تقارير الموردين";
            this.Load += new System.EventHandler(this.Frm_SupplierReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CbxSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txttotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorpov1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnfind;
        public DevExpress.XtraEditors.ComboBoxEdit CbxSupplier;
        private DevExpress.XtraEditors.RadioGroup RadioSupplier;
        public System.Windows.Forms.DataGridView dg1;
        private DevExpress.XtraEditors.SimpleButton btndel;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        public DevExpress.XtraEditors.TextEdit txttotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorpov1;
    }
}