namespace GMMusic
{
    partial class TimeTracker
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
            this.panelSpent = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelSpent
            // 
            this.panelSpent.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelSpent.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSpent.Location = new System.Drawing.Point(0, 0);
            this.panelSpent.Name = "panelSpent";
            this.panelSpent.Size = new System.Drawing.Size(215, 40);
            this.panelSpent.TabIndex = 0;
            this.panelSpent.Click += new System.EventHandler(this.PanelSpent_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.LightGray;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(215, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(135, 40);
            this.panelLeft.TabIndex = 1;
            this.panelLeft.Click += new System.EventHandler(this.PanelLeft_Click);
            // 
            // TimeTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelSpent);
            this.Name = "TimeTracker";
            this.Size = new System.Drawing.Size(350, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSpent;
        private System.Windows.Forms.Panel panelLeft;
    }
}
