
namespace gachinaruto
{
    partial class ClansPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClansPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.privetusername = new System.Windows.Forms.Label();
            this.userpicture = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clansearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel1.Location = new System.Drawing.Point(13, 141);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 519);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(585, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Кланы";
            // 
            // privetusername
            // 
            this.privetusername.AutoSize = true;
            this.privetusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.privetusername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.privetusername.Location = new System.Drawing.Point(1102, 111);
            this.privetusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.privetusername.Name = "privetusername";
            this.privetusername.Size = new System.Drawing.Size(80, 20);
            this.privetusername.TabIndex = 17;
            this.privetusername.Text = "username";
            // 
            // userpicture
            // 
            this.userpicture.Image = ((System.Drawing.Image)(resources.GetObject("userpicture.Image")));
            this.userpicture.InitialImage = null;
            this.userpicture.Location = new System.Drawing.Point(1107, 32);
            this.userpicture.Margin = new System.Windows.Forms.Padding(4);
            this.userpicture.Name = "userpicture";
            this.userpicture.Size = new System.Drawing.Size(75, 75);
            this.userpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userpicture.TabIndex = 16;
            this.userpicture.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.29703F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.70297F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.clansearch, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(385, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 39);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 31);
            this.textBox1.TabIndex = 3;
            // 
            // clansearch
            // 
            this.clansearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clansearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clansearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clansearch.Location = new System.Drawing.Point(358, 4);
            this.clansearch.Margin = new System.Windows.Forms.Padding(4);
            this.clansearch.Name = "clansearch";
            this.clansearch.Size = new System.Drawing.Size(143, 31);
            this.clansearch.TabIndex = 2;
            this.clansearch.Text = "Поиск";
            this.clansearch.UseVisualStyleBackColor = false;
            this.clansearch.Click += new System.EventHandler(this.clansearch_Click);
            // 
            // ClansPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.privetusername);
            this.Controls.Add(this.userpicture);
            this.Controls.Add(this.pictureBox2);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "ClansPage";
            this.Text = "Clans page";
            ((System.ComponentModel.ISupportInitialize)(this.userpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label privetusername;
        private System.Windows.Forms.PictureBox userpicture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button clansearch;
    }
}