using CarwashLib;
using CarwashLib.Cryptography;
using Repository;
using System.Text;
using System.Windows.Forms;

namespace Vaskehal
{
    public partial class StatisticsForm : Form
    {
        private readonly int _carwashId;

        public StatisticsForm(int carwashId)
        {
            _carwashId = carwashId;
            InitializeComponent();

            Statistics statistics = GetStatistics();
            lbl_Basic.Text = statistics.BasicWashes.ToString();
            lbl_Silver.Text = statistics.SilverWashes.ToString();
            lbl_Gold.Text = statistics.GoldWashes.ToString();
            lbl_Total.Text = statistics.TotalWashes.ToString();
        }

        private Statistics GetStatistics()
        {
            AesEncryption aes = new AesEncryption();
            byte[] key = aes.GenerateRandomNumber(32);
            byte[] iv = aes.GenerateRandomNumber(16);

            // Gets the statistics encrypted
            byte[] encryptedData = StatisticsRepository.GetStatistics(key, iv, _carwashId);
            // Decrypts the data
            byte[] decryptedData = aes.Decrypt(encryptedData, key, iv);

            // Makes the byte array into a string
            string decryptedJson = Encoding.UTF8.GetString(decryptedData);
            // Deserializes the json string
            Statistics statistics = JsonHelper.DeserializeJson<Statistics>(decryptedJson);

            return statistics;
        }
    }
}
