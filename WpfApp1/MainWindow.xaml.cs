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
    public partial class MainWindow : Window
    {
        bool running = false;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void switch_bool(ref bool toggle)
        {
            if (toggle)
            {
                toggle = false;
            }
            else
            {
                toggle = true;
            }
        }

        private void btn_toggleRun(object sender, RoutedEventArgs e)
        {
            if (running)
            {
                tb_status.Text = tb_status.Text + " BRUTTISSIMA";
            }else if (!running)
            {
                tb_status.Text = "ELISA BRUTTA";
            }
            switch_bool(ref running);
        }
    }
}