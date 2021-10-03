
namespace Loja
{
    partial class FormEstoque
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
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.btIncluir = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.dgEstoque = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colsubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbValor = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbQtd = new System.Windows.Forms.TextBox();
            this.lbQtd = new System.Windows.Forms.Label();
            this.tbValorTotal = new System.Windows.Forms.TextBox();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.tbQtdTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(102, 41);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(194, 20);
            this.tbMarca.TabIndex = 0;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(102, 67);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(283, 20);
            this.tbDescricao.TabIndex = 1;
            this.tbDescricao.TextChanged += new System.EventHandler(this.tbDescricao_TextChanged);
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Location = new System.Drawing.Point(102, 14);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 22);
            this.tbCodigo.TabIndex = 2;
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(3, 40);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(52, 18);
            this.lbMarca.TabIndex = 3;
            this.lbMarca.Text = "Marca";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(3, 66);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(80, 18);
            this.lbDescricao.TabIndex = 4;
            this.lbDescricao.Text = "Descrição";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(3, 13);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(60, 18);
            this.lbCodigo.TabIndex = 5;
            this.lbCodigo.Text = "Código";
            // 
            // btIncluir
            // 
            this.btIncluir.BackColor = System.Drawing.Color.ForestGreen;
            this.btIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btIncluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btIncluir.Location = new System.Drawing.Point(102, 104);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(120, 40);
            this.btIncluir.TabIndex = 6;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = false;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.Firebrick;
            this.btExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btExcluir.Location = new System.Drawing.Point(265, 104);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(120, 40);
            this.btExcluir.TabIndex = 7;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.AutoEllipsis = true;
            this.btAlterar.BackColor = System.Drawing.Color.Orange;
            this.btAlterar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAlterar.Location = new System.Drawing.Point(420, 104);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(120, 40);
            this.btAlterar.TabIndex = 8;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // dgEstoque
            // 
            this.dgEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgEstoque.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colMarca,
            this.colDescricao,
            this.colValor,
            this.ColQtd,
            this.Colsubtotal});
            this.dgEstoque.Location = new System.Drawing.Point(6, 160);
            this.dgEstoque.Name = "dgEstoque";
            this.dgEstoque.Size = new System.Drawing.Size(1018, 470);
            this.dgEstoque.TabIndex = 9;
            this.dgEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEstoque_CellContentClick);
            this.dgEstoque.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEstoque_CellContentDoubleClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 50;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Width = 70;
            // 
            // ColQtd
            // 
            this.ColQtd.HeaderText = "Qtd";
            this.ColQtd.Name = "ColQtd";
            this.ColQtd.Width = 30;
            // 
            // Colsubtotal
            // 
            this.Colsubtotal.HeaderText = "Total";
            this.Colsubtotal.Name = "Colsubtotal";
            this.Colsubtotal.Width = 70;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.Location = new System.Drawing.Point(390, 40);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(44, 18);
            this.lbValor.TabIndex = 10;
            this.lbValor.Text = "Valor";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(440, 41);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 20);
            this.tbValor.TabIndex = 11;
            this.tbValor.TextChanged += new System.EventHandler(this.tbValor_TextChanged);
            // 
            // tbQtd
            // 
            this.tbQtd.Location = new System.Drawing.Point(440, 67);
            this.tbQtd.Name = "tbQtd";
            this.tbQtd.Size = new System.Drawing.Size(100, 20);
            this.tbQtd.TabIndex = 13;
            // 
            // lbQtd
            // 
            this.lbQtd.AutoSize = true;
            this.lbQtd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtd.Location = new System.Drawing.Point(391, 66);
            this.lbQtd.Name = "lbQtd";
            this.lbQtd.Size = new System.Drawing.Size(33, 18);
            this.lbQtd.TabIndex = 12;
            this.lbQtd.Text = "Qtd";
            this.lbQtd.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbValorTotal
            // 
            this.tbValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValorTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbValorTotal.Enabled = false;
            this.tbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorTotal.Location = new System.Drawing.Point(910, 41);
            this.tbValorTotal.Name = "tbValorTotal";
            this.tbValorTotal.ReadOnly = true;
            this.tbValorTotal.Size = new System.Drawing.Size(100, 22);
            this.tbValorTotal.TabIndex = 15;
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotal.Location = new System.Drawing.Point(741, 40);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(163, 18);
            this.lbValorTotal.TabIndex = 14;
            this.lbValorTotal.Text = "Valor total em estoque";
            // 
            // tbQtdTotal
            // 
            this.tbQtdTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbQtdTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbQtdTotal.Enabled = false;
            this.tbQtdTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQtdTotal.Location = new System.Drawing.Point(910, 67);
            this.tbQtdTotal.Name = "tbQtdTotal";
            this.tbQtdTotal.ReadOnly = true;
            this.tbQtdTotal.Size = new System.Drawing.Size(100, 22);
            this.tbQtdTotal.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(741, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Qtd total em estoque";
            // 
            // btLimpar
            // 
            this.btLimpar.AutoEllipsis = true;
            this.btLimpar.BackColor = System.Drawing.Color.Chocolate;
            this.btLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btLimpar.Location = new System.Drawing.Point(578, 104);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(120, 40);
            this.btLimpar.TabIndex = 18;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1010, 634);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.tbQtdTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbValorTotal);
            this.Controls.Add(this.lbValorTotal);
            this.Controls.Add(this.tbQtd);
            this.Controls.Add(this.lbQtd);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.dgEstoque);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbMarca);
            this.Name = "FormEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque";
            this.Load += new System.EventHandler(this.FormEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbQtd;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.DataGridView dgEstoque;
        private System.Windows.Forms.Label lbValor;        
        private System.Windows.Forms.Label lbQtd;
        private System.Windows.Forms.TextBox tbValorTotal;
        private System.Windows.Forms.Label lbValorTotal;
        private System.Windows.Forms.TextBox tbQtdTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colsubtotal;
        private System.Windows.Forms.Button btLimpar;
    }
}

