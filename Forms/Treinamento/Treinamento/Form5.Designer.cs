
namespace Treinamento
{
    partial class Form5
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
            this.clb_transp = new System.Windows.Forms.CheckedListBox();
            this.btn_selecionar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_resetar = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_add = new System.Windows.Forms.TextBox();
            this.lb_add = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_transp
            // 
            this.clb_transp.FormattingEnabled = true;
            this.clb_transp.Items.AddRange(new object[] {
            "Carro",
            "Aviao",
            "Navio",
            "Onibus",
            "Trem"});
            this.clb_transp.Location = new System.Drawing.Point(13, 13);
            this.clb_transp.Name = "clb_transp";
            this.clb_transp.Size = new System.Drawing.Size(120, 274);
            this.clb_transp.TabIndex = 0;
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.Location = new System.Drawing.Point(139, 13);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(382, 23);
            this.btn_selecionar.TabIndex = 1;
            this.btn_selecionar.Text = "Selecionados";
            this.btn_selecionar.UseVisualStyleBackColor = true;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(139, 42);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(382, 23);
            this.btn_limpar.TabIndex = 2;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_resetar
            // 
            this.btn_resetar.Location = new System.Drawing.Point(139, 71);
            this.btn_resetar.Name = "btn_resetar";
            this.btn_resetar.Size = new System.Drawing.Size(382, 23);
            this.btn_resetar.TabIndex = 3;
            this.btn_resetar.Text = "Resetar";
            this.btn_resetar.UseVisualStyleBackColor = true;
            this.btn_resetar.Click += new System.EventHandler(this.btn_resetar_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(139, 264);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(382, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_add
            // 
            this.tb_add.Location = new System.Drawing.Point(139, 238);
            this.tb_add.Name = "tb_add";
            this.tb_add.Size = new System.Drawing.Size(382, 20);
            this.tb_add.TabIndex = 5;
            // 
            // lb_add
            // 
            this.lb_add.AutoSize = true;
            this.lb_add.Location = new System.Drawing.Point(136, 222);
            this.lb_add.Name = "lb_add";
            this.lb_add.Size = new System.Drawing.Size(128, 13);
            this.lb_add.TabIndex = 6;
            this.lb_add.Text = "Digite um novo transporte";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_add);
            this.Controls.Add(this.tb_add);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_resetar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_selecionar);
            this.Controls.Add(this.clb_transp);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transp;
        private System.Windows.Forms.Button btn_selecionar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_resetar;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_add;
        private System.Windows.Forms.Label lb_add;
    }
}