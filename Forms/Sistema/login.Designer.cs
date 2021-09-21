
namespace Sistema
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
            this.pn_00 = new System.Windows.Forms.Panel();
            this.tlp_00 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.pn_01 = new System.Windows.Forms.Panel();
            this.pn_enter = new System.Windows.Forms.Panel();
            this.btn_enter = new System.Windows.Forms.Button();
            this.pn_exit = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.pn_00.SuspendLayout();
            this.tlp_00.SuspendLayout();
            this.pn_01.SuspendLayout();
            this.pn_enter.SuspendLayout();
            this.pn_exit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_00
            // 
            this.pn_00.BackColor = System.Drawing.SystemColors.Control;
            this.pn_00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_00.Controls.Add(this.tlp_00);
            this.pn_00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_00.Location = new System.Drawing.Point(0, 0);
            this.pn_00.Margin = new System.Windows.Forms.Padding(0);
            this.pn_00.Name = "pn_00";
            this.pn_00.Padding = new System.Windows.Forms.Padding(1);
            this.pn_00.Size = new System.Drawing.Size(285, 279);
            this.pn_00.TabIndex = 0;
            // 
            // tlp_00
            // 
            this.tlp_00.BackColor = System.Drawing.SystemColors.Control;
            this.tlp_00.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlp_00.ColumnCount = 1;
            this.tlp_00.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_00.Controls.Add(this.lb_welcome, 0, 0);
            this.tlp_00.Controls.Add(this.pn_01, 0, 1);
            this.tlp_00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_00.Location = new System.Drawing.Point(1, 1);
            this.tlp_00.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_00.Name = "tlp_00";
            this.tlp_00.RowCount = 2;
            this.tlp_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlp_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlp_00.Size = new System.Drawing.Size(281, 275);
            this.tlp_00.TabIndex = 0;
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.BackColor = System.Drawing.SystemColors.Control;
            this.lb_welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_welcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_welcome.Location = new System.Drawing.Point(2, 2);
            this.lb_welcome.Margin = new System.Windows.Forms.Padding(0);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(277, 94);
            this.lb_welcome.TabIndex = 0;
            this.lb_welcome.Text = "Bem vindo ao SGI. Digite seu usuário e senha para entrar.";
            this.lb_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_01
            // 
            this.pn_01.Controls.Add(this.pn_enter);
            this.pn_01.Controls.Add(this.pn_exit);
            this.pn_01.Controls.Add(this.tb_password);
            this.pn_01.Controls.Add(this.lb_password);
            this.pn_01.Controls.Add(this.tb_user);
            this.pn_01.Controls.Add(this.lb_user);
            this.pn_01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_01.Location = new System.Drawing.Point(5, 101);
            this.pn_01.Name = "pn_01";
            this.pn_01.Size = new System.Drawing.Size(271, 169);
            this.pn_01.TabIndex = 1;
            // 
            // pn_enter
            // 
            this.pn_enter.Controls.Add(this.btn_enter);
            this.pn_enter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_enter.Location = new System.Drawing.Point(0, 89);
            this.pn_enter.Margin = new System.Windows.Forms.Padding(0);
            this.pn_enter.Name = "pn_enter";
            this.pn_enter.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pn_enter.Size = new System.Drawing.Size(271, 40);
            this.pn_enter.TabIndex = 7;
            // 
            // btn_enter
            // 
            this.btn_enter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_enter.Location = new System.Drawing.Point(0, 0);
            this.btn_enter.Margin = new System.Windows.Forms.Padding(0);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(271, 37);
            this.btn_enter.TabIndex = 5;
            this.btn_enter.Text = "Entrar";
            this.btn_enter.UseVisualStyleBackColor = true;
            // 
            // pn_exit
            // 
            this.pn_exit.Controls.Add(this.btn_exit);
            this.pn_exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_exit.Location = new System.Drawing.Point(0, 129);
            this.pn_exit.Margin = new System.Windows.Forms.Padding(0);
            this.pn_exit.Name = "pn_exit";
            this.pn_exit.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.pn_exit.Size = new System.Drawing.Size(271, 40);
            this.pn_exit.TabIndex = 6;
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_exit.Location = new System.Drawing.Point(0, 3);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(271, 37);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Sair";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // tb_password
            // 
            this.tb_password.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_password.Location = new System.Drawing.Point(0, 53);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(271, 23);
            this.tb_password.TabIndex = 3;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_password.Location = new System.Drawing.Point(0, 38);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(39, 15);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Senha";
            // 
            // tb_user
            // 
            this.tb_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_user.Location = new System.Drawing.Point(0, 15);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(271, 23);
            this.tb_user.TabIndex = 1;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_user.Location = new System.Drawing.Point(0, 0);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(47, 15);
            this.lb_user.TabIndex = 0;
            this.lb_user.Text = "Usuário";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 279);
            this.Controls.Add(this.pn_00);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.Text = "login";
            this.pn_00.ResumeLayout(false);
            this.tlp_00.ResumeLayout(false);
            this.tlp_00.PerformLayout();
            this.pn_01.ResumeLayout(false);
            this.pn_01.PerformLayout();
            this.pn_enter.ResumeLayout(false);
            this.pn_exit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_00;
        private System.Windows.Forms.TableLayoutPanel tlp_00;
        private System.Windows.Forms.Label lb_welcome;
        private System.Windows.Forms.Panel pn_01;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Panel pn_enter;
        private System.Windows.Forms.Panel pn_exit;
    }
}