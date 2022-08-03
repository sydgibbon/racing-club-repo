namespace Formularios
{
    partial class regCuotas
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grillaCuotas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioNoPagado = new System.Windows.Forms.RadioButton();
            this.fechaCuota = new System.Windows.Forms.DateTimePicker();
            this.radioPagado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tipoDocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAV_RACINGDataSet1 = new Formularios.PAV_RACINGDataSet1();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.Label();
            this.txtAp = new System.Windows.Forms.TextBox();
            this.pAV_RACINGDataSet = new Formularios.PAV_RACINGDataSet();
            this.pAVRACINGDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnoTableAdapter = new Formularios.PAV_RACINGDataSetTableAdapters.alumnoTableAdapter();
            this.tipoDocTableAdapter = new Formularios.PAV_RACINGDataSet1TableAdapters.TipoDocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCuotas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_RACINGDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_RACINGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAVRACINGDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleName = "btnguardar";
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBuscar.Location = new System.Drawing.Point(495, 109);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 29);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // grillaCuotas
            // 
            this.grillaCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCuotas.Location = new System.Drawing.Point(12, 154);
            this.grillaCuotas.Name = "grillaCuotas";
            this.grillaCuotas.ReadOnly = true;
            this.grillaCuotas.Size = new System.Drawing.Size(588, 211);
            this.grillaCuotas.TabIndex = 23;
            this.grillaCuotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaCuotas_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioNoPagado);
            this.groupBox2.Controls.Add(this.fechaCuota);
            this.groupBox2.Controls.Add(this.radioPagado);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMonto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(13, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 90);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monto";
            // 
            // radioNoPagado
            // 
            this.radioNoPagado.AccessibleName = "rdfemenino";
            this.radioNoPagado.AutoSize = true;
            this.radioNoPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radioNoPagado.Location = new System.Drawing.Point(294, 50);
            this.radioNoPagado.Name = "radioNoPagado";
            this.radioNoPagado.Size = new System.Drawing.Size(96, 20);
            this.radioNoPagado.TabIndex = 15;
            this.radioNoPagado.TabStop = true;
            this.radioNoPagado.Text = "No Pagado";
            this.radioNoPagado.UseVisualStyleBackColor = true;
            // 
            // fechaCuota
            // 
            this.fechaCuota.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCuota.Location = new System.Drawing.Point(94, 54);
            this.fechaCuota.Name = "fechaCuota";
            this.fechaCuota.Size = new System.Drawing.Size(131, 22);
            this.fechaCuota.TabIndex = 13;
            // 
            // radioPagado
            // 
            this.radioPagado.AutoSize = true;
            this.radioPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radioPagado.Location = new System.Drawing.Point(294, 27);
            this.radioPagado.Name = "radioPagado";
            this.radioPagado.Size = new System.Drawing.Size(75, 20);
            this.radioPagado.TabIndex = 14;
            this.radioPagado.TabStop = true;
            this.radioPagado.Text = "Pagado";
            this.radioPagado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(237, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vencimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(40, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.AccessibleName = "txtapellido";
            this.txtMonto.Location = new System.Drawing.Point(94, 24);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(131, 22);
            this.txtMonto.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AccessibleName = "btnguardar";
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnRegistrar.Location = new System.Drawing.Point(495, 385);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 29);
            this.btnRegistrar.TabIndex = 25;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 74);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documento de identidad";
            // 
            // cmbDoc
            // 
            this.cmbDoc.AccessibleName = "lbtipodoc";
            this.cmbDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoc.FormattingEnabled = true;
            this.cmbDoc.Location = new System.Drawing.Point(83, 30);
            this.cmbDoc.Name = "cmbDoc";
            this.cmbDoc.Size = new System.Drawing.Size(143, 24);
            this.cmbDoc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(41, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipo";
            // 
            // txtDoc
            // 
            this.txtDoc.AccessibleName = "txtnrodoc";
            this.txtDoc.Location = new System.Drawing.Point(295, 30);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(102, 22);
            this.txtDoc.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(232, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Número";
            // 
            // tipoDocBindingSource
            // 
            this.tipoDocBindingSource.DataMember = "TipoDoc";
            this.tipoDocBindingSource.DataSource = this.pAV_RACINGDataSet1;
            // 
            // pAV_RACINGDataSet1
            // 
            this.pAV_RACINGDataSet1.DataSetName = "PAV_RACINGDataSet1";
            this.pAV_RACINGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNom);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.txtApellido);
            this.groupBox3.Controls.Add(this.txtAp);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(12, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 62);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos personales";
            // 
            // txtNom
            // 
            this.txtNom.AccessibleName = "txtnombre";
            this.txtNom.Location = new System.Drawing.Point(295, 24);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(102, 22);
            this.txtNom.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNombre.Location = new System.Drawing.Point(232, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(57, 16);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.AutoSize = true;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtApellido.Location = new System.Drawing.Point(19, 27);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(58, 16);
            this.txtApellido.TabIndex = 10;
            this.txtApellido.Text = "Apellido";
            // 
            // txtAp
            // 
            this.txtAp.AccessibleName = "txtapellido";
            this.txtAp.Location = new System.Drawing.Point(83, 26);
            this.txtAp.Name = "txtAp";
            this.txtAp.ReadOnly = true;
            this.txtAp.Size = new System.Drawing.Size(143, 22);
            this.txtAp.TabIndex = 0;
            // 
            // pAV_RACINGDataSet
            // 
            this.pAV_RACINGDataSet.DataSetName = "PAV_RACINGDataSet";
            this.pAV_RACINGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pAVRACINGDataSetBindingSource
            // 
            this.pAVRACINGDataSetBindingSource.DataSource = this.pAV_RACINGDataSet;
            this.pAVRACINGDataSetBindingSource.Position = 0;
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataMember = "alumno";
            this.alumnoBindingSource.DataSource = this.pAVRACINGDataSetBindingSource;
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // tipoDocTableAdapter
            // 
            this.tipoDocTableAdapter.ClearBeforeFill = true;
            // 
            // regCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grillaCuotas);
            this.Controls.Add(this.btnBuscar);
            this.Name = "regCuotas";
            this.Text = "Cuotas";
            this.Load += new System.EventHandler(this.Cuotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaCuotas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_RACINGDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_RACINGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAVRACINGDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView grillaCuotas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.RadioButton radioNoPagado;
        private System.Windows.Forms.DateTimePicker fechaCuota;
        private System.Windows.Forms.RadioButton radioPagado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtApellido;
        private System.Windows.Forms.BindingSource pAVRACINGDataSetBindingSource;
        private PAV_RACINGDataSet pAV_RACINGDataSet;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private PAV_RACINGDataSetTableAdapters.alumnoTableAdapter alumnoTableAdapter;
        private PAV_RACINGDataSet1 pAV_RACINGDataSet1;
        private System.Windows.Forms.BindingSource tipoDocBindingSource;
        private PAV_RACINGDataSet1TableAdapters.TipoDocTableAdapter tipoDocTableAdapter;
        public System.Windows.Forms.TextBox txtDoc;
        public System.Windows.Forms.ComboBox cmbDoc;
        public System.Windows.Forms.TextBox txtNom;
        public System.Windows.Forms.TextBox txtAp;
    }
}