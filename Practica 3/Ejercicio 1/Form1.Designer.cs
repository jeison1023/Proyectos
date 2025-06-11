namespace Ejercicio_1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbServicios = new System.Windows.Forms.ComboBox();
            this.cbvehiculo = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgatencion = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalservivio1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalservivio3 = new System.Windows.Forms.Label();
            this.totalservivio2 = new System.Windows.Forms.Label();
            this.lblserviciomenordemanda = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.montoTotallamado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgatencion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de vehiculo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de servivios:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbServicios
            // 
            this.cbServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServicios.FormattingEnabled = true;
            this.cbServicios.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbServicios.Location = new System.Drawing.Point(188, 193);
            this.cbServicios.Name = "cbServicios";
            this.cbServicios.Size = new System.Drawing.Size(177, 28);
            this.cbServicios.TabIndex = 3;
            // 
            // cbvehiculo
            // 
            this.cbvehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbvehiculo.FormattingEnabled = true;
            this.cbvehiculo.Items.AddRange(new object[] {
            "A",
            "C"});
            this.cbvehiculo.Location = new System.Drawing.Point(188, 147);
            this.cbvehiculo.Name = "cbvehiculo";
            this.cbvehiculo.Size = new System.Drawing.Size(177, 28);
            this.cbvehiculo.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(11, 49);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(142, 54);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(188, 49);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(142, 54);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgatencion
            // 
            this.dgatencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgatencion.Location = new System.Drawing.Point(15, 244);
            this.dgatencion.Name = "dgatencion";
            this.dgatencion.RowHeadersWidth = 51;
            this.dgatencion.RowTemplate.Height = 24;
            this.dgatencion.Size = new System.Drawing.Size(738, 343);
            this.dgatencion.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total de Servivios 1( Lavado):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(416, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total de Servivios 2( Enserado):";
            // 
            // totalservivio1
            // 
            this.totalservivio1.AutoSize = true;
            this.totalservivio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalservivio1.Location = new System.Drawing.Point(756, 52);
            this.totalservivio1.Name = "totalservivio1";
            this.totalservivio1.Size = new System.Drawing.Size(19, 20);
            this.totalservivio1.TabIndex = 10;
            this.totalservivio1.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(416, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total de Servivios 3( Silicona):";
            // 
            // totalservivio3
            // 
            this.totalservivio3.AutoSize = true;
            this.totalservivio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalservivio3.Location = new System.Drawing.Point(756, 128);
            this.totalservivio3.Name = "totalservivio3";
            this.totalservivio3.Size = new System.Drawing.Size(19, 20);
            this.totalservivio3.TabIndex = 12;
            this.totalservivio3.Text = "0";
            // 
            // totalservivio2
            // 
            this.totalservivio2.AutoSize = true;
            this.totalservivio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalservivio2.Location = new System.Drawing.Point(756, 90);
            this.totalservivio2.Name = "totalservivio2";
            this.totalservivio2.Size = new System.Drawing.Size(19, 20);
            this.totalservivio2.TabIndex = 13;
            this.totalservivio2.Text = "0";
            // 
            // lblserviciomenordemanda
            // 
            this.lblserviciomenordemanda.AutoSize = true;
            this.lblserviciomenordemanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblserviciomenordemanda.Location = new System.Drawing.Point(416, 165);
            this.lblserviciomenordemanda.Name = "lblserviciomenordemanda";
            this.lblserviciomenordemanda.Size = new System.Drawing.Size(243, 20);
            this.lblserviciomenordemanda.TabIndex = 14;
            this.lblserviciomenordemanda.Text = "Servios de menor demanda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(756, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(416, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Monto promedio de lavado:";
            // 
            // montoTotallamado
            // 
            this.montoTotallamado.AutoSize = true;
            this.montoTotallamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoTotallamado.Location = new System.Drawing.Point(756, 204);
            this.montoTotallamado.Name = "montoTotallamado";
            this.montoTotallamado.Size = new System.Drawing.Size(19, 20);
            this.montoTotallamado.TabIndex = 17;
            this.montoTotallamado.Text = "0";
            this.montoTotallamado.Click += new System.EventHandler(this.lblmontopromedio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1003, 599);
            this.Controls.Add(this.montoTotallamado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblserviciomenordemanda);
            this.Controls.Add(this.totalservivio2);
            this.Controls.Add(this.totalservivio3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalservivio1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgatencion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbvehiculo);
            this.Controls.Add(this.cbServicios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Registro de Atenciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgatencion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbServicios;
        private System.Windows.Forms.ComboBox cbvehiculo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgatencion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalservivio1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalservivio3;
        private System.Windows.Forms.Label totalservivio2;
        private System.Windows.Forms.Label lblserviciomenordemanda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label montoTotallamado;
    }
}

