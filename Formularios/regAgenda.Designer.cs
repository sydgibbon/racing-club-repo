namespace Formularios
{
    partial class regAgenda
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
            this.lblPresente = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblAusente = new System.Windows.Forms.Label();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.rbPresente = new System.Windows.Forms.RadioButton();
            this.rbAusente = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.grillaAgendas = new System.Windows.Forms.DataGridView();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoDoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAgendas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPresente
            // 
            this.lblPresente.AutoSize = true;
            this.lblPresente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresente.Location = new System.Drawing.Point(485, 30);
            this.lblPresente.Name = "lblPresente";
            this.lblPresente.Size = new System.Drawing.Size(62, 16);
            this.lblPresente.TabIndex = 1;
            this.lblPresente.Text = "Presente";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(276, 64);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(53, 16);
            this.lblHorario.TabIndex = 2;
            this.lblHorario.Text = "Horario";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(283, 30);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDoc.Location = new System.Drawing.Point(35, 65);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(105, 16);
            this.lblNroDoc.TabIndex = 4;
            this.lblNroDoc.Text = "Nro. Documento";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(32, 32);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(108, 16);
            this.lblTipoDoc.TabIndex = 5;
            this.lblTipoDoc.Text = "Tipo Documento";
            // 
            // lblAusente
            // 
            this.lblAusente.AutoSize = true;
            this.lblAusente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAusente.Location = new System.Drawing.Point(490, 65);
            this.lblAusente.Name = "lblAusente";
            this.lblAusente.Size = new System.Drawing.Size(57, 16);
            this.lblAusente.TabIndex = 6;
            this.lblAusente.Text = "Ausente";
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(146, 64);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(100, 20);
            this.txtNroDoc.TabIndex = 8;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(335, 63);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(100, 20);
            this.txtHorario.TabIndex = 10;
            // 
            // rbPresente
            // 
            this.rbPresente.AutoSize = true;
            this.rbPresente.Checked = true;
            this.rbPresente.Location = new System.Drawing.Point(554, 32);
            this.rbPresente.Name = "rbPresente";
            this.rbPresente.Size = new System.Drawing.Size(14, 13);
            this.rbPresente.TabIndex = 11;
            this.rbPresente.TabStop = true;
            this.rbPresente.UseVisualStyleBackColor = true;
            // 
            // rbAusente
            // 
            this.rbAusente.AutoSize = true;
            this.rbAusente.Location = new System.Drawing.Point(554, 67);
            this.rbAusente.Name = "rbAusente";
            this.rbAusente.Size = new System.Drawing.Size(14, 13);
            this.rbAusente.TabIndex = 12;
            this.rbAusente.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(38, 108);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(174, 23);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(218, 108);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(174, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(398, 108);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(174, 23);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(125, 148);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(303, 20);
            this.txtBuscar.TabIndex = 19;
            // 
            // grillaAgendas
            // 
            this.grillaAgendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAgendas.Location = new System.Drawing.Point(38, 190);
            this.grillaAgendas.Name = "grillaAgendas";
            this.grillaAgendas.ReadOnly = true;
            this.grillaAgendas.Size = new System.Drawing.Size(535, 229);
            this.grillaAgendas.TabIndex = 20;
            this.grillaAgendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaAgendas_CellClick);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(335, 26);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 21;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(441, 146);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(132, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Buscar (DNI)";
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipoDoc.FormattingEnabled = true;
            this.txtTipoDoc.Location = new System.Drawing.Point(146, 30);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.Size = new System.Drawing.Size(100, 21);
            this.txtTipoDoc.TabIndex = 24;
            // 
            // regAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.txtTipoDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.grillaAgendas);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rbAusente);
            this.Controls.Add(this.rbPresente);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtNroDoc);
            this.Controls.Add(this.lblAusente);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblPresente);
            this.Name = "regAgenda";
            this.Text = " Registro de Agendas";
            this.Load += new System.EventHandler(this.regAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaAgendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPresente;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblAusente;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.RadioButton rbPresente;
        private System.Windows.Forms.RadioButton rbAusente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView grillaAgendas;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtTipoDoc;
    }
}