using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MtpSharp;
using Mp3TagDirectory.Helpers;

namespace Mp3TagDirectory
{
    public partial class Form1 : Form
    {


        public bool IsFilenameWriting = false;

        private TreeNode tn; 

        //public List<DirectoryAlbum> Albums { get; set; }
        public string SongPath =  @"D:\Personal\Mi Musica";

        private ResultFilesForm resultFilesForm;

        private DeviceForm deviceForm;

        public class DirectoryAlbum : TreeNode
        {

            private DirectoryInfo directory = null;

            public DirectoryAlbum(string fullPath)
            {
                directory = new DirectoryInfo(fullPath);
               this.ToolTipText = this.Text = FileName;
            }

            public string FullPath
            {
                get { return directory.FullName; }
            }

            public string FileName
            {
                get { return directory.Name; }
            }

            public string[] GetDirectories()
            {
                return System.IO.Directory.GetDirectories(FullPath);
            }

        }

        public int temporalId = 0;


        public Form1()
        {
            InitializeComponent();
            
            IntializeObjects();
          
            //Albums = new List<DirectoryAlbum>();


            RefreshDirectories();

        }

        public void IntializeObjects()
        {

            //var storageDevice = Windows.Devices.Portable.StorageDevice;

            deviceForm= new DeviceForm();
          
            //Panel de resultados
            resultFilesForm = new ResultFilesForm(this);
           

        }

     

      



        public string GetSActualIdAndSetNext()
        {
            return "tmp" + temporalId++;
        }

        void GetFilesInDirectory(string directory)
        {

            DirectoryInfo tmp = new DirectoryInfo(directory);
            
            var files =
                tmp.GetFiles().Where(
                    file => file.Extension.ToLower().EndsWith(".mp3") || file.Extension.ToLower().EndsWith(".wma") || file.Extension.ToLower().EndsWith(".wav")).
                    ToArray();

            listView1.Items.Clear();

            resultFilesForm.ClearItems();
            
            foreach (var song in files)
            {

                using (var f = TagLib.File.Create(song.FullName))
                {

                ListViewItem lvi = new ListViewItem(song.Name.Substring(0, song.Name.Count() - song.Extension.Length));
                lvi.SubItems.Add(song.Extension);
                lvi.SubItems.Add(song.CreationTime.ToShortTimeString());

                try
                {
                    lvi.SubItems.Add(f.Tag.Title);
                }
                catch (Exception)
                {
                    lvi.SubItems.Add("");
                }
                    
                try
                {
                    lvi.SubItems.Add(f.Tag.Album);
                }
                catch (Exception)
                {
                    lvi.SubItems.Add("");
                }

                try
                {
                    lvi.SubItems.Add(f.Tag.AlbumArtists[0]);
                }
                catch (Exception)
                {
                    lvi.SubItems.Add("");
                }


                try
                {
                    lvi.SubItems.Add(f.Tag.Track.ToString());
                }
                catch (Exception)
                {
                    lvi.SubItems.Add("");
                }

                try
                {
                    lvi.SubItems.Add(f.Tag.FirstGenre );
                }
                catch (Exception)
                {
                    lvi.SubItems.Add("");
                }

                listView1.Items.Add(lvi);
                }



            }

        }

        #region Process Recursive

        void RefreshDirectories()
        {

            DirectoryAlbum tmp = new DirectoryAlbum(SongPath);
            temporalId = 0;
            tmp.Name = GetSActualIdAndSetNext();
            temporalId++;
            CheckRecursiveDirectory(ref tmp);

            treeLocalDirectories.Nodes.Clear();

            treeLocalDirectories.Nodes.Add(tmp);

            TreeViewHelper.ExpandFirstNode(treeLocalDirectories);

        }

        void CheckRecursiveDirectory(ref DirectoryAlbum parent)
        {
            DirectoryAlbum tmp;
            foreach (var dir in parent.GetDirectories())
            {
                tmp = new DirectoryAlbum(dir);
                tmp.Name = GetSActualIdAndSetNext();

                //Añadimos el album al array
                //Albums.Add(tmp);
                
                //Añadimos el album al nodetree si no es null
                if (parent != null)
                    parent.Nodes.Add(tmp);

                //comprobamos si existen más
                CheckRecursiveDirectory(ref tmp);
            }
        }

        //void TagNewAlbums()
        //{
        //    foreach (var album in Albums)
        //    {
        //        TagNewAlbumToDirectory(album);
        //    }
        //}

        #endregion

        #region Process Single

        static void TagNewAlbumToDirectory(string directoryPath, string albumName)
        {
            foreach (var file in System.IO.Directory.GetFiles(directoryPath, "*.mp3"))
            {
                TagNewAlbumToFile(file, albumName);
            }

        }

        #endregion

        #region Tag Album Common

        static void TagNewAlbumToDirectory(DirectoryAlbum album)
        {
            TagNewAlbumToDirectory(album.FullPath, album.FileName);
        }

        static void TagNewAlbumToFile(string filePath, string albumName)
        {
            try
            {

                using (var f = TagLib.File.Create(filePath))
                {
                    f.Tag.Album = albumName;
                    f.Save();
                }

            }
            catch(Exception) { 

            }
        }

        #endregion

        #region Form Events

    


        #endregion

        void RefreshFiles()
        {
             try
             {
                 var nodeSelected = (treeLocalDirectories.SelectedNode as DirectoryAlbum);
                 if (nodeSelected != null)
                 {
                     SetEnableDirectoryWrite(false);
                     GetFilesInDirectory(nodeSelected.FullPath);
                     txtSelectedDirectory.Text = nodeSelected.Text;
                 }
             } 
             catch (Exception)
             { }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
                  
            RefreshFiles();
           
                //txtName.Text = "";
                //txtParentName.Text = "";
                //txtText.Text = "";
                //txtTag.Text = "";
               
                //txtName.Text = treeView1.SelectedNode.Name.ToString();
                //txtText.Text = treeView1.SelectedNode.Text.ToString();
                //txtTag.Text = treeView1.SelectedNode.Tag.ToString();
                //txtParentName.Text = treeView1.SelectedNode.Parent.Text.ToString();
          
        }

        void SetEnableFileWrite(bool active)
        {
            if (groupFile.Enabled)
            {
                btnModificarFileName.Enabled = btnCancelarFileName.Enabled =
                    btnUpdateSelectedArtist.Enabled = btnUpdateSelectedAlbum.Enabled = btnUpdateSelectedGenero.Enabled=
                    txtSelectedFileName.Enabled =
                    txtSelectedFileTitle.Enabled =
                    txtSelectedFilePista.Enabled =
                    txtSelectedFileArtista.Enabled =
                    txtSelectedFileAlbum.Enabled =
                    txtSelectedFileGenero.Enabled = 
                    active;

                if (active)
                    txtSelectedFileName.Focus();
            }
           
        }

        void SetEnableDirectoryWrite(bool active)
        {
            if (groupDirectory.Enabled)
            {
                btnModifyDirectoryName.Enabled = txtSelectedDirectory.Enabled = active;

                if (active)
                    txtSelectedDirectory.Focus();
            }

        }
        

        void SelectAllFiles(bool value)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Selected = value;
            }
        }
     

        #region DRAG AND DROP

           private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listView1.DoDragDrop(listView1.SelectedItems, DragDropEffects.Move);
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
         
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {

        }


        private void listView1_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            e.UseDefaultCursors = false;
            if ((e.Effect & DragDropEffects.Move) == DragDropEffects.Move)
                Cursor.Current = Cursors.Hand;
            else
                Cursor.Current = Cursors.Default;
        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
           
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListView.SelectedListViewItemCollection)))
                e.Effect = DragDropEffects.Move;
        }
    
        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {

            Point loc = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
            TreeNode destNode = ((TreeView)sender).GetNodeAt(loc);
            //TreeNode tnNew;

            ListView.SelectedListViewItemCollection lstViewColl =
                (ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(ListView.SelectedListViewItemCollection));
            foreach (ListViewItem lvItem in lstViewColl)
            {

                //tnNew = new TreeNode(lvItem.Text);
                //tnNew.Tag = lvItem;

                //destNode.Nodes.Insert(destNode.Index + 1, tnNew);
                //destNode.Expand();
                // Remove this line if you want to only copy items
                // from ListView and not move them

                if (lvItem.Selected)
                lvItem.Remove();

               

            }
            resultFilesForm.ClearItems();
            //listView2.Items.Clear();
        }



        #endregion


        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (e.Item!=null)
            {
                SetEnableFileGroups();

                SetEnableFileWrite(false);
               
                txtSelectedFileName.Text = e.Item.Text;
                lblFileFecha.Text = "Created at: " + e.Item.SubItems[2].Text;
                lblFileTipo.Text = "Filetype: " + e.Item.SubItems[1].Text;
                txtSelectedFileTitle.Text = e.Item.SubItems[3].Text;
                txtSelectedFileArtista.Text = e.Item.SubItems[5].Text;
                txtSelectedFileAlbum.Text = e.Item.SubItems[4].Text;
                txtSelectedFilePista.Text = e.Item.SubItems[6].Text;
                txtSelectedFileGenero.Text = e.Item.SubItems[7].Text;

                if (e.IsSelected)
                {
                    var tmp = (ListViewItem)e.Item.Clone();
                    tmp.Name = e.Item.Index.ToString();
                    resultFilesForm.AddItem(tmp);
                }
                else
                {
                    resultFilesForm.RemoveByKey(e.Item.Index.ToString());
                }

            }

        }

        void SetEnableFileGroups()
        {
           groupFile.Enabled = (listView1.SelectedItems.Count == 1);
           if (listView1.SelectedItems.Count>0)
           {
               
           }
        }


        void EnableGroupTools(bool active)
        {

           // utilitiesForm.EnableGroupTools(active);
        }

        private void treeLocalDirectories_Enter(object sender, EventArgs e)
        {
            groupDirectory.Enabled = true;
            groupFile.Enabled = false;
        }

        private void listView1_Enter(object sender, EventArgs e)
        {
            groupDirectory.Enabled = false;
            groupFile.Enabled = true;

            SetEnableFileGroups();
        }

    
   

        private void btnModificarTittle_Click(object sender, EventArgs e)
        {
            UpdateFileData();
        }

        void UpdateFileData()
        {
            var fileRenamed = GetRenamedItemFullPath();
            var fileOriginal = GetSelectedItemFullPath();

            RenameSelectedFile(fileOriginal, fileRenamed);
            UpdateMp3Tags(fileOriginal, txtSelectedFileTitle.Text, txtSelectedFileArtista.Text, txtSelectedFileAlbum.Text, txtSelectedFileGenero.Text, txtSelectedFilePista.Text);

            CancelFileData();
        }
        void CancelFileData()
        {
            RefreshFiles();
            SetEnableFileWrite(false);
        }

        string GetSelectedDirectoryFullPath()
        {
            var nodeSelected = (treeLocalDirectories.SelectedNode as DirectoryAlbum);
            if (nodeSelected != null)
                return nodeSelected.FullPath;
            return "";
        }

        string GetSelectedItemFullPath()
        {
            var selectedDirectory = GetSelectedDirectoryFullPath();
            if (!String.IsNullOrEmpty(selectedDirectory ))
            {
                var selected = listView1.FocusedItem;
                 if (selected!=null)
                     return selectedDirectory + @"\" + selected.SubItems[0].Text + selected.SubItems[1].Text;
            }
            return "";
        }

        string GetRenamedItemFullPath()
        {
            var selectedDirectory = GetSelectedDirectoryFullPath();
            if (!String.IsNullOrEmpty(selectedDirectory))
            {
                var selected = listView1.FocusedItem;
                if (selected!=null)
                    return selectedDirectory + @"\" + txtSelectedFileName.Text + selected.SubItems[1].Text;
            }
            return "";
        }

        void RenameSelectedFile()
        {
            var fileRenamed = GetRenamedItemFullPath();
            var fileOriginal = GetSelectedItemFullPath();
            RenameSelectedFile(fileOriginal, fileRenamed);
        }

        void RenameSelectedFile(string fileOriginal,string fileRenamed )
        {
          
            if (fileRenamed != fileOriginal)
            {
                if (!String.IsNullOrEmpty(fileOriginal) && !String.IsNullOrEmpty(fileRenamed))
                    System.IO.File.Move(fileOriginal, fileRenamed);

            
            }
            
        }

        void DeleteSelectedDirectory()
        {

            var selectedDirectory = GetSelectedDirectoryFullPath();
            if (!String.IsNullOrEmpty(selectedDirectory))
               {
                   if (
                       MessageBox.Show("Desea eliminar el directorio '" + selectedDirectory + "'? SE ELIMINARAN TODOS LAS CARPETAS Y SUBCARPETAS QUE EXISTAN", "Atencion", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Exclamation) == DialogResult.Yes)
                   {

                       System.IO.Directory.Delete(selectedDirectory,true);
                   }
               }
            RefreshDirectories();
            SetEnableFileWrite(false);
        }

        void DeleteSelectedFile()
        {

            var fileOriginal = GetSelectedItemFullPath();
            if (!String.IsNullOrEmpty(fileOriginal))
            {
                if (MessageBox.Show("Desea eliminar el fichero '" + fileOriginal + "' ?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    System.IO.File.Delete(fileOriginal);
                }

            }
            RefreshFiles();
            SetEnableFileWrite(false);
        }

        public  System.Windows.Forms.ListView.ListViewItemCollection GetFilesItemCollection()
        {
            return listView1.Items;
        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                SetEnableDirectoryWrite(true);

             
            }
            else if (e.KeyCode == Keys.F5)
            {
                RefreshDirectories();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedDirectory();
            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                SetEnableFileWrite(true);

            }else   if (e.KeyCode == Keys.F5)

            {
                RefreshFiles();
            }

            else if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedFile();
            }
            else if (e.KeyCode == Keys.E && e.Modifiers == Keys.Control)
            {
                SelectAllFiles(true);
            }
            else if (e.KeyCode == Keys.M && e.Modifiers == Keys.Control)
            {
                SelectAllFiles(false);
            }
          
        }

        private void btnModifyDirectoryName_Click(object sender, EventArgs e)
        {

            RefreshDirectories();
            SetEnableDirectoryWrite(false);
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = "explorer.exe",
                UseShellExecute = true,
                Verb = "open", Arguments = GetSelectedDirectoryFullPath()
            });
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = "explorer.exe",
                UseShellExecute = true,
                Verb = "open",
                Arguments =  GetSelectedItemFullPath()
            });
        }

        public void RefreshResultFiles()
        {
            resultFilesForm.ClearItems();
           
            foreach (ListViewItem e in listView1.SelectedItems)
            {
                var tmp = (ListViewItem)e.Clone();
                tmp.Name = e.Index.ToString();
                resultFilesForm.AddItem(tmp);
            }
        }

        public void ReplaceResultFilesChars(string from, string to)
        {
            foreach (ListViewItem item in resultFilesForm.GetItems())
            {
                item.SubItems[0].Text = listView1.Items[Convert.ToInt32(item.Name)].SubItems[0].Text.Replace(from,to);
            }
        }
       
        static void UpdateMp3Tags(string filePath, string title, string albumArtists, string album, string firstGenre, string track  )
        {
            try
            {

                //f.Tag.Title);
                //f.Tag.Album);
                //f.Tag.AlbumArtists[0]);
                //f.Tag.Track.ToString());
                //f.Tag.FirstGenre );

                //  txtSelectedFileTitle.Text = e.Item.SubItems[3].Text;
                //txtSelectedFileArtista.Text = e.Item.SubItems[5].Text;
                //txtSelectedFileAlbum.Text = e.Item.SubItems[4].Text;
                //txtSelectedFilePista.Text = e.Item.SubItems[6].Text;
                //txtSelectedFileGenero.Text = e.Item.SubItems[7].Text;

                using (var f = TagLib.File.Create(filePath))
                {
                    if (!String.IsNullOrEmpty(albumArtists))
                    f.Tag.AlbumArtists = new string[] {albumArtists};
                    if (!String.IsNullOrEmpty(album))
                    f.Tag.Album = album;
                    if (!String.IsNullOrEmpty(title))
                    f.Tag.Title = title;
                    if (!String.IsNullOrEmpty(firstGenre))
                    f.Tag.Genres = new string[] { firstGenre };
                    if (!String.IsNullOrEmpty(track))
                    {
                        try
                        {
                            f.Tag.Track = uint.Parse(track);
                        }
                        catch (Exception)
                        {
                        }
                    }
                   
                    f.Save();
                }

            }
            catch (Exception)
            {

            }
        }

        private void txtSelectedFile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                CancelFileData();
            }
        }

        private void btnCancelarFileName_Click(object sender, EventArgs e)
        {
            CancelFileData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SelectAllFiles(true);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SelectAllFiles(false);
        }

        private void btnDirectoryDelete_Click(object sender, EventArgs e)
        {
          
                DeleteSelectedDirectory();
          
        }

        private void btnDirectoryEdit_Click(object sender, EventArgs e)
        {
                SetEnableDirectoryWrite(true);
        }

        private void btnFileEdit_Click(object sender, EventArgs e)
        {
            SetEnableFileWrite(true);
        }

        private void btnDirectoryRefresh_Click(object sender, EventArgs e)
        {
            RefreshDirectories();
        }

        private void btnFilesRefresh_Click(object sender, EventArgs e)
        {
            RefreshFiles();
        }

     

        private void btnShowDevice_Click(object sender, EventArgs e)
        {
            btnShowDevice.Checked = !btnShowDevice.Checked;
            if (btnShowDevice.Checked)
                deviceForm.Show();
            else
            deviceForm.Hide();
        }

        private void btnShowResults_Click(object sender, EventArgs e)
        {

            btnShowResults.Checked = !btnShowResults.Checked;
            if (btnShowResults.Checked)
                resultFilesForm.Show();
            else
                resultFilesForm.Hide();

        }


    }
}
