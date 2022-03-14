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
    public partial class FormPropietarios : Form
    {
        List<Propietario> propietarios = new List<Propietario>();
        public FormPropietarios()
        {
            InitializeComponent();
        }
        private void GuardarPropietarios()
        {
            FileStream stream = new FileStream("Propietarios.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var propietario in propietarios)
            {
                writer.WriteLine(propietario.dpi);
                writer.WriteLine(propietario.nombre);
                writer.WriteLine(propietario.apellido);
            }
            writer.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Propietario propietario = new Propietario();
            propietario.dpi = textBoxDpi.Text;
            propietario.nombre = textBoxNombre.Text;
            propietario.apellido = textBoxApellido.Text;
            propietarios.Add(propietario);
            GuardarPropietarios();
            
            textBoxDpi.Clear();         //RESETEA CUADRO DE TEXTO
            textBoxNombre.Clear();         //RESETEA CUADRO DE TEXTO
            textBoxApellido.Clear();         //RESETEA CUADRO DE TEXTO
        }
    }
}
