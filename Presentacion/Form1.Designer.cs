namespace Presentacion
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.cmboperacion = new System.Windows.Forms.ComboBox();
            this.ptbcalcular = new System.Windows.Forms.PictureBox();
            this.ptboperacion = new System.Windows.Forms.PictureBox();
            this.ptbnumero2 = new System.Windows.Forms.PictureBox();
            this.ptbnumeroq = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbcalcular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptboperacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbnumero2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbnumeroq)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 120);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ptbcalcular);
            this.panel2.Controls.Add(this.ptboperacion);
            this.panel2.Controls.Add(this.ptbnumero2);
            this.panel2.Controls.Add(this.ptbnumeroq);
            this.panel2.Controls.Add(this.cmboperacion);
            this.panel2.Controls.Add(this.txtnumero2);
            this.panel2.Controls.Add(this.txtnumero1);
            this.panel2.Controls.Add(this.lblresultado);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 281);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funciones Matematicas Basicas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numero 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "Operacion:";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.ForeColor = System.Drawing.Color.White;
            this.lblresultado.Location = new System.Drawing.Point(530, 83);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(63, 69);
            this.lblresultado.TabIndex = 3;
            this.lblresultado.Text = "0";
            // 
            // txtnumero1
            // 
            this.txtnumero1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero1.Location = new System.Drawing.Point(192, 41);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(177, 38);
            this.txtnumero1.TabIndex = 4;
            // 
            // txtnumero2
            // 
            this.txtnumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero2.Location = new System.Drawing.Point(192, 97);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(177, 45);
            this.txtnumero2.TabIndex = 5;
            // 
            // cmboperacion
            // 
            this.cmboperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboperacion.FormattingEnabled = true;
            this.cmboperacion.Items.AddRange(new object[] {
            "suma",
            "resta",
            "multiplicacion",
            "dividir"});
            this.cmboperacion.Location = new System.Drawing.Point(192, 163);
            this.cmboperacion.Name = "cmboperacion";
            this.cmboperacion.Size = new System.Drawing.Size(169, 46);
            this.cmboperacion.TabIndex = 6;
            // 
            // ptbcalcular
            // 
            this.ptbcalcular.Image = global::Presentacion.Properties.Resources.calcular;
            this.ptbcalcular.Location = new System.Drawing.Point(223, 215);
            this.ptbcalcular.Name = "ptbcalcular";
            this.ptbcalcular.Size = new System.Drawing.Size(82, 59);
            this.ptbcalcular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbcalcular.TabIndex = 10;
            this.ptbcalcular.TabStop = false;
            this.ptbcalcular.Click += new System.EventHandler(this.ptbcalcular_Click);
            // 
            // ptboperacion
            // 
            this.ptboperacion.Image = global::Presentacion.Properties.Resources.calculadora__1_;
            this.ptboperacion.Location = new System.Drawing.Point(367, 158);
            this.ptboperacion.Name = "ptboperacion";
            this.ptboperacion.Size = new System.Drawing.Size(68, 62);
            this.ptboperacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptboperacion.TabIndex = 9;
            this.ptboperacion.TabStop = false;
            // 
            // ptbnumero2
            // 
            this.ptbnumero2.Image = global::Presentacion.Properties.Resources.numero_2;
            this.ptbnumero2.Location = new System.Drawing.Point(375, 88);
            this.ptbnumero2.Name = "ptbnumero2";
            this.ptbnumero2.Size = new System.Drawing.Size(68, 64);
            this.ptbnumero2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbnumero2.TabIndex = 8;
            this.ptbnumero2.TabStop = false;
            this.toolTip1.SetToolTip(this.ptbnumero2, "Boton para grabar el numero 2");
            this.ptbnumero2.Click += new System.EventHandler(this.ptbnumero2_Click);
            // 
            // ptbnumeroq
            // 
            this.ptbnumeroq.Image = global::Presentacion.Properties.Resources.numero_uno;
            this.ptbnumeroq.Location = new System.Drawing.Point(375, 24);
            this.ptbnumeroq.Name = "ptbnumeroq";
            this.ptbnumeroq.Size = new System.Drawing.Size(68, 62);
            this.ptbnumeroq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbnumeroq.TabIndex = 7;
            this.ptbnumeroq.TabStop = false;
            this.toolTip1.SetToolTip(this.ptbnumeroq, "Boton para grabar el numero 1");
            this.ptbnumeroq.Click += new System.EventHandler(this.ptbnumeroq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 432);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbcalcular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptboperacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbnumero2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbnumeroq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptbcalcular;
        private System.Windows.Forms.PictureBox ptboperacion;
        private System.Windows.Forms.PictureBox ptbnumero2;
        private System.Windows.Forms.PictureBox ptbnumeroq;
        private System.Windows.Forms.ComboBox cmboperacion;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

