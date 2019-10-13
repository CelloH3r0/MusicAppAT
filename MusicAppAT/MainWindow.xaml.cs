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
using System.Windows.Resources;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace MusicAppAT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {

        }

        private void OnLoad(object sender, EventArgs e)
        {
            
        }
        public async void PlayMusic()
        {
            int marginSize = 150;
            while (true)
            {
                await Task.Delay(1);
                Thickness margin = musicSlider.Margin;
                
                margin.Left = marginSize;
                musicSlider.Margin = margin;
                marginSize++;

                if(marginSize==625 && margin.Top == 21)
                {
                    margin.Top = 158;
                    marginSize = 150;
                    musicSlider.Margin = margin;
                }
                if (marginSize == 625 && margin.Top == 158)
                {
                    marginSize = 150;
                    margin.Left = marginSize;
                    margin.Top = 21;
                    musicSlider.Margin = margin;
                }
            }
        }

        public void OnClick()
        {
            
        }

        private void whole_Click(object sender, RoutedEventArgs e)
        {
            double length = 4;

        }
        private void dothalf_Click(object sender, RoutedEventArgs e)
        {
            double length = 3;
        }

        private void half_Click(object sender, RoutedEventArgs e)
        {
            double length = 2;
        }

        private void dotquarter_Click(object sender, RoutedEventArgs e)
        {
            double length = 1.5;
        }

        private void quarter_Click(object sender, RoutedEventArgs e)
        {
            double length = 1;
        }

        private void m1b1b2_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "b2";
            //margin: left: 175, top: 4, right: 0, bottom: 0
        }

        private void m1b1a2_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "a2";
            //margin: left: 175, top: 10, right: 0, bottom: 0

        }

        private void m1b1g1_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "g1";
            //margin: left: 175, top: 16, right: 0, bottom: 0
        }

        private void m1b1f1_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "f1";
            //margin: left: 175, top: 23, right: 0, bottom: 0
        }

        private void m1b1e1_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "e1";
            //margin: left: 175, top: 30, right: 0, bottom: 0
        }
        private void m1b1d1_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "d1";
            //margin: left: 175, top: 36, right: 0, bottom: 0
        }
        private void m1b1c1_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "c1";
            //margin: left: 175, top: 43, right: 0, bottom: 0
        }
        private void m1b1b1_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "b1";
            //margin: left: 175, top: 50, right: 0, bottom: 0
        }

        private void m1b1a1_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "a1";
            //margin: left: 175, top: 56, right: 0, bottom: 0
        }
        private void m1b1g0_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "g0";
            //margin: left: 175, top: 62, right: 0, bottom: 0
        }
        private void m1b1f0_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "f0";
            //margin: left: 175, top: 68, right: 0, bottom: 0
        }

        private void m1b1andb2_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "b2";
            //margin: left: 234, top: 4, right: 0, bottom: 0
        }

        private void m1b1anda2_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "a2";
            //margin: left: 234, top: 10, right: 0, bottom: 0
        }

        private void m1b1andg1_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "g1";
            //margin: left: 234, top: 16, right: 0, bottom: 0
        }

        private void m1b1andf1_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "f1";
            //margin: left: 234, top: 23, right: 0, bottom: 0
        }

        private void m1b1ande1_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "e1";
            //margin: left: 234, top: 30, right: 0, bottom: 0
        }
        private void m1b1andd1_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "d1";
            //margin: left: 234, top: 36, right: 0, bottom: 0
        }
        private void m1b1andc1_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "c1";
            //margin: left: 234, top: 43, right: 0, bottom: 0
        }
        private void m1b1andb1_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "b1";
            //margin: left: 234, top: 50, right: 0, bottom: 0
        }

        private void m1b1anda1_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "a1";
            //margin: left: 234, top: 56, right: 0, bottom: 0
        }
        private void m1b1andg0_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "g0";
            //margin: left: 234, top: 62, right: 0, bottom: 0
        }
        private void m1b1andf0_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "f0";
            //margin: left: 234, top: 68, right: 0, bottom: 0
        }

        private void m1b2b2_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "b2";
            //margin: left: 290, top: 4, right: 0, bottom: 0
        }

        private void m1b2a2_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "a2";
            //margin: left: 290, top: 10, right: 0, bottom: 0
        }

        private void m1b2g1_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "g1";
            //margin: left: 290, top: 16, right: 0, bottom: 0
        }

        private void m1b2f1_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "f1";
            //margin: left: 290, top: 23, right: 0, bottom: 0
        }

        private void m1b2e1_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "e1";
            //margin: left: 290, top: 30, right: 0, bottom: 0
        }
        private void m1b2d1_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "d1";
            //margin: left: 290, top: 36, right: 0, bottom: 0
        }
        private void m1b2c1_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "c1";
            //margin: left: 290, top: 43, right: 0, bottom: 0
        }
        private void m1b2b1_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "b1";
            //margin: left: 290, top: 50, right: 0, bottom: 0
        }

        private void m1b2a1_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "a1";
            //margin: left: 290, top: 56, right: 0, bottom: 0
        }
        private void m1b2g0_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "g0";
            //margin: left: 290, top: 62, right: 0, bottom: 0
        }
        private void m1b2f0_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "f0";
            //margin: left: 290, top: 68, right: 0, bottom: 0
        }

        private void m1b2andb2_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "b2";
            //margin: left: 351, top: 4, right: 0, bottom: 0
        }

        private void m1b2anda2_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "a1";
            //margin: left: 351, top: 10, right: 0, bottom: 0
        }

        private void m1b2andg1_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "g1";
            //margin: left: 351, top: 16, right: 0, bottom: 0
        }

        private void m1b2andf1_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "f1";
            //margin: left: 351, top: 23, right: 0, bottom: 0
        }

        private void m1b2ande1_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "e1";
            //margin: left: 351, top: 30, right: 0, bottom: 0
        }
        private void m1b2andd1_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "d1";
            //margin: left: 351, top: 36, right: 0, bottom: 0
        }
        private void m1b2andc1_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "c1";
            //margin: left: 351, top: 43, right: 0, bottom: 0
        }
        private void m1b2andb1_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "b1";
            //margin: left: 351, top: 50, right: 0, bottom: 0
        }

        private void m1b2anda1_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "a1";
            //margin: left: 351, top: 56, right: 0, bottom: 0
        }
        private void m1b2andg0_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "g0";
            //margin: left: 351, top: 62, right: 0, bottom: 0
        }
        private void m1b2andf0_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "f0";
            //margin: left: 351, top: 68, right: 0, bottom: 0
        }

        private void m1b3b2_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "b2";
            //margin: left: 406, top: 4, right: 0, bottom: 0
        }

        private void m1b3a2_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "a2";
            //margin: left: 406, top: 10, right: 0, bottom: 0
        }

        private void m1b3g1_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "g1";
            //margin: left: 406, top: 16, right: 0, bottom: 0
        }

        private void m1b3f1_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "f1";
            //margin: left: 406, top: 23, right: 0, bottom: 0
        }

        private void m1b3e1_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "e1";
            //margin: left: 406, top: 30, right: 0, bottom: 0
        }
        private void m1b3d1_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "d1";
            //margin: left: 406, top: 36, right: 0, bottom: 0
        }
        private void m1b3c1_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "c1";
            //margin: left: 406, top: 43, right: 0, bottom: 0
        }
        private void m1b3b1_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "b1";
            //margin: left: 406, top: 50, right: 0, bottom: 0
        }

        private void m1b3a1_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "a1";
            //margin: left: 406, top: 56, right: 0, bottom: 0
        }
        private void m1b3g0_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "g0";
            //margin: left: 406, top: 62, right: 0, bottom: 0
        }
        private void m1b3f0_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "f0";
            //margin: left: 406, top: 68, right: 0, bottom: 0
        }

        private void m1b3andb2_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "b2";
            //margin: left: 466, top: 4, right: 0, bottom: 0
        }

        private void m1b3anda2_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "a2";
            //margin: left: 466, top: 10, right: 0, bottom: 0
        }

        private void m1b3andg1_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "g1";
            //margin: left: 466, top: 16, right: 0, bottom: 0
        }

        private void m1b3andf1_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "f1";
            //margin: left: 466, top: 23, right: 0, bottom: 0
        }

        private void m1b3ande1_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "e1";
            //margin: left: 466, top: 30, right: 0, bottom: 0
        }
        private void m1b3andd1_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "d1";
            //margin: left: 466, top: 36, right: 0, bottom: 0
        }
        private void m1b3andc1_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "c1";
            //margin: left: 466, top: 43, right: 0, bottom: 0
        }
        private void m1b3andb1_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "b1";
            //margin: left: 466, top: 50, right: 0, bottom: 0
        }

        private void m1b3anda1_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "a1";
            //margin: left: 466, top: 56, right: 0, bottom: 0
        }
        private void m1b3andg0_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "g0";
            //margin: left: 466, top: 62, right: 0, bottom: 0
        }
        private void m1b3andf0_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "f0";
            //margin: left: 466, top: 68, right: 0, bottom: 0
        }
        private void m1b4b2_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "b2";
            //margin: left: 522, top: 4, right: 0, bottom: 0
        }

        private void m1b4a2_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "a2";
            //margin: left: 522, top: 10, right: 0, bottom: 0
        }

        private void m1b4g1_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "g1";
            //margin: left: 522, top: 16, right: 0, bottom: 0
        }

        private void m1b4f1_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "f1";
            //margin: left: 522, top: 23, right: 0, bottom: 0
        }

        private void m1b4e1_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "e1";
            //margin: left: 522, top: 30, right: 0, bottom: 0
        }
        private void m1b4d1_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "d1";
            //margin: left: 522, top: 36, right: 0, bottom: 0
        }
        private void m1b4c1_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "c1";
            //margin: left: 522, top: 43, right: 0, bottom: 0
        }
        private void m1b4b1_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "b1";
            //margin: left: 522, top: 50, right: 0, bottom: 0
        }

        private void m1b4a1_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "a1";
            //margin: left: 522, top: 56, right: 0, bottom: 0
        }
        private void m1b4g0_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "g0";
            //margin: left: 522, top: 62, right: 0, bottom: 0
        }
        private void m1b4f0_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "f0";
            //margin: left: 522, top: 68, right: 0, bottom: 0
        }

        private void m1b4andb2_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "b2";
            //margin: left: 583, top: 4, right: 0, bottom: 0
        }

        private void m1b4anda2_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "a2";
            //margin: left: 583, top: 10, right: 0, bottom: 0
        }

        private void m1b4andg1_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "g1";
            //margin: left: 583, top: 16, right: 0, bottom: 0
        }

        private void m1b4andf1_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "f1";
            //margin: left: 583, top: 23, right: 0, bottom: 0
        }

        private void m1b4ande1_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "e1";
            //margin: left: 583, top: 30, right: 0, bottom: 0
        }
        private void m1b4andd1_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "d1";
            //margin: left: 583, top: 36, right: 0, bottom: 0
        }
        private void m1b4andc1_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "c1";
            //margin: left: 583, top: 43, right: 0, bottom: 0
        }
        private void m1b4andb1_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "b1";
            //margin: left: 583, top: 50, right: 0, bottom: 0
        }

        private void m1b4anda1_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "a1";
            //margin: left: 583, top: 56, right: 0, bottom: 0
        }
        private void m1b4andg0_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "g0";
            //margin: left: 583, top: 62, right: 0, bottom: 0
        }
        private void m1b4andf0_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "f0";
            //margin: left: 583, top: 68, right: 0, bottom: 0
        }
        private void m2b1b2_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "b2";
            //margin: left: 174, top: 141, right: 0, bottom: 0
        }

        private void m2b1a2_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "a2";
            //margin: left: 174, top: 147, right: 0, bottom: 0
        }

        private void m2b1g1_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "g1";
            //margin: left: 174, top: 153, right: 0, bottom: 0
        }

        private void m2b1f1_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "f1";
            //margin: left: 174, top: 160, right: 0, bottom: 0
        }

        private void m2b1e1_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "e1";
            //margin: left: 174, top: 167, right: 0, bottom: 0
        }
        private void m2b1d1_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "d1";
            //margin: left: 174, top: 173, right: 0, bottom: 0
        }
        private void m2b1c1_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "c1";
            //margin: left: 174, top: 180, right: 0, bottom: 0
        }
        private void m2b1b1_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "b1";
            //margin: left: 174, top: 187, right: 0, bottom: 0
        }

        private void m2b1a1_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "a1";
            //margin: left: 174, top: 193, right: 0, bottom: 0
        }
        private void m2b1g0_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "g0";
            //margin: left: 174, top: 199, right: 0, bottom: 0
        }
        private void m2b1f0_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "f0";
            //margin: left: 174, top: 205, right: 0, bottom: 0
        }

        private void m2b1andb2_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "b2";
        }

        private void m2b1anda2_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "a2";
        }

        private void m2b1andg1_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "g1";
        }

        private void m2b1andf1_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "f1";
        }

        private void m2b1ande1_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "e1";
        }
        private void m2b1andd1_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "d1";
        }
        private void m2b1andc1_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "c1";
        }
        private void m2b1andb1_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "b1";
        }

        private void m2b1anda1_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "a1";
        }
        private void m2b1andg0_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "g0";
        }
        private void m2b1andf0_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "f0";
        }

        private void m2b2b2_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "b2";
        }

        private void m2b2a2_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "a2";
        }

        private void m2b2g1_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "g1";
        }

        private void m2b2f1_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "f1";
        }

        private void m2b2e1_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "e1";
        }
        private void m2b2d1_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "d1";
        }
        private void m2b2c1_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "c1";
        }
        private void m2b2b1_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "b1";
        }

        private void m2b2a1_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "a1";
        }
        private void m2b2g0_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "g0";
        }
        private void m2b2f0_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "f0";
        }

        private void m2b2andb2_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "b2";
        }

        private void m2b2anda2_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "a2";
        }

        private void m2b2andg1_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "g1";
        }

        private void m2b2andf1_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "f1";
        }

        private void m2b2ande1_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "e1";
        }
        private void m2b2andd1_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "d1";
        }
        private void m2b2andc1_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "c1";
        }
        private void m2b2andb1_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "b1";
        }

        private void m2b2anda1_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "a1";
        }
        private void m2b2andg0_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "g0";
        }
        private void m2b2andf0_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "f0";
        }

        private void m2b3b2_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "b2";
        }

        private void m2b3a2_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "a2";
        }

        private void m2b3g1_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "g1";
        }

        private void m2b3f1_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "f1";
        }

        private void m2b3e1_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "e1";
        }
        private void m2b3d1_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "d1";
        }
        private void m2b3c1_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "c1";
        }
        private void m2b3b1_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "b1";
        }

        private void m2b3a1_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "a1";
        }
        private void m2b3g0_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "g0";
        }
        private void m2b3f0_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "f0";
        }

        private void m2b3andb2_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "b2";
        }

        private void m2b3anda2_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "a2";
        }

        private void m2b3andg1_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "g1";
        }

        private void m2b3andf1_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "f1";
        }

        private void m2b3ande1_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "e1";
        }
        private void m2b3andd1_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "d1";
        }
        private void m2b3andc1_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "c1";
        }
        private void m2b3andb1_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "b1";
        }

        private void m2b3anda1_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "a1";
        }
        private void m2b3andg0_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "g0";
        }
        private void m2b3andf0_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "f0";
        }
        private void m2b4b2_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "b2";
        }

        private void m2b4a2_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "a2";
        }

        private void m2b4g1_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "g1";
        }

        private void m2b4f1_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "f1";
        }

        private void m2b4e1_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "e1";
        }
        private void m2b4d1_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "d1";
        }
        private void m2b4c1_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "c1";
        }
        private void m2b4b1_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "b1";
        }

        private void m2b4a1_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "a1";
        }
        private void m2b4g0_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "g0";
        }
        private void m2b4f0_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "f0";
        }

        private void m2b4andb2_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "b2";
        }

        private void m2b4anda2_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "a2";
        }

        private void m2b4andg1_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "g1";
        }

        private void m2b4andf1_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "f1";
        }

        private void m2b4ande1_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "e1";
        }
        private void m2b4andd1_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "d1";
        }
        private void m2b4andc1_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "c1";
        }
        private void m2b4andb1_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "b1";
        }

        private void m2b4anda1_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "a1";
        }
        private void m2b4andg0_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "g0";
        }
        private void m2b4andf0_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "f0";
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            PlayMusic();
        }

        
    }
}
