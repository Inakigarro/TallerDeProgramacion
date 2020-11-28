
namespace Ejercicio_2
{
    partial class VAgregarCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.AceptarClienteBtn = new System.Windows.Forms.Button();
            this.NombreClienteLbl = new System.Windows.Forms.Label();
            this.ApellidoClienteLbl = new System.Windows.Forms.Label();
            this.NombreClienteTb = new System.Windows.Forms.TextBox();
            this.ApellidoClienteTb = new System.Windows.Forms.TextBox();
            this.TipoDocumentoClienteLbl = new System.Windows.Forms.Label();
            this.TipoDocumentoCb = new System.Windows.Forms.ComboBox();
            this.NumeroDocumentoClienteLbl = new System.Windows.Forms.Label();
            this.NumeroDocumentoClienteTb = new System.Windows.Forms.TextBox();
            this.CancelarClienteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AceptarClienteBtn
            // 
            this.AceptarClienteBtn.Location = new System.Drawing.Point(12, 162);
            this.AceptarClienteBtn.Name = "AceptarClienteBtn";
            this.AceptarClienteBtn.Size = new System.Drawing.Size(101, 27);
            this.AceptarClienteBtn.TabIndex = 0;
            this.AceptarClienteBtn.Text = "Aceptar";
            this.AceptarClienteBtn.UseVisualStyleBackColor = true;
            this.AceptarClienteBtn.Click += new System.EventHandler(this.AgregarClienteBtn_Click);
            // 
            // NombreClienteLbl
            // 
            this.NombreClienteLbl.AutoSize = true;
            this.NombreClienteLbl.Location = new System.Drawing.Point(30, 35);
            this.NombreClienteLbl.Name = "NombreClienteLbl";
            this.NombreClienteLbl.Size = new System.Drawing.Size(50, 13);
            this.NombreClienteLbl.TabIndex = 1;
            this.NombreClienteLbl.Text = "Nombre: ";
            // 
            // ApellidoClienteLbl
            // 
            this.ApellidoClienteLbl.AutoSize = true;
            this.ApellidoClienteLbl.Location = new System.Drawing.Point(30, 61);
            this.ApellidoClienteLbl.Name = "ApellidoClienteLbl";
            this.ApellidoClienteLbl.Size = new System.Drawing.Size(50, 13);
            this.ApellidoClienteLbl.TabIndex = 2;
            this.ApellidoClienteLbl.Text = "Apellido: ";
            // 
            // NombreClienteTb
            // 
            this.NombreClienteTb.Location = new System.Drawing.Point(86, 32);
            this.NombreClienteTb.Name = "NombreClienteTb";
            this.NombreClienteTb.Size = new System.Drawing.Size(100, 20);
            this.NombreClienteTb.TabIndex = 3;
            // 
            // ApellidoClienteTb
            // 
            this.ApellidoClienteTb.Location = new System.Drawing.Point(86, 58);
            this.ApellidoClienteTb.Name = "ApellidoClienteTb";
            this.ApellidoClienteTb.Size = new System.Drawing.Size(100, 20);
            this.ApellidoClienteTb.TabIndex = 4;
            // 
            // TipoDocumentoClienteLbl
            // 
            this.TipoDocumentoClienteLbl.AutoSize = true;
            this.TipoDocumentoClienteLbl.Location = new System.Drawing.Point(12, 91);
            this.TipoDocumentoClienteLbl.Name = "TipoDocumentoClienteLbl";
            this.TipoDocumentoClienteLbl.Size = new System.Drawing.Size(68, 13);
            this.TipoDocumentoClienteLbl.TabIndex = 5;
            this.TipoDocumentoClienteLbl.Text = "Documento: ";
            // 
            // TipoDocumentoCb
            // 
            this.TipoDocumentoCb.FormattingEnabled = true;
            this.TipoDocumentoCb.Location = new System.Drawing.Point(86, 88);
            this.TipoDocumentoCb.Name = "TipoDocumentoCb";
            this.TipoDocumentoCb.Size = new System.Drawing.Size(100, 21);
            this.TipoDocumentoCb.TabIndex = 6;
            // 
            // NumeroDocumentoClienteLbl
            // 
            this.NumeroDocumentoClienteLbl.AutoSize = true;
            this.NumeroDocumentoClienteLbl.Location = new System.Drawing.Point(30, 118);
            this.NumeroDocumentoClienteLbl.Name = "NumeroDocumentoClienteLbl";
            this.NumeroDocumentoClienteLbl.Size = new System.Drawing.Size(50, 13);
            this.NumeroDocumentoClienteLbl.TabIndex = 7;
            this.NumeroDocumentoClienteLbl.Text = "Numero: ";
            // 
            // NumeroDocumentoClienteTb
            // 
            this.NumeroDocumentoClienteTb.Location = new System.Drawing.Point(86, 115);
            this.NumeroDocumentoClienteTb.Name = "NumeroDocumentoClienteTb";
            this.NumeroDocumentoClienteTb.Size = new System.Drawing.Size(100, 20);
            this.NumeroDocumentoClienteTb.TabIndex = 8;
            // 
            // CancelarClienteBtn
            // 
            this.CancelarClienteBtn.Location = new System.Drawing.Point(119, 162);
            this.CancelarClienteBtn.Name = "CancelarClienteBtn";
            this.CancelarClienteBtn.Size = new System.Drawing.Size(101, 27);
            this.CancelarClienteBtn.TabIndex = 9;
            this.CancelarClienteBtn.Text = "Cancelar";
            this.CancelarClienteBtn.UseVisualStyleBackColor = true;
            // 
            // VAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 203);
            this.Controls.Add(this.CancelarClienteBtn);
            this.Controls.Add(this.NumeroDocumentoClienteTb);
            this.Controls.Add(this.NumeroDocumentoClienteLbl);
            this.Controls.Add(this.TipoDocumentoCb);
            this.Controls.Add(this.TipoDocumentoClienteLbl);
            this.Controls.Add(this.ApellidoClienteTb);
            this.Controls.Add(this.NombreClienteTb);
            this.Controls.Add(this.ApellidoClienteLbl);
            this.Controls.Add(this.NombreClienteLbl);
            this.Controls.Add(this.AceptarClienteBtn);
            this.Name = "VAgregarCliente";
            this.Text = "Agregar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FachadaEj2 fachada = new FachadaEj2();
        private System.Windows.Forms.Button AceptarClienteBtn;
        private System.Windows.Forms.Label NombreClienteLbl;
        private System.Windows.Forms.Label ApellidoClienteLbl;
        private System.Windows.Forms.TextBox NombreClienteTb;
        private System.Windows.Forms.TextBox ApellidoClienteTb;
        private System.Windows.Forms.Label TipoDocumentoClienteLbl;
        private System.Windows.Forms.ComboBox TipoDocumentoCb;
        private System.Windows.Forms.Label NumeroDocumentoClienteLbl;
        private System.Windows.Forms.TextBox NumeroDocumentoClienteTb;
        private System.Windows.Forms.Button CancelarClienteBtn;
    }
}

