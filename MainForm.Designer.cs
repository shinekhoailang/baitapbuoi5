namespace Lab03_02
{
    partial class MainForm
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
            this.richText = new System.Windows.Forms.RichTextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnMoi = new System.Windows.Forms.ToolStripButton();
            this.btnMo = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.sepCongCu1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbFonts = new System.Windows.Forms.ToolStripComboBox();
            this.cmbSize = new System.Windows.Forms.ToolStripComboBox();
            this.sepCongCu2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDam = new System.Windows.Forms.ToolStripButton();
            this.btnNghieng = new System.Windows.Forms.ToolStripButton();
            this.btnGachChan = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblTongTu = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaoMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMoTapTin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.sepHeThong = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDinhDang = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // richText
            // 
            this.richText.Name = "richText";
            this.richText.AcceptsTab = true;
            this.richText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richText.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richText.HideSelection = false;
            this.richText.Location = new System.Drawing.Point(0, 49);
            this.richText.Size = new System.Drawing.Size(720, 407);
            this.richText.TabIndex = 0;
            this.richText.Text = "";
            this.richText.SelectionChanged += new System.EventHandler(this.richText_SelectionChanged);
            this.richText.TextChanged += new System.EventHandler(this.richText_TextChanged);
            // 
            // toolStrip
            // 
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Size = new System.Drawing.Size(720, 25);
            this.toolStrip.Text = "toolStrip";
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMoi,
            this.btnMo,
            this.btnLuu,
            this.sepCongCu1,
            this.cmbFonts,
            this.cmbSize,
            this.sepCongCu2,
            this.btnDam,
            this.btnNghieng,
            this.btnGachChan});
            // 
            // btnMoi
            // 
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMoi.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMoi.Text = "📄";
            this.btnMoi.ToolTipText = "Tạo văn bản mới (Ctrl+N)";
            this.btnMoi.Click += new System.EventHandler(this.TaoMoi_Click);
            // 
            // btnMo
            // 
            this.btnMo.Name = "btnMo";
            this.btnMo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMo.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMo.Text = "📂";
            this.btnMo.ToolTipText = "Mở tập tin (Ctrl+O)";
            this.btnMo.Click += new System.EventHandler(this.MoTapTin_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.Text = "💾";
            this.btnLuu.ToolTipText = "Lưu nội dung văn bản (Ctrl+S)";
            this.btnLuu.Click += new System.EventHandler(this.LuuTapTin_Click);
            // 
            // sepCongCu1
            // 
            this.sepCongCu1.Name = "sepCongCu1";
            // 
            // cmbFonts
            // 
            this.cmbFonts.Name = "cmbFonts";
            this.cmbFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFonts.Size = new System.Drawing.Size(170, 25);
            this.cmbFonts.ToolTipText = "Font chữ";
            this.cmbFonts.Items.AddRange(new object[] {
            "Tahoma"});
            this.cmbFonts.SelectedIndexChanged += new System.EventHandler(this.cmbFonts_SelectedIndexChanged);
            // 
            // cmbSize
            // 
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(60, 25);
            this.cmbSize.Text = "14";
            this.cmbSize.ToolTipText = "Cỡ chữ";
            this.cmbSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            this.cmbSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSize_KeyDown);
            // 
            // sepCongCu2
            // 
            this.sepCongCu2.Name = "sepCongCu2";
            // 
            // btnDam
            // 
            this.btnDam.Name = "btnDam";
            this.btnDam.CheckOnClick = true;
            this.btnDam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDam.Text = "B";
            this.btnDam.ToolTipText = "In đậm";
            this.btnDam.Click += new System.EventHandler(this.btnDam_Click);
            // 
            // btnNghieng
            // 
            this.btnNghieng.Name = "btnNghieng";
            this.btnNghieng.CheckOnClick = true;
            this.btnNghieng.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNghieng.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnNghieng.Text = "I";
            this.btnNghieng.ToolTipText = "In nghiêng";
            this.btnNghieng.Click += new System.EventHandler(this.btnNghieng_Click);
            // 
            // btnGachChan
            // 
            this.btnGachChan.Name = "btnGachChan";
            this.btnGachChan.CheckOnClick = true;
            this.btnGachChan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGachChan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnGachChan.Text = "U";
            this.btnGachChan.ToolTipText = "Gạch dưới";
            this.btnGachChan.Click += new System.EventHandler(this.btnGachChan_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Location = new System.Drawing.Point(0, 456);
            this.statusStrip.Size = new System.Drawing.Size(720, 24);
            this.statusStrip.Text = "statusStrip";
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTongTu});
            // 
            // lblTongTu
            // 
            this.lblTongTu.Name = "lblTongTu";
            this.lblTongTu.Text = "Tổng số từ: 0";
            // 
            // menuStrip
            // 
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Size = new System.Drawing.Size(720, 24);
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuDinhDang});
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Text = "Hệ thống";
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaoMoi,
            this.mnuMoTapTin,
            this.mnuLuu,
            this.sepHeThong,
            this.mnuThoat});
            // 
            // mnuTaoMoi
            // 
            this.mnuTaoMoi.Name = "mnuTaoMoi";
            this.mnuTaoMoi.Text = "Tạo văn bản mới";
            this.mnuTaoMoi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuTaoMoi.Click += new System.EventHandler(this.TaoMoi_Click);
            // 
            // mnuMoTapTin
            // 
            this.mnuMoTapTin.Name = "mnuMoTapTin";
            this.mnuMoTapTin.Text = "Mở tập tin";
            this.mnuMoTapTin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuMoTapTin.Click += new System.EventHandler(this.MoTapTin_Click);
            // 
            // mnuLuu
            // 
            this.mnuLuu.Name = "mnuLuu";
            this.mnuLuu.Text = "Lưu nội dung văn bản";
            this.mnuLuu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuLuu.Click += new System.EventHandler(this.LuuTapTin_Click);
            // 
            // sepHeThong
            // 
            this.sepHeThong.Name = "sepHeThong";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDinhDang
            // 
            this.mnuDinhDang.Name = "mnuDinhDang";
            this.mnuDinhDang.Text = "Định dạng";
            this.mnuDinhDang.Click += new System.EventHandler(this.mnuDinhDang_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Văn bản (*.txt;*.rtf)|*.txt;*.rtf|Tất cả tệp (*.*)|*.*";
            this.openFileDialog.Title = "Mở tập tin";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "rtf";
            this.saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Văn bản thuần (*.txt)|*.txt";
            this.saveFileDialog.Title = "Lưu nội dung văn bản";
            // 
            // fontDialog
            // 
            this.fontDialog.ShowApply = true;
            this.fontDialog.ShowColor = true;
            this.fontDialog.ShowEffects = true;
            this.fontDialog.ShowHelp = true;
            this.fontDialog.Apply += new System.EventHandler(this.fontDialog_Apply);
            this.fontDialog.HelpRequest += new System.EventHandler(this.fontDialog_HelpRequest);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(420, 280);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soạn thảo văn bản";
            this.Controls.Add(this.richText);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Name = "MainForm";
            this.toolStrip.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.PerformLayout();
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnMoi;
        private System.Windows.Forms.ToolStripButton btnMo;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripSeparator sepCongCu1;
        private System.Windows.Forms.ToolStripComboBox cmbFonts;
        private System.Windows.Forms.ToolStripComboBox cmbSize;
        private System.Windows.Forms.ToolStripSeparator sepCongCu2;
        private System.Windows.Forms.ToolStripButton btnDam;
        private System.Windows.Forms.ToolStripButton btnNghieng;
        private System.Windows.Forms.ToolStripButton btnGachChan;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblTongTu;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuTaoMoi;
        private System.Windows.Forms.ToolStripMenuItem mnuMoTapTin;
        private System.Windows.Forms.ToolStripMenuItem mnuLuu;
        private System.Windows.Forms.ToolStripSeparator sepHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDinhDang;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}
