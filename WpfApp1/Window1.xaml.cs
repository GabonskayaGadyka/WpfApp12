using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void registerbutton_Click(object sender, RoutedEventArgs e)
        {
            Window3 register = new Window3();
            register.Show();
            this.Close();
        }

        private void loginbutton_Click(object sender, RoutedEventArgs e)
        {
            var context = new AppDbContext();
            User user = context.Users.Where(x => x.Login == logintext.Text && x.Password == passwordtext.Text).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Неверные данные!");
                return;
            }
            Window2 menu = new Window2(user);
            menu.Show();
            this.Close();
        }
    }
}
