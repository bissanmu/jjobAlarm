using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkinExample
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
            this.nextBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rJobBtn = new MaterialSkin2Framework.Controls.MaterialRadioButton();
            this.rFolderBtn = new MaterialSkin2Framework.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rDevBtn = new MaterialSkin2Framework.Controls.MaterialRadioButton();
            this.rVerifyBtn = new MaterialSkin2Framework.Controls.MaterialRadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin2Framework.Controls.MaterialButton();
            this.materialListView1 = new MaterialSkin2Framework.Controls.MaterialListView();
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.order_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.start_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.end_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin2Framework.Controls.MaterialLabel();
            this.materialDivider4 = new MaterialSkin2Framework.Controls.MaterialDivider();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin2Framework.Controls.MaterialLabel();
            this.materialDivider3 = new MaterialSkin2Framework.Controls.MaterialDivider();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin2Framework.Controls.MaterialLabel();
            this.materialDivider2 = new MaterialSkin2Framework.Controls.MaterialDivider();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.item1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.disabledItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.item3ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.prevBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel8 = new MaterialSkin2Framework.Controls.MaterialLabel();
            this.materialDivider5 = new MaterialSkin2Framework.Controls.MaterialDivider();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.AutoSize = true;
            this.nextBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextBtn.Depth = 0;
            this.nextBtn.Icon = null;
            this.nextBtn.Location = new System.Drawing.Point(915, 538);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nextBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Primary = true;
            this.nextBtn.Size = new System.Drawing.Size(85, 36);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 534);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1063, 1);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 59);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1063, 45);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(17, 102);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1024, 421);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1016, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Step1 서버";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rJobBtn);
            this.groupBox2.Controls.Add(this.rFolderBtn);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(523, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 192);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "알림 단위";
            // 
            // rJobBtn
            // 
            this.rJobBtn.AutoSize = true;
            this.rJobBtn.Checked = true;
            this.rJobBtn.Depth = 0;
            this.rJobBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJobBtn.Location = new System.Drawing.Point(32, 60);
            this.rJobBtn.Margin = new System.Windows.Forms.Padding(0);
            this.rJobBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rJobBtn.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.rJobBtn.Name = "rJobBtn";
            this.rJobBtn.Ripple = true;
            this.rJobBtn.Size = new System.Drawing.Size(90, 37);
            this.rJobBtn.TabIndex = 22;
            this.rJobBtn.TabStop = true;
            this.rJobBtn.Text = "Job 단위";
            this.rJobBtn.UseVisualStyleBackColor = true;
            // 
            // rFolderBtn
            // 
            this.rFolderBtn.AutoSize = true;
            this.rFolderBtn.Depth = 0;
            this.rFolderBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rFolderBtn.Location = new System.Drawing.Point(32, 103);
            this.rFolderBtn.Margin = new System.Windows.Forms.Padding(0);
            this.rFolderBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rFolderBtn.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.rFolderBtn.Name = "rFolderBtn";
            this.rFolderBtn.Ripple = true;
            this.rFolderBtn.Size = new System.Drawing.Size(87, 37);
            this.rFolderBtn.TabIndex = 23;
            this.rFolderBtn.TabStop = true;
            this.rFolderBtn.Text = "폴더 단위";
            this.rFolderBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rDevBtn);
            this.groupBox1.Controls.Add(this.rVerifyBtn);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(235, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 192);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "서버 리스트";
            // 
            // rDevBtn
            // 
            this.rDevBtn.AutoSize = true;
            this.rDevBtn.Checked = true;
            this.rDevBtn.Depth = 0;
            this.rDevBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDevBtn.Location = new System.Drawing.Point(32, 60);
            this.rDevBtn.Margin = new System.Windows.Forms.Padding(0);
            this.rDevBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rDevBtn.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.rDevBtn.Name = "rDevBtn";
            this.rDevBtn.Ripple = true;
            this.rDevBtn.Size = new System.Drawing.Size(127, 37);
            this.rDevBtn.TabIndex = 22;
            this.rDevBtn.TabStop = true;
            this.rDevBtn.Text = "J-JOBS 개발계";
            this.rDevBtn.UseVisualStyleBackColor = true;
            // 
            // rVerifyBtn
            // 
            this.rVerifyBtn.AutoSize = true;
            this.rVerifyBtn.Depth = 0;
            this.rVerifyBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rVerifyBtn.Location = new System.Drawing.Point(32, 103);
            this.rVerifyBtn.Margin = new System.Windows.Forms.Padding(0);
            this.rVerifyBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rVerifyBtn.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.rVerifyBtn.Name = "rVerifyBtn";
            this.rVerifyBtn.Ripple = true;
            this.rVerifyBtn.Size = new System.Drawing.Size(127, 37);
            this.rVerifyBtn.TabIndex = 23;
            this.rVerifyBtn.TabStop = true;
            this.rVerifyBtn.Text = "J-JOBS 검증계";
            this.rVerifyBtn.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialButton1);
            this.tabPage2.Controls.Add(this.materialListView1);
            this.tabPage2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1016, 395);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Step2 대상작업";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(923, 359);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(85, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "내역조회";
            this.materialButton1.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.CheckBoxes = true;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.status,
            this.order_id,
            this.name,
            this.tags,
            this.start_time,
            this.end_time});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(-4, 0);
            this.materialListView1.Margin = new System.Windows.Forms.Padding(2);
            this.materialListView1.MinimumSize = new System.Drawing.Size(127, 57);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin2Framework.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1024, 351);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // status
            // 
            this.status.Text = "Status";
            // 
            // order_id
            // 
            this.order_id.Text = "Order id";
            // 
            // name
            // 
            this.name.Text = "Name";
            // 
            // tags
            // 
            this.tags.Text = "Tags";
            // 
            // start_time
            // 
            this.start_time.Text = "Start Time";
            // 
            // end_time
            // 
            this.end_time.Text = "End time";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.materialLabel9);
            this.tabPage3.Controls.Add(this.materialLabel8);
            this.tabPage3.Controls.Add(this.materialDivider5);
            this.tabPage3.Controls.Add(this.materialLabel7);
            this.tabPage3.Controls.Add(this.materialLabel6);
            this.tabPage3.Controls.Add(this.materialDivider4);
            this.tabPage3.Controls.Add(this.materialLabel5);
            this.tabPage3.Controls.Add(this.materialLabel4);
            this.tabPage3.Controls.Add(this.materialDivider3);
            this.tabPage3.Controls.Add(this.materialLabel3);
            this.tabPage3.Controls.Add(this.materialLabel1);
            this.tabPage3.Controls.Add(this.materialDivider2);
            this.tabPage3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Size = new System.Drawing.Size(1016, 395);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Step3 결과내역";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(190, 193);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(71, 32);
            this.materialLabel7.TabIndex = 8;
            this.materialLabel7.Text = "input";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(78, 193);
            this.materialLabel6.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(93, 20);
            this.materialLabel6.TabIndex = 7;
            this.materialLabel6.Text = "알림 스케쥴 대상";
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(49, 181);
            this.materialDivider4.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(23, 42);
            this.materialDivider4.TabIndex = 6;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(160, 127);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(71, 32);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "input";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(78, 129);
            this.materialLabel4.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(53, 20);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "알림 단위";
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(49, 117);
            this.materialDivider3.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(23, 42);
            this.materialDivider3.TabIndex = 3;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(160, 69);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(71, 32);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "input";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(78, 69);
            this.materialLabel1.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(53, 20);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "서버 구분";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(49, 56);
            this.materialDivider2.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(23, 42);
            this.materialDivider2.TabIndex = 0;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.materialLabel2);
            this.tabPage4.Controls.Add(this.materialFlatButton4);
            this.tabPage4.Controls.Add(this.materialRaisedButton2);
            this.tabPage4.Controls.Add(this.materialProgressBar1);
            this.tabPage4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage4.Size = new System.Drawing.Size(1016, 395);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "이력조회";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(4, 14);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(676, 58);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Here we\'re showcasing the progressbar together with a FlatButton and a RaisedButt" +
    "on that have support for icons.";
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Icon = global::MaterialSkinExample.Properties.Resources.minus;
            this.materialFlatButton4.Location = new System.Drawing.Point(8, 87);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(173, 36);
            this.materialFlatButton4.TabIndex = 2;
            this.materialFlatButton4.Text = "Subtract";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            this.materialFlatButton4.Click += new System.EventHandler(this.materialFlatButton4_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = global::MaterialSkinExample.Properties.Resources.plus;
            this.materialRaisedButton2.Location = new System.Drawing.Point(601, 87);
            this.materialRaisedButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(100, 36);
            this.materialRaisedButton2.TabIndex = 1;
            this.materialRaisedButton2.Text = "Add";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(7, 75);
            this.materialProgressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(666, 5);
            this.materialProgressBar1.TabIndex = 0;
            this.materialProgressBar1.Value = 45;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.disabledItemToolStripMenuItem,
            this.item2ToolStripMenuItem,
            this.toolStripSeparator1,
            this.item3ToolStripMenuItem});
            this.materialContextMenuStrip1.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(243, 130);
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.AutoSize = false;
            this.item1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subItem1ToolStripMenuItem,
            this.subItem2ToolStripMenuItem});
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item1ToolStripMenuItem.Text = "Item 1";
            // 
            // subItem1ToolStripMenuItem
            // 
            this.subItem1ToolStripMenuItem.AutoSize = false;
            this.subItem1ToolStripMenuItem.Name = "subItem1ToolStripMenuItem";
            this.subItem1ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem1ToolStripMenuItem.Text = "SubItem 1";
            // 
            // subItem2ToolStripMenuItem
            // 
            this.subItem2ToolStripMenuItem.AutoSize = false;
            this.subItem2ToolStripMenuItem.Name = "subItem2ToolStripMenuItem";
            this.subItem2ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem2ToolStripMenuItem.Text = "SubItem 2";
            // 
            // disabledItemToolStripMenuItem
            // 
            this.disabledItemToolStripMenuItem.AutoSize = false;
            this.disabledItemToolStripMenuItem.Enabled = false;
            this.disabledItemToolStripMenuItem.Name = "disabledItemToolStripMenuItem";
            this.disabledItemToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.disabledItemToolStripMenuItem.Text = "Disabled item";
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.AutoSize = false;
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item2ToolStripMenuItem.Text = "Item 2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
            // 
            // item3ToolStripMenuItem
            // 
            this.item3ToolStripMenuItem.AutoSize = false;
            this.item3ToolStripMenuItem.Name = "item3ToolStripMenuItem";
            this.item3ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item3ToolStripMenuItem.Text = "Item 3";
            // 
            // prevBtn
            // 
            this.prevBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.prevBtn.AutoSize = true;
            this.prevBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.prevBtn.Depth = 0;
            this.prevBtn.Icon = null;
            this.prevBtn.Location = new System.Drawing.Point(853, 538);
            this.prevBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.prevBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Primary = false;
            this.prevBtn.Size = new System.Drawing.Size(84, 36);
            this.prevBtn.TabIndex = 19;
            this.prevBtn.Text = "PREV";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(78, 260);
            this.materialLabel8.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(117, 20);
            this.materialLabel8.TabIndex = 10;
            this.materialLabel8.Text = "알림 스케쥴 시작시간";
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(49, 248);
            this.materialDivider5.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(23, 42);
            this.materialDivider5.TabIndex = 9;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(208, 260);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(71, 32);
            this.materialLabel9.TabIndex = 11;
            this.materialLabel9.Text = "input";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 580);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.nextBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "ARK System Batch Alarm";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton nextBtn;
        private MaterialDivider materialDivider1;
        private MaterialTabSelector materialTabSelector1;
        private MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem disabledItemToolStripMenuItem;
		private TabPage tabPage2;
        private TabPage tabPage4;
        private MaterialProgressBar materialProgressBar1;
        private MaterialRaisedButton materialRaisedButton2;
        private MaterialFlatButton prevBtn;
        private MaterialFlatButton materialFlatButton4;
        private MaterialLabel materialLabel2;
        private MaterialSkin2Framework.Controls.MaterialListView materialListView1;
        private MaterialSkin2Framework.Controls.MaterialRadioButton rDevBtn;
        private MaterialSkin2Framework.Controls.MaterialRadioButton rVerifyBtn;
        private ColumnHeader status;
        private ColumnHeader order_id;
        private ColumnHeader name;
        private ColumnHeader tags;
        private ColumnHeader start_time;
        private ColumnHeader end_time;
        private MaterialSkin2Framework.Controls.MaterialButton materialButton1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private MaterialSkin2Framework.Controls.MaterialRadioButton rJobBtn;
        private MaterialSkin2Framework.Controls.MaterialRadioButton rFolderBtn;
        private MaterialSkin2Framework.Controls.MaterialDivider materialDivider2;
        private MaterialSkin2Framework.Controls.MaterialLabel materialLabel1;
        private MaterialLabel materialLabel3;
        private MaterialLabel materialLabel5;
        private MaterialSkin2Framework.Controls.MaterialLabel materialLabel4;
        private MaterialSkin2Framework.Controls.MaterialDivider materialDivider3;
        private MaterialSkin2Framework.Controls.MaterialLabel materialLabel6;
        private MaterialSkin2Framework.Controls.MaterialDivider materialDivider4;
        private MaterialLabel materialLabel7;
        private MaterialSkin2Framework.Controls.MaterialLabel materialLabel8;
        private MaterialSkin2Framework.Controls.MaterialDivider materialDivider5;
        private MaterialLabel materialLabel9;
    }
}