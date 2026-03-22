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
        private string[,] Empleado;
        double mostrarSueldoBruto;
        double mostrarExencion;
        double mostrarRetencionDeImpuestos;
        double mostrarSueldoNeto;

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
            Empleado = new string[contadorTrabajores,8];
            Empleado[contadorTrabajores,1] = "Trabajador #" + contadorTrabajores + ": " + textBox1.Text;
            Empleado[contadorTrabajores,2] = "Nivel: " + comboBox1.Text;
            Empleado[contadorTrabajores,3] = "Sueldo Bruto: " + textBox2.Text;
            Empleado[contadorTrabajores,4] = "Exención: " + textBox3.Text;
            Empleado[contadorTrabajores,5] = "Número de Semanas: " + textBox4.Text;
            Empleado[contadorTrabajores,6] = "Sueldo Bruto Total: " + mostrarSueldoBruto.ToString("C");
            Empleado[contadorTrabajores,7] = "Retención De Impuestos: " + mostrarRetencionDeImpuestos.ToString("C");
            Empleado[contadorTrabajores,8] = "Sueldo Neto A Cobrar: " + mostrarSueldoNeto.ToString("C");

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
                if(ValidarNumeros())
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
        }
    }
}
