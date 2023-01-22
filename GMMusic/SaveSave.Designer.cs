namespace GMMusic
{
    partial class SaveSave
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
            this.newRB = new System.Windows.Forms.RadioButton();
            this.reRB = new System.Windows.Forms.RadioButton();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.saveCB = new System.Windows.Forms.ComboBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newRB
            // 
            this.newRB.AutoSize = true;
            this.newRB.Location = new System.Drawing.Point(12, 12);
            this.newRB.Name = "newRB";
            this.newRB.Size = new System.Drawing.Size(57, 17);
            this.newRB.TabIndex = 0;
            this.newRB.TabStop = true;
            this.newRB.Text = "Новое";
            this.newRB.UseVisualStyleBackColor = true;
            this.newRB.CheckedChanged += new System.EventHandler(this.NewRB_CheckedChanged);
            // 
            // reRB
            // 
            this.reRB.AutoSize = true;
            this.reRB.Location = new System.Drawing.Point(12, 61);
            this.reRB.Name = "reRB";
            this.reRB.Size = new System.Drawing.Size(98, 17);
            this.reRB.TabIndex = 1;
            this.reRB.TabStop = true;
            this.reRB.Text = "Перезаписать";
            this.reRB.UseVisualStyleBackColor = true;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(12, 35);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(266, 20);
            this.nameTB.TabIndex = 2;
            // 
            // saveCB
            // 
            this.saveCB.FormattingEnabled = true;
            this.saveCB.Location = new System.Drawing.Point(12, 84);
            this.saveCB.Name = "saveCB";
            this.saveCB.Size = new System.Drawing.Size(266, 21);
            this.saveCB.TabIndex = 3;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(203, 170);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "Сохранить";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(122, 170);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 205);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.saveCB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.reRB);
            this.Controls.Add(this.newRB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SaveSave";
            this.Text = "SaveSave";
            this.Load += new System.EventHandler(this.SaveSave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton newRB;
        private System.Windows.Forms.RadioButton reRB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.ComboBox saveCB;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}