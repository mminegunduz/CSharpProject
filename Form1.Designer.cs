﻿namespace Ticari_Otomasyon
{
    partial class FrmAnaModul
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaModul));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnStoklar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnFirmalar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAnaSayfa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPersoneller = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGiderler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKasa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnNotlar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBankalar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRehber = new DevExpress.XtraBars.BarButtonItem();
            this.BtnFaturalar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnHareketler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRaporlar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BtnUrunler,
            this.BtnStoklar,
            this.BtnMusteriler,
            this.BtnFirmalar,
            this.BtnAnaSayfa,
            this.BtnPersoneller,
            this.BtnGiderler,
            this.BtnKasa,
            this.BtnNotlar,
            this.BtnBankalar,
            this.BtnRehber,
            this.BtnFaturalar,
            this.BtnAyarlar,
            this.BtnHareketler,
            this.BtnRaporlar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1924, 183);
            // 
            // BtnUrunler
            // 
            this.BtnUrunler.Caption = "ÜRÜNLER";
            this.BtnUrunler.Id = 1;
            this.BtnUrunler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnUrunler.ImageOptions.SvgImage")));
            this.BtnUrunler.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunler.ItemAppearance.Disabled.Options.UseFont = true;
            this.BtnUrunler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnUrunler.Name = "BtnUrunler";
            this.BtnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnUrunler_ItemClick);
            // 
            // BtnStoklar
            // 
            this.BtnStoklar.Caption = "STOKLAR";
            this.BtnStoklar.Id = 2;
            this.BtnStoklar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnStoklar.ImageOptions.SvgImage")));
            this.BtnStoklar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStoklar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnStoklar.Name = "BtnStoklar";
            this.BtnStoklar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnStoklar_ItemClick);
            // 
            // BtnMusteriler
            // 
            this.BtnMusteriler.Caption = "MÜŞTERİLER";
            this.BtnMusteriler.Id = 3;
            this.BtnMusteriler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnMusteriler.ImageOptions.SvgImage")));
            this.BtnMusteriler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnMusteriler.Name = "BtnMusteriler";
            this.BtnMusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMusteriler_ItemClick);
            // 
            // BtnFirmalar
            // 
            this.BtnFirmalar.Caption = "FİRMALAR";
            this.BtnFirmalar.Id = 4;
            this.BtnFirmalar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnFirmalar.ImageOptions.SvgImage")));
            this.BtnFirmalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFirmalar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnFirmalar.Name = "BtnFirmalar";
            this.BtnFirmalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnFirmalar_ItemClick);
            // 
            // BtnAnaSayfa
            // 
            this.BtnAnaSayfa.Caption = "ANA SAYFA";
            this.BtnAnaSayfa.Id = 5;
            this.BtnAnaSayfa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAnaSayfa.ImageOptions.SvgImage")));
            this.BtnAnaSayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAnaSayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnAnaSayfa.Name = "BtnAnaSayfa";
            this.BtnAnaSayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAnaSayfa_ItemClick);
            // 
            // BtnPersoneller
            // 
            this.BtnPersoneller.Caption = "PERSONELLER";
            this.BtnPersoneller.Id = 6;
            this.BtnPersoneller.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnPersoneller.ImageOptions.SvgImage")));
            this.BtnPersoneller.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPersoneller.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnPersoneller.Name = "BtnPersoneller";
            this.BtnPersoneller.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPersoneller_ItemClick);
            // 
            // BtnGiderler
            // 
            this.BtnGiderler.Caption = "GİDERLER";
            this.BtnGiderler.Id = 7;
            this.BtnGiderler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGiderler.ImageOptions.SvgImage")));
            this.BtnGiderler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiderler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnGiderler.Name = "BtnGiderler";
            this.BtnGiderler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGiderler_ItemClick);
            // 
            // BtnKasa
            // 
            this.BtnKasa.Caption = "KASA";
            this.BtnKasa.Id = 8;
            this.BtnKasa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnKasa.ImageOptions.SvgImage")));
            this.BtnKasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKasa.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnKasa.Name = "BtnKasa";
            this.BtnKasa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnKasa_ItemClick);
            // 
            // BtnNotlar
            // 
            this.BtnNotlar.Caption = "NOTLAR";
            this.BtnNotlar.Id = 9;
            this.BtnNotlar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnNotlar.ImageOptions.SvgImage")));
            this.BtnNotlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNotlar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnNotlar.Name = "BtnNotlar";
            this.BtnNotlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnNotlar_ItemClick);
            // 
            // BtnBankalar
            // 
            this.BtnBankalar.Caption = "BANKALAR";
            this.BtnBankalar.Id = 10;
            this.BtnBankalar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnBankalar.ImageOptions.SvgImage")));
            this.BtnBankalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBankalar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnBankalar.Name = "BtnBankalar";
            this.BtnBankalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnBankalar_ItemClick);
            // 
            // BtnRehber
            // 
            this.BtnRehber.Caption = "REHBER";
            this.BtnRehber.Id = 11;
            this.BtnRehber.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnRehber.ImageOptions.SvgImage")));
            this.BtnRehber.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRehber.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnRehber.Name = "BtnRehber";
            this.BtnRehber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnRehber_ItemClick);
            // 
            // BtnFaturalar
            // 
            this.BtnFaturalar.Caption = "FATURALAR";
            this.BtnFaturalar.Id = 12;
            this.BtnFaturalar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnFaturalar.ImageOptions.SvgImage")));
            this.BtnFaturalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFaturalar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnFaturalar.Name = "BtnFaturalar";
            this.BtnFaturalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnFaturalar_ItemClick);
            // 
            // BtnAyarlar
            // 
            this.BtnAyarlar.Caption = "AYARLAR";
            this.BtnAyarlar.Id = 13;
            this.BtnAyarlar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAyarlar.ImageOptions.SvgImage")));
            this.BtnAyarlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAyarlar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnAyarlar.Name = "BtnAyarlar";
            this.BtnAyarlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAyarlar_ItemClick);
            // 
            // BtnHareketler
            // 
            this.BtnHareketler.Caption = "HAREKETLER";
            this.BtnHareketler.Id = 14;
            this.BtnHareketler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnHareketler.ImageOptions.SvgImage")));
            this.BtnHareketler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHareketler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnHareketler.Name = "BtnHareketler";
            this.BtnHareketler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnHareketler_ItemClick);
            // 
            // BtnRaporlar
            // 
            this.BtnRaporlar.Caption = "RAPORLAR";
            this.BtnRaporlar.Id = 15;
            this.BtnRaporlar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnRaporlar.ImageOptions.SvgImage")));
            this.BtnRaporlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRaporlar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnRaporlar.Name = "BtnRaporlar";
            this.BtnRaporlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnRaporlar_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "TİCARİ OTOMASYON";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAnaSayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnUrunler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnStoklar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnMusteriler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnFirmalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnPersoneller);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnGiderler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnKasa);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnNotlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnBankalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnRehber);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnFaturalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnHareketler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnRaporlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAyarlar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmAnaModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmAnaModul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TİCARİ_OTOMASYON";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAnaModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnUrunler;
        private DevExpress.XtraBars.BarButtonItem BtnStoklar;
        private DevExpress.XtraBars.BarButtonItem BtnMusteriler;
        private DevExpress.XtraBars.BarButtonItem BtnFirmalar;
        private DevExpress.XtraBars.BarButtonItem BtnAnaSayfa;
        private DevExpress.XtraBars.BarButtonItem BtnPersoneller;
        private DevExpress.XtraBars.BarButtonItem BtnGiderler;
        private DevExpress.XtraBars.BarButtonItem BtnKasa;
        private DevExpress.XtraBars.BarButtonItem BtnNotlar;
        private DevExpress.XtraBars.BarButtonItem BtnBankalar;
        private DevExpress.XtraBars.BarButtonItem BtnRehber;
        private DevExpress.XtraBars.BarButtonItem BtnFaturalar;
        private DevExpress.XtraBars.BarButtonItem BtnAyarlar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem BtnHareketler;
        private DevExpress.XtraBars.BarButtonItem BtnRaporlar;
    }
}

