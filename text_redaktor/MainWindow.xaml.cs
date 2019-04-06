using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace text_redaktor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // string fileName;
        string filePath;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                filePath=openFileDialog.FileName;
                
                tbMain.Text = File.ReadAllText(openFileDialog.FileName, Encoding.GetEncoding(1251));
            }
        }
        
        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            
        }
        
        private void SaveText_Click(object sender, RoutedEventArgs e)
        {
           
            File.AppendAllText(filePath, tbMain.Text);
        }
    }
}
