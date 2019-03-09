namespace QuanLyNhaSach
{
    partial class FormSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplier));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.txtbKeyword = new DevExpress.XtraEditors.TextEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtbEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtbAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtbPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtbDisplayName = new DevExpress.XtraEditors.TextEdit();
            this.txtbSupplierId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gtrlSupplier = new DevExpress.XtraGrid.GridControl();
            this.gvSupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbKeyword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbDisplayName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbSupplierId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gtrlSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSearch);
            this.panelControl2.Controls.Add(this.btnEdit);
            this.panelControl2.Controls.Add(this.txtbKeyword);
            this.panelControl2.Controls.Add(this.btnDelete);
            this.panelControl2.Controls.Add(this.btnAdd);
            this.panelControl2.Location = new System.Drawing.Point(12, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(646, 48);
            this.panelControl2.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.Location = new System.Drawing.Point(247, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 38);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(556, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 38);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtbKeyword
            // 
            this.txtbKeyword.Location = new System.Drawing.Point(5, 13);
            this.txtbKeyword.Name = "txtbKeyword";
            this.txtbKeyword.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbKeyword.Properties.Appearance.Options.UseFont = true;
            this.txtbKeyword.Size = new System.Drawing.Size(236, 22);
            this.txtbKeyword.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(464, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(372, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtbEmail);
            this.panelControl1.Controls.Add(this.txtbAddress);
            this.panelControl1.Controls.Add(this.txtbPhoneNumber);
            this.panelControl1.Controls.Add(this.txtbDisplayName);
            this.panelControl1.Controls.Add(this.txtbSupplierId);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 66);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(646, 117);
            this.panelControl1.TabIndex = 4;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(428, 46);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(154, 20);
            this.txtbEmail.TabIndex = 6;
            // 
            // txtbAddress
            // 
            this.txtbAddress.Location = new System.Drawing.Point(428, 11);
            this.txtbAddress.Name = "txtbAddress";
            this.txtbAddress.Size = new System.Drawing.Size(154, 20);
            this.txtbAddress.TabIndex = 5;
            // 
            // txtbPhoneNumber
            // 
            this.txtbPhoneNumber.Location = new System.Drawing.Point(115, 84);
            this.txtbPhoneNumber.Name = "txtbPhoneNumber";
            this.txtbPhoneNumber.Size = new System.Drawing.Size(154, 20);
            this.txtbPhoneNumber.TabIndex = 4;
            // 
            // txtbDisplayName
            // 
            this.txtbDisplayName.Location = new System.Drawing.Point(115, 46);
            this.txtbDisplayName.Name = "txtbDisplayName";
            this.txtbDisplayName.Size = new System.Drawing.Size(154, 20);
            this.txtbDisplayName.TabIndex = 2;
            // 
            // txtbSupplierId
            // 
            this.txtbSupplierId.Location = new System.Drawing.Point(115, 11);
            this.txtbSupplierId.Name = "txtbSupplierId";
            this.txtbSupplierId.Properties.Appearance.Options.UseTextOptions = true;
            this.txtbSupplierId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtbSupplierId.Properties.ReadOnly = true;
            this.txtbSupplierId.Size = new System.Drawing.Size(154, 20);
            this.txtbSupplierId.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(335, 50);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 16);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Email:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(335, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 16);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Địa chỉ:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 88);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 16);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Số điện thoại:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tên NCC:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã NCC:";
            // 
            // gtrlSupplier
            // 
            this.gtrlSupplier.Location = new System.Drawing.Point(12, 190);
            this.gtrlSupplier.MainView = this.gvSupplier;
            this.gtrlSupplier.Name = "gtrlSupplier";
            this.gtrlSupplier.Size = new System.Drawing.Size(646, 256);
            this.gtrlSupplier.TabIndex = 5;
            this.gtrlSupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSupplier});
            // 
            // gvSupplier
            // 
            this.gvSupplier.GridControl = this.gtrlSupplier;
            this.gvSupplier.Name = "gvSupplier";
            this.gvSupplier.OptionsBehavior.Editable = false;
            this.gvSupplier.OptionsView.ShowGroupPanel = false;
            // 
            // FormSupplier
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 458);
            this.Controls.Add(this.gtrlSupplier);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà cung cấp";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtbKeyword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbDisplayName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbSupplierId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gtrlSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.TextEdit txtbKeyword;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtbEmail;
        private DevExpress.XtraEditors.TextEdit txtbAddress;
        private DevExpress.XtraEditors.TextEdit txtbPhoneNumber;
        private DevExpress.XtraEditors.TextEdit txtbDisplayName;
        private DevExpress.XtraEditors.TextEdit txtbSupplierId;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gtrlSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSupplier;
    }
}