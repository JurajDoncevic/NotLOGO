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

namespace NotLOGO.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CanvasCursor _cursor;
        public MainWindow()
        {
            InitializeComponent();
            _cursor = new CanvasCursor(cursorRectangle);
        }


        private void btn_executeCommand_Click(object sender, RoutedEventArgs e)
        {
            _cursor.CenterOnCanvas();
            
            
            _cursor.MoveForward(40);
            _cursor.RotateRight(45);
            _cursor.MoveForward(30);
            //_cursor.RotateLeft(90);
            //_cursor.MoveForward(50);

            //_cursor.RotateRight(45);
            //_cursor.MoveBackward(20);

        }
    }
}
