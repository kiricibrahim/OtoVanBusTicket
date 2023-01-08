using OtoVan.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using OtoVan.Models.Enums;
using Dapper;

namespace OtoVan.Forms
{
    public partial class Seat_frm : DevExpress.XtraEditors.XtraForm
    {
        public Seat_tbl secilenKoltuk;
        private Seat_tbl db;
        private KoltukDurum koltukdurum;


        public Seat_frm()
        {

            InitializeComponent();

            //db=Program.DB
        }

        private void Seat_frm_Load(object sender, EventArgs e)
        {
            Olustur();
        }
        private void Seat_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
           // bttnn = btn;

            MessageBox.Show(btn.Text, "Seçilen Koltuk ?");
            //Form f = Application.OpenForms["koltuksecim"];
            this.Close();
        }

            public void Olustur()
        {
            //this.cursor = Cursor.WaitCursor;
            try
            {
                
                //List<Seat_tbl> lst=



                //otomatik buton oluşturma
                List<Seat_tbl> lst = new List<Seat_tbl>();
                string sql = $@"select * from Seat_tbl 
                         LEFT JOIN Ticket_tbl ON Seat_tbl.KID=Ticket_tbl.SeatID";

               // var connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=OtoVan;Integrated Security=True";
                using (var Connenction = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=OtoVan;Integrated Security=True"))
                {
                    lst = Connenction.Query<Seat_tbl>(sql).ToList();
                        

                }
                FlowLayoutPanel pnl = this.flowLayoutPanel1;
                pnl.Controls.Clear();
                int _adet = lst.Count;
                int _weight = 38;
                int _eight = 38;

                foreach (Seat_tbl item in lst)
                {
                    Button btn=new Button();
                    btn.Name = ("btn_" + item.KID);
                    btn.Text = (item.KSeatNumber+"");
                    btn.Size = new Size(_weight,_eight);
                    btn.Margin = new Padding(5);
                    btn.Click += new System.EventHandler(this.Seat_Click);
                    pnl.Controls.Add(btn);
                    btn.BackColor = Color.DarkOliveGreen;
                    btn.ForeColor = Color.BlanchedAlmond;
                    

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
            this.Cursor = Cursors.Default;
        }


    }


}