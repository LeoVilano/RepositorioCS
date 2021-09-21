
namespace Treinamento
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_001 = new System.Windows.Forms.Button();
            this.tb_digite = new System.Windows.Forms.TextBox();
            this.lb_digitado = new System.Windows.Forms.Label();
            this.tb_digite2 = new System.Windows.Forms.TextBox();
            this.btm_limpar = new System.Windows.Forms.Button();
            this.btn_lista = new System.Windows.Forms.Button();
            this.btn_variavel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_001
            // 
            this.btn_001.Location = new System.Drawing.Point(136, 46);
            this.btn_001.Name = "btn_001";
            this.btn_001.Size = new System.Drawing.Size(75, 23);
            this.btn_001.TabIndex = 0;
            this.btn_001.Text = "Adicionar";
            this.btn_001.UseVisualStyleBackColor = true;
            this.btn_001.Click += new System.EventHandler(this.btn_001_Click);
            // 
            // tb_digite
            // 
            this.tb_digite.Location = new System.Drawing.Point(12, 47);
            this.tb_digite.Name = "tb_digite";
            this.tb_digite.Size = new System.Drawing.Size(117, 20);
            this.tb_digite.TabIndex = 1;
            // 
            // lb_digitado
            // 
            this.lb_digitado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_digitado.AutoSize = true;
            this.lb_digitado.Location = new System.Drawing.Point(12, 31);
            this.lb_digitado.Name = "lb_digitado";
            this.lb_digitado.Size = new System.Drawing.Size(77, 13);
            this.lb_digitado.TabIndex = 2;
            this.lb_digitado.Text = "Digite um texto";
            // 
            // tb_digite2
            // 
            this.tb_digite2.Location = new System.Drawing.Point(12, 76);
            this.tb_digite2.Multiline = true;
            this.tb_digite2.Name = "tb_digite2";
            this.tb_digite2.ReadOnly = true;
            this.tb_digite2.Size = new System.Drawing.Size(199, 263);
            this.tb_digite2.TabIndex = 3;
            // 
            // btm_limpar
            // 
            this.btm_limpar.Location = new System.Drawing.Point(12, 347);
            this.btm_limpar.Name = "btm_limpar";
            this.btm_limpar.Size = new System.Drawing.Size(199, 23);
            this.btm_limpar.TabIndex = 4;
            this.btm_limpar.Text = "Limpar";
            this.btm_limpar.UseVisualStyleBackColor = true;
            this.btm_limpar.Click += new System.EventHandler(this.btm_limpar_Click);
            // 
            // btn_lista
            // 
            this.btn_lista.Location = new System.Drawing.Point(12, 376);
            this.btn_lista.Name = "btn_lista";
            this.btn_lista.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_lista.Size = new System.Drawing.Size(199, 23);
            this.btn_lista.TabIndex = 5;
            this.btn_lista.Text = "Lista de Carro";
            this.btn_lista.UseVisualStyleBackColor = true;
            this.btn_lista.Click += new System.EventHandler(this.btn_lista_Click);
            // 
            // btn_variavel
            // 
            this.btn_variavel.Location = new System.Drawing.Point(12, 406);
            this.btn_variavel.Name = "btn_variavel";
            this.btn_variavel.Size = new System.Drawing.Size(199, 23);
            this.btn_variavel.TabIndex = 6;
            this.btn_variavel.Text = "Variavel";
            this.btn_variavel.UseVisualStyleBackColor = true;
            this.btn_variavel.Click += new System.EventHandler(this.btn_variavel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem,
            this.sQLiteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(223, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem,
            this.checkedToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.timePickerToolStripMenuItem,
            this.linkLabelToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkBoxToolStripMenuItem.Text = "Check Box";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
            // 
            // checkedToolStripMenuItem
            // 
            this.checkedToolStripMenuItem.Name = "checkedToolStripMenuItem";
            this.checkedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedToolStripMenuItem.Text = "Checked";
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // timePickerToolStripMenuItem
            // 
            this.timePickerToolStripMenuItem.Name = "timePickerToolStripMenuItem";
            this.timePickerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.timePickerToolStripMenuItem.Text = "TimePicker";
            this.timePickerToolStripMenuItem.Click += new System.EventHandler(this.timePickerToolStripMenuItem_Click);
            // 
            // linkLabelToolStripMenuItem
            // 
            this.linkLabelToolStripMenuItem.Name = "linkLabelToolStripMenuItem";
            this.linkLabelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linkLabelToolStripMenuItem.Text = "LinkLabel";
            this.linkLabelToolStripMenuItem.Click += new System.EventHandler(this.linkLabelToolStripMenuItem_Click);
            // 
            // sQLiteToolStripMenuItem
            // 
            this.sQLiteToolStripMenuItem.Name = "sQLiteToolStripMenuItem";
            this.sQLiteToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sQLiteToolStripMenuItem.Text = "SQLite";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(223, 435);
            this.Controls.Add(this.btn_variavel);
            this.Controls.Add(this.btn_lista);
            this.Controls.Add(this.btm_limpar);
            this.Controls.Add(this.tb_digite2);
            this.Controls.Add(this.lb_digitado);
            this.Controls.Add(this.tb_digite);
            this.Controls.Add(this.btn_001);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa Teste";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_001;
        private System.Windows.Forms.TextBox tb_digite;
        private System.Windows.Forms.Label lb_digitado;
        private System.Windows.Forms.Button btm_limpar;
        private System.Windows.Forms.Button btn_lista;
        private System.Windows.Forms.Button btn_variavel;
        public System.Windows.Forms.TextBox tb_digite2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timePickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLiteToolStripMenuItem;
    }
}

