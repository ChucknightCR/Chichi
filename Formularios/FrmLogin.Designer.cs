namespace Chichi.Formularios
{
    partial class FrmLogin
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
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Contrasenia = new System.Windows.Forms.TextBox();
            this.Txt_NombreUsuario = new System.Windows.Forms.TextBox();
            this.Btn_IngresoDirecto = new System.Windows.Forms.Button();
            this.btn_VerPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(3, 398);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(143, 51);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.Green;
            this.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_Ingresar.Location = new System.Drawing.Point(654, 398);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(143, 51);
            this.btn_Ingresar.TabIndex = 2;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(240, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(240, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Contrasenia
            // 
            this.Txt_Contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Contrasenia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Txt_Contrasenia.Location = new System.Drawing.Point(240, 358);
            this.Txt_Contrasenia.Name = "Txt_Contrasenia";
            this.Txt_Contrasenia.Size = new System.Drawing.Size(276, 29);
            this.Txt_Contrasenia.TabIndex = 7;
            this.Txt_Contrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Contrasenia.UseSystemPasswordChar = true;
            this.Txt_Contrasenia.TextChanged += new System.EventHandler(this.Txt_Contrasenia_TextChanged);
            // 
            // Txt_NombreUsuario
            // 
            this.Txt_NombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreUsuario.ForeColor = System.Drawing.Color.Black;
            this.Txt_NombreUsuario.Location = new System.Drawing.Point(245, 76);
            this.Txt_NombreUsuario.Name = "Txt_NombreUsuario";
            this.Txt_NombreUsuario.Size = new System.Drawing.Size(276, 29);
            this.Txt_NombreUsuario.TabIndex = 6;
            this.Txt_NombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_IngresoDirecto
            // 
            this.Btn_IngresoDirecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_IngresoDirecto.Location = new System.Drawing.Point(3, 1);
            this.Btn_IngresoDirecto.Name = "Btn_IngresoDirecto";
            this.Btn_IngresoDirecto.Size = new System.Drawing.Size(102, 29);
            this.Btn_IngresoDirecto.TabIndex = 10;
            this.Btn_IngresoDirecto.Text = "Ingreso Directo";
            this.Btn_IngresoDirecto.UseVisualStyleBackColor = false;
            this.Btn_IngresoDirecto.Visible = false;
            this.Btn_IngresoDirecto.Click += new System.EventHandler(this.Btn_IngresoDirecto_Click);
            // 
            // btn_VerPassword
            // 
            this.btn_VerPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_VerPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_VerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_VerPassword.Location = new System.Drawing.Point(522, 358);
            this.btn_VerPassword.Name = "btn_VerPassword";
            this.btn_VerPassword.Size = new System.Drawing.Size(121, 29);
            this.btn_VerPassword.TabIndex = 11;
            this.btn_VerPassword.Text = "Ver contraseña";
            this.btn_VerPassword.UseVisualStyleBackColor = false;
            this.btn_VerPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_VerPassword_MouseDown);
            this.btn_VerPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_VerPassword_MouseUp);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btn_Ingresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chichi.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_VerPassword);
            this.Controls.Add(this.Btn_IngresoDirecto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Contrasenia);
            this.Controls.Add(this.Txt_NombreUsuario);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Ingresar);
            this.KeyPreview = true;
            this.Name = "FrmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Contrasenia;
        private System.Windows.Forms.TextBox Txt_NombreUsuario;
        private System.Windows.Forms.Button Btn_IngresoDirecto;
        private System.Windows.Forms.Button btn_VerPassword;
    }
}