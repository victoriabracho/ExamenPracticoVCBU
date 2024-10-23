namespace ExamenPracticoVCBU
{
    partial class MotoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.BttListarCarros = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNuevoAño = new System.Windows.Forms.TextBox();
            this.txtNuevaMarca = new System.Windows.Forms.TextBox();
            this.txtNuevoModelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreAntiguo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstMotos = new System.Windows.Forms.ListBox();
            this.btnActualizarCarro = new System.Windows.Forms.Button();
            this.btnEliminarCarro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreEliminar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnAlmacenarCarro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(63, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 54);
            this.button1.TabIndex = 58;
            this.button1.Text = "REGRESAR AL MENÚ PRINCIPAL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BttListarCarros
            // 
            this.BttListarCarros.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BttListarCarros.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttListarCarros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BttListarCarros.Location = new System.Drawing.Point(304, 197);
            this.BttListarCarros.Name = "BttListarCarros";
            this.BttListarCarros.Size = new System.Drawing.Size(203, 47);
            this.BttListarCarros.TabIndex = 57;
            this.BttListarCarros.Text = "LISTAR MOTOS ALMACENADAS";
            this.BttListarCarros.UseVisualStyleBackColor = false;
            this.BttListarCarros.Click += new System.EventHandler(this.BttListarCarros_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Teal;
            this.label13.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label13.Location = new System.Drawing.Point(637, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 17);
            this.label13.TabIndex = 56;
            this.label13.Text = "Nuevo nombre ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.BackColor = System.Drawing.Color.Teal;
            this.txtNombreNuevo.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNombreNuevo.Location = new System.Drawing.Point(634, 155);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(100, 26);
            this.txtNombreNuevo.TabIndex = 55;
            this.txtNombreNuevo.TextChanged += new System.EventHandler(this.txtNombreNuevo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Teal;
            this.label10.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(648, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 54;
            this.label10.Text = "Nuevo año";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Teal;
            this.label11.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(639, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 17);
            this.label11.TabIndex = 53;
            this.label11.Text = "Nuevo modelo";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Teal;
            this.label12.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(638, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 52;
            this.label12.Text = "Nueva Marca ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtNuevoAño
            // 
            this.txtNuevoAño.BackColor = System.Drawing.Color.Teal;
            this.txtNuevoAño.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoAño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNuevoAño.Location = new System.Drawing.Point(633, 307);
            this.txtNuevoAño.Name = "txtNuevoAño";
            this.txtNuevoAño.Size = new System.Drawing.Size(100, 26);
            this.txtNuevoAño.TabIndex = 51;
            this.txtNuevoAño.TextChanged += new System.EventHandler(this.txtNuevoAño_TextChanged);
            // 
            // txtNuevaMarca
            // 
            this.txtNuevaMarca.BackColor = System.Drawing.Color.Teal;
            this.txtNuevaMarca.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNuevaMarca.Location = new System.Drawing.Point(634, 203);
            this.txtNuevaMarca.Name = "txtNuevaMarca";
            this.txtNuevaMarca.Size = new System.Drawing.Size(100, 26);
            this.txtNuevaMarca.TabIndex = 50;
            this.txtNuevaMarca.TextChanged += new System.EventHandler(this.txtNuevaMarca_TextChanged);
            // 
            // txtNuevoModelo
            // 
            this.txtNuevoModelo.BackColor = System.Drawing.Color.Teal;
            this.txtNuevoModelo.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNuevoModelo.Location = new System.Drawing.Point(634, 257);
            this.txtNuevoModelo.Name = "txtNuevoModelo";
            this.txtNuevoModelo.Size = new System.Drawing.Size(100, 26);
            this.txtNuevoModelo.TabIndex = 49;
            this.txtNuevoModelo.TextChanged += new System.EventHandler(this.txtNuevoModelo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(607, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Nombre antiguo de la moto";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNombreAntiguo
            // 
            this.txtNombreAntiguo.BackColor = System.Drawing.Color.Teal;
            this.txtNombreAntiguo.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAntiguo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNombreAntiguo.Location = new System.Drawing.Point(634, 105);
            this.txtNombreAntiguo.Name = "txtNombreAntiguo";
            this.txtNombreAntiguo.Size = new System.Drawing.Size(100, 26);
            this.txtNombreAntiguo.TabIndex = 47;
            this.txtNombreAntiguo.TextChanged += new System.EventHandler(this.txtNombreAntiguo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(70, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Nombre de la moto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(63, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 26);
            this.textBox1.TabIndex = 45;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lstMotos
            // 
            this.lstMotos.BackColor = System.Drawing.Color.Teal;
            this.lstMotos.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMotos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstMotos.FormattingEnabled = true;
            this.lstMotos.ItemHeight = 17;
            this.lstMotos.Location = new System.Drawing.Point(272, 250);
            this.lstMotos.Name = "lstMotos";
            this.lstMotos.Size = new System.Drawing.Size(279, 157);
            this.lstMotos.TabIndex = 44;
            this.lstMotos.SelectedIndexChanged += new System.EventHandler(this.lstCarros_SelectedIndexChanged);
            // 
            // btnActualizarCarro
            // 
            this.btnActualizarCarro.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnActualizarCarro.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCarro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnActualizarCarro.Location = new System.Drawing.Point(563, 18);
            this.btnActualizarCarro.Name = "btnActualizarCarro";
            this.btnActualizarCarro.Size = new System.Drawing.Size(203, 47);
            this.btnActualizarCarro.TabIndex = 43;
            this.btnActualizarCarro.Text = "ACTUALIZAR MOTO";
            this.btnActualizarCarro.UseVisualStyleBackColor = false;
            this.btnActualizarCarro.Click += new System.EventHandler(this.btnActualizarCarro_Click);
            // 
            // btnEliminarCarro
            // 
            this.btnEliminarCarro.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEliminarCarro.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCarro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminarCarro.Location = new System.Drawing.Point(304, 17);
            this.btnEliminarCarro.Name = "btnEliminarCarro";
            this.btnEliminarCarro.Size = new System.Drawing.Size(203, 47);
            this.btnEliminarCarro.TabIndex = 42;
            this.btnEliminarCarro.Text = "ELIMINAR MOTO";
            this.btnEliminarCarro.UseVisualStyleBackColor = false;
            this.btnEliminarCarro.Click += new System.EventHandler(this.btnEliminarCarro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(343, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Nombre de la moto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNombreEliminar
            // 
            this.txtNombreEliminar.BackColor = System.Drawing.Color.Teal;
            this.txtNombreEliminar.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNombreEliminar.Location = new System.Drawing.Point(335, 100);
            this.txtNombreEliminar.Name = "txtNombreEliminar";
            this.txtNombreEliminar.Size = new System.Drawing.Size(131, 26);
            this.txtNombreEliminar.TabIndex = 40;
            this.txtNombreEliminar.TextChanged += new System.EventHandler(this.txtNombreEliminar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(113, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Año";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(104, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Modelo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(110, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Marca";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAño
            // 
            this.txtAño.BackColor = System.Drawing.Color.Teal;
            this.txtAño.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAño.Location = new System.Drawing.Point(63, 250);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(128, 26);
            this.txtAño.TabIndex = 36;
            this.txtAño.TextChanged += new System.EventHandler(this.txtAño_TextChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.Teal;
            this.txtMarca.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMarca.Location = new System.Drawing.Point(63, 152);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(128, 26);
            this.txtMarca.TabIndex = 35;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.Teal;
            this.txtModelo.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtModelo.Location = new System.Drawing.Point(63, 197);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(128, 26);
            this.txtModelo.TabIndex = 34;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // btnAlmacenarCarro
            // 
            this.btnAlmacenarCarro.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAlmacenarCarro.Font = new System.Drawing.Font("Please write me a song", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacenarCarro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAlmacenarCarro.Location = new System.Drawing.Point(32, 17);
            this.btnAlmacenarCarro.Name = "btnAlmacenarCarro";
            this.btnAlmacenarCarro.Size = new System.Drawing.Size(203, 47);
            this.btnAlmacenarCarro.TabIndex = 33;
            this.btnAlmacenarCarro.Text = "ALMACENAR MOTO";
            this.btnAlmacenarCarro.UseVisualStyleBackColor = false;
            this.btnAlmacenarCarro.Click += new System.EventHandler(this.btnAlmacenarCarro_Click);
            // 
            // MotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExamenPracticoVCBU.Properties.Resources.Captura_de_pantalla_2024_10_22_210419;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BttListarCarros);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNombreNuevo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNuevoAño);
            this.Controls.Add(this.txtNuevaMarca);
            this.Controls.Add(this.txtNuevoModelo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombreAntiguo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstMotos);
            this.Controls.Add(this.btnActualizarCarro);
            this.Controls.Add(this.btnEliminarCarro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.btnAlmacenarCarro);
            this.Name = "MotoForm";
            this.Text = "MotoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BttListarCarros;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNuevoAño;
        private System.Windows.Forms.TextBox txtNuevaMarca;
        private System.Windows.Forms.TextBox txtNuevoModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreAntiguo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lstMotos;
        private System.Windows.Forms.Button btnActualizarCarro;
        private System.Windows.Forms.Button btnEliminarCarro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnAlmacenarCarro;
    }
}