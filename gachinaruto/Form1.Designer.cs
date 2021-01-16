
namespace gachinaruto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.herosearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.naitipersonaja = new System.Windows.Forms.Label();
            this.privetusername = new System.Windows.Forms.Label();
            this.userpicture = new System.Windows.Forms.PictureBox();
            this.filterclan = new System.Windows.Forms.CheckedListBox();
            this.labelclan = new System.Windows.Forms.Label();
            this.lablefrom = new System.Windows.Forms.Label();
            this.filterfrom = new System.Windows.Forms.CheckedListBox();
            this.labelprofession = new System.Windows.Forms.Label();
            this.filterprofession = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.narutouzumakipic = new System.Windows.Forms.PictureBox();
            this.narutouzumakilabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.narutouzumakipic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 147);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // herosearch
            // 
            this.herosearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.herosearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.herosearch.Location = new System.Drawing.Point(627, 68);
            this.herosearch.Name = "herosearch";
            this.herosearch.Size = new System.Drawing.Size(222, 49);
            this.herosearch.TabIndex = 2;
            this.herosearch.Text = "Поиск";
            this.herosearch.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(308, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 49);
            this.textBox1.TabIndex = 3;
            // 
            // naitipersonaja
            // 
            this.naitipersonaja.AutoSize = true;
            this.naitipersonaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.naitipersonaja.Location = new System.Drawing.Point(303, 31);
            this.naitipersonaja.Name = "naitipersonaja";
            this.naitipersonaja.Size = new System.Drawing.Size(195, 25);
            this.naitipersonaja.TabIndex = 4;
            this.naitipersonaja.Text = "Найти персонажа:";
            // 
            // privetusername
            // 
            this.privetusername.AutoSize = true;
            this.privetusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privetusername.Location = new System.Drawing.Point(942, 86);
            this.privetusername.Name = "privetusername";
            this.privetusername.Size = new System.Drawing.Size(197, 25);
            this.privetusername.TabIndex = 5;
            this.privetusername.Text = "Привет, username!";
            // 
            // userpicture
            // 
            this.userpicture.Image = ((System.Drawing.Image)(resources.GetObject("userpicture.Image")));
            this.userpicture.InitialImage = null;
            this.userpicture.Location = new System.Drawing.Point(1145, 25);
            this.userpicture.Name = "userpicture";
            this.userpicture.Size = new System.Drawing.Size(88, 86);
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
            "Ооцуцуки"});
            this.filterclan.Location = new System.Drawing.Point(993, 209);
            this.filterclan.Name = "filterclan";
            this.filterclan.Size = new System.Drawing.Size(240, 89);
            this.filterclan.TabIndex = 7;
            this.filterclan.SelectedIndexChanged += new System.EventHandler(this.filterclan_SelectedIndexChanged);
            // 
            // labelclan
            // 
            this.labelclan.AutoSize = true;
            this.labelclan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelclan.Location = new System.Drawing.Point(989, 186);
            this.labelclan.Name = "labelclan";
            this.labelclan.Size = new System.Drawing.Size(51, 20);
            this.labelclan.TabIndex = 8;
            this.labelclan.Text = "Клан:";
            this.labelclan.Click += new System.EventHandler(this.labelclan_Click);
            // 
            // lablefrom
            // 
            this.lablefrom.AutoSize = true;
            this.lablefrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lablefrom.Location = new System.Drawing.Point(989, 301);
            this.lablefrom.Name = "lablefrom";
            this.lablefrom.Size = new System.Drawing.Size(146, 20);
            this.lablefrom.TabIndex = 9;
            this.lablefrom.Text = "Принадлежность:";
            // 
            // filterfrom
            // 
            this.filterfrom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterfrom.FormattingEnabled = true;
            this.filterfrom.Items.AddRange(new object[] {
            "Деревня Скрытого Листа",
            "Деревня Скрытого Звука",
            "Деревня Скрытых Источников",
            "Деревня Скрытого Водопада",
            "Деревня Скрытого Дождя",
            "Акацуки"});
            this.filterfrom.Location = new System.Drawing.Point(993, 324);
            this.filterfrom.Name = "filterfrom";
            this.filterfrom.Size = new System.Drawing.Size(240, 89);
            this.filterfrom.TabIndex = 10;
            // 
            // labelprofession
            // 
            this.labelprofession.AutoSize = true;
            this.labelprofession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelprofession.Location = new System.Drawing.Point(989, 416);
            this.labelprofession.Name = "labelprofession";
            this.labelprofession.Size = new System.Drawing.Size(101, 20);
            this.labelprofession.TabIndex = 11;
            this.labelprofession.Text = "Профессия:";
            // 
            // filterprofession
            // 
            this.filterprofession.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterprofession.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterprofession.FormattingEnabled = true;
            this.filterprofession.Items.AddRange(new object[] {
            "Хокаге",
            "Казекаге",
            "Мизукаге",
            "Райкаге",
            "Цучикаге",
            "Чунин",
            "Генин",
            "Джоунин",
            "Специальный Джоунин"});
            this.filterprofession.Location = new System.Drawing.Point(993, 439);
            this.filterprofession.Name = "filterprofession";
            this.filterprofession.Size = new System.Drawing.Size(240, 89);
            this.filterprofession.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel1.Location = new System.Drawing.Point(6, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 505);
            this.panel1.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(670, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 293);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox3.Size = new System.Drawing.Size(273, 271);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Какаши Хатаке";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(350, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 293);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(273, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Саске Учиха";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.narutouzumakipic);
            this.panel2.Controls.Add(this.narutouzumakilabel);
            this.panel2.Location = new System.Drawing.Point(30, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 293);
            this.panel2.TabIndex = 2;
            // 
            // narutouzumakipic
            // 
            this.narutouzumakipic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.narutouzumakipic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.narutouzumakipic.Image = ((System.Drawing.Image)(resources.GetObject("narutouzumakipic.Image")));
            this.narutouzumakipic.Location = new System.Drawing.Point(0, 0);
            this.narutouzumakipic.Name = "narutouzumakipic";
            this.narutouzumakipic.Padding = new System.Windows.Forms.Padding(3);
            this.narutouzumakipic.Size = new System.Drawing.Size(273, 271);
            this.narutouzumakipic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.narutouzumakipic.TabIndex = 0;
            this.narutouzumakipic.TabStop = false;
            // 
            // narutouzumakilabel
            // 
            this.narutouzumakilabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.narutouzumakilabel.Location = new System.Drawing.Point(0, 271);
            this.narutouzumakilabel.Name = "narutouzumakilabel";
            this.narutouzumakilabel.Size = new System.Drawing.Size(273, 20);
            this.narutouzumakilabel.TabIndex = 1;
            this.narutouzumakilabel.Text = "Наруто Узумаки";
            this.narutouzumakilabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.narutouzumakilabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(993, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.filterprofession);
            this.Controls.Add(this.labelprofession);
            this.Controls.Add(this.filterfrom);
            this.Controls.Add(this.lablefrom);
            this.Controls.Add(this.labelclan);
            this.Controls.Add(this.filterclan);
            this.Controls.Add(this.userpicture);
            this.Controls.Add(this.privetusername);
            this.Controls.Add(this.naitipersonaja);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.herosearch);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "mainpage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.narutouzumakipic)).EndInit();
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
        private System.Windows.Forms.Label lablefrom;
        private System.Windows.Forms.CheckedListBox filterfrom;
        private System.Windows.Forms.Label labelprofession;
        private System.Windows.Forms.CheckedListBox filterprofession;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label narutouzumakilabel;
        private System.Windows.Forms.PictureBox narutouzumakipic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

