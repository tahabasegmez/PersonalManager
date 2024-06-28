using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Globalization;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;

namespace OOP_PROJE
{
    public class UserManager
    {
        string filePath = @"data/users.csv";
        private List<User> users;
        bool flag = false;

        public readonly static string EMAIL_PATTERN = @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+.(com|org|net|edu|gov|mil|biz|info|mobi)(.[A-Z]{2})?$";
        public static bool isEmailValid(string emailInput)
        {
            Regex regex = new Regex(EMAIL_PATTERN, RegexOptions.IgnoreCase);
            return regex.IsMatch(emailInput);
        }
        public void AddCsv(User user)
        {
            try
            {
                
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{user.Username},{user.Password},{user.Name},{user.Surname},{user.PhoneNumber},{user.Address},{user.Email},{user.Salary},{user.Photo},{user.UserType},{user.RememberMe}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }
        }
        public void AddCsv(string noteFilePath, string note)
        {
            try
            {

                using (StreamWriter writer = new StreamWriter(noteFilePath, true))
                {
                    writer.WriteLine($"{note}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }
        }
        public void UpdateSalaryInCsv(string username, double newSalary)
        {
            
            string[] lines = File.ReadAllLines(filePath);
            string[] headers = lines[0].Split(',');

            int usernameIndex = Array.IndexOf(headers, "username");
            int salaryIndex = Array.IndexOf(headers, "salary");

            if (usernameIndex == -1 || salaryIndex == -1)
            {
                MessageBox.Show("CSV dosyasında gerekli sütunlar bulunamadı.");
                return;
            }

            for (int i = 1; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');

                if (fields[usernameIndex] == username)
                {
                    fields[salaryIndex] = newSalary.ToString("F0");
                    lines[i] = string.Join(",", fields);
                    break;
                }
            }

            File.WriteAllLines(filePath, lines);
        }
        public void AddCsv(string phoneFilePath, string contactName, string contactSurname, string contactPhone, string contactAddress, string contactDescription, string contactEmail)
        {
            try
            {
                
                using (StreamWriter writer = new StreamWriter(phoneFilePath, true))
                {
                    writer.WriteLine($"{contactName},{contactSurname},{contactPhone},{contactAddress},{contactDescription},{contactEmail}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }
        }
        public void AddCsv(string reminderFilePath, string reminderType, string description, string time, string summary, bool status)
        {
            try
            {
                
                using (StreamWriter writer = new StreamWriter(reminderFilePath, true))
                {
                    writer.WriteLine($"{reminderType},{description},{time},{summary},{status}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }
        }
        public bool userExists(string username)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fs))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    if (fields[0] == username)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public bool isThereAdmin()
        {
            try
            {
                
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(filePath))
                {
                    
                    string line = reader.ReadLine();

                    
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        
                        return false;
                    }
                    else return true;
                }

               
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public int VerifyPassword(string username, string password)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fs))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    if (fields[0] == username)
                    {

                        if (fields[1] == password)
                        {
                            // Şifre doğru
                            return 0;
                        }
                        else
                        {
                            // Şifre yanlış
                            return 1;
                        }
                    }
                }
                // Kullanıcı adı bulunamadı
                return 2;
            }
        }

        public User GetUser(string username)
        {
            using (var reader = new StreamReader(filePath))
            {
                var header = reader.ReadLine(); 
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values[0].Equals(username, StringComparison.OrdinalIgnoreCase))
                    {
                        return new User
                        {
                            Username = values[0],
                            Password = values[1],
                            Name = values[2],
                            Surname = values[3],
                            PhoneNumber = values[4],
                            Address = values[5],
                            Email = values[6],
                            Salary = values[7],
                            Photo = values[8],
                            UserType = int.Parse(values[9]),
                            RememberMe = bool.Parse(values[10])
                        };
                    }
                }
            }
            return null; // Kullanıcı bulunamazsa null döner
        }
        //public DataTable LoadCsvToDataTable(string filePath)
        //{
        //    DataTable dataTable = new DataTable();

        //    // Gerekli sütunları ekleyin
        //    dataTable.Columns.Add("username");
        //    dataTable.Columns.Add("password");
        //    dataTable.Columns.Add("name");
        //    dataTable.Columns.Add("surname");
        //    dataTable.Columns.Add("phoneNumber");
        //    dataTable.Columns.Add("address");
        //    dataTable.Columns.Add("email");
        //    dataTable.Columns.Add("photo");
        //    dataTable.Columns.Add("usertype");
        //    dataTable.Columns.Add("rememberMe");

        //    using (StreamReader reader = new StreamReader(filePath))
        //    {
        //        bool isFirstRow = true;

        //        while (!reader.EndOfStream)
        //        {
        //            string line = reader.ReadLine();
        //            string[] columns = line.Split(',');

        //            if (isFirstRow)
        //            {
        //                isFirstRow = false;
        //                continue; // İlk satırı atla, sadece sütun başlıklarını oku
        //            }

        //            DataRow row = dataTable.NewRow();
        //            row["username"] = columns[0];
        //            row["password"] = columns[1];
        //            row["name"] = columns[2];
        //            row["surname"] = columns[3];
        //            row["phoneNumber"] = columns[4];
        //            row["address"] = columns[5];
        //            row["email"] = columns[6];
        //            row["photo"] = columns[7];
        //            row["usertype"] = columns[8];
        //            row["rememberMe"] = bool.Parse(columns[9]); // rememberMe sütunu bool olarak ekleniyor

        //            dataTable.Rows.Add(row);
        //        }
        //    }

        //    return dataTable;
        //}
        public DataTable LoadCsvToDataTable(string filePath)
        {
            DataTable dataTable = new DataTable();

            using (StreamReader reader = new StreamReader(filePath))
            {
                bool isFirstRow = true;
                string[] headers = null;

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] columns = line.Split(',');

                    if (isFirstRow)
                    {
                        
                        headers = columns;
                        foreach (var header in headers)
                        {
                            dataTable.Columns.Add(header);
                        }
                        isFirstRow = false;
                        continue; 
                    }

                    
                    DataRow row = dataTable.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        row[headers[i]] = columns[i];
                    }
                    dataTable.Rows.Add(row);
                }
            }

            return dataTable;
        }
        public void SaveDataGridViewToCsv(string filePath, DataGridView dgv)
        {
            var lines = new List<string>();

            // Sütun başlıklarını yaz
            string[] columnNames = dgv.Columns
                .Cast<DataGridViewColumn>()
                .Select(column => column.HeaderText)
                .ToArray();
            string header = string.Join(",", columnNames);
            lines.Add(header);

            // Satır verilerini yaz
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    string[] cells = row.Cells
                        .Cast<DataGridViewCell>()
                        .Select(cell => cell.Value?.ToString() ?? string.Empty)
                        .ToArray();
                    string line = string.Join(",", cells);
                    lines.Add(line);
                }
            }

            File.WriteAllLines(filePath, lines);
        }
        private void changeUserType(string userType, DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int userTypeValue = 0; 
                switch (userType)
                {
                    case "Admin":
                        userTypeValue = 0;
                        break;
                    case "User":
                        userTypeValue = 1;
                        break;
                    case "Part-Time User":
                        userTypeValue = 2;
                        break;
                    default:
                        
                        break;
                }

                foreach (DataGridViewRow selectedRow in dgv.SelectedRows)
                {
                    // Seçili satırdaki 'usertype' değerini güncelle
                    selectedRow.Cells["usertype"].Value = userTypeValue;

                    // Güncellenen satırın verilerini ekrana yazdır
                    
                    foreach (DataGridViewCell cell in selectedRow.Cells)
                    {
                        Console.WriteLine($"{dgv.Columns[cell.ColumnIndex].HeaderText}: {cell.Value}");
                    }
                }

                // Güncellenen verileri CSV dosyasına kaydet
                SaveDataGridViewToCsv(filePath,dgv);
                MessageBox.Show("Kullanıcı tipi güncellendi!");
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin!");
            }
        }
        public void WriteDataTableToCsv(DataTable dataTable, string filePath)
        {
            // CSV dosyasını oluştur
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                // Sütun başlıklarını yaz
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    streamWriter.Write(dataTable.Columns[i]);
                    if (i < dataTable.Columns.Count - 1)
                    {
                        streamWriter.Write(",");
                    }
                }
                streamWriter.WriteLine();

                // Her satırı CSV dosyasına yaz
                foreach (DataRow row in dataTable.Rows)
                {
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        streamWriter.Write(row[i].ToString());
                        if (i < dataTable.Columns.Count - 1)
                        {
                            streamWriter.Write(",");
                        }
                    }
                    streamWriter.WriteLine();
                }
            }

        }
        public Image DisplayBase64Image(string base64String)
        {
            // Base64 formatındaki string'i byte dizisine dönüştür
            byte[] imageBytes = Convert.FromBase64String(base64String);

            // Byte dizisini bir MemoryStream'e yükle
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                // MemoryStream'deki resmi PictureBox kontrolüne yükle
                return Image.FromStream(ms);
            }
        }
        public string ConvertImageToBase64(string imagePath)
        {
            byte[] imageBytes = File.ReadAllBytes(imagePath);
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }
        
        public bool ChangePersonalInfo(string oldUsername, string newUsername, string newPassword, string newName, string newSurname, string newPhoneNumber, string newAddress, string newEmail, string newPhoto)
        {
            try
            {
                
                var lines = File.ReadAllLines(filePath).ToList();

                
                string header = lines[0];
                lines.RemoveAt(0);

                bool usernameChanged = false;

                
                for (int i = 0; i < lines.Count; i++)
                {
                    var fields = lines[i].Split(',');

                   
                    if (fields[0] == oldUsername)
                    {
                        fields[0] = newUsername;
                        fields[1] = newPassword;
                        fields[2] = newName;
                        fields[3] = newSurname;
                        fields[4] = newPhoneNumber;
                        fields[5] = newAddress;
                        fields[6] = newEmail;
                        fields[7] = newPhoto;

                        lines[i] = string.Join(",", fields);
                        usernameChanged = true;
                    }
                }

                if (usernameChanged)
                {
                    
                    lines.Insert(0, header);

                   
                    File.WriteAllLines(filePath, lines);
                    return true;
                }
                else
                {
                    
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
    



