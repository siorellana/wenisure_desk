namespace FacialRecognition
{
    partial class ModEnroll
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModEnroll));
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnStartCam = new System.Windows.Forms.Button();
            this.btnDetectCam = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblRut = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.boxPerfil = new System.Windows.Forms.ComboBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(22, 112);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(283, 234);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(356, 112);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(214, 161);
            this.imageBox2.TabIndex = 4;
            this.imageBox2.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(610, 161);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(607, 145);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // btnStartCam
            // 
            this.btnStartCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(20)))));
            this.btnStartCam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnStartCam.ForeColor = System.Drawing.Color.Black;
            this.btnStartCam.Location = new System.Drawing.Point(329, 395);
            this.btnStartCam.Name = "btnStartCam";
            this.btnStartCam.Size = new System.Drawing.Size(153, 54);
            this.btnStartCam.TabIndex = 9;
            this.btnStartCam.Text = "Encender \r\nCamara";
            this.btnStartCam.UseVisualStyleBackColor = false;
            this.btnStartCam.Click += new System.EventHandler(this.btnStartCam_Click);
            // 
            // btnDetectCam
            // 
            this.btnDetectCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(20)))));
            this.btnDetectCam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetectCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDetectCam.ForeColor = System.Drawing.Color.Black;
            this.btnDetectCam.Location = new System.Drawing.Point(329, 395);
            this.btnDetectCam.Name = "btnDetectCam";
            this.btnDetectCam.Size = new System.Drawing.Size(153, 54);
            this.btnDetectCam.TabIndex = 10;
            this.btnDetectCam.Text = "Tomar Fotografía";
            this.btnDetectCam.UseVisualStyleBackColor = false;
            this.btnDetectCam.Visible = false;
            this.btnDetectCam.Click += new System.EventHandler(this.btnDetectCam_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.btnVolver);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 60);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(795, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FacialRecognition.Properties.Resources.logo_banner;
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(149, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(818, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(20)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Location = new System.Drawing.Point(653, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(136, 32);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver a Menu";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(20)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.Color.Black;
            this.btnIngresar.Location = new System.Drawing.Point(329, 395);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(153, 54);
            this.btnIngresar.TabIndex = 18;
            this.btnIngresar.Text = "Registrar en Base de Datos";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Visible = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(607, 192);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(30, 13);
            this.lblRut.TabIndex = 20;
            this.lblRut.Text = "RUT";
            this.lblRut.Visible = false;
            this.lblRut.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(610, 208);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(202, 20);
            this.txtRut.TabIndex = 19;
            this.txtRut.Tag = "";
            this.txtRut.Text = "12345678K";
            this.txtRut.Visible = false;
            this.txtRut.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(588, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ingrese los siguientes datos:";
            this.label1.Visible = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(607, 250);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(40, 13);
            this.lblHora.TabIndex = 22;
            this.lblHora.Text = "lblHora";
            this.lblHora.Visible = false;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(607, 287);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(30, 13);
            this.lblPerfil.TabIndex = 23;
            this.lblPerfil.Text = "Perfil";
            this.lblPerfil.Visible = false;
            // 
            // boxPerfil
            // 
            this.boxPerfil.FormattingEnabled = true;
            this.boxPerfil.Items.AddRange(new object[] {
            "Educador",
            "Administrativo",
            "Apoderado",
            "Visita",
            "Otro"});
            this.boxPerfil.Location = new System.Drawing.Point(610, 304);
            this.boxPerfil.Name = "boxPerfil";
            this.boxPerfil.Size = new System.Drawing.Size(202, 21);
            this.boxPerfil.TabIndex = 24;
            this.boxPerfil.Text = "Seleccione Perfil";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMensaje.Location = new System.Drawing.Point(607, 354);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(57, 13);
            this.lblMensaje.TabIndex = 25;
            this.lblMensaje.Text = "lblMensaje";
            this.lblMensaje.Visible = false;
            // 
            // ModEnroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 500);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.boxPerfil);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRut);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDetectCam);
            this.Controls.Add(this.btnStartCam);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(840, 500);
            this.MinimumSize = new System.Drawing.Size(840, 500);
            this.Name = "ModEnroll";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrrolamiento";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnStartCam;
        private System.Windows.Forms.Button btnDetectCam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox boxPerfil;
        private System.Windows.Forms.Label lblMensaje;
    }
}

