﻿using System;
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

namespace TextRedactor
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

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CutButtonClick(object sender, RoutedEventArgs e)
        {
            richTextBox.Cut();
        }

        private void CopyButtonClick(object sender, RoutedEventArgs e)
        {
            richTextBox.Copy();
        }

        private void PasteButtonClick(object sender, RoutedEventArgs e)
        {
            richTextBox.Paste();
        }
    }
}
