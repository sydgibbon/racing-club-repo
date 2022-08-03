namespace Formularios
{
    partial class registroPartido
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblRival = new System.Windows.Forms.Label();
            this.lblLiga = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPartido = new System.Windows.Forms.Label();
            this.txtPartido = new System.Windows.Forms.TextBox();
            this.txtRival = new System.Windows.Forms.TextBox();
            this.txtLiga = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtFechaPartido = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dataPartido = new System.Windows.Forms.DataGridView();
            this.pAVRACINGDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAV_RACINGDataSet = new Formularios.PAV_RACINGDataSet();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.txtCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataPartido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAVRACINGDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_RACINGDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(239, 25);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 16);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // lblRival
            // 
            this.lblRival.AutoSize = true;
            this.lblRival.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRival.Location = new System.Drawing.Point(55, 59);
            this.lblRival.Name = "lblRival";
            this.lblRival.Size = new System.Drawing.Size(39, 16);
            this.lblRival.TabIndex = 1;
            this.lblRival.Text = "Rival";
            this.lblRival.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblLiga
            // 
            this.lblLiga.AutoSize = true;
            this.lblLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiga.Location = new System.Drawing.Point(451, 25);
            this.lblLiga.Name = "lblLiga";
            this.lblLiga.Size = new System.Drawing.Size(34, 16);
            this.lblLiga.TabIndex = 2;
            this.lblLiga.Text = "Liga";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(418, 56);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(67, 16);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartido.Location = new System.Drawing.Point(12, 25);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(82, 16);
            this.lblPartido.TabIndex = 4;
            this.lblPartido.Text = "Cod. Partido";
            // 
            // txtPartido
            // 
            this.txtPartido.Enabled = false;
            this.txtPartido.Location = new System.Drawing.Point(100, 24);
            this.txtPartido.Name = "txtPartido";
            this.txtPartido.Size = new System.Drawing.Size(100, 20);
            this.txtPartido.TabIndex = 5;
            // 
            // txtRival
            // 
            this.txtRival.Location = new System.Drawing.Point(100, 58);
            this.txtRival.Name = "txtRival";
            this.txtRival.Size = new System.Drawing.Size(100, 20);
            this.txtRival.TabIndex = 0;
            // 
            // txtLiga
            // 
            this.txtLiga.Location = new System.Drawing.Point(491, 24);
            this.txtLiga.Name = "txtLiga";
            this.txtLiga.Size = new System.Drawing.Size(100, 20);
            this.txtLiga.TabIndex = 3;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(247, 59);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(38, 16);
            this.lblHora.TabIndex = 10;
            this.lblHora.Text = "Hora";
            // 
            // txtFechaPartido
            // 
            this.txtFechaPartido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaPartido.Location = new System.Drawing.Point(291, 24);
            this.txtFechaPartido.Name = "txtFechaPartido";
            this.txtFechaPartido.Size = new System.Drawing.Size(100, 20);
            this.txtFechaPartido.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(33, 97);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(174, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(231, 97);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(174, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(421, 97);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(174, 23);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // dataPartido
            // 
            this.dataPartido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPartido.Location = new System.Drawing.Point(33, 178);
            this.dataPartido.Name = "dataPartido";
            this.dataPartido.ReadOnly = true;
            this.dataPartido.Size = new System.Drawing.Size(558, 241);
            this.dataPartido.TabIndex = 9;
            this.dataPartido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPartido_CellClick);
            // 
            // pAVRACINGDataSetBindingSource
            // 
            this.pAVRACINGDataSetBindingSource.DataSource = this.pAV_RACINGDataSet;
            this.pAVRACINGDataSetBindingSource.Position = 0;
            // 
            // pAV_RACINGDataSet
            // 
            this.pAV_RACINGDataSet.DataSetName = "PAV_RACINGDataSet";
            this.pAV_RACINGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(33, 139);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(558, 20);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.Text = "Buscar (Codigo de partido)";
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.TxtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.TxtBuscar_Leave);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(291, 55);
            this.txtHora.Mask = "00:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 2;
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHora.ValidatingType = typeof(System.DateTime);
            // 
            // txtCategoria
            // 
            this.txtCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.txtCategoria.FormattingEnabled = true;
            this.txtCategoria.Items.AddRange(new object[] {
            "Pulguitas",
            "Cebollitas",
            "Premini",
            "Mini",
            "U13 M",
            "U13 F",
            "U15 M",
            "U15 F",
            "U17 M",
            "U17 F",
            "Primera M",
            "Primera F"});
            this.txtCategoria.Location = new System.Drawing.Point(491, 55);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 21);
            this.txtCategoria.TabIndex = 14;
            // 
            // registroPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(620, 442);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataPartido);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtFechaPartido);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.txtLiga);
            this.Controls.Add(this.txtRival);
            this.Controls.Add(this.txtPartido);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblLiga);
            this.Controls.Add(this.lblRival);
            this.Controls.Add(this.lblFecha);
            this.Name = "registroPartido";
            this.Text = "Registro de Partidos";
            this.Load += new System.EventHandler(this.RegPartido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPartido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAVRACINGDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_RACINGDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblRival;
        private System.Windows.Forms.Label lblLiga;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.TextBox txtPartido;
        private System.Windows.Forms.TextBox txtRival;
        private System.Windows.Forms.TextBox txtLiga;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker txtFechaPartido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dataPartido;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private System.Windows.Forms.BindingSource pAVRACINGDataSetBindingSource;
        private PAV_RACINGDataSet pAV_RACINGDataSet;
        private System.Windows.Forms.ComboBox txtCategoria;
    }
}