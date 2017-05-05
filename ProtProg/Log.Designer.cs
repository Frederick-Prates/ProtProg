namespace ProtProg
{
    partial class Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            this.Bt_ComecarLog = new System.Windows.Forms.Button();
            this.Bt_CancelarLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_LogAtual = new System.Windows.Forms.Label();
            this.Bt_Dir = new System.Windows.Forms.Button();
            this.Tb_Arquivos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Bt_ComecarLog
            // 
            this.Bt_ComecarLog.Location = new System.Drawing.Point(241, 266);
            this.Bt_ComecarLog.Name = "Bt_ComecarLog";
            this.Bt_ComecarLog.Size = new System.Drawing.Size(112, 56);
            this.Bt_ComecarLog.TabIndex = 1;
            this.Bt_ComecarLog.Text = "Novo";
            this.Bt_ComecarLog.UseVisualStyleBackColor = true;
            this.Bt_ComecarLog.Click += new System.EventHandler(this.Bt_ComecarLog_Click);
            // 
            // Bt_CancelarLog
            // 
            this.Bt_CancelarLog.Location = new System.Drawing.Point(5, 266);
            this.Bt_CancelarLog.Name = "Bt_CancelarLog";
            this.Bt_CancelarLog.Size = new System.Drawing.Size(112, 56);
            this.Bt_CancelarLog.TabIndex = 2;
            this.Bt_CancelarLog.Text = "Cancelar";
            this.Bt_CancelarLog.UseVisualStyleBackColor = true;
            this.Bt_CancelarLog.Click += new System.EventHandler(this.Bt_CancelarLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Atual: ";
            // 
            // Lb_LogAtual
            // 
            this.Lb_LogAtual.AutoSize = true;
            this.Lb_LogAtual.Location = new System.Drawing.Point(43, 23);
            this.Lb_LogAtual.Name = "Lb_LogAtual";
            this.Lb_LogAtual.Size = new System.Drawing.Size(0, 13);
            this.Lb_LogAtual.TabIndex = 4;
            // 
            // Bt_Dir
            // 
            this.Bt_Dir.Location = new System.Drawing.Point(123, 266);
            this.Bt_Dir.Name = "Bt_Dir";
            this.Bt_Dir.Size = new System.Drawing.Size(112, 56);
            this.Bt_Dir.TabIndex = 5;
            this.Bt_Dir.Text = "Abrir Diretorio";
            this.Bt_Dir.UseVisualStyleBackColor = true;
            this.Bt_Dir.Click += new System.EventHandler(this.Bt_Dir_Click);
            // 
            // Tb_Arquivos
            // 
            this.Tb_Arquivos.Location = new System.Drawing.Point(5, 39);
            this.Tb_Arquivos.Name = "Tb_Arquivos";
            this.Tb_Arquivos.ReadOnly = true;
            this.Tb_Arquivos.Size = new System.Drawing.Size(348, 221);
            this.Tb_Arquivos.TabIndex = 6;
            this.Tb_Arquivos.Text = "";
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(359, 326);
            this.Controls.Add(this.Tb_Arquivos);
            this.Controls.Add(this.Bt_Dir);
            this.Controls.Add(this.Lb_LogAtual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bt_CancelarLog);
            this.Controls.Add(this.Bt_ComecarLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Log";
            this.Text = "Log de Ações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button Bt_ComecarLog;
        public System.Windows.Forms.Button Bt_CancelarLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_LogAtual;
        public System.Windows.Forms.Button Bt_Dir;
        private System.Windows.Forms.RichTextBox Tb_Arquivos;
    }
}