using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mp3TagDirectory.Helpers;
using MtpSharp;

namespace Mp3TagDirectory
{
    public partial class DeviceForm : Form
    {
        public DeviceForm()
        {
            InitializeComponent();
            IntializeDevice();
        }

        public class DirectoryNode : TreeNode
        {
            //public TYPE Type { get; set; }

            public ValueType _pStorage { get; set; }
            public bool _folder { get; set; }
            public bool _datafile { get; set; }
            public bool _audiofile { get; set; }

            public bool _link { get; set; }
            public bool _canplay;
            public bool _virtualfile { get; set; }
            public bool _hidden { get; set; }
            public bool _system { get; set; }
            public bool _defaultlocation { get; set; }

            public DirectoryNode(string text)
            {
                this.Text = text;
            }

        }

        private DeviceManager manager;

        public void IntializeDevice()
        {
            manager = new DeviceManager();
            RefreshDevices();
        }

        void RefreshDevices()
        {
            cmbDevices.Items.Clear();
            foreach (Device device in manager)
                cmbDevices.Items.Add(device.Name);

            cmbDevices.SelectedIndex = 0;
        }

        #region Device Methods

        void RefreshDeviceTree()
        {

            treeDeviceDirectories.Nodes.Clear();
            foreach (Device device in manager)
            {
                treeDeviceDirectories.Nodes.Add(createTreeFromDevice(device));
            }

            TreeViewHelper.ExpandSecondNode(treeDeviceDirectories);

        }

        public DirectoryNode GetDirectoryNodeFromStorage(Storage storage)
        {
            try
            {
                var st = storage.References[0];
                //st.
                var eee = storage.References.Clone();
            }
            catch (Exception)
            {
                
               
            }
           
            

            return  new DirectoryNode(storage.ToString())
                                          {
                                              _audiofile = storage.isAudioFile(),
                                              _canplay = storage.isPlayable(),
                                              _datafile = storage.isDataFile(),
                                              _defaultlocation = storage.isDefault(),
                                              _folder = storage.isFolder(),
                                              _hidden = storage.isHidden(),
                                              _link = storage.isLink(),
                                              _system = storage.isSystem(),
                                              _virtualfile = storage.isVirtual()
                                          };    
        }

        /// <summary>
        /// Een Tree aanmaken van de storage.
        /// </summary>
        private DirectoryNode createTreeFromDevice(Device device)
        {
            DirectoryNode parent = new DirectoryNode(device.Name);

            foreach (Storage storage in device)
            {
                var child = GetDirectoryNodeFromStorage(storage);
                parent.Nodes.Add(child);
                if (storage.isFolder())
                    addChilds(child, storage);
            }

            return parent;
        }



        private void addChilds(DirectoryNode parent, Storage parentStorage)
        {
            foreach (Storage storage in parentStorage)
            {
                try
                {
                    var child = GetDirectoryNodeFromStorage(storage);
                    parent.Nodes.Add(child);
                    if (storage.isFolder())
                        addChilds(child, storage);
                }
                catch (Exception ex)
                {


                }

            }
        }

        private void btnDevicesRefresh_Click(object sender, EventArgs e)
        {
          
        }

        private void cmbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDeviceTree();
        }

        #endregion

        private void btnDeviceRefresh_Click(object sender, EventArgs e)
        {
            RefreshDevices();
        }

        private void btnRefrescarCarpetas_Click(object sender, EventArgs e)
        {
            RefreshDeviceTree();
        }

        private void treeDeviceDirectories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                var nodeSelected = (treeDeviceDirectories.SelectedNode as DirectoryNode);
                if (nodeSelected != null)
                {
                    //SetEnableDirectoryWrite(false);
                    //GetFilesInDirectory(nodeSelected.FullPath);
                    //txtSelectedDirectory.Text = nodeSelected.Text;
                }
            }
            catch (Exception)
            { }
        }

    }
}
