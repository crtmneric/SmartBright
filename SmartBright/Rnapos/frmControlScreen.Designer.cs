namespace Rnapos
{
    partial class frmControlScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlScreen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSettingOkay = new System.Windows.Forms.Button();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.lblVerim = new System.Windows.Forms.Label();
            this.prgBarVerim = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnClose = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tmrPortRead = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.webBrowser4 = new System.Windows.Forms.WebBrowser();
            this.webBrowser5 = new System.Windows.Forms.WebBrowser();
            this.webBrowser6 = new System.Windows.Forms.WebBrowser();
            this.webBrowser7 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.tmrSerialWrite = new System.Windows.Forms.Timer(this.components);
            this.lblMod = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prgBarVerim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblMod);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblVerim);
            this.groupBox1.Controls.Add(this.prgBarVerim);
            this.groupBox1.Controls.Add(this.pctLogo);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1247, 611);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMinTemp);
            this.groupBox2.Controls.Add(this.txtTemp);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.webBrowser5);
            this.groupBox2.Controls.Add(this.webBrowser6);
            this.groupBox2.Controls.Add(this.webBrowser7);
            this.groupBox2.Controls.Add(this.webBrowser3);
            this.groupBox2.Controls.Add(this.webBrowser4);
            this.groupBox2.Controls.Add(this.webBrowser2);
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Controls.Add(this.btnSettingOkay);
            this.groupBox2.Controls.Add(this.cmbPort);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1226, 277);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Smart Bright Ayarları";
            // 
            // btnSettingOkay
            // 
            this.btnSettingOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingOkay.Location = new System.Drawing.Point(7, 220);
            this.btnSettingOkay.Name = "btnSettingOkay";
            this.btnSettingOkay.Size = new System.Drawing.Size(1213, 51);
            this.btnSettingOkay.TabIndex = 12;
            this.btnSettingOkay.Text = "Tamamla ve Mobille Senkronize Et";
            this.btnSettingOkay.UseVisualStyleBackColor = true;
            this.btnSettingOkay.Click += new System.EventHandler(this.btnSettingOkay_Click);
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(7, 30);
            this.cmbPort.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(1213, 33);
            this.cmbPort.TabIndex = 11;
            this.cmbPort.Text = "PORT SEÇİNİZ";
            this.cmbPort.SelectedIndexChanged += new System.EventHandler(this.cmbPort_SelectedIndexChanged);
            this.cmbPort.Click += new System.EventHandler(this.cmbPort_Click);
            // 
            // lblVerim
            // 
            this.lblVerim.AutoSize = true;
            this.lblVerim.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVerim.ForeColor = System.Drawing.Color.White;
            this.lblVerim.Location = new System.Drawing.Point(197, 191);
            this.lblVerim.Name = "lblVerim";
            this.lblVerim.Size = new System.Drawing.Size(542, 59);
            this.lblVerim.TabIndex = 9;
            this.lblVerim.Text = "Solar Panel Verimliliği Şuan:";
            // 
            // prgBarVerim
            // 
            this.prgBarVerim.Location = new System.Drawing.Point(6, 253);
            this.prgBarVerim.Name = "prgBarVerim";
            this.prgBarVerim.Properties.EndColor = System.Drawing.Color.ForestGreen;
            this.prgBarVerim.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.prgBarVerim.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.prgBarVerim.Properties.Maximum = 10;
            this.prgBarVerim.Properties.StartColor = System.Drawing.Color.Red;
            this.prgBarVerim.Size = new System.Drawing.Size(1235, 69);
            this.prgBarVerim.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1208, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 27);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // tmrPortRead
            // 
            this.tmrPortRead.Interval = 200;
            this.tmrPortRead.Tick += new System.EventHandler(this.tmrPortRead_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(301, 108);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(87, 75);
            this.webBrowser1.TabIndex = 13;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(379, 108);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScrollBarsEnabled = false;
            this.webBrowser2.Size = new System.Drawing.Size(87, 75);
            this.webBrowser2.TabIndex = 14;
            // 
            // webBrowser3
            // 
            this.webBrowser3.Location = new System.Drawing.Point(460, 108);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.ScrollBarsEnabled = false;
            this.webBrowser3.Size = new System.Drawing.Size(87, 75);
            this.webBrowser3.TabIndex = 16;
            // 
            // webBrowser4
            // 
            this.webBrowser4.Location = new System.Drawing.Point(544, 108);
            this.webBrowser4.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser4.Name = "webBrowser4";
            this.webBrowser4.ScrollBarsEnabled = false;
            this.webBrowser4.Size = new System.Drawing.Size(87, 75);
            this.webBrowser4.TabIndex = 15;
            // 
            // webBrowser5
            // 
            this.webBrowser5.Location = new System.Drawing.Point(627, 108);
            this.webBrowser5.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser5.Name = "webBrowser5";
            this.webBrowser5.ScrollBarsEnabled = false;
            this.webBrowser5.Size = new System.Drawing.Size(87, 75);
            this.webBrowser5.TabIndex = 19;
            // 
            // webBrowser6
            // 
            this.webBrowser6.Location = new System.Drawing.Point(791, 108);
            this.webBrowser6.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser6.Name = "webBrowser6";
            this.webBrowser6.ScrollBarsEnabled = false;
            this.webBrowser6.Size = new System.Drawing.Size(87, 75);
            this.webBrowser6.TabIndex = 18;
            // 
            // webBrowser7
            // 
            this.webBrowser7.Location = new System.Drawing.Point(708, 108);
            this.webBrowser7.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser7.Name = "webBrowser7";
            this.webBrowser7.ScrollBarsEnabled = false;
            this.webBrowser7.Size = new System.Drawing.Size(87, 75);
            this.webBrowser7.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(290, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Önümüzdeki Bir Haftanın Hava Tahminleri Yukardadır.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(245, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(712, 38);
            this.label2.TabIndex = 20;
            this.label2.Text = "Solar Panaller Otonom Konumlandırma Aktive Durumda.";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(1005, 74);
            this.txtTemp.Multiline = true;
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(215, 132);
            this.txtTemp.TabIndex = 21;
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(7, 74);
            this.txtMinTemp.Multiline = true;
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(215, 132);
            this.txtMinTemp.TabIndex = 22;
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctLogo.BackgroundImage")));
            this.pctLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctLogo.Location = new System.Drawing.Point(550, 52);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(139, 133);
            this.pctLogo.TabIndex = 7;
            this.pctLogo.TabStop = false;
            // 
            // tmrSerialWrite
            // 
            this.tmrSerialWrite.Tick += new System.EventHandler(this.tmrSerialWrite_Tick);
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMod.ForeColor = System.Drawing.Color.White;
            this.lblMod.Location = new System.Drawing.Point(8, 18);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(145, 38);
            this.lblMod.TabIndex = 23;
            this.lblMod.Text = "Aktif Mod:";
            // 
            // frmControlScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 647);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmControlScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmControlScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmControlScreen_FormClosing);
            this.Load += new System.EventHandler(this.frmControlScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prgBarVerim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblVerim;
        private DevExpress.XtraEditors.ProgressBarControl prgBarVerim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSettingOkay;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer tmrPortRead;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.WebBrowser webBrowser4;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser5;
        private System.Windows.Forms.WebBrowser webBrowser6;
        private System.Windows.Forms.WebBrowser webBrowser7;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrSerialWrite;
        private System.Windows.Forms.Label lblMod;
    }
}