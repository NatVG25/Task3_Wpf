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

namespace Task3_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
        }
       
        private void ComboBox_ChangeFontSize(object sender, SelectionChangedEventArgs e) //обработчик события выбора размера шрифта
        {
            string fontSize = ((sender as ComboBox).SelectedItem as TextBlock).Text; //считываем выбранную позицию из списка
            double fontSizeDouble = Convert.ToDouble(fontSize); //преобразуем string в double
            if (textBox != null)
            {
                textBox.FontSize = fontSizeDouble; //присваиваем размер шрифта в textBox
            }
        }

        private void RadioButton_Checked1(object sender, RoutedEventArgs e)//обработчик события выбора цвета шрифта
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black; //обращаемся к textBox и присваиваем ему в свойство Foreground - цвет черный
            }
        }

        private void RadioButton_Checked2(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Red;
            }
        }

        private void Bold_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.FontWeight = FontWeights.Bold;
            }
        }

        private void Italic_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.FontStyle= FontStyles.Italic;
            }
        }

        private void Underline_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.TextDecorations = TextDecorations.Underline;
            }
        }

        


        //TextDecortion - подчеркнутый шрифт - Underline
        //FontSize - размер шрифта 
        //FontWeight - толщина шрифта - Black
        //FontStyle - наклон шрифта = Italic
    }
}



