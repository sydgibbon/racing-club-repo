namespace Formularios
{
    partial class Concentrados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.Label();
            this.txtAp = new System.Windows.Forms.TextBox();
            this.grillaCuotas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCuotas)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(378, 74);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documento de identidad";
            // 
            // cmbDoc
            // 
            this.cmbDoc.AccessibleName = "lbtipodoc";
            this.cmbDoc.FormattingEnabled = true;
            this.cmbDoc.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte",
            "Libreta Civica"});
            this.cmbDoc.Location = new System.Drawing.Point(83, 30);
            this.cmbDoc.Name = "cmbDoc";
            this.cmbDoc.Size = new System.Drawing.Size(71, 24);
            this.cmbDoc.TabIndex = 5;
            this.cmbDoc.Text = "DNI";
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
            this.txtDoc.Location = new System.Drawing.Point(222, 32);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(132, 22);
            this.txtDoc.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(160, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Número";
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
            this.groupBox3.Size = new System.Drawing.Size(377, 62);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos personales";
            // 
            // txtNom
            // 
            this.txtNom.AccessibleName = "txtnombre";
            this.txtNom.Location = new System.Drawing.Point(252, 26);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 22);
            this.txtNom.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNombre.Location = new System.Drawing.Point(189, 29);
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
            this.txtAp.Size = new System.Drawing.Size(100, 22);
            this.txtAp.TabIndex = 0;
            // 
            // grillaCuotas
            // 
            this.grillaCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCuotas.Location = new System.Drawing.Point(12, 154);
            this.grillaCuotas.Name = "grillaCuotas";
            this.grillaCuotas.Size = new System.Drawing.Size(378, 151);
            this.grillaCuotas.TabIndex = 30;
            // 
            // Concentrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grillaCuotas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Concentrados";
            this.Text = "Concentrados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCuotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cmbDoc;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtApellido;
        public System.Windows.Forms.TextBox txtAp;
        private System.Windows.Forms.DataGridView grillaCuotas;
    }
}