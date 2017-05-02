namespace ProtProg
{
    partial class CfgBluetooth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CfgBluetooth));
            this.Cb_COM = new System.Windows.Forms.ComboBox();
            this.Cb_BaudRate = new System.Windows.Forms.ComboBox();
            this.Bt_Conectar = new System.Windows.Forms.Button();
            this.Bt_Cancelar = new System.Windows.Forms.Button();
            this.lb_COM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bt_Atualizar = new System.Windows.Forms.Button();
            this.Bt_Dialog = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Bt_AtualizarStatusBT = new System.Windows.Forms.Button();
            this.Lb_StatusBT1 = new System.Windows.Forms.Label();
            this.Lb_StatusBT = new System.Windows.Forms.Label();
            this.Lb_ClasseBT1 = new System.Windows.Forms.Label();
            this.Lb_EndBT1 = new System.Windows.Forms.Label();
            this.Lb_NomeBT1 = new System.Windows.Forms.Label();
            this.Lb_ModoBT1 = new System.Windows.Forms.Label();
            this.Lb_ClasseBT = new System.Windows.Forms.Label();
            this.Lb_EndBT = new System.Windows.Forms.Label();
            this.Lb_NomeBT = new System.Windows.Forms.Label();
            this.Lb_ModoBT = new System.Windows.Forms.Label();
            this.Lb_ParRes = new System.Windows.Forms.Label();
            this.Lb_EndeRes = new System.Windows.Forms.Label();
            this.Lb_DispRes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_Disp = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Lb_TipoRes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cb_COM
            // 
            this.Cb_COM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_COM.FormattingEnabled = true;
            this.Cb_COM.Location = new System.Drawing.Point(8, 32);
            this.Cb_COM.Name = "Cb_COM";
            this.Cb_COM.Size = new System.Drawing.Size(103, 21);
            this.Cb_COM.TabIndex = 0;
            // 
            // Cb_BaudRate
            // 
            this.Cb_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_BaudRate.FormattingEnabled = true;
            this.Cb_BaudRate.Location = new System.Drawing.Point(117, 32);
            this.Cb_BaudRate.Name = "Cb_BaudRate";
            this.Cb_BaudRate.Size = new System.Drawing.Size(103, 21);
            this.Cb_BaudRate.TabIndex = 1;
            // 
            // Bt_Conectar
            // 
            this.Bt_Conectar.Location = new System.Drawing.Point(117, 60);
            this.Bt_Conectar.Name = "Bt_Conectar";
            this.Bt_Conectar.Size = new System.Drawing.Size(102, 57);
            this.Bt_Conectar.TabIndex = 2;
            this.Bt_Conectar.Text = "Conectar";
            this.Bt_Conectar.UseVisualStyleBackColor = true;
            this.Bt_Conectar.Click += new System.EventHandler(this.Bt_Conectar_Click);
            // 
            // Bt_Cancelar
            // 
            this.Bt_Cancelar.Location = new System.Drawing.Point(8, 251);
            this.Bt_Cancelar.Name = "Bt_Cancelar";
            this.Bt_Cancelar.Size = new System.Drawing.Size(406, 45);
            this.Bt_Cancelar.TabIndex = 3;
            this.Bt_Cancelar.Text = "Cancelar";
            this.Bt_Cancelar.UseVisualStyleBackColor = true;
            this.Bt_Cancelar.Click += new System.EventHandler(this.Bt_Cancelar_Click);
            // 
            // lb_COM
            // 
            this.lb_COM.AutoSize = true;
            this.lb_COM.Location = new System.Drawing.Point(11, 16);
            this.lb_COM.Name = "lb_COM";
            this.lb_COM.Size = new System.Drawing.Size(64, 13);
            this.lb_COM.TabIndex = 4;
            this.lb_COM.Text = "Portas COM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Baud Rate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bt_Atualizar);
            this.groupBox1.Controls.Add(this.lb_COM);
            this.groupBox1.Controls.Add(this.Bt_Conectar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cb_COM);
            this.groupBox1.Controls.Add(this.Cb_BaudRate);
            this.groupBox1.Location = new System.Drawing.Point(192, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial";
            // 
            // Bt_Atualizar
            // 
            this.Bt_Atualizar.Location = new System.Drawing.Point(8, 59);
            this.Bt_Atualizar.Name = "Bt_Atualizar";
            this.Bt_Atualizar.Size = new System.Drawing.Size(103, 58);
            this.Bt_Atualizar.TabIndex = 8;
            this.Bt_Atualizar.Text = "Atualizar";
            this.Bt_Atualizar.UseVisualStyleBackColor = true;
            this.Bt_Atualizar.Click += new System.EventHandler(this.Bt_Atualizar_Click);
            // 
            // Bt_Dialog
            // 
            this.Bt_Dialog.Location = new System.Drawing.Point(302, 19);
            this.Bt_Dialog.Name = "Bt_Dialog";
            this.Bt_Dialog.Size = new System.Drawing.Size(102, 66);
            this.Bt_Dialog.TabIndex = 7;
            this.Bt_Dialog.Text = "Localizar Dispositivo";
            this.Bt_Dialog.UseVisualStyleBackColor = true;
            this.Bt_Dialog.Click += new System.EventHandler(this.Bt_Dialog_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Bt_AtualizarStatusBT);
            this.groupBox2.Controls.Add(this.Lb_StatusBT1);
            this.groupBox2.Controls.Add(this.Lb_StatusBT);
            this.groupBox2.Controls.Add(this.Lb_ClasseBT1);
            this.groupBox2.Controls.Add(this.Lb_EndBT1);
            this.groupBox2.Controls.Add(this.Lb_NomeBT1);
            this.groupBox2.Controls.Add(this.Lb_ModoBT1);
            this.groupBox2.Controls.Add(this.Lb_ClasseBT);
            this.groupBox2.Controls.Add(this.Lb_EndBT);
            this.groupBox2.Controls.Add(this.Lb_NomeBT);
            this.groupBox2.Controls.Add(this.Bt_Dialog);
            this.groupBox2.Controls.Add(this.Lb_ModoBT);
            this.groupBox2.Location = new System.Drawing.Point(8, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 95);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bluetooth";
            // 
            // Bt_AtualizarStatusBT
            // 
            this.Bt_AtualizarStatusBT.Location = new System.Drawing.Point(198, 19);
            this.Bt_AtualizarStatusBT.Name = "Bt_AtualizarStatusBT";
            this.Bt_AtualizarStatusBT.Size = new System.Drawing.Size(102, 66);
            this.Bt_AtualizarStatusBT.TabIndex = 26;
            this.Bt_AtualizarStatusBT.Text = "Atualizar Status";
            this.Bt_AtualizarStatusBT.UseVisualStyleBackColor = true;
            this.Bt_AtualizarStatusBT.Click += new System.EventHandler(this.Bt_AtualizarStatusBT_Click);
            // 
            // Lb_StatusBT1
            // 
            this.Lb_StatusBT1.AutoSize = true;
            this.Lb_StatusBT1.Location = new System.Drawing.Point(67, 20);
            this.Lb_StatusBT1.Name = "Lb_StatusBT1";
            this.Lb_StatusBT1.Size = new System.Drawing.Size(0, 13);
            this.Lb_StatusBT1.TabIndex = 25;
            // 
            // Lb_StatusBT
            // 
            this.Lb_StatusBT.AutoSize = true;
            this.Lb_StatusBT.Location = new System.Drawing.Point(11, 20);
            this.Lb_StatusBT.Name = "Lb_StatusBT";
            this.Lb_StatusBT.Size = new System.Drawing.Size(40, 13);
            this.Lb_StatusBT.TabIndex = 24;
            this.Lb_StatusBT.Text = "Status:";
            // 
            // Lb_ClasseBT1
            // 
            this.Lb_ClasseBT1.AutoSize = true;
            this.Lb_ClasseBT1.Location = new System.Drawing.Point(67, 73);
            this.Lb_ClasseBT1.Name = "Lb_ClasseBT1";
            this.Lb_ClasseBT1.Size = new System.Drawing.Size(0, 13);
            this.Lb_ClasseBT1.TabIndex = 23;
            // 
            // Lb_EndBT1
            // 
            this.Lb_EndBT1.AutoSize = true;
            this.Lb_EndBT1.Location = new System.Drawing.Point(67, 46);
            this.Lb_EndBT1.Name = "Lb_EndBT1";
            this.Lb_EndBT1.Size = new System.Drawing.Size(0, 13);
            this.Lb_EndBT1.TabIndex = 21;
            // 
            // Lb_NomeBT1
            // 
            this.Lb_NomeBT1.AutoSize = true;
            this.Lb_NomeBT1.Location = new System.Drawing.Point(67, 33);
            this.Lb_NomeBT1.Name = "Lb_NomeBT1";
            this.Lb_NomeBT1.Size = new System.Drawing.Size(0, 13);
            this.Lb_NomeBT1.TabIndex = 20;
            // 
            // Lb_ModoBT1
            // 
            this.Lb_ModoBT1.AutoSize = true;
            this.Lb_ModoBT1.Location = new System.Drawing.Point(67, 60);
            this.Lb_ModoBT1.Name = "Lb_ModoBT1";
            this.Lb_ModoBT1.Size = new System.Drawing.Size(0, 13);
            this.Lb_ModoBT1.TabIndex = 22;
            // 
            // Lb_ClasseBT
            // 
            this.Lb_ClasseBT.AutoSize = true;
            this.Lb_ClasseBT.Location = new System.Drawing.Point(11, 73);
            this.Lb_ClasseBT.Name = "Lb_ClasseBT";
            this.Lb_ClasseBT.Size = new System.Drawing.Size(44, 13);
            this.Lb_ClasseBT.TabIndex = 19;
            this.Lb_ClasseBT.Text = "Classe: ";
            // 
            // Lb_EndBT
            // 
            this.Lb_EndBT.AutoSize = true;
            this.Lb_EndBT.Location = new System.Drawing.Point(11, 46);
            this.Lb_EndBT.Name = "Lb_EndBT";
            this.Lb_EndBT.Size = new System.Drawing.Size(56, 13);
            this.Lb_EndBT.TabIndex = 17;
            this.Lb_EndBT.Text = "Endereço:";
            // 
            // Lb_NomeBT
            // 
            this.Lb_NomeBT.AutoSize = true;
            this.Lb_NomeBT.Location = new System.Drawing.Point(11, 33);
            this.Lb_NomeBT.Name = "Lb_NomeBT";
            this.Lb_NomeBT.Size = new System.Drawing.Size(38, 13);
            this.Lb_NomeBT.TabIndex = 16;
            this.Lb_NomeBT.Text = "Nome:";
            // 
            // Lb_ModoBT
            // 
            this.Lb_ModoBT.AutoSize = true;
            this.Lb_ModoBT.Location = new System.Drawing.Point(11, 60);
            this.Lb_ModoBT.Name = "Lb_ModoBT";
            this.Lb_ModoBT.Size = new System.Drawing.Size(40, 13);
            this.Lb_ModoBT.TabIndex = 18;
            this.Lb_ModoBT.Text = "Modo: ";
            // 
            // Lb_ParRes
            // 
            this.Lb_ParRes.AutoSize = true;
            this.Lb_ParRes.Location = new System.Drawing.Point(67, 68);
            this.Lb_ParRes.Name = "Lb_ParRes";
            this.Lb_ParRes.Size = new System.Drawing.Size(0, 13);
            this.Lb_ParRes.TabIndex = 15;
            // 
            // Lb_EndeRes
            // 
            this.Lb_EndeRes.AutoSize = true;
            this.Lb_EndeRes.Location = new System.Drawing.Point(67, 50);
            this.Lb_EndeRes.Name = "Lb_EndeRes";
            this.Lb_EndeRes.Size = new System.Drawing.Size(0, 13);
            this.Lb_EndeRes.TabIndex = 13;
            // 
            // Lb_DispRes
            // 
            this.Lb_DispRes.AutoSize = true;
            this.Lb_DispRes.Location = new System.Drawing.Point(67, 32);
            this.Lb_DispRes.Name = "Lb_DispRes";
            this.Lb_DispRes.Size = new System.Drawing.Size(0, 13);
            this.Lb_DispRes.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pareado: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Endereço:";
            // 
            // Lb_Disp
            // 
            this.Lb_Disp.AutoSize = true;
            this.Lb_Disp.Location = new System.Drawing.Point(6, 31);
            this.Lb_Disp.Name = "Lb_Disp";
            this.Lb_Disp.Size = new System.Drawing.Size(61, 13);
            this.Lb_Disp.TabIndex = 8;
            this.Lb_Disp.Text = "Dispositivo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.Bt_Cancelar);
            this.groupBox3.Location = new System.Drawing.Point(4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 302);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configurar";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Lb_TipoRes);
            this.groupBox4.Controls.Add(this.Lb_ParRes);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.Lb_EndeRes);
            this.groupBox4.Controls.Add(this.Lb_Disp);
            this.groupBox4.Controls.Add(this.Lb_DispRes);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(8, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 125);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informação do Dispositivo";
            // 
            // Lb_TipoRes
            // 
            this.Lb_TipoRes.AutoSize = true;
            this.Lb_TipoRes.Location = new System.Drawing.Point(46, 84);
            this.Lb_TipoRes.Name = "Lb_TipoRes";
            this.Lb_TipoRes.Size = new System.Drawing.Size(0, 13);
            this.Lb_TipoRes.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tipo: ";
            // 
            // CfgBluetooth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(430, 307);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CfgBluetooth";
            this.Text = "Configuração Bluetooth";
            this.Shown += new System.EventHandler(this.CfgBluetooth_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Bt_Cancelar;
        private System.Windows.Forms.Label lb_COM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bt_Dialog;
        private System.Windows.Forms.Button Bt_Atualizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Lb_Disp;
        private System.Windows.Forms.Label Lb_ParRes;
        private System.Windows.Forms.Label Lb_EndeRes;
        private System.Windows.Forms.Label Lb_DispRes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox Cb_COM;
        public System.Windows.Forms.ComboBox Cb_BaudRate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Lb_EndBT;
        private System.Windows.Forms.Label Lb_NomeBT;
        private System.Windows.Forms.Label Lb_ModoBT;
        private System.Windows.Forms.Label Lb_ClasseBT;
        private System.Windows.Forms.Label Lb_ClasseBT1;
        private System.Windows.Forms.Label Lb_EndBT1;
        private System.Windows.Forms.Label Lb_NomeBT1;
        private System.Windows.Forms.Label Lb_ModoBT1;
        private System.Windows.Forms.Label Lb_StatusBT1;
        private System.Windows.Forms.Label Lb_StatusBT;
        private System.Windows.Forms.Button Bt_AtualizarStatusBT;
        public System.Windows.Forms.Button Bt_Conectar;
        private System.Windows.Forms.Label Lb_TipoRes;
        private System.Windows.Forms.Label label5;
    }
}