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
            PlayMusic();
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
    }
}
