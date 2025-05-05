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

namespace IPCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void m_rbClass_Checked(object sender, RoutedEventArgs e)
        {
            m_txtMask.IsReadOnly = true;
        }

        private void m_rbCIDR_Checked(object sender, RoutedEventArgs e)
        {
            m_txtMask.IsReadOnly = false;
            m_txtMask.Text = string.Empty;
        }

        private void calcIP(byte[] bytes)
        {/*
            
            m_txtLogs.Text += $"Wprowadzony adres IP: {m_txtIP.Text}, ";
            if (bytes[0] < 128)
            {
                m_txtLogs.Text += "klasa A";
                m_txtMask.Text = "255.0.0.0";
            }
            else if (bytes[0] < 192)
            {
                m_txtLogs.Text += "klasa B";
                m_txtMask.Text = "255.255.0.0";
            }
            else if (bytes[0] < 224)
            {
                m_txtLogs.Text += "klasa C";
                m_txtMask.Text = "255.255.255.0";
            }
            else if (bytes[0] < 240)
            {
                m_txtLogs.Text += "klasa D";
                m_txtMask.Text = string.Empty;
            }
            else
            {
                m_txtLogs.Text += "klasa E";
                m_txtMask.Text = string.Empty;
            }*/
        }

        private void m_btnCalc_Click(object sender, RoutedEventArgs e)
        {
            /*
            string[] octets = m_txtIP.Text.Split('.');
            byte[] bytes = new byte[4];
            if (octets.Length != 4)
            {
                m_txtLogs.Text += "Adres IP jest nieprawidłowy!\n";
                return;
            }
            int index = 0;
            foreach (string octet in octets)
            {
                if (!int.TryParse(octet, out int value) || value < 0 || value > 255)
                {
                    m_txtLogs.Text += "Adres IP jest nieprawidłowy!\n";
                    return;
                }
                else
                {
                    bytes[index++] = (byte)value;
                }
            }

            calcIP(bytes);*/
        }

        private void m_txtIP_TextChanged(object sender, TextChangedEventArgs e)
        {
            /*
            string[] octets = m_txtIP.Text.Split('.');
            byte[] bytes = new byte[4];
            if (octets.Length == 4)
            {
                int index = 0;
                foreach (string octet in octets)
                {
                    if (!int.TryParse(octet, out int value) || value < 0 || value > 255)
                    {
                        m_txtLogs.Text += "Adres IP jest nieprawidłowy!\n";
                        return;
                    }
                    else
                    {
                        bytes[index++] = (byte)value;
                    }
                }
            }            
            calcIP(bytes);
        }*/
    }
}