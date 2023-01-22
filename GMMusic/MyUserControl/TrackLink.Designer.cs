namespace GMMusic
{
    partial class TrackLink
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
            this.trackLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // trackLbl
            // 
            this.trackLbl.AutoSize = true;
            this.trackLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.trackLbl.Location = new System.Drawing.Point(4, 6);
            this.trackLbl.Name = "trackLbl";
            this.trackLbl.Size = new System.Drawing.Size(169, 16);
            this.trackLbl.TabIndex = 0;
            this.trackLbl.Text = "Исполнитель - название";
            this.trackLbl.DoubleClick += new System.EventHandler(this.TrackLbl_DoubleClick);
            this.trackLbl.MouseEnter += new System.EventHandler(this.TrackLbl_MouseEnter);
            this.trackLbl.MouseLeave += new System.EventHandler(this.TrackLbl_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "00:00";
            // 
            // contextCMS
            // 
            this.contextCMS.Name = "contextCMS";
            this.contextCMS.Size = new System.Drawing.Size(61, 4);
            // 
            // TrackLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackLbl);
            this.Name = "TrackLink";
            this.Size = new System.Drawing.Size(418, 29);
            this.DoubleClick += new System.EventHandler(this.TrackLink_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.TrackLink_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.TrackLink_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label trackLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextCMS;
    }
}
