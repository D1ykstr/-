namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Choose = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchName = new System.Windows.Forms.TextBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dif2 = new System.Windows.Forms.PictureBox();
            this.dif3 = new System.Windows.Forms.PictureBox();
            this.dif1 = new System.Windows.Forms.PictureBox();
            this.universal = new System.Windows.Forms.PictureBox();
            this.strenght = new System.Windows.Forms.PictureBox();
            this.agility = new System.Windows.Forms.PictureBox();
            this.intelligence = new System.Windows.Forms.PictureBox();
            this.pauseMusic = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.stopMusic = new System.Windows.Forms.PictureBox();
            this.playMusic = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dif2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dif3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dif1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // Choose
            // 
            this.Choose.AutoSize = true;
            this.Choose.BackColor = System.Drawing.Color.Transparent;
            this.Choose.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Choose.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Choose.Location = new System.Drawing.Point(340, 40);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(278, 34);
            this.Choose.TabIndex = 10;
            this.Choose.Text = "ВЫБЕРИТЕ ГЕРОЯ";
            this.Choose.Visible = false;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.info.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.info.Location = new System.Drawing.Point(70, 100);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(854, 63);
            this.info.TabIndex = 11;
            this.info.Text = resources.GetString("info.Text");
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.info.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(15, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Атрибут";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(410, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Сложность";
            this.label2.Visible = false;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(945, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 24);
            this.close.TabIndex = 22;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // searchName
            // 
            this.searchName.Location = new System.Drawing.Point(750, 200);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(100, 20);
            this.searchName.TabIndex = 24;
            this.searchName.Visible = false;
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.Transparent;
            this.buttonSort.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.сортировка;
            this.buttonSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSort.FlatAppearance.BorderSize = 0;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSort.Location = new System.Drawing.Point(910, 190);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(44, 42);
            this.buttonSort.TabIndex = 25;
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Visible = false;
            this.buttonSort.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.search;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Location = new System.Drawing.Point(856, 199);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(24, 22);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Visible = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dif2
            // 
            this.dif2.BackColor = System.Drawing.Color.Transparent;
            this.dif2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dif2.Location = new System.Drawing.Point(590, 180);
            this.dif2.Name = "dif2";
            this.dif2.Size = new System.Drawing.Size(70, 60);
            this.dif2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dif2.TabIndex = 19;
            this.dif2.TabStop = false;
            this.dif2.Visible = false;
            this.dif2.Click += new System.EventHandler(this.dif2_Click);
            // 
            // dif3
            // 
            this.dif3.BackColor = System.Drawing.Color.Transparent;
            this.dif3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dif3.Location = new System.Drawing.Point(665, 180);
            this.dif3.Name = "dif3";
            this.dif3.Size = new System.Drawing.Size(70, 60);
            this.dif3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dif3.TabIndex = 18;
            this.dif3.TabStop = false;
            this.dif3.Visible = false;
            this.dif3.Click += new System.EventHandler(this.dif3_Click);
            // 
            // dif1
            // 
            this.dif1.BackColor = System.Drawing.Color.Transparent;
            this.dif1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dif1.Location = new System.Drawing.Point(515, 180);
            this.dif1.Name = "dif1";
            this.dif1.Size = new System.Drawing.Size(70, 60);
            this.dif1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dif1.TabIndex = 17;
            this.dif1.TabStop = false;
            this.dif1.Visible = false;
            this.dif1.Click += new System.EventHandler(this.dif1_Click);
            // 
            // universal
            // 
            this.universal.BackColor = System.Drawing.Color.Transparent;
            this.universal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.universal.Location = new System.Drawing.Point(325, 180);
            this.universal.Name = "universal";
            this.universal.Size = new System.Drawing.Size(70, 60);
            this.universal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.universal.TabIndex = 16;
            this.universal.TabStop = false;
            this.universal.Visible = false;
            this.universal.Click += new System.EventHandler(this.universal_Click);
            // 
            // strenght
            // 
            this.strenght.BackColor = System.Drawing.Color.Transparent;
            this.strenght.Cursor = System.Windows.Forms.Cursors.Hand;
            this.strenght.Location = new System.Drawing.Point(100, 180);
            this.strenght.Name = "strenght";
            this.strenght.Size = new System.Drawing.Size(70, 60);
            this.strenght.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.strenght.TabIndex = 15;
            this.strenght.TabStop = false;
            this.strenght.Visible = false;
            this.strenght.Click += new System.EventHandler(this.strenght_Click);
            // 
            // agility
            // 
            this.agility.BackColor = System.Drawing.Color.Transparent;
            this.agility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agility.Location = new System.Drawing.Point(175, 180);
            this.agility.Name = "agility";
            this.agility.Size = new System.Drawing.Size(70, 60);
            this.agility.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.agility.TabIndex = 14;
            this.agility.TabStop = false;
            this.agility.Visible = false;
            this.agility.Click += new System.EventHandler(this.agility_Click);
            // 
            // intelligence
            // 
            this.intelligence.BackColor = System.Drawing.Color.Transparent;
            this.intelligence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.intelligence.Location = new System.Drawing.Point(250, 180);
            this.intelligence.Name = "intelligence";
            this.intelligence.Size = new System.Drawing.Size(70, 60);
            this.intelligence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.intelligence.TabIndex = 13;
            this.intelligence.TabStop = false;
            this.intelligence.Visible = false;
            this.intelligence.Click += new System.EventHandler(this.intelligence_Click);
            // 
            // pauseMusic
            // 
            this.pauseMusic.BackColor = System.Drawing.Color.Transparent;
            this.pauseMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pauseMusic.Image = global::WindowsFormsApp1.Properties.Resources.icons8_пауза_30;
            this.pauseMusic.Location = new System.Drawing.Point(48, 10);
            this.pauseMusic.Name = "pauseMusic";
            this.pauseMusic.Size = new System.Drawing.Size(30, 30);
            this.pauseMusic.TabIndex = 12;
            this.pauseMusic.TabStop = false;
            this.pauseMusic.Click += new System.EventHandler(this.pauseMusic_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.минус_звук;
            this.pictureBox4.Location = new System.Drawing.Point(156, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.downVolume_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.плюс_звук;
            this.pictureBox3.Location = new System.Drawing.Point(120, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.upVolume_Click);
            // 
            // stopMusic
            // 
            this.stopMusic.BackColor = System.Drawing.Color.Transparent;
            this.stopMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopMusic.Image = ((System.Drawing.Image)(resources.GetObject("stopMusic.Image")));
            this.stopMusic.Location = new System.Drawing.Point(84, 10);
            this.stopMusic.Name = "stopMusic";
            this.stopMusic.Size = new System.Drawing.Size(30, 30);
            this.stopMusic.TabIndex = 7;
            this.stopMusic.TabStop = false;
            this.stopMusic.Click += new System.EventHandler(this.stopMusic_Click);
            // 
            // playMusic
            // 
            this.playMusic.BackColor = System.Drawing.Color.Transparent;
            this.playMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playMusic.Image = global::WindowsFormsApp1.Properties.Resources.пуск;
            this.playMusic.Location = new System.Drawing.Point(12, 10);
            this.playMusic.Name = "playMusic";
            this.playMusic.Size = new System.Drawing.Size(30, 30);
            this.playMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playMusic.TabIndex = 6;
            this.playMusic.TabStop = false;
            this.playMusic.Click += new System.EventHandler(this.playMusic_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStart.BackgroundImage")));
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(300, 370);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(383, 78);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Войти";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 576);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dif2);
            this.Controls.Add(this.dif3);
            this.Controls.Add(this.dif1);
            this.Controls.Add(this.universal);
            this.Controls.Add(this.strenght);
            this.Controls.Add(this.agility);
            this.Controls.Add(this.intelligence);
            this.Controls.Add(this.pauseMusic);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Choose);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.stopMusic);
            this.Controls.Add(this.playMusic);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MD);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MV);
            ((System.ComponentModel.ISupportInitialize)(this.dif2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dif3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dif1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox playMusic;
        private System.Windows.Forms.PictureBox stopMusic;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Choose;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.PictureBox pauseMusic;
        private System.Windows.Forms.PictureBox intelligence;
        private System.Windows.Forms.PictureBox agility;
        private System.Windows.Forms.PictureBox strenght;
        private System.Windows.Forms.PictureBox universal;
        private System.Windows.Forms.PictureBox dif1;
        private System.Windows.Forms.PictureBox dif3;
        private System.Windows.Forms.PictureBox dif2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox searchName;
        private System.Windows.Forms.Button buttonSort;
    }
}

