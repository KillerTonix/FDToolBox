namespace FDToolBox
{
    partial class FDToolBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDToolBox));
            this.header = new System.Windows.Forms.Panel();
            this.Name_l = new System.Windows.Forms.Label();
            this.close_btn = new FDUni.buttons();
            this.minimaze_btn = new FDUni.buttons();
            this.checkin_header = new System.Windows.Forms.Panel();
            this.autro_checkBox = new System.Windows.Forms.CheckBox();
            this.intro2_checkBox = new System.Windows.Forms.CheckBox();
            this.intro_checkBox = new System.Windows.Forms.CheckBox();
            this.logo_checkBox = new System.Windows.Forms.CheckBox();
            this.audio_checkBox = new System.Windows.Forms.CheckBox();
            this.sub_checkBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sub_pic = new System.Windows.Forms.PictureBox();
            this.logo_pic = new System.Windows.Forms.PictureBox();
            this.audio_pic = new System.Windows.Forms.PictureBox();
            this.outro_pic = new System.Windows.Forms.PictureBox();
            this.intro_pic = new System.Windows.Forms.PictureBox();
            this.intro2_pic = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.logo_sett_pic = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.shakal = new System.Windows.Forms.CheckBox();
            this.after_exit = new System.Windows.Forms.CheckBox();
            this.shakal_img = new System.Windows.Forms.PictureBox();
            this.CPU = new System.Windows.Forms.RadioButton();
            this.NVIDIA = new System.Windows.Forms.RadioButton();
            this.AMD = new System.Windows.Forms.RadioButton();
            this.upper_left = new System.Windows.Forms.RadioButton();
            this.lower_left = new System.Windows.Forms.RadioButton();
            this.lower_right = new System.Windows.Forms.RadioButton();
            this.upper_right = new System.Windows.Forms.RadioButton();
            this.logo_border = new System.Windows.Forms.GroupBox();
            this.video_bitrate = new System.Windows.Forms.ListBox();
            this.audio_bitrate = new System.Windows.Forms.ListBox();
            this.label_sub = new System.Windows.Forms.Label();
            this.label_sourec_video = new System.Windows.Forms.Label();
            this.label_logo = new System.Windows.Forms.Label();
            this.label_intro = new System.Windows.Forms.Label();
            this.label_audio = new System.Windows.Forms.Label();
            this.label_intro2 = new System.Windows.Forms.Label();
            this.label_outro = new System.Windows.Forms.Label();
            this.dir_working = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.logo_size = new System.Windows.Forms.TextBox();
            this.logo_indet = new System.Windows.Forms.TextBox();
            this.logo_transparency = new System.Windows.Forms.TextBox();
            this.count_vag = new System.Windows.Forms.TextBox();
            this.buttons1 = new FDUni.buttons();
            this.set_workdir_btn = new FDUni.buttons();
            this.add_outro_btn = new FDUni.buttons();
            this.add_intro2_btn = new FDUni.buttons();
            this.add_intro_btn = new FDUni.buttons();
            this.add_logo_btn = new FDUni.buttons();
            this.add_audio_btn = new FDUni.buttons();
            this.add_subtitles_btn = new FDUni.buttons();
            this.add_source_btn = new FDUni.buttons();
            this.start_btn = new FDUni.buttons();
            this.logo_rem = new System.Windows.Forms.CheckBox();
            this.intro_rem = new System.Windows.Forms.CheckBox();
            this.intro2_rem = new System.Windows.Forms.CheckBox();
            this.outro_rem = new System.Windows.Forms.CheckBox();
            this.work_dri_rem = new System.Windows.Forms.CheckBox();
            this.header.SuspendLayout();
            this.checkin_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audio_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outro_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intro_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intro2_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_sett_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shakal_img)).BeginInit();
            this.logo_border.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.header.Controls.Add(this.Name_l);
            this.header.Controls.Add(this.close_btn);
            this.header.Controls.Add(this.minimaze_btn);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(900, 30);
            this.header.TabIndex = 0;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.header_MouseUp);
            // 
            // Name_l
            // 
            this.Name_l.AutoSize = true;
            this.Name_l.Font = new System.Drawing.Font("a_MachinaNova", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_l.Location = new System.Drawing.Point(3, 2);
            this.Name_l.Name = "Name_l";
            this.Name_l.Size = new System.Drawing.Size(95, 25);
            this.Name_l.TabIndex = 3;
            this.Name_l.Text = "FDToolBox";
            this.Name_l.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Name_MouseDown);
            this.Name_l.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Name_MouseMove);
            this.Name_l.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Name_MouseUp);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.close_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.close_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.close_btn.BorderRadius = 10;
            this.close_btn.BorderSize = 1;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("a_MachinaNova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.close_btn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.close_btn.Location = new System.Drawing.Point(864, 3);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(24, 24);
            this.close_btn.TabIndex = 2;
            this.close_btn.Text = "X";
            this.close_btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // minimaze_btn
            // 
            this.minimaze_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.minimaze_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.minimaze_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.minimaze_btn.BorderRadius = 10;
            this.minimaze_btn.BorderSize = 1;
            this.minimaze_btn.FlatAppearance.BorderSize = 0;
            this.minimaze_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimaze_btn.Font = new System.Drawing.Font("a_MachinaNova", 14.25F);
            this.minimaze_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.minimaze_btn.Location = new System.Drawing.Point(834, 3);
            this.minimaze_btn.Name = "minimaze_btn";
            this.minimaze_btn.Size = new System.Drawing.Size(24, 24);
            this.minimaze_btn.TabIndex = 1;
            this.minimaze_btn.Text = "~";
            this.minimaze_btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.minimaze_btn.UseVisualStyleBackColor = false;
            this.minimaze_btn.Click += new System.EventHandler(this.minimaze_btn_Click);
            // 
            // checkin_header
            // 
            this.checkin_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(231)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.checkin_header.Controls.Add(this.autro_checkBox);
            this.checkin_header.Controls.Add(this.intro2_checkBox);
            this.checkin_header.Controls.Add(this.intro_checkBox);
            this.checkin_header.Controls.Add(this.logo_checkBox);
            this.checkin_header.Controls.Add(this.audio_checkBox);
            this.checkin_header.Controls.Add(this.sub_checkBox);
            this.checkin_header.Location = new System.Drawing.Point(0, 30);
            this.checkin_header.Name = "checkin_header";
            this.checkin_header.Size = new System.Drawing.Size(900, 30);
            this.checkin_header.TabIndex = 1;
            // 
            // autro_checkBox
            // 
            this.autro_checkBox.AutoSize = true;
            this.autro_checkBox.BackColor = System.Drawing.Color.Transparent;
            this.autro_checkBox.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autro_checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.autro_checkBox.Location = new System.Drawing.Point(622, 5);
            this.autro_checkBox.Name = "autro_checkBox";
            this.autro_checkBox.Size = new System.Drawing.Size(106, 20);
            this.autro_checkBox.TabIndex = 7;
            this.autro_checkBox.Text = "Добавить Аутро";
            this.autro_checkBox.UseVisualStyleBackColor = false;
            this.autro_checkBox.CheckedChanged += new System.EventHandler(this.autro_checkBox_CheckedChanged);
            // 
            // intro2_checkBox
            // 
            this.intro2_checkBox.AutoSize = true;
            this.intro2_checkBox.BackColor = System.Drawing.Color.Transparent;
            this.intro2_checkBox.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intro2_checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.intro2_checkBox.Location = new System.Drawing.Point(120, 5);
            this.intro2_checkBox.Name = "intro2_checkBox";
            this.intro2_checkBox.Size = new System.Drawing.Size(143, 20);
            this.intro2_checkBox.TabIndex = 6;
            this.intro2_checkBox.Text = "Добавить Второе Интро";
            this.intro2_checkBox.UseVisualStyleBackColor = false;
            this.intro2_checkBox.CheckedChanged += new System.EventHandler(this.intro2_checkBox_CheckedChanged);
            // 
            // intro_checkBox
            // 
            this.intro_checkBox.AutoSize = true;
            this.intro_checkBox.BackColor = System.Drawing.Color.Transparent;
            this.intro_checkBox.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intro_checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.intro_checkBox.Location = new System.Drawing.Point(8, 5);
            this.intro_checkBox.Name = "intro_checkBox";
            this.intro_checkBox.Size = new System.Drawing.Size(106, 20);
            this.intro_checkBox.TabIndex = 5;
            this.intro_checkBox.Text = "Добавить Интро";
            this.intro_checkBox.UseVisualStyleBackColor = false;
            this.intro_checkBox.CheckedChanged += new System.EventHandler(this.intro_checkBox_CheckedChanged);
            // 
            // logo_checkBox
            // 
            this.logo_checkBox.AutoSize = true;
            this.logo_checkBox.BackColor = System.Drawing.Color.Transparent;
            this.logo_checkBox.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logo_checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.logo_checkBox.Location = new System.Drawing.Point(269, 5);
            this.logo_checkBox.Name = "logo_checkBox";
            this.logo_checkBox.Size = new System.Drawing.Size(100, 20);
            this.logo_checkBox.TabIndex = 4;
            this.logo_checkBox.Text = "Добавить Лого";
            this.logo_checkBox.UseVisualStyleBackColor = false;
            this.logo_checkBox.CheckedChanged += new System.EventHandler(this.logo_checkBox_CheckedChanged);
            // 
            // audio_checkBox
            // 
            this.audio_checkBox.AutoSize = true;
            this.audio_checkBox.BackColor = System.Drawing.Color.Transparent;
            this.audio_checkBox.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.audio_checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.audio_checkBox.Location = new System.Drawing.Point(504, 5);
            this.audio_checkBox.Name = "audio_checkBox";
            this.audio_checkBox.Size = new System.Drawing.Size(108, 20);
            this.audio_checkBox.TabIndex = 3;
            this.audio_checkBox.Text = "Заменить Аудио";
            this.audio_checkBox.UseVisualStyleBackColor = false;
            this.audio_checkBox.CheckedChanged += new System.EventHandler(this.audio_checkBox_CheckedChanged);
            // 
            // sub_checkBox
            // 
            this.sub_checkBox.AutoSize = true;
            this.sub_checkBox.BackColor = System.Drawing.Color.Transparent;
            this.sub_checkBox.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sub_checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.sub_checkBox.Location = new System.Drawing.Point(375, 5);
            this.sub_checkBox.Name = "sub_checkBox";
            this.sub_checkBox.Size = new System.Drawing.Size(126, 20);
            this.sub_checkBox.TabIndex = 2;
            this.sub_checkBox.Text = "Добавить Субтитры";
            this.sub_checkBox.UseVisualStyleBackColor = false;
            this.sub_checkBox.CheckedChanged += new System.EventHandler(this.sub_checkBox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FDToolBox.Properties.Resources.isxodnih_video_fail;
            this.pictureBox1.Location = new System.Drawing.Point(10, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // sub_pic
            // 
            this.sub_pic.Image = global::FDToolBox.Properties.Resources.dobavit_subtitri;
            this.sub_pic.Location = new System.Drawing.Point(10, 128);
            this.sub_pic.Name = "sub_pic";
            this.sub_pic.Size = new System.Drawing.Size(435, 51);
            this.sub_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sub_pic.TabIndex = 3;
            this.sub_pic.TabStop = false;
            this.sub_pic.Visible = false;
            // 
            // logo_pic
            // 
            this.logo_pic.Image = global::FDToolBox.Properties.Resources.dobavit_logo;
            this.logo_pic.Location = new System.Drawing.Point(10, 250);
            this.logo_pic.Name = "logo_pic";
            this.logo_pic.Size = new System.Drawing.Size(435, 64);
            this.logo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo_pic.TabIndex = 5;
            this.logo_pic.TabStop = false;
            this.logo_pic.Visible = false;
            // 
            // audio_pic
            // 
            this.audio_pic.Image = global::FDToolBox.Properties.Resources.dobavit_audio;
            this.audio_pic.Location = new System.Drawing.Point(10, 188);
            this.audio_pic.Name = "audio_pic";
            this.audio_pic.Size = new System.Drawing.Size(435, 51);
            this.audio_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.audio_pic.TabIndex = 4;
            this.audio_pic.TabStop = false;
            this.audio_pic.Visible = false;
            // 
            // outro_pic
            // 
            this.outro_pic.Image = global::FDToolBox.Properties.Resources.dobavit_outro;
            this.outro_pic.Location = new System.Drawing.Point(10, 460);
            this.outro_pic.Name = "outro_pic";
            this.outro_pic.Size = new System.Drawing.Size(435, 64);
            this.outro_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.outro_pic.TabIndex = 7;
            this.outro_pic.TabStop = false;
            this.outro_pic.Visible = false;
            // 
            // intro_pic
            // 
            this.intro_pic.Image = global::FDToolBox.Properties.Resources.dobavit_intro;
            this.intro_pic.Location = new System.Drawing.Point(10, 320);
            this.intro_pic.Name = "intro_pic";
            this.intro_pic.Size = new System.Drawing.Size(435, 64);
            this.intro_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.intro_pic.TabIndex = 6;
            this.intro_pic.TabStop = false;
            this.intro_pic.Visible = false;
            // 
            // intro2_pic
            // 
            this.intro2_pic.Image = global::FDToolBox.Properties.Resources.dobavit_vtoroe_intro;
            this.intro2_pic.Location = new System.Drawing.Point(10, 390);
            this.intro2_pic.Name = "intro2_pic";
            this.intro2_pic.Size = new System.Drawing.Size(435, 64);
            this.intro2_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.intro2_pic.TabIndex = 8;
            this.intro2_pic.TabStop = false;
            this.intro2_pic.Visible = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::FDToolBox.Properties.Resources.vihodnaya_papka;
            this.pictureBox8.Location = new System.Drawing.Point(504, 67);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(384, 110);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            // 
            // logo_sett_pic
            // 
            this.logo_sett_pic.Image = global::FDToolBox.Properties.Resources.logo_settings;
            this.logo_sett_pic.Location = new System.Drawing.Point(504, 188);
            this.logo_sett_pic.Margin = new System.Windows.Forms.Padding(10);
            this.logo_sett_pic.Name = "logo_sett_pic";
            this.logo_sett_pic.Size = new System.Drawing.Size(384, 129);
            this.logo_sett_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo_sett_pic.TabIndex = 10;
            this.logo_sett_pic.TabStop = false;
            this.logo_sett_pic.Visible = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::FDToolBox.Properties.Resources.vixodnie_nastroiki;
            this.pictureBox10.Location = new System.Drawing.Point(504, 320);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(384, 141);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 11;
            this.pictureBox10.TabStop = false;
            // 
            // shakal
            // 
            this.shakal.AutoSize = true;
            this.shakal.BackColor = System.Drawing.Color.Transparent;
            this.shakal.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shakal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.shakal.Location = new System.Drawing.Point(820, 478);
            this.shakal.Name = "shakal";
            this.shakal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.shakal.Size = new System.Drawing.Size(68, 20);
            this.shakal.TabIndex = 9;
            this.shakal.Text = "Шакалы";
            this.shakal.UseVisualStyleBackColor = false;
            this.shakal.CheckedChanged += new System.EventHandler(this.shakal_CheckedChanged);
            // 
            // after_exit
            // 
            this.after_exit.AutoSize = true;
            this.after_exit.BackColor = System.Drawing.Color.Transparent;
            this.after_exit.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.after_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.after_exit.Location = new System.Drawing.Point(622, 504);
            this.after_exit.Name = "after_exit";
            this.after_exit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.after_exit.Size = new System.Drawing.Size(266, 20);
            this.after_exit.TabIndex = 8;
            this.after_exit.Text = "Закрыть программу после завершение работы";
            this.after_exit.UseVisualStyleBackColor = false;
            // 
            // shakal_img
            // 
            this.shakal_img.Image = global::FDToolBox.Properties.Resources.shakal;
            this.shakal_img.Location = new System.Drawing.Point(799, 367);
            this.shakal_img.Name = "shakal_img";
            this.shakal_img.Size = new System.Drawing.Size(77, 73);
            this.shakal_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shakal_img.TabIndex = 13;
            this.shakal_img.TabStop = false;
            this.shakal_img.Visible = false;
            // 
            // CPU
            // 
            this.CPU.AutoSize = true;
            this.CPU.Checked = true;
            this.CPU.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.CPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.CPU.Location = new System.Drawing.Point(696, 364);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(43, 20);
            this.CPU.TabIndex = 14;
            this.CPU.TabStop = true;
            this.CPU.Text = "CPU";
            this.CPU.UseVisualStyleBackColor = true;
            this.CPU.CheckedChanged += new System.EventHandler(this.CPU_CheckedChanged);
            // 
            // NVIDIA
            // 
            this.NVIDIA.AutoSize = true;
            this.NVIDIA.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.NVIDIA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.NVIDIA.Location = new System.Drawing.Point(696, 396);
            this.NVIDIA.Name = "NVIDIA";
            this.NVIDIA.Size = new System.Drawing.Size(95, 20);
            this.NVIDIA.TabIndex = 15;
            this.NVIDIA.Text = "Nvidia (Nvenc)";
            this.NVIDIA.UseVisualStyleBackColor = true;
            this.NVIDIA.CheckedChanged += new System.EventHandler(this.NVIDIA_CheckedChanged);
            // 
            // AMD
            // 
            this.AMD.AutoSize = true;
            this.AMD.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.AMD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.AMD.Location = new System.Drawing.Point(696, 429);
            this.AMD.Name = "AMD";
            this.AMD.Size = new System.Drawing.Size(75, 20);
            this.AMD.TabIndex = 16;
            this.AMD.Text = "AMD (AMF)";
            this.AMD.UseVisualStyleBackColor = true;
            this.AMD.CheckedChanged += new System.EventHandler(this.AMD_CheckedChanged);
            // 
            // upper_left
            // 
            this.upper_left.AutoSize = true;
            this.upper_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.upper_left.Checked = true;
            this.upper_left.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.upper_left.ForeColor = System.Drawing.Color.Black;
            this.upper_left.Location = new System.Drawing.Point(6, 1);
            this.upper_left.Name = "upper_left";
            this.upper_left.Size = new System.Drawing.Size(127, 20);
            this.upper_left.TabIndex = 26;
            this.upper_left.TabStop = true;
            this.upper_left.Text = "лвеый верхний угол";
            this.upper_left.UseVisualStyleBackColor = false;
            this.upper_left.CheckedChanged += new System.EventHandler(this.upper_left_CheckedChanged);
            // 
            // lower_left
            // 
            this.lower_left.AutoSize = true;
            this.lower_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lower_left.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.lower_left.ForeColor = System.Drawing.Color.Black;
            this.lower_left.Location = new System.Drawing.Point(7, 25);
            this.lower_left.Name = "lower_left";
            this.lower_left.Size = new System.Drawing.Size(126, 20);
            this.lower_left.TabIndex = 27;
            this.lower_left.Text = "лвеый нижний угол";
            this.lower_left.UseVisualStyleBackColor = false;
            this.lower_left.CheckedChanged += new System.EventHandler(this.lower_left_CheckedChanged);
            // 
            // lower_right
            // 
            this.lower_right.AutoSize = true;
            this.lower_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lower_right.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.lower_right.ForeColor = System.Drawing.Color.Black;
            this.lower_right.Location = new System.Drawing.Point(157, 25);
            this.lower_right.Name = "lower_right";
            this.lower_right.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lower_right.Size = new System.Drawing.Size(133, 20);
            this.lower_right.TabIndex = 29;
            this.lower_right.Text = "правый нижний угол";
            this.lower_right.UseVisualStyleBackColor = false;
            this.lower_right.CheckedChanged += new System.EventHandler(this.lower_right_CheckedChanged);
            // 
            // upper_right
            // 
            this.upper_right.AutoSize = true;
            this.upper_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.upper_right.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.upper_right.ForeColor = System.Drawing.Color.Black;
            this.upper_right.Location = new System.Drawing.Point(156, 0);
            this.upper_right.Name = "upper_right";
            this.upper_right.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.upper_right.Size = new System.Drawing.Size(134, 20);
            this.upper_right.TabIndex = 28;
            this.upper_right.Text = "правый верхний угол";
            this.upper_right.UseVisualStyleBackColor = false;
            this.upper_right.CheckedChanged += new System.EventHandler(this.upper_right_CheckedChanged);
            // 
            // logo_border
            // 
            this.logo_border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.logo_border.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo_border.Controls.Add(this.upper_left);
            this.logo_border.Controls.Add(this.lower_right);
            this.logo_border.Controls.Add(this.upper_right);
            this.logo_border.Controls.Add(this.lower_left);
            this.logo_border.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logo_border.Location = new System.Drawing.Point(545, 260);
            this.logo_border.Name = "logo_border";
            this.logo_border.Size = new System.Drawing.Size(297, 45);
            this.logo_border.TabIndex = 30;
            this.logo_border.TabStop = false;
            this.logo_border.Visible = false;
            // 
            // video_bitrate
            // 
            this.video_bitrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.video_bitrate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.video_bitrate.Font = new System.Drawing.Font("a_MachinaNova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.video_bitrate.FormattingEnabled = true;
            this.video_bitrate.ItemHeight = 22;
            this.video_bitrate.Items.AddRange(new object[] {
            "1500k ",
            "2500k ",
            "3500k ",
            "4500k ",
            "5500k ",
            "6500k "});
            this.video_bitrate.Location = new System.Drawing.Point(539, 379);
            this.video_bitrate.Name = "video_bitrate";
            this.video_bitrate.Size = new System.Drawing.Size(64, 22);
            this.video_bitrate.TabIndex = 32;
            // 
            // audio_bitrate
            // 
            this.audio_bitrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.audio_bitrate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.audio_bitrate.Font = new System.Drawing.Font("a_MachinaNova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.audio_bitrate.FormattingEnabled = true;
            this.audio_bitrate.ItemHeight = 22;
            this.audio_bitrate.Items.AddRange(new object[] {
            "128k ",
            "192k ",
            "256k ",
            "320k "});
            this.audio_bitrate.Location = new System.Drawing.Point(539, 427);
            this.audio_bitrate.Name = "audio_bitrate";
            this.audio_bitrate.Size = new System.Drawing.Size(64, 22);
            this.audio_bitrate.TabIndex = 33;
            // 
            // label_sub
            // 
            this.label_sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label_sub.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.label_sub.ForeColor = System.Drawing.Color.DimGray;
            this.label_sub.Location = new System.Drawing.Point(25, 148);
            this.label_sub.Name = "label_sub";
            this.label_sub.Size = new System.Drawing.Size(310, 18);
            this.label_sub.TabIndex = 34;
            this.label_sub.Visible = false;
            // 
            // label_sourec_video
            // 
            this.label_sourec_video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label_sourec_video.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.label_sourec_video.ForeColor = System.Drawing.Color.DimGray;
            this.label_sourec_video.Location = new System.Drawing.Point(25, 87);
            this.label_sourec_video.Name = "label_sourec_video";
            this.label_sourec_video.Size = new System.Drawing.Size(310, 18);
            this.label_sourec_video.TabIndex = 35;
            // 
            // label_logo
            // 
            this.label_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label_logo.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.label_logo.ForeColor = System.Drawing.Color.DimGray;
            this.label_logo.Location = new System.Drawing.Point(25, 270);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(310, 18);
            this.label_logo.TabIndex = 37;
            this.label_logo.Visible = false;
            // 
            // label_intro
            // 
            this.label_intro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label_intro.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.label_intro.ForeColor = System.Drawing.Color.DimGray;
            this.label_intro.Location = new System.Drawing.Point(25, 340);
            this.label_intro.Name = "label_intro";
            this.label_intro.Size = new System.Drawing.Size(310, 18);
            this.label_intro.TabIndex = 36;
            this.label_intro.Visible = false;
            // 
            // label_audio
            // 
            this.label_audio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label_audio.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.label_audio.ForeColor = System.Drawing.Color.DimGray;
            this.label_audio.Location = new System.Drawing.Point(25, 208);
            this.label_audio.Name = "label_audio";
            this.label_audio.Size = new System.Drawing.Size(310, 18);
            this.label_audio.TabIndex = 38;
            this.label_audio.Visible = false;
            // 
            // label_intro2
            // 
            this.label_intro2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label_intro2.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.label_intro2.ForeColor = System.Drawing.Color.DimGray;
            this.label_intro2.Location = new System.Drawing.Point(25, 410);
            this.label_intro2.Name = "label_intro2";
            this.label_intro2.Size = new System.Drawing.Size(310, 18);
            this.label_intro2.TabIndex = 40;
            this.label_intro2.Visible = false;
            // 
            // label_outro
            // 
            this.label_outro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label_outro.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.label_outro.ForeColor = System.Drawing.Color.DimGray;
            this.label_outro.Location = new System.Drawing.Point(25, 480);
            this.label_outro.Name = "label_outro";
            this.label_outro.Size = new System.Drawing.Size(310, 18);
            this.label_outro.TabIndex = 39;
            this.label_outro.Visible = false;
            // 
            // dir_working
            // 
            this.dir_working.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dir_working.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.dir_working.ForeColor = System.Drawing.Color.DimGray;
            this.dir_working.Location = new System.Drawing.Point(521, 87);
            this.dir_working.Name = "dir_working";
            this.dir_working.Size = new System.Drawing.Size(280, 18);
            this.dir_working.TabIndex = 41;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(522, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 16);
            this.textBox1.TabIndex = 42;
            this.textBox1.Text = "Название выходного файла";
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // logo_size
            // 
            this.logo_size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.logo_size.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logo_size.Font = new System.Drawing.Font("a_MachinaNova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logo_size.Location = new System.Drawing.Point(537, 208);
            this.logo_size.Name = "logo_size";
            this.logo_size.Size = new System.Drawing.Size(85, 22);
            this.logo_size.TabIndex = 43;
            this.logo_size.Tag = "";
            this.logo_size.Text = "120";
            this.logo_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logo_size.Visible = false;
            this.logo_size.TextChanged += new System.EventHandler(this.logo_size_TextChanged);
            this.logo_size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.logo_size_KeyPress);
            // 
            // logo_indet
            // 
            this.logo_indet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.logo_indet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logo_indet.Font = new System.Drawing.Font("a_MachinaNova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logo_indet.Location = new System.Drawing.Point(655, 208);
            this.logo_indet.Name = "logo_indet";
            this.logo_indet.Size = new System.Drawing.Size(85, 22);
            this.logo_indet.TabIndex = 44;
            this.logo_indet.Text = "10";
            this.logo_indet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logo_indet.Visible = false;
            this.logo_indet.TextChanged += new System.EventHandler(this.logo_indet_TextChanged);
            this.logo_indet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.logo_indet_KeyPress);
            // 
            // logo_transparency
            // 
            this.logo_transparency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.logo_transparency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logo_transparency.Font = new System.Drawing.Font("a_MachinaNova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logo_transparency.Location = new System.Drawing.Point(772, 209);
            this.logo_transparency.Name = "logo_transparency";
            this.logo_transparency.Size = new System.Drawing.Size(85, 22);
            this.logo_transparency.TabIndex = 45;
            this.logo_transparency.Text = "50";
            this.logo_transparency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logo_transparency.Visible = false;
            this.logo_transparency.TextChanged += new System.EventHandler(this.logo_transparency_TextChanged);
            this.logo_transparency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.logo_transparency_KeyPress);
            // 
            // count_vag
            // 
            this.count_vag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.count_vag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.count_vag.Font = new System.Drawing.Font("a_MachinaNova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_vag.Location = new System.Drawing.Point(803, 596);
            this.count_vag.Name = "count_vag";
            this.count_vag.Size = new System.Drawing.Size(85, 22);
            this.count_vag.TabIndex = 46;
            this.count_vag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttons1
            // 
            this.buttons1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.buttons1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.buttons1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttons1.BorderRadius = 13;
            this.buttons1.BorderSize = 0;
            this.buttons1.FlatAppearance.BorderSize = 0;
            this.buttons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons1.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.buttons1.ForeColor = System.Drawing.Color.Black;
            this.buttons1.Location = new System.Drawing.Point(713, 593);
            this.buttons1.Name = "buttons1";
            this.buttons1.Size = new System.Drawing.Size(78, 25);
            this.buttons1.TabIndex = 47;
            this.buttons1.Text = "Добавить";
            this.buttons1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttons1.TextColor = System.Drawing.Color.Black;
            this.buttons1.UseVisualStyleBackColor = false;
            // 
            // set_workdir_btn
            // 
            this.set_workdir_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.set_workdir_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.set_workdir_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.set_workdir_btn.BorderRadius = 13;
            this.set_workdir_btn.BorderSize = 0;
            this.set_workdir_btn.FlatAppearance.BorderSize = 0;
            this.set_workdir_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_workdir_btn.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.set_workdir_btn.ForeColor = System.Drawing.Color.Black;
            this.set_workdir_btn.Location = new System.Drawing.Point(820, 83);
            this.set_workdir_btn.Name = "set_workdir_btn";
            this.set_workdir_btn.Size = new System.Drawing.Size(57, 25);
            this.set_workdir_btn.TabIndex = 25;
            this.set_workdir_btn.Text = "Указать";
            this.set_workdir_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.set_workdir_btn.TextColor = System.Drawing.Color.Black;
            this.set_workdir_btn.UseVisualStyleBackColor = false;
            this.set_workdir_btn.Click += new System.EventHandler(this.set_workdir_btn_Click);
            // 
            // add_outro_btn
            // 
            this.add_outro_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.add_outro_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.add_outro_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.add_outro_btn.BorderRadius = 13;
            this.add_outro_btn.BorderSize = 0;
            this.add_outro_btn.FlatAppearance.BorderSize = 0;
            this.add_outro_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_outro_btn.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.add_outro_btn.ForeColor = System.Drawing.Color.Black;
            this.add_outro_btn.Location = new System.Drawing.Point(355, 476);
            this.add_outro_btn.Name = "add_outro_btn";
            this.add_outro_btn.Size = new System.Drawing.Size(78, 25);
            this.add_outro_btn.TabIndex = 24;
            this.add_outro_btn.Text = "Добавить";
            this.add_outro_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_outro_btn.TextColor = System.Drawing.Color.Black;
            this.add_outro_btn.UseVisualStyleBackColor = false;
            this.add_outro_btn.Visible = false;
            this.add_outro_btn.Click += new System.EventHandler(this.add_outro_btn_Click);
            // 
            // add_intro2_btn
            // 
            this.add_intro2_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.add_intro2_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.add_intro2_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.add_intro2_btn.BorderRadius = 13;
            this.add_intro2_btn.BorderSize = 0;
            this.add_intro2_btn.FlatAppearance.BorderSize = 0;
            this.add_intro2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_intro2_btn.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.add_intro2_btn.ForeColor = System.Drawing.Color.Black;
            this.add_intro2_btn.Location = new System.Drawing.Point(355, 406);
            this.add_intro2_btn.Name = "add_intro2_btn";
            this.add_intro2_btn.Size = new System.Drawing.Size(78, 25);
            this.add_intro2_btn.TabIndex = 23;
            this.add_intro2_btn.Text = "Добавить";
            this.add_intro2_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_intro2_btn.TextColor = System.Drawing.Color.Black;
            this.add_intro2_btn.UseVisualStyleBackColor = false;
            this.add_intro2_btn.Visible = false;
            this.add_intro2_btn.Click += new System.EventHandler(this.add_intro2_btn_Click);
            // 
            // add_intro_btn
            // 
            this.add_intro_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.add_intro_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.add_intro_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.add_intro_btn.BorderRadius = 13;
            this.add_intro_btn.BorderSize = 0;
            this.add_intro_btn.FlatAppearance.BorderSize = 0;
            this.add_intro_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_intro_btn.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.add_intro_btn.ForeColor = System.Drawing.Color.Black;
            this.add_intro_btn.Location = new System.Drawing.Point(355, 336);
            this.add_intro_btn.Name = "add_intro_btn";
            this.add_intro_btn.Size = new System.Drawing.Size(78, 25);
            this.add_intro_btn.TabIndex = 22;
            this.add_intro_btn.Text = "Добавить";
            this.add_intro_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_intro_btn.TextColor = System.Drawing.Color.Black;
            this.add_intro_btn.UseVisualStyleBackColor = false;
            this.add_intro_btn.Visible = false;
            this.add_intro_btn.Click += new System.EventHandler(this.add_intro_btn_Click);
            // 
            // add_logo_btn
            // 
            this.add_logo_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.add_logo_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.add_logo_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.add_logo_btn.BorderRadius = 13;
            this.add_logo_btn.BorderSize = 0;
            this.add_logo_btn.FlatAppearance.BorderSize = 0;
            this.add_logo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_logo_btn.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.add_logo_btn.ForeColor = System.Drawing.Color.Black;
            this.add_logo_btn.Location = new System.Drawing.Point(355, 266);
            this.add_logo_btn.Name = "add_logo_btn";
            this.add_logo_btn.Size = new System.Drawing.Size(78, 25);
            this.add_logo_btn.TabIndex = 21;
            this.add_logo_btn.Text = "Добавить";
            this.add_logo_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_logo_btn.TextColor = System.Drawing.Color.Black;
            this.add_logo_btn.UseVisualStyleBackColor = false;
            this.add_logo_btn.Visible = false;
            this.add_logo_btn.Click += new System.EventHandler(this.add_logo_btn_Click);
            // 
            // add_audio_btn
            // 
            this.add_audio_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.add_audio_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.add_audio_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.add_audio_btn.BorderRadius = 13;
            this.add_audio_btn.BorderSize = 0;
            this.add_audio_btn.FlatAppearance.BorderSize = 0;
            this.add_audio_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_audio_btn.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.add_audio_btn.ForeColor = System.Drawing.Color.Black;
            this.add_audio_btn.Location = new System.Drawing.Point(355, 204);
            this.add_audio_btn.Name = "add_audio_btn";
            this.add_audio_btn.Size = new System.Drawing.Size(78, 25);
            this.add_audio_btn.TabIndex = 20;
            this.add_audio_btn.Text = "Добавить";
            this.add_audio_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_audio_btn.TextColor = System.Drawing.Color.Black;
            this.add_audio_btn.UseVisualStyleBackColor = false;
            this.add_audio_btn.Visible = false;
            this.add_audio_btn.Click += new System.EventHandler(this.add_audio_btn_Click);
            // 
            // add_subtitles_btn
            // 
            this.add_subtitles_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.add_subtitles_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.add_subtitles_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.add_subtitles_btn.BorderRadius = 13;
            this.add_subtitles_btn.BorderSize = 0;
            this.add_subtitles_btn.FlatAppearance.BorderSize = 0;
            this.add_subtitles_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_subtitles_btn.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.add_subtitles_btn.ForeColor = System.Drawing.Color.Black;
            this.add_subtitles_btn.Location = new System.Drawing.Point(355, 144);
            this.add_subtitles_btn.Name = "add_subtitles_btn";
            this.add_subtitles_btn.Size = new System.Drawing.Size(78, 25);
            this.add_subtitles_btn.TabIndex = 19;
            this.add_subtitles_btn.Text = "Добавить";
            this.add_subtitles_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_subtitles_btn.TextColor = System.Drawing.Color.Black;
            this.add_subtitles_btn.UseVisualStyleBackColor = false;
            this.add_subtitles_btn.Visible = false;
            this.add_subtitles_btn.Click += new System.EventHandler(this.add_subtitles_btn_Click);
            // 
            // add_source_btn
            // 
            this.add_source_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.add_source_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.add_source_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.add_source_btn.BorderRadius = 13;
            this.add_source_btn.BorderSize = 0;
            this.add_source_btn.FlatAppearance.BorderSize = 0;
            this.add_source_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_source_btn.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F);
            this.add_source_btn.ForeColor = System.Drawing.Color.Black;
            this.add_source_btn.Location = new System.Drawing.Point(355, 83);
            this.add_source_btn.Name = "add_source_btn";
            this.add_source_btn.Size = new System.Drawing.Size(78, 25);
            this.add_source_btn.TabIndex = 18;
            this.add_source_btn.Text = "Добавить";
            this.add_source_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_source_btn.TextColor = System.Drawing.Color.Black;
            this.add_source_btn.UseVisualStyleBackColor = false;
            this.add_source_btn.Click += new System.EventHandler(this.add_source_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.start_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.start_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.start_btn.BorderRadius = 20;
            this.start_btn.BorderSize = 2;
            this.start_btn.FlatAppearance.BorderSize = 0;
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Font = new System.Drawing.Font("a_MachinaNova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.start_btn.Location = new System.Drawing.Point(375, 578);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(150, 40);
            this.start_btn.TabIndex = 12;
            this.start_btn.Text = " Начать";
            this.start_btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // logo_rem
            // 
            this.logo_rem.AutoSize = true;
            this.logo_rem.BackColor = System.Drawing.Color.Transparent;
            this.logo_rem.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logo_rem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.logo_rem.Location = new System.Drawing.Point(24, 292);
            this.logo_rem.Name = "logo_rem";
            this.logo_rem.Size = new System.Drawing.Size(107, 20);
            this.logo_rem.TabIndex = 8;
            this.logo_rem.Text = "Запомнить путь";
            this.logo_rem.UseVisualStyleBackColor = false;
            this.logo_rem.Visible = false;
            this.logo_rem.CheckedChanged += new System.EventHandler(this.logo_rem_CheckedChanged);
            // 
            // intro_rem
            // 
            this.intro_rem.AutoSize = true;
            this.intro_rem.BackColor = System.Drawing.Color.Transparent;
            this.intro_rem.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intro_rem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.intro_rem.Location = new System.Drawing.Point(24, 362);
            this.intro_rem.Name = "intro_rem";
            this.intro_rem.Size = new System.Drawing.Size(107, 20);
            this.intro_rem.TabIndex = 48;
            this.intro_rem.Text = "Запомнить путь";
            this.intro_rem.UseVisualStyleBackColor = false;
            this.intro_rem.Visible = false;
            this.intro_rem.CheckedChanged += new System.EventHandler(this.intro_rem_CheckedChanged);
            // 
            // intro2_rem
            // 
            this.intro2_rem.AutoSize = true;
            this.intro2_rem.BackColor = System.Drawing.Color.Transparent;
            this.intro2_rem.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intro2_rem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.intro2_rem.Location = new System.Drawing.Point(24, 432);
            this.intro2_rem.Name = "intro2_rem";
            this.intro2_rem.Size = new System.Drawing.Size(107, 20);
            this.intro2_rem.TabIndex = 49;
            this.intro2_rem.Text = "Запомнить путь";
            this.intro2_rem.UseVisualStyleBackColor = false;
            this.intro2_rem.Visible = false;
            this.intro2_rem.CheckedChanged += new System.EventHandler(this.intro2_rem_CheckedChanged_1);
            // 
            // outro_rem
            // 
            this.outro_rem.AutoSize = true;
            this.outro_rem.BackColor = System.Drawing.Color.Transparent;
            this.outro_rem.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outro_rem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.outro_rem.Location = new System.Drawing.Point(24, 502);
            this.outro_rem.Name = "outro_rem";
            this.outro_rem.Size = new System.Drawing.Size(107, 20);
            this.outro_rem.TabIndex = 50;
            this.outro_rem.Text = "Запомнить путь";
            this.outro_rem.UseVisualStyleBackColor = false;
            this.outro_rem.Visible = false;
            this.outro_rem.CheckedChanged += new System.EventHandler(this.outro_rem_CheckedChanged);
            // 
            // work_dri_rem
            // 
            this.work_dri_rem.AutoSize = true;
            this.work_dri_rem.BackColor = System.Drawing.Color.Transparent;
            this.work_dri_rem.Font = new System.Drawing.Font("a_MachinaNova", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.work_dri_rem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.work_dri_rem.Location = new System.Drawing.Point(521, 108);
            this.work_dri_rem.Name = "work_dri_rem";
            this.work_dri_rem.Size = new System.Drawing.Size(107, 20);
            this.work_dri_rem.TabIndex = 51;
            this.work_dri_rem.Text = "Запомнить путь";
            this.work_dri_rem.UseVisualStyleBackColor = false;
            this.work_dri_rem.CheckedChanged += new System.EventHandler(this.work_dri_rem_CheckedChanged);
            // 
            // FDToolBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 630);
            this.Controls.Add(this.work_dri_rem);
            this.Controls.Add(this.outro_rem);
            this.Controls.Add(this.intro2_rem);
            this.Controls.Add(this.intro_rem);
            this.Controls.Add(this.logo_rem);
            this.Controls.Add(this.buttons1);
            this.Controls.Add(this.count_vag);
            this.Controls.Add(this.logo_transparency);
            this.Controls.Add(this.logo_indet);
            this.Controls.Add(this.logo_size);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dir_working);
            this.Controls.Add(this.label_intro2);
            this.Controls.Add(this.label_outro);
            this.Controls.Add(this.label_audio);
            this.Controls.Add(this.label_logo);
            this.Controls.Add(this.label_intro);
            this.Controls.Add(this.label_sourec_video);
            this.Controls.Add(this.label_sub);
            this.Controls.Add(this.audio_bitrate);
            this.Controls.Add(this.video_bitrate);
            this.Controls.Add(this.logo_border);
            this.Controls.Add(this.set_workdir_btn);
            this.Controls.Add(this.add_outro_btn);
            this.Controls.Add(this.add_intro2_btn);
            this.Controls.Add(this.add_intro_btn);
            this.Controls.Add(this.add_logo_btn);
            this.Controls.Add(this.add_audio_btn);
            this.Controls.Add(this.add_subtitles_btn);
            this.Controls.Add(this.add_source_btn);
            this.Controls.Add(this.AMD);
            this.Controls.Add(this.NVIDIA);
            this.Controls.Add(this.CPU);
            this.Controls.Add(this.shakal_img);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.shakal);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.after_exit);
            this.Controls.Add(this.logo_sett_pic);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.intro2_pic);
            this.Controls.Add(this.outro_pic);
            this.Controls.Add(this.intro_pic);
            this.Controls.Add(this.logo_pic);
            this.Controls.Add(this.audio_pic);
            this.Controls.Add(this.sub_pic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkin_header);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("a_MachinaNova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FDToolBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDToolBox";
            this.Load += new System.EventHandler(this.FDToolBox_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.checkin_header.ResumeLayout(false);
            this.checkin_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audio_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outro_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intro_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intro2_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_sett_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shakal_img)).EndInit();
            this.logo_border.ResumeLayout(false);
            this.logo_border.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private FDUni.buttons minimaze_btn;
        private System.Windows.Forms.Label Name_l;
        private FDUni.buttons close_btn;
        private System.Windows.Forms.Panel checkin_header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox sub_pic;
        private System.Windows.Forms.PictureBox logo_pic;
        private System.Windows.Forms.PictureBox audio_pic;
        private System.Windows.Forms.PictureBox outro_pic;
        private System.Windows.Forms.PictureBox intro_pic;
        private System.Windows.Forms.PictureBox intro2_pic;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox logo_sett_pic;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.CheckBox shakal;
        private System.Windows.Forms.CheckBox after_exit;
        private FDUni.buttons start_btn;
        private System.Windows.Forms.RadioButton CPU;
        private System.Windows.Forms.RadioButton NVIDIA;
        private System.Windows.Forms.RadioButton AMD;
        private FDUni.buttons add_source_btn;
        private FDUni.buttons add_subtitles_btn;
        private FDUni.buttons add_logo_btn;
        private FDUni.buttons add_intro_btn;
        private FDUni.buttons add_intro2_btn;
        private FDUni.buttons add_outro_btn;
        private FDUni.buttons set_workdir_btn;
        private System.Windows.Forms.RadioButton upper_left;
        private System.Windows.Forms.RadioButton lower_left;
        private System.Windows.Forms.RadioButton lower_right;
        private System.Windows.Forms.RadioButton upper_right;
        private System.Windows.Forms.GroupBox logo_border;
        private System.Windows.Forms.ListBox video_bitrate;
        private System.Windows.Forms.ListBox audio_bitrate;
        private System.Windows.Forms.PictureBox shakal_img;
        private FDUni.buttons add_audio_btn;
        private System.Windows.Forms.Label label_sub;
        private System.Windows.Forms.Label label_sourec_video;
        private System.Windows.Forms.Label label_intro;
        private System.Windows.Forms.Label label_audio;
        private System.Windows.Forms.Label label_intro2;
        private System.Windows.Forms.Label label_outro;
        private System.Windows.Forms.Label dir_working;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox logo_size;
        private System.Windows.Forms.TextBox logo_indet;
        private System.Windows.Forms.TextBox logo_transparency;
        private System.Windows.Forms.TextBox count_vag;
        private FDUni.buttons buttons1;
        private System.Windows.Forms.CheckBox logo_rem;
        private System.Windows.Forms.CheckBox intro_rem;
        private System.Windows.Forms.CheckBox intro2_rem;
        private System.Windows.Forms.CheckBox outro_rem;
        private System.Windows.Forms.CheckBox work_dri_rem;
        private System.Windows.Forms.Label label_logo;
        public System.Windows.Forms.CheckBox autro_checkBox;
        public System.Windows.Forms.CheckBox intro2_checkBox;
        public System.Windows.Forms.CheckBox intro_checkBox;
        public System.Windows.Forms.CheckBox logo_checkBox;
        public System.Windows.Forms.CheckBox audio_checkBox;
        public System.Windows.Forms.CheckBox sub_checkBox;
    }
}

