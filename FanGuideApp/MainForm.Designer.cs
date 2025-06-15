namespace FanGuideApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearchRecord;
        private System.Windows.Forms.TextBox textBoxSearchSport;
        private System.Windows.Forms.Button btnSortByName;
        private System.Windows.Forms.Button btnFavorites;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView = new System.Windows.Forms.DataGridView();
            btnAdd = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnSearchRecord = new System.Windows.Forms.Button();
            textBoxSearchSport = new System.Windows.Forms.TextBox();
            btnSortByName = new System.Windows.Forms.Button();
            btnFavorites = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeight = 29;
            dataGridView.Location = new System.Drawing.Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new System.Drawing.Size(776, 300);
            dataGridView.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(12, 330);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Додати";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(112, 330);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(75, 32);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Редагувати";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(212, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 32);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Видалити";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearchRecord
            // 
            btnSearchRecord.Location = new System.Drawing.Point(168, 368);
            btnSearchRecord.Name = "btnSearchRecord";
            btnSearchRecord.Size = new System.Drawing.Size(75, 29);
            btnSearchRecord.TabIndex = 5;
            btnSearchRecord.Text = "Пошук рекорду";
            btnSearchRecord.Click += btnSearchRecord_Click;
            // 
            // textBoxSearchSport
            // 
            textBoxSearchSport.Location = new System.Drawing.Point(12, 370);
            textBoxSearchSport.Name = "textBoxSearchSport";
            textBoxSearchSport.Size = new System.Drawing.Size(150, 27);
            textBoxSearchSport.TabIndex = 4;
            // 
            // btnSortByName
            // 
            btnSortByName.Location = new System.Drawing.Point(312, 368);
            btnSortByName.Name = "btnSortByName";
            btnSortByName.Size = new System.Drawing.Size(75, 29);
            btnSortByName.TabIndex = 6;
            btnSortByName.Text = "Сортувати по ПІБ";
            btnSortByName.Click += btnSortByName_Click;
            // 
            // btnFavorites
            // 
            btnFavorites.Location = new System.Drawing.Point(456, 368);
            btnFavorites.Name = "btnFavorites";
            btnFavorites.Size = new System.Drawing.Size(75, 29);
            btnFavorites.TabIndex = 7;
            btnFavorites.Text = "Улюблені";
            btnFavorites.Click += btnFavorites_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(600, 368);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Зберегти";
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(700, 368);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(75, 29);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Завантажити";
            btnLoad.Click += btnLoad_Click;
            // 
            // MainForm
            // 
            ClientSize = new System.Drawing.Size(800, 420);
            Controls.Add(dataGridView);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(textBoxSearchSport);
            Controls.Add(btnSearchRecord);
            Controls.Add(btnSortByName);
            Controls.Add(btnFavorites);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Name = "MainForm";
            Text = "Довідник фаната";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}