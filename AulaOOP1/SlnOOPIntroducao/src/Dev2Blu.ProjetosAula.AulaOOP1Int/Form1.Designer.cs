namespace Dev2Blu.ProjetosAula.AulaOOP1Int
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
            this.CadastroDeFuncionarios = new System.Windows.Forms.GroupBox();
            this.Status = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CadastroDeFuncionarios.SuspendLayout();
            this.Status.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CadastroDeFuncionarios
            // 
            this.CadastroDeFuncionarios.Controls.Add(this.label3);
            this.CadastroDeFuncionarios.Controls.Add(this.label2);
            this.CadastroDeFuncionarios.Controls.Add(this.label1);
            this.CadastroDeFuncionarios.Location = new System.Drawing.Point(20, 14);
            this.CadastroDeFuncionarios.Name = "CadastroDeFuncionarios";
            this.CadastroDeFuncionarios.Size = new System.Drawing.Size(478, 368);
            this.CadastroDeFuncionarios.TabIndex = 0;
            this.CadastroDeFuncionarios.TabStop = false;
            this.CadastroDeFuncionarios.Text = "Cadastro de Funcionários";
            this.CadastroDeFuncionarios.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Status
            // 
            this.Status.Controls.Add(this.groupBox4);
            this.Status.Location = new System.Drawing.Point(518, 14);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(218, 239);
            this.Status.TabIndex = 1;
            this.Status.TabStop = false;
            this.Status.Text = "Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnLimpar);
            this.groupBox3.Controls.Add(this.btnSalvar);
            this.groupBox3.Location = new System.Drawing.Point(518, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 115);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(13, 18);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(193, 33);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(16, 62);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(189, 33);
            this.BtnLimpar.TabIndex = 1;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(28, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(164, 180);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calculando funcionários...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.CadastroDeFuncionarios);
            this.Name = "Form1";
            this.Text = "Aula OOP 1 - Sistema de Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CadastroDeFuncionarios.ResumeLayout(false);
            this.CadastroDeFuncionarios.PerformLayout();
            this.Status.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CadastroDeFuncionarios;
        private System.Windows.Forms.GroupBox Status;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button btnSalvar;
    }
}

