using Entidades;

namespace Integrador
{
    public partial class FormCalculadora : Form
    {
        // Declaración de variables y objetos de clase
        private bool mensajeMostrado = false;  // Bandera para controlar si se mostró un mensaje de confirmación
        private ESistema sistema = ESistema.SistemaDecimal;  // Sistema numérico predeterminado
        Numeracion resultado = new Numeracion(ESistema.SistemaDecimal, 0.0);  // Objeto para almacenar el resultado
        bool flag = false;  // Bandera para controlar ciertos estados

        // Constructor de la clase FormCalculadora
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load_1(object sender, EventArgs e)
        {

        }

        // Evento al cerrar el formulario
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!mensajeMostrado)
            {
                // Mostrar un cuadro de diálogo de confirmación
                DialogResult resultado = MessageBox.Show("¿Desea cerrar la calculadora?", "Cierre",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Guardar cambios (si es necesario)
                }
                else if (resultado == DialogResult.No)
                {
                    // Cancelar el cierre del formulario
                    e.Cancel = true;
                }

                mensajeMostrado = true;
            }
            mensajeMostrado = false;
        }

        // Evento al hacer clic en el botón "Cerrar"
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Evento al hacer clic en el botón "Limpiar"
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "Resultado: ";
            textBox1.Text = "";
            textBox2.Text = "";

            radioButton2.Checked = false;
            radioButton1.Checked = true;

            Numeracion resu = new Numeracion(ESistema.SistemaDecimal,0.0);
            resultado = resu;

        }


        // Evento al hacer clic en el radiobutton "Decimal"
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            sistema = ESistema.SistemaDecimal;

            if (!flag) 
            {
                if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "" && resultado.GetValorNumerico() > 0)
                {

                    setResultado(resultado);
                }


            }

        }

        // Evento al hacer clic en el radiobutton "Binario"
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            sistema = ESistema.SistemaBinario;

            if (!flag)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "" && resultado.GetValorNumerico() > 0)
                {
                    setResultado(resultado);
                }
            }


        }

        // Metodo para validar y mostrar el resultado
        private void setResultado(Numeracion resultado)
        {

            if (sistema == ESistema.SistemaDecimal)
            {

                labelResultado.Text = "Resultado: " + resultado.ConvertirA(ESistema.SistemaDecimal);
                flag = false;
            }

            if (sistema == ESistema.SistemaBinario)
            {

                string resu = resultado.ConvertirA(ESistema.SistemaBinario);

                if (resu == "" || resu == "Número Inválido")

                {
                    MessageBox.Show("Si esta seleccionado el SISTEMA BINARIO. Por favor, Ingrese valores solo BINARIOS numéricos válidos.", "Error de BINARIO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (resu == textBox1.Text && textBox2.Text != "1")
                {
                    if (textBox2.Text == "0")
                    {

                        labelResultado.Text = "Resultado: " + resu;
                        flag = false;

                    }
                    else
                    {

                        MessageBox.Show("Si esta seleccionado el SISTEMA BINARIO. Por favor, Ingrese valores solo BINARIOS numéricos válidos.", "Error de BINARIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = true;
                    }


                }

                else if (resu == textBox2.Text && textBox1.Text != "1")
                {
                    if (textBox1.Text == "0")
                    {

                        labelResultado.Text = "Resultado: " + resu;
                        flag = false;

                    }
                    else
                    {

                        MessageBox.Show("Si esta seleccionado el SISTEMA BINARIO. Por favor, Ingrese valores solo BINARIOS numéricos válidos.", "Error de BINARIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = true;
                    }


                }
                else if (resu == "0")
                {
                    MessageBox.Show("Si esta seleccionado el SISTEMA BINARIO. Por favor, Ingrese valores solo BINARIOS numéricos válidos.", "Error de BINARIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = true;
                }

                else
                {
                    labelResultado.Text = "Resultado: " + resu;
                    flag = false;
                }
            }

        }

        // Evento al hacer clic en el botón "Operar"
        private void btnOperar_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBox1.Text, out double valorNumero1) &&
                double.TryParse(textBox2.Text, out double valorNumero2))

            {
                // Crear instancias de Numeracion

                Numeracion numeracion1 = new Numeracion(sistema, valorNumero1);
                Numeracion numeracion2 = new Numeracion(sistema, valorNumero2);

                // Obtener el operador seleccionado del ComboBox como una cadenag();

                Operacion operacion = new Operacion(numeracion1, numeracion2);

                // Verificar si se seleccionó un operador

                if (comboBox1.SelectedItem != null)
                {
                    string operadorSeleccionadoString = comboBox1.SelectedItem.ToString();

                    // Convertir la cadena a un char
                    char operadorSeleccionado = operadorSeleccionadoString[0]; ;

                    // Realizar la operación deseada 
                    resultado = operacion.Operar(operadorSeleccionado);

                    // Muestra el resultado
                    setResultado(resultado);

                }

                else
                {

                    MessageBox.Show("Por favor, seleccione un OPERADOR valido", "Error de OPERADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Si esta seleccionado el SISTEMA DECIMAL. Por favor, Ingrese valores solo valores numéricos válidos.", "Error de DECIMAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}