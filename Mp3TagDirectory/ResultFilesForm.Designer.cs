namespace Mp3TagDirectory
{
    partial class ResultFilesForm
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
            this.listView2 = new System.Windows.Forms.ListView();
            this.col2Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2Titulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2Artista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2Pista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2Genero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupToolsFiles = new System.Windows.Forms.GroupBox();
            this.txtReplaceCharTo = new System.Windows.Forms.TextBox();
            this.txtReplaceCharFrom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupToolsFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col2Nombre,
            this.col2Tipo,
            this.col2Fecha,
            this.col2Titulo,
            this.col2Album,
            this.col2Artista,
            this.col2Pista,
            this.col2Genero});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(6, 18);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(818, 454);
            this.listView2.TabIndex = 14;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // col2Nombre
            // 
            this.col2Nombre.Text = "Nombre";
            this.col2Nombre.Width = 200;
            // 
            // col2Tipo
            // 
            this.col2Tipo.Text = "Tipo";
            // 
            // col2Fecha
            // 
            this.col2Fecha.Text = "Fecha";
            // 
            // col2Titulo
            // 
            this.col2Titulo.Text = "Titulo";
            // 
            // col2Album
            // 
            this.col2Album.Text = "Album";
            // 
            // col2Artista
            // 
            this.col2Artista.Text = "Artista";
            // 
            // col2Pista
            // 
            this.col2Pista.Text = "Track";
            // 
            // col2Genero
            // 
            this.col2Genero.Text = "Género";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupToolsFiles);
            this.groupBox3.Controls.Add(this.listView2);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(830, 668);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result files";
            // 
            // groupToolsFiles
            // 
            this.groupToolsFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupToolsFiles.Controls.Add(this.txtReplaceCharTo);
            this.groupToolsFiles.Controls.Add(this.txtReplaceCharFrom);
            this.groupToolsFiles.Controls.Add(this.label8);
            this.groupToolsFiles.Controls.Add(this.btnRename);
            this.groupToolsFiles.Controls.Add(this.label6);
            this.groupToolsFiles.Location = new System.Drawing.Point(6, 478);
            this.groupToolsFiles.Name = "groupToolsFiles";
            this.groupToolsFiles.Size = new System.Drawing.Size(217, 130);
            this.groupToolsFiles.TabIndex = 23;
            this.groupToolsFiles.TabStop = false;
            this.groupToolsFiles.Text = "Substituir cadena de texto";
            // 
            // txtReplaceCharTo
            // 
            this.txtReplaceCharTo.Location = new System.Drawing.Point(66, 52);
            this.txtReplaceCharTo.Name = "txtReplaceCharTo";
            this.txtReplaceCharTo.Size = new System.Drawing.Size(131, 20);
            this.txtReplaceCharTo.TabIndex = 3;
            this.txtReplaceCharTo.TextChanged += new System.EventHandler(this.txtReplace_TextChanged);
            // 
            // txtReplaceCharFrom
            // 
            this.txtReplaceCharFrom.Location = new System.Drawing.Point(66, 30);
            this.txtReplaceCharFrom.Name = "txtReplaceCharFrom";
            this.txtReplaceCharFrom.Size = new System.Drawing.Size(131, 20);
            this.txtReplaceCharFrom.TabIndex = 0;
            this.txtReplaceCharFrom.TextChanged += new System.EventHandler(this.txtReplace_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "por";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(96, 78);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(101, 30);
            this.btnRename.TabIndex = 2;
            this.btnRename.Text = "Reemplazar";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cadena";
            // 
            // ResultFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 692);
            this.Controls.Add(this.groupBox3);
            this.Name = "ResultFilesForm";
            this.Text = "Operaciones de renombrado";
            this.groupBox3.ResumeLayout(false);
            this.groupToolsFiles.ResumeLayout(false);
            this.groupToolsFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader col2Nombre;
        private System.Windows.Forms.ColumnHeader col2Tipo;
        private System.Windows.Forms.ColumnHeader col2Fecha;
        private System.Windows.Forms.ColumnHeader col2Titulo;
        private System.Windows.Forms.ColumnHeader col2Album;
        private System.Windows.Forms.ColumnHeader col2Artista;
        private System.Windows.Forms.ColumnHeader col2Pista;
        private System.Windows.Forms.ColumnHeader col2Genero;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupToolsFiles;
        private System.Windows.Forms.TextBox txtReplaceCharTo;
        private System.Windows.Forms.TextBox txtReplaceCharFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Label label6;

    }
}