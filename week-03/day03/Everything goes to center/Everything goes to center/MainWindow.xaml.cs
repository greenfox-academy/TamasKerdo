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
using GreenFox;

namespace Everything_goes_to_center
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int xposition = 100;
            int yposition = 100;


            StarDrawer(xposition, yposition);
                
        }

        public void StarDrawer(int xstart, int ystart)
        {
            var foxDraw = new FoxDraw(canvas);
            int halfWidth = 1000 / 2;
            int resolution = 2;
            int xcenter = xstart + halfWidth;
            int ycenter = ystart + halfWidth;
            int xposition = xstart;
            int yposition = ystart;


            while (xposition < (xcenter + halfWidth))
            {
                foxDraw.DrawLine(xposition, yposition, xcenter, ycenter);
                xposition += resolution;
            }
            while (yposition < (ycenter + halfWidth))
            {
                foxDraw.DrawLine(xposition, yposition, xcenter, ycenter);
                yposition += resolution;
            }
            while (xposition > (xcenter - halfWidth))
            {
                foxDraw.DrawLine(xposition, yposition, xcenter, ycenter);
                xposition -= resolution;
            }
            while (yposition > (ycenter - halfWidth))
            {
                foxDraw.DrawLine(xposition, yposition, xcenter, ycenter);
                yposition -= resolution;
            }
        }
    }
}
