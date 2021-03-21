
namespace gachinaruto
{
    partial class FavouriteCharactersPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavouriteCharactersPage));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.privetusername = new System.Windows.Forms.Label();
            this.userpicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, 0);
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
            this.privetusername.Location = new System.Drawing.Point(1089, 117);
            this.privetusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.privetusername.Name = "privetusername";
            this.privetusername.Size = new System.Drawing.Size(80, 20);
            this.privetusername.TabIndex = 10;
            this.privetusername.Text = "username";
            // 
            // userpicture
            // 
            this.userpicture.Image = ((System.Drawing.Image)(resources.GetObject("userpicture.Image")));
            this.userpicture.InitialImage = null;
            this.userpicture.Location = new System.Drawing.Point(1093, 38);
            this.userpicture.Margin = new System.Windows.Forms.Padding(4);
            this.userpicture.Name = "userpicture";
            this.userpicture.Size = new System.Drawing.Size(75, 75);
            this.userpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userpicture.TabIndex = 9;
            this.userpicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(269, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Любимые персонажи:";
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
            this.panel1.TabIndex = 14;
            // 
            // FavouriteCharactersPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.privetusername);
            this.Controls.Add(this.userpicture);
            this.Controls.Add(this.pictureBox2);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FavouriteCharactersPage";
            this.Text = "Favourite characters page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label privetusername;
        private System.Windows.Forms.PictureBox userpicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}