using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_PROJE
{
    public partial class SalaryCalculatorForm : Form
    {
        User loginedUser;
        public SalaryCalculatorForm(User loginedUser)
        {
            InitializeComponent();
            this.loginedUser = loginedUser;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            try
            {
                // Katsayıları ve seçilen değerleri al
                if (cmExperience.SelectedItem == null || cmbCity.SelectedItem == null || cmbEducation.SelectedItem == null || cmbTitle.SelectedItem == null || cmbLanguage.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }
                // Eğer textbox'lar doluysa, aynı kontrolü yapabilirsiniz.
                if (chk06.Checked && string.IsNullOrWhiteSpace(txtAmount06.Text) || chk718.Checked && string.IsNullOrWhiteSpace(txtAmount718.Text) || chk18.Checked && string.IsNullOrWhiteSpace(txtAmount18.Text))
                {
                    MessageBox.Show("Lütfen tüm miktar alanlarını doldurun.");
                    return;
                }

                double experienceCoefficient = GetExperienceCoefficient(cmExperience.SelectedItem.ToString());
                double cityCoefficient = GetCityCoefficient(cmbCity.SelectedItem.ToString());
                double educationCoefficient = GetEducationCoefficient(cmbEducation.SelectedItem.ToString());
                double titleCoefficient = GetTitleCoefficient(cmbTitle.SelectedItem.ToString());
                double languageCoefficient = GetLanguageCoefficient(cmbLanguage.SelectedItem.ToString());
                double familyCoefficient = GetFamilyCoefficient();


                double monthlySalary = CalculateMonthlySalary(experienceCoefficient, cityCoefficient, educationCoefficient, titleCoefficient, languageCoefficient, familyCoefficient);


                lblDisplaySalary.Text = $"Salary: {monthlySalary:C2}";
                loginedUser.Salary = monthlySalary.ToString("F0");
                userManager.UpdateSalaryInCsv(loginedUser.Username, monthlySalary);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating the salary: {ex.Message}");
            }
        }
        
        private double GetTitleCoefficient(string title)
        {
            switch (title)
            {
                case "Takım Lideri / Grup Yöneticisi / Teknik Yönetici / Yazılım Mimarı":
                    return 0.50;
                case "Proje Yöneticisi":
                    return 0.75;
                case "Direktör / Projeler Yöneticisi":
                    return 0.85;
                case "CTO / Genel Müdür":
                    return 1.00;
                case "Bilgi İşlem Sorumlusu / Müdürü (Bilgi İşlem biriminde en çok 5 bilişim personeli varsa)":
                    return 0.40;
                case "Bilgi İşlem Sorumlusu / Müdürü (Bilgi İşlem biriminde 5'ten çok bilişim personeli varsa)":
                    return 0.60;
                default:
                    return 0.0;
            }
        }
        private double GetExperienceCoefficient(string experience)
        {
            switch (experience)
            {
                case "2-4":
                    return 0.60;
                case "5-9":
                    return 1.00;
                case "10-14":
                    return 1.20;
                case "15-20":
                    return 1.35;
                default:
                    return 1.50;
            }
        }

        
        private double GetCityCoefficient(string city)
        {
            switch (city)
            {
                case "TR10: İstanbul":
                    return 0.30;
                case "TR51: Ankara":
                case "TR31: İzmir":
                    return 0.20;
                case "TR42: Kocaeli, Sakarya, Düzce, Bolu, Yalova":
                case "TR21: Edirne, Kırklareli, Tekirdağ":
                case "TR90: Trabzon, Ordu, Giresun, Rize, Artvin, Gümüşhane":
                case "TR41: Bursa, Eskişehir, Bilecik":
                case "TR32: Aydın, Denizli, Muğla":
                case "TR62: Adana, Mersin":
                case "TR22: Balıkesir, Çanakkale":
                case "TR61: Antalya, Isparta, Burdur":
                    return 0.10;
                default:
                    return 0.0;
            }
        }

       
        private double GetEducationCoefficient(string education)
        {
            switch (education)
            {
                case "Meslek alanı ile ilgili yüksek lisans":
                    return 0.10;
                case "Meslek alanı ile ilgili doktora":
                    return 0.30;
                case "Meslek alanı ile ilgili doçentlik":
                    return 0.35;
                case "Meslek alanı ile ilgili olmayan yüksek lisans":
                    return 0.05;
                case "Meslek alanı ile ilgili olmayan doktora/doçentlik":
                    return 0.15;
                default:
                    return 0.0;
            }
        }

        // Yabancı dil katsayısını döndürür
        private double GetLanguageCoefficient(string language)
        {
            switch (language)
            {
                case "Belgelendirilmiş İngilizce bilgisi":
                case "İngilizce eğitim veren okul mezuniyeti":
                    return 0.20;
                case "Belgelendirilmiş diğer yabancı dil bilgisi (her dil için)":
                    return 0.05;
                default:
                    return 0.0;
            }
        }

        
        private double GetFamilyCoefficient()
        {
            double co = 0;
            if (chkEsCalismiyor.Checked) co += 0.20;
            if (chk06.Checked) co += (0.20 * int.Parse(txtAmount06.Text));
            if (chk718.Checked) co += (0.30 * int.Parse(txtAmount718.Text));
            if (chk18.Checked) co += (0.40 * int.Parse(txtAmount18.Text));
            return co;
        }

       
        private double CalculateMonthlySalary(double experienceCoefficient, double cityCoefficient, double educationCoefficient, double titleCoefficient, double languageCoefficient, double familyCoefficient)
        {
            // Sabit bir maaş değeri varsayalım
            double baseSalary = 20002;

            // Tüm katsayıları topla ve sabit maaş ile çarp
            double totalCoefficient = experienceCoefficient + cityCoefficient + educationCoefficient + titleCoefficient + languageCoefficient + familyCoefficient;
            double monthlySalary = baseSalary * totalCoefficient;

            return monthlySalary;
        }

        private void cmbBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = SystemColors.ControlText;
        }

        private void btnMinimized_MouseHover(object sender, EventArgs e)
        {
            btnMinimized.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnMinimized_MouseLeave(object sender, EventArgs e)
        {
            btnMinimized.BackColor = SystemColors.ControlText;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SalaryCalculatorForm_Load(object sender, EventArgs e)
        {
            cmExperience.Items.Add("2-4");
            cmExperience.Items.Add("5-9");
            cmExperience.Items.Add("10-14");
            cmExperience.Items.Add("15-20");
            cmExperience.Items.Add("20+");

            cmbCity.Items.Add("TR10: İstanbul");
            cmbCity.Items.Add("TR51: Ankara");
            cmbCity.Items.Add("TR31: İzmir");
            cmbCity.Items.Add("TR42: Kocaeli, Sakarya, Düzce, Bolu, Yalova");
            cmbCity.Items.Add("TR21: Edirne, Kırklareli, Tekirdağ");
            cmbCity.Items.Add("TR90: Trabzon, Ordu, Giresun, Rize, Artvin, Gümüşhane");
            cmbCity.Items.Add("TR41: Bursa, Eskişehir, Bilecik");
            cmbCity.Items.Add("TR32: Aydın, Denizli, Muğla");
            cmbCity.Items.Add("TR62: Adana, Mersin");
            cmbCity.Items.Add("TR22: Balıkesir, Çanakkale");
            cmbCity.Items.Add("TR61: Antalya, Isparta, Burdur");

            cmbEducation.Items.Add("Meslek alanı ile ilgili yüksek lisans");
            cmbEducation.Items.Add("Meslek alanı ile ilgili doktora");
            cmbEducation.Items.Add("Meslek alanı ile ilgili doçentlik");
            cmbEducation.Items.Add("Meslek alanı ile ilgili olmayan yüksek lisans");
            cmbEducation.Items.Add("Meslek alanı ile ilgili olmayan doktora/doçentlik");

            cmbTitle.Items.Add("Takım Lideri / Grup Yöneticisi / Teknik Yönetici / Yazılım Mimarı");
            cmbTitle.Items.Add("Proje Yöneticisi");
            cmbTitle.Items.Add("Direktör / Projeler Yöneticisi");
            cmbTitle.Items.Add("CTO / Genel Müdür");
            cmbTitle.Items.Add("Bilgi İşlem Sorumlusu / Müdürü (Bilgi İşlem biriminde en çok 5 bilişim personeli varsa)");
            cmbTitle.Items.Add("Bilgi İşlem Sorumlusu / Müdürü (Bilgi İşlem biriminde 5'ten çok bilişim personeli varsa)");

            cmbLanguage.Items.Add("Belgelendirilmiş İngilizce bilgisi");
            cmbLanguage.Items.Add("İngilizce eğitim veren okul mezuniyeti");
            cmbLanguage.Items.Add("Belgelendirilmiş diğer yabancı dil bilgisi (her dil için)");

        }

        private void chk06_CheckedChanged(object sender, EventArgs e)
        {
            label8.Visible = true; txtAmount06.Visible = true;
        }

        private void chk718_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = true; txtAmount718.Visible = true;
        }

        private void chk18_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true; txtAmount18.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
