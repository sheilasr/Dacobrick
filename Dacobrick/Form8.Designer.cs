using System;

namespace Dacobrick
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_Tit = new System.Windows.Forms.TextBox();
            this.textBox_Exp = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_obra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Título = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox_Tit);
            this.panel1.Controls.Add(this.textBox_Exp);
            this.panel1.Controls.Add(this.textBox_ID);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 945);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 559);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 54);
            this.button2.TabIndex = 46;
            this.button2.Text = "MOSTRAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 489);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 444);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Desde";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(107, 509);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(254, 22);
            this.dateTimePicker2.TabIndex = 43;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 464);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(254, 22);
            this.dateTimePicker1.TabIndex = 42;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox_Tit
            // 
            this.textBox_Tit.Enabled = false;
            this.textBox_Tit.Location = new System.Drawing.Point(4, 813);
            this.textBox_Tit.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Tit.Name = "textBox_Tit";
            this.textBox_Tit.Size = new System.Drawing.Size(132, 22);
            this.textBox_Tit.TabIndex = 41;
            this.textBox_Tit.Visible = false;
            // 
            // textBox_Exp
            // 
            this.textBox_Exp.Enabled = false;
            this.textBox_Exp.Location = new System.Drawing.Point(4, 783);
            this.textBox_Exp.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Exp.Name = "textBox_Exp";
            this.textBox_Exp.Size = new System.Drawing.Size(132, 22);
            this.textBox_Exp.TabIndex = 40;
            this.textBox_Exp.Visible = false;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Enabled = false;
            this.textBox_ID.Location = new System.Drawing.Point(4, 753);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(132, 22);
            this.textBox_ID.TabIndex = 39;
            this.textBox_ID.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(107, 113);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "TODOS LOS EVENTOS";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(107, 140);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 276);
            this.listBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.ID_obra,
            this.Expediente,
            this.Título,
            this.Tipo,
            this.Descripcion});
            this.dataGridView1.Location = new System.Drawing.Point(367, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(965, 719);
            this.dataGridView1.TabIndex = 3;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // ID_obra
            // 
            this.ID_obra.DataPropertyName = "ID_obra";
            this.ID_obra.HeaderText = "Id obra";
            this.ID_obra.Name = "ID_obra";
            this.ID_obra.ReadOnly = true;
            // 
            // Expediente
            // 
            this.Expediente.DataPropertyName = "Expediente";
            this.Expediente.HeaderText = "Expediente";
            this.Expediente.Name = "Expediente";
            this.Expediente.ReadOnly = true;
            // 
            // Título
            // 
            this.Título.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Título.DataPropertyName = "Titulo";
            this.Título.HeaderText = "Título";
            this.Título.Name = "Título";
            this.Título.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(141, 625);
            this.monthCalendar1.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(107, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 62);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALENDARIO.";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_obra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.TextBox textBox_Tit;
        private System.Windows.Forms.TextBox textBox_Exp;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}