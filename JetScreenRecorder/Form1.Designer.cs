namespace JetScreenRecorder
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            //if (_writer.IsOpen)
            //{
            //    _streamVideo.SignalToStop();
            //    _writer.Close();
            //    _writer.Dispose();
            //}
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_start = new Bunifu.Framework.UI.BunifuImageButton();
            this.bt_Save = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_stopWatch = new System.Windows.Forms.Label();
            this.lb_1 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.cb_screenSelector = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_SaveFolder = new System.Windows.Forms.TextBox();
            this.nud_FPS = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_BitRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_VideoCodec = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bt_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_FPS)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_start
            // 
            this.bt_start.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_start.BackgroundImage = global::JetScreenRecorder.Properties.Resources.mdl_button;
            this.bt_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_start.Image = global::JetScreenRecorder.Properties.Resources.Circled_Play_32px_1;
            this.bt_start.ImageActive = null;
            this.bt_start.Location = new System.Drawing.Point(440, 42);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(55, 55);
            this.bt_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bt_start.TabIndex = 94;
            this.bt_start.TabStop = false;
            this.bt_start.Zoom = 10;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_Save.BackgroundImage = global::JetScreenRecorder.Properties.Resources.mdl_button2;
            this.bt_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Save.Image = global::JetScreenRecorder.Properties.Resources.Circled_Pause_32px;
            this.bt_Save.ImageActive = null;
            this.bt_Save.Location = new System.Drawing.Point(379, 42);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(55, 55);
            this.bt_Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bt_Save.TabIndex = 93;
            this.bt_Save.TabStop = false;
            this.bt_Save.Zoom = 10;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuImageButton1.Image = global::JetScreenRecorder.Properties.Resources.Close_Window_48px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(497, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 90;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_stopWatch);
            this.panel1.Controls.Add(this.lb_1);
            this.panel1.Location = new System.Drawing.Point(8, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 74);
            this.panel1.TabIndex = 92;
            this.panel1.Visible = false;
            // 
            // lb_stopWatch
            // 
            this.lb_stopWatch.AutoSize = true;
            this.lb_stopWatch.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_stopWatch.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb_stopWatch.Location = new System.Drawing.Point(2, 13);
            this.lb_stopWatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_stopWatch.Name = "lb_stopWatch";
            this.lb_stopWatch.Size = new System.Drawing.Size(354, 38);
            this.lb_stopWatch.TabIndex = 15;
            this.lb_stopWatch.Text = "00:00:00.0000000";
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb_1.Location = new System.Drawing.Point(9, 55);
            this.lb_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(62, 14);
            this.lb_1.TabIndex = 14;
            this.lb_1.Text = "Frames: ";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuImageButton2.Image = global::JetScreenRecorder.Properties.Resources.Minimize_Window_48px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(472, 5);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 91;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // cb_screenSelector
            // 
            this.cb_screenSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.cb_screenSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_screenSelector.ForeColor = System.Drawing.SystemColors.Menu;
            this.cb_screenSelector.FormattingEnabled = true;
            this.cb_screenSelector.Location = new System.Drawing.Point(112, 60);
            this.cb_screenSelector.Margin = new System.Windows.Forms.Padding(2);
            this.cb_screenSelector.Name = "cb_screenSelector";
            this.cb_screenSelector.Size = new System.Drawing.Size(102, 21);
            this.cb_screenSelector.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label5.Location = new System.Drawing.Point(44, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Screens:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label4.Location = new System.Drawing.Point(7, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Save in folder:";
            // 
            // tb_SaveFolder
            // 
            this.tb_SaveFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.tb_SaveFolder.ForeColor = System.Drawing.SystemColors.Menu;
            this.tb_SaveFolder.Location = new System.Drawing.Point(113, 87);
            this.tb_SaveFolder.Margin = new System.Windows.Forms.Padding(2);
            this.tb_SaveFolder.Name = "tb_SaveFolder";
            this.tb_SaveFolder.Size = new System.Drawing.Size(238, 20);
            this.tb_SaveFolder.TabIndex = 86;
            // 
            // nud_FPS
            // 
            this.nud_FPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.nud_FPS.ForeColor = System.Drawing.SystemColors.Menu;
            this.nud_FPS.Location = new System.Drawing.Point(275, 59);
            this.nud_FPS.Margin = new System.Windows.Forms.Padding(2);
            this.nud_FPS.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_FPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_FPS.Name = "nud_FPS";
            this.nud_FPS.Size = new System.Drawing.Size(75, 20);
            this.nud_FPS.TabIndex = 85;
            this.nud_FPS.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(232, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "FPS:";
            // 
            // cb_BitRate
            // 
            this.cb_BitRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.cb_BitRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_BitRate.ForeColor = System.Drawing.SystemColors.Menu;
            this.cb_BitRate.FormattingEnabled = true;
            this.cb_BitRate.Location = new System.Drawing.Point(275, 35);
            this.cb_BitRate.Margin = new System.Windows.Forms.Padding(2);
            this.cb_BitRate.Name = "cb_BitRate";
            this.cb_BitRate.Size = new System.Drawing.Size(76, 21);
            this.cb_BitRate.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(218, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "BitRate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "VideoCodec:";
            // 
            // cb_VideoCodec
            // 
            this.cb_VideoCodec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.cb_VideoCodec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_VideoCodec.ForeColor = System.Drawing.SystemColors.Menu;
            this.cb_VideoCodec.FormattingEnabled = true;
            this.cb_VideoCodec.Location = new System.Drawing.Point(112, 35);
            this.cb_VideoCodec.Margin = new System.Windows.Forms.Padding(2);
            this.cb_VideoCodec.Name = "cb_VideoCodec";
            this.cb_VideoCodec.Size = new System.Drawing.Size(102, 21);
            this.cb_VideoCodec.TabIndex = 80;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(8, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 104);
            this.panel2.TabIndex = 95;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(64, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(386, 42);
            this.label6.TabIndex = 2;
            this.label6.Text = "JetScreenRecorder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(529, 112);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.cb_screenSelector);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_SaveFolder);
            this.Controls.Add(this.nud_FPS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_BitRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_VideoCodec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recorder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bt_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_FPS)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bt_start;
        private Bunifu.Framework.UI.BunifuImageButton bt_Save;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_stopWatch;
        private System.Windows.Forms.Label lb_1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.ComboBox cb_screenSelector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_SaveFolder;
        private System.Windows.Forms.NumericUpDown nud_FPS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_BitRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_VideoCodec;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}

