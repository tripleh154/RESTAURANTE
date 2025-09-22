namespace PantallaDeLogin
{
    partial class Login
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
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBcontrasena = new System.Windows.Forms.TextBox();
            this.BTinicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBnombre
            // 
            this.TBnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnombre.Location = new System.Drawing.Point(288, 82);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(429, 30);
            this.TBnombre.TabIndex = 0;
            this.TBnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBnombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE DE USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTRASEÑA";
            // 
            // TBcontrasena
            // 
            this.TBcontrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBcontrasena.Location = new System.Drawing.Point(288, 166);
            this.TBcontrasena.Name = "TBcontrasena";
            this.TBcontrasena.PasswordChar = '*';
            this.TBcontrasena.Size = new System.Drawing.Size(429, 30);
            this.TBcontrasena.TabIndex = 2;
            this.TBcontrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBcontrasena_KeyPress);
            // 
            // BTinicio
            // 
            this.BTinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTinicio.Location = new System.Drawing.Point(342, 319);
            this.BTinicio.Name = "BTinicio";
            this.BTinicio.Size = new System.Drawing.Size(356, 48);
            this.BTinicio.TabIndex = 4;
            this.BTinicio.Text = "INICIAR";
            this.BTinicio.UseVisualStyleBackColor = true;
            this.BTinicio.Click += new System.EventHandler(this.BTinicio_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 557);
            this.Controls.Add(this.BTinicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBcontrasena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBnombre);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBcontrasena;
        private System.Windows.Forms.Button BTinicio;
    }
}