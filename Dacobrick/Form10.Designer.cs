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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
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
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 945);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(587, 849);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 31);
            this.button6.TabIndex = 33;
            this.button6.Text = "GUARDAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
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
            this.Editar,
            this.Eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(40, 111);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1260, 726);
            this.dataGridView1.TabIndex = 31;
            // 
            // Cod_empleado
            // 
            this.Cod_empleado.DataPropertyName = "Cod_empleado";
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
            this.Nivel_pro.HeaderText = "Nivel profesional";
            this.Nivel_pro.Name = "Nivel_pro";
            this.Nivel_pro.ReadOnly = true;
            // 
            // Contrato
            // 
            this.Contrato.HeaderText = "Contrato";
            this.Contrato.Name = "Contrato";
            // 
            // Apto
            // 
            this.Apto.HeaderText = "Apto médico";
            this.Apto.Name = "Apto";
            // 
            // Entrega
            // 
            this.Entrega.HeaderText = "Entrega EPIs";
            this.Entrega.Name = "Entrega";
            // 
            // Autorizacion
            // 
            this.Autorizacion.HeaderText = "Autorización maquinaria";
            this.Autorizacion.Name = "Autorizacion";
            // 
            // Curso_PRL
            // 
            this.Curso_PRL.HeaderText = "Curso PRL";
            this.Curso_PRL.Name = "Curso_PRL";
            // 
            // Curso_alb
            // 
            this.Curso_alb.HeaderText = "Curso Albañilería";
            this.Curso_alb.Name = "Curso_alb";
            // 
            // Curso_hor
            // 
            this.Curso_hor.HeaderText = "Curso hormigón";
            this.Curso_hor.Name = "Curso_hor";
            this.Curso_hor.ReadOnly = true;
            // 
            // Curso_gru
            // 
            this.Curso_gru.HeaderText = "Curso Grúa";
            this.Curso_gru.Name = "Curso_gru";
            this.Curso_gru.ReadOnly = true;
            // 
            // Curso_pla
            // 
            this.Curso_pla.HeaderText = "Curso Plataformas";
            this.Curso_pla.Name = "Curso_pla";
            this.Curso_pla.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
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
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form10";
            this.Text = "TRABAJADORES.";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
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
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}