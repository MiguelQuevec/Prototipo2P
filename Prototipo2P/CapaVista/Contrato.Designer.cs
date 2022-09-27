
namespace CapaVista
{
    partial class Contrato
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.txttipoContrato = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDcontrato = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBusacar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listContratos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEliminar);
            this.groupBox2.Controls.Add(this.btnIngresar);
            this.groupBox2.Controls.Add(this.btnmod);
            this.groupBox2.Controls.Add(this.txttipoContrato);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtIDcontrato);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(16, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 152);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Contrato";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(48, 104);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(28, 20);
            this.txtEliminar.TabIndex = 30;
            this.txtEliminar.Tag = "";
            this.txtEliminar.Visible = false;
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
            // 
            // txttipoContrato
            // 
            this.txttipoContrato.Location = new System.Drawing.Point(128, 63);
            this.txttipoContrato.Name = "txttipoContrato";
            this.txttipoContrato.Size = new System.Drawing.Size(244, 20);
            this.txttipoContrato.TabIndex = 7;
            this.txttipoContrato.Tag = "tipoContrato";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Tipo Contrato";
            // 
            // txtIDcontrato
            // 
            this.txtIDcontrato.Location = new System.Drawing.Point(128, 32);
            this.txtIDcontrato.Name = "txtIDcontrato";
            this.txtIDcontrato.Size = new System.Drawing.Size(244, 20);
            this.txtIDcontrato.TabIndex = 5;
            this.txtIDcontrato.Tag = "IDcontrato";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "ID Contrato";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtBusacar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(24, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 82);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contrato";
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
            // listContratos
            // 
            this.listContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listContratos.Location = new System.Drawing.Point(24, 336);
            this.listContratos.Name = "listContratos";
            this.listContratos.RowHeadersWidth = 51;
            this.listContratos.Size = new System.Drawing.Size(496, 104);
            this.listContratos.TabIndex = 55;
            this.listContratos.Tag = "vista_Empleados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 39);
            this.label1.TabIndex = 54;
            this.label1.Text = "Contrato";
            // 
            // Contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 446);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listContratos);
            this.Controls.Add(this.label1);
            this.Name = "Contrato";
            this.Text = "Contrato";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listContratos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.TextBox txttipoContrato;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIDcontrato;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBusacar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView listContratos;
        private System.Windows.Forms.Label label1;
    }
}