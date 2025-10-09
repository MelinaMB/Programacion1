
namespace CajaCobranzaColas
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCajaRapida;
        private System.Windows.Forms.Button btnCajaNormal;
        private System.Windows.Forms.ListBox listBoxGeneral;
        private System.Windows.Forms.ListBox listBoxRapida;
        private System.Windows.Forms.ListBox listBoxNormal;
        private System.Windows.Forms.Label lblGeneral;
        private System.Windows.Forms.Label lblRapida;
        private System.Windows.Forms.Label lblNormal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCajaRapida = new System.Windows.Forms.Button();
            this.btnCajaNormal = new System.Windows.Forms.Button();
            this.listBoxGeneral = new System.Windows.Forms.ListBox();
            this.listBoxRapida = new System.Windows.Forms.ListBox();
            this.listBoxNormal = new System.Windows.Forms.ListBox();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.lblRapida = new System.Windows.Forms.Label();
            this.lblNormal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(30, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 23);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(30, 60);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PlaceholderText = "Cantidad";
            this.txtCantidad.Size = new System.Drawing.Size(150, 23);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(30, 90);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.PlaceholderText = "Importe";
            this.txtImporte.Size = new System.Drawing.Size(150, 23);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 130);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 30);
            this.btnAgregar.Text = "Agregar Cliente";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCajaRapida
            // 
            this.btnCajaRapida.Location = new System.Drawing.Point(200, 130);
            this.btnCajaRapida.Name = "btnCajaRapida";
            this.btnCajaRapida.Size = new System.Drawing.Size(150, 30);
            this.btnCajaRapida.Text = "Pagar Caja Rápida";
            this.btnCajaRapida.Click += new System.EventHandler(this.btnCajaRapida_Click);
            // 
            // btnCajaNormal
            // 
            this.btnCajaNormal.Location = new System.Drawing.Point(370, 130);
            this.btnCajaNormal.Name = "btnCajaNormal";
            this.btnCajaNormal.Size = new System.Drawing.Size(150, 30);
            this.btnCajaNormal.Text = "Pagar Caja Normal";
            this.btnCajaNormal.Click += new System.EventHandler(this.btnCajaNormal_Click);
            // 
            // listBoxGeneral
            // 
            this.listBoxGeneral.FormattingEnabled = true;
            this.listBoxGeneral.ItemHeight = 15;
            this.listBoxGeneral.Location = new System.Drawing.Point(30, 190);
            this.listBoxGeneral.Size = new System.Drawing.Size(150, 150);
            // 
            // listBoxRapida
            // 
            this.listBoxRapida.FormattingEnabled = true;
            this.listBoxRapida.ItemHeight = 15;
            this.listBoxRapida.Location = new System.Drawing.Point(200, 190);
            this.listBoxRapida.Size = new System.Drawing.Size(150, 150);
            // 
            // listBoxNormal
            // 
            this.listBoxNormal.FormattingEnabled = true;
            this.listBoxNormal.ItemHeight = 15;
            this.listBoxNormal.Location = new System.Drawing.Point(370, 190);
            this.listBoxNormal.Size = new System.Drawing.Size(150, 150);
            // 
            // Labels
            // 
            this.lblGeneral.Location = new System.Drawing.Point(30, 170);
            this.lblGeneral.Text = "Cola General";
            this.lblRapida.Location = new System.Drawing.Point(200, 170);
            this.lblRapida.Text = "Caja Rápida";
            this.lblNormal.Location = new System.Drawing.Point(370, 170);
            this.lblNormal.Text = "Caja Normal";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(560, 370);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCajaRapida);
            this.Controls.Add(this.btnCajaNormal);
            this.Controls.Add(this.listBoxGeneral);
            this.Controls.Add(this.listBoxRapida);
            this.Controls.Add(this.listBoxNormal);
            this.Controls.Add(this.lblGeneral);
            this.Controls.Add(this.lblRapida);
            this.Controls.Add(this.lblNormal);
            this.Name = "Form1";
            this.Text = "Simulación de Caja con Colas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
