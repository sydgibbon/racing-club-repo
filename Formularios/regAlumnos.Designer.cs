namespace Formularios
{
    partial class regAlumnos
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.txtTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAV_RACINGDataSet = new Formularios.PAV_RACINGDataSet();
            this.alumnoTableAdapter = new Formularios.PAV_RACINGDataSetTableAdapters.alumnoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoSocio = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAlta = new System.Windows.Forms.Label();
            this.txtAlta = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBaja = new System.Windows.Forms.DateTimePicker();
            this.grillaAlumnos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_RACINGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nro. de Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(507, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sexo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(270, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha Nac";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(512, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Calle";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(495, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Numero";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(516, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Piso";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(503, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Depto.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(507, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Barrio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(154, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(154, 119);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(100, 20);
            this.txtNroDoc.TabIndex = 3;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(557, 50);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 20);
            this.txtCalle.TabIndex = 7;
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Location = new System.Drawing.Point(557, 79);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(100, 20);
            this.txtNroCalle.TabIndex = 8;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(557, 108);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(100, 20);
            this.txtPiso.TabIndex = 9;
            // 
            // txtDepto
            // 
            this.txtDepto.Location = new System.Drawing.Point(557, 138);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(100, 20);
            this.txtDepto.TabIndex = 11;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Checked = true;
            this.radioM.Location = new System.Drawing.Point(557, 22);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(34, 17);
            this.radioM.TabIndex = 6;
            this.radioM.TabStop = true;
            this.radioM.Text = "M";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Location = new System.Drawing.Point(610, 22);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(31, 17);
            this.radioF.TabIndex = 26;
            this.radioF.Text = "F";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipoDoc.FormattingEnabled = true;
            this.txtTipoDoc.Location = new System.Drawing.Point(154, 86);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.Size = new System.Drawing.Size(100, 21);
            this.txtTipoDoc.TabIndex = 2;
            this.txtTipoDoc.SelectedIndexChanged += new System.EventHandler(this.TxtTipoDoc_SelectedIndexChanged);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(351, 61);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNacimiento.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(27, 225);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(204, 23);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(246, 225);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(204, 23);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(278, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 16);
            this.label14.TabIndex = 32;
            this.label14.Text = "Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCategoria.FormattingEnabled = true;
            this.txtCategoria.Location = new System.Drawing.Point(351, 90);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 21);
            this.txtCategoria.TabIndex = 13;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(467, 225);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(204, 23);
            this.btnActualizar.TabIndex = 34;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click_1);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(111, 266);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(422, 20);
            this.txtBuscar.TabIndex = 35;
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataMember = "alumno";
            this.alumnoBindingSource.DataSource = this.pAV_RACINGDataSet;
            // 
            // pAV_RACINGDataSet
            // 
            this.pAV_RACINGDataSet.DataSetName = "PAV_RACINGDataSet";
            this.pAV_RACINGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tipo Socio";
            // 
            // txtTipoSocio
            // 
            this.txtTipoSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipoSocio.FormattingEnabled = true;
            this.txtTipoSocio.Location = new System.Drawing.Point(350, 23);
            this.txtTipoSocio.Name = "txtTipoSocio";
            this.txtTipoSocio.Size = new System.Drawing.Size(100, 21);
            this.txtTipoSocio.TabIndex = 38;
            // 
            // txtEstado
            // 
            this.txtEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Location = new System.Drawing.Point(154, 152);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 21);
            this.txtEstado.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Estado";
            // 
            // lblAlta
            // 
            this.lblAlta.AutoSize = true;
            this.lblAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlta.Location = new System.Drawing.Point(272, 123);
            this.lblAlta.Name = "lblAlta";
            this.lblAlta.Size = new System.Drawing.Size(72, 16);
            this.lblAlta.TabIndex = 41;
            this.lblAlta.Text = "Fecha Alta";
            // 
            // txtAlta
            // 
            this.txtAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtAlta.Location = new System.Drawing.Point(350, 123);
            this.txtAlta.Name = "txtAlta";
            this.txtAlta.Size = new System.Drawing.Size(100, 20);
            this.txtAlta.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(270, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 16);
            this.label15.TabIndex = 43;
            this.label15.Text = "Fecha Baja";
            // 
            // txtBaja
            // 
            this.txtBaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBaja.Location = new System.Drawing.Point(351, 153);
            this.txtBaja.Name = "txtBaja";
            this.txtBaja.Size = new System.Drawing.Size(100, 20);
            this.txtBaja.TabIndex = 44;
            // 
            // grillaAlumnos
            // 
            this.grillaAlumnos.AllowUserToAddRows = false;
            this.grillaAlumnos.AllowUserToDeleteRows = false;
            this.grillaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAlumnos.Location = new System.Drawing.Point(21, 300);
            this.grillaAlumnos.Name = "grillaAlumnos";
            this.grillaAlumnos.ReadOnly = true;
            this.grillaAlumnos.Size = new System.Drawing.Size(650, 243);
            this.grillaAlumnos.TabIndex = 45;
            this.grillaAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaAlumnos_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(539, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 266);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 16);
            this.label16.TabIndex = 47;
            this.label16.Text = "Buscar (DNI)";
            // 
            // txtBarrio
            // 
            this.txtBarrio.FormattingEnabled = true;
            this.txtBarrio.Location = new System.Drawing.Point(557, 165);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(100, 21);
            this.txtBarrio.TabIndex = 48;
            // 
            // regAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(690, 555);
            this.Controls.Add(this.txtBarrio);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grillaAlumnos);
            this.Controls.Add(this.txtBaja);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtAlta);
            this.Controls.Add(this.lblAlta);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTipoSocio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.radioM);
            this.Controls.Add(this.radioF);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtTipoDoc);
            this.Controls.Add(this.txtDepto);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtNroCalle);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtNroDoc);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "regAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Alumnos";
            this.Load += new System.EventHandler(this.RegAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_RACINGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNroCalle;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.ComboBox txtTipoDoc;
        private System.Windows.Forms.DateTimePicker txtFechaNacimiento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox txtCategoria;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtBuscar;
        private PAV_RACINGDataSet pAV_RACINGDataSet;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private PAV_RACINGDataSetTableAdapters.alumnoTableAdapter alumnoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtTipoSocio;
        private System.Windows.Forms.ComboBox txtEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAlta;
        private System.Windows.Forms.DateTimePicker txtAlta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker txtBaja;
        private System.Windows.Forms.DataGridView grillaAlumnos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox txtBarrio;
    }
}