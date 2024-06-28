using System;

namespace OOP_PROJE
{
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
}
