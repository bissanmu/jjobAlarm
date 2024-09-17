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
            this.materialRadioButton4 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialRadioButton6 = new MaterialSkin2Framework.Controls.MaterialRadioButton();
            this.materialRadioButton5 = new MaterialSkin2Framework.Controls.MaterialRadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialListView1 = new MaterialSkin2Framework.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialCheckBox6 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox5 = new MaterialSkin.Controls.MaterialCheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
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
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
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
            this.nextBtn.Location = new System.Drawing.Point(962, 646);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
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
            this.materialDivider1.Location = new System.Drawing.Point(0, 612);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1146, 2);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialRadioButton4
            // 
            this.materialRadioButton4.AutoSize = true;
            this.materialRadioButton4.Checked = true;
            this.materialRadioButton4.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialRadioButton4.Depth = 0;
            this.materialRadioButton4.Enabled = false;
            this.materialRadioButton4.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton4.Location = new System.Drawing.Point(0, 158);
            this.materialRadioButton4.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton4.Name = "materialRadioButton4";
            this.materialRadioButton4.Ripple = true;
            this.materialRadioButton4.Size = new System.Drawing.Size(267, 30);
            this.materialRadioButton4.TabIndex = 15;
            this.materialRadioButton4.TabStop = true;
            this.materialRadioButton4.Text = "materialRadioButton4";
            this.materialRadioButton4.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton3
            // 
            this.materialRadioButton3.AutoSize = true;
            this.materialRadioButton3.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialRadioButton3.Depth = 0;
            this.materialRadioButton3.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton3.Location = new System.Drawing.Point(0, 110);
            this.materialRadioButton3.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton3.Name = "materialRadioButton3";
            this.materialRadioButton3.Ripple = true;
            this.materialRadioButton3.Size = new System.Drawing.Size(267, 30);
            this.materialRadioButton3.TabIndex = 11;
            this.materialRadioButton3.Text = "materialRadioButton3";
            this.materialRadioButton3.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton2.Location = new System.Drawing.Point(0, 61);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(267, 30);
            this.materialRadioButton2.TabIndex = 10;
            this.materialRadioButton2.Text = "materialRadioButton2";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox4
            // 
            this.materialCheckbox4.AutoSize = true;
            this.materialCheckbox4.Depth = 0;
            this.materialCheckbox4.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckbox4.Location = new System.Drawing.Point(0, 158);
            this.materialCheckbox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox4.Name = "materialCheckbox4";
            this.materialCheckbox4.Ripple = true;
            this.materialCheckbox4.Size = new System.Drawing.Size(242, 30);
            this.materialCheckbox4.TabIndex = 7;
            this.materialCheckbox4.Text = "materialCheckbox4";
            this.materialCheckbox4.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox3
            // 
            this.materialCheckbox3.AutoSize = true;
            this.materialCheckbox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialCheckbox3.Depth = 0;
            this.materialCheckbox3.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckbox3.Location = new System.Drawing.Point(0, 110);
            this.materialCheckbox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox3.Name = "materialCheckbox3";
            this.materialCheckbox3.Ripple = true;
            this.materialCheckbox3.Size = new System.Drawing.Size(242, 30);
            this.materialCheckbox3.TabIndex = 6;
            this.materialCheckbox3.Text = "materialCheckbox3";
            this.materialCheckbox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.AutoSize = true;
            this.materialCheckbox2.Checked = true;
            this.materialCheckbox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckbox2.Location = new System.Drawing.Point(0, 61);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(242, 30);
            this.materialCheckbox2.TabIndex = 5;
            this.materialCheckbox2.Text = "materialCheckbox2";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Checked = true;
            this.materialCheckbox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 13);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(242, 30);
            this.materialCheckbox1.TabIndex = 4;
            this.materialCheckbox1.Text = "materialCheckbox1";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(0, 13);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(267, 30);
            this.materialRadioButton1.TabIndex = 9;
            this.materialRadioButton1.Text = "materialRadioButton1";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 103);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1146, 78);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
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
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(26, 179);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1084, 414);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialRadioButton6);
            this.tabPage1.Controls.Add(this.materialRadioButton5);
            this.tabPage1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Size = new System.Drawing.Size(1076, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Step1 서버";
            // 
            // materialRadioButton6
            // 
            this.materialRadioButton6.AutoSize = true;
            this.materialRadioButton6.Depth = 0;
            this.materialRadioButton6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRadioButton6.Location = new System.Drawing.Point(139, 182);
            this.materialRadioButton6.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton6.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialRadioButton6.Name = "materialRadioButton6";
            this.materialRadioButton6.Ripple = true;
            this.materialRadioButton6.Size = new System.Drawing.Size(127, 37);
            this.materialRadioButton6.TabIndex = 23;
            this.materialRadioButton6.TabStop = true;
            this.materialRadioButton6.Text = "J-JOBS 검증계";
            this.materialRadioButton6.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton5
            // 
            this.materialRadioButton5.AutoSize = true;
            this.materialRadioButton5.Depth = 0;
            this.materialRadioButton5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRadioButton5.Location = new System.Drawing.Point(139, 121);
            this.materialRadioButton5.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton5.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialRadioButton5.Name = "materialRadioButton5";
            this.materialRadioButton5.Ripple = true;
            this.materialRadioButton5.Size = new System.Drawing.Size(127, 37);
            this.materialRadioButton5.TabIndex = 22;
            this.materialRadioButton5.TabStop = true;
            this.materialRadioButton5.Text = "J-JOBS 개발계";
            this.materialRadioButton5.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialListView1);
            this.tabPage2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage2.Size = new System.Drawing.Size(1076, 379);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Step2 대상작업";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.materialListView1.Depth = 0;
            this.materialListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(6, 5);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin2Framework.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1064, 369);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 300;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.materialRadioButton4);
            this.tabPage3.Controls.Add(this.materialRadioButton1);
            this.tabPage3.Controls.Add(this.materialRadioButton2);
            this.tabPage3.Controls.Add(this.materialRadioButton3);
            this.tabPage3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage3.Size = new System.Drawing.Size(1076, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Step3 알림단위";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.materialCheckBox6);
            this.tabPage4.Controls.Add(this.materialCheckBox5);
            this.tabPage4.Controls.Add(this.materialCheckbox3);
            this.tabPage4.Controls.Add(this.materialCheckbox1);
            this.tabPage4.Controls.Add(this.materialCheckbox2);
            this.tabPage4.Controls.Add(this.materialCheckbox4);
            this.tabPage4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage4.Size = new System.Drawing.Size(1076, 379);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Step4 최종내역";
            // 
            // materialCheckBox6
            // 
            this.materialCheckBox6.AutoSize = true;
            this.materialCheckBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialCheckBox6.Depth = 0;
            this.materialCheckBox6.Enabled = false;
            this.materialCheckBox6.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox6.Location = new System.Drawing.Point(0, 255);
            this.materialCheckBox6.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox6.Name = "materialCheckBox6";
            this.materialCheckBox6.Ripple = true;
            this.materialCheckBox6.Size = new System.Drawing.Size(243, 30);
            this.materialCheckBox6.TabIndex = 9;
            this.materialCheckBox6.Text = "materialCheckBox6";
            this.materialCheckBox6.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox5
            // 
            this.materialCheckBox5.AutoSize = true;
            this.materialCheckBox5.Checked = true;
            this.materialCheckBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialCheckBox5.Depth = 0;
            this.materialCheckBox5.Enabled = false;
            this.materialCheckBox5.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox5.Location = new System.Drawing.Point(0, 207);
            this.materialCheckBox5.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox5.Name = "materialCheckBox5";
            this.materialCheckBox5.Ripple = true;
            this.materialCheckBox5.Size = new System.Drawing.Size(243, 30);
            this.materialCheckBox5.TabIndex = 8;
            this.materialCheckBox5.Text = "materialCheckBox5";
            this.materialCheckBox5.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.materialLabel2);
            this.tabPage5.Controls.Add(this.materialFlatButton4);
            this.tabPage5.Controls.Add(this.materialRaisedButton2);
            this.tabPage5.Controls.Add(this.materialProgressBar1);
            this.tabPage5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage5.Size = new System.Drawing.Size(1076, 379);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "이력조회";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 24);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(1063, 102);
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
            this.materialFlatButton4.Location = new System.Drawing.Point(13, 153);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
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
            this.materialRaisedButton2.Location = new System.Drawing.Point(1001, 153);
            this.materialRaisedButton2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
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
            this.materialProgressBar1.Location = new System.Drawing.Point(11, 131);
            this.materialProgressBar1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(1047, 5);
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
            this.prevBtn.Location = new System.Drawing.Point(864, 646);
            this.prevBtn.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.prevBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Primary = false;
            this.prevBtn.Size = new System.Drawing.Size(84, 36);
            this.prevBtn.TabIndex = 19;
            this.prevBtn.Text = "PREV";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1131, 693);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.nextBtn);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainForm";
            this.Text = "ARK System Batch Alarm";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton nextBtn;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckbox3;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckbox4;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialRadioButton materialRadioButton2;
        private MaterialRadioButton materialRadioButton3;
        private MaterialRadioButton materialRadioButton4;
        private MaterialDivider materialDivider1;
        private MaterialTabSelector materialTabSelector1;
        private MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialCheckBox materialCheckBox5;
        private MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem disabledItemToolStripMenuItem;
		private MaterialCheckBox materialCheckBox6;
		private TabPage tabPage2;
        private TabPage tabPage5;
        private MaterialProgressBar materialProgressBar1;
        private MaterialRaisedButton materialRaisedButton2;
        private MaterialFlatButton prevBtn;
        private MaterialFlatButton materialFlatButton4;
        private MaterialLabel materialLabel2;
        private MaterialSkin2Framework.Controls.MaterialListView materialListView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private MaterialSkin2Framework.Controls.MaterialRadioButton materialRadioButton5;
        private MaterialSkin2Framework.Controls.MaterialRadioButton materialRadioButton6;
    }
}