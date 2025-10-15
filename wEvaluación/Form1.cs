using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wEvaluacion
{
    public partial class frmActividadEvaluativa : Form
    {
        public frmActividadEvaluativa()
        {
            InitializeComponent();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            lstResumen.Items.Clear();
            var items = new List<Dispositivo>
                {
                    new Laptop { Nombre = txtNombre.Text, CostoBase = double.TryParse(txtCosto.Text, out var c1) ? c1 : 0 },
                    new Tablet { Nombre = txtNombre.Text, CostoBase = double.TryParse(txtCosto.Text, out var c2) ? c2 : 0 },
                    new Celular { Nombre = txtNombre.Text, CostoBase = double.TryParse(txtCosto.Text, out var c3) ? c3 : 0 }
                };

            foreach (var d in items)
            {
                lstResumen.Items.Add($"{d.GetType().Name} = {d.CalcularMantenimiento()}");
            }
        }
    }
}
