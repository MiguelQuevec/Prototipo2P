
namespace CapaVista
{
    partial class Empleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.listEmpleados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBusacar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.txtpuesto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDempleado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.txtIDcontrato = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listEmpleados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 39);
            this.label1.TabIndex = 28;
            this.label1.Text = "Empleado";
            // 
            // listEmpleados
            // 
            this.listEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listEmpleados.Location = new System.Drawing.Point(16, 352);
            this.listEmpleados.Name = "listEmpleados";
            this.listEmpleados.RowHeadersWidth = 51;
            this.listEmpleados.Size = new System.Drawing.Size(496, 80);
            this.listEmpleados.TabIndex = 51;
            this.listEmpleados.Tag = "vista_Empleados";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtBusacar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(16, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 82);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBusacar
            // 
            this.txtBusacar.Location = new System.Drawing.Point(110, 33);
            this.txtBusacar.Name = "txtBusacar";
            this.txtBusacar.Size = new System.Drawing.Size(260, 20);
            this.txtBusacar.TabIndex = 1;
            this.txtBusacar.TextChanged += new System.EventHandler(this.txtBusacar_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Buscar Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIDcontrato);
            this.groupBox2.Controls.Add(this.txtEliminar);
            this.groupBox2.Controls.Add(this.btnIngresar);
            this.groupBox2.Controls.Add(this.btnmod);
            this.groupBox2.Controls.Add(this.txtpuesto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtIDempleado);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(8, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 192);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Empleado";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(408, 26);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(78, 45);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(408, 96);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(78, 42);
            this.btnmod.TabIndex = 17;
            this.btnmod.Text = "Modificar";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // txtpuesto
            // 
            this.txtpuesto.Location = new System.Drawing.Point(128, 128);
            this.txtpuesto.Name = "txtpuesto";
            this.txtpuesto.Size = new System.Drawing.Size(244, 20);
            this.txtpuesto.TabIndex = 25;
            this.txtpuesto.Tag = "puesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Puesto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "ID Contrato";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 20);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.Tag = "nombreEmpleado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Nombre";
            // 
            // txtIDempleado
            // 
            this.txtIDempleado.Location = new System.Drawing.Point(128, 32);
            this.txtIDempleado.Name = "txtIDempleado";
            this.txtIDempleado.Size = new System.Drawing.Size(244, 20);
            this.txtIDempleado.TabIndex = 5;
            this.txtIDempleado.Tag = "IDempleado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Codigo";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(40, 160);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(28, 20);
            this.txtEliminar.TabIndex = 30;
            this.txtEliminar.Tag = "";
            this.txtEliminar.Visible = false;
            // 
            // txtIDcontrato
            // 
            this.txtIDcontrato.Location = new System.Drawing.Point(128, 96);
            this.txtIDcontrato.Name = "txtIDcontrato";
            this.txtIDcontrato.Size = new System.Drawing.Size(244, 20);
            this.txtIDcontrato.TabIndex = 31;
            this.txtIDcontrato.Tag = "fk_IDcontrato";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 444);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listEmpleados);
            this.Controls.Add(this.label1);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listEmpleados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listEmpleados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBusacar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.TextBox txtpuesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIDempleado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.TextBox txtIDcontrato;
    }
}