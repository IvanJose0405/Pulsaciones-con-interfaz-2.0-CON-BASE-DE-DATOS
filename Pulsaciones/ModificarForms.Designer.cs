namespace Pulsaciones
{
    partial class ModificarForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarForms));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.ComboSexo = new System.Windows.Forms.ComboBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sexo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Edad: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtNombre
            // 
            this.TxtNombre.AccessibleName = "TxtNombre";
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Location = new System.Drawing.Point(120, 75);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(116, 20);
            this.TxtNombre.TabIndex = 8;
            // 
            // TxtEdad
            // 
            this.TxtEdad.AccessibleName = "TxtEdad";
            this.TxtEdad.Enabled = false;
            this.TxtEdad.Location = new System.Drawing.Point(120, 101);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(116, 20);
            this.TxtEdad.TabIndex = 9;
            // 
            // ComboSexo
            // 
            this.ComboSexo.AccessibleName = "ComboSexo";
            this.ComboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSexo.Enabled = false;
            this.ComboSexo.FormattingEnabled = true;
            this.ComboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.ComboSexo.Location = new System.Drawing.Point(120, 137);
            this.ComboSexo.Name = "ComboSexo";
            this.ComboSexo.Size = new System.Drawing.Size(116, 21);
            this.ComboSexo.TabIndex = 10;
            // 
            // BtnModificar
            // 
            this.BtnModificar.AccessibleName = "BtnModificar";
            this.BtnModificar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnModificar.Enabled = false;
            this.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(120, 177);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(116, 38);
            this.BtnModificar.TabIndex = 11;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.AccessibleName = "TxtIdentificacion";
            this.TxtIdentificacion.Location = new System.Drawing.Point(120, 41);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(116, 20);
            this.TxtIdentificacion.TabIndex = 1;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AccessibleName = "BtnBuscar";
            this.BtnBuscar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatAppearance.BorderSize = 4;
            this.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(262, 32);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(91, 36);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // ModificarForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(721, 456);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.ComboSexo);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarForms";
            this.Text = "ModificarForms";
            this.Load += new System.EventHandler(this.ModificarForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.ComboBox ComboSexo;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnModificar;
    }
}