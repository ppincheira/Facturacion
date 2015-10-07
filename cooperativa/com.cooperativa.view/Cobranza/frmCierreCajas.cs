using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace com.cooperativa.view.Cobranza
{
    public partial class frmCierreCajas : Form
    {

        #region << EVENTOS >>
        public frmCierreCajas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
        #endregion

        #region << METODOS >>
        private void Salir() {
            this.Close();
        }

        #endregion
    }
}
