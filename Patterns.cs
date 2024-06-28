using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.Timer;

namespace OOP_PROJE.Resources
{
    public class Patterns
    {

    }
    public interface IReminderFactory
    {
        IDescription CreateDescription();
        ISummary CreateSummary();
    }
    public interface IDescription
    {
        string Description(string text);
    }
    public interface ISummary
    {
        string Summary(string text);
    }
    public class MeetingDescription : IDescription
    {
        public string Description(string text)
        {
            return text;
        }
    }
    public class TaskDescription : IDescription
    {
        public string Description(string text)
        {
            return text;
        }
    }
    public class MeetingSummary : ISummary
    {
        public string Summary(string text)
        {
            return text;
        }
    }
    public class TaskSummary : ISummary
    {
        public string Summary(string text)
        {
            return text;
        }
    }

    public class MeetingFactory : IReminderFactory
    {
        public IDescription CreateDescription()
        {
            return new MeetingDescription();
        }
        public ISummary CreateSummary()
        {
            return new MeetingSummary();
        }
    }
    public class TaskFactory : IReminderFactory
    {
        public IDescription CreateDescription()
        {
            return new TaskDescription();
        }
        public ISummary CreateSummary()
        {
            return new TaskSummary();
        }
    }

    public class Reminder
    {
        public readonly IDescription _description;
        public readonly ISummary _summary;

        public Reminder(IReminderFactory factory)
        {
            _description = factory.CreateDescription();
            _summary = factory.CreateSummary();
        }
        public string getReminderDescription(string text)
        {
            return _description.Description(text);

        }
        public string getReminderSummary(string text)
        {
            return _summary.Summary(text);
        }
    }
    public class ShakeAnimation
    {
        private System.Windows.Forms.Timer timer;
        private Form form;
        private Point originalLocation;
        private int shakeCount;
        private const int shakeAmplitude = 10; // Sallamanın genliği
        private const int shakeDuration = 20;  // Sallamanın süresi (tik sayısı)

        public ShakeAnimation(Form form)
        {
            this.form = form;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 20; // 20 ms (50 FPS)
            timer.Tick += Timer_Tick;
        }

        public void Start()
        {
            originalLocation = form.Location;
            shakeCount = 0;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int offsetX = (shakeCount % 2 == 0) ? shakeAmplitude : -shakeAmplitude;
            form.Location = new Point(originalLocation.X + offsetX, originalLocation.Y);
            shakeCount++;

            if (shakeCount >= shakeDuration)
            {
                timer.Stop();
                form.Location = originalLocation; // Formu orijinal konumuna geri getir
            }
        }
    }
    public class ReminderEventArgs : EventArgs
    {
        public string Description { get; set; }
        public DateTime Time { get; set; }

        public ReminderEventArgs(string description, DateTime time)
        {
            Description = description;
            Time = time;
        }
    }
    public class ReminderManager
    {
        public event EventHandler<ReminderEventArgs> ReminderOccurred;

        private System.Windows.Forms.Timer timer;
        string reminderPath;

        public ReminderManager(string reminderPath)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000 * 60; // Her bir dakikada bir kontrol yap
            timer.Tick += Timer_Tick;
            timer.Start();
            this.reminderPath = reminderPath;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Timer tetiklendiğinde hatırlatıcıları kontrol et
            CheckReminders(reminderPath);
        }
        public void CheckReminders(string filePath)
        {
            // Dosya yoksa veya içeriği boşsa, kullanıcıya bilgi mesajı göster
            if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
            {
                MessageBox.Show("No reminders found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            
            for (int i = lines.Length-1; i > 0; --i) // İlk satırı (başlık satırını) atlıyoruz
            {
                string line = lines[i];
                string[] parts = line.Split(',');

                // CSV satırını parçala ve gerekli alanları al
                string type = parts[0];
                string description = parts[1];
                string timeStr = parts[2];
                string summary = parts[3];
                bool status = bool.Parse(parts[4]);

                if (status)
                {
                    // Verilen formatı belirt
                    string format = "HH:mm:ss"; 

                    // Belirtilen formata göre DateTime değerini analiz et
                    DateTime time = DateTime.ParseExact(timeStr, format, null);

                    if (time <= DateTime.Now)
                    {
                        OnReminderOccurred(new ReminderEventArgs(description, time));
                        lines = lines.Where((val, idx) => idx != i).ToArray();
                    }
                }
            }
            File.WriteAllLines(filePath, lines);
        }


        protected virtual void OnReminderOccurred(ReminderEventArgs e)
        {
            EventHandler<ReminderEventArgs> handler = ReminderOccurred;
            handler(this, e);
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// Observer
    //public interface IObserver
    //{
    //    void getUpdate(ISubject _subject);
    //    void Shake(Label header);
    //}
    //public interface ISubject
    //{
    //    void Attach(IObserver _observer);
    //    void Detach(IObserver _observer);
    //    void Notify();
    //}
    //public class _Reminder : ISubject{
    //    public List<IObserver> _observers = new List<IObserver>();
    //    public string _description;

    //    public void Attach(IObserver _observer)
    //    {
    //        _observers.Add(_observer);
    //    }
    //    public void Detach(IObserver _observer)
    //    {
    //        _observers.Remove(_observer);
    //    }
    //    public void Notify()
    //    {
    //        foreach (var _observer in _observers)
    //        {
    //            _observer.getUpdate(this);
    //        }

    //    }
    //}
    //public class SubForms : IObserver
    //{
    //    Form _form;
    //    Label header;
    //    public SubForms(Form form, Label header)
    //    {
    //        _form = form;
    //        this.header = header;
    //    }
    //    public void getUpdate(ISubject subject)
    //    {
    //        Shake(header);
    //    }
    //    public void Shake(Label header)
    //    {
    //        header.Text = 
    //    }
    //}


}
