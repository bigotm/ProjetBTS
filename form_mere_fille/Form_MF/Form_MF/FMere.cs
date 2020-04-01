using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_MF
{
    public partial class FMere : Form
    {
        private int nombreFilles;
        private List<FFille> lesFilles;
        private string nomMere;
        public FMere()
        {
            InitializeComponent();
            this.Text = "Mère";
            this.nomMere = "Maman";
            this.lesFilles = new List<FFille>();
            BtnNew.Click += new EventHandler(BtnNew_Click);
        }



        private void BtnNew_Click(object sender, EventArgs e)
        {
            FFille nouvelleFille;
            nombreFilles = nombreFilles + 1;
            nouvelleFille = new FFille(this,nombreFilles);
            lesFilles.Add(nouvelleFille);
            lbLesFIlles.Items.Add("Fille n°" + this.nombreFilles);

        }

        private void BtnShow(object sender, EventArgs e)
        {
            if (lbLesFIlles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFIlles.SelectedIndex].Show();
            }
        }

        private void BtnHide(object sender, EventArgs e)
        {
            if (lbLesFIlles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFIlles.SelectedIndex].Hide();
            }
        }

        private void BtnClose(object sender, EventArgs e)
        {
            if (lbLesFIlles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFIlles.SelectedIndex].Close();
                lbLesFIlles.Items.RemoveAt(lbLesFIlles.SelectedIndex);
            }
        }

        private void BtnShowDialog(object sender, EventArgs e)
        {
            if (lbLesFIlles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFIlles.SelectedIndex].ShowDialog();
            }

        }
    }
}
