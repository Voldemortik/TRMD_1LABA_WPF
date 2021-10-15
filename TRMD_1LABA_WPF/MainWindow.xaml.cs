using System;
using System.Collections.Generic;
using System.Linq;
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
using TRMD_1LABA_WPF.Entities;

namespace TRMD_1LABA_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<User> testUsers { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            testUsers = new List<User>()
            {
                new User()
                {
                    Login = "testUser1",
                    Password = "testUser1",
                    Rememberme = false
                },
                 new User()
                {
                    Login = "testUser2",
                    Password = "testUser2",
                    Rememberme = false
                },
                  new User()
                {
                    Login = "testUser3",
                    Password = "testUser3",
                    Rememberme = false
                },
                   new User()
                {
                    Login = "testUser4",
                    Password = "testUser4",
                    Rememberme = false
                },
                    new User()
                {
                    Login = "testUser5",
                    Password = "testUser5",
                    Rememberme = false
                },
            };
            this.label3.Visibility = Visibility.Hidden;
            this.label2.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.label3.Visibility = Visibility.Hidden;
            this.label2.Visibility =  Visibility.Hidden;
            string loginFromControl = this.textBox1.Text;
            string passwordFromControl = this.textBox2.Text;
            bool rememberMeFromControl = this.checkBox1.IsChecked.Value;
            var needFullUser = testUsers
                .FirstOrDefault(x => x.Login == loginFromControl && passwordFromControl == x.Password);
            if (needFullUser == null)
            {
                this.label2.Visibility = Visibility.Visible;
                ClearForm();
                return;
            }
            needFullUser.Rememberme = rememberMeFromControl;
            this.label3.Visibility = Visibility.Visible;
            this.label3.Content = $"Welcome on board {loginFromControl}";
            ClearForm();
        }
        private void ClearForm()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.checkBox1.IsChecked = false;
        }

    }
}
