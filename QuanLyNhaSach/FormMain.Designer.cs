namespace QuanLyNhaSach
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccountInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccountSetting = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnBookCategory = new DevExpress.XtraBars.BarButtonItem();
            this.btnBooks = new DevExpress.XtraBars.BarButtonItem();
            this.btnSupplier = new DevExpress.XtraBars.BarButtonItem();
            this.btnRevenueReport = new DevExpress.XtraBars.BarButtonItem();
            this.btnInventoryReport = new DevExpress.XtraBars.BarButtonItem();
            this.btnServer = new DevExpress.XtraBars.BarButtonItem();
            this.btnInput = new DevExpress.XtraBars.BarButtonItem();
            this.btnHelp = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.rbpSystemManagement = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpgAccount = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgAdminManagement = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgReportStat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgSkin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pnlUserInput = new DevExpress.XtraEditors.PanelControl();
            this.txtbTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.nmAmount = new System.Windows.Forms.NumericUpDown();
            this.txbBookCode = new DevExpress.XtraEditors.TextEdit();
            this.txtbCustomerId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbBillNum = new DevExpress.XtraEditors.LabelControl();
            this.txtbBillNum = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pnlTotalPriceAndCheckout = new DevExpress.XtraEditors.PanelControl();
            this.btnCheckOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddBook = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewBill = new DevExpress.XtraEditors.SimpleButton();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUserInput)).BeginInit();
            this.pnlUserInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbBookCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbCustomerId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbBillNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTotalPriceAndCheckout)).BeginInit();
            this.pnlTotalPriceAndCheckout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnLogout,
            this.btnAccountInfo,
            this.btnAccountSetting,
            this.btnCustomer,
            this.btnBookCategory,
            this.btnBooks,
            this.btnSupplier,
            this.btnRevenueReport,
            this.btnInventoryReport,
            this.btnServer,
            this.btnInput,
            this.btnHelp,
            this.skinRibbonGalleryBarItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 16;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpSystemManagement});
            this.ribbon.Size = new System.Drawing.Size(928, 141);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Id = 1;
            this.btnLogout.ImageOptions.LargeImage = global::QuanLyNhaSach.Properties.Resources.logout_icon;
            this.btnLogout.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnAccountInfo
            // 
            this.btnAccountInfo.Caption = "Thông tin tài khoản";
            this.btnAccountInfo.Id = 3;
            this.btnAccountInfo.ImageOptions.LargeImage = global::QuanLyNhaSach.Properties.Resources.user;
            this.btnAccountInfo.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W));
            this.btnAccountInfo.Name = "btnAccountInfo";
            this.btnAccountInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAccountInfo_ItemClick);
            // 
            // btnAccountSetting
            // 
            this.btnAccountSetting.Caption = "Thiết lập tài khoản";
            this.btnAccountSetting.Id = 4;
            this.btnAccountSetting.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountSetting.ImageOptions.Image")));
            this.btnAccountSetting.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAccountSetting.ImageOptions.LargeImage")));
            this.btnAccountSetting.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.btnAccountSetting.Name = "btnAccountSetting";
            this.btnAccountSetting.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAccountSetting_ItemClick);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Caption = "Khách hàng";
            this.btnCustomer.Id = 5;
            this.btnCustomer.ImageOptions.LargeImage = global::QuanLyNhaSach.Properties.Resources.Customer;
            this.btnCustomer.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomer_ItemClick);
            // 
            // btnBookCategory
            // 
            this.btnBookCategory.Caption = "Loại sách";
            this.btnBookCategory.Id = 6;
            this.btnBookCategory.ImageOptions.LargeImage = global::QuanLyNhaSach.Properties.Resources.mail_shelf_icon;
            this.btnBookCategory.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            this.btnBookCategory.Name = "btnBookCategory";
            this.btnBookCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBookCategory_ItemClick);
            // 
            // btnBooks
            // 
            this.btnBooks.Caption = "Sách";
            this.btnBooks.Id = 7;
            this.btnBooks.ImageOptions.LargeImage = global::QuanLyNhaSach.Properties.Resources.Books_icon;
            this.btnBooks.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBooks_ItemClick);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Caption = "Nhà cung cấp";
            this.btnSupplier.Id = 8;
            this.btnSupplier.ImageOptions.LargeImage = global::QuanLyNhaSach.Properties.Resources.truck_icon;
            this.btnSupplier.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSupplier_ItemClick);
            // 
            // btnRevenueReport
            // 
            this.btnRevenueReport.Caption = "Doanh thu";
            this.btnRevenueReport.Id = 10;
            this.btnRevenueReport.ImageOptions.LargeImage = global::QuanLyNhaSach.Properties.Resources.statistics_market_icon;
            this.btnRevenueReport.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.btnRevenueReport.Name = "btnRevenueReport";
            // 
            // btnInventoryReport
            // 
            this.btnInventoryReport.Caption = "Tồn kho";
            this.btnInventoryReport.Id = 11;
            this.btnInventoryReport.ImageOptions.LargeImage = global::QuanLyNhaSach.Properties.Resources.inventory_maintenance_icon;
            this.btnInventoryReport.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.btnInventoryReport.Name = "btnInventoryReport";
            // 
            // btnServer
            // 
            this.btnServer.Caption = "Cấu hình Database";
            this.btnServer.Id = 12;
            this.btnServer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnServer.ImageOptions.Image")));
            this.btnServer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnServer.ImageOptions.LargeImage")));
            this.btnServer.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4);
            this.btnServer.Name = "btnServer";
            // 
            // btnInput
            // 
            this.btnInput.Caption = "Nhập kho";
            this.btnInput.Id = 13;
            this.btnInput.ImageOptions.LargeImage = global::QuanLyNhaSach.Properties.Resources.arrow_download_icon;
            this.btnInput.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.btnInput.Name = "btnInput";
            this.btnInput.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInput_ItemClick);
            // 
            // btnHelp
            // 
            this.btnHelp.Caption = "Giúp đỡ";
            this.btnHelp.Id = 14;
            this.btnHelp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.ImageOptions.Image")));
            this.btnHelp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.ImageOptions.LargeImage")));
            this.btnHelp.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHelp_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 15;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // rbpSystemManagement
            // 
            this.rbpSystemManagement.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpgAccount,
            this.rbpgAdminManagement,
            this.rbpgReportStat,
            this.rbpgSystem,
            this.rbpgSkin});
            this.rbpSystemManagement.Name = "rbpSystemManagement";
            this.rbpSystemManagement.Text = "Quản trị";
            // 
            // rbpgAccount
            // 
            this.rbpgAccount.ItemLinks.Add(this.btnLogout);
            this.rbpgAccount.ItemLinks.Add(this.btnAccountInfo);
            this.rbpgAccount.ItemLinks.Add(this.btnAccountSetting);
            this.rbpgAccount.Name = "rbpgAccount";
            this.rbpgAccount.Text = "TÀI KHOẢN";
            // 
            // rbpgAdminManagement
            // 
            this.rbpgAdminManagement.ItemLinks.Add(this.btnCustomer);
            this.rbpgAdminManagement.ItemLinks.Add(this.btnBookCategory);
            this.rbpgAdminManagement.ItemLinks.Add(this.btnBooks);
            this.rbpgAdminManagement.ItemLinks.Add(this.btnSupplier);
            this.rbpgAdminManagement.ItemLinks.Add(this.btnInput);
            this.rbpgAdminManagement.Name = "rbpgAdminManagement";
            this.rbpgAdminManagement.Text = "DANH MỤC";
            // 
            // rbpgReportStat
            // 
            this.rbpgReportStat.ItemLinks.Add(this.btnRevenueReport);
            this.rbpgReportStat.ItemLinks.Add(this.btnInventoryReport);
            this.rbpgReportStat.Name = "rbpgReportStat";
            this.rbpgReportStat.Text = "BÁO CÁO";
            // 
            // rbpgSystem
            // 
            this.rbpgSystem.ItemLinks.Add(this.btnServer);
            this.rbpgSystem.ItemLinks.Add(this.btnHelp);
            this.rbpgSystem.Name = "rbpgSystem";
            this.rbpgSystem.Text = "HỆ THỐNG";
            // 
            // rbpgSkin
            // 
            this.rbpgSkin.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.rbpgSkin.Name = "rbpgSkin";
            this.rbpgSkin.Text = "GIAO DIỆN";
            // 
            // pnlUserInput
            // 
            this.pnlUserInput.AutoSize = true;
            this.pnlUserInput.Controls.Add(this.txtbTotalPrice);
            this.pnlUserInput.Controls.Add(this.labelControl5);
            this.pnlUserInput.Controls.Add(this.nmDiscount);
            this.pnlUserInput.Controls.Add(this.labelControl4);
            this.pnlUserInput.Controls.Add(this.nmAmount);
            this.pnlUserInput.Controls.Add(this.txbBookCode);
            this.pnlUserInput.Controls.Add(this.txtbCustomerId);
            this.pnlUserInput.Controls.Add(this.labelControl3);
            this.pnlUserInput.Controls.Add(this.labelControl2);
            this.pnlUserInput.Controls.Add(this.labelControl1);
            this.pnlUserInput.Controls.Add(this.lbBillNum);
            this.pnlUserInput.Controls.Add(this.txtbBillNum);
            this.pnlUserInput.Location = new System.Drawing.Point(0, 149);
            this.pnlUserInput.Name = "pnlUserInput";
            this.pnlUserInput.Size = new System.Drawing.Size(474, 121);
            this.pnlUserInput.TabIndex = 3;
            // 
            // txtbTotalPrice
            // 
            this.txtbTotalPrice.Location = new System.Drawing.Point(242, 89);
            this.txtbTotalPrice.Name = "txtbTotalPrice";
            this.txtbTotalPrice.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTotalPrice.Properties.Appearance.Options.UseFont = true;
            this.txtbTotalPrice.Properties.Appearance.Options.UseTextOptions = true;
            this.txtbTotalPrice.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtbTotalPrice.Properties.ReadOnly = true;
            this.txtbTotalPrice.Size = new System.Drawing.Size(107, 22);
            this.txtbTotalPrice.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(242, 64);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 16);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Tổng tiền:";
            // 
            // nmDiscount
            // 
            this.nmDiscount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmDiscount.Location = new System.Drawing.Point(242, 30);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(107, 22);
            this.nmDiscount.TabIndex = 8;
            this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(242, 8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Giảm giá:";
            // 
            // nmAmount
            // 
            this.nmAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmAmount.Location = new System.Drawing.Point(121, 90);
            this.nmAmount.Name = "nmAmount";
            this.nmAmount.Size = new System.Drawing.Size(107, 22);
            this.nmAmount.TabIndex = 4;
            this.nmAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbBookCode
            // 
            this.txbBookCode.Location = new System.Drawing.Point(121, 61);
            this.txbBookCode.Name = "txbBookCode";
            this.txbBookCode.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBookCode.Properties.Appearance.Options.UseFont = true;
            this.txbBookCode.Properties.Appearance.Options.UseTextOptions = true;
            this.txbBookCode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txbBookCode.Size = new System.Drawing.Size(107, 22);
            this.txbBookCode.TabIndex = 3;
            // 
            // txtbCustomerId
            // 
            this.txtbCustomerId.Location = new System.Drawing.Point(121, 33);
            this.txtbCustomerId.Name = "txtbCustomerId";
            this.txtbCustomerId.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCustomerId.Properties.Appearance.Options.UseFont = true;
            this.txtbCustomerId.Properties.Appearance.Options.UseTextOptions = true;
            this.txtbCustomerId.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtbCustomerId.Size = new System.Drawing.Size(107, 22);
            this.txtbCustomerId.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 16);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Số lượng:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã sách:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã khách hàng:";
            // 
            // lbBillNum
            // 
            this.lbBillNum.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBillNum.Appearance.Options.UseFont = true;
            this.lbBillNum.Location = new System.Drawing.Point(5, 8);
            this.lbBillNum.Name = "lbBillNum";
            this.lbBillNum.Size = new System.Drawing.Size(58, 16);
            this.lbBillNum.TabIndex = 0;
            this.lbBillNum.Text = "Hóa đơn:";
            // 
            // txtbBillNum
            // 
            this.txtbBillNum.Location = new System.Drawing.Point(121, 5);
            this.txtbBillNum.Name = "txtbBillNum";
            this.txtbBillNum.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbBillNum.Properties.Appearance.Options.UseFont = true;
            this.txtbBillNum.Properties.Appearance.Options.UseTextOptions = true;
            this.txtbBillNum.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtbBillNum.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtbBillNum.Properties.ReadOnly = true;
            this.txtbBillNum.Size = new System.Drawing.Size(107, 22);
            this.txtbBillNum.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = global::QuanLyNhaSach.Properties.Resources.img1;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 312);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(474, 257);
            this.pictureEdit1.TabIndex = 8;
            // 
            // pnlTotalPriceAndCheckout
            // 
            this.pnlTotalPriceAndCheckout.AutoSize = true;
            this.pnlTotalPriceAndCheckout.Controls.Add(this.btnCheckOut);
            this.pnlTotalPriceAndCheckout.Controls.Add(this.btnAddBook);
            this.pnlTotalPriceAndCheckout.Controls.Add(this.btnNewBill);
            this.pnlTotalPriceAndCheckout.Location = new System.Drawing.Point(0, 272);
            this.pnlTotalPriceAndCheckout.Name = "pnlTotalPriceAndCheckout";
            this.pnlTotalPriceAndCheckout.Size = new System.Drawing.Size(474, 38);
            this.pnlTotalPriceAndCheckout.TabIndex = 7;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(242, 6);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 7;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(161, 6);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Thêm";
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnNewBill
            // 
            this.btnNewBill.Location = new System.Drawing.Point(80, 6);
            this.btnNewBill.Name = "btnNewBill";
            this.btnNewBill.Size = new System.Drawing.Size(75, 23);
            this.btnNewBill.TabIndex = 6;
            this.btnNewBill.Text = "Hóa đơn mới";
            this.btnNewBill.Click += new System.EventHandler(this.btnNewBill_Click);
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Location = new System.Drawing.Point(480, 149);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(448, 420);
            this.lsvBill.TabIndex = 6;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên sách";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 571);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.pnlTotalPriceAndCheckout);
            this.Controls.Add(this.lsvBill);
            this.Controls.Add(this.pnlUserInput);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý Nhà sách";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUserInput)).EndInit();
            this.pnlUserInput.ResumeLayout(false);
            this.pnlUserInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbBookCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbCustomerId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbBillNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTotalPriceAndCheckout)).EndInit();
            this.pnlTotalPriceAndCheckout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpSystemManagement;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgAccount;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnAccountInfo;
        private DevExpress.XtraBars.BarButtonItem btnAccountSetting;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgAdminManagement;
        private DevExpress.XtraBars.BarButtonItem btnCustomer;
        private DevExpress.XtraBars.BarButtonItem btnBookCategory;
        private DevExpress.XtraBars.BarButtonItem btnBooks;
        private DevExpress.XtraBars.BarButtonItem btnSupplier;
        private DevExpress.XtraBars.BarButtonItem btnRevenueReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgReportStat;
        private DevExpress.XtraBars.BarButtonItem btnInventoryReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgSystem;
        private DevExpress.XtraBars.BarButtonItem btnServer;
        private DevExpress.XtraEditors.PanelControl pnlUserInput;
        private DevExpress.XtraEditors.TextEdit txtbTotalPrice;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.NumericUpDown nmAmount;
        private DevExpress.XtraEditors.TextEdit txbBookCode;
        private DevExpress.XtraEditors.TextEdit txtbCustomerId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbBillNum;
        private DevExpress.XtraEditors.TextEdit txtbBillNum;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PanelControl pnlTotalPriceAndCheckout;
        private DevExpress.XtraEditors.SimpleButton btnCheckOut;
        private DevExpress.XtraEditors.SimpleButton btnAddBook;
        private DevExpress.XtraEditors.SimpleButton btnNewBill;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DevExpress.XtraBars.BarButtonItem btnInput;
        private DevExpress.XtraBars.BarButtonItem btnHelp;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgSkin;
    }
}