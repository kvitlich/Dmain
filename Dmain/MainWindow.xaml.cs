using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dmain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Uri("SignIn.xaml", UriKind.Relative));
        }

        private async void Run(object sender, RoutedEventArgs e)
        {

            using (var client = new SmtpClient("smtp-mail.ru", 465))
            {
                client.Credentials = new NetworkCredential("almaapai7@mail.com", "4#74semSum4p%");
                client.EnableSsl = true;
                MailMessage message = new MailMessage();
                message.From = new MailAddress("almaapai7@mail.com", "Kvit");
                message.To.Add(new MailAddress("Kvitlich@gmail.com"));
                message.Subject = "Die";
                message.Attachments.Add(new Attachment("1.txt"));
                message.Body = "Frethin sectum!";
                await client.SendMailAsync(message);
            }
            
        }
    }
}
