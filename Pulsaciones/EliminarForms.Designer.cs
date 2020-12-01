namespace Pulsaciones
{
    partial class EliminarForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarForms));
            this.BtnModificar = new System.Windows.Forms.Button();
            this.ComboSexo = new System.Windows.Forms.ComboBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnModificar
            // 
            this.BtnModificar.AccessibleName = "BtnModificar";
            this.BtnModificar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnModificar.Enabled = false;
            this.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnModificar.FlatAppearance.BorderSize = 4;
            this.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(133, 181);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(100, 36);
            this.BtnModificar.TabIndex = 21;
            this.BtnModificar.Text = "Eliminar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // ComboSexo
            // 
            this.ComboSexo.AccessibleName = "ComboSexo";
            this.ComboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSexo.Enabled = false;
            this.ComboSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboSexo.FormattingEnabled = true;
            this.ComboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.ComboSexo.Location = new System.Drawing.Point(133, 139);
            this.ComboSexo.Name = "ComboSexo";
            this.ComboSexo.Size = new System.Drawing.Size(100, 23);
            this.ComboSexo.TabIndex = 20;
            // 
            // TxtEdad
            // 
            this.TxtEdad.AccessibleName = "TxtEdad";
            this.TxtEdad.Enabled = false;
            this.TxtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEdad.Location = new System.Drawing.Point(133, 103);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(100, 21);
            this.TxtEdad.TabIndex = 19;
            // 
            // TxtNombre
            // 
            this.TxtNombre.AccessibleName = "TxtNombre";
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(133, 77);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 21);
            this.TxtNombre.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Edad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre:";
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
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(251, 31);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(103, 33);
            this.BtnBuscar.TabIndex = 14;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.AccessibleName = "TxtIdentificacion";
            this.TxtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.Location = new System.Drawing.Point(133, 38);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(100, 21);
            this.TxtIdentificacion.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Identificacion:";
            // 
            // EliminarForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(618, 456);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarForms";
            this.Text = "EliminarForms";
            this.Load += new System.EventHandler(this.EliminarForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.ComboBox ComboSexo;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label label1;
    }
}