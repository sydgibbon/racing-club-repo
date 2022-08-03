namespace Formularios
{
    partial class buscarAlumno
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAVRACINGDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAV_RACINGDataSet1 = new Formularios.PAV_RACINGDataSet1();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tipoDocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoDocTableAdapter = new Formularios.PAV_RACINGDataSet1TableAdapters.TipoDocTableAdapter();
            this.alumnoTableAdapter = new Formularios.PAV_RACINGDataSet1TableAdapters.alumnoTableAdapter();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.alumnoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cod_tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataAlumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAVRACINGDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_RACINGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Buscar por Nombre o Apellido";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(207, 28);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(414, 20);
            this.txtBusqueda.TabIndex = 5;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataMember = "alumno";
            this.alumnoBindingSource.DataSource = this.pAVRACINGDataSet1BindingSource;
            // 
            // pAVRACINGDataSet1BindingSource
            // 
            this.pAVRACINGDataSet1BindingSource.DataSource = this.pAV_RACINGDataSet1;
            this.pAVRACINGDataSet1BindingSource.Position = 0;
            // 
            // pAV_RACINGDataSet1
            // 
            this.pAV_RACINGDataSet1.DataSetName = "PAV_RACINGDataSet1";
            this.pAV_RACINGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleName = "btnguardar";
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSalir.Location = new System.Drawing.Point(480, 282);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 29);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "btnguardar";
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button2.Location = new System.Drawing.Point(369, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 29);
            this.button2.TabIndex = 24;
            this.button2.Text = "Nuevo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tipoDocBindingSource
            // 
            this.tipoDocBindingSource.DataMember = "TipoDoc";
            this.tipoDocBindingSource.DataSource = this.pAV_RACINGDataSet1;
            // 
            // tipoDocTableAdapter
            // 
            this.tipoDocTableAdapter.ClearBeforeFill = true;
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AccessibleName = "btnguardar";
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSeleccionar.Location = new System.Drawing.Point(12, 282);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(105, 29);
            this.btnSeleccionar.TabIndex = 26;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // alumnoBindingSource1
            // 
            this.alumnoBindingSource1.DataMember = "alumno";
            this.alumnoBindingSource1.DataSource = this.pAVRACINGDataSet1BindingSource;
            // 
            // cod_tipoDoc
            // 
            this.cod_tipoDoc.DataPropertyName = "cod_tipoDoc";
            this.cod_tipoDoc.HeaderText = "TipoDoc";
            this.cod_tipoDoc.Name = "cod_tipoDoc";
            this.cod_tipoDoc.ReadOnly = true;
            // 
            // nroDoc
            // 
            this.nroDoc.DataPropertyName = "nroDoc";
            this.nroDoc.HeaderText = "Documento";
            this.nroDoc.Name = "nroDoc";
            this.nroDoc.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido2
            // 
            this.Apellido2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Apellido2.DataPropertyName = "apellido";
            this.Apellido2.HeaderText = "Apellido";
            this.Apellido2.Name = "Apellido2";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.DataPropertyName = "fechaNacimiento";
            this.fechaNacimiento.HeaderText = "FechNacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            // 
            // alumnoBindingSource2
            // 
            this.alumnoBindingSource2.DataMember = "alumno";
            this.alumnoBindingSource2.DataSource = this.pAV_RACINGDataSet1;
            // 
            // dataAlumnos
            // 
            this.dataAlumnos.AllowUserToAddRows = false;
            this.dataAlumnos.AllowUserToDeleteRows = false;
            this.dataAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAlumnos.Location = new System.Drawing.Point(15, 54);
            this.dataAlumnos.Name = "dataAlumnos";
            this.dataAlumnos.ReadOnly = true;
            this.dataAlumnos.Size = new System.Drawing.Size(606, 222);
            this.dataAlumnos.TabIndex = 46;
            this.dataAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataAlumnos_CellContentClick_1);
            // 
            // buscarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 323);
            this.Controls.Add(this.dataAlumnos);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label4);
            this.Name = "buscarAlumno";
            this.Text = "Buscar Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAVRACINGDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_RACINGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button2;
        private PAV_RACINGDataSet1 pAV_RACINGDataSet1;
        private System.Windows.Forms.BindingSource tipoDocBindingSource;
        private PAV_RACINGDataSet1TableAdapters.TipoDocTableAdapter tipoDocTableAdapter;
        private System.Windows.Forms.BindingSource pAVRACINGDataSet1BindingSource;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private PAV_RACINGDataSet1TableAdapters.alumnoTableAdapter alumnoTableAdapter;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.BindingSource alumnoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.BindingSource alumnoBindingSource2;
        private System.Windows.Forms.DataGridView dataAlumnos;
    }
}