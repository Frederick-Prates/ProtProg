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
            this.Lb_ParRes = new System.Windows.Forms.Label();
            this.Lb_EndeRes = new System.Windows.Forms.Label();
            this.Lb_DispRes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_Disp = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cb_COM
            // 
            this.Cb_COM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_COM.FormattingEnabled = true;
            this.Cb_COM.Location = new System.Drawing.Point(8, 32);
            this.Cb_COM.Name = "Cb_COM";
            this.Cb_COM.Size = new System.Drawing.Size(130, 21);
            this.Cb_COM.TabIndex = 0;
            // 
            // Cb_BaudRate
            // 
            this.Cb_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_BaudRate.FormattingEnabled = true;
            this.Cb_BaudRate.Location = new System.Drawing.Point(195, 32);
            this.Cb_BaudRate.Name = "Cb_BaudRate";
            this.Cb_BaudRate.Size = new System.Drawing.Size(130, 21);
            this.Cb_BaudRate.TabIndex = 1;
            // 
            // Bt_Conectar
            // 
            this.Bt_Conectar.Location = new System.Drawing.Point(203, 300);
            this.Bt_Conectar.Name = "Bt_Conectar";
            this.Bt_Conectar.Size = new System.Drawing.Size(130, 66);
            this.Bt_Conectar.TabIndex = 2;
            this.Bt_Conectar.Text = "Conectar";
            this.Bt_Conectar.UseVisualStyleBackColor = true;
            this.Bt_Conectar.Click += new System.EventHandler(this.Bt_Conectar_Click);
            // 
            // Bt_Cancelar
            // 
            this.Bt_Cancelar.Location = new System.Drawing.Point(16, 300);
            this.Bt_Cancelar.Name = "Bt_Cancelar";
            this.Bt_Cancelar.Size = new System.Drawing.Size(130, 66);
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
            this.label1.Location = new System.Drawing.Point(198, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Baud Rate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bt_Atualizar);
            this.groupBox1.Controls.Add(this.lb_COM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cb_COM);
            this.groupBox1.Controls.Add(this.Cb_BaudRate);
            this.groupBox1.Location = new System.Drawing.Point(8, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 133);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial";
            // 
            // Bt_Atualizar
            // 
            this.Bt_Atualizar.Location = new System.Drawing.Point(8, 59);
            this.Bt_Atualizar.Name = "Bt_Atualizar";
            this.Bt_Atualizar.Size = new System.Drawing.Size(317, 66);
            this.Bt_Atualizar.TabIndex = 8;
            this.Bt_Atualizar.Text = "Atualizar";
            this.Bt_Atualizar.UseVisualStyleBackColor = true;
            this.Bt_Atualizar.Click += new System.EventHandler(this.Bt_Atualizar_Click);
            // 
            // Bt_Dialog
            // 
            this.Bt_Dialog.Location = new System.Drawing.Point(195, 38);
            this.Bt_Dialog.Name = "Bt_Dialog";
            this.Bt_Dialog.Size = new System.Drawing.Size(130, 66);
            this.Bt_Dialog.TabIndex = 7;
            this.Bt_Dialog.Text = "Localizar";
            this.Bt_Dialog.UseVisualStyleBackColor = true;
            this.Bt_Dialog.Click += new System.EventHandler(this.Bt_Dialog_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lb_ParRes);
            this.groupBox2.Controls.Add(this.Lb_EndeRes);
            this.groupBox2.Controls.Add(this.Lb_DispRes);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Lb_Disp);
            this.groupBox2.Controls.Add(this.Bt_Dialog);
            this.groupBox2.Location = new System.Drawing.Point(8, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 135);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bluetooth";
            // 
            // Lb_ParRes
            // 
            this.Lb_ParRes.AutoSize = true;
            this.Lb_ParRes.Location = new System.Drawing.Point(63, 69);
            this.Lb_ParRes.Name = "Lb_ParRes";
            this.Lb_ParRes.Size = new System.Drawing.Size(0, 13);
            this.Lb_ParRes.TabIndex = 15;
            // 
            // Lb_EndeRes
            // 
            this.Lb_EndeRes.AutoSize = true;
            this.Lb_EndeRes.Location = new System.Drawing.Point(63, 51);
            this.Lb_EndeRes.Name = "Lb_EndeRes";
            this.Lb_EndeRes.Size = new System.Drawing.Size(0, 13);
            this.Lb_EndeRes.TabIndex = 13;
            // 
            // Lb_DispRes
            // 
            this.Lb_DispRes.AutoSize = true;
            this.Lb_DispRes.Location = new System.Drawing.Point(63, 33);
            this.Lb_DispRes.Name = "Lb_DispRes";
            this.Lb_DispRes.Size = new System.Drawing.Size(0, 13);
            this.Lb_DispRes.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pareado: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Endereço:";
            // 
            // Lb_Disp
            // 
            this.Lb_Disp.AutoSize = true;
            this.Lb_Disp.Location = new System.Drawing.Point(2, 32);
            this.Lb_Disp.Name = "Lb_Disp";
            this.Lb_Disp.Size = new System.Drawing.Size(61, 13);
            this.Lb_Disp.TabIndex = 8;
            this.Lb_Disp.Text = "Dispositivo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.Bt_Conectar);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.Bt_Cancelar);
            this.groupBox3.Location = new System.Drawing.Point(4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 372);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configurar";
            // 
            // CfgBluetooth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(362, 379);
            this.Controls.Add(this.groupBox3);
            this.Name = "CfgBluetooth";
            this.Text = "CfgBluetooth";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Bt_Conectar;
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
    }
}