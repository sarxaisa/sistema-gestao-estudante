namespace sistema_gestao_estudante
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eSTUDANTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirEstudantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEstudantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatíticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarremoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarEstudantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ímprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cURSOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eSTUDANTEToolStripMenuItem,
            this.cURSOToolStripMenuItem,
            this.nOTAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eSTUDANTEToolStripMenuItem
            // 
            this.eSTUDANTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirEstudantesToolStripMenuItem,
            this.listarEstudantesToolStripMenuItem,
            this.estatíticasToolStripMenuItem,
            this.editarremoverToolStripMenuItem,
            this.gerenciarEstudantesToolStripMenuItem,
            this.ímprimirToolStripMenuItem});
            this.eSTUDANTEToolStripMenuItem.Name = "eSTUDANTEToolStripMenuItem";
            this.eSTUDANTEToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.eSTUDANTEToolStripMenuItem.Text = "ESTUDANTE";
            // 
            // inserirEstudantesToolStripMenuItem
            // 
            this.inserirEstudantesToolStripMenuItem.Name = "inserirEstudantesToolStripMenuItem";
            this.inserirEstudantesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.inserirEstudantesToolStripMenuItem.Text = "Inserir Estudantes";
            this.inserirEstudantesToolStripMenuItem.Click += new System.EventHandler(this.inserirEstudantesToolStripMenuItem_Click);
            // 
            // listarEstudantesToolStripMenuItem
            // 
            this.listarEstudantesToolStripMenuItem.Name = "listarEstudantesToolStripMenuItem";
            this.listarEstudantesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.listarEstudantesToolStripMenuItem.Text = "Listar Estudantes";
            // 
            // estatíticasToolStripMenuItem
            // 
            this.estatíticasToolStripMenuItem.Name = "estatíticasToolStripMenuItem";
            this.estatíticasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.estatíticasToolStripMenuItem.Text = "Estatísticas";
            // 
            // editarremoverToolStripMenuItem
            // 
            this.editarremoverToolStripMenuItem.Name = "editarremoverToolStripMenuItem";
            this.editarremoverToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.editarremoverToolStripMenuItem.Text = "Editar/Remover";
            // 
            // gerenciarEstudantesToolStripMenuItem
            // 
            this.gerenciarEstudantesToolStripMenuItem.Name = "gerenciarEstudantesToolStripMenuItem";
            this.gerenciarEstudantesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.gerenciarEstudantesToolStripMenuItem.Text = "Gerenciar Estudantes";
            // 
            // ímprimirToolStripMenuItem
            // 
            this.ímprimirToolStripMenuItem.Name = "ímprimirToolStripMenuItem";
            this.ímprimirToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ímprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // cURSOToolStripMenuItem
            // 
            this.cURSOToolStripMenuItem.Name = "cURSOToolStripMenuItem";
            this.cURSOToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cURSOToolStripMenuItem.Text = "CURSO";
            // 
            // nOTAToolStripMenuItem
            // 
            this.nOTAToolStripMenuItem.Name = "nOTAToolStripMenuItem";
            this.nOTAToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.nOTAToolStripMenuItem.Text = "NOTA";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "SGE - Início";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eSTUDANTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirEstudantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEstudantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatíticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarremoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarEstudantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ímprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cURSOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOTAToolStripMenuItem;
    }
}