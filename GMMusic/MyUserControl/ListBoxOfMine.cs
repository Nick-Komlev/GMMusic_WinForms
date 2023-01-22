using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMMusic
{    public class ListBoxOfMine : Panel
    {
        public int Last { get; set; }

        public ListBoxOfMine() : base()
        {
        }

        public void FillTheLines(List<string> tags)
        {
            foreach (string tag in tags)
                AddTB(tag);
            AddTB("");
        }

        public void InitAdd()
        {
            AddTB("");
        }

        private void AddTB(string tag)
        {
            TextBox tb = new TextBox();
            tb.Text = tag;
            tb.Tag = ++Last;
            tb.Dock = DockStyle.Top;
            tb.Leave += Tb_Leave;
            tb.Enter += Tb_Enter; ;
            Controls.Add(tb);
        }

        private void Tb_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (((int)tb.Tag == Last))
                AddTB("");
        }

        private void Tb_Leave(object sender, EventArgs e)
        {
            if (((sender as TextBox).Text == "") && ((int)(sender as TextBox).Tag != Last))
                Controls.Remove((sender as TextBox));               
        }
    }
}
