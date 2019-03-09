using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
#pragma warning disable CS0246 // The type or namespace name 'QLNS_BusinessAccessLayer' could not be found (are you missing a using directive or an assembly reference?)
using QLNS_BusinessAccessLayer;
#pragma warning restore CS0246 // The type or namespace name 'QLNS_BusinessAccessLayer' could not be found (are you missing a using directive or an assembly reference?)

namespace QuanLyNhaSach
{
    public partial class FormHelp : DevExpress.XtraEditors.XtraForm
    {
        public FormHelp()
        {
            InitializeComponent();
            LoadHelpMenu();
        }
        void LoadHelpMenu()
        {
            dtgvHelp.DataSource = MenuDAO.Instance.LoadHelpMenu();
            dtgvHelp.Columns["Phím tắt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}