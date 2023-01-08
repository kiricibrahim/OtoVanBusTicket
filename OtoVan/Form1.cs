using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoVan
{
    public partial class Form1 : Form
    {


        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //(

        //    //ekranı yuvarlak yapmak için kullanılan kodlar
        //    //int nLeftRect,     // x-coordinate of upper-left corner
        //    //int nTopRect,      // y-coordinate of upper-left corner
        //    //int nRightRect,    // x-coordinate of lower-right corner
        //    //int nBottomRect,   // y-coordinate of lower-right corner
        //    //int nWidthEllipse, // width of ellipse
        //    //int nHeightEllipse // height of ellipse
        //    //////////////////////////////////////
        //);

        public Form1()
        {
            

            InitializeComponent();
            
            //barManager = barManager1;
            //barManager.ItemClick += new ItemClickEventHandler(barmanager_ItemClick);
            //radialMenu=new RadialMenu(barManager);
            //radialMenu.AddItems(GetRadialMenuItems(barManager));
            ////radialMenu.Visible = true;






            ////yuvarlama kodları
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 200, 200));
            /////////////////////////
        }

        private void btnShowRadialMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //// Display Radial Menu
            //if (radialMenu == null) return;
            //Point pt = this.Location;
            //pt.Offset(this.Width / 2, this.Height / 2);
            //radialMenu.ShowPopup(pt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            RadialMenu radialMenu = new RadialMenu();
            // radialMenu = radialMenu1;
           // this.radialMenu1.Visible = true;

        }

        private void Clicked(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show(e.Item.Caption+"Clicked");
        }

        private void menu_btn4_Click(object sender, EventArgs e)
        {
            radialMenu1.ShowPopup(MousePosition);
        }

        private void barLargeButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Satis_Clicked(object sender, ItemClickEventArgs e)
        {
            OtoVan.Forms.Satis_frm satis=new Forms.Satis_frm();
            satis.Show();
            
        }

        private void Sorgu_Clicked(object sender, ItemClickEventArgs e)
        {
            OtoVan.Forms.BiletSorgu_frm sorgu=new Forms.BiletSorgu_frm();
            sorgu.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //BarItem[] GetRadialMenuItems(BarManager barmanager)
        //{
        //    BarItem btnCopy = new BarButtonItem(barmanager,"Copy");
        //    btnCopy.ImageOptions.ImageUri.Uri = "Copy;Size16x16";

        //    BarItem btnCut = new BarButtonItem(barManager, "Cut");
        //    btnCut.ImageOptions.ImageUri.Uri = "Cut;Size16x16";

        //    BarItem btnDelete = new BarButtonItem(barManager, "Delete");
        //    btnDelete.ImageOptions.ImageUri.Uri = "Delete;Size16x16";

        //    BarItem btnPaste = new BarButtonItem(barManager, "Paste");
        //    btnPaste.ImageOptions.ImageUri.Uri = "Paste;Size16x16";

        //    // Sub-menu with 3 check buttons
        //    BarSubItem btnMenuFormat = new BarSubItem(barManager, "Format");
        //    BarCheckItem btnCheckBold = new BarCheckItem(barManager, false);
        //    btnCheckBold.Caption = "Bold";
        //    btnCheckBold.ImageOptions.ImageUri.Uri = "Bold;Size16x16";

        //    BarCheckItem btnCheckItalic = new BarCheckItem(barManager, true);
        //    btnCheckItalic.Caption = "Italic";
        //    btnCheckItalic.ImageOptions.ImageUri.Uri = "Italic;Size16x16";

        //    BarCheckItem btnCheckUnderline = new BarCheckItem(barManager, false);
        //    btnCheckUnderline.Caption = "Underline";
        //    btnCheckUnderline.ImageOptions.ImageUri.Uri = "Underline;Size16x16";

        //    BarItem[] subMenuItems = new BarItem[] { btnCheckBold, btnCheckItalic, btnCheckUnderline };
        //    btnMenuFormat.AddItems(subMenuItems);

        //    BarItem btnFind = new BarButtonItem(barManager, "Find");
        //    btnFind.ImageOptions.ImageUri.Uri = "Find;Size16x16";

        //    BarItem btnUndo = new BarButtonItem(barManager, "Undo");
        //    btnUndo.ImageOptions.ImageUri.Uri = "Undo;Size16x16";

        //    BarItem btnRedo = new BarButtonItem(barManager, "Redo");
        //    btnRedo.ImageOptions.ImageUri.Uri = "Redo;Size16x16";

        //    return new BarItem[] { btnCopy, btnCut, btnDelete, btnPaste, btnMenuFormat, btnFind, btnUndo, btnRedo };

    }
        
        //void barmanager_ItemClick(object sender ,ItemClickEventArgs e)
        //{
        //    Text = "item Clicked: " + e.Item.Caption;        }
    
}
 