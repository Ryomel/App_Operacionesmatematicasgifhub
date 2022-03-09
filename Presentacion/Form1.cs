using System;
using System.Windows.Forms;
using Negocio;
namespace Presentacion
{
    public partial class Form1 : Form
    {
        clsOperaciones objoperaciones = new clsOperaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void ptbnumeroq_Click(object sender, EventArgs e)
        {
            objoperaciones.setnumero1(Convert.ToDouble(txtnumero1.Text));
        }

        private void ptbnumero2_Click(object sender, EventArgs e)
        {
            objoperaciones.setnumero2(Convert.ToDouble(txtnumero2.Text));
        }

        private void ptbcalcular_Click(object sender, EventArgs e)
        {
            objoperaciones.setCalcularOperacion(cmboperacion.SelectedIndex);
            lblresultado.Text = Convert.ToString(objoperaciones.getresultado());
            if (objoperaciones.getmensaje() == "")
            {
                MessageBox.Show(objoperaciones.getmensaje());
            }
        }
    }
}
