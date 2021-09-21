
namespace Treinamento
{
    partial class Form6
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
            this.cb_transp = new System.Windows.Forms.ComboBox();
            this.btn_selecionado = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_resetar = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_transp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_transp
            // 
            this.cb_transp.FormattingEnabled = true;
            this.cb_transp.Items.AddRange(new object[] {
            "Carro",
            "Aviao",
            "Navio",
            "Onibus",
            "Trem"});
            this.cb_transp.Location = new System.Drawing.Point(12, 12);
            this.cb_transp.Name = "cb_transp";
            this.cb_transp.Size = new System.Drawing.Size(252, 21);
            this.cb_transp.TabIndex = 0;
            this.cb_transp.SelectedIndexChanged += new System.EventHandler(this.cb_transp_SelectedIndexChanged);
            // 
            // btn_selecionado
            // 
            this.btn_selecionado.Location = new System.Drawing.Point(271, 12);
            this.btn_selecionado.Name = "btn_selecionado";
            this.btn_selecionado.Size = new System.Drawing.Size(342, 20);
            this.btn_selecionado.TabIndex = 1;
            this.btn_selecionado.Text = "Selecionado";
            this.btn_selecionado.UseVisualStyleBackColor = true;
            this.btn_selecionado.Click += new System.EventHandler(this.btn_selecionado_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(271, 38);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(342, 20);
            this.btn_limpar.TabIndex = 2;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_resetar
            // 
            this.btn_resetar.Location = new System.Drawing.Point(271, 64);
            this.btn_resetar.Name = "btn_resetar";
            this.btn_resetar.Size = new System.Drawing.Size(342, 20);
            this.btn_resetar.TabIndex = 3;
            this.btn_resetar.Text = "Resetar";
            this.btn_resetar.UseVisualStyleBackColor = true;
            this.btn_resetar.Click += new System.EventHandler(this.btn_resetar_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(271, 202);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(342, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_transp
            // 
            this.tb_transp.Location = new System.Drawing.Point(271, 176);
            this.tb_transp.Name = "tb_transp";
            this.tb_transp.Size = new System.Drawing.Size(342, 20);
            this.tb_transp.TabIndex = 6;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_transp);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_resetar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_selecionado);
            this.Controls.Add(this.cb_transp);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_transp;
        private System.Windows.Forms.Button btn_selecionado;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_resetar;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_transp;
    }
}