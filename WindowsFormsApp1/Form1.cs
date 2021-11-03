using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Aplicación : Form
    {
        Image File;
        public Aplicación()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(count > 0)
            { 
                count--;
            }
            label1.Text = (count + 1).ToString();
            pictureBox1.Image = imageList1.Images[count];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int count = -1;
        private void Next_Click(object sender, EventArgs e)
        {
            if(count<6)
            { 
            count++;
            }
            label1.Text = (count + 1).ToString();
            pictureBox1.Image = imageList1.Images[count];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowDialog();
            txtDirectory.Text = dlg.SelectedPath;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          var files=  System.IO.Directory.GetFiles(txtDirectory.Text, "*."+cmbExtn.Text, System.IO.SearchOption.AllDirectories);
            lstFiles.DataSource = files;
            MessageBox.Show(files.Count() + "files found");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btn_Max1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btn_Max2.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void acercaDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Es un programa para la clase de periféricos. Es sobre el capítulo 6. Es muy sencillo de hacer solo sigue viendo.");

        }

        private void salidaDeEmergenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void álbumDeFotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDirectory.Enabled = false;
            button1.Enabled = false;
            cmbExtn.Enabled = false;
            lstFiles.Enabled = false;
            button2.Enabled = false;
            pictureBox1.Enabled = true;
            Next.Enabled = true;
            Previos.Enabled = true;
            label1.Enabled = true;
            label2.Enabled = true;
        }

        private void directorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            Next.Enabled = false;
            Previos.Enabled = false;
            label1.Enabled = false;
            label2.Enabled = false;
            txtDirectory.Enabled = true;
            button1.Enabled = true;
            cmbExtn.Enabled = true;
            lstFiles.Enabled = true;
            button2.Enabled = true;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblAbrir.Text = openFileDialog1.FileName;

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblSalvar.Text = saveFileDialog1.FileName;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pictureBox2.Image = File;
            }
            {

            };
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                File.Save(f.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void cmbExtn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDirectory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
