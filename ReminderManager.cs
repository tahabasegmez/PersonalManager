using System;
using System.IO;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace OOP_PROJE
{
    public class ReminderManager
    {
        public event EventHandler<ReminderEventArgs> ReminderOccurred;

        private System.Timers.Timer timer;
        private string reminderPath;

        public ReminderManager(string reminderPath)
        {
            this.reminderPath = reminderPath;
            timer = new System.Timers.Timer(1000); // Her saniye kontrol yap
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            CheckReminders(reminderPath);
        }

        public void CheckReminders(string filePath)
        {
            if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
            {
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++) // İlk satırı (başlık satırını) atlıyoruz
            {
                string line = lines[i];
                string[] parts = line.Split(',');

                string type = parts[0];
                string description = parts[1];
                string timeStr = parts[2];
                string summary = parts[3];
                bool status = bool.Parse(parts[4]);

                if (status)
                {
                    string format = "HH:mm:ss";
                    DateTime time = DateTime.ParseExact(timeStr, format, null);

                    if (time <= DateTime.Now)
                    {
                        OnReminderOccurred(new ReminderEventArgs(description, time));
                        // Hatırlatıcıyı bir kez tetikledikten sonra status'u false yaparak tekrar tetiklenmesini engelleyebiliriz
                        parts[4] = "false";
                        lines[i] = string.Join(",", parts);
                        File.WriteAllLines(filePath, lines);
                    }
                }
            }
        }

        protected virtual void OnReminderOccurred(ReminderEventArgs e)
        {
            ReminderOccurred?.Invoke(this, e);
        }
    }
}
