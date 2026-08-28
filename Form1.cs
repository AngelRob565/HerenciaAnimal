using System.Diagnostics.Eventing.Reader;

namespace HerenciaAnimal
{
    public partial class Form1 : Form
    {
        Perro unPerro;
        Gato unGato;
        string resultado;
        public Form1()
        {
            InitializeComponent();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            lblRaza.Visible = radPerro.Visible;
            txtRaza.Visible = radPerro.Visible;
            lblVacunado.Visible = radPerro.Visible;
            cbVacuna.Visible = radPerro.Visible;
            lblColorGato.Enabled = false;
            txtColorGato.Enabled = false;
            lblDomesticado.Enabled = false;
            cbDomesticado.Enabled = false;
            lblRaza.Enabled = true;
            txtRaza.Enabled = true;
            lblVacunado.Enabled = true;
            cbVacuna.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            foreach (Control c in grpAnimal.Controls)
                if (c is TextBox)
                    c.Text = "";
        }

        private void btnCapturarDatos_Click(object sender, EventArgs e)
        {


            if (radPerro.Checked)
            {
                unPerro = new Perro(txtNombre.Text, int.Parse(txtEdad.Text),txtRaza.Text,cbVacuna.Checked);
                MessageBox.Show("Datos Capturados del Perro");

            }
            else if (radGato.Checked)
            {
                unGato = new Gato(txtNombre.Text, int.Parse(txtEdad.Text),txtColorGato.Text,cbDomesticado.Checked);
                MessageBox.Show("Datos Capturados del Gato");
            }
            Limpiar();
        }
        private void radGato_CheckedChanged(object sender, EventArgs e)
        {
            lblColorGato.Visible = radGato.Visible;
            txtColorGato.Visible = radGato.Visible;
            lblDomesticado.Visible = radGato.Visible;
            cbDomesticado.Visible = radGato.Visible;
            lblRaza.Enabled = false;
            txtRaza.Enabled = false;
            lblVacunado.Enabled = false;
            cbVacuna.Enabled = false;
            txtColorGato.Enabled = true;
            lblColorGato.Enabled = true;
            lblDomesticado.Enabled = true;
            cbDomesticado.Enabled = true;
        }


        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {


            if (radPerro.Checked)
                MessageBox.Show(unPerro.ToString());
                //MessageBox.Show("Datos del Perro\nNombre: " + unPerro.Nombre + "\nEdad: " + unPerro.Edad + " años" + "\n" + unPerro.HacerSonido() + "\nRaza del perro: " + unPerro.Raza + "\nEsta Vacunado: " + ((unPerro.EstaVacunado == true) ? "si" : "no"));

            if (radGato.Checked)
                //MessageBox.Show("Datos del Gato\nNombre: " + unGato.Nombre + "\nEdad: " + unGato.Edad + " años" + "\n " + unGato.HacerSonido() + "\nColor del Gato: " + unGato.Color + "\nEsta Domesticado: " + unGato.EstaDomesticado);
                MessageBox.Show(unGato.ToString());
        }

        private void cbVacuna_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbDomesticado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
    


