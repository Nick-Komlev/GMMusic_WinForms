namespace GMMusic
{
    partial class TrackInfo
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
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.fileBtn = new System.Windows.Forms.Button();
            this.ambienceChB = new System.Windows.Forms.CheckBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.fileTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tagLB = new GMMusic.ListBoxOfMine();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.durTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelGeneral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.durTB);
            this.panelGeneral.Controls.Add(this.label3);
            this.panelGeneral.Controls.Add(this.fileBtn);
            this.panelGeneral.Controls.Add(this.ambienceChB);
            this.panelGeneral.Controls.Add(this.nameTB);
            this.panelGeneral.Controls.Add(this.fileTB);
            this.panelGeneral.Controls.Add(this.label2);
            this.panelGeneral.Controls.Add(this.label1);
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(357, 135);
            this.panelGeneral.TabIndex = 0;
            // 
            // fileBtn
            // 
            this.fileBtn.Location = new System.Drawing.Point(266, 7);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(75, 23);
            this.fileBtn.TabIndex = 6;
            this.fileBtn.Text = "Выбрать...";
            this.fileBtn.UseVisualStyleBackColor = true;
            this.fileBtn.Click += new System.EventHandler(this.FileBtn_Click);
            // 
            // ambienceChB
            // 
            this.ambienceChB.AutoSize = true;
            this.ambienceChB.Location = new System.Drawing.Point(76, 106);
            this.ambienceChB.Name = "ambienceChB";
            this.ambienceChB.Size = new System.Drawing.Size(70, 17);
            this.ambienceChB.TabIndex = 5;
            this.ambienceChB.Text = "Эмбиент";
            this.ambienceChB.UseVisualStyleBackColor = true;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(76, 42);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(265, 20);
            this.nameTB.TabIndex = 4;
            // 
            // fileTB
            // 
            this.fileTB.Location = new System.Drawing.Point(76, 10);
            this.fileTB.Name = "fileTB";
            this.fileTB.Size = new System.Drawing.Size(185, 20);
            this.fileTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Файл:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тэги:";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tagLB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 241);
            this.panel1.TabIndex = 4;
            // 
            // tagLB
            // 
            this.tagLB.Last = 0;
            this.tagLB.Location = new System.Drawing.Point(16, 29);
            this.tagLB.Name = "tagLB";
            this.tagLB.Size = new System.Drawing.Size(325, 239);
            this.tagLB.TabIndex = 4;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(186, 389);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(268, 389);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 23);
            this.acceptBtn.TabIndex = 6;
            this.acceptBtn.Text = "Применить";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // durTB
            // 
            this.durTB.Location = new System.Drawing.Point(75, 74);
            this.durTB.Name = "durTB";
            this.durTB.Size = new System.Drawing.Size(265, 20);
            this.durTB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Длит.:";
            // 
            // TrackInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 423);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TrackInfo";
            this.Text = "TrackInfo";
            this.Load += new System.EventHandler(this.TrackInfo_Load);
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Button fileBtn;
        private System.Windows.Forms.CheckBox ambienceChB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox fileTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button acceptBtn;
        private ListBoxOfMine tagLB;
        private System.Windows.Forms.TextBox durTB;
        private System.Windows.Forms.Label label3;
    }
}