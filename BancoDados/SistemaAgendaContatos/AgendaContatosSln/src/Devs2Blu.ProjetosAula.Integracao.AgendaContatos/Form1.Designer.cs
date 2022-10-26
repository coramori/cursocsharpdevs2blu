namespace Devs2Blu.ProjetosAula.Integracao.AgendaContatos
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
            this.gpRegister = new System.Windows.Forms.GroupBox();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbDeco1 = new System.Windows.Forms.GroupBox();
            this.gridContacts = new System.Windows.Forms.DataGridView();
            this.gbAptm = new System.Windows.Forms.GroupBox();
            this.btClearAptm = new System.Windows.Forms.Button();
            this.btAddAptm = new System.Windows.Forms.Button();
            this.dtpFinDate = new System.Windows.Forms.DateTimePicker();
            this.lbFinDate = new System.Windows.Forms.Label();
            this.lbIniDate = new System.Windows.Forms.Label();
            this.dtpIniDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.lbState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.lbDistrict = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lbNumber = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lbStreet = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.gpRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContacts)).BeginInit();
            this.gbAptm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpRegister
            // 
            this.gpRegister.BackColor = System.Drawing.Color.White;
            this.gpRegister.Controls.Add(this.mskPhone);
            this.gpRegister.Controls.Add(this.groupBox1);
            this.gpRegister.Controls.Add(this.btClear);
            this.gpRegister.Controls.Add(this.btDelete);
            this.gpRegister.Controls.Add(this.btChange);
            this.gpRegister.Controls.Add(this.groupBox2);
            this.gpRegister.Controls.Add(this.gbDeco1);
            this.gpRegister.Controls.Add(this.gridContacts);
            this.gpRegister.Controls.Add(this.gbAptm);
            this.gpRegister.Controls.Add(this.btSave);
            this.gpRegister.Controls.Add(this.cbState);
            this.gpRegister.Controls.Add(this.lbState);
            this.gpRegister.Controls.Add(this.txtCity);
            this.gpRegister.Controls.Add(this.lbCity);
            this.gpRegister.Controls.Add(this.txtDistrict);
            this.gpRegister.Controls.Add(this.lbDistrict);
            this.gpRegister.Controls.Add(this.txtNumber);
            this.gpRegister.Controls.Add(this.lbNumber);
            this.gpRegister.Controls.Add(this.txtStreet);
            this.gpRegister.Controls.Add(this.lbStreet);
            this.gpRegister.Controls.Add(this.txtEmail);
            this.gpRegister.Controls.Add(this.lbEmail);
            this.gpRegister.Controls.Add(this.lbPhone);
            this.gpRegister.Controls.Add(this.txtName);
            this.gpRegister.Controls.Add(this.lbName);
            this.gpRegister.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpRegister.Location = new System.Drawing.Point(12, 12);
            this.gpRegister.Name = "gpRegister";
            this.gpRegister.Size = new System.Drawing.Size(872, 686);
            this.gpRegister.TabIndex = 0;
            this.gpRegister.TabStop = false;
            this.gpRegister.Text = "Cadastro de Contatos";
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(71, 80);
            this.mskPhone.Mask = "(00) 0000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(86, 21);
            this.mskPhone.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(218)))), ((int)(((byte)(247)))));
            this.groupBox1.Location = new System.Drawing.Point(19, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 10);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(218)))), ((int)(((byte)(247)))));
            this.btClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClear.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btClear.FlatAppearance.BorderSize = 0;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(238, 227);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(86, 41);
            this.btClear.TabIndex = 16;
            this.btClear.Text = "Limpar";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(218)))), ((int)(((byte)(247)))));
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btDelete.FlatAppearance.BorderSize = 0;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(765, 618);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(86, 41);
            this.btDelete.TabIndex = 24;
            this.btDelete.Text = "Excluir";
            this.btDelete.UseVisualStyleBackColor = false;
            // 
            // btChange
            // 
            this.btChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(218)))), ((int)(((byte)(247)))));
            this.btChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btChange.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btChange.FlatAppearance.BorderSize = 0;
            this.btChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChange.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChange.Location = new System.Drawing.Point(662, 618);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(86, 41);
            this.btChange.TabIndex = 23;
            this.btChange.Text = "Alterar";
            this.btChange.UseVisualStyleBackColor = false;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(218)))), ((int)(((byte)(247)))));
            this.groupBox2.Location = new System.Drawing.Point(19, 587);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(832, 10);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // gbDeco1
            // 
            this.gbDeco1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(218)))), ((int)(((byte)(247)))));
            this.gbDeco1.Location = new System.Drawing.Point(19, 293);
            this.gbDeco1.Name = "gbDeco1";
            this.gbDeco1.Size = new System.Drawing.Size(832, 10);
            this.gbDeco1.TabIndex = 18;
            this.gbDeco1.TabStop = false;
            // 
            // gridContacts
            // 
            this.gridContacts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridContacts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContacts.Location = new System.Drawing.Point(19, 309);
            this.gridContacts.Name = "gridContacts";
            this.gridContacts.Size = new System.Drawing.Size(832, 272);
            this.gridContacts.TabIndex = 17;
            this.gridContacts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContacts_DoubleClick);
            // 
            // gbAptm
            // 
            this.gbAptm.BackColor = System.Drawing.Color.White;
            this.gbAptm.Controls.Add(this.btClearAptm);
            this.gbAptm.Controls.Add(this.btAddAptm);
            this.gbAptm.Controls.Add(this.dtpFinDate);
            this.gbAptm.Controls.Add(this.lbFinDate);
            this.gbAptm.Controls.Add(this.lbIniDate);
            this.gbAptm.Controls.Add(this.dtpIniDate);
            this.gbAptm.Controls.Add(this.txtDescription);
            this.gbAptm.Controls.Add(this.lbDescription);
            this.gbAptm.Controls.Add(this.txtTitle);
            this.gbAptm.Controls.Add(this.lbTitle);
            this.gbAptm.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAptm.Location = new System.Drawing.Point(446, 19);
            this.gbAptm.Name = "gbAptm";
            this.gbAptm.Size = new System.Drawing.Size(405, 265);
            this.gbAptm.TabIndex = 1;
            this.gbAptm.TabStop = false;
            this.gbAptm.Text = "Adicionar Compromisso";
            // 
            // btClearAptm
            // 
            this.btClearAptm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(218)))), ((int)(((byte)(247)))));
            this.btClearAptm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClearAptm.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btClearAptm.FlatAppearance.BorderSize = 0;
            this.btClearAptm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClearAptm.Location = new System.Drawing.Point(216, 208);
            this.btClearAptm.Name = "btClearAptm";
            this.btClearAptm.Size = new System.Drawing.Size(86, 41);
            this.btClearAptm.TabIndex = 17;
            this.btClearAptm.Text = "Limpar";
            this.btClearAptm.UseVisualStyleBackColor = false;
            // 
            // btAddAptm
            // 
            this.btAddAptm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(218)))), ((int)(((byte)(247)))));
            this.btAddAptm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddAptm.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btAddAptm.FlatAppearance.BorderSize = 0;
            this.btAddAptm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddAptm.Location = new System.Drawing.Point(110, 208);
            this.btAddAptm.Name = "btAddAptm";
            this.btAddAptm.Size = new System.Drawing.Size(86, 41);
            this.btAddAptm.TabIndex = 17;
            this.btAddAptm.Text = "Adicionar";
            this.btAddAptm.UseVisualStyleBackColor = false;
            // 
            // dtpFinDate
            // 
            this.dtpFinDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFinDate.Location = new System.Drawing.Point(79, 167);
            this.dtpFinDate.Name = "dtpFinDate";
            this.dtpFinDate.Size = new System.Drawing.Size(303, 22);
            this.dtpFinDate.TabIndex = 22;
            // 
            // lbFinDate
            // 
            this.lbFinDate.AutoSize = true;
            this.lbFinDate.Location = new System.Drawing.Point(13, 171);
            this.lbFinDate.Name = "lbFinDate";
            this.lbFinDate.Size = new System.Drawing.Size(60, 14);
            this.lbFinDate.TabIndex = 21;
            this.lbFinDate.Text = "Data Final";
            // 
            // lbIniDate
            // 
            this.lbIniDate.AutoSize = true;
            this.lbIniDate.Location = new System.Drawing.Point(8, 137);
            this.lbIniDate.Name = "lbIniDate";
            this.lbIniDate.Size = new System.Drawing.Size(65, 14);
            this.lbIniDate.TabIndex = 20;
            this.lbIniDate.Text = "Data Inicial";
            // 
            // dtpIniDate
            // 
            this.dtpIniDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpIniDate.Location = new System.Drawing.Point(79, 131);
            this.dtpIniDate.Name = "dtpIniDate";
            this.dtpIniDate.Size = new System.Drawing.Size(303, 22);
            this.dtpIniDate.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(79, 61);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(303, 52);
            this.txtDescription.TabIndex = 19;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(14, 64);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(59, 14);
            this.lbDescription.TabIndex = 18;
            this.lbDescription.Text = "Descrição";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(79, 21);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(303, 22);
            this.txtTitle.TabIndex = 17;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(35, 26);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(38, 14);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Título";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(218)))), ((int)(((byte)(247)))));
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.Black;
            this.btSave.Location = new System.Drawing.Point(130, 227);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(86, 41);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Salvar";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbState
            // 
            this.cbState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbState.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(355, 186);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(66, 22);
            this.cbState.TabIndex = 15;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.Location = new System.Drawing.Point(330, 190);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(22, 14);
            this.lbState.TabIndex = 14;
            this.lbState.Text = "UF";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(71, 187);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(253, 22);
            this.txtCity.TabIndex = 13;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.Location = new System.Drawing.Point(21, 190);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(44, 14);
            this.lbCity.TabIndex = 12;
            this.lbCity.Text = "Cidade";
            // 
            // txtDistrict
            // 
            this.txtDistrict.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistrict.Location = new System.Drawing.Point(71, 153);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(253, 22);
            this.txtDistrict.TabIndex = 11;
            // 
            // lbDistrict
            // 
            this.lbDistrict.AutoSize = true;
            this.lbDistrict.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistrict.Location = new System.Drawing.Point(27, 156);
            this.lbDistrict.Name = "lbDistrict";
            this.lbDistrict.Size = new System.Drawing.Size(38, 14);
            this.lbDistrict.TabIndex = 10;
            this.lbDistrict.Text = "Bairro";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(355, 153);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(66, 22);
            this.txtNumber.TabIndex = 9;
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.Location = new System.Drawing.Point(330, 156);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(21, 14);
            this.lbNumber.TabIndex = 8;
            this.lbNumber.Text = "Nº";
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(71, 115);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(350, 22);
            this.txtStreet.TabIndex = 7;
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStreet.Location = new System.Drawing.Point(37, 118);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(28, 14);
            this.lbStreet.TabIndex = 6;
            this.lbStreet.Text = "Rua";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(206, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(215, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(163, 83);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(37, 14);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(13, 83);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(52, 14);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "Telefone";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(71, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(350, 22);
            this.txtName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(25, 45);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(40, 14);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(897, 710);
            this.Controls.Add(this.gpRegister);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpRegister.ResumeLayout(false);
            this.gpRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContacts)).EndInit();
            this.gbAptm.ResumeLayout(false);
            this.gbAptm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpRegister;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label lbDistrict;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lbStreet;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.GroupBox gbAptm;
        private System.Windows.Forms.Label lbFinDate;
        private System.Windows.Forms.Label lbIniDate;
        private System.Windows.Forms.DateTimePicker dtpIniDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btClearAptm;
        private System.Windows.Forms.Button btAddAptm;
        private System.Windows.Forms.DateTimePicker dtpFinDate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbDeco1;
        private System.Windows.Forms.DataGridView gridContacts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskPhone;
    }
}

