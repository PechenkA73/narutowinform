
namespace gachinaruto
{
    partial class ArticlesPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticlesPage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.articlesearch = new System.Windows.Forms.Button();
            this.naitipersonaja = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userpicture = new System.Windows.Forms.PictureBox();
            this.privetusername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.29703F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.70297F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.articlesearch, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(290, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 39);
            this.tableLayoutPanel1.TabIndex = 19;
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
            // articlesearch
            // 
            this.articlesearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.articlesearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.articlesearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.articlesearch.Location = new System.Drawing.Point(358, 4);
            this.articlesearch.Margin = new System.Windows.Forms.Padding(4);
            this.articlesearch.Name = "articlesearch";
            this.articlesearch.Size = new System.Drawing.Size(143, 31);
            this.articlesearch.TabIndex = 2;
            this.articlesearch.Text = "Поиск";
            this.articlesearch.UseVisualStyleBackColor = false;
            this.articlesearch.Click += new System.EventHandler(this.articlesearch_Click);
            // 
            // naitipersonaja
            // 
            this.naitipersonaja.AutoSize = true;
            this.naitipersonaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.naitipersonaja.Location = new System.Drawing.Point(289, 38);
            this.naitipersonaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.naitipersonaja.Name = "naitipersonaja";
            this.naitipersonaja.Size = new System.Drawing.Size(121, 20);
            this.naitipersonaja.TabIndex = 18;
            this.naitipersonaja.Text = "Найти cтатью:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // userpicture
            // 
            this.userpicture.Image = ((System.Drawing.Image)(resources.GetObject("userpicture.Image")));
            this.userpicture.InitialImage = null;
            this.userpicture.Location = new System.Drawing.Point(1097, 13);
            this.userpicture.Margin = new System.Windows.Forms.Padding(4);
            this.userpicture.Name = "userpicture";
            this.userpicture.Size = new System.Drawing.Size(75, 75);
            this.userpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userpicture.TabIndex = 21;
            this.userpicture.TabStop = false;
            // 
            // privetusername
            // 
            this.privetusername.AutoSize = true;
            this.privetusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.privetusername.Location = new System.Drawing.Point(1092, 91);
            this.privetusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.privetusername.Name = "privetusername";
            this.privetusername.Size = new System.Drawing.Size(84, 20);
            this.privetusername.TabIndex = 20;
            this.privetusername.Text = " username";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel1.Location = new System.Drawing.Point(13, 126);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 542);
            this.panel1.TabIndex = 22;
            // 
            // ArticlesPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userpicture);
            this.Controls.Add(this.privetusername);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.naitipersonaja);
            this.Controls.Add(this.pictureBox2);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "ArticlesPage";
            this.Text = "Articles page";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button articlesearch;
        private System.Windows.Forms.Label naitipersonaja;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox userpicture;
        private System.Windows.Forms.Label privetusername;
        private System.Windows.Forms.Panel panel1;
    }
}