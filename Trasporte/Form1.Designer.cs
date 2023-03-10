namespace Trasporte
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbpeso = new System.Windows.Forms.Label();
            this.lbAño = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbTransporte = new System.Windows.Forms.Label();
            this.chkMarchamo = new System.Windows.Forms.CheckBox();
            this.chkLicencia = new System.Windows.Forms.CheckBox();
            this.chkRiteve = new System.Windows.Forms.CheckBox();
            this.lbMotor = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lbVelocidad = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lbAsientos = new System.Windows.Forms.Label();
            this.lbPuertas = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbKilometraje = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.lbInformacion = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(518, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 284);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.BackColor = System.Drawing.Color.Transparent;
            this.lbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbModel.Location = new System.Drawing.Point(21, 58);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(61, 20);
            this.lbModel.TabIndex = 3;
            this.lbModel.Text = "Modelo";
            this.lbModel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.BackColor = System.Drawing.Color.Transparent;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMarca.Location = new System.Drawing.Point(21, 91);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(53, 20);
            this.lbMarca.TabIndex = 4;
            this.lbMarca.Text = "Marca";
            this.lbMarca.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.BackColor = System.Drawing.Color.Transparent;
            this.lbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbColor.Location = new System.Drawing.Point(21, 116);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(46, 20);
            this.lbColor.TabIndex = 5;
            this.lbColor.Text = "Color";
            // 
            // lbpeso
            // 
            this.lbpeso.AutoSize = true;
            this.lbpeso.BackColor = System.Drawing.Color.Transparent;
            this.lbpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbpeso.Location = new System.Drawing.Point(21, 151);
            this.lbpeso.Name = "lbpeso";
            this.lbpeso.Size = new System.Drawing.Size(45, 20);
            this.lbpeso.TabIndex = 6;
            this.lbpeso.Text = "Peso";
            // 
            // lbAño
            // 
            this.lbAño.AutoSize = true;
            this.lbAño.BackColor = System.Drawing.Color.Transparent;
            this.lbAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbAño.Location = new System.Drawing.Point(21, 207);
            this.lbAño.Name = "lbAño";
            this.lbAño.Size = new System.Drawing.Size(38, 20);
            this.lbAño.TabIndex = 7;
            this.lbAño.Text = "Año";
            this.lbAño.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(108, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(108, 209);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(108, 235);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(190, 20);
            this.textBox5.TabIndex = 12;
            // 
            // lbTransporte
            // 
            this.lbTransporte.AutoSize = true;
            this.lbTransporte.BackColor = System.Drawing.Color.Transparent;
            this.lbTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbTransporte.Location = new System.Drawing.Point(306, 9);
            this.lbTransporte.Name = "lbTransporte";
            this.lbTransporte.Size = new System.Drawing.Size(282, 31);
            this.lbTransporte.TabIndex = 13;
            this.lbTransporte.Text = "Formulario Transporte";
            this.lbTransporte.Click += new System.EventHandler(this.label6_Click);
            // 
            // chkMarchamo
            // 
            this.chkMarchamo.AutoSize = true;
            this.chkMarchamo.BackColor = System.Drawing.Color.Transparent;
            this.chkMarchamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkMarchamo.Location = new System.Drawing.Point(346, 136);
            this.chkMarchamo.Name = "chkMarchamo";
            this.chkMarchamo.Size = new System.Drawing.Size(103, 24);
            this.chkMarchamo.TabIndex = 14;
            this.chkMarchamo.Text = "Marchamo";
            this.chkMarchamo.UseVisualStyleBackColor = false;
            this.chkMarchamo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkLicencia
            // 
            this.chkLicencia.AutoSize = true;
            this.chkLicencia.BackColor = System.Drawing.Color.Transparent;
            this.chkLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkLicencia.Location = new System.Drawing.Point(346, 176);
            this.chkLicencia.Name = "chkLicencia";
            this.chkLicencia.Size = new System.Drawing.Size(127, 24);
            this.chkLicencia.TabIndex = 15;
            this.chkLicencia.Text = "Licencia al día";
            this.chkLicencia.UseVisualStyleBackColor = false;
            // 
            // chkRiteve
            // 
            this.chkRiteve.AutoSize = true;
            this.chkRiteve.BackColor = System.Drawing.Color.Transparent;
            this.chkRiteve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkRiteve.Location = new System.Drawing.Point(346, 91);
            this.chkRiteve.Name = "chkRiteve";
            this.chkRiteve.Size = new System.Drawing.Size(73, 24);
            this.chkRiteve.TabIndex = 16;
            this.chkRiteve.Text = "Riteve";
            this.chkRiteve.UseVisualStyleBackColor = false;
            // 
            // lbMotor
            // 
            this.lbMotor.AutoSize = true;
            this.lbMotor.BackColor = System.Drawing.Color.Transparent;
            this.lbMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMotor.Location = new System.Drawing.Point(21, 233);
            this.lbMotor.Name = "lbMotor";
            this.lbMotor.Size = new System.Drawing.Size(50, 20);
            this.lbMotor.TabIndex = 17;
            this.lbMotor.Text = "Motor";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(108, 60);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(190, 20);
            this.txtModelo.TabIndex = 18;
            // 
            // lbVelocidad
            // 
            this.lbVelocidad.AutoSize = true;
            this.lbVelocidad.BackColor = System.Drawing.Color.Transparent;
            this.lbVelocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbVelocidad.Location = new System.Drawing.Point(23, 352);
            this.lbVelocidad.Name = "lbVelocidad";
            this.lbVelocidad.Size = new System.Drawing.Size(79, 20);
            this.lbVelocidad.TabIndex = 19;
            this.lbVelocidad.Text = "Velocidad";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(108, 180);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(190, 20);
            this.textBox7.TabIndex = 20;
            // 
            // lbAsientos
            // 
            this.lbAsientos.AutoSize = true;
            this.lbAsientos.BackColor = System.Drawing.Color.Transparent;
            this.lbAsientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbAsientos.Location = new System.Drawing.Point(22, 268);
            this.lbAsientos.Name = "lbAsientos";
            this.lbAsientos.Size = new System.Drawing.Size(71, 20);
            this.lbAsientos.TabIndex = 21;
            this.lbAsientos.Text = "Asientos";
            // 
            // lbPuertas
            // 
            this.lbPuertas.AutoSize = true;
            this.lbPuertas.BackColor = System.Drawing.Color.Transparent;
            this.lbPuertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbPuertas.Location = new System.Drawing.Point(22, 297);
            this.lbPuertas.Name = "lbPuertas";
            this.lbPuertas.Size = new System.Drawing.Size(64, 20);
            this.lbPuertas.TabIndex = 22;
            this.lbPuertas.Text = "Puertas";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbPlaca.Location = new System.Drawing.Point(22, 325);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(48, 20);
            this.lbPlaca.TabIndex = 23;
            this.lbPlaca.Text = "Placa";
            this.lbPlaca.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.BackColor = System.Drawing.Color.Transparent;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTipo.Location = new System.Drawing.Point(12, 387);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(199, 20);
            this.lbTipo.TabIndex = 24;
            this.lbTipo.Text = "Tipo(Manual o Automatico)";
            this.lbTipo.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbKilometraje
            // 
            this.lbKilometraje.AutoSize = true;
            this.lbKilometraje.BackColor = System.Drawing.Color.Transparent;
            this.lbKilometraje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbKilometraje.Location = new System.Drawing.Point(15, 178);
            this.lbKilometraje.Name = "lbKilometraje";
            this.lbKilometraje.Size = new System.Drawing.Size(87, 20);
            this.lbKilometraje.TabIndex = 25;
            this.lbKilometraje.Text = "Kilometraje";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(108, 268);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(190, 20);
            this.textBox8.TabIndex = 26;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(108, 294);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(190, 20);
            this.textBox9.TabIndex = 27;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(108, 352);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(190, 20);
            this.textBox10.TabIndex = 28;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(229, 387);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(190, 20);
            this.textBox12.TabIndex = 30;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(108, 322);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(190, 20);
            this.textBox13.TabIndex = 31;
            // 
            // lbInformacion
            // 
            this.lbInformacion.AutoSize = true;
            this.lbInformacion.BackColor = System.Drawing.Color.Transparent;
            this.lbInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbInformacion.Location = new System.Drawing.Point(612, 72);
            this.lbInformacion.Name = "lbInformacion";
            this.lbInformacion.Size = new System.Drawing.Size(216, 26);
            this.lbInformacion.TabIndex = 32;
            this.lbInformacion.Text = "Informacion Vehiculo";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(27, 477);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(94, 23);
            this.btnEnviar.TabIndex = 33;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(138, 477);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 23);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(518, 453);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(398, 20);
            this.textBox6.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(929, 532);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lbInformacion);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.lbKilometraje);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.lbPuertas);
            this.Controls.Add(this.lbAsientos);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.lbVelocidad);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lbMotor);
            this.Controls.Add(this.chkRiteve);
            this.Controls.Add(this.chkLicencia);
            this.Controls.Add(this.chkMarchamo);
            this.Controls.Add(this.lbTransporte);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbAño);
            this.Controls.Add(this.lbpeso);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbModel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label lbpeso;
        private System.Windows.Forms.Label lbAño;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbTransporte;
        private System.Windows.Forms.CheckBox chkMarchamo;
        private System.Windows.Forms.CheckBox chkLicencia;
        private System.Windows.Forms.CheckBox chkRiteve;
        private System.Windows.Forms.Label lbMotor;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lbVelocidad;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lbAsientos;
        private System.Windows.Forms.Label lbPuertas;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbKilometraje;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label lbInformacion;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox textBox6;
    }
}

