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
            mail.From =new MailAddress("LezzetVirtuozu@outlook.com","LezzetVirtüözü");// eposta gönderilen mail.
            mail.To.Add("kaanbinici9@gmail.com"); //eposta kime gönderilecek
            mail.Subject = "Lezzet Virtüözü Doðrulama Kodu"; //Konu Baþlýðý
            mail.IsBodyHtml = true;
            mail.Body = "Lezzet Virtüözü uygulamasýna hoþ geldin. Ýþte Doðrulama Kodun=" + onayKodu;//içerik
            //if (ek!=null)
            //{
            //    mail.Attachments.Add(new Attachment(ek));
            //}
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Port = 587; // portu giriyoruz siteye göre
            smtpClient.Host = "smtp.outlook.com"; //gmail,outlook, sitenin smtp si
            smtpClient.EnableSsl = true; //ssl istiyorsa true. genelde true
            smtpClient.Credentials = new NetworkCredential("LezzetVirtuozu@outlook.com", "lezzet123");//gönderilecek eposta ve þifresi.

            smtpClient.Send(mail); // mail gönder.
            smtpClient.Timeout = 100;

        }
    }
}
