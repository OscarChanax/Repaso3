using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso3
{
    public partial class FormPropiedades : Form
    {
        List<Propiedad> propiedades = new List<Propiedad>();
        public FormPropiedades()
        {
            InitializeComponent();
        }
        private void GuardarPropiedades()
        {
            FileStream stream = new FileStream("Propiedades.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var propiedad in propiedades)
            {
                writer.WriteLine(propiedad.numeroCasa);
                writer.WriteLine(propiedad.dpiDueno);
                writer.WriteLine(propiedad.cuota);
            }
            writer.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Propiedad propiedad = new Propiedad();
            propiedad.numeroCasa = textBoxNocasa.Text;
            propiedad.dpiDueno = textBoxDpi.Text;
            propiedad.cuota = Convert.ToDecimal(textBoxCuota.Text);
            propiedades.Add(propiedad);
            GuardarPropiedades();

            textBoxNocasa.Clear();         //RESETEA CUADRO DE TEXTO
            textBoxDpi.Clear();         //RESETEA CUADRO DE TEXTO
            textBoxCuota.Clear();         //RESETEA CUADRO DE TEXTO
        }
    }
}
