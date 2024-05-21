namespace GestorDeEstudantesT6
{
    partial class FormMenuPrincipal
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAlunoToolStripMenuItem,
            this.listarAlunosToolStripMenuItem,
            this.estatisticasToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.gerenciarAlunosToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // cadastrarAlunoToolStripMenuItem
            // 
            this.cadastrarAlunoToolStripMenuItem.Name = "cadastrarAlunoToolStripMenuItem";
            this.cadastrarAlunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarAlunoToolStripMenuItem.Text = "Cadastrar aluno";
            // 
            // listarAlunosToolStripMenuItem
            // 
            this.listarAlunosToolStripMenuItem.Name = "listarAlunosToolStripMenuItem";
            this.listarAlunosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarAlunosToolStripMenuItem.Text = "Listar alunos ";
            // 
            // estatisticasToolStripMenuItem
            // 
            this.estatisticasToolStripMenuItem.Name = "estatisticasToolStripMenuItem";
            this.estatisticasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estatisticasToolStripMenuItem.Text = "Estatisticas";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.editarToolStripMenuItem.Text = "Editar/ Remover alunos";
            // 
            // gerenciarAlunosToolStripMenuItem
            // 
            this.gerenciarAlunosToolStripMenuItem.Name = "gerenciarAlunosToolStripMenuItem";
            this.gerenciarAlunosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.gerenciarAlunosToolStripMenuItem.Text = "Gerenciar alunos";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenuPrincipal";
            this.Text = "FormMenuPrincipal";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
    }
}