using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_PROJE
{
    public class ShakeAnimation
    {
        private Timer timer;
        private Form form;
        private Point originalLocation;
        private int shakeCount;
        private const int shakeAmplitude = 10; // Sallamanın genliği
        private const int shakeDuration = 20;  // Sallamanın süresi (tik sayısı)

        public ShakeAnimation(Form form)
        {
            this.form = form;
            timer = new Timer();
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
}
