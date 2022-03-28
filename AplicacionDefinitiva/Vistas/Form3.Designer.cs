
using System.Windows.Forms;

namespace AplicacionDefinitiva.Vistas
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbUsuarioMenu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dasdjaskldjakld = new System.Windows.Forms.Label();
            this.etiVerificacion = new System.Windows.Forms.Label();
            this.etiCorretaMenu = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(132)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 35);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(387, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Menu ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(802, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(832, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Location = new System.Drawing.Point(337, 162);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.Size = new System.Drawing.Size(484, 312);
            this.dgvCuentas.TabIndex = 1;
            this.dgvCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentas_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(332, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Todas sus Cuentas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese Nueva Cuenta a Recordar ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txbUsuarioMenu);
            this.panel2.Location = new System.Drawing.Point(17, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 54);
            this.panel2.TabIndex = 5;
            // 
            // txbUsuarioMenu
            // 
            this.txbUsuarioMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txbUsuarioMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsuarioMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuarioMenu.ForeColor = System.Drawing.SystemColors.Window;
            this.txbUsuarioMenu.Location = new System.Drawing.Point(17, 14);
            this.txbUsuarioMenu.Name = "txbUsuarioMenu";
            this.txbUsuarioMenu.Size = new System.Drawing.Size(204, 24);
            this.txbUsuarioMenu.TabIndex = 0;
            this.txbUsuarioMenu.Enter += new System.EventHandler(this.txbUsuarioMenu_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txbContraseña);
            this.panel3.Location = new System.Drawing.Point(16, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 54);
            this.panel3.TabIndex = 7;
            // 
            // txbContraseña
            // 
            this.txbContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContraseña.ForeColor = System.Drawing.SystemColors.Window;
            this.txbContraseña.Location = new System.Drawing.Point(17, 14);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Size = new System.Drawing.Size(204, 24);
            this.txbContraseña.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(13, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Usuario";
            // 
            // btnAgregarMenu
            // 
            this.btnAgregarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(132)))), ((int)(((byte)(70)))));
            this.btnAgregarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(132)))), ((int)(((byte)(70)))));
            this.btnAgregarMenu.Location = new System.Drawing.Point(16, 345);
            this.btnAgregarMenu.Name = "btnAgregarMenu";
            this.btnAgregarMenu.Size = new System.Drawing.Size(246, 45);
            this.btnAgregarMenu.TabIndex = 11;
            this.btnAgregarMenu.Text = "Guardar";
            this.btnAgregarMenu.UseVisualStyleBackColor = true;
            this.btnAgregarMenu.Click += new System.EventHandler(this.btnAgregarMenu_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(132)))), ((int)(((byte)(70)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(132)))), ((int)(((byte)(70)))));
            this.button1.Location = new System.Drawing.Point(337, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Mostrar Todas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(333, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Buscar";
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBusqueda.Location = new System.Drawing.Point(404, 119);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(311, 24);
            this.txbBusqueda.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(132)))), ((int)(((byte)(70)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(132)))), ((int)(((byte)(70)))));
            this.button2.Location = new System.Drawing.Point(729, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(309, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 528);
            this.panel5.TabIndex = 16;
            // 
            // dasdjaskldjakld
            // 
            this.dasdjaskldjakld.AutoSize = true;
            this.dasdjaskldjakld.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dasdjaskldjakld.Location = new System.Drawing.Point(662, 66);
            this.dasdjaskldjakld.Name = "dasdjaskldjakld";
            this.dasdjaskldjakld.Size = new System.Drawing.Size(35, 13);
            this.dasdjaskldjakld.TabIndex = 17;
            this.dasdjaskldjakld.Text = "label8";
            // 
            // etiVerificacion
            // 
            this.etiVerificacion.AutoSize = true;
            this.etiVerificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiVerificacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.etiVerificacion.Location = new System.Drawing.Point(14, 319);
            this.etiVerificacion.Name = "etiVerificacion";
            this.etiVerificacion.Size = new System.Drawing.Size(295, 15);
            this.etiVerificacion.TabIndex = 18;
            this.etiVerificacion.Text = "Un campos esta vacio ... Intente Nuevamente";
            this.etiVerificacion.Visible = false;
            // 
            // etiCorretaMenu
            // 
            this.etiCorretaMenu.AutoSize = true;
            this.etiCorretaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiCorretaMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.etiCorretaMenu.Location = new System.Drawing.Point(20, 319);
            this.etiCorretaMenu.Name = "etiCorretaMenu";
            this.etiCorretaMenu.Size = new System.Drawing.Size(215, 15);
            this.etiCorretaMenu.TabIndex = 19;
            this.etiCorretaMenu.Text = "Cuenta Agregada Correctamente";
            this.etiCorretaMenu.Visible = false;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(132)))), ((int)(((byte)(70)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(132)))), ((int)(((byte)(70)))));
            this.button3.Location = new System.Drawing.Point(17, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 45);
            this.button3.TabIndex = 20;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(132)))), ((int)(((byte)(70)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(132)))), ((int)(((byte)(70)))));
            this.button4.Location = new System.Drawing.Point(17, 474);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(246, 45);
            this.button4.TabIndex = 21;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(864, 562);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.etiCorretaMenu);
            this.Controls.Add(this.etiVerificacion);
            this.Controls.Add(this.dasdjaskldjakld);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txbBusqueda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregarMenu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbUsuarioMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private Label dasdjaskldjakld;
        private Label etiVerificacion;
        private Label etiCorretaMenu;
        private Button button3;
        private Button button4;

        public Label Dasdjaskldjakld { get => dasdjaskldjakld; set => dasdjaskldjakld = value; }
        public DataGridView DgvCuentas { get => dgvCuentas; set => dgvCuentas = value; }
        public Label EtiVerificacion { get => etiVerificacion; set => etiVerificacion = value; }
        public TextBox TxbUsuarioMenu { get => txbUsuarioMenu; set => txbUsuarioMenu = value; }
        public TextBox TxbContraseña { get => txbContraseña; set => txbContraseña = value; }
        public TextBox TxbBusqueda { get => txbBusqueda; set => txbBusqueda = value; }
        public Label EtiCorretaMenu { get => etiCorretaMenu; set => etiCorretaMenu = value; }
    }
}