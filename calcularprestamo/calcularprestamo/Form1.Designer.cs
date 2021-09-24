namespace calcularprestamo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtperiodo = new System.Windows.Forms.TextBox();
            this.txtinteres = new System.Windows.Forms.TextBox();
            this.txtprestamo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtcuota = new System.Windows.Forms.TextBox();
            this.txttotalprestamo = new System.Windows.Forms.TextBox();
            this.txttotalinteres = new System.Windows.Forms.TextBox();
            this.txtinteresmensual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtperiodo);
            this.groupBox1.Controls.Add(this.txtinteres);
            this.groupBox1.Controls.Add(this.txtprestamo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "pretsamo";
            // 
            // txtperiodo
            // 
            this.txtperiodo.Location = new System.Drawing.Point(160, 122);
            this.txtperiodo.Name = "txtperiodo";
            this.txtperiodo.Size = new System.Drawing.Size(100, 20);
            this.txtperiodo.TabIndex = 5;
            // 
            // txtinteres
            // 
            this.txtinteres.Location = new System.Drawing.Point(140, 81);
            this.txtinteres.Name = "txtinteres";
            this.txtinteres.Size = new System.Drawing.Size(100, 20);
            this.txtinteres.TabIndex = 4;
            // 
            // txtprestamo
            // 
            this.txtprestamo.Location = new System.Drawing.Point(118, 36);
            this.txtprestamo.Name = "txtprestamo";
            this.txtprestamo.Size = new System.Drawing.Size(100, 20);
            this.txtprestamo.TabIndex = 3;
            this.txtprestamo.TextChanged += new System.EventHandler(this.txtprestamo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Periodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " interes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prestamo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsalir);
            this.groupBox2.Controls.Add(this.btnlimpiar);
            this.groupBox2.Controls.Add(this.btncalcular);
            this.groupBox2.Controls.Add(this.txtcuota);
            this.groupBox2.Controls.Add(this.txttotalprestamo);
            this.groupBox2.Controls.Add(this.txttotalinteres);
            this.groupBox2.Controls.Add(this.txtinteresmensual);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(19, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(650, 129);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(60, 30);
            this.btnsalir.TabIndex = 10;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(650, 83);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(55, 23);
            this.btnlimpiar.TabIndex = 9;
            this.btnlimpiar.Text = "limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(645, 28);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(60, 23);
            this.btncalcular.TabIndex = 8;
            this.btncalcular.Text = "calcular\r\n";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtcuota
            // 
            this.txtcuota.Location = new System.Drawing.Point(345, 85);
            this.txtcuota.Name = "txtcuota";
            this.txtcuota.Size = new System.Drawing.Size(100, 20);
            this.txtcuota.TabIndex = 7;
            // 
            // txttotalprestamo
            // 
            this.txttotalprestamo.Location = new System.Drawing.Point(379, 38);
            this.txttotalprestamo.Name = "txttotalprestamo";
            this.txttotalprestamo.Size = new System.Drawing.Size(100, 20);
            this.txttotalprestamo.TabIndex = 6;
            // 
            // txttotalinteres
            // 
            this.txttotalinteres.Location = new System.Drawing.Point(155, 75);
            this.txttotalinteres.Name = "txttotalinteres";
            this.txttotalinteres.Size = new System.Drawing.Size(100, 20);
            this.txttotalinteres.TabIndex = 5;
            this.txttotalinteres.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtinteresmensual
            // 
            this.txtinteresmensual.Location = new System.Drawing.Point(155, 38);
            this.txtinteresmensual.Name = "txtinteresmensual";
            this.txtinteresmensual.Size = new System.Drawing.Size(100, 20);
            this.txtinteresmensual.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "cuota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "total  prestamo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "total interes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = " interes mensual";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtperiodo;
        private System.Windows.Forms.TextBox txtinteres;
        private System.Windows.Forms.TextBox txtprestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcuota;
        private System.Windows.Forms.TextBox txttotalprestamo;
        private System.Windows.Forms.TextBox txttotalinteres;
        private System.Windows.Forms.TextBox txtinteresmensual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncalcular;
    }
}

