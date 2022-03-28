
using System.Windows.Forms;

namespace AplicacionDefinitiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IconoCerrar = new System.Windows.Forms.PictureBox();
            this.IconoMinimizar = new System.Windows.Forms.PictureBox();
            this.IconoAgrandar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrarme = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.etiErrorLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoAgrandar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // IconoCerrar
            // 
            this.IconoCerrar.Image = ((System.Drawing.Image)(resources.GetObject("IconoCerrar.Image")));
            this.IconoCerrar.Location = new System.Drawing.Point(362, 2);
            this.IconoCerrar.Name = "IconoCerrar";
            this.IconoCerrar.Size = new System.Drawing.Size(30, 25);
            this.IconoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoCerrar.TabIndex = 0;
            this.IconoCerrar.TabStop = false;
            this.IconoCerrar.Click += new System.EventHandler(this.IconoCerrar_Click);
            // 
            // IconoMinimizar
            // 
            this.IconoMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.IconoMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("IconoMinimizar.Image")));
            this.IconoMinimizar.Location = new System.Drawing.Point(309, 2);
            this.IconoMinimizar.Name = "IconoMinimizar";
            this.IconoMinimizar.Size = new System.Drawing.Size(28, 25);
            this.IconoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoMinimizar.TabIndex = 1;
            this.IconoMinimizar.TabStop = false;
            this.IconoMinimizar.Click += new System.EventHandler(this.IconoMinimizar_Click);
            // 
            // IconoAgrandar
            // 
            this.IconoAgrandar.Image = ((System.Drawing.Image)(resources.GetObject("IconoAgrandar.Image")));
            this.IconoAgrandar.Location = new System.Drawing.Point(334, 2);
            this.IconoAgrandar.Name = "IconoAgrandar";
            this.IconoAgrandar.Size = new System.Drawing.Size(31, 25);
            this.IconoAgrandar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoAgrandar.TabIndex = 2;
            this.IconoAgrandar.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(102, 58);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(201, 143);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(76, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // txbUsuario
            // 
            this.txbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(204)))), ((int)(((byte)(101)))));
            this.txbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txbUsuario.Location = new System.Drawing.Point(90, 326);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(222, 22);
            this.txbUsuario.TabIndex = 5;
            this.txbUsuario.Enter += new System.EventHandler(this.txbUsuario_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // txbContraseña
            // 
            this.txbContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(204)))), ((int)(((byte)(101)))));
            this.txbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContraseña.Location = new System.Drawing.Point(90, 427);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.PasswordChar = '*';
            this.txbContraseña.Size = new System.Drawing.Size(222, 22);
            this.txbContraseña.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(125, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Iniciar Sesion ";
            // 
            // btnRegistrarme
            // 
            this.btnRegistrarme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarme.Location = new System.Drawing.Point(34, 519);
            this.btnRegistrarme.Name = "btnRegistrarme";
            this.btnRegistrarme.Size = new System.Drawing.Size(145, 35);
            this.btnRegistrarme.TabIndex = 10;
            this.btnRegistrarme.Text = "Registrarme";
            this.btnRegistrarme.UseVisualStyleBackColor = true;
            this.btnRegistrarme.Click += new System.EventHandler(this.btnRegistrarme_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(90, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 1);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(90, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 1);
            this.panel2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 590);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "- Por Isaias Romano";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(208, 519);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(145, 35);
            this.btnIniciarSesion.TabIndex = 16;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // etiErrorLogin
            // 
            this.etiErrorLogin.AutoSize = true;
            this.etiErrorLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiErrorLogin.Location = new System.Drawing.Point(41, 484);
            this.etiErrorLogin.Name = "etiErrorLogin";
            this.etiErrorLogin.Size = new System.Drawing.Size(211, 13);
            this.etiErrorLogin.TabIndex = 17;
            this.etiErrorLogin.Text = "Usuario y/o Contraseña Incorrecto..";
            this.etiErrorLogin.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(204)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(394, 612);
            this.Controls.Add(this.etiErrorLogin);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegistrarme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.IconoAgrandar);
            this.Controls.Add(this.IconoMinimizar);
            this.Controls.Add(this.IconoCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IconoCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoAgrandar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconoCerrar;
        private System.Windows.Forms.PictureBox IconoMinimizar;
        private System.Windows.Forms.PictureBox IconoAgrandar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrarme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label etiErrorLogin;

        public Label EtiErrorLogin { get => etiErrorLogin; set => etiErrorLogin = value; }
        
        public TextBox TxbUsuario { get => txbUsuario; set => txbUsuario = value; }
        public TextBox TxbContraseña { get => txbContraseña; set => txbContraseña = value; }
    }
}

