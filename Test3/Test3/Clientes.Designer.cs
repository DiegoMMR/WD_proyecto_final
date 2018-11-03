namespace Test3
{
    partial class Clientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.text_busqueda = new System.Windows.Forms.TextBox();
            this.btn_busqueda = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.fechacover = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.fechanac = new System.Windows.Forms.DateTimePicker();
            this.txtmontocovertura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtcodpaciente = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.Boton_modificar_TP0 = new System.Windows.Forms.Button();
            this.fechacov = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.fechanaci = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtpaciente = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(239, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(25, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 394);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.text_busqueda);
            this.tabPage2.Controls.Add(this.btn_busqueda);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta Clientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "CODIGO CLIENTE";
            // 
            // text_busqueda
            // 
            this.text_busqueda.Location = new System.Drawing.Point(131, 17);
            this.text_busqueda.Name = "text_busqueda";
            this.text_busqueda.Size = new System.Drawing.Size(210, 20);
            this.text_busqueda.TabIndex = 2;
            // 
            // btn_busqueda
            // 
            this.btn_busqueda.Location = new System.Drawing.Point(359, 14);
            this.btn_busqueda.Name = "btn_busqueda";
            this.btn_busqueda.Size = new System.Drawing.Size(75, 23);
            this.btn_busqueda.TabIndex = 1;
            this.btn_busqueda.Text = "Busqueda";
            this.btn_busqueda.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(713, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtstatus);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.fechacover);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.fechanac);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtmontocovertura);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txttel);
            this.tabPage1.Controls.Add(this.txtcodpaciente);
            this.tabPage1.Controls.Add(this.txtfullname);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(177, 210);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(100, 20);
            this.txtstatus.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Estatus";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(332, 247);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 30;
            this.button6.Text = "Nuevo";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // fechacover
            // 
            this.fechacover.Location = new System.Drawing.Point(133, 159);
            this.fechacover.Name = "fechacover";
            this.fechacover.Size = new System.Drawing.Size(200, 20);
            this.fechacover.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fecha Inicio Covertura";
            // 
            // fechanac
            // 
            this.fechanac.Location = new System.Drawing.Point(133, 98);
            this.fechanac.Name = "fechanac";
            this.fechanac.Size = new System.Drawing.Size(200, 20);
            this.fechanac.TabIndex = 13;
            // 
            // txtmontocovertura
            // 
            this.txtmontocovertura.Location = new System.Drawing.Point(177, 184);
            this.txtmontocovertura.Name = "txtmontocovertura";
            this.txtmontocovertura.Size = new System.Drawing.Size(100, 20);
            this.txtmontocovertura.TabIndex = 9;
            this.txtmontocovertura.TextChanged += new System.EventHandler(this.txtmontocovertura_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto de covertura";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(177, 124);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 8;
            // 
            // txtcodpaciente
            // 
            this.txtcodpaciente.Location = new System.Drawing.Point(177, 43);
            this.txtcodpaciente.Name = "txtcodpaciente";
            this.txtcodpaciente.Size = new System.Drawing.Size(100, 20);
            this.txtcodpaciente.TabIndex = 5;
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(177, 71);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(100, 20);
            this.txtfullname.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.Boton_modificar_TP0);
            this.tabPage3.Controls.Add(this.fechacov);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.fechanaci);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtmonto);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txttelefono);
            this.tabPage3.Controls.Add(this.txtpaciente);
            this.tabPage3.Controls.Add(this.txtnombre);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(742, 368);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificacion Cliente";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(316, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Nuevo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Boton_modificar_TP0
            // 
            this.Boton_modificar_TP0.Location = new System.Drawing.Point(207, 229);
            this.Boton_modificar_TP0.Name = "Boton_modificar_TP0";
            this.Boton_modificar_TP0.Size = new System.Drawing.Size(75, 23);
            this.Boton_modificar_TP0.TabIndex = 28;
            this.Boton_modificar_TP0.Text = "Modificar";
            this.Boton_modificar_TP0.UseVisualStyleBackColor = true;
            // 
            // fechacov
            // 
            this.fechacov.Location = new System.Drawing.Point(151, 143);
            this.fechacov.Name = "fechacov";
            this.fechacov.Size = new System.Drawing.Size(200, 20);
            this.fechacov.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fecha Inicio Covertura";
            // 
            // fechanaci
            // 
            this.fechanaci.Location = new System.Drawing.Point(151, 82);
            this.fechanaci.Name = "fechanaci";
            this.fechanaci.Size = new System.Drawing.Size(200, 20);
            this.fechanaci.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Codigo Paciente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nombre Completo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Fecha Nacimiento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Telefono";
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(195, 168);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(100, 20);
            this.txtmonto.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Monto de covertura";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(195, 108);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 23;
            this.txttelefono.TextChanged += new System.EventHandler(this.txttelefono_TextChanged);
            // 
            // txtpaciente
            // 
            this.txtpaciente.Location = new System.Drawing.Point(195, 27);
            this.txtpaciente.Name = "txtpaciente";
            this.txtpaciente.Size = new System.Drawing.Size(100, 20);
            this.txtpaciente.TabIndex = 21;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(195, 55);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 22;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 443);
            this.Controls.Add(this.tabControl1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox text_busqueda;
        private System.Windows.Forms.Button btn_busqueda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker fechanac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fechacover;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Boton_modificar_TP0;
        private System.Windows.Forms.DateTimePicker fechacov;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker fechanaci;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtpaciente;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtmontocovertura;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtcodpaciente;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Label label14;
    }
}