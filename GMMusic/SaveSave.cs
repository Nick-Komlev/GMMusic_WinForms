using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMMusic
{
    public partial class SaveSave : Form
    {
        public SaveSave()
        {
            InitializeComponent();
        }

        private void NewRB_CheckedChanged(object sender, EventArgs e)
        {
            nameTB.Enabled = newRB.Checked;
            saveCB.Enabled = !newRB.Checked;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (newRB.Checked)
            {
                if (nameTB.Text == "")
                    MessageBox.Show("Заполните поле имени");
                else if (saveCB.Items.Contains(nameTB.Text))
                    MessageBox.Show("Такой уже существует");
                else
                {
                    Singleton.Saves.Add(new Save(nameTB.Text, Singleton.MTL.MT[0].Playlist_,
                                                              Singleton.MTL.MT[1].Playlist_, 
                                                              Singleton.MTL.MT[2].Playlist_));
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                if (!saveCB.Items.Contains(saveCB.Text))
                {
                    MessageBox.Show("Выберите существующую сохраненку");
                }
                else
                {
                    Singleton.Saves.Find(s => s.Name == saveCB.Text).Update( Singleton.MTL.MT[0].Playlist_,
                                                              Singleton.MTL.MT[1].Playlist_, 
                                                              Singleton.MTL.MT[2].Playlist_);
                    DialogResult = DialogResult.OK;
                }
            }
            
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveSave_Load(object sender, EventArgs e)
        {
            nameTB.Enabled = newRB.Checked;
            saveCB.Enabled = !newRB.Checked;

            saveCB.Items.AddRange(Singleton.Saves.ToArray());
        }
    }
}
