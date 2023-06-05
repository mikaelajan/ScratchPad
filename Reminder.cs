using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using try1234.Category;
using System.IO;

namespace try1234
{
    public partial class Reminder : Form
    {
        private Timer timer;
        private List<Alarm> alarms;
        private SQLiteConnection connection;

        public Reminder()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Start();

            alarms = new List<Alarm>();

            connection = new SQLiteConnection("Data Source=alarms.db");
            if (!File.Exists("alarms.db"))
            {
                connection.Open();
                CreateAlarmsTable();
                connection.Close();
            }
        }

        private void CreateAlarmsTable()
        {
            string createTableQuery = "CREATE TABLE IF NOT EXISTS Alarms (Title TEXT, Description TEXT, Time TEXT)";
            SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
            command.ExecuteNonQuery();
        }

        private void InsertAlarm(Alarm alarm)
        {
            connection.Open();

            string insertQuery = "INSERT INTO Alarms (Title, Description, Time) VALUES (@Title, @Description, @Time)";
            SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@Title", alarm.Title);
            command.Parameters.AddWithValue("@Description", alarm.Description);
            command.Parameters.AddWithValue("@Time", alarm.Time);
            command.ExecuteNonQuery();

            connection.Close();
        }

        private DataTable LoadAlarmsFromDatabase()
        {
            connection.Open();

            DataTable dataTable = new DataTable();

            string selectQuery = "SELECT Title, Time FROM Alarms";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectQuery, connection);
            adapter.Fill(dataTable);

            connection.Close();

            return dataTable;
        }

        private void DisplayAlarmsInDataGridView()
        {
            DataTable dataTable = LoadAlarmsFromDatabase();
            dataGridView1.DataSource = dataTable;
        }

        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            if (txtHour.Text != "" && txtMinute.Text != "")
            {
                int hour, minute;

                if (!int.TryParse(txtHour.Text, out hour) || hour < 1 || hour > 12)
                {
                    MessageBox.Show("Invalid hour format. Please enter a valid hour (1-12).");
                    return;
                }

                if (!int.TryParse(txtMinute.Text, out minute) || minute < 0 || minute > 59)
                {
                    MessageBox.Show("Invalid minute format. Please enter a valid minute (0-59).");
                    return;
                }

                string amPm = radAM.Checked ? "AM" : "PM";
                string alarmTime = $"{hour:D2}:{minute:D2} {amPm}";

                Alarm newAlarm = new Alarm
                {
                    Title = txtTitle.Text,
                    Description = txtDescription.Text,
                    Time = alarmTime
                };

                alarms.Add(newAlarm);
                InsertAlarm(newAlarm);

                DisplayAlarmsInDataGridView();

                timer.Start();
                MessageBox.Show($"Alarm set for {newAlarm.Time}\n\nTitle: {newAlarm.Title}\nDescription: {newAlarm.Description}");

                txtTitle.Text = "";
                txtDescription.Text = "";
                txtHour.Text = "";
                txtMinute.Text = "";
                radAM.Checked = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            lblTime.Text = currentTime.ToString("hh:mm:ss tt");

            foreach (Alarm alarm in alarms)
            {
                DateTime alarmDateTime;
                if (!DateTime.TryParseExact(alarm.Time, "hh:mm tt", null, System.Globalization.DateTimeStyles.None, out alarmDateTime))
                {
                    MessageBox.Show($"Invalid alarm time format for '{alarm.Title}'. Please enter the time in the format 'hh:mm AM/PM'.");
                    timer.Stop();
                    return;
                }

                if (alarmDateTime.TimeOfDay == currentTime.TimeOfDay || alarmDateTime.TimeOfDay < currentTime.TimeOfDay)
                {
                    MessageBox.Show($"Wake up!\n\nTitle: {alarm.Title}\nDescription: {alarm.Description}");
                    timer.Stop();
                }
            }
        }

        public class Alarm
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string Time { get; set; }
        }

       
        private void Reminder_Load(object sender, EventArgs e)
        {
           
            DisplayAlarmsInDataGridView();
        }

        private void homeStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.ShowDialog();
        }

        private void backStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            categoryPage back = new categoryPage();
            back.ShowDialog();
        }

        private void cLOSEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
