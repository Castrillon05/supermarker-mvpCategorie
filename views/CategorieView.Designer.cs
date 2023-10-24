namespace Supermarket_mvpCategorie.views
{
    partial class Categorieview
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPageCategorieList = new TabPage();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            BtnNew = new Button();
            dataGridView1 = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCategoriesDetail = new TabPage();
            button4 = new Button();
            BtnSave = new Button();
            textBox2 = new TextBox();
            TxtCategorieObservation = new Label();
            textBox1 = new TextBox();
            TxtCategorieName = new Label();
            TxtBox = new TextBox();
            TxtCategorieId = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategorieList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageCategoriesDetail.SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(134, 36);
            label1.Name = "label1";
            label1.Size = new Size(185, 50);
            label1.TabIndex = 3;
            label1.Text = "Categorie";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategorieList);
            tabControl1.Controls.Add(tabPageCategoriesDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 393);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCategorieList
            // 
            tabPageCategorieList.Controls.Add(button3);
            tabPageCategorieList.Controls.Add(button2);
            tabPageCategorieList.Controls.Add(button1);
            tabPageCategorieList.Controls.Add(BtnNew);
            tabPageCategorieList.Controls.Add(dataGridView1);
            tabPageCategorieList.Controls.Add(BtnSearch);
            tabPageCategorieList.Controls.Add(TxtSearch);
            tabPageCategorieList.Controls.Add(label2);
            tabPageCategorieList.Location = new Point(4, 29);
            tabPageCategorieList.Name = "tabPageCategorieList";
            tabPageCategorieList.Padding = new Padding(3);
            tabPageCategorieList.Size = new Size(792, 360);
            tabPageCategorieList.TabIndex = 0;
            tabPageCategorieList.Text = "CategorieList";
            tabPageCategorieList.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = Properties.Resources._new;
            button3.Location = new Point(537, 68);
            button3.Name = "button3";
            button3.Size = new Size(214, 51);
            button3.TabIndex = 8;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.edit;
            button2.Location = new Point(537, 125);
            button2.Name = "button2";
            button2.Size = new Size(214, 51);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.delete;
            button1.Location = new Point(537, 182);
            button1.Name = "button1";
            button1.Size = new Size(214, 51);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources.cerrar;
            BtnNew.Location = new Point(537, 235);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(214, 51);
            BtnNew.TabIndex = 5;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(528, 218);
            dataGridView1.TabIndex = 4;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(478, 14);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(53, 50);
            BtnSearch.TabIndex = 3;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(6, 26);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(466, 27);
            TxtSearch.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 1;
            label2.Text = "Search Categorie";
            // 
            // tabPageCategoriesDetail
            // 
            tabPageCategoriesDetail.Controls.Add(button4);
            tabPageCategoriesDetail.Controls.Add(BtnSave);
            tabPageCategoriesDetail.Controls.Add(textBox2);
            tabPageCategoriesDetail.Controls.Add(TxtCategorieObservation);
            tabPageCategoriesDetail.Controls.Add(textBox1);
            tabPageCategoriesDetail.Controls.Add(TxtCategorieName);
            tabPageCategoriesDetail.Controls.Add(TxtBox);
            tabPageCategoriesDetail.Controls.Add(TxtCategorieId);
            tabPageCategoriesDetail.Location = new Point(4, 29);
            tabPageCategoriesDetail.Name = "tabPageCategoriesDetail";
            tabPageCategoriesDetail.Padding = new Padding(3);
            tabPageCategoriesDetail.Size = new Size(792, 360);
            tabPageCategoriesDetail.TabIndex = 1;
            tabPageCategoriesDetail.Text = "CategorisDetail";
            tabPageCategoriesDetail.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.save;
            button4.Location = new Point(27, 272);
            button4.Name = "button4";
            button4.Size = new Size(94, 60);
            button4.TabIndex = 8;
            button4.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.cancel;
            BtnSave.Location = new Point(149, 272);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 60);
            BtnSave.TabIndex = 7;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 167);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Categorie Observation";
            textBox2.Size = new Size(318, 83);
            textBox2.TabIndex = 6;
            // 
            // TxtCategorieObservation
            // 
            TxtCategorieObservation.AutoSize = true;
            TxtCategorieObservation.Location = new Point(3, 144);
            TxtCategorieObservation.Name = "TxtCategorieObservation";
            TxtCategorieObservation.Size = new Size(158, 20);
            TxtCategorieObservation.TabIndex = 5;
            TxtCategorieObservation.Text = "Categorie Observation";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 100);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Categorie Id";
            textBox1.Size = new Size(318, 27);
            textBox1.TabIndex = 4;
            // 
            // TxtCategorieName
            // 
            TxtCategorieName.AutoSize = true;
            TxtCategorieName.Location = new Point(3, 77);
            TxtCategorieName.Name = "TxtCategorieName";
            TxtCategorieName.Size = new Size(118, 20);
            TxtCategorieName.TabIndex = 3;
            TxtCategorieName.Text = "Categorie Name";
            // 
            // TxtBox
            // 
            TxtBox.Location = new Point(3, 28);
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(182, 27);
            TxtBox.TabIndex = 2;
            // 
            // TxtCategorieId
            // 
            TxtCategorieId.AutoSize = true;
            TxtCategorieId.Location = new Point(3, 5);
            TxtCategorieId.Name = "TxtCategorieId";
            TxtCategorieId.Size = new Size(91, 20);
            TxtCategorieId.TabIndex = 1;
            TxtCategorieId.Text = "Categorie Id";
            // 
            // Categorieview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 518);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "Categorieview";
            Text = "CategorieMannagement";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategorieList.ResumeLayout(false);
            tabPageCategorieList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPageCategoriesDetail.ResumeLayout(false);
            tabPageCategoriesDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCategorieList;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabPageCategoriesDetail;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button BtnNew;
        private DataGridView dataGridView1;
        private Button BtnSearch;
        private Button button4;
        private Button BtnSave;
        private TextBox textBox2;
        private Label TxtCategorieObservation;
        private TextBox textBox1;
        private Label TxtCategorieName;
        private TextBox TxtBox;
        private Label TxtCategorieId;
    }
}