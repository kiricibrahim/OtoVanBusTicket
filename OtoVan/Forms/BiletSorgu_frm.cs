using DevExpress.XtraBars;
using OtoVan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoVan.Forms
{
    public partial class BiletSorgu_frm : DevExpress.XtraEditors.XtraForm
    {
        public BiletSorgu_frm()
        {
            InitializeComponent();
        }
        OtoVanEntities1 db = new OtoVanEntities1();

        private void barLargeButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void BiletSorgu_frm_Load(object sender, EventArgs e)
        {
            var query = from item in db.Ticket_tbl
                        select new { item.YName, item.KalkisYeri, item.VarisYeri, item.Date, item.Gender, item.Fee,  item.SeatID };
            gridControl1.DataSource = query.ToList();


           // gridControl1.DataSource=db.Ticket_tbl.ToList();
        }
    }
}