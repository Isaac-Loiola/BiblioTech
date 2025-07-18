using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioTechClass;

namespace BiblioTechDesk
{
    public partial class UscDetalheLivro : UserControl
    {
        public UscDetalheLivro()
        {
            InitializeComponent();
        }

        private void UscDetalheLivro_Load(object sender, EventArgs e)
        {
            Livro.ObterPorId();
        }
    }
}
