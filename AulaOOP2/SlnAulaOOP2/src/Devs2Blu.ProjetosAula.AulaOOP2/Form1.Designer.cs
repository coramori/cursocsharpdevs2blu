namespace Devs2Blu.ProjetosAula.AulaOOP2
{
    partial class Form1
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
            this.formContact = new System.Windows.Forms.GroupBox();
            this.labelTexto = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelNumRua = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelBairro = new System.Windows.Forms.Label();
            this.labelRua = new System.Windows.Forms.Label();
            this.labelCep = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.formContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // formContact
            // 
            this.formContact.BackColor = System.Drawing.Color.Gainsboro;
            this.formContact.Controls.Add(this.labelTexto);
            this.formContact.Controls.Add(this.txtTexto);
            this.formContact.Controls.Add(this.btnLimpar);
            this.formContact.Controls.Add(this.btnEnviar);
            this.formContact.Controls.Add(this.txtEstado);
            this.formContact.Controls.Add(this.txtCidade);
            this.formContact.Controls.Add(this.txtBairro);
            this.formContact.Controls.Add(this.txtNumero);
            this.formContact.Controls.Add(this.txtRua);
            this.formContact.Controls.Add(this.txtCep);
            this.formContact.Controls.Add(this.txtEmail);
            this.formContact.Controls.Add(this.txtTel);
            this.formContact.Controls.Add(this.txtNome);
            this.formContact.Controls.Add(this.labelNumRua);
            this.formContact.Controls.Add(this.labelEstado);
            this.formContact.Controls.Add(this.labelCidade);
            this.formContact.Controls.Add(this.labelBairro);
            this.formContact.Controls.Add(this.labelRua);
            this.formContact.Controls.Add(this.labelCep);
            this.formContact.Controls.Add(this.labelEmail);
            this.formContact.Controls.Add(this.labelPhone);
            this.formContact.Controls.Add(this.labelName);
            this.formContact.Location = new System.Drawing.Point(36, 13);
            this.formContact.Name = "formContact";
            this.formContact.Size = new System.Drawing.Size(856, 412);
            this.formContact.TabIndex = 0;
            this.formContact.TabStop = false;
            this.formContact.Text = "Contato";
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexto.Location = new System.Drawing.Point(640, 29);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(48, 20);
            this.labelTexto.TabIndex = 23;
            this.labelTexto.Text = "Texto";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(511, 54);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(299, 248);
            this.txtTexto.TabIndex = 22;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Red;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(295, 337);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(140, 43);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(134, 337);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(140, 43);
            this.btnEnviar.TabIndex = 20;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(112, 282);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(359, 20);
            this.txtEstado.TabIndex = 19;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(112, 246);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(359, 20);
            this.txtCidade.TabIndex = 18;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(112, 212);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(359, 20);
            this.txtBairro.TabIndex = 17;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(429, 177);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(42, 20);
            this.txtNumero.TabIndex = 16;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(112, 176);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(287, 20);
            this.txtRua.TabIndex = 15;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(112, 140);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(359, 20);
            this.txtCep.TabIndex = 14;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 104);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(359, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(112, 66);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(359, 20);
            this.txtTel.TabIndex = 12;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(112, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(359, 20);
            this.txtNome.TabIndex = 11;
            // 
            // labelNumRua
            // 
            this.labelNumRua.AutoSize = true;
            this.labelNumRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumRua.Location = new System.Drawing.Point(405, 177);
            this.labelNumRua.Name = "labelNumRua";
            this.labelNumRua.Size = new System.Drawing.Size(24, 18);
            this.labelNumRua.TabIndex = 10;
            this.labelNumRua.Text = "Nº";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(43, 284);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(55, 18);
            this.labelEstado.TabIndex = 9;
            this.labelEstado.Text = "Estado";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidade.Location = new System.Drawing.Point(43, 248);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(54, 18);
            this.labelCidade.TabIndex = 8;
            this.labelCidade.Text = "Cidade";
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBairro.Location = new System.Drawing.Point(43, 211);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(48, 18);
            this.labelBairro.TabIndex = 7;
            this.labelBairro.Text = "Bairro";
            // 
            // labelRua
            // 
            this.labelRua.AutoSize = true;
            this.labelRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRua.Location = new System.Drawing.Point(43, 176);
            this.labelRua.Name = "labelRua";
            this.labelRua.Size = new System.Drawing.Size(35, 18);
            this.labelRua.TabIndex = 6;
            this.labelRua.Text = "Rua";
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCep.Location = new System.Drawing.Point(43, 140);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(39, 18);
            this.labelCep.TabIndex = 5;
            this.labelCep.Text = "CEP";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(43, 104);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 18);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(43, 68);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(65, 18);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Telefone";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(43, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 18);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 534);
            this.Controls.Add(this.formContact);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formContact.ResumeLayout(false);
            this.formContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox formContact;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelRua;
        private System.Windows.Forms.Label labelCep;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelNumRua;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Label labelBairro;
    }
}

