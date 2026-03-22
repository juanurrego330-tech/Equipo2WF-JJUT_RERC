namespace Equipo2WF_JJUT_RERC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int contadorTrabajores = 1;
        private int Complemento = 5000;
        double mostrarSueldoBruto;
        double mostrarExencion;
        double mostrarRetencionDeImpuestos;
        double mostrarSueldoNeto;
        private List<string[]> listaEmpleados = new List<string[]>();
        public bool ValidarCampos()
        {
            if (textBox1.Text == "" || comboBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }
            return true;
        }
        public bool ValidarNumeros()
        {
            if (!double.TryParse(textBox2.Text, out double sueldoBruto))
            {
                MessageBox.Show("Por favor, ingrese un número válido para el sueldo bruto.");
                return false;
            }
            if (!double.TryParse(textBox3.Text, out double exencion))
            {
                MessageBox.Show("Por favor, ingrese un número válido para la exención.");
                return false;
            }
            if (!int.TryParse(textBox4.Text, out int numeroSemanas))
            {
                MessageBox.Show("Por favor, ingrese un número entero para el numero de semanas.");
                return false;
            }
            return true;
        }
        public void MostrarDatos()
        {
            mostrarSueldoBruto = double.Parse(textBox2.Text);
            mostrarExencion = double.Parse(textBox3.Text);
            TemporizadorResultados.Start();
            if (comboBox1.SelectedIndex == 3)
            {
                mostrarSueldoBruto += Complemento;
            }
            mostrarRetencionDeImpuestos = ((mostrarSueldoBruto - mostrarExencion) * 0.33);
            mostrarSueldoNeto = mostrarSueldoBruto - mostrarRetencionDeImpuestos;

            label6.Text = "Sueldo Bruto Total:" + mostrarSueldoBruto.ToString("C");
            label7.Text = "Retención De Impuestos:" + mostrarRetencionDeImpuestos.ToString("C");
            label8.Text = "Sueldo Neto A Cobrar:" + mostrarSueldoNeto.ToString("C");

        }

        public void GuardarDatos()
        {
            string[] datos = new string[8];
            datos[0] = "Trabajador #" + (listaEmpleados.Count + 1) + ": " + textBox1.Text;
            datos[1] = comboBox1.Text;
            datos[2] = textBox2.Text;
            datos[3] = textBox3.Text;
            datos[4] = textBox4.Text;
            datos[5] = mostrarSueldoBruto.ToString("C");
            datos[6] = mostrarRetencionDeImpuestos.ToString("C");
            datos[7] = mostrarSueldoNeto.ToString("C");
            listaEmpleados.Add(datos);

        }
        public void LimpiarCampos()
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (ValidarNumeros())
                {
                    contadorTrabajores++;
                    label1.Text = "Nombre Del Empleado #" + contadorTrabajores.ToString() + ":";
                    MostrarDatos();
                    GuardarDatos();
                }

            }
        }

        private void TemporizadorResultados_Tick(object sender, EventArgs e)
        {
            TemporizadorResultados.Stop();
            label6.Text = "Sueldo Bruto Total:";
            label7.Text = "Retención De Impuestos:";
            label8.Text = "Sueldo Neto A Cobrar:";
            LimpiarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 VentanaInformacionEmpleados = new Form2(listaEmpleados);
            VentanaInformacionEmpleados.ShowDialog();
        }
    }
}
