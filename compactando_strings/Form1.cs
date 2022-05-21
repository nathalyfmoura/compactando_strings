using System;
using System.IO.Compression;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using compactando_strings;

namespace compactando_strings
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCompactaString_Click(object sender, System.EventArgs e)
        {
            txtTextoCompactado.Text = CompactaTexto.Compacta(txtTexto.Text);
        }

        private void btnDescompactaString_Click(object sender, System.EventArgs e)
        {
            txtTextoDescompactado.Text = CompactaTexto.Descompacta(txtTextoCompactado.Text);
        }


    }
}
