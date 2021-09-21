
namespace Treinamento
{
    partial class Form7
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
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.btn_pegar = new System.Windows.Forms.Button();
            this.tb_completo = new System.Windows.Forms.TextBox();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_hoje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_time
            // 
            this.dtp_time.Location = new System.Drawing.Point(12, 8);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.Size = new System.Drawing.Size(313, 20);
            this.dtp_time.TabIndex = 0;
            // 
            // btn_pegar
            // 
            this.btn_pegar.Location = new System.Drawing.Point(331, 8);
            this.btn_pegar.Name = "btn_pegar";
            this.btn_pegar.Size = new System.Drawing.Size(220, 23);
            this.btn_pegar.TabIndex = 1;
            this.btn_pegar.Text = "Pegar";
            this.btn_pegar.UseVisualStyleBackColor = true;
            this.btn_pegar.Click += new System.EventHandler(this.btn_pegar_Click);
            // 
            // tb_completo
            // 
            this.tb_completo.Location = new System.Drawing.Point(12, 34);
            this.tb_completo.Name = "tb_completo";
            this.tb_completo.Size = new System.Drawing.Size(313, 20);
            this.tb_completo.TabIndex = 6;
            // 
            // tb_dia
            // 
            this.tb_dia.Location = new System.Drawing.Point(13, 61);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(100, 20);
            this.tb_dia.TabIndex = 7;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(225, 61);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(100, 20);
            this.tb_ano.TabIndex = 8;
            // 
            // tb_mes
            // 
            this.tb_mes.Location = new System.Drawing.Point(119, 60);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(100, 20);
            this.tb_mes.TabIndex = 9;
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(331, 61);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(220, 23);
            this.btn_set.TabIndex = 10;
            this.btn_set.Text = "Set";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_hoje
            // 
            this.btn_hoje.Location = new System.Drawing.Point(403, 90);
            this.btn_hoje.Name = "btn_hoje";
            this.btn_hoje.Size = new System.Drawing.Size(75, 23);
            this.btn_hoje.TabIndex = 11;
            this.btn_hoje.Text = "Hoje";
            this.btn_hoje.UseVisualStyleBackColor = true;
            this.btn_hoje.Click += new System.EventHandler(this.btn_hoje_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_hoje);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.tb_completo);
            this.Controls.Add(this.btn_pegar);
            this.Controls.Add(this.dtp_time);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_time;
        private System.Windows.Forms.Button btn_pegar;
        private System.Windows.Forms.TextBox tb_completo;
        private System.Windows.Forms.TextBox tb_dia;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.TextBox tb_mes;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_hoje;
    }
}