namespace WinFormsApp1
{
    using global::System.Net;
    using global::System.Net.Mail;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Random random = new Random();
        string onayKodu;
        private void btnMail_Click(object sender, EventArgs e)
        {
            onayKodu = random.Next(100) + random.Next(100) + random.Next(100) + random.Next(100).ToString();
            MailMessage mail = new MailMessage();
            mail.From =new MailAddress("LezzetVirtuozu@outlook.com","LezzetVirt��z�");// eposta g�nderilen mail.
            mail.To.Add("kaanbinici9@gmail.com"); //eposta kime g�nderilecek
            mail.Subject = "Lezzet Virt��z� Do�rulama Kodu"; //Konu Ba�l���
            mail.IsBodyHtml = true;
            mail.Body = "Lezzet Virt��z� uygulamas�na ho� geldin. ��te Do�rulama Kodun=" + onayKodu;//i�erik
            //if (ek!=null)
            //{
            //    mail.Attachments.Add(new Attachment(ek));
            //}
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Port = 587; // portu giriyoruz siteye g�re
            smtpClient.Host = "smtp.outlook.com"; //gmail,outlook, sitenin smtp si
            smtpClient.EnableSsl = true; //ssl istiyorsa true. genelde true
            smtpClient.Credentials = new NetworkCredential("LezzetVirtuozu@outlook.com", "lezzet123");//g�nderilecek eposta ve �ifresi.

            smtpClient.Send(mail); // mail g�nder.
            smtpClient.Timeout = 100;

        }
    }
}
