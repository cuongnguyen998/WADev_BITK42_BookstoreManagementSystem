namespace QuanLyNhaSach
{
    partial class FormBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBook));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.txtbKeyword = new DevExpress.XtraEditors.TextEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lkpCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lkpSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.txtbStatus = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtbAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtbUnitPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtbDisplayName = new DevExpress.XtraEditors.TextEdit();
            this.txtBookCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gcBoook = new DevExpress.XtraGrid.GridControl();
            this.gvBook = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbKeyword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbDisplayName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBoook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSearch);
            this.panelControl2.Controls.Add(this.btnEdit);
            this.panelControl2.Controls.Add(this.txtbKeyword);
            this.panelControl2.Controls.Add(this.btnDelete);
            this.panelControl2.Controls.Add(this.btnAdd);
            this.panelControl2.Location = new System.Drawing.Point(7, 9);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(646, 48);
            this.panelControl2.TabIndex = 1;
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
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.lkpCategory);
            this.panelControl1.Controls.Add(this.lkpSupplier);
            this.panelControl1.Controls.Add(this.txtbStatus);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtbAmount);
            this.panelControl1.Controls.Add(this.txtbUnitPrice);
            this.panelControl1.Controls.Add(this.txtbDisplayName);
            this.panelControl1.Controls.Add(this.txtBookCode);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(7, 63);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(646, 155);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(325, 110);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(149, 16);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "(0: Hết hàng 1: Còn hàng)";
            // 
            // lkpCategory
            // 
            this.lkpCategory.Location = new System.Drawing.Point(115, 87);
            this.lkpCategory.Name = "lkpCategory";
            this.lkpCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpCategory.Size = new System.Drawing.Size(154, 20);
            this.lkpCategory.TabIndex = 3;
            // 
            // lkpSupplier
            // 
            this.lkpSupplier.Location = new System.Drawing.Point(115, 120);
            this.lkpSupplier.Name = "lkpSupplier";
            this.lkpSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpSupplier.Size = new System.Drawing.Size(154, 20);
            this.lkpSupplier.TabIndex = 4;
            // 
            // txtbStatus
            // 
            this.txtbStatus.Location = new System.Drawing.Point(428, 84);
            this.txtbStatus.Name = "txtbStatus";
            this.txtbStatus.Size = new System.Drawing.Size(154, 20);
            this.txtbStatus.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(335, 88);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 16);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Trạng thái:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 124);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 16);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Nhà cung cấp:";
            // 
            // txtbAmount
            // 
            this.txtbAmount.Location = new System.Drawing.Point(428, 46);
            this.txtbAmount.Name = "txtbAmount";
            this.txtbAmount.Size = new System.Drawing.Size(154, 20);
            this.txtbAmount.TabIndex = 6;
            // 
            // txtbUnitPrice
            // 
            this.txtbUnitPrice.Location = new System.Drawing.Point(428, 11);
            this.txtbUnitPrice.Name = "txtbUnitPrice";
            this.txtbUnitPrice.Size = new System.Drawing.Size(154, 20);
            this.txtbUnitPrice.TabIndex = 5;
            // 
            // txtbDisplayName
            // 
            this.txtbDisplayName.Location = new System.Drawing.Point(115, 46);
            this.txtbDisplayName.Name = "txtbDisplayName";
            this.txtbDisplayName.Size = new System.Drawing.Size(154, 20);
            this.txtbDisplayName.TabIndex = 2;
            // 
            // txtBookCode
            // 
            this.txtBookCode.Location = new System.Drawing.Point(115, 11);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.Size = new System.Drawing.Size(154, 20);
            this.txtBookCode.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(335, 50);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 16);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Số lượng:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(335, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 16);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Đơn giá:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 88);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 16);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Danh mục:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tên sách:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã sách:";
            // 
            // gcBoook
            // 
            this.gcBoook.Location = new System.Drawing.Point(7, 225);
            this.gcBoook.MainView = this.gvBook;
            this.gcBoook.Name = "gcBoook";
            this.gcBoook.Size = new System.Drawing.Size(646, 216);
            this.gcBoook.TabIndex = 2;
            this.gcBoook.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBook});
            // 
            // gvBook
            // 
            this.gvBook.GridControl = this.gcBoook;
            this.gvBook.Name = "gvBook";
            this.gvBook.OptionsBehavior.ReadOnly = true;
            this.gvBook.OptionsView.ShowGroupPanel = false;
            // 
            // FormBook
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 453);
            this.Controls.Add(this.gcBoook);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtbKeyword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbDisplayName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBoook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBook)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtbAmount;
        private DevExpress.XtraEditors.TextEdit txtbUnitPrice;
        private DevExpress.XtraEditors.TextEdit txtbDisplayName;
        private DevExpress.XtraEditors.TextEdit txtBookCode;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtbStatus;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.IO.Ports.SerialPort serialPort1;
        private DevExpress.XtraEditors.LookUpEdit lkpSupplier;
        private DevExpress.XtraEditors.LookUpEdit lkpCategory;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.GridControl gcBoook;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBook;
    }
}