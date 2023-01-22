namespace GMMusic
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.chooseSaveBtn = new System.Windows.Forms.Button();
            this.newTrackBtn = new System.Windows.Forms.Button();
            this.playerPanel = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.ambPanel = new System.Windows.Forms.Panel();
            this.ambHeaderPanel = new System.Windows.Forms.Panel();
            this.ambReBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ambSearchTB = new System.Windows.Forms.TextBox();
            this.sdtckPanel = new System.Windows.Forms.Panel();
            this.sdtckHeaderPanel = new System.Windows.Forms.Panel();
            this.sdtckReBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sdtckSearchTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openSearchBtn = new System.Windows.Forms.Button();
            this.threadPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.ambHeaderPanel.SuspendLayout();
            this.sdtckHeaderPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.saveBtn);
            this.menuPanel.Controls.Add(this.chooseSaveBtn);
            this.menuPanel.Controls.Add(this.newTrackBtn);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1284, 30);
            this.menuPanel.TabIndex = 5;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(530, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // chooseSaveBtn
            // 
            this.chooseSaveBtn.Location = new System.Drawing.Point(449, 3);
            this.chooseSaveBtn.Name = "chooseSaveBtn";
            this.chooseSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.chooseSaveBtn.TabIndex = 6;
            this.chooseSaveBtn.Text = "Выбрать";
            this.chooseSaveBtn.UseVisualStyleBackColor = true;
            this.chooseSaveBtn.Click += new System.EventHandler(this.ChooseSaveBtn_Click);
            // 
            // newTrackBtn
            // 
            this.newTrackBtn.Location = new System.Drawing.Point(3, 2);
            this.newTrackBtn.Name = "newTrackBtn";
            this.newTrackBtn.Size = new System.Drawing.Size(75, 23);
            this.newTrackBtn.TabIndex = 5;
            this.newTrackBtn.Text = "Новый трек";
            this.newTrackBtn.UseVisualStyleBackColor = true;
            this.newTrackBtn.Click += new System.EventHandler(this.NewTrackBtn_Click);
            // 
            // playerPanel
            // 
            this.playerPanel.BackColor = System.Drawing.Color.Azure;
            this.playerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.playerPanel.Location = new System.Drawing.Point(0, 30);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(450, 552);
            this.playerPanel.TabIndex = 6;
            // 
            // searchPanel
            // 
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPanel.Controls.Add(this.ambPanel);
            this.searchPanel.Controls.Add(this.ambHeaderPanel);
            this.searchPanel.Controls.Add(this.sdtckPanel);
            this.searchPanel.Controls.Add(this.sdtckHeaderPanel);
            this.searchPanel.Controls.Add(this.panel1);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchPanel.Location = new System.Drawing.Point(834, 30);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(450, 552);
            this.searchPanel.TabIndex = 7;
            // 
            // ambPanel
            // 
            this.ambPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ambPanel.Location = new System.Drawing.Point(30, 164);
            this.ambPanel.Name = "ambPanel";
            this.ambPanel.Size = new System.Drawing.Size(418, 100);
            this.ambPanel.TabIndex = 5;
            // 
            // ambHeaderPanel
            // 
            this.ambHeaderPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.ambHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ambHeaderPanel.Controls.Add(this.ambReBtn);
            this.ambHeaderPanel.Controls.Add(this.label2);
            this.ambHeaderPanel.Controls.Add(this.ambSearchTB);
            this.ambHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ambHeaderPanel.Location = new System.Drawing.Point(30, 132);
            this.ambHeaderPanel.Name = "ambHeaderPanel";
            this.ambHeaderPanel.Size = new System.Drawing.Size(418, 32);
            this.ambHeaderPanel.TabIndex = 3;
            this.ambHeaderPanel.Click += new System.EventHandler(this.AmbHeaderPanel_Click);
            // 
            // ambReBtn
            // 
            this.ambReBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ambReBtn.Location = new System.Drawing.Point(240, 5);
            this.ambReBtn.Name = "ambReBtn";
            this.ambReBtn.Size = new System.Drawing.Size(23, 23);
            this.ambReBtn.TabIndex = 3;
            this.ambReBtn.Text = "( )";
            this.ambReBtn.UseVisualStyleBackColor = true;
            this.ambReBtn.Click += new System.EventHandler(this.AmbReBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(10, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Эмбиент";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // ambSearchTB
            // 
            this.ambSearchTB.Location = new System.Drawing.Point(111, 6);
            this.ambSearchTB.Name = "ambSearchTB";
            this.ambSearchTB.Size = new System.Drawing.Size(123, 20);
            this.ambSearchTB.TabIndex = 0;
            this.ambSearchTB.TextChanged += new System.EventHandler(this.AmbSearchTB_TextChanged);
            this.ambSearchTB.Enter += new System.EventHandler(this.AmpSearchTB_Enter);
            // 
            // sdtckPanel
            // 
            this.sdtckPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sdtckPanel.Location = new System.Drawing.Point(30, 32);
            this.sdtckPanel.Name = "sdtckPanel";
            this.sdtckPanel.Size = new System.Drawing.Size(418, 100);
            this.sdtckPanel.TabIndex = 4;
            // 
            // sdtckHeaderPanel
            // 
            this.sdtckHeaderPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.sdtckHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sdtckHeaderPanel.Controls.Add(this.sdtckReBtn);
            this.sdtckHeaderPanel.Controls.Add(this.label1);
            this.sdtckHeaderPanel.Controls.Add(this.sdtckSearchTB);
            this.sdtckHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sdtckHeaderPanel.Location = new System.Drawing.Point(30, 0);
            this.sdtckHeaderPanel.Name = "sdtckHeaderPanel";
            this.sdtckHeaderPanel.Size = new System.Drawing.Size(418, 32);
            this.sdtckHeaderPanel.TabIndex = 2;
            this.sdtckHeaderPanel.Click += new System.EventHandler(this.SdtckHeaderPanel_Click);
            // 
            // sdtckReBtn
            // 
            this.sdtckReBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sdtckReBtn.Location = new System.Drawing.Point(240, 4);
            this.sdtckReBtn.Name = "sdtckReBtn";
            this.sdtckReBtn.Size = new System.Drawing.Size(23, 23);
            this.sdtckReBtn.TabIndex = 2;
            this.sdtckReBtn.Text = "( )";
            this.sdtckReBtn.UseVisualStyleBackColor = true;
            this.sdtckReBtn.Click += new System.EventHandler(this.SdtckReBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Саундтреки";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // sdtckSearchTB
            // 
            this.sdtckSearchTB.Location = new System.Drawing.Point(111, 6);
            this.sdtckSearchTB.Name = "sdtckSearchTB";
            this.sdtckSearchTB.Size = new System.Drawing.Size(123, 20);
            this.sdtckSearchTB.TabIndex = 0;
            this.sdtckSearchTB.TextChanged += new System.EventHandler(this.SdtckSearchTB_TextChanged);
            this.sdtckSearchTB.Enter += new System.EventHandler(this.SdtckSearchTB_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.openSearchBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 550);
            this.panel1.TabIndex = 1;
            // 
            // openSearchBtn
            // 
            this.openSearchBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.openSearchBtn.Location = new System.Drawing.Point(3, 231);
            this.openSearchBtn.Name = "openSearchBtn";
            this.openSearchBtn.Size = new System.Drawing.Size(21, 102);
            this.openSearchBtn.TabIndex = 0;
            this.openSearchBtn.Text = "Поиск";
            this.openSearchBtn.UseVisualStyleBackColor = true;
            this.openSearchBtn.Click += new System.EventHandler(this.OpenSearchBtn_Click);
            // 
            // threadPanel
            // 
            this.threadPanel.BackColor = System.Drawing.SystemColors.Info;
            this.threadPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threadPanel.Location = new System.Drawing.Point(450, 30);
            this.threadPanel.Name = "threadPanel";
            this.threadPanel.Size = new System.Drawing.Size(384, 552);
            this.threadPanel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 582);
            this.Controls.Add(this.threadPanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.playerPanel);
            this.Controls.Add(this.menuPanel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "GMMusic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.ambHeaderPanel.ResumeLayout(false);
            this.ambHeaderPanel.PerformLayout();
            this.sdtckHeaderPanel.ResumeLayout(false);
            this.sdtckHeaderPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel playerPanel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button newTrackBtn;
        private System.Windows.Forms.Button openSearchBtn;
        private System.Windows.Forms.Panel ambHeaderPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ambSearchTB;
        private System.Windows.Forms.Panel sdtckHeaderPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sdtckSearchTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sdtckPanel;
        private System.Windows.Forms.Panel ambPanel;
        public System.Windows.Forms.Panel threadPanel;
        private System.Windows.Forms.Button ambReBtn;
        private System.Windows.Forms.Button sdtckReBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button chooseSaveBtn;
    }
}

