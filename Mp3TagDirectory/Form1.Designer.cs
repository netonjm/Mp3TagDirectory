namespace Mp3TagDirectory
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.colTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArtista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treeLocalDirectories = new System.Windows.Forms.TreeView();
            this.groupDirectory = new System.Windows.Forms.GroupBox();
            this.btnModifyDirectoryName = new System.Windows.Forms.Button();
            this.txtSelectedDirectory = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupFile = new System.Windows.Forms.GroupBox();
            this.btnUpdateSelectedGenero = new System.Windows.Forms.Button();
            this.btnUpdateSelectedAlbum = new System.Windows.Forms.Button();
            this.btnUpdateSelectedArtist = new System.Windows.Forms.Button();
            this.btnCancelarFileName = new System.Windows.Forms.Button();
            this.txtSelectedFileGenero = new System.Windows.Forms.TextBox();
            this.txtSelectedFileArtista = new System.Windows.Forms.TextBox();
            this.txtSelectedFilePista = new System.Windows.Forms.TextBox();
            this.txtSelectedFileAlbum = new System.Windows.Forms.TextBox();
            this.txtSelectedFileTitle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnModificarFileName = new System.Windows.Forms.Button();
            this.lblFileFecha = new System.Windows.Forms.Label();
            this.txtSelectedFileName = new System.Windows.Forms.TextBox();
            this.lblFileTipo = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDirectoryEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDirectoryRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnDirectoryCreate = new System.Windows.Forms.ToolStripButton();
            this.btnDirectoryDelete = new System.Windows.Forms.ToolStripButton();
            this.btnFileEdit = new System.Windows.Forms.ToolStripButton();
            this.btnFilesRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnFilesSelectAll = new System.Windows.Forms.ToolStripButton();
            this.btnFilesSelectNone = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShowDevice = new System.Windows.Forms.ToolStripButton();
            this.btnShowResults = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.groupDirectory.SuspendLayout();
            this.groupFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 200;
            // 
            // colTipo
            // 
            this.colTipo.Text = "Tipo";
            // 
            // colFecha
            // 
            this.colFecha.Text = "Fecha";
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNombre,
            this.colTipo,
            this.colFecha,
            this.colTitulo,
            this.colAlbum,
            this.colArtista,
            this.colPista,
            this.colGenero});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(405, 310);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView1_ItemDrag);
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            this.listView1.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.listView1_GiveFeedback);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.Enter += new System.EventHandler(this.listView1_Enter);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // colTitulo
            // 
            this.colTitulo.Text = "Título";
            // 
            // colAlbum
            // 
            this.colAlbum.Text = "Album";
            // 
            // colArtista
            // 
            this.colArtista.Text = "Artista";
            // 
            // colPista
            // 
            this.colPista.Text = "Pista";
            // 
            // colGenero
            // 
            this.colGenero.Text = "Genero";
            // 
            // treeLocalDirectories
            // 
            this.treeLocalDirectories.AllowDrop = true;
            this.treeLocalDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeLocalDirectories.FullRowSelect = true;
            this.treeLocalDirectories.HideSelection = false;
            this.treeLocalDirectories.Location = new System.Drawing.Point(6, 44);
            this.treeLocalDirectories.Name = "treeLocalDirectories";
            this.treeLocalDirectories.Size = new System.Drawing.Size(368, 428);
            this.treeLocalDirectories.TabIndex = 8;
            this.treeLocalDirectories.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            this.treeLocalDirectories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeLocalDirectories.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeLocalDirectories.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeLocalDirectories.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            this.treeLocalDirectories.Enter += new System.EventHandler(this.treeLocalDirectories_Enter);
            this.treeLocalDirectories.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            // 
            // groupDirectory
            // 
            this.groupDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDirectory.Controls.Add(this.btnModifyDirectoryName);
            this.groupDirectory.Controls.Add(this.txtSelectedDirectory);
            this.groupDirectory.Controls.Add(this.label9);
            this.groupDirectory.Location = new System.Drawing.Point(10, 487);
            this.groupDirectory.Name = "groupDirectory";
            this.groupDirectory.Size = new System.Drawing.Size(380, 93);
            this.groupDirectory.TabIndex = 9;
            this.groupDirectory.TabStop = false;
            this.groupDirectory.Text = "Directory selected info";
            // 
            // btnModifyDirectoryName
            // 
            this.btnModifyDirectoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyDirectoryName.Location = new System.Drawing.Point(297, 54);
            this.btnModifyDirectoryName.Name = "btnModifyDirectoryName";
            this.btnModifyDirectoryName.Size = new System.Drawing.Size(65, 26);
            this.btnModifyDirectoryName.TabIndex = 24;
            this.btnModifyDirectoryName.Text = "Update";
            this.btnModifyDirectoryName.UseVisualStyleBackColor = true;
            this.btnModifyDirectoryName.Click += new System.EventHandler(this.btnModifyDirectoryName_Click);
            // 
            // txtSelectedDirectory
            // 
            this.txtSelectedDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedDirectory.Location = new System.Drawing.Point(70, 28);
            this.txtSelectedDirectory.Name = "txtSelectedDirectory";
            this.txtSelectedDirectory.Size = new System.Drawing.Size(292, 20);
            this.txtSelectedDirectory.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Nombre:";
            // 
            // groupFile
            // 
            this.groupFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFile.Controls.Add(this.btnUpdateSelectedGenero);
            this.groupFile.Controls.Add(this.btnUpdateSelectedAlbum);
            this.groupFile.Controls.Add(this.btnUpdateSelectedArtist);
            this.groupFile.Controls.Add(this.btnCancelarFileName);
            this.groupFile.Controls.Add(this.txtSelectedFileGenero);
            this.groupFile.Controls.Add(this.txtSelectedFileArtista);
            this.groupFile.Controls.Add(this.txtSelectedFilePista);
            this.groupFile.Controls.Add(this.txtSelectedFileAlbum);
            this.groupFile.Controls.Add(this.txtSelectedFileTitle);
            this.groupFile.Controls.Add(this.label14);
            this.groupFile.Controls.Add(this.label13);
            this.groupFile.Controls.Add(this.label12);
            this.groupFile.Controls.Add(this.label11);
            this.groupFile.Controls.Add(this.label10);
            this.groupFile.Controls.Add(this.btnModificarFileName);
            this.groupFile.Controls.Add(this.lblFileFecha);
            this.groupFile.Controls.Add(this.txtSelectedFileName);
            this.groupFile.Controls.Add(this.lblFileTipo);
            this.groupFile.Controls.Add(this.lblFileName);
            this.groupFile.Location = new System.Drawing.Point(8, 369);
            this.groupFile.Name = "groupFile";
            this.groupFile.Size = new System.Drawing.Size(417, 211);
            this.groupFile.TabIndex = 10;
            this.groupFile.TabStop = false;
            this.groupFile.Text = "File selected info";
            // 
            // btnUpdateSelectedGenero
            // 
            this.btnUpdateSelectedGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateSelectedGenero.Location = new System.Drawing.Point(348, 133);
            this.btnUpdateSelectedGenero.Name = "btnUpdateSelectedGenero";
            this.btnUpdateSelectedGenero.Size = new System.Drawing.Size(50, 23);
            this.btnUpdateSelectedGenero.TabIndex = 35;
            this.btnUpdateSelectedGenero.Text = "To all";
            this.btnUpdateSelectedGenero.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSelectedAlbum
            // 
            this.btnUpdateSelectedAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateSelectedAlbum.Location = new System.Drawing.Point(243, 108);
            this.btnUpdateSelectedAlbum.Name = "btnUpdateSelectedAlbum";
            this.btnUpdateSelectedAlbum.Size = new System.Drawing.Size(50, 23);
            this.btnUpdateSelectedAlbum.TabIndex = 34;
            this.btnUpdateSelectedAlbum.Text = "To all";
            this.btnUpdateSelectedAlbum.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSelectedArtist
            // 
            this.btnUpdateSelectedArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateSelectedArtist.Location = new System.Drawing.Point(123, 134);
            this.btnUpdateSelectedArtist.Name = "btnUpdateSelectedArtist";
            this.btnUpdateSelectedArtist.Size = new System.Drawing.Size(50, 23);
            this.btnUpdateSelectedArtist.TabIndex = 33;
            this.btnUpdateSelectedArtist.Text = "To all";
            this.btnUpdateSelectedArtist.UseVisualStyleBackColor = true;
            // 
            // btnCancelarFileName
            // 
            this.btnCancelarFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarFileName.Location = new System.Drawing.Point(325, 170);
            this.btnCancelarFileName.Name = "btnCancelarFileName";
            this.btnCancelarFileName.Size = new System.Drawing.Size(86, 26);
            this.btnCancelarFileName.TabIndex = 32;
            this.btnCancelarFileName.Text = "Cancel";
            this.btnCancelarFileName.UseVisualStyleBackColor = true;
            this.btnCancelarFileName.Click += new System.EventHandler(this.btnCancelarFileName_Click);
            // 
            // txtSelectedFileGenero
            // 
            this.txtSelectedFileGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedFileGenero.Location = new System.Drawing.Point(223, 135);
            this.txtSelectedFileGenero.Name = "txtSelectedFileGenero";
            this.txtSelectedFileGenero.Size = new System.Drawing.Size(119, 20);
            this.txtSelectedFileGenero.TabIndex = 31;
            this.txtSelectedFileGenero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSelectedFile_KeyDown);
            // 
            // txtSelectedFileArtista
            // 
            this.txtSelectedFileArtista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedFileArtista.Location = new System.Drawing.Point(70, 136);
            this.txtSelectedFileArtista.Name = "txtSelectedFileArtista";
            this.txtSelectedFileArtista.Size = new System.Drawing.Size(47, 20);
            this.txtSelectedFileArtista.TabIndex = 30;
            this.txtSelectedFileArtista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSelectedFile_KeyDown);
            // 
            // txtSelectedFilePista
            // 
            this.txtSelectedFilePista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedFilePista.Location = new System.Drawing.Point(338, 110);
            this.txtSelectedFilePista.Name = "txtSelectedFilePista";
            this.txtSelectedFilePista.Size = new System.Drawing.Size(60, 20);
            this.txtSelectedFilePista.TabIndex = 29;
            this.txtSelectedFilePista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSelectedFile_KeyDown);
            // 
            // txtSelectedFileAlbum
            // 
            this.txtSelectedFileAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedFileAlbum.Location = new System.Drawing.Point(70, 110);
            this.txtSelectedFileAlbum.Name = "txtSelectedFileAlbum";
            this.txtSelectedFileAlbum.Size = new System.Drawing.Size(167, 20);
            this.txtSelectedFileAlbum.TabIndex = 28;
            this.txtSelectedFileAlbum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSelectedFile_KeyDown);
            // 
            // txtSelectedFileTitle
            // 
            this.txtSelectedFileTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedFileTitle.Location = new System.Drawing.Point(70, 85);
            this.txtSelectedFileTitle.Name = "txtSelectedFileTitle";
            this.txtSelectedFileTitle.Size = new System.Drawing.Size(328, 20);
            this.txtSelectedFileTitle.TabIndex = 27;
            this.txtSelectedFileTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSelectedFile_KeyDown);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(179, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Genero:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(17, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Album:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(299, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Pista:";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(19, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Artista:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(21, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Titulo:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnModificarFileName
            // 
            this.btnModificarFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarFileName.Location = new System.Drawing.Point(231, 170);
            this.btnModificarFileName.Name = "btnModificarFileName";
            this.btnModificarFileName.Size = new System.Drawing.Size(88, 26);
            this.btnModificarFileName.TabIndex = 21;
            this.btnModificarFileName.Text = "Update";
            this.btnModificarFileName.UseVisualStyleBackColor = true;
            this.btnModificarFileName.Click += new System.EventHandler(this.btnModificarTittle_Click);
            // 
            // lblFileFecha
            // 
            this.lblFileFecha.AutoSize = true;
            this.lblFileFecha.Location = new System.Drawing.Point(140, 55);
            this.lblFileFecha.Name = "lblFileFecha";
            this.lblFileFecha.Size = new System.Drawing.Size(59, 13);
            this.lblFileFecha.TabIndex = 20;
            this.lblFileFecha.Text = "Created at:";
            // 
            // txtSelectedFileName
            // 
            this.txtSelectedFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedFileName.Location = new System.Drawing.Point(70, 25);
            this.txtSelectedFileName.Name = "txtSelectedFileName";
            this.txtSelectedFileName.Size = new System.Drawing.Size(328, 20);
            this.txtSelectedFileName.TabIndex = 18;
            this.txtSelectedFileName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSelectedFile_KeyDown);
            // 
            // lblFileTipo
            // 
            this.lblFileTipo.AutoSize = true;
            this.lblFileTipo.Location = new System.Drawing.Point(33, 55);
            this.lblFileTipo.Name = "lblFileTipo";
            this.lblFileTipo.Size = new System.Drawing.Size(31, 13);
            this.lblFileTipo.TabIndex = 17;
            this.lblFileTipo.Text = "Tipo:";
            // 
            // lblFileName
            // 
            this.lblFileName.Location = new System.Drawing.Point(6, 28);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(58, 13);
            this.lblFileName.TabIndex = 16;
            this.lblFileName.Text = "Nombre:";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupDirectory);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupFile);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(826, 583);
            this.splitContainer1.SplitterDistance = 394;
            this.splitContainer1.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.toolStrip2);
            this.groupBox2.Controls.Add(this.treeLocalDirectories);
            this.groupBox2.Location = new System.Drawing.Point(4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 478);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LOCAL - Directorios";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDirectoryEdit,
            this.toolStripSeparator2,
            this.btnDirectoryRefresh,
            this.toolStripSeparator3,
            this.btnDirectoryCreate,
            this.btnDirectoryDelete,
            this.toolStripSeparator6});
            this.toolStrip2.Location = new System.Drawing.Point(3, 16);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(374, 25);
            this.toolStrip2.TabIndex = 16;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 360);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOCAL - Ficheros";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFileEdit,
            this.toolStripSeparator1,
            this.btnFilesRefresh,
            this.toolStripSeparator4,
            this.btnFilesSelectAll,
            this.btnFilesSelectNone,
            this.toolStripSeparator7,
            this.btnShowDevice,
            this.toolStripSeparator9,
            this.btnShowResults});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(411, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 613);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(850, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 17);
            this.toolStripStatusLabel1.Text = "Device Music Manager v0.4";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.deviceToolStripMenuItem.Text = "Configuración";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem1});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.acercaDeToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem1.Text = "Acerca de...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // btnDirectoryEdit
            // 
            this.btnDirectoryEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDirectoryEdit.Image = global::Mp3TagDirectory.Properties.Resources.folder_edit;
            this.btnDirectoryEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDirectoryEdit.Name = "btnDirectoryEdit";
            this.btnDirectoryEdit.Size = new System.Drawing.Size(23, 22);
            this.btnDirectoryEdit.Text = "Renombrar";
            this.btnDirectoryEdit.Click += new System.EventHandler(this.btnDirectoryEdit_Click);
            // 
            // btnDirectoryRefresh
            // 
            this.btnDirectoryRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDirectoryRefresh.Image = global::Mp3TagDirectory.Properties.Resources.action_refresh;
            this.btnDirectoryRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDirectoryRefresh.Name = "btnDirectoryRefresh";
            this.btnDirectoryRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnDirectoryRefresh.Text = "Refrescar directorios";
            this.btnDirectoryRefresh.Click += new System.EventHandler(this.btnDirectoryRefresh_Click);
            // 
            // btnDirectoryCreate
            // 
            this.btnDirectoryCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDirectoryCreate.Image = global::Mp3TagDirectory.Properties.Resources.folder_add;
            this.btnDirectoryCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDirectoryCreate.Name = "btnDirectoryCreate";
            this.btnDirectoryCreate.Size = new System.Drawing.Size(23, 22);
            this.btnDirectoryCreate.Text = "Añadir carpeta";
            // 
            // btnDirectoryDelete
            // 
            this.btnDirectoryDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDirectoryDelete.Image = global::Mp3TagDirectory.Properties.Resources.folder_delete;
            this.btnDirectoryDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDirectoryDelete.Name = "btnDirectoryDelete";
            this.btnDirectoryDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDirectoryDelete.Text = "Eliminar carpeta";
            this.btnDirectoryDelete.Click += new System.EventHandler(this.btnDirectoryDelete_Click);
            // 
            // btnFileEdit
            // 
            this.btnFileEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFileEdit.Image = global::Mp3TagDirectory.Properties.Resources.page_edit;
            this.btnFileEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFileEdit.Name = "btnFileEdit";
            this.btnFileEdit.Size = new System.Drawing.Size(23, 22);
            this.btnFileEdit.Text = "File edit";
            this.btnFileEdit.Click += new System.EventHandler(this.btnFileEdit_Click);
            // 
            // btnFilesRefresh
            // 
            this.btnFilesRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilesRefresh.Image = global::Mp3TagDirectory.Properties.Resources.action_refresh;
            this.btnFilesRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilesRefresh.Name = "btnFilesRefresh";
            this.btnFilesRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnFilesRefresh.Text = "Refrescar ficheros";
            this.btnFilesRefresh.Click += new System.EventHandler(this.btnFilesRefresh_Click);
            // 
            // btnFilesSelectAll
            // 
            this.btnFilesSelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilesSelectAll.Image = global::Mp3TagDirectory.Properties.Resources.add;
            this.btnFilesSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilesSelectAll.Name = "btnFilesSelectAll";
            this.btnFilesSelectAll.Size = new System.Drawing.Size(23, 22);
            this.btnFilesSelectAll.Text = "Select all";
            this.btnFilesSelectAll.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnFilesSelectNone
            // 
            this.btnFilesSelectNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilesSelectNone.Image = global::Mp3TagDirectory.Properties.Resources.add_minus;
            this.btnFilesSelectNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilesSelectNone.Name = "btnFilesSelectNone";
            this.btnFilesSelectNone.Size = new System.Drawing.Size(23, 22);
            this.btnFilesSelectNone.Text = "Select none";
            this.btnFilesSelectNone.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // btnShowDevice
            // 
            this.btnShowDevice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowDevice.Image = global::Mp3TagDirectory.Properties.Resources.phone;
            this.btnShowDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowDevice.Name = "btnShowDevice";
            this.btnShowDevice.Size = new System.Drawing.Size(23, 22);
            this.btnShowDevice.Text = "Mostrar pantalla dispositivo";
            this.btnShowDevice.Click += new System.EventHandler(this.btnShowDevice_Click);
            // 
            // btnShowResults
            // 
            this.btnShowResults.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowResults.Image = global::Mp3TagDirectory.Properties.Resources.application_view_detail;
            this.btnShowResults.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(23, 22);
            this.btnShowResults.Text = "Mostrar ventana de resultados";
            this.btnShowResults.Click += new System.EventHandler(this.btnShowResults_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 635);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Device Music Manager v0.2";
            this.groupDirectory.ResumeLayout(false);
            this.groupDirectory.PerformLayout();
            this.groupFile.ResumeLayout(false);
            this.groupFile.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colTipo;
        private System.Windows.Forms.ColumnHeader colFecha;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TreeView treeLocalDirectories;
        private System.Windows.Forms.GroupBox groupDirectory;
        private System.Windows.Forms.GroupBox groupFile;
        private System.Windows.Forms.Label lblFileTipo;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtSelectedFileName;
        private System.Windows.Forms.Label lblFileFecha;
        private System.Windows.Forms.Button btnModificarFileName;
        private System.Windows.Forms.Button btnModifyDirectoryName;
        private System.Windows.Forms.TextBox txtSelectedDirectory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ColumnHeader colTitulo;
        private System.Windows.Forms.ColumnHeader colAlbum;
        private System.Windows.Forms.ColumnHeader colArtista;
        private System.Windows.Forms.ColumnHeader colPista;
        private System.Windows.Forms.ColumnHeader colGenero;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSelectedFileGenero;
        private System.Windows.Forms.TextBox txtSelectedFileArtista;
        private System.Windows.Forms.TextBox txtSelectedFilePista;
        private System.Windows.Forms.TextBox txtSelectedFileAlbum;
        private System.Windows.Forms.TextBox txtSelectedFileTitle;
        private System.Windows.Forms.Button btnCancelarFileName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnFilesSelectAll;
        private System.Windows.Forms.ToolStripButton btnFilesSelectNone;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnDirectoryCreate;
        private System.Windows.Forms.ToolStripButton btnDirectoryDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnDirectoryEdit;
        private System.Windows.Forms.ToolStripButton btnFileEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripButton btnDirectoryRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnFilesRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button btnUpdateSelectedArtist;
        private System.Windows.Forms.Button btnUpdateSelectedGenero;
        private System.Windows.Forms.Button btnUpdateSelectedAlbum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnShowDevice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton btnShowResults;
    }
}

