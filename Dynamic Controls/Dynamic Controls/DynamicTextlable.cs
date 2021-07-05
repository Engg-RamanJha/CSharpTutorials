using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Controls
{
    public partial class DynamicTextlable : Form
    {
        public DynamicTextlable()
        {
            InitializeComponent();
        }
        TextBox[] tbox = null;
        private void btn_gentext_Click(object sender, EventArgs e)
        {
            int x = 60;
            int y = 90;
            int j = int.Parse(textBox1.Text.Trim());
            tbox = new TextBox[j];
            for(int i=0;i< j;i++)
            {
                
                var text = new TextBox();
                text.Name = "txt" + i.ToString();
                text.Text = "TextBox" + i.ToString();
                text.Location = new Point(x, y);
                text.Size = new Size(100, 20);
                this.Controls.Add(text);
                y = y + 40;
                tbox[i] = text;

            }
        }

        private void btn_genlabel_Click(object sender, EventArgs e)
        {
            int x = 60;
            int y = 70;
            int j = int.Parse(textBox2.Text.Trim());
            for (int i = 0; i < j; i++)
            {
                var lbl = new Label();
                lbl.Name = "lbl" + i.ToString();
                lbl.Text = "label" + i.ToString();
                lbl.Location = new Point(x, y);
                this.Controls.Add(lbl);
                y = y + 40;

            }
        }

        private void btn_txtval_Click(object sender, EventArgs e)
        {
            string s=tbox[0].Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in tbox)
            {
                txt.Size =new Size(80,15);
            }
        }
    }
}
