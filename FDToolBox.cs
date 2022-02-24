using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FDToolBox
{
    public partial class FDToolBox : Form
    {
        private bool dragging = false;                      //для перемещения формы
        private Point startPoint = new Point(0, 0);         //для перемещения формы

        //____________________________________Глобальные переменные___Начало________________
        string location = AppDomain.CurrentDomain.BaseDirectory;   // Определяет директорию где находится сама прогама
        int modify_count = 0;
        int logo_position = 0;
        string sub_dir = "";

        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Глобальные переменные^^^Конец^^^^^^^^^^^^^^^^^
        public FDToolBox()
        {
            InitializeComponent();

            video_bitrate.SelectedIndex = 3;
            audio_bitrate.SelectedIndex = 1;
            dir_working.Text = work_dir.Default.path;
            work_dri_rem.Checked = work_dir.Default.check;
            switch (render_metod.Default.metod)
            {
                case 1:
                    NVIDIA.Checked = true;
                    break;
                case 2:
                    AMD.Checked = true;
                    break ;

            }


        }


        //____________________________________Начало интерфейса____________________________
        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       //кнопка закрытие

        private void minimaze_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }       //кнопка сворачивание

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }       //перемещение формы

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }        //перемещение формы

        private void header_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }        //перемещение формы

        private void Name_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }        //перемещение формы

        private void Name_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }        //перемещение формы

        private void Name_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }        //перемещение формы

        private void sub_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!sub_checkBox.Checked)
            {
                sub_pic.Visible = false;
                add_subtitles_btn.Visible = false;
                label_sub.Visible = false;
                modify_count -= 1;
            }
            else
            {
                sub_pic.Visible = true;
                add_subtitles_btn.Visible = true;
                label_sub.Visible = true;
                modify_count += 1;
            }
        }       //чекбокс для субтитров

        private void audio_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!audio_checkBox.Checked)
            {
                audio_pic.Visible = false;
                add_audio_btn.Visible = false;
                label_audio.Visible = false;
                modify_count -= 1;
            }
            else
            {
                audio_pic.Visible = true;
                add_audio_btn.Visible = true;
                label_audio.Visible = true;
                modify_count += 1;
            }
        }       //чекбокс для Аудио

        private void logo_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!logo_checkBox.Checked)
            {
                logo_pic.Visible = false;
                add_logo_btn.Visible = false;
                label_logo.Visible = false;
                logo_sett_pic.Visible = false;
                logo_size.Visible = false;
                logo_indet.Visible = false;
                logo_transparency.Visible = false;
                upper_left.Visible = false;
                upper_right.Visible = false;
                lower_left.Visible = false;
                lower_right.Visible = false;
                logo_border.Visible = false;
                logo_rem.Visible = false;
                modify_count -= 1;

            }
            else
            {
                logo_pic.Visible = true;
                add_logo_btn.Visible = true;
                label_logo.Visible = true;
                logo_sett_pic.Visible = true;
                logo_size.Visible = true;
                logo_indet.Visible = true;
                logo_transparency.Visible = true;
                upper_left.Visible = true;
                upper_right.Visible = true;
                lower_left.Visible = true;
                lower_right.Visible = true;
                logo_border.Visible = true;
                logo_rem.Visible = true;
                modify_count += 1;
            }
        }       //чекбокс для лого

        private void intro_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!intro_checkBox.Checked)
            {
                intro_pic.Visible = false;
                add_intro_btn.Visible = false;
                label_intro.Visible = false;
                intro_rem.Visible = false;
                modify_count -= 1;
            }
            else
            {
                intro_pic.Visible = true;
                add_intro_btn.Visible = true;
                label_intro.Visible = true;
                intro_rem.Visible = true;
                modify_count += 1;
            }
        }       //чекбокс для интро

        private void intro2_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!intro_checkBox.Checked)
            {
                MessageBox.Show("Вы не доабвили первое интро, чтоб добавить второе!!!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);  //сообщить об ошибке
                intro2_checkBox.Checked = false;

            }
            else
            {
                if (!intro2_checkBox.Checked)
                {
                    intro2_pic.Visible = false;
                    label_intro2.Visible = false;
                    add_intro2_btn.Visible = false;
                    intro2_rem.Visible = false;
                    modify_count -= 1;
                }
                else
                {
                    intro2_pic.Visible = true;
                    add_intro2_btn.Visible = true;
                    label_intro2.Visible = true;
                    intro2_rem.Visible = true;
                    modify_count += 1;
                }
            }

        }       //чекбокс для интро2

        private void autro_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!autro_checkBox.Checked)
            {
                outro_pic.Visible = false;
                add_outro_btn.Visible = false;
                label_outro.Visible = false;
                outro_rem.Visible = false;
                modify_count -= 1;
            }
            else
            {
                outro_pic.Visible = true;
                add_outro_btn.Visible = true;
                label_outro.Visible = true;
                outro_rem.Visible = true;
                modify_count += 1;
            }
        }       //чекбокс для аутро

        private void shakal_CheckedChanged(object sender, EventArgs e)
        {
            if (!shakal.Checked)
            {
                shakal_img.Visible = false;
            }
            else
            {
                shakal_img.Visible = true;
            }
        }       ////чекбокс для шакала        



        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Конец интерфейса^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^









        //---------------------------------------------------------Начало Логики-----------------------------------------------------------------



        //————————————————————————————Кнопки----Начало---------------------------------------------//
        private void add_source_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Видео файлы (*.mp4;*.avi;*.mkv)| *.mp4; *.avi; *.mkv";
            openFileDialog.Title = "Выберите исходный видео файл";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
        proverka:
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                label_sourec_video.Text = openFileDialog.SafeFileName;
                Properties.Settings.Default.source_path = "\"" + openFileDialog.FileName + "\"";
            }
            else
            {
                MessageBox.Show("Вы не выбрали видео файл!!!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);  //сообщить об ошибке
                goto proverka;
            }

        }       //кнопка исходный файл

        private void add_subtitles_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файл Субтитров (*.srt; *.ass)| *.srt; *.ass";
            openFileDialog.Title = "Выберите файл субтитров";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
        proverka:
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                label_sub.Text = openFileDialog.SafeFileName;
                Properties.Settings.Default.sub_path = openFileDialog.FileName;

                File.Copy(Properties.Settings.Default.sub_path, @"C:\Temp\" + openFileDialog.SafeFileName, true);
                Properties.Settings.Default.sub_path = @"C:\Temp\" + openFileDialog.SafeFileName;
                Properties.Settings.Default.sub_path = "\"" + Properties.Settings.Default.sub_path + "\"";
                sub_dir = Properties.Settings.Default.sub_path.Replace(@"\", @"\\").Replace("C:", "C\\:").Trim('"');
            }
            else
            {
                MessageBox.Show("Вы не выбрали файл субтитров!!!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);  //сообщить об ошибке
                goto proverka;
            }
        }       //кнопка субтитров

        private void add_audio_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Аудио файл (*.mp3;*.ogg;*.wav;*.FLAC;*.aac;*.wma) | *.mp3; *.ogg; *.wav; *.FLAC; *.aac; *.wma";
            openFileDialog.Title = "Выберите файл озвучки";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
        proverka:
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                label_audio.Text = openFileDialog.SafeFileName;
                Properties.Settings.Default.audio_path = "\"" + openFileDialog.FileName + "\"";

            }
            else
            {
                MessageBox.Show("Вы не выбрали файл озвучки!!!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);  //сообщить об ошибке
                goto proverka;
            }

        }       //кнопка аудио

        private void add_logo_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Картинка (*.png;*.jpg;*.jpeg;*.bmp) | *.png; *.jpg; *.jpeg; *.bmp";
            openFileDialog.Title = "Выберите картинку для лого";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
        proverka:
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                label_logo.Text = openFileDialog.SafeFileName;
                Properties.Settings.Default.logo_path = "\"" + openFileDialog.FileName + "\"";

            }
            else
            {
                MessageBox.Show("Вы не выбрали картинку для лого!!!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);  //сообщить об ошибке
                goto proverka;
            }
        }       //кнопка лого

        private void add_intro_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Видео файлы (*.mp4;*.avi;*.mkv)| *.mp4; *.avi; *.mkv";
            openFileDialog.Title = "Выберите интро";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
        proverka:
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                label_intro.Text = openFileDialog.SafeFileName;
                Properties.Settings.Default.intro_path = "\"" + openFileDialog.FileName + "\"";

            }
            else
            {
                MessageBox.Show("Вы не выбрали видео файл для интро!!!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);  //сообщить об ошибке
                goto proverka;
            }
        }       //кнопка интро

        private void add_intro2_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Видео файлы (*.mp4;*.avi;*.mkv)| *.mp4; *.avi; *.mkv";
            openFileDialog.Title = "Выберите второе интро";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
        proverka:
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                label_intro2.Text = openFileDialog.SafeFileName;
                Properties.Settings.Default.intro2_path = "\"" + openFileDialog.FileName + "\"";

            }
            else
            {
                MessageBox.Show("Вы не выбрали видео файл для второго интро!!!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);  //сообщить об ошибке
                goto proverka;
            }
        }       //кнопка лого 2

        private void add_outro_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Видео файлы (*.mp4;*.avi;*.mkv)| *.mp4; *.avi; *.mkv";
            openFileDialog.Title = "Выберите ауто, зачитку";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
        proverka:
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                label_outro.Text = openFileDialog.SafeFileName;
                Properties.Settings.Default.outro_path = "\"" + openFileDialog.FileName + "\"";

            }
            else
            {
                MessageBox.Show("Вы не выбрали видео файл для ауто!!!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);  //сообщить об ошибке
                goto proverka;
            }
        }       //кнопка аутро

        private void set_workdir_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                dir_working.Text = FBD.SelectedPath;
                Properties.Settings.Default.working_dir = FBD.SelectedPath;
            }
        }       //кнопка выходной папки

        //————————————————————————————Кнопки----Конец---------------------------------------------//




        //————————————————————————————позиция---лого—————Начало-----------------------------------//
        private void upper_left_CheckedChanged(object sender, EventArgs e)
        {
            logo_position = 0;
        }

        private void upper_right_CheckedChanged(object sender, EventArgs e)
        {
            logo_position = 1;
        }

        private void lower_left_CheckedChanged(object sender, EventArgs e)
        {
            logo_position = 2;
        }

        private void lower_right_CheckedChanged(object sender, EventArgs e)
        {
            logo_position = 3;
        }

        //————————————————————————————позиция---лого—————Конец-----------------------------------//




        //----------------------------Render Metod----Начало-------------------------------------//
        private void CPU_CheckedChanged(object sender, EventArgs e)
        {
            render_metod.Default.metod = 0;
            render_metod.Default.Save();
        }

        private void NVIDIA_CheckedChanged(object sender, EventArgs e)
        {
            render_metod.Default.metod = 1;
            render_metod.Default.Save();
        }

        private void AMD_CheckedChanged(object sender, EventArgs e)
        {
            render_metod.Default.metod = 2;
            render_metod.Default.Save();
        }

        //----------------------------Render Metod----Конец-------------------------------------//




        //----------------------------Запоминалки----Начало-------------------------------------//
        private void logo_rem_CheckedChanged(object sender, EventArgs e)
        {
            if (logo_rem.Checked)
            {
                if (label_logo.Text != "")
                {
                    logo.Default.check = true;
                    logo.Default.path = label_logo.Text;
                    logo.Default.Save();
                    logo_rem.Text = "Путь запомнен.";

                }
                else
                {
                    MessageBox.Show("Вы не выбрали путь к файлу", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logo_rem.Checked = false;
                }

            }
            else
            {
                logo.Default.check = false;
                logo_rem.Text = "Запомнить путь";
            }
        }

        private void intro_rem_CheckedChanged(object sender, EventArgs e)
        {
            if (intro_rem.Checked)
            {
                if (label_intro.Text != "")
                {
                    intro_rem.Text = "Путь запомнен.";
                    intro.Default.check = true;
                    intro.Default.path = label_intro.Text;
                    intro.Default.Save();
                }
                else
                {
                    MessageBox.Show("Вы не выбрали путь к файлу", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intro_rem.Checked = false;
                }

            }
            else
            {
                intro_rem.Text = "Запомнить путь";
                intro.Default.check = false;
            }
        }

        private void intro2_rem_CheckedChanged_1(object sender, EventArgs e)
        {
            if (intro2_rem.Checked)
            {
                if (label_intro2.Text != "")
                {
                    intro2_rem.Text = "Путь запомнен.";
                    intro2.Default.check = true;
                    intro2.Default.path = label_intro2.Text;
                    intro2.Default.Save();
                }
                else
                {
                    MessageBox.Show("Вы не выбрали путь к файлу", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intro2_rem.Checked = false;
                }

            }
            else
            {
                intro2_rem.Text = "Запомнить путь";
                intro2.Default.check = false;
            }
        }

        private void outro_rem_CheckedChanged(object sender, EventArgs e)
        {
            if (outro_rem.Checked)
            {
                if (label_outro.Text != "")
                {
                    outro_rem.Text = "Путь запомнен.";
                    outro.Default.check = true;
                    outro.Default.path = label_outro.Text;
                    outro.Default.Save();
                }
                else
                {
                    MessageBox.Show("Вы не выбрали путь к файлу", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    outro_rem.Checked = false;
                }

            }
            else
            {
                outro_rem.Text = "Запомнить путь";
                outro.Default.check = false;
            }

        }

        private void work_dri_rem_CheckedChanged(object sender, EventArgs e)
        {
            if (work_dri_rem.Checked)
            {
                if (dir_working.Text != "")
                {
                    work_dri_rem.Text = "Путь запомнен.";
                    work_dir.Default.path = dir_working.Text;
                    work_dir.Default.check = true;
                    work_dir.Default.Save();
                }
                else
                {
                    MessageBox.Show("Вы не выбрали путь к файлу", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    work_dri_rem.Checked = false;
                }

            }
            else
            {
                work_dri_rem.Text = "Запомнить путь";
                work_dir.Default.check = false;
            }
        }

        //----------------------------Запоминалки----Конец-------------------------------------//


        //-----------------------Проверка параметров лого------Начало--------------------------//
        private void logo_size_TextChanged(object sender, EventArgs e)
        {
            if (logo_size.TextLength > 3)
            {
                MessageBox.Show("Значение больше 3 цифер не допускается", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logo_size.Text = logo_size.Text.Substring(0, logo_size.TextLength - 1);
            }
            if (logo_size.Text == "0")
            {
                MessageBox.Show("Значение 0 не допускается", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logo_size.Text = "110";
            }
        }

        private void logo_size_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void logo_indet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void logo_transparency_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void logo_indet_TextChanged(object sender, EventArgs e)
        {
            if (logo_indet.TextLength > 2)
            {
                MessageBox.Show("Значение больше 2 цифер не допускается", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logo_indet.Text = logo_indet.Text.Substring(0, logo_indet.TextLength - 1);
            }
            if (logo_indet.Text == "0")
            {
                MessageBox.Show("Значение 0 не допускается", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logo_indet.Text = "10";
            }
        }

        private void logo_transparency_TextChanged(object sender, EventArgs e)
        {
            if (logo_transparency.TextLength > 2)
            {
                MessageBox.Show("Значение больше 2 цифер не допускается", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logo_transparency.Text = logo_transparency.Text.Substring(0, logo_transparency.TextLength - 1);
            }
            if (logo_transparency.TextLength < 2)
            {
                MessageBox.Show("Значение меньше 2 цифер не допускается", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logo_transparency.Text = "50";
            }

        }

        //-----------------------Проверка параметров лого------Конец--------------------------//



        private void start_btn_Click(object sender, EventArgs e)
        {
            string modify = "";
            string f_complex = "";
            string ffmpeg_inputs = "";

            string video_settings = "";
            string audio_settings = "";
            string pos_log = "";
            string arguments = "";
            string render_codec = "";
            string output_name = "";

            if ((intro_checkBox.Checked) && (label_intro.Text != ""))           //intro 1
            {
                modify += "a";
            }
            if ((intro2_checkBox.Checked) && (label_intro2.Text != ""))         //intro 2
            {
                modify += "b";
            }
            if (label_sourec_video.Text != "")                                  //source video
            {
                modify += "c";
            }
            if ((logo_checkBox.Checked) && (label_logo.Text != ""))             //logo
            {
                modify += "d";
            }   
            if ((sub_checkBox.Checked) && (label_sub.Text != ""))               //subtitles
            {
                modify += "e";
            }
            if ((audio_checkBox.Checked) && (label_audio.Text != ""))           //audio
            {
                modify += "f";
            }
            if ((autro_checkBox.Checked) && (label_outro.Text != ""))           //outro
            {
                modify += "g";
            }

            char[] charArray = modify.ToCharArray();        //переводим строку в аррай
            Array.Sort(charArray);                          //сортировка арайа от А до Я
            modify = new String(charArray);                 //присваеваем к modify наш аррай 



            switch (logo_position)
            {
                case 0:
                    pos_log = "overlay = " + logo_indet.Text + ":" + logo_indet.Text;
                    break;
                case 1:
                    pos_log = "overlay=main_w-overlay_w-" + logo_indet.Text + ":" + logo_indet.Text ;
                    break;
                case 2:
                    pos_log = "overlay=" + logo_indet.Text + ":" + "main_h-overlay_h-" + logo_indet.Text;
                    break;
                case 3:
                    pos_log = "overlay=main_w-overlay_w-" + logo_indet.Text  + ":" + "main_h-overlay_h-" + logo_indet.Text;
                    break;
            }





            //------------------------------------------------------с двумя интро-------------------Начало----------------------------------------------------------//
            if (modify == "abcdefg") //Полная
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path + " -i " + Properties.Settings.Default.intro2_path + " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " +Properties.Settings.Default.sub_path + " -i " + Properties.Settings.Default.audio_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[3:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[2:v]subtitles='" + sub_dir + "'[sub];[sub][alpha_logo]" + pos_log + "[logo];  [0:v][0:a][1:v][1:a][logo][5:a][6:v][6:a] concat=n=4:v=1:a=1 [v] [a]" +"\"" + " -map " + "\""+ "[v]" + "\"" + " -map " + "\""+ "[a]" + "\"";
            
            }

            if (modify == "abcdef") //Полная без аутро
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path + " -i " + Properties.Settings.Default.intro2_path + " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " +Properties.Settings.Default.sub_path + " -i " + Properties.Settings.Default.audio_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[3:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[2:v]subtitles='" + sub_dir + "'[sub];[sub][alpha_logo]" + pos_log + "[logo];  [0:v][0:a][1:v][1:a][logo][5:a]concat=n=3:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }

            if (modify == "abcef") //две интро / видео / субтитры / аудио
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path + " -i " + Properties.Settings.Default.intro2_path + " -i " + Properties.Settings.Default.source_path + " -i " +Properties.Settings.Default.sub_path + " -i " + Properties.Settings.Default.audio_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[2:v]subtitles='" + sub_dir + "'[sub]; [0:v][0:a][1:v][1:a][sub][4:a]concat=n=3:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";
                               
            }

            if (modify == "abcefg") //две интро / видео / субтитры / аудио / Аутро
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path + " -i " + Properties.Settings.Default.intro2_path + " -i " + Properties.Settings.Default.source_path + " -i " +Properties.Settings.Default.sub_path + " -i " + Properties.Settings.Default.audio_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[2:v]subtitles='" + sub_dir + "'[sub]; [0:v][0:a][1:v][1:a][sub][4:a][5:v][5:a] concat=n=4:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }

            if (modify == "abcde") // Две интро / видео / лого / субтитры
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path + " -i " + Properties.Settings.Default.intro2_path + " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " +Properties.Settings.Default.sub_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[3:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[2:v]subtitles='" + sub_dir + "'[sub];[sub][alpha_logo]" + pos_log + "[logo];  [0:v][0:a][1:v][1:a][logo][2:a]concat=n=3:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }

            if (modify == "abcdeg") // Две интро / видео / лого / субтитры / аутро
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path + " -i " + Properties.Settings.Default.intro2_path + " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " +Properties.Settings.Default.sub_path + " -i " + Properties.Settings.Default.audio_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[3:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[2:v]subtitles='" + sub_dir + "'[sub];[sub][alpha_logo]" + pos_log + "[logo];  [0:v][0:a][1:v][1:a][logo][2:a][5:v][5:a]concat=n=4:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }

            if (modify == "abce") //две интро / видео / субтитры 
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path + " -i " + Properties.Settings.Default.intro2_path + " -i " + Properties.Settings.Default.source_path + " -i " +Properties.Settings.Default.sub_path +  " -y ";
                f_complex = " -filter_complex " + "\"" + "[2:v]subtitles='" + sub_dir + "'[sub]; [0:v][0:a][1:v][1:a][sub][2:a]concat=n=3:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }

            if (modify == "abceg") //две интро / видео / субтитры / аутро
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path + " -i " + Properties.Settings.Default.intro2_path + " -i " + Properties.Settings.Default.source_path + " -i " +Properties.Settings.Default.sub_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[2:v]subtitles='" + sub_dir + "'[sub]; [0:v][0:a][1:v][1:a][sub][2:a][4:v][4:a]concat=n=4:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            if (modify == "abcdf") // Две интро / видео / лого / аудио
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path + " -i " + Properties.Settings.Default.intro2_path + " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path +  " -i " + Properties.Settings.Default.audio_path +  " -y ";
                f_complex = " -filter_complex " + "\"" + "[3:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[2:v][alpha_logo]" + pos_log + "[logo];  [0:v][0:a][1:v][1:a][logo][4:a]concat=n=3:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            if (modify == "abcdfg") // Две интро / видео / лого / аудио / аутро 
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path + " -i " + Properties.Settings.Default.intro2_path + " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " + Properties.Settings.Default.audio_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[3:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[2:v][alpha_logo]" + pos_log + "[logo];  [0:v][0:a][1:v][1:a][logo][4:a][5:v][5:a]concat=n=4:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }

            if (modify == "abcf") // Две интро / видео / аудио
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path + " -i " + Properties.Settings.Default.intro2_path + " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.audio_path + " -y ";
                f_complex = " -filter_complex " + "\"" +"[0:v][0:a][1:v][1:a][2:v][3:a]concat=n=3:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            if (modify == "abcfg") // Две интро / видео / аудио / аутро 
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path + " -i " + Properties.Settings.Default.intro2_path + " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.audio_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[0:v][0:a][1:v][1:a][2:v][3:a][4:v][4:a]concat=n=4:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            if (modify == "abc") // Две интро / видео 
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path + " -i " + Properties.Settings.Default.intro2_path + " -i " + Properties.Settings.Default.source_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[0:v][0:a][1:v][1:a][2:v][2:a]concat=n=3:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            if (modify == "abcg") // Две интро / видео / аутро 
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path + " -i " + Properties.Settings.Default.intro2_path + " -i " + Properties.Settings.Default.source_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[0:v][0:a][1:v][1:a][2:v][2:a][3:v][3:a]concat=n=4:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            if (modify == "abcd") // Две интро / видео / лого
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path + " -i " + Properties.Settings.Default.intro2_path + " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[3:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[2:v][alpha_logo]" + pos_log + "[logo];  [0:v][0:a][1:v][1:a][logo][2:a]concat=n=3:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            if (modify == "abcdg") // Две интро / видео / лого / аутро
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path + " -i " + Properties.Settings.Default.intro2_path + " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[3:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[2:v][alpha_logo]" + pos_log + "[logo];  [0:v][0:a][1:v][1:a][logo][2:a][4:v][4:a]concat=n=4:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            //----------------------------------------------------- С   ДВУМЯ     ИНТРО  -------------------Конец----------------------------------------------------------//










            //---------------------------------------------------- С    ОДНИМ     ИНТРО   -------------------Начало---------------------------------------------------------//
            if (modify == "acdefg") //интро / видео / лого / субтитри / аудио / аутро
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path +  " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " +Properties.Settings.Default.sub_path + " -i " + Properties.Settings.Default.audio_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[2:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[1:v]subtitles='" + sub_dir + "'[sub];[sub][alpha_logo]" + pos_log + "[logo];  [0:v][0:a][logo][4:a][5:v][5:a] concat=n=3:v=1:a=1 [v] [a]" + "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }

            if (modify == "acdef") //интро / видео / лого / субтитри / аудио 
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path +  " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " +Properties.Settings.Default.sub_path + " -i " + Properties.Settings.Default.audio_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[2:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[1:v]subtitles='" + sub_dir + "'[sub];[sub][alpha_logo]" + pos_log + "[logo];  [0:v][0:a][logo][4:a]concat=n=2:v=1:a=1 [v] [a]" + "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }

            if (modify == "acef") //Одно интро / видео / субтитры / аудио
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path +  " -i " + Properties.Settings.Default.source_path + " -i " +Properties.Settings.Default.sub_path + " -i " + Properties.Settings.Default.audio_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[1:v]subtitles='" + sub_dir + "'[sub]; [0:v][0:a][sub][3:a]concat=n=2:v=1:a=1 [v] [a]" + "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }

            if (modify == "acefg") //Одно интро / видео / субтитры / аудио / Аутро
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path +  " -i " + Properties.Settings.Default.source_path + " -i " +Properties.Settings.Default.sub_path + " -i " + Properties.Settings.Default.audio_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[1:v]subtitles='" + sub_dir + "'[sub]; [0:v][0:a][sub][3:a][4:v][4:a] concat=n=3:v=1:a=1 [v] [a]" + "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }

            if (modify == "acde") // Одно интро / видео / лого / субтитры
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path +  " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " +Properties.Settings.Default.sub_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[2:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[1:v]subtitles='" + sub_dir + "'[sub];[sub][alpha_logo]" + pos_log + "[logo];  [0:v][0:a][logo][1:a]concat=n=2:v=1:a=1 [v] [a]" + "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }

            if (modify == "acdeg") // Одно интро / видео / лого / субтитры / аутро
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path +  " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " +Properties.Settings.Default.sub_path + " -i " + Properties.Settings.Default.audio_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[2:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[1:v]subtitles='" + sub_dir + "'[sub];[sub][alpha_logo]" + pos_log + "[logo];  [0:v][0:a][logo][1:a][4:v][4:a]concat=n=3:v=1:a=1 [v] [a]" + "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }

            if (modify == "ace") //Одно интро / видео / субтитры 
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path +  " -i " + Properties.Settings.Default.source_path + " -i " +Properties.Settings.Default.sub_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[1:v]subtitles='" + sub_dir + "'[sub]; [0:v][0:a][sub][1:a]concat=n=2:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }

            if (modify == "aceg") //Одно интро / видео / субтитры / аутро
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path +  " -i " + Properties.Settings.Default.source_path + " -i " +Properties.Settings.Default.sub_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[1:v]subtitles='" + sub_dir + "'[sub]; [0:v][0:a][sub][1:a][3:v][3:a]concat=n=3:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            if (modify == "acdf") // Одно интро / видео / лого / аудио
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path +  " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " + Properties.Settings.Default.audio_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[2:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[1:v][alpha_logo]" + pos_log + "[logo];  [0:v][0:a][logo][3:a]concat=n=2:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            if (modify == "acdfg") // Одно интро / видео / лого / аудио / аутро 
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path +  " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " + Properties.Settings.Default.audio_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[2:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[1:v][alpha_logo]" + pos_log + "[logo];  [0:v][0:a][logo][3:a][4:v][4:a]concat=n=3:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }

            if (modify == "acf") // Одно интро / видео / аудио
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path +  " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.audio_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[0:v][0:a][1:v][2:a]concat=n=2:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            if (modify == "acfg") // Одно интро / видео / аудио / аутро 
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path +  " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.audio_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[0:v][0:a][1:v][2:a][3:v][3:a]concat=n=3:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            if (modify == "ac") // Одно интро / видео 
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path +  " -i " + Properties.Settings.Default.source_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[0:v][0:a][1:v][1:a]concat=n=2:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            if (modify == "acg") // Одно интро / видео / аутро 
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path +  " -i " + Properties.Settings.Default.source_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[0:v][0:a][1:v][1:a][2:v][2:a]concat=n=3:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            if (modify == "acd") // Одно интро / видео / лого
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path +  " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[2:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[1:v][alpha_logo]" + pos_log + "[logo];  [0:v][0:a][logo][1:a]concat=n=2:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            if (modify == "acdg") // Одно интро / видео / лого / аутро
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i " + Properties.Settings.Default.intro_path +  " -i " + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[2:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[1:v][alpha_logo]" + pos_log + "[logo];  [0:v][0:a][logo][1:a][3:v][3:a]concat=n=3:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            //---------------------------------------------------- С    ОДНИМ     ИНТРО   -------------------Конец---------------------------------------------------------//








            //----------------------------------------------------------- БЕЗ  ИНТРО   ---------------------Начало---------------------------------------------------------//
            if (modify == "cdefg") // видео / лого / субтитри / аудио / аутро
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i "  + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " +Properties.Settings.Default.sub_path + " -i " + Properties.Settings.Default.audio_path + " -i " +  Properties.Settings.Default.outro_path + " -y "; 
                f_complex = " -filter_complex " + "\"" + "[1:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[0:v]subtitles='" + sub_dir + "'[sub];[sub][alpha_logo]" + pos_log + "[logo]; [logo][3:a][4:v][4:a] concat=n=2:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }

            if (modify == "cdef")// видео / лого / субтитри / аудио 
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i "  + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " +Properties.Settings.Default.sub_path + " -i " + Properties.Settings.Default.audio_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[1:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[1:v]subtitles='" + sub_dir + "'[sub];[sub][alpha_logo]" + pos_log + "[logo] " + " -map " + "\"" + "[logo]" + "\"" + " -map " + "\"" + "[3:a]" + "\"";

            }

            if (modify == "cef") // видео / субтитры / аудио
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i "  + Properties.Settings.Default.source_path + " -i " +Properties.Settings.Default.sub_path + " -i " + Properties.Settings.Default.audio_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[0:v]subtitles='" + sub_dir + "'[sub]" + " -map " + "\"" + "[sub]" + "\"" + " -map " + "\"" + "[2:a]" + "\"";

            }

            if (modify == "cefg") // видео / субтитры / аудио / Аутро
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i "  + Properties.Settings.Default.source_path + " -i " +Properties.Settings.Default.sub_path + " -i " + Properties.Settings.Default.audio_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[0:v]subtitles='" + sub_dir + "'[sub]; [sub][2:a][3:v][3:a] concat=n=2:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }

            if (modify == "cde") //  видео / лого / субтитры
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i "  + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " +Properties.Settings.Default.sub_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[1:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[0:v]subtitles='" + sub_dir + "'[sub];[sub][alpha_logo]" + pos_log + "[logo]" + " -map " + "\"" + "[logo]" + "\"" + " -map " + "\"" + "[0:a]" + "\"";

            }

            if (modify == "cdeg") //  видео / лого / субтитры / аутро
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i "  + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " +Properties.Settings.Default.sub_path + " -i " + Properties.Settings.Default.audio_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[1:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[0:v]subtitles='" + sub_dir + "'[sub];[sub][alpha_logo]" + pos_log + "[logo]; [logo][0:a][3:v][3:a]concat=n=2:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }

            if (modify == "ce") // видео / субтитры 
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i "  + Properties.Settings.Default.source_path + " -i " +Properties.Settings.Default.sub_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[0:v]subtitles='" + sub_dir + "'[sub]" + " -map " + "\"" + "[sub]" + "\"" + " -map " + "\"" + "[0:a]" + "\"";

            }

            if (modify == "ceg") // видео / субтитры / аутро
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i "  + Properties.Settings.Default.source_path + " -i " +Properties.Settings.Default.sub_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[0:v]subtitles='" + sub_dir + "'[sub]; [sub][0:a][2:v][2:a]concat=n=2:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            if (modify == "cdf") //  видео / лого / аудио
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i "  + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " + Properties.Settings.Default.audio_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[1:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[0:v][alpha_logo]" + pos_log + "[logo]" + " -map " + "\"" + "[logo]" + "\"" + " -map " + "\"" + "[2:a]" + "\"";

            }
            if (modify == "cdfg") //  видео / лого / аудио / аутро 
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i "  + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " + Properties.Settings.Default.audio_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[1:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[0:v][alpha_logo]" + pos_log + "[logo]; [logo][2:a][3:v][3:a]concat=n=2:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }

            if (modify == "cf") //  видео / аудио
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i "  + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.audio_path + " -y ";
                f_complex = " -map 0:v:0 -map 1:a:0";

            }
            if (modify == "cfg") //  видео / аудио / аутро 
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i "  + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.audio_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[0:v][1:a][2:v][2:a]concat=n=2:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            if (modify == "c") //  видео 
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i "  + Properties.Settings.Default.source_path + " -y ";
                f_complex = " -filter_complex " + "\"" +  " -map " + "\"" + "[0:v]" + "\"" + " -map " + "\"" + "[0:a]" + "\"";

            }
            if (modify == "cg") //  видео / аутро 
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i "  + Properties.Settings.Default.source_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[0:v][0:a][1:v][1:a]concat=n=2:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            if (modify == "cd") //  видео / лого
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i "  + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[1:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[0:v][alpha_logo]" + pos_log + "[logo];" + " -map " + "\"" + "[logo]" + "\"" + " -map " + "\"" + "[0:a]" + "\"";

            }
            if (modify == "cdg") //  видео / лого / аутро
            {
                ffmpeg_inputs = " -hwaccel_device 0 -hwaccel dxva2 -i "  + Properties.Settings.Default.source_path + " -i " + Properties.Settings.Default.logo_path + " -i " +  Properties.Settings.Default.outro_path + " -y ";
                f_complex = " -filter_complex " + "\"" + "[1:v]" + "scale=" + logo_size.Text + ":" + logo_size.Text + "[scaled_logo];[scaled_logo]format = rgba,colorchannelmixer = aa = 0." + logo_transparency.Text + "[alpha_logo];[0:v][alpha_logo]" + pos_log + "[logo]; [logo][0:a][2:v][2:a]concat=n=2:v=1:a=1 [v] [a]" +  "\"" + " -map " + "\"" + "[v]" + "\"" + " -map " + "\"" + "[a]" + "\"";

            }
            //----------------------------------------------------------- БЕЗ  ИНТРО   ---------------------КОНЕЦ---------------------------------------------------------//

            if (shakal.Checked)
            {
                audio_settings = " - c:a aac -ar 44100 - b:a 128k ";
                video_settings = " -b:v 700k - minrate 700k - maxrate 700k ";
            }
            else
            {
                audio_settings = " -c:a aac -ar 44100 -b:a " + audio_bitrate.SelectedItem + " -minrate " + audio_bitrate.SelectedItem + " -maxrate " + audio_bitrate.SelectedItem + " -shortest -strict experimental ";
                video_settings = " -b:v " + video_bitrate.SelectedItem + " -minrate " + video_bitrate.SelectedItem + " -maxrate " + video_bitrate.SelectedItem +" -vsync 2 ";
            }
           
            if ((textBox1.Text == "") || (textBox1.Text == "Название выходного файла"))
            {
                output_name = "\\output";
            }
            else
            {
                output_name = "\\" + textBox1.Text;
            }

            if (NVIDIA.Checked)
            {
                render_codec = " -c:v h264_nvenc ";
            }
            render_codec = " -c:v hvec_amf ";

            arguments = ffmpeg_inputs + f_complex + render_codec  + video_settings + audio_settings   + " " + "\"" + dir_working.Text + output_name + ".mp4" +"\"";

            count_vag.Text = "ffmpeg " + arguments;

            Process ffmpeg_proc = Process.Start(new ProcessStartInfo
            {
                WorkingDirectory = Properties.Settings.Default.working_dir,             //рабочяя папка
                FileName = location + "\\ffmpeg\\ffmpeg.exe",           //абсалютый путь к программе для запуска
                Arguments = arguments,       
                
            });

            
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void FDToolBox_Load(object sender, EventArgs e)
        {
           
        }
    }
}




