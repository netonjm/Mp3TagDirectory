namespace Mp3TagDirectory
{
    partial class DeviceForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.treeDeviceDirectories = new System.Windows.Forms.TreeView();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDeviceRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescarCarpetas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.treeDeviceDirectories);
            this.groupBox3.Controls.Add(this.cmbDevices);
            this.groupBox3.Location = new System.Drawing.Point(12, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 347);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Device";
            // 
            // treeDeviceDirectories
            // 
            this.treeDeviceDirectories.AllowDrop = true;
            this.treeDeviceDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeDeviceDirectories.FullRowSelect = true;
            this.treeDeviceDirectories.HideSelection = false;
            this.treeDeviceDirectories.Location = new System.Drawing.Point(6, 46);
            this.treeDeviceDirectories.Name = "treeDeviceDirectories";
            this.treeDeviceDirectories.Size = new System.Drawing.Size(331, 295);
            this.treeDeviceDirectories.TabIndex = 23;
            this.treeDeviceDirectories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDeviceDirectories_AfterSelect);
            // 
            // cmbDevices
            // 
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(6, 19);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(176, 21);
            this.cmbDevices.TabIndex = 22;
            this.cmbDevices.SelectedIndexChanged += new System.EventHandler(this.cmbDevices_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeviceRefresh,
            this.toolStripSeparator1,
            this.btnRefrescarCarpetas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(367, 25);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDeviceRefresh
            // 
            this.btnDeviceRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeviceRefresh.Image = global::Mp3TagDirectory.Properties.Resources.action_refresh;
            this.btnDeviceRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeviceRefresh.Name = "btnDeviceRefresh";
            this.btnDeviceRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnDeviceRefresh.Text = "Refrescar devices";
            this.btnDeviceRefresh.Click += new System.EventHandler(this.btnDeviceRefresh_Click);
            // 
            // btnRefrescarCarpetas
            // 
            this.btnRefrescarCarpetas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefrescarCarpetas.Image = global::Mp3TagDirectory.Properties.Resources.action_refresh;
            this.btnRefrescarCarpetas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefrescarCarpetas.Name = "btnRefrescarCarpetas";
            this.btnRefrescarCarpetas.Size = new System.Drawing.Size(23, 22);
            this.btnRefrescarCarpetas.Text = "Refrescar carpetas";
            this.btnRefrescarCarpetas.Click += new System.EventHandler(this.btnRefrescarCarpetas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 395);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Name = "DeviceForm";
            this.Text = "Device Data Manager";
            this.groupBox3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView treeDeviceDirectories;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDeviceRefresh;
        private System.Windows.Forms.ToolStripButton btnRefrescarCarpetas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}