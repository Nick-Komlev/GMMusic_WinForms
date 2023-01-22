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
    public partial class SaveInfo : Form
    {
        public SaveInfo()
        {
            InitializeComponent();
        }

        private void SaveInfo_Load(object sender, EventArgs e)
        {
            saveLB.Items.AddRange(Singleton.Saves.ToArray());
        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            if (searchTB.Text != "")
            {
                saveLB.Items.Clear();
                saveLB.Items.AddRange(Singleton.Saves.FindAll(s => s.Name.ToLower().Contains(searchTB.Text.ToLower())).ToArray());
            }
            else
            {
                saveLB.Items.Clear();
                saveLB.Items.AddRange(Singleton.Saves.ToArray());
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Singleton.MTL.MT[0].ConnectToList((saveLB.SelectedItem as Save).MTPL1);
            Singleton.MTL.MT[1].ConnectToList((saveLB.SelectedItem as Save).MTPL2);
            Singleton.MTL.MT[2].ConnectToList((saveLB.SelectedItem as Save).MTPL3);
            DialogResult = DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
