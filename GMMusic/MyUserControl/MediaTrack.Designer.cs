namespace GMMusic
{
    partial class MediaTrack
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.timeWhole = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeSpent = new System.Windows.Forms.Label();
            this.timeTracker = new GMMusic.TimeTracker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.restartBtn = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Azure;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.restartBtn);
            this.panel.Controls.Add(this.volumeBar);
            this.panel.Controls.Add(this.nameLbl);
            this.panel.Controls.Add(this.nextBtn);
            this.panel.Controls.Add(this.prevBtn);
            this.panel.Controls.Add(this.stopBtn);
            this.panel.Controls.Add(this.pauseBtn);
            this.panel.Controls.Add(this.playBtn);
            this.panel.Controls.Add(this.timeWhole);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.timeSpent);
            this.panel.Controls.Add(this.timeTracker);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(450, 100);
            this.panel.TabIndex = 0;
            this.panel.Click += new System.EventHandler(this.Panel_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(365, 68);
            this.volumeBar.Maximum = 20;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(79, 45);
            this.volumeBar.TabIndex = 10;
            this.volumeBar.ValueChanged += new System.EventHandler(this.VolumeBar_ValueChanged);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.nameLbl.Location = new System.Drawing.Point(291, 19);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(140, 17);
            this.nameLbl.TabIndex = 9;
            this.nameLbl.Text = "Исполнитель - Трек";
            this.nameLbl.Click += new System.EventHandler(this.NameLbl_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextBtn.Location = new System.Drawing.Point(224, 11);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(30, 33);
            this.nextBtn.TabIndex = 8;
            this.nextBtn.Text = ">>";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prevBtn.Location = new System.Drawing.Point(188, 11);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(30, 33);
            this.prevBtn.TabIndex = 7;
            this.prevBtn.Text = "<<";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopBtn.Location = new System.Drawing.Point(132, 11);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(50, 33);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pauseBtn.Location = new System.Drawing.Point(76, 10);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(50, 33);
            this.pauseBtn.TabIndex = 5;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playBtn.Location = new System.Drawing.Point(9, 10);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(61, 33);
            this.playBtn.TabIndex = 4;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // timeWhole
            // 
            this.timeWhole.AutoSize = true;
            this.timeWhole.Location = new System.Drawing.Point(412, 52);
            this.timeWhole.Name = "timeWhole";
            this.timeWhole.Size = new System.Drawing.Size(34, 13);
            this.timeWhole.TabIndex = 3;
            this.timeWhole.Text = "59:59";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "/";
            // 
            // timeSpent
            // 
            this.timeSpent.AutoSize = true;
            this.timeSpent.Location = new System.Drawing.Point(364, 52);
            this.timeSpent.Name = "timeSpent";
            this.timeSpent.Size = new System.Drawing.Size(34, 13);
            this.timeSpent.TabIndex = 1;
            this.timeSpent.Text = "00:00";
            // 
            // timeTracker
            // 
            this.timeTracker.Location = new System.Drawing.Point(9, 50);
            this.timeTracker.Name = "timeTracker";
            this.timeTracker.Size = new System.Drawing.Size(350, 40);
            this.timeTracker.TabIndex = 0;
            this.timeTracker.TimeSpent = 0D;
            this.timeTracker.TimeWhole = 1D;
            this.timeTracker.WMP = null;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // restartBtn
            // 
            this.restartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restartBtn.Location = new System.Drawing.Point(260, 14);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(27, 26);
            this.restartBtn.TabIndex = 11;
            this.restartBtn.Text = "( )";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // MediaTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "MediaTrack";
            this.Size = new System.Drawing.Size(450, 100);
            this.Load += new System.EventHandler(this.MediaTrack_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TimeTracker timeTracker;
        private System.Windows.Forms.Label timeWhole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeSpent;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button playBtn;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TrackBar volumeBar;
        public System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button restartBtn;
    }
}
