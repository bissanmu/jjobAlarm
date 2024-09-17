using System.Windows.Forms;
using System.Drawing;
namespace MaterialSkinExample
{
    partial class Form_Alert
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            lblMsg = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(704, 12);
            button1.Name = "button1";
            button1.Size = new Size(69, 41);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.success;
            pictureBox1.Location = new Point(21, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Font = new Font("맑은 고딕", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point);
            lblMsg.ForeColor = SystemColors.Window;
            lblMsg.Location = new Point(130, 26);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(252, 50);
            lblMsg.TabIndex = 2;
            lblMsg.Text = "Message Text";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(144, 133);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(97, 30);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "바로가기";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form_Alert
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(785, 185);
            Controls.Add(linkLabel1);
            Controls.Add(lblMsg);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Alert";
            Text = "Form_Alert";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Label lblMsg;
        private System.Windows.Forms.Timer timer1;
        private LinkLabel linkLabel1;
    }
}