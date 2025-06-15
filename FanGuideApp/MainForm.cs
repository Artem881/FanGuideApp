using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace FanGuideApp
{
    public partial class MainForm : Form
    {
        private List<Athlete> athletes = new();
        private BindingSource bindingSource = new();

        public MainForm()
        {
            InitializeComponent();
            bindingSource.DataSource = athletes;
            dataGridView.DataSource = bindingSource;
            dataGridView.AutoGenerateColumns = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AthleteForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                athletes.Add(form.Athlete);
                RefreshGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow?.DataBoundItem is Athlete athlete)
            {
                athletes.Remove(athlete);
                RefreshGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow?.DataBoundItem is Athlete athlete)
            {
                var form = new AthleteForm(athlete);
                if (form.ShowDialog() == DialogResult.OK)
                    RefreshGrid();
            }
        }

        private void btnSearchRecord_Click(object sender, EventArgs e)
        {
            var sport = textBoxSearchSport.Text.Trim();
            var recordHolder = athletes
                .Where(a => a.SportType.Equals(sport, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(a => a.PersonalRecord)
                .FirstOrDefault();

            MessageBox.Show(recordHolder != null ? $"Рекордсмен: {recordHolder.FullName}" : "Не знайдено.");
        }

        private void btnSortByName_Click(object sender, EventArgs e)
        {
            athletes = athletes.OrderBy(a => a.FullName).ToList();
            RefreshGrid();
        }

        private void btnFavorites_Click(object sender, EventArgs e)
        {
            var favorites = athletes.Where(a => a.IsFavorite).ToList();
            bindingSource.DataSource = favorites;
        }

        private void RefreshGrid()
        {
            bindingSource.DataSource = null;
            bindingSource.DataSource = athletes;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText("athletes.json", JsonSerializer.Serialize(athletes));
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists("athletes.json"))
            {
                var json = File.ReadAllText("athletes.json");
                athletes = JsonSerializer.Deserialize<List<Athlete>>(json);
                RefreshGrid();
            }
        }
    }
}