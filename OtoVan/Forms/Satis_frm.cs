using DevExpress.XtraEditors;
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
    public partial class Satis_frm : DevExpress.XtraEditors.XtraForm
    {
        public Satis_frm()
        {
            InitializeComponent();
            group_kisisel.BackColor = Color.Red;
        }
       // private Seat_frm db;
       OtoVanEntities1 db=new OtoVanEntities1();
        private void barLargeButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seat_frm goSeat=new Seat_frm();
            goSeat.ShowDialog (this);
            
        }

        private void barLargeButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Ticket_tbl bilet = new Ticket_tbl();
                bilet.YName = ad_txt.Text;
                bilet.YAge = yasCombo.SelectedIndex;
                bilet.Fee = ucretTxt.SelectedIndex;
                bilet.Date = tarihDate.Checked ? DateTime.Today : DateTime.MinValue;
                bilet.KalkisYeri = kalkisCombo.Text;
                bilet.VarisYeri = varisCombo.Text;
                bilet.IletisimNo = iletisim_txt.Text;
                if (rdBay.Checked)
                {
                    bilet.Gender = rdBay.Text;
                }
                else
                {
                    bilet.Gender = rdBayan.Text;
                }

                Seat_frm stfr = new Seat_frm();
                 //bilet.SeatID = stfr.Seat_Click() ;
                db.Ticket_tbl.Add(bilet);
                db.SaveChanges();
                MessageBox.Show("Kayıt Yapıldı");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);;
            }
            
            
        }
    }
}