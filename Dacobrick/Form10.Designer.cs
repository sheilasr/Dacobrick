namespace Dacobrick
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cod_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrato = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Apto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Entrega = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Autorizacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Curso_PRL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Curso_alb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Curso_hor = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Curso_gru = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Curso_pla = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Libre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(40, 37);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 62);
            this.button8.TabIndex = 32;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_empleado,
            this.Nombre,
            this.Apellidos,
            this.DNI,
            this.Telefono,
            this.Nivel_pro,
            this.Contrato,
            this.Apto,
            this.Entrega,
            this.Autorizacion,
            this.Curso_PRL,
            this.Curso_alb,
            this.Curso_hor,
            this.Curso_gru,
            this.Curso_pla,
            this.Libre,
            this.Obra,
            this.Editar,
            this.Eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(40, 111);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1260, 751);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Cod_empleado
            // 
            this.Cod_empleado.DataPropertyName = "CODI";
            this.Cod_empleado.HeaderText = "Código empleado";
            this.Cod_empleado.Name = "Cod_empleado";
            this.Cod_empleado.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Nivel_pro
            // 
            this.Nivel_pro.DataPropertyName = "Nivel";
            this.Nivel_pro.HeaderText = "Nivel profesional";
            this.Nivel_pro.Name = "Nivel_pro";
            this.Nivel_pro.ReadOnly = true;
            // 
            // Contrato
            // 
            this.Contrato.DataPropertyName = "Contrato";
            this.Contrato.HeaderText = "Contrato";
            this.Contrato.Name = "Contrato";
            this.Contrato.ReadOnly = true;
            // 
            // Apto
            // 
            this.Apto.DataPropertyName = "Apto";
            this.Apto.HeaderText = "Apto médico";
            this.Apto.Name = "Apto";
            this.Apto.ReadOnly = true;
            // 
            // Entrega
            // 
            this.Entrega.DataPropertyName = "EPIs";
            this.Entrega.HeaderText = "Entrega EPIs";
            this.Entrega.Name = "Entrega";
            this.Entrega.ReadOnly = true;
            // 
            // Autorizacion
            // 
            this.Autorizacion.DataPropertyName = "Maquinaria";
            this.Autorizacion.HeaderText = "Autorización maquinaria";
            this.Autorizacion.Name = "Autorizacion";
            this.Autorizacion.ReadOnly = true;
            // 
            // Curso_PRL
            // 
            this.Curso_PRL.DataPropertyName = "PRL";
            this.Curso_PRL.HeaderText = "Curso PRL";
            this.Curso_PRL.Name = "Curso_PRL";
            this.Curso_PRL.ReadOnly = true;
            // 
            // Curso_alb
            // 
            this.Curso_alb.DataPropertyName = "Albañileria";
            this.Curso_alb.HeaderText = "Curso Albañilería";
            this.Curso_alb.Name = "Curso_alb";
            this.Curso_alb.ReadOnly = true;
            // 
            // Curso_hor
            // 
            this.Curso_hor.DataPropertyName = "Hormigon";
            this.Curso_hor.HeaderText = "Curso hormigón";
            this.Curso_hor.Name = "Curso_hor";
            this.Curso_hor.ReadOnly = true;
            // 
            // Curso_gru
            // 
            this.Curso_gru.DataPropertyName = "Grua";
            this.Curso_gru.HeaderText = "Curso Grúa";
            this.Curso_gru.Name = "Curso_gru";
            this.Curso_gru.ReadOnly = true;
            // 
            // Curso_pla
            // 
            this.Curso_pla.DataPropertyName = "Plataformas";
            this.Curso_pla.HeaderText = "Curso Plataformas";
            this.Curso_pla.Name = "Curso_pla";
            this.Curso_pla.ReadOnly = true;
            // 
            // Libre
            // 
            this.Libre.DataPropertyName = "Libre";
            this.Libre.HeaderText = "Libre";
            this.Libre.Name = "Libre";
            this.Libre.ReadOnly = true;
            // 
            // Obra
            // 
            this.Obra.DataPropertyName = "Obra_asignada";
            this.Obra.HeaderText = "Obra asignada";
            this.Obra.Name = "Obra";
            this.Obra.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(120, 37);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 62);
            this.button7.TabIndex = 30;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 945);
            this.panel1.TabIndex = 0;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRABAJADORES.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel_pro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Contrato;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Apto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Entrega;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Autorizacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Curso_PRL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Curso_alb;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Curso_hor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Curso_gru;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Curso_pla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obra;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Panel panel1;
    }
}