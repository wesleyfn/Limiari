using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limiari
{
    public partial class FormMain : Form
    {
        int imgSelected;
        bool hasImagem = false;
        TreeNode imgNode;
        Bitmap[] arrayImage;

        public FormMain()
        {
            InitializeComponent();
        }
        private void formMain_Load(object sender, EventArgs e)
        {
        }
        private void menuOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PNG (*.png) | *.png";
                ofd.Multiselect = true;
                if (DialogResult.OK == ofd.ShowDialog())
                {
                    treeImagens.Nodes.Clear();
                    string[] imgName = ofd.SafeFileNames;
                    string[] imgDiretory = ofd.FileNames;
                    
                    arrayImage = new Bitmap[imgDiretory.Length];
                    imgNode = treeImagens.Nodes.Add("Imagens");
                    imgNode.Tag = ofd.InitialDirectory;

                    for (int i = 0; i < imgDiretory.Length; i++)
                    {
                        arrayImage[i] = new Bitmap(imgDiretory[i]);
                        arrayImage[i].Tag = imgDiretory[i];
                        imgNode.Nodes.Add(imgName[i]);
                    }
                    boxPicture.Image = arrayImage[0];
                    StatusInfo(ofd.SafeFileName);
                    hasImagem = true;
                } 
            }
        }
        private void menuGray_Click(object sender, EventArgs e)
        {
            if (hasImagem)
            {
                foreach (TreeNode checkedImg in imgNode.Nodes)
                {
                    if (checkedImg.Checked)
                    {
                        int index = checkedImg.Index;
                        Bitmap selected = arrayImage[index];
                        Processing processingType = new Processing();

                        barProgress.Value++;
                        processingType.GrayScale(selected);
                        boxPicture.Image = selected;

                        ImageSave(checkedImg.Index, "-gray.png");

                        boxPicture.Refresh();
                    }
                }
                barProgress.Value = 0;
            }
        }
        private void edgeSobel_Click(object sender, EventArgs e)
        {
            if (hasImagem)
            {
                foreach (TreeNode checkedImg in imgNode.Nodes)
                {
                    if (checkedImg.Checked)
                    {
                        int index = checkedImg.Index;
                        Bitmap selected = arrayImage[index];
                        Processing processingType = new Processing();

                        barProgress.Value++;
                        processingType.SobelEdge(selected);
                        boxPicture.Image = selected;

                        ImageSave(checkedImg.Index, "-sob.png");
                        boxPicture.Refresh();
                    }
                }
                barProgress.Value = 0;
            }
        }
        private void edgeRobert_Click(object sender, EventArgs e)
        {
            if (hasImagem)
            {
                foreach (TreeNode checkedImg in imgNode.Nodes)
                {
                    if (checkedImg.Checked)
                    {
                        int index = checkedImg.Index;
                        Bitmap selected = arrayImage[index];
                        Processing processingType = new Processing();

                        barProgress.Value++;
                        processingType.RobertEdge(selected);
                        boxPicture.Image = selected;

                        ImageSave(checkedImg.Index, "-rob.png");

                        boxPicture.Refresh();
                    }
                }
                barProgress.Value = 0;
            }
        }
        private void menuNegative_Click(object sender, EventArgs e)
        {
            if (hasImagem)
            {
                foreach (TreeNode checkedImg in imgNode.Nodes)
                {
                    if (checkedImg.Checked)
                    {
                        int index = checkedImg.Index;
                        Bitmap selected = arrayImage[index];
                        Processing processingType = new Processing();

                        barProgress.Value++;
                        processingType.NegativeScale(selected);
                        boxPicture.Image = selected;

                        ImageSave(checkedImg.Index, "-neg.png");
                        boxPicture.Refresh();
                    }
                }
                barProgress.Value = 0;
            }
        }
        private void menuAbout_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void treeImagens_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != imgNode)
            {
                imgSelected = e.Node.Index;
                boxPicture.Image = arrayImage[imgSelected];
                StatusInfo(e.Node.Text);
            }
        }
        private void StatusInfo(string name = "")
        {
            string h = Convert.ToString(boxPicture.Image.Height);
            string w = Convert.ToString(boxPicture.Image.Width);
            lblNameString.Text = "Name: " + name;
            lblSizeNum.Text = "Size: " + w + "x" + h + "px";
        }
        private void treeImagens_AfterCheck(object sender, TreeViewEventArgs e)
        {
            int max = 0;
            if (e.Node == imgNode)
            {
                foreach (TreeNode child in imgNode.Nodes)
                {  
                    child.Checked = imgNode.Checked == true ? true : false;
                    max++;
                }
            }
            else
            {
                foreach (TreeNode child in imgNode.Nodes)
                {
                    if (child.Checked) max++;
                }
                lblProgressNum.Text = "Sel: " + max.ToString();
                barProgress.Maximum = max;
            }
        }
        private void quant_Click(object sender, EventArgs e)
        {
            if (hasImagem)
            {
                foreach (TreeNode checkedImg in imgNode.Nodes)
                {
                    if (checkedImg.Checked)
                    {
                        int index = checkedImg.Index;
                        Bitmap selected = arrayImage[index];
                        Processing processingType = new Processing();

                        barProgress.Value++;
                        processingType.Quantization(selected, 2);
                        boxPicture.Image = selected;

                        ImageSave(checkedImg.Index, "-quant.png");
                        boxPicture.Refresh();
                    }
                }
                barProgress.Value = 0;
            }
        }
        public void ImageSave(int index, string type)
        {
            string outName = Convert.ToString(arrayImage[index].Tag);
            imgNode.Nodes[index].Text = outName.Substring(outName.LastIndexOf("\\")+1).Replace(".png", type);
            using (MemoryStream memory = new MemoryStream())
            {
                using (FileStream fs = new FileStream(outName.Replace(".png", type), FileMode.Create, FileAccess.ReadWrite))
                {
                    arrayImage[index].Save(memory, ImageFormat.Png);
                    byte[] bytes = memory.ToArray();
                    fs.Write(bytes, 0, bytes.Length);
                }
            }
        }
        private void lblSizeNum_Click(object sender, EventArgs e)
        {

        }
        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormManual().Show();
        }
    }  
}
