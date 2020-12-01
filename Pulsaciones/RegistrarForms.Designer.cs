namespace Pulsaciones
{
    partial class RegistrarForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarForms));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.ComboSexo = new System.Windows.Forms.ComboBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo:";
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.AccessibleName = "TxtIdentificacion";
            this.TxtIdentificacion.Location = new System.Drawing.Point(141, 80);
            this.TxtIdentificacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(229, 21);
            this.TxtIdentificacion.TabIndex = 5;
            // 
            // TxtNombre
            // 
            this.TxtNombre.AccessibleName = "TxtNombre";
            this.TxtNombre.Location = new System.Drawing.Point(141, 120);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(229, 21);
            this.TxtNombre.TabIndex = 6;
            // 
            // TxtEdad
            // 
            this.TxtEdad.AccessibleName = "TxtEdad";
            this.TxtEdad.Location = new System.Drawing.Point(141, 150);
            this.TxtEdad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(229, 21);
            this.TxtEdad.TabIndex = 7;
            // 
            // ComboSexo
            // 
            this.ComboSexo.AccessibleName = "ComboSexo";
            this.ComboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSexo.FormattingEnabled = true;
            this.ComboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.ComboSexo.Location = new System.Drawing.Point(141, 177);
            this.ComboSexo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboSexo.Name = "ComboSexo";
            this.ComboSexo.Size = new System.Drawing.Size(229, 23);
            this.ComboSexo.TabIndex = 10;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.AccessibleName = "BtnGuardar";
            this.BtnGuardar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatAppearance.BorderSize = 4;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(141, 216);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(229, 62);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // RegistrarForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1067, 519);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.ComboSexo);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RegistrarForms";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.RegistrarForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.ComboBox ComboSexo;
        private System.Windows.Forms.Button BtnGuardar;
    }
}