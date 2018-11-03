namespace Test3
{
    partial class Proveedores
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
            this.txtrsocial = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrazonsocial = new System.Windows.Forms.TextBox();
            this.txtnit = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_tp0_Nit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_tp0_buscar = new System.Windows.Forms.Button();
            this.btn_tp0_modificar = new System.Windows.Forms.Button();
            this.btn_tp0_eliminar = new System.Windows.Forms.Button();
            this.btn_tp0_nuevo = new System.Windows.Forms.Button();
            this.btn_tp0_vertodos = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razon Social";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIT";
            // 
            // txtrsocial
            // 
            this.txtrsocial.Location = new System.Drawing.Point(149, 74);
            this.txtrsocial.Name = "txtrsocial";
            this.txtrsocial.Size = new System.Drawing.Size(413, 20);
            this.txtrsocial.TabIndex = 2;
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(149, 110);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(413, 20);
            this.txtn.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 366);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtrsocial);
            this.tabPage1.Controls.Add(this.txtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso Proveedores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_tp0_vertodos);
            this.tabPage2.Controls.Add(this.txt_tp0_Nit);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btn_tp0_buscar);
            this.tabPage2.Controls.Add(this.btn_tp0_modificar);
            this.tabPage2.Controls.Add(this.btn_tp0_eliminar);
            this.tabPage2.Controls.Add(this.btn_tp0_nuevo);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta Proveedores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtrazonsocial);
            this.tabPage3.Controls.Add(this.txtnit);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(676, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificacion Proveedores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Razon Social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "NIT";
            // 
            // txtrazonsocial
            // 
            this.txtrazonsocial.Location = new System.Drawing.Point(311, 32);
            this.txtrazonsocial.Name = "txtrazonsocial";
            this.txtrazonsocial.Size = new System.Drawing.Size(100, 20);
            this.txtrazonsocial.TabIndex = 6;
            // 
            // txtnit
            // 
            this.txtnit.Location = new System.Drawing.Point(311, 68);
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(100, 20);
            this.txtnit.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(215, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(336, 159);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Nuevo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(429, 158);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Nuevo";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_tp0_Nit
            // 
            this.txt_tp0_Nit.Location = new System.Drawing.Point(90, 50);
            this.txt_tp0_Nit.Name = "txt_tp0_Nit";
            this.txt_tp0_Nit.Size = new System.Drawing.Size(195, 20);
            this.txt_tp0_Nit.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "NIT:";
            // 
            // btn_tp0_buscar
            // 
            this.btn_tp0_buscar.Location = new System.Drawing.Point(300, 48);
            this.btn_tp0_buscar.Name = "btn_tp0_buscar";
            this.btn_tp0_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_tp0_buscar.TabIndex = 11;
            this.btn_tp0_buscar.Text = "Buscar";
            this.btn_tp0_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_tp0_modificar
            // 
            this.btn_tp0_modificar.Location = new System.Drawing.Point(186, 106);
            this.btn_tp0_modificar.Name = "btn_tp0_modificar";
            this.btn_tp0_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_tp0_modificar.TabIndex = 10;
            this.btn_tp0_modificar.Text = "Modificar";
            this.btn_tp0_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_tp0_eliminar
            // 
            this.btn_tp0_eliminar.Location = new System.Drawing.Point(105, 106);
            this.btn_tp0_eliminar.Name = "btn_tp0_eliminar";
            this.btn_tp0_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_tp0_eliminar.TabIndex = 9;
            this.btn_tp0_eliminar.Text = "Eliminar";
            this.btn_tp0_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_tp0_nuevo
            // 
            this.btn_tp0_nuevo.Location = new System.Drawing.Point(24, 106);
            this.btn_tp0_nuevo.Name = "btn_tp0_nuevo";
            this.btn_tp0_nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_tp0_nuevo.TabIndex = 8;
            this.btn_tp0_nuevo.Text = "Nuevo";
            this.btn_tp0_nuevo.UseVisualStyleBackColor = true;
            // 
            // btn_tp0_vertodos
            // 
            this.btn_tp0_vertodos.Location = new System.Drawing.Point(582, 106);
            this.btn_tp0_vertodos.Name = "btn_tp0_vertodos";
            this.btn_tp0_vertodos.Size = new System.Drawing.Size(75, 23);
            this.btn_tp0_vertodos.TabIndex = 14;
            this.btn_tp0_vertodos.Text = "Mostrar Todo";
            this.btn_tp0_vertodos.UseVisualStyleBackColor = true;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 444);
            this.Controls.Add(this.tabControl1);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrsocial;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrazonsocial;
        private System.Windows.Forms.TextBox txtnit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_tp0_vertodos;
        private System.Windows.Forms.TextBox txt_tp0_Nit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_tp0_buscar;
        private System.Windows.Forms.Button btn_tp0_modificar;
        private System.Windows.Forms.Button btn_tp0_eliminar;
        private System.Windows.Forms.Button btn_tp0_nuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

