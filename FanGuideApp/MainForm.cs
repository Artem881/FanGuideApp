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

            // ��������� ����������� ��� �������� ���� ������.
            // ����������, �� ��� ����� �������� �������, ��� �����.
            // ���� ��� ����������� ���� ������ (���������, �����, ��) ����� �������� �����,
            // ��� ������� ������ OrderByDescending �� OrderBy.
            var recordHolder = athletes
                .Where(a => a.SportType.Equals(sport, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(a => a.PersonalRecord) // ����� PersonalRecord � double, ���� ������� �������
                .FirstOrDefault();

            MessageBox.Show(recordHolder != null ?
                $"���������� � ��� ������ '{sport}': {recordHolder.FullName}, ��������� ������: {recordHolder.PersonalRecord}" :
                "�� �������� ����������� ��� ����� ���� ������.");
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
            // ���������� �� ����������� �� ����������
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
                MessageBox.Show("��� ��������� ������!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� ���������� �����: {ex.Message}");
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
                    MessageBox.Show("��� ����������� ������!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������� ������������ �����: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("���� 'athletes.json' �� ��������.");
            }
        }
    }
}