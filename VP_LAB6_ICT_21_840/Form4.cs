using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_LAB6_ICT_21_840
{
    public partial class Form4 : Form
    {
        private string filePath = "";
        private bool isFile = false;
        private string currentlySelectedItemName = "";
        public Form4()
        {
            InitializeComponent();
            txtPath.Text = filePath;
            loadFilesAndDirectories();
        }

        public void loadFilesAndDirectories()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;
            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    lblFileName.Text = fileDetails.Name;
                    lblFileType.Text = fileDetails.Extension;
                    fileAttr = File.GetAttributes(filePath);
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = tempFilePath;
                    startInfo.UseShellExecute = true;
                    Process.Start(startInfo);

                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);
                    lblFileName.Text = "...";
                    lblFileType.Text = "...";

                }
                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {

                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles();
                    DirectoryInfo[] dirs = fileList.GetDirectories();
                    string fileExtension = "";
                    listView1.Items.Clear();

                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();
                        switch (fileExtension)
                        {
                            case ".MP3":
                            case ".MP2":
                                listView1.Items.Add(files[i].Name, 4);
                                break;
                            case ".EXE":
                            case ".COM":
                                listView1.Items.Add(files[i].Name, 2);
                                break;

                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                listView1.Items.Add(files[i].Name, 3);
                                break;
                            case ".PDF":
                                listView1.Items.Add(files[i].Name, 5);
                                break;
                            case ".DOC":
                            case ".DOCX":
                                listView1.Items.Add(files[i].Name, 6);
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                listView1.Items.Add(files[i].Name, 1);
                                break;

                            default:
                                listView1.Items.Add(files[i].Name, 8);
                                break;
                        }
                    }

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name, 9);
                    }

                }
                else
                {
                    txtPath.Text = this.currentlySelectedItemName;
                    lblFileName.Text = "...";
                    lblFileType.Text = "...";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
        public void loadButtonAction()
        {
            removeBackSlash();
            filePath = txtPath.Text;
            loadFilesAndDirectories();
            isFile = false;
        }
        public void removeBackSlash()
        {
            string path = txtPath.Text;
            if (path.LastIndexOf("/") == path.Length - 1)
            {
                txtPath.Text = path.Substring(0, path.Length - 1);
            }
        }

        public void goBack()
        {
            try
            {
                removeBackSlash();
                string path = txtPath.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                this.isFile = false;
                txtPath.Text = path;
                removeBackSlash();
            }
            catch (Exception e)
            {

            }
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = filePath;
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    string convertedPath = selectedPath.Replace("\\", "/");
                    txtPath.Text = convertedPath;
                    filePath = convertedPath;
                    loadButtonAction();
                }
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;
            FileAttributes fileAttr = File.GetAttributes(filePath + "/" + currentlySelectedItemName);
            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                txtPath.Text = filePath + "/" + currentlySelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            goBack();
            loadButtonAction();
        }
    }
}
