﻿
namespace gachinaruto
{
    partial class NewElementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewElementForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.privetusername = new System.Windows.Forms.Label();
            this.userpicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelclan = new System.Windows.Forms.Label();
            this.labelfrom = new System.Windows.Forms.Label();
            this.labelprofession = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.characterpanel = new System.Windows.Forms.Panel();
            this.filterprofession = new System.Windows.Forms.CheckedListBox();
            this.filterfrom = new System.Windows.Forms.CheckedListBox();
            this.filterclan = new System.Windows.Forms.CheckedListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.articlepanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.characterpanel.SuspendLayout();
            this.articlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // privetusername
            // 
            this.privetusername.AutoSize = true;
            this.privetusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.privetusername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.privetusername.Location = new System.Drawing.Point(1113, 109);
            this.privetusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.privetusername.Name = "privetusername";
            this.privetusername.Size = new System.Drawing.Size(99, 25);
            this.privetusername.TabIndex = 13;
            this.privetusername.Text = "username";
            // 
            // userpicture
            // 
            this.userpicture.Image = ((System.Drawing.Image)(resources.GetObject("userpicture.Image")));
            this.userpicture.InitialImage = null;
            this.userpicture.Location = new System.Drawing.Point(1132, 38);
            this.userpicture.Margin = new System.Windows.Forms.Padding(4);
            this.userpicture.Name = "userpicture";
            this.userpicture.Size = new System.Drawing.Size(65, 67);
            this.userpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userpicture.TabIndex = 12;
            this.userpicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Персонажи",
            "Кланы",
            "Статьи"});
            this.comboBox1.Location = new System.Drawing.Point(366, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(361, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Выберите что добавить";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(367, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 22);
            this.textBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(362, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Имя:";
            // 
            // labelclan
            // 
            this.labelclan.AutoSize = true;
            this.labelclan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelclan.Location = new System.Drawing.Point(29, 4);
            this.labelclan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelclan.Name = "labelclan";
            this.labelclan.Size = new System.Drawing.Size(55, 20);
            this.labelclan.TabIndex = 20;
            this.labelclan.Text = "Клан:";
            // 
            // labelfrom
            // 
            this.labelfrom.AutoSize = true;
            this.labelfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelfrom.Location = new System.Drawing.Point(29, 119);
            this.labelfrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfrom.Name = "labelfrom";
            this.labelfrom.Size = new System.Drawing.Size(160, 20);
            this.labelfrom.TabIndex = 21;
            this.labelfrom.Text = "Принадлежность:";
            // 
            // labelprofession
            // 
            this.labelprofession.AutoSize = true;
            this.labelprofession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelprofession.Location = new System.Drawing.Point(29, 231);
            this.labelprofession.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelprofession.Name = "labelprofession";
            this.labelprofession.Size = new System.Drawing.Size(111, 20);
            this.labelprofession.TabIndex = 23;
            this.labelprofession.Text = "Профессия:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 463);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(582, 198);
            this.textBox2.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(7, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Поле с информацией:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(363, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 69);
            this.button1.TabIndex = 27;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // characterpanel
            // 
            this.characterpanel.Controls.Add(this.filterprofession);
            this.characterpanel.Controls.Add(this.filterfrom);
            this.characterpanel.Controls.Add(this.filterclan);
            this.characterpanel.Controls.Add(this.labelclan);
            this.characterpanel.Controls.Add(this.labelfrom);
            this.characterpanel.Controls.Add(this.labelprofession);
            this.characterpanel.Location = new System.Drawing.Point(629, 117);
            this.characterpanel.Name = "characterpanel";
            this.characterpanel.Size = new System.Drawing.Size(511, 358);
            this.characterpanel.TabIndex = 28;
            this.characterpanel.Visible = false;
            // 
            // filterprofession
            // 
            this.filterprofession.FormattingEnabled = true;
            this.filterprofession.Items.AddRange(new object[] {
            "Шиноби",
            "Ниндзя-отступник",
            "Ниндзя-медик",
            "Анбу",
            "Хокаге",
            "Казекаге",
            "Мизукаге",
            "Райкаге",
            "Цучикаге"});
            this.filterprofession.Location = new System.Drawing.Point(33, 254);
            this.filterprofession.Name = "filterprofession";
            this.filterprofession.Size = new System.Drawing.Size(221, 89);
            this.filterprofession.TabIndex = 27;
            // 
            // filterfrom
            // 
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
            this.filterfrom.Location = new System.Drawing.Point(33, 142);
            this.filterfrom.Name = "filterfrom";
            this.filterfrom.Size = new System.Drawing.Size(221, 89);
            this.filterfrom.TabIndex = 26;
            // 
            // filterclan
            // 
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
            this.filterclan.Location = new System.Drawing.Point(33, 27);
            this.filterclan.Name = "filterclan";
            this.filterclan.Size = new System.Drawing.Size(221, 89);
            this.filterclan.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 32);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(582, 198);
            this.textBox3.TabIndex = 29;
            this.textBox3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(11, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Второе поле с информацией:";
            this.label4.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // articlepanel
            // 
            this.articlepanel.Controls.Add(this.label4);
            this.articlepanel.Controls.Add(this.textBox3);
            this.articlepanel.Location = new System.Drawing.Point(603, 431);
            this.articlepanel.Name = "articlepanel";
            this.articlepanel.Size = new System.Drawing.Size(608, 239);
            this.articlepanel.TabIndex = 31;
            // 
            // NewElementForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.articlepanel);
            this.Controls.Add(this.characterpanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.privetusername);
            this.Controls.Add(this.userpicture);
            this.Controls.Add(this.pictureBox2);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "NewElementForm";
            this.Text = "New element page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.characterpanel.ResumeLayout(false);
            this.characterpanel.PerformLayout();
            this.articlepanel.ResumeLayout(false);
            this.articlepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label privetusername;
        private System.Windows.Forms.PictureBox userpicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelclan;
        private System.Windows.Forms.Label labelfrom;
        private System.Windows.Forms.Label labelprofession;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel characterpanel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel articlepanel;
        private System.Windows.Forms.CheckedListBox filterclan;
        private System.Windows.Forms.CheckedListBox filterfrom;
        private System.Windows.Forms.CheckedListBox filterprofession;
    }
}