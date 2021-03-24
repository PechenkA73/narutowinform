
namespace gachinaruto
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.herosearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.naitipersonaja = new System.Windows.Forms.Label();
            this.privetusername = new System.Windows.Forms.Label();
            this.userpicture = new System.Windows.Forms.PictureBox();
            this.filterclan = new System.Windows.Forms.CheckedListBox();
            this.labelclan = new System.Windows.Forms.Label();
            this.labelfrom = new System.Windows.Forms.Label();
            this.filterfrom = new System.Windows.Forms.CheckedListBox();
            this.labelprofession = new System.Windows.Forms.Label();
            this.filterprofession = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.favouritepersonpagebutton = new System.Windows.Forms.PictureBox();
            this.clanpagebutton = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.articleicon = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpicture)).BeginInit();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favouritepersonpagebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanpagebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleicon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // herosearch
            // 
            this.herosearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.herosearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.herosearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.herosearch.Location = new System.Drawing.Point(358, 4);
            this.herosearch.Margin = new System.Windows.Forms.Padding(4);
            this.herosearch.Name = "herosearch";
            this.herosearch.Size = new System.Drawing.Size(143, 31);
            this.herosearch.TabIndex = 2;
            this.herosearch.Text = "Поиск";
            this.herosearch.UseVisualStyleBackColor = false;
            this.herosearch.Click += new System.EventHandler(this.herosearch_Click);
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
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // naitipersonaja
            // 
            this.naitipersonaja.AutoSize = true;
            this.naitipersonaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.naitipersonaja.Location = new System.Drawing.Point(293, 40);
            this.naitipersonaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.naitipersonaja.Name = "naitipersonaja";
            this.naitipersonaja.Size = new System.Drawing.Size(182, 25);
            this.naitipersonaja.TabIndex = 4;
            this.naitipersonaja.Text = "Найти персонажа:";
            // 
            // privetusername
            // 
            this.privetusername.AutoSize = true;
            this.privetusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.privetusername.Location = new System.Drawing.Point(1102, 112);
            this.privetusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.privetusername.Name = "privetusername";
            this.privetusername.Size = new System.Drawing.Size(104, 25);
            this.privetusername.TabIndex = 5;
            this.privetusername.Text = " username";
            this.privetusername.Click += new System.EventHandler(this.privetusername_Click);
            // 
            // userpicture
            // 
            this.userpicture.Image = ((System.Drawing.Image)(resources.GetObject("userpicture.Image")));
            this.userpicture.InitialImage = null;
            this.userpicture.Location = new System.Drawing.Point(1106, 34);
            this.userpicture.Margin = new System.Windows.Forms.Padding(4);
            this.userpicture.Name = "userpicture";
            this.userpicture.Size = new System.Drawing.Size(75, 75);
            this.userpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userpicture.TabIndex = 6;
            this.userpicture.TabStop = false;
            this.userpicture.Click += new System.EventHandler(this.userpicture_Click);
            // 
            // filterclan
            // 
            this.filterclan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterclan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterclan.FormattingEnabled = true;
            this.filterclan.Items.AddRange(new object[] {
            "Учиха",
            "Узумаки",
            "Сенджу",
            "Хьюга",
            "Хатаке",
            "Ибури",
            "Инузука",
            "Казекаге",
            "Ооцуцуки",
            "Нара",
            "Сарутоби",
            "Хозуки",
            "Яманака",
            "Абураме",
            "Акимичи"});
            this.filterclan.Location = new System.Drawing.Point(0, 24);
            this.filterclan.Margin = new System.Windows.Forms.Padding(4);
            this.filterclan.Name = "filterclan";
            this.filterclan.Size = new System.Drawing.Size(229, 109);
            this.filterclan.TabIndex = 7;
            this.filterclan.SelectedIndexChanged += new System.EventHandler(this.filterclan_SelectedIndexChanged);
            // 
            // labelclan
            // 
            this.labelclan.AutoSize = true;
            this.labelclan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelclan.Location = new System.Drawing.Point(4, 0);
            this.labelclan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelclan.Name = "labelclan";
            this.labelclan.Size = new System.Drawing.Size(55, 20);
            this.labelclan.TabIndex = 8;
            this.labelclan.Text = "Клан:";
            this.labelclan.Click += new System.EventHandler(this.labelclan_Click);
            // 
            // labelfrom
            // 
            this.labelfrom.AutoSize = true;
            this.labelfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelfrom.Location = new System.Drawing.Point(4, 158);
            this.labelfrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfrom.Name = "labelfrom";
            this.labelfrom.Size = new System.Drawing.Size(160, 20);
            this.labelfrom.TabIndex = 9;
            this.labelfrom.Text = "Принадлежность:";
            // 
            // filterfrom
            // 
            this.filterfrom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.filterfrom.FormattingEnabled = true;
            this.filterfrom.Items.AddRange(new object[] {
            "Деревня Скрытого Листа",
            "Деревня Скрытого Звука",
            "Деревня Скрытого Водопада",
            "Деревня Скрытого Дождя",
            "Деревня Скрытого Песка",
            "Деревня Скрытого Тумана",
            "Деревня Скрытого Облака",
            "Деревня Скрытого Камня",
            "Деревня Скрытых Водоворотов",
            "Деревня Скрытой Травы",
            "Акацуки",
            "Союзные Силы Шиноби",
            "Лес Шиккоцу",
            "Гора Мьёбоку",
            "Пещера Рьючи"});
            this.filterfrom.Location = new System.Drawing.Point(0, 185);
            this.filterfrom.Margin = new System.Windows.Forms.Padding(4);
            this.filterfrom.Name = "filterfrom";
            this.filterfrom.Size = new System.Drawing.Size(229, 109);
            this.filterfrom.TabIndex = 10;
            // 
            // labelprofession
            // 
            this.labelprofession.AutoSize = true;
            this.labelprofession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelprofession.Location = new System.Drawing.Point(4, 319);
            this.labelprofession.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelprofession.Name = "labelprofession";
            this.labelprofession.Size = new System.Drawing.Size(111, 20);
            this.labelprofession.TabIndex = 11;
            this.labelprofession.Text = "Профессия:";
            // 
            // filterprofession
            // 
            this.filterprofession.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterprofession.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterprofession.FormattingEnabled = true;
            this.filterprofession.Items.AddRange(new object[] {
            "Шиноби",
            "Ниндзя-медик",
            "Анбу",
            "Хокаге",
            "Казекаге",
            "Мизукаге",
            "Райкаге",
            "Цучикаге"});
            this.filterprofession.Location = new System.Drawing.Point(4, 343);
            this.filterprofession.Margin = new System.Windows.Forms.Padding(4);
            this.filterprofession.Name = "filterprofession";
            this.filterprofession.Size = new System.Drawing.Size(229, 109);
            this.filterprofession.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel1.Location = new System.Drawing.Point(13, 147);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 519);
            this.panel1.TabIndex = 13;
            this.panel1.Click += new System.EventHandler(this.button1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(29, 481);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.labelclan);
            this.panel7.Controls.Add(this.filterprofession);
            this.panel7.Controls.Add(this.filterclan);
            this.panel7.Controls.Add(this.filterfrom);
            this.panel7.Controls.Add(this.labelfrom);
            this.panel7.Controls.Add(this.labelprofession);
            this.panel7.Location = new System.Drawing.Point(1030, 147);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(233, 519);
            this.panel7.TabIndex = 15;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.29703F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.70297F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.herosearch, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(294, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 39);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // favouritepersonpagebutton
            // 
            this.favouritepersonpagebutton.Image = ((System.Drawing.Image)(resources.GetObject("favouritepersonpagebutton.Image")));
            this.favouritepersonpagebutton.Location = new System.Drawing.Point(1188, 34);
            this.favouritepersonpagebutton.Name = "favouritepersonpagebutton";
            this.favouritepersonpagebutton.Size = new System.Drawing.Size(75, 75);
            this.favouritepersonpagebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.favouritepersonpagebutton.TabIndex = 17;
            this.favouritepersonpagebutton.TabStop = false;
            this.toolTip1.SetToolTip(this.favouritepersonpagebutton, "Любимые персонажи");
            this.favouritepersonpagebutton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // clanpagebutton
            // 
            this.clanpagebutton.Image = ((System.Drawing.Image)(resources.GetObject("clanpagebutton.Image")));
            this.clanpagebutton.Location = new System.Drawing.Point(1024, 34);
            this.clanpagebutton.Name = "clanpagebutton";
            this.clanpagebutton.Size = new System.Drawing.Size(75, 75);
            this.clanpagebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clanpagebutton.TabIndex = 18;
            this.clanpagebutton.TabStop = false;
            this.toolTip1.SetToolTip(this.clanpagebutton, "Кланы");
            this.clanpagebutton.Click += new System.EventHandler(this.clanpagebutton_Click);
            // 
            // articleicon
            // 
            this.articleicon.Image = ((System.Drawing.Image)(resources.GetObject("articleicon.Image")));
            this.articleicon.Location = new System.Drawing.Point(943, 34);
            this.articleicon.Name = "articleicon";
            this.articleicon.Size = new System.Drawing.Size(75, 75);
            this.articleicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.articleicon.TabIndex = 19;
            this.articleicon.TabStop = false;
            this.toolTip1.SetToolTip(this.articleicon, "Статьи");
            this.articleicon.Click += new System.EventHandler(this.articleicon_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1220, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 28);
            this.button2.TabIndex = 20;
            this.button2.Text = "EN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.EnglishClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(1176, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 28);
            this.button3.TabIndex = 21;
            this.button3.Text = "RU";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.RussianClick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.articleicon);
            this.Controls.Add(this.clanpagebutton);
            this.Controls.Add(this.favouritepersonpagebutton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userpicture);
            this.Controls.Add(this.privetusername);
            this.Controls.Add(this.naitipersonaja);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.Text = "Main page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpicture)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favouritepersonpagebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanpagebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button herosearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label naitipersonaja;
        private System.Windows.Forms.Label privetusername;
        private System.Windows.Forms.PictureBox userpicture;
        private System.Windows.Forms.CheckedListBox filterclan;
        private System.Windows.Forms.Label labelclan;
        private System.Windows.Forms.Label labelfrom;
        private System.Windows.Forms.CheckedListBox filterfrom;
        private System.Windows.Forms.Label labelprofession;
        private System.Windows.Forms.CheckedListBox filterprofession;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox favouritepersonpagebutton;
        private System.Windows.Forms.PictureBox clanpagebutton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox articleicon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

