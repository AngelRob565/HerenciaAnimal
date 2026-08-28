namespace HerenciaAnimal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            radPerro = new RadioButton();
            radGato = new RadioButton();
            grpAnimal = new GroupBox();
            grpDatosAnimal = new GroupBox();
            cbDomesticado = new CheckBox();
            cbVacuna = new CheckBox();
            txtColorGato = new TextBox();
            txtRaza = new TextBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            lblDomesticado = new Label();
            lblColorGato = new Label();
            lblVacunado = new Label();
            lblRaza = new Label();
            lblEdad = new Label();
            lblNombre = new Label();
            btnCapturarDatos = new Button();
            btnMostrarDatos = new Button();
            grpAnimal.SuspendLayout();
            grpDatosAnimal.SuspendLayout();
            SuspendLayout();
            // 
            // radPerro
            // 
            radPerro.AutoSize = true;
            radPerro.Location = new Point(34, 44);
            radPerro.Name = "radPerro";
            radPerro.Size = new Size(64, 24);
            radPerro.TabIndex = 0;
            radPerro.TabStop = true;
            radPerro.Text = "Perro";
            radPerro.UseVisualStyleBackColor = true;
            radPerro.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radGato
            // 
            radGato.AutoSize = true;
            radGato.Location = new Point(34, 74);
            radGato.Name = "radGato";
            radGato.Size = new Size(62, 24);
            radGato.TabIndex = 1;
            radGato.TabStop = true;
            radGato.Text = "Gato";
            radGato.UseVisualStyleBackColor = true;
            radGato.CheckedChanged += radGato_CheckedChanged;
            // 
            // grpAnimal
            // 
            grpAnimal.Controls.Add(radPerro);
            grpAnimal.Controls.Add(radGato);
            grpAnimal.Location = new Point(243, 28);
            grpAnimal.Name = "grpAnimal";
            grpAnimal.Size = new Size(250, 125);
            grpAnimal.TabIndex = 2;
            grpAnimal.TabStop = false;
            grpAnimal.Text = "Animal";
            // 
            // grpDatosAnimal
            // 
            grpDatosAnimal.Controls.Add(cbDomesticado);
            grpDatosAnimal.Controls.Add(cbVacuna);
            grpDatosAnimal.Controls.Add(txtColorGato);
            grpDatosAnimal.Controls.Add(txtRaza);
            grpDatosAnimal.Controls.Add(txtEdad);
            grpDatosAnimal.Controls.Add(txtNombre);
            grpDatosAnimal.Controls.Add(lblDomesticado);
            grpDatosAnimal.Controls.Add(lblColorGato);
            grpDatosAnimal.Controls.Add(lblVacunado);
            grpDatosAnimal.Controls.Add(lblRaza);
            grpDatosAnimal.Controls.Add(lblEdad);
            grpDatosAnimal.Controls.Add(lblNombre);
            grpDatosAnimal.Location = new Point(239, 187);
            grpDatosAnimal.Name = "grpDatosAnimal";
            grpDatosAnimal.Size = new Size(549, 251);
            grpDatosAnimal.TabIndex = 3;
            grpDatosAnimal.TabStop = false;
            grpDatosAnimal.Text = "Datos del Animal";
            // 
            // cbDomesticado
            // 
            cbDomesticado.AutoSize = true;
            cbDomesticado.Location = new Point(219, 205);
            cbDomesticado.Name = "cbDomesticado";
            cbDomesticado.Size = new Size(18, 17);
            cbDomesticado.TabIndex = 13;
            cbDomesticado.UseVisualStyleBackColor = true;
            cbDomesticado.CheckedChanged += cbDomesticado_CheckedChanged;
            // 
            // cbVacuna
            // 
            cbVacuna.AutoSize = true;
            cbVacuna.Location = new Point(191, 135);
            cbVacuna.Name = "cbVacuna";
            cbVacuna.Size = new Size(18, 17);
            cbVacuna.TabIndex = 12;
            cbVacuna.UseVisualStyleBackColor = true;
            cbVacuna.CheckedChanged += cbVacuna_CheckedChanged;
            // 
            // txtColorGato
            // 
            txtColorGato.Location = new Point(129, 167);
            txtColorGato.Name = "txtColorGato";
            txtColorGato.Size = new Size(125, 27);
            txtColorGato.TabIndex = 10;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(123, 102);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(125, 27);
            txtRaza.TabIndex = 8;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(79, 65);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 27);
            txtEdad.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(81, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 6;
            // 
            // lblDomesticado
            // 
            lblDomesticado.AutoSize = true;
            lblDomesticado.Location = new Point(11, 202);
            lblDomesticado.Name = "lblDomesticado";
            lblDomesticado.Size = new Size(193, 20);
            lblDomesticado.TabIndex = 5;
            lblDomesticado.Text = "¿Esta domesticado el Gato?";
            // 
            // lblColorGato
            // 
            lblColorGato.AutoSize = true;
            lblColorGato.Location = new Point(11, 170);
            lblColorGato.Name = "lblColorGato";
            lblColorGato.Size = new Size(106, 20);
            lblColorGato.TabIndex = 4;
            lblColorGato.Text = "Color del Gato";
            // 
            // lblVacunado
            // 
            lblVacunado.AutoSize = true;
            lblVacunado.Location = new Point(11, 138);
            lblVacunado.Name = "lblVacunado";
            lblVacunado.Size = new Size(174, 20);
            lblVacunado.TabIndex = 3;
            lblVacunado.Text = "¿Esta vacunado el perro?";
            // 
            // lblRaza
            // 
            lblRaza.AutoSize = true;
            lblRaza.Location = new Point(11, 102);
            lblRaza.Name = "lblRaza";
            lblRaza.Size = new Size(106, 20);
            lblRaza.TabIndex = 2;
            lblRaza.Text = "Raza del perro";
            lblRaza.Click += label3_Click;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(11, 65);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "Edad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(11, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // btnCapturarDatos
            // 
            btnCapturarDatos.Location = new Point(539, 44);
            btnCapturarDatos.Name = "btnCapturarDatos";
            btnCapturarDatos.Size = new Size(182, 29);
            btnCapturarDatos.TabIndex = 4;
            btnCapturarDatos.Text = "Capturar Datos";
            btnCapturarDatos.UseVisualStyleBackColor = true;
            btnCapturarDatos.Click += btnCapturarDatos_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(539, 97);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(182, 29);
            btnMostrarDatos.TabIndex = 5;
            btnMostrarDatos.Text = "Mostrar Datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnCapturarDatos);
            Controls.Add(grpDatosAnimal);
            Controls.Add(grpAnimal);
            Name = "Form1";
            Text = "Animal";
            grpAnimal.ResumeLayout(false);
            grpAnimal.PerformLayout();
            grpDatosAnimal.ResumeLayout(false);
            grpDatosAnimal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton radPerro;
        private RadioButton radGato;
        private GroupBox grpAnimal;
        private GroupBox grpDatosAnimal;
        private Label lblDomesticado;
        private Label lblColorGato;
        private Label lblVacunado;
        private Label lblRaza;
        private Label lblEdad;
        private Label lblNombre;
        private TextBox txtDomesticadoGato;
        private TextBox txtColorGato;
        private TextBox txtVacunaPerro;
        private TextBox txtRaza;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Button btnCapturarDatos;
        private Button btnMostrarDatos;
        private CheckBox cbVacuna;
        private CheckBox cbDomesticado;
    }
}
