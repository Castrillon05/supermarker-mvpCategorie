namespace Supermarket_mvpCategorie.views
{
    partial class CategorieView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCategorieList = new TabPage();
            tabPageCategorieDetail = new TabPage();
            TxtCategorieId = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            BtnSave = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            BtnNew = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategorieList.SuspendLayout();
            tabPageCategorieDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(131, 37);
            label1.Name = "label1";
            label1.Size = new Size(185, 50);
            label1.TabIndex = 3;
            label1.Text = "Categorie";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategorieList);
            tabControl1.Controls.Add(tabPageCategorieDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 366);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCategorieList
            // 
            tabPageCategorieList.Controls.Add(button4);
            tabPageCategorieList.Controls.Add(button3);
            tabPageCategorieList.Controls.Add(button2);
            tabPageCategorieList.Controls.Add(BtnNew);
            tabPageCategorieList.Controls.Add(BtnSearch);
            tabPageCategorieList.Controls.Add(TxtSearch);
            tabPageCategorieList.Controls.Add(label5);
            tabPageCategorieList.Controls.Add(dataGridView1);
            tabPageCategorieList.Controls.Add(TxtCategorieId);
            tabPageCategorieList.Location = new Point(4, 29);
            tabPageCategorieList.Name = "tabPageCategorieList";
            tabPageCategorieList.Padding = new Padding(3);
            tabPageCategorieList.Size = new Size(792, 333);
            tabPageCategorieList.TabIndex = 0;
            tabPageCategorieList.Text = "CategorieList";
            tabPageCategorieList.UseVisualStyleBackColor = true;
            // 
            // tabPageCategorieDetail
            // 
            tabPageCategorieDetail.Controls.Add(button1);
            tabPageCategorieDetail.Controls.Add(BtnSave);
            tabPageCategorieDetail.Controls.Add(textBox5);
            tabPageCategorieDetail.Controls.Add(label4);
            tabPageCategorieDetail.Controls.Add(textBox4);
            tabPageCategorieDetail.Controls.Add(label3);
            tabPageCategorieDetail.Controls.Add(textBox3);
            tabPageCategorieDetail.Controls.Add(label2);
            tabPageCategorieDetail.Location = new Point(4, 29);
            tabPageCategorieDetail.Name = "tabPageCategorieDetail";
            tabPageCategorieDetail.Padding = new Padding(3);
            tabPageCategorieDetail.Size = new Size(792, 333);
            tabPageCategorieDetail.TabIndex = 1;
            tabPageCategorieDetail.Text = "CategorieDetail";
            tabPageCategorieDetail.UseVisualStyleBackColor = true;
            tabPageCategorieDetail.Click += tabPage2_Click;
            // 
            // TxtCategorieId
            // 
            TxtCategorieId.AutoSize = true;
            TxtCategorieId.Location = new Point(8, 6);
            TxtCategorieId.Name = "TxtCategorieId";
            TxtCategorieId.Size = new Size(0, 20);
            TxtCategorieId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 11);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 2;
            label2.Text = "Categorie Id";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(8, 34);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "CategorieName";
            textBox3.Size = new Size(182, 27);
            textBox3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 79);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 4;
            label3.Text = "Categorie Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(8, 99);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Categorie Id";
            textBox4.Size = new Size(318, 27);
            textBox4.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 137);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 6;
            label4.Text = "Categorie Observation";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(8, 157);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Categorie Observation";
            textBox5.Size = new Size(318, 83);
            textBox5.TabIndex = 7;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(14, 255);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 60);
            BtnSave.TabIndex = 8;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.cancel;
            button1.Location = new Point(140, 255);
            button1.Name = "button1";
            button1.Size = new Size(94, 60);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(525, 222);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 6);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 3;
            label5.Text = "Search Categorie";
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(8, 29);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(466, 27);
            TxtSearch.TabIndex = 4;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(480, 17);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(53, 50);
            BtnSearch.TabIndex = 5;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources.cerrar;
            BtnNew.Location = new Point(539, 244);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(214, 51);
            BtnNew.TabIndex = 6;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.delete;
            button2.Location = new Point(539, 187);
            button2.Name = "button2";
            button2.Size = new Size(214, 51);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.edit;
            button3.Location = new Point(539, 130);
            button3.Name = "button3";
            button3.Size = new Size(214, 51);
            button3.TabIndex = 8;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = Properties.Resources._new;
            button4.Location = new Point(539, 73);
            button4.Name = "button4";
            button4.Size = new Size(214, 51);
            button4.TabIndex = 9;
            button4.UseVisualStyleBackColor = true;
            // 
            // CategorieView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategorieView";
            Text = "Categorie Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategorieList.ResumeLayout(false);
            tabPageCategorieList.PerformLayout();
            tabPageCategorieDetail.ResumeLayout(false);
            tabPageCategorieDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageCategorieList;
        private TabPage tabPageCategorieDetail;
        private Label TxtCategorieId;
        private TextBox textBox3;
        private Label label2;
        private Button button1;
        private Button BtnSave;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button BtnNew;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label5;
    }
}