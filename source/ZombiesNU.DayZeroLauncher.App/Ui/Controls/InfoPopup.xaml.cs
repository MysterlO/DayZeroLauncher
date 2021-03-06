﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MonoTorrent.Common;
using zombiesnu.DayZeroLauncher.App.Core;

namespace zombiesnu.DayZeroLauncher.App.Ui.Controls
{
    /// <summary>
    /// Interaction logic for InfoPopup.xaml
    /// </summary>
    public partial class InfoPopup : Window
    {
        bool running = true;
        bool doneRunning = false;
        public InfoPopup()
        {
            InitializeComponent();
        }

        public void SetMessage(string message)
        {
            Message.Content = message;
        }

        public void OK_Click(object sender, EventArgs e)
        {
            running = false;
            this.Close();
        }
    }
}
