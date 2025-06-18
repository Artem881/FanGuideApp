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

            // Знаходимо рекордсмена для заданого виду спорту.
            // Припускаємо, що чим більше значення рекорду, тим краще.
            // Якщо для конкретного виду спорту (наприклад, гольф, біг) менше значення краще,
            // тоді потрібно змінити OrderByDescending на OrderBy.
            var recordHolder = athletes
                .Where(a => a.SportType.Equals(sport, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(a => a.PersonalRecord) // Тепер PersonalRecord є double, тому сортуємо числово
                .FirstOrDefault();

            MessageBox.Show(recordHolder != null ?
                $"Рекордсмен у виді спорту '{sport}': {recordHolder.FullName}, Особистий рекорд: {recordHolder.PersonalRecord}" :
                "Не знайдено рекордсмена для цього виду спорту.");
        }

        private void btnSortByName_Click(object sender, EventArgs e)
        {
            athletes = athletes.OrderBy(a => a.FullName).ToList();
            RefreshGrid();
        }

        private void btnSortBySportType_Click(object sender, EventArgs e)
        {
            athletes = athletes.OrderBy(a => a.SportType).ThenBy(a => a.FullName).ToList();
            RefreshGrid();
        }

        private void btnSortByTeamOrClub_Click(object sender, EventArgs e)
        {
            athletes = athletes.OrderBy(a => a.TeamOrClub).ThenBy(a => a.FullName).ToList();
            RefreshGrid();
        }

        private void btnSortByAge_Click(object sender, EventArgs e)
        {
            // Сортування від наймолодших до найстаріших
            athletes = athletes.OrderByDescending(a => a.BirthDate).ToList();
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
            try
            {
                File.WriteAllText("athletes.json", JsonSerializer.Serialize(athletes, new JsonSerializerOptions { WriteIndented = true }));
                MessageBox.Show("Дані збережено успішно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження даних: {ex.Message}");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists("athletes.json"))
            {
                try
                {
                    var json = File.ReadAllText("athletes.json");
                    athletes = JsonSerializer.Deserialize<List<Athlete>>(json);
                    RefreshGrid();
                    MessageBox.Show("Дані завантажено успішно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка завантаження даних: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Файл 'athletes.json' не знайдено.");
            }
        }
    }
}