using System.Windows;
using System.Windows.Media;

namespace HolaMundo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cadena;

            cadena = NombreTexto.Text;
            MensajeTextBlock.Text = "Hola " + cadena + "!!";

            MensajeTextBlock.Foreground = Brushes.DarkCyan;
        }
    }
}
