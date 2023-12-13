
namespace ZeplinFlow.Login
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logOutBtn = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.loginBtn = new DevExpress.XtraEditors.SimpleButton();
            this.PasswordTxt = new DevExpress.XtraEditors.TextEdit();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.UsernameTxt = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Controls.Add(this.logOutBtn);
            this.panelControl1.Controls.Add(this.comboBoxEdit1);
            this.panelControl1.Controls.Add(this.loginBtn);
            this.panelControl1.Controls.Add(this.PasswordTxt);
            this.panelControl1.Controls.Add(this.toggleSwitch1);
            this.panelControl1.Controls.Add(this.UsernameTxt);
            this.panelControl1.Location = new System.Drawing.Point(52, 26);
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(374, 467);
            this.panelControl1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.logOutBtn.Appearance.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.logOutBtn.Appearance.Options.UseBackColor = true;
            this.logOutBtn.Appearance.Options.UseFont = true;
            this.logOutBtn.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.logOutBtn.AppearanceDisabled.Options.UseBackColor = true;
            this.logOutBtn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.logOutBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("logOutBtn.ImageOptions.SvgImage")));
            this.logOutBtn.Location = new System.Drawing.Point(334, 10);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.logOutBtn.Size = new System.Drawing.Size(30, 30);
            this.logOutBtn.TabIndex = 27;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "Şirket Seç";
            this.comboBoxEdit1.Location = new System.Drawing.Point(100, 210);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Yumak",
            "Zeplin"});
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Size = new System.Drawing.Size(169, 20);
            this.comboBoxEdit1.TabIndex = 25;
            // 
            // loginBtn
            // 
            this.loginBtn.Appearance.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.loginBtn.Appearance.Options.UseFont = true;
            this.loginBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("loginBtn.ImageOptions.SvgImage")));
            this.loginBtn.Location = new System.Drawing.Point(100, 340);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(169, 52);
            this.loginBtn.TabIndex = 19;
            this.loginBtn.Text = "Giriş Yap";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(100, 273);
            this.PasswordTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordTxt.Properties.Appearance.Options.UseFont = true;
            this.PasswordTxt.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White;
            this.PasswordTxt.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.PasswordTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PasswordTxt.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("PasswordTxt.Properties.ContextImageOptions.SvgImage")));
            this.PasswordTxt.Properties.UseSystemPasswordChar = true;
            this.PasswordTxt.Size = new System.Drawing.Size(169, 34);
            this.PasswordTxt.TabIndex = 18;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(100, 312);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.toggleSwitch1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.toggleSwitch1.Properties.Appearance.Options.UseBackColor = true;
            this.toggleSwitch1.Properties.Appearance.Options.UseForeColor = true;
            this.toggleSwitch1.Properties.OffText = "      Beni Hatırla";
            this.toggleSwitch1.Properties.OnText = "      Beni Hatırla";
            this.toggleSwitch1.Size = new System.Drawing.Size(169, 22);
            this.toggleSwitch1.TabIndex = 17;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(100, 235);
            this.UsernameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsernameTxt.Properties.Appearance.Options.UseFont = true;
            this.UsernameTxt.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White;
            this.UsernameTxt.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.UsernameTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.UsernameTxt.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("UsernameTxt.Properties.ContextImageOptions.SvgImage")));
            this.UsernameTxt.Size = new System.Drawing.Size(169, 34);
            this.UsernameTxt.TabIndex = 15;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(479, 518);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTxt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton logOutBtn;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton loginBtn;
        public DevExpress.XtraEditors.TextEdit PasswordTxt;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        public DevExpress.XtraEditors.TextEdit UsernameTxt;
    }
}