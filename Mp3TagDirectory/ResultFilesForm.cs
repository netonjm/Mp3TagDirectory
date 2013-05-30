using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3TagDirectory
{
    public partial class ResultFilesForm : Form
    {
        private Form1 _parentForm;

        public ResultFilesForm(Form1 mainForm )
        {
            InitializeComponent();

            _parentForm = mainForm;
        }

        public void ClearItems()
        {
            listView2.Items.Clear();
        }

        public  void AddItem(ListViewItem item)
        {
            listView2.Items.Add(item);
        }

        public  void RemoveByKey(string key)
        {
            listView2.Items.RemoveByKey(key);
        }

        public ListView.ListViewItemCollection GetItems()
        {
            return listView2.Items;
        }

        private void txtReplace_TextChanged(object sender, EventArgs e)
        {
            //listView2.Clear();
            if (txtReplaceCharFrom.Text != "")
            {
               _parentForm.ReplaceResultFilesChars(txtReplaceCharFrom.Text, txtReplaceCharTo.Text);
            }
            else
            {
                _parentForm.RefreshResultFiles();
            }

        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            //SongPath = "";
            foreach (var song in _parentForm.GetFilesItemCollection())
            {
                //ListViewItem lvi = new ListViewItem(song.Name.Substring(0, song.Name.Count() - song.Extension.Length));
                //lvi.SubItems.Add(song.Extension);
                //lvi.SubItems.Add(song.CreationTime.ToShortTimeString());
                //listView1.Items.Add(lvi);
            }
        }

        //private void txtDirectory_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void txtDirectory_Leave(object sender, EventArgs e)
        //{
        //    CheckDirectory(SongPath);
        //}

        //private void txtDirectory_Enter(object sender, EventArgs e)
        //{
        //    txtDirectory.SelectionStart = 0;
        //    txtDirectory.SelectAll();

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //string folderPath = "";
        //    var folderBrowserDialog1 = new FolderBrowserDialog();
        //    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        SongPath = folderBrowserDialog1.SelectedPath;
        //        CheckDirectory();
        //    }
        //}


        //private void txtDirectory_MouseClick(object sender, MouseEventArgs e)
        //{
        //    txtDirectory.SelectionStart = 0;
        //    txtDirectory.SelectAll();
        //}

        //private void chk_recursivo_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chk_recursivo.Checked)
        //        btnAssign.Enabled = txtAlbumName.Enabled = false;
        //    else
        //        CheckDirectory();


        //}

        //void CheckDirectory()
        //{
        //    CheckDirectory(SongPath);
        //}

        //void CheckDirectory(string directoryPath)
        //{
        //    if (directoryPath != "")
        //    {
        //        DirectoryInfo dinfo = new DirectoryInfo(directoryPath);
        //        if (dinfo.Exists)
        //        {
        //            txtAlbumName.Text = dinfo.Name;
        //            txtAlbumName.Enabled = true;
        //            btnAssign.Enabled = true;
        //        }
        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Process();
        //}
        //void ProcessRecursive()
        //{
        //    Albums.Clear();
        //    RefreshDirectories();
        //    //TagNewAlbums();
        //}

        //void ProcessSingle()
        //{
        //    TagNewAlbumToDirectory(SongPath, txtAlbumName.Text);
        //}

        //void Process()
        //{
        //    if (chk_recursivo.Checked)
        //        ProcessRecursive();
        //    else
        //        ProcessSingle();

        //    MessageBox.Show("Terminado correcto");
        //}

    }
}
