using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileRenamePro
{
    public partial class FileRenameForm : Form
    {
        string[] fileNames, renewFileNames;
        public FileRenameForm()
        {
            InitializeComponent();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.ClearItems();

            fileNames = openFileDialog1.FileNames;
            renewFileNames = new string[openFileDialog1.FileNames.Length];
            listBoxFiles.Items.AddRange(fileNames);            
        }

        private void BtnFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void BtnOnbellekTemizle_Click(object sender, EventArgs e)
        {
            this.ClearItems();
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtFileName.Text))
            {
                MessageBox.Show("İfade alanı boş bırakılamaz!", "Geçersiz İfade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(listBoxFiles.Items.Count == 0)
            {
                MessageBox.Show("Dosya seçimi yapmadınız!", "Dosya Seçimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(rbInsertPre.Checked)
            {
                for (int i = 0; i < fileNames.Length; i++)
                {
                    string txt = fileNames[i].Split('.')[0].Split('\\')[fileNames[i].Split('.')[0].Split('\\').Length - 1] + "." + fileNames[i].Split('.')[1];
                    string klasorAdi = fileNames[i].Remove(fileNames[i].IndexOf(txt));
                    txt = txtFileName.Text + txt;
                    renewFileNames[i] = klasorAdi + txt ;                    
                }
                listBoxFiles.Items.Clear();
                listBoxFiles.Items.AddRange(renewFileNames);
            }
            else if(rbInsertEnd.Checked)
            {
                for (int i = 0; i < fileNames.Length; i++)
                {
                    renewFileNames[i] = fileNames[i].Split('.')[0] + txtFileName.Text + "." +fileNames[i].Split('.')[1];
                }
                listBoxFiles.Items.Clear();
                listBoxFiles.Items.AddRange(renewFileNames);
            }
            else
            {
                MessageBox.Show("Eklenecek ifade konumu seçmediniz !", "Önüne / Sonuna", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < renewFileNames.Length; i++)
            {
                File.Move(fileNames[i], renewFileNames[i]);
            }

            MessageBox.Show("Dosya adı değiştirme işlemleri başarı ile tamamlandı", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.ClearItems();
        }

        private void ClearItems()
        {
            listBoxFiles.Items.Clear();
            fileNames = renewFileNames = null;
            this.txtFileName.Text = string.Empty;
        }

    }
}
