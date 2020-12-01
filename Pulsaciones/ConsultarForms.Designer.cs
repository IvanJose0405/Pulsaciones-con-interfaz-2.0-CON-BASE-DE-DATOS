namespace Pulsaciones
{
    partial class ConsultarForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarForms));
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.TablaPersonas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnConsultar.FlatAppearance.BorderSize = 9;
            this.BtnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultar.Image")));
            this.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnConsultar.Location = new System.Drawing.Point(12, 107);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 97);
            this.BtnConsultar.TabIndex = 0;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // TablaPersonas
            // 
            this.TablaPersonas.BackgroundColor = System.Drawing.Color.Teal;
            this.TablaPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaPersonas.Location = new System.Drawing.Point(93, 12);
            this.TablaPersonas.Name = "TablaPersonas";
            this.TablaPersonas.Size = new System.Drawing.Size(502, 310);
            this.TablaPersonas.TabIndex = 1;
            // 
            // ConsultarForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(618, 456);
            this.Controls.Add(this.TablaPersonas);
            this.Controls.Add(this.BtnConsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarForms";
            this.Text = "ConsultarForms";
            ((System.ComponentModel.ISupportInitialize)(this.TablaPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.DataGridView TablaPersonas;
    }
}