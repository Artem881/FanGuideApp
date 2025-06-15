using System;
using System.Windows.Forms;
// using System.Globalization; // <--- Видаліть цей рядок, якщо він є

namespace FanGuideApp
{
    public partial class AthleteForm : Form
    {
        public Athlete Athlete { get; private set; }

        // UI Controls (залиште їх, якщо вони потрібні для InitializeComponent)
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label lblSportType;
        private System.Windows.Forms.TextBox txtSportType;
        private System.Windows.Forms.Label lblTeamOrClub;
        private System.Windows.Forms.TextBox txtTeamOrClub;
        private System.Windows.Forms.Label lblPersonalRecord;
        private System.Windows.Forms.TextBox txtPersonalRecord;
        private System.Windows.Forms.CheckBox chkIsFavorite;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;


        public AthleteForm(Athlete athlete = null)
        {
            InitializeComponent();
            Athlete = athlete ?? new Athlete();
            LoadAthleteData(); // Load data if editing an existing athlete
        }

        private void InitializeComponent()
        {
            // Цей блок коду має бути згенерований дизайнером Visual Studio.
            // Якщо ви його вставили вручну, залиште як було.
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblNationality = new System.Windows.Forms.Label();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.lblSportType = new System.Windows.Forms.Label();
            this.txtSportType = new System.Windows.Forms.TextBox();
            this.lblTeamOrClub = new System.Windows.Forms.Label();
            this.txtTeamOrClub = new System.Windows.Forms.TextBox();
            this.lblPersonalRecord = new System.Windows.Forms.Label();
            this.txtPersonalRecord = new System.Windows.Forms.TextBox();
            this.chkIsFavorite = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblFullName
            //
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(12, 15);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(42, 15);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "ПІБ:";
            //
            // txtFullName
            //
            this.txtFullName.Location = new System.Drawing.Point(120, 12);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 23);
            this.txtFullName.TabIndex = 1;
            //
            // lblBirthDate
            //
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(12, 45);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(102, 15);
            this.lblBirthDate.TabIndex = 2;
            this.lblBirthDate.Text = "Дата народження:";
            //
            // dtpBirthDate
            //
            this.dtpBirthDate.Location = new System.Drawing.Point(120, 42);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 23);
            this.dtpBirthDate.TabIndex = 3;
            //
            // lblNationality
            //
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(12, 75);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(73, 15);
            this.lblNationality.TabIndex = 4;
            this.lblNationality.Text = "Громадянство:";
            //
            // txtNationality
            //
            this.txtNationality.Location = new System.Drawing.Point(120, 72);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(200, 23);
            this.txtNationality.TabIndex = 5;
            //
            // lblOrigin
            //
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(12, 105);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(65, 15);
            this.lblOrigin.TabIndex = 6;
            this.lblOrigin.Text = "Походження:";
            //
            // txtOrigin
            //
            this.txtOrigin.Location = new System.Drawing.Point(120, 102);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(200, 23);
            this.txtOrigin.TabIndex = 7;
            //
            // lblSportType
            //
            this.lblSportType.AutoSize = true;
            this.lblSportType.Location = new System.Drawing.Point(12, 135);
            this.lblSportType.Name = "lblSportType";
            this.lblSportType.Size = new System.Drawing.Size(37, 15);
            this.lblSportType.TabIndex = 8;
            this.lblSportType.Text = "Вид спорту:";
            //
            // txtSportType
            //
            this.txtSportType.Location = new System.Drawing.Point(120, 132);
            this.txtSportType.Name = "txtSportType";
            this.txtSportType.Size = new System.Drawing.Size(200, 23);
            this.txtSportType.TabIndex = 9;
            //
            // lblTeamOrClub
            //
            this.lblTeamOrClub.AutoSize = true;
            this.lblTeamOrClub.Location = new System.Drawing.Point(12, 165);
            this.lblTeamOrClub.Name = "lblTeamOrClub";
            this.lblTeamOrClub.Size = new System.Drawing.Size(82, 15);
            this.lblTeamOrClub.TabIndex = 10;
            this.lblTeamOrClub.Text = "Команда/Клуб:";
            //
            // txtTeamOrClub
            //
            this.txtTeamOrClub.Location = new System.Drawing.Point(120, 162);
            this.txtTeamOrClub.Name = "txtTeamOrClub";
            this.txtTeamOrClub.Size = new System.Drawing.Size(200, 23);
            this.txtTeamOrClub.TabIndex = 11;
            //
            // lblPersonalRecord
            //
            this.lblPersonalRecord.AutoSize = true;
            this.lblPersonalRecord.Location = new System.Drawing.Point(12, 195);
            this.lblPersonalRecord.Name = "lblPersonalRecord";
            this.lblPersonalRecord.Size = new System.Drawing.Size(89, 15);
            this.lblPersonalRecord.TabIndex = 12;
            this.lblPersonalRecord.Text = "Особистий рекорд:";
            //
            // txtPersonalRecord
            //
            this.txtPersonalRecord.Location = new System.Drawing.Point(120, 192);
            this.txtPersonalRecord.Name = "txtPersonalRecord";
            this.txtPersonalRecord.Size = new System.Drawing.Size(200, 23);
            this.txtPersonalRecord.TabIndex = 13;
            //
            // chkIsFavorite
            //
            this.chkIsFavorite.AutoSize = true;
            this.chkIsFavorite.Location = new System.Drawing.Point(120, 222);
            this.chkIsFavorite.Name = "chkIsFavorite";
            this.chkIsFavorite.Size = new System.Drawing.Size(73, 19);
            this.chkIsFavorite.TabIndex = 14;
            this.chkIsFavorite.Text = "Улюблений";
            this.chkIsFavorite.UseVisualStyleBackColor = true;
            //
            // btnOK
            //
            this.btnOK.Location = new System.Drawing.Point(120, 260);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            //
            // btnCancel
            //
            this.btnCancel.Location = new System.Drawing.Point(245, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            //
            // AthleteForm
            //
            this.ClientSize = new System.Drawing.Size(334, 301);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkIsFavorite);
            this.Controls.Add(this.txtPersonalRecord);
            this.Controls.Add(this.lblPersonalRecord);
            this.Controls.Add(this.txtTeamOrClub);
            this.Controls.Add(this.lblTeamOrClub);
            this.Controls.Add(this.txtSportType);
            this.Controls.Add(this.lblSportType);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Name = "AthleteForm";
            this.Text = "Дані про спортсмена";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Load data from the Athlete object into the form fields
        private void LoadAthleteData()
        {
            txtFullName.Text = Athlete.FullName;
            dtpBirthDate.Value = Athlete.BirthDate == DateTime.MinValue ? DateTime.Now : Athlete.BirthDate;
            txtNationality.Text = Athlete.Nationality;
            txtOrigin.Text = Athlete.Origin;
            txtSportType.Text = Athlete.SportType;
            txtTeamOrClub.Text = Athlete.TeamOrClub;
            txtPersonalRecord.Text = Athlete.PersonalRecord; // <--- Повернуто на пряме присвоєння рядка
            chkIsFavorite.Checked = Athlete.IsFavorite;
        }

        // Save data from the form fields into the Athlete object
        private void SaveAthleteData()
        {
            Athlete.FullName = txtFullName.Text;
            Athlete.BirthDate = dtpBirthDate.Value;
            Athlete.Nationality = txtNationality.Text;
            Athlete.Origin = txtOrigin.Text;
            Athlete.SportType = txtSportType.Text;
            Athlete.TeamOrClub = txtTeamOrClub.Text;
            Athlete.PersonalRecord = txtPersonalRecord.Text; // <--- Повернуто на пряме присвоєння рядка
            Athlete.IsFavorite = chkIsFavorite.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveAthleteData(); // Зберігаємо дані
            DialogResult = DialogResult.OK; // <--- Повернуто на пряме присвоєння
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}