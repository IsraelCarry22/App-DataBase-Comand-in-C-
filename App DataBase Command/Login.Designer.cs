namespace App_DataBase_Command
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
            ConectarBtm = new Button();
            ContraseñaTxb = new TextBox();
            label2 = new Label();
            UsuarioTxb = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // ConectarBtm
            // 
            ConectarBtm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConectarBtm.Location = new Point(114, 253);
            ConectarBtm.Name = "ConectarBtm";
            ConectarBtm.Size = new Size(117, 38);
            ConectarBtm.TabIndex = 9;
            ConectarBtm.Text = "Conectar";
            ConectarBtm.UseVisualStyleBackColor = true;
            ConectarBtm.Click += ConectarBtm_Click;
            // 
            // ContraseñaTxb
            // 
            ContraseñaTxb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContraseñaTxb.Location = new Point(130, 171);
            ContraseñaTxb.Name = "ContraseñaTxb";
            ContraseñaTxb.Size = new Size(214, 29);
            ContraseñaTxb.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 171);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 7;
            label2.Text = "Contraseña:";
            // 
            // UsuarioTxb
            // 
            UsuarioTxb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsuarioTxb.Location = new Point(130, 126);
            UsuarioTxb.Name = "UsuarioTxb";
            UsuarioTxb.Size = new Size(214, 29);
            UsuarioTxb.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 126);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 5;
            label1.Text = "Usuario:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 303);
            Controls.Add(ConectarBtm);
            Controls.Add(ContraseñaTxb);
            Controls.Add(label2);
            Controls.Add(UsuarioTxb);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConectarBtm;
        private TextBox ContraseñaTxb;
        private Label label2;
        private TextBox UsuarioTxb;
        private Label label1;
    }
}