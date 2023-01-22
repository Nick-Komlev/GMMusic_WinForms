namespace GMMusic
{
    partial class PlaylistElement
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
            this.contextCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.movePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.movePanel.SuspendLayout();
            this.timePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackLbl
            // 
            this.trackLbl.AutoSize = true;
            this.trackLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.trackLbl.Location = new System.Drawing.Point(30, 7);
            this.trackLbl.Name = "trackLbl";
            this.trackLbl.Size = new System.Drawing.Size(169, 16);
            this.trackLbl.TabIndex = 1;
            this.trackLbl.Text = "Исполнитель - название";
            this.trackLbl.DoubleClick += new System.EventHandler(this.TrackLbl_DoubleClick);
            this.trackLbl.MouseEnter += new System.EventHandler(this.TrackLbl_MouseEnter);
            this.trackLbl.MouseLeave += new System.EventHandler(this.TrackLbl_MouseLeave);
            // 
            // contextCMS
            // 
            this.contextCMS.Name = "contextCMS";
            this.contextCMS.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "00:00";
            // 
            // movePanel
            // 
            this.movePanel.BackColor = System.Drawing.SystemColors.Info;
            this.movePanel.Controls.Add(this.label2);
            this.movePanel.Location = new System.Drawing.Point(0, 0);
            this.movePanel.Name = "movePanel";
            this.movePanel.Size = new System.Drawing.Size(28, 30);
            this.movePanel.TabIndex = 5;
            this.movePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseDown);
            this.movePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseMove);
            this.movePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "=";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label2_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label2_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label2_MouseUp);
            // 
            // timePanel
            // 
            this.timePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timePanel.Controls.Add(this.label1);
            this.timePanel.Location = new System.Drawing.Point(233, 0);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(39, 30);
            this.timePanel.TabIndex = 6;
            // 
            // PlaylistElement
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.movePanel);
            this.Controls.Add(this.trackLbl);
            this.Name = "PlaylistElement";
            this.Size = new System.Drawing.Size(271, 30);
            this.DoubleClick += new System.EventHandler(this.PlaylistElement_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.TrackLink_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.TrackLink_MouseLeave);
            this.movePanel.ResumeLayout(false);
            this.movePanel.PerformLayout();
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label trackLbl;
        private System.Windows.Forms.ContextMenuStrip contextCMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel movePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel timePanel;
    }
}
