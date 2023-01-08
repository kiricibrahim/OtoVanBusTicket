namespace OtoVan
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radialMenu1 = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.yetkilibtn = new DevExpress.XtraBars.BarButtonItem();
            this.istatistikbtn = new DevExpress.XtraBars.BarButtonItem();
            this.satisbtn = new DevExpress.XtraBars.BarButtonItem();
            this.sorgubtn = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.menu_btn4 = new DevExpress.XtraEditors.SimpleButton();
            this.barLargeButtonItem6 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // radialMenu1
            // 
            this.radialMenu1.ItemAutoSize = DevExpress.XtraBars.Ribbon.RadialMenuItemAutoSize.Spring;
            this.radialMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.yetkilibtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.istatistikbtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.satisbtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.sorgubtn)});
            this.radialMenu1.Manager = this.barManager1;
            this.radialMenu1.Name = "radialMenu1";
            // 
            // yetkilibtn
            // 
            this.yetkilibtn.Caption = "Yetkililer";
            this.yetkilibtn.Id = 2;
            this.yetkilibtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("yetkilibtn.ImageOptions.SvgImage")));
            this.yetkilibtn.Name = "yetkilibtn";
            this.yetkilibtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Clicked);
            // 
            // istatistikbtn
            // 
            this.istatistikbtn.Caption = "İstatistikler";
            this.istatistikbtn.Id = 3;
            this.istatistikbtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("istatistikbtn.ImageOptions.SvgImage")));
            this.istatistikbtn.Name = "istatistikbtn";
            this.istatistikbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Clicked);
            // 
            // satisbtn
            // 
            this.satisbtn.Caption = "Bilet Satış";
            this.satisbtn.Id = 0;
            this.satisbtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("satisbtn.ImageOptions.SvgImage")));
            this.satisbtn.Name = "satisbtn";
            this.satisbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Satis_Clicked);
            // 
            // sorgubtn
            // 
            this.sorgubtn.Caption = "Bilet Sorgulama";
            this.sorgubtn.Id = 1;
            this.sorgubtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sorgubtn.ImageOptions.SvgImage")));
            this.sorgubtn.Name = "sorgubtn";
            this.sorgubtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Sorgu_Clicked);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.satisbtn,
            this.sorgubtn,
            this.yetkilibtn,
            this.istatistikbtn});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(583, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 350);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(583, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 350);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(583, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 350);
            // 
            // menu_btn4
            // 
            this.menu_btn4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.menu_btn4.Appearance.ForeColor = System.Drawing.Color.White;
            this.menu_btn4.Appearance.Options.UseFont = true;
            this.menu_btn4.Appearance.Options.UseForeColor = true;
            this.menu_btn4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("menu_btn4.ImageOptions.SvgImage")));
            this.menu_btn4.Location = new System.Drawing.Point(410, 302);
            this.menu_btn4.Name = "menu_btn4";
            this.menu_btn4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.menu_btn4.Size = new System.Drawing.Size(147, 51);
            this.menu_btn4.TabIndex = 4;
            this.menu_btn4.Text = "Menü";
            this.menu_btn4.Click += new System.EventHandler(this.menu_btn4_Click);
            // 
            // barLargeButtonItem6
            // 
            this.barLargeButtonItem6.Caption = "Kapat";
            this.barLargeButtonItem6.Id = 7;
            this.barLargeButtonItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barLargeButtonItem6.ImageOptions.SvgImage")));
            this.barLargeButtonItem6.Name = "barLargeButtonItem6";
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "Kapat";
            this.barLargeButtonItem1.Id = 7;
            this.barLargeButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barLargeButtonItem1.ImageOptions.SvgImage")));
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Acid House", 11F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(0, 322);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(276, 16);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Yolun Goturdugu Yere....";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(496, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(583, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.menu_btn4);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OtoVan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RadialMenu radialMenu1;
        private DevExpress.XtraBars.BarButtonItem satisbtn;
        private DevExpress.XtraBars.BarButtonItem sorgubtn;
        private DevExpress.XtraBars.BarButtonItem yetkilibtn;
        private DevExpress.XtraBars.BarButtonItem istatistikbtn;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton menu_btn4;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem6;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button button1;
    }
}

