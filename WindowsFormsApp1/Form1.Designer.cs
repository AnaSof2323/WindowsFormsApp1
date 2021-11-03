
namespace WindowsFormsApp1
{
    partial class Aplicación
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aplicación));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Next = new System.Windows.Forms.Button();
            this.Previos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.cmbExtn = new System.Windows.Forms.ComboBox();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Min = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_Max1 = new System.Windows.Forms.Button();
            this.btn_Max2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acercaDelProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaDeEmergenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alb = new System.Windows.Forms.ToolStripMenuItem();
            this.directorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lblAbrir = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Header.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "25a0df9bc79f6db978028f03f4778e4c.jpg");
            this.imageList1.Images.SetKeyName(1, "descargar.jpg");
            this.imageList1.Images.SetKeyName(2, "UNPLASH.jpeg");
            this.imageList1.Images.SetKeyName(3, "pexels-photo-3814743.jpeg");
            this.imageList1.Images.SetKeyName(4, "imagenes-de-calidad-web.jpg");
            this.imageList1.Images.SetKeyName(5, "450_1000.jpg");
            this.imageList1.Images.SetKeyName(6, "descargar (1).jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 205);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(163, 313);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 1;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previos
            // 
            this.Previos.Location = new System.Drawing.Point(45, 313);
            this.Previos.Name = "Previos";
            this.Previos.Size = new System.Drawing.Size(75, 23);
            this.Previos.TabIndex = 2;
            this.Previos.Text = "Previous";
            this.Previos.UseVisualStyleBackColor = true;
            this.Previos.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Image index";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(745, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Show Files";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(302, 109);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(285, 20);
            this.txtDirectory.TabIndex = 7;
            this.txtDirectory.TextChanged += new System.EventHandler(this.txtDirectory_TextChanged);
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(302, 135);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(518, 82);
            this.lstFiles.TabIndex = 8;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            // 
            // cmbExtn
            // 
            this.cmbExtn.FormattingEnabled = true;
            this.cmbExtn.Items.AddRange(new object[] {
            "JPG",
            "PNG",
            "GIF",
            "BMP",
            "EPS",
            "SVG"});
            this.cmbExtn.Location = new System.Drawing.Point(674, 106);
            this.cmbExtn.Name = "cmbExtn";
            this.cmbExtn.Size = new System.Drawing.Size(65, 21);
            this.cmbExtn.TabIndex = 9;
            this.cmbExtn.SelectedIndexChanged += new System.EventHandler(this.cmbExtn_SelectedIndexChanged);
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Header.Controls.Add(this.btn_Min);
            this.pnl_Header.Controls.Add(this.btn_close);
            this.pnl_Header.Controls.Add(this.btn_Max1);
            this.pnl_Header.Controls.Add(this.btn_Max2);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(872, 33);
            this.pnl_Header.TabIndex = 10;
            // 
            // btn_Min
            // 
            this.btn_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Min.FlatAppearance.BorderSize = 0;
            this.btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Min.Location = new System.Drawing.Point(664, 5);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(47, 23);
            this.btn_Min.TabIndex = 14;
            this.btn_Min.Text = "__";
            this.btn_Min.UseVisualStyleBackColor = true;
            this.btn_Min.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_close
            // 
            this.btn_close.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(813, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(47, 23);
            this.btn_close.TabIndex = 13;
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_Max1
            // 
            this.btn_Max1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Max1.FlatAppearance.BorderSize = 0;
            this.btn_Max1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Max1.Image = ((System.Drawing.Image)(resources.GetObject("btn_Max1.Image")));
            this.btn_Max1.Location = new System.Drawing.Point(708, 5);
            this.btn_Max1.Name = "btn_Max1";
            this.btn_Max1.Size = new System.Drawing.Size(47, 23);
            this.btn_Max1.TabIndex = 12;
            this.btn_Max1.UseVisualStyleBackColor = true;
            this.btn_Max1.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Max2
            // 
            this.btn_Max2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Max2.FlatAppearance.BorderSize = 0;
            this.btn_Max2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Max2.Image = ((System.Drawing.Image)(resources.GetObject("btn_Max2.Image")));
            this.btn_Max2.Location = new System.Drawing.Point(761, 5);
            this.btn_Max2.Name = "btn_Max2";
            this.btn_Max2.Size = new System.Drawing.Size(47, 23);
            this.btn_Max2.TabIndex = 11;
            this.btn_Max2.UseVisualStyleBackColor = true;
            this.btn_Max2.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDelProgramaToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.alb,
            this.directorioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(227, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acercaDelProgramaToolStripMenuItem
            // 
            this.acercaDelProgramaToolStripMenuItem.Name = "acercaDelProgramaToolStripMenuItem";
            this.acercaDelProgramaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.acercaDelProgramaToolStripMenuItem.Text = "About";
            this.acercaDelProgramaToolStripMenuItem.Click += new System.EventHandler(this.acercaDelProgramaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salidaDeEmergenciasToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ayudaToolStripMenuItem.Text = "Help";
            // 
            // salidaDeEmergenciasToolStripMenuItem
            // 
            this.salidaDeEmergenciasToolStripMenuItem.Name = "salidaDeEmergenciasToolStripMenuItem";
            this.salidaDeEmergenciasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salidaDeEmergenciasToolStripMenuItem.Text = "Emergency exit ";
            this.salidaDeEmergenciasToolStripMenuItem.Click += new System.EventHandler(this.salidaDeEmergenciasToolStripMenuItem_Click);
            // 
            // alb
            // 
            this.alb.Name = "alb";
            this.alb.Size = new System.Drawing.Size(56, 20);
            this.alb.Text = "Photos";
            this.alb.Click += new System.EventHandler(this.álbumDeFotosToolStripMenuItem_Click);
            // 
            // directorioToolStripMenuItem
            // 
            this.directorioToolStripMenuItem.Name = "directorioToolStripMenuItem";
            this.directorioToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.directorioToolStripMenuItem.Text = "Directory";
            this.directorioToolStripMenuItem.Click += new System.EventHandler(this.directorioToolStripMenuItem_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(303, 237);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 12;
            this.btnAbrir.Text = "Open";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lblAbrir
            // 
            this.lblAbrir.AutoSize = true;
            this.lblAbrir.Location = new System.Drawing.Point(311, 275);
            this.lblAbrir.Name = "lblAbrir";
            this.lblAbrir.Size = new System.Drawing.Size(0, 13);
            this.lblAbrir.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(417, 238);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Save";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblSalvar
            // 
            this.lblSalvar.AutoSize = true;
            this.lblSalvar.Location = new System.Drawing.Point(311, 288);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(0, 13);
            this.lblSalvar.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(720, 237);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(745, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Open";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(745, 407);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Aplicación
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(872, 442);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblAbrir);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.cmbExtn);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Previos);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aplicación";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Header.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Previos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.ComboBox cmbExtn;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Max2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_Max1;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDelProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaDeEmergenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alb;
        private System.Windows.Forms.ToolStripMenuItem directorioToolStripMenuItem;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lblAbrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}

