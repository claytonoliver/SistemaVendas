namespace Sistema
{
    partial class ParametrosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParametrosForm));
            DgParametros = new DataGridView();
            toolStrip1 = new ToolStrip();
            BtnIncluir = new ToolStripButton();
            BtnEditar = new ToolStripButton();
            BtnRemover = new ToolStripButton();
            btnReport = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)DgParametros).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DgParametros
            // 
            DgParametros.AllowUserToAddRows = false;
            DgParametros.AllowUserToDeleteRows = false;
            DgParametros.AllowUserToResizeRows = false;
            DgParametros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgParametros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgParametros.Dock = DockStyle.Fill;
            DgParametros.Location = new Point(0, 25);
            DgParametros.MultiSelect = false;
            DgParametros.Name = "DgParametros";
            DgParametros.ReadOnly = true;
            DgParametros.RowHeadersVisible = false;
            DgParametros.RowTemplate.Height = 25;
            DgParametros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgParametros.ShowCellToolTips = false;
            DgParametros.Size = new Size(800, 425);
            DgParametros.TabIndex = 3;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { BtnIncluir, BtnEditar, BtnRemover, btnReport });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // BtnIncluir
            // 
            BtnIncluir.BackgroundImage = (Image)resources.GetObject("BtnIncluir.BackgroundImage");
            BtnIncluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnIncluir.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_bookmark_new_256;
            BtnIncluir.ImageTransparentColor = Color.Magenta;
            BtnIncluir.Name = "BtnIncluir";
            BtnIncluir.Size = new Size(23, 22);
            BtnIncluir.Text = "Incluir";
            BtnIncluir.Click += BtnIncluir_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnEditar.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_edit_256;
            BtnEditar.ImageTransparentColor = Color.Magenta;
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(23, 22);
            BtnEditar.Text = "Editar";
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnRemover
            // 
            BtnRemover.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnRemover.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_close_256;
            BtnRemover.ImageTransparentColor = Color.Magenta;
            BtnRemover.Name = "BtnRemover";
            BtnRemover.Size = new Size(23, 22);
            BtnRemover.Text = "Excluir";
            BtnRemover.Click += BtnRemover_Click;
            // 
            // btnReport
            // 
            btnReport.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageTransparentColor = Color.Magenta;
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(23, 22);
            btnReport.Text = "toolStripButton1";
            btnReport.Click += btnReport_Click;
            // 
            // ParametrosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgParametros);
            Controls.Add(toolStrip1);
            Name = "ParametrosForm";
            ShowIcon = false;
            Text = "Parametros";
            ((System.ComponentModel.ISupportInitialize)DgParametros).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DgParametros;
        private ToolStrip toolStrip1;
        private ToolStripButton BtnIncluir;
        private ToolStripButton BtnEditar;
        private ToolStripButton BtnRemover;
        private ToolStripButton btnReport;
    }
}