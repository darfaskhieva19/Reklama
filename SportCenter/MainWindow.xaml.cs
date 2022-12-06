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
using System.Windows.Media.Animation;

namespace SportCenter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DoubleAnimation WA = new DoubleAnimation(); // создание объекта для настройки анимации
            WA.From = 275; // начальное значение свойства
            WA.To = 305; // конечное значение свойства
            WA.Duration = TimeSpan.FromSeconds(2); // продолжительность анимации (в секундах)
            WA.RepeatBehavior = RepeatBehavior.Forever; // бесконечность анимации
            WA.AutoReverse = true; // воспроизведение временной шкалы в обратном порядке
            Training.BeginAnimation(WidthProperty, WA); // «навешивание» анимации на свойство ширины кнопки


        }
    }
}
