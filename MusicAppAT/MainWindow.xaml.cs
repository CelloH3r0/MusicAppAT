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
using System.Media;
using System.IO;

namespace MusicAppAT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numOfNotes = 0;

        string[,] notes = new string[16, 3];

        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {

        }

        public static string GetExeDirSubPath(string subPath)
        {
            return new DirectoryInfo(System.IO.Path.Combine(GetExeDirPath(), subPath)).FullName;
        }

        public static string GetExeDirPath()
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            string baseDir = System.IO.Path.GetDirectoryName(a.Location);
            return baseDir;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            
        }
        public async void MovePlayer()
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

        public async void PlayMusic()
        {
            SoundPlayer player = new SoundPlayer(GetExeDirSubPath("../../References/SeparatedSoundFiles/A1.wav"));
            player.Load();
            player.Play();
            await Task.Delay(3000);
            player.SoundLocation = GetExeDirSubPath("../../References/SeparatedSoundFiles/A2.wav");
            player.Load();
            player.Play();
        }

        public void OnClick()
        {
            
        }

        

        private void Whole_Click(object sender, RoutedEventArgs e)
        {
            double length = 4;
            notes[numOfNotes, 0] = length.ToString();

            // lighten selected button
            wholeNote.Background = Brushes.LightGray;

            // darkening buttons
            dothalfNote.Background = Brushes.DarkGray;
            halfNote.Background = Brushes.DarkGray;
            dotquarterNote.Background = Brushes.DarkGray;
            quarterNote.Background = Brushes.DarkGray;
        }
        private void Dothalf_Click(object sender, RoutedEventArgs e)
        {
            double length = 3;
            notes[numOfNotes, 0] = length.ToString();
            // lighten selected button
            dothalfNote.Background = Brushes.LightGray;

            // darkening buttons
            wholeNote.Background = Brushes.DarkGray;
            halfNote.Background = Brushes.DarkGray;
            dotquarterNote.Background = Brushes.DarkGray;
            quarterNote.Background = Brushes.DarkGray;
        }

        private void Half_Click(object sender, RoutedEventArgs e)
        {
            double length = 2;
            notes[numOfNotes, 0] = length.ToString();
            // lighten selected button
            halfNote.Background = Brushes.LightGray;

            // darkening buttons
            wholeNote.Background = Brushes.DarkGray;
            dothalfNote.Background = Brushes.DarkGray;
            dotquarterNote.Background = Brushes.DarkGray;
            quarterNote.Background = Brushes.DarkGray;
        }

        private void Dotquarter_Click(object sender, RoutedEventArgs e)
        {
            double length = 1.5;
            notes[numOfNotes, 0] = length.ToString();
            // lighten selected button
            dotquarterNote.Background = Brushes.LightGray;

            // darkening buttons
            wholeNote.Background = Brushes.DarkGray;
            dothalfNote.Background = Brushes.DarkGray;
            halfNote.Background = Brushes.DarkGray;
            quarterNote.Background = Brushes.DarkGray;
        }

        private void Quarter_Click(object sender, RoutedEventArgs e)
        {
            double length = 1;
            notes[numOfNotes, 0] = length.ToString();
            // lighten selected button
            quarterNote.Background = Brushes.LightGray;

            // darkening buttons
            wholeNote.Background = Brushes.DarkGray;
            dothalfNote.Background = Brushes.DarkGray;
            halfNote.Background = Brushes.DarkGray;
            dotquarterNote.Background = Brushes.DarkGray;
        }

        private void m1b1b2_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "b2";
            //margin: left: 175, top: 1, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 1;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 1;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 1;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 1;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 1;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b1a2_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "a2";
            //margin: left: 175, top: 7, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 7;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 7;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 7;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 7;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 7;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;

        }

        private void m1b1g1_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "g1";
            //margin: left: 175, top: 13, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 13;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 13;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 13;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 13;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 13;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b1f1_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "f1";
            //margin: left: 175, top: 20, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 20;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 20;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 20;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 20;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 20;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b1e1_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "e1";
            //margin: left: 175, top: 27, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 27;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 27;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 27;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 27;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 27;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b1d1_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "d1";
            //margin: left: 175, top: 33, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 33;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 33;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 33;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 33;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 33;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b1c1_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "c1";
            //margin: left: 175, top: 13, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 40;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 40;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 40;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 40;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 40;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b1b1_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "b1";
            //margin: left: 175, top: 47, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 47;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 47;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 47;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 47;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 47;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b1a1_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "a1";
            //margin: left: 175, top: 53, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 53;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 53;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 53;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 53;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 53;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b1g0_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "g0";
            //margin: left: 175, top: 59, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 59;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 59;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 59;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 59;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 59;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b1f0_Click(object sender, EventArgs e)
        {
            string position = "m1b1";
            string noteName = "f0";
            //margin: left: 175, top: 65, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 65;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb1.Source = finalImage.Source;
            } else if (length == 3)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 65;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            } else if (length == 2)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 65;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb1.Source = finalImage.Source;
            } else if (length == 1.5)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 65;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            } else if(length == 1)
            {
                Thickness margin = m1bar1pb1.Margin;
                margin.Left = 175;
                margin.Top = 65;
                m1bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b1andb2_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "b2";
            //margin: left: 234, top: 1, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 1;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 1;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 1;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 1;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 1;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b1anda2_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "a2";
            //margin: left: 234, top: 7, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 7;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 7;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 7;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 7;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 7;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b1andg1_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "g1";
            //margin: left: 234, top: 13, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 13;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 13;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 13;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 13;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 13;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b1andf1_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "f1";
            //margin: left: 234, top: 20, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 20;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 20;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 20;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 20;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 20;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b1ande1_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "e1";
            //margin: left: 234, top: 27, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 27;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 27;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 27;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 27;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 27;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b1andd1_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "d1";
            //margin: left: 234, top: 33, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 33;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 33;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 33;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 33;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 33;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b1andc1_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "c1";
            //margin: left: 234, top: 13, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 40;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 40;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 40;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 40;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 40;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b1andb1_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "b1";
            //margin: left: 234, top: 47, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 47;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 47;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 47;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 47;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 47;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b1anda1_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "a1";
            //margin: left: 234, top: 53, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 53;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 53;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 53;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 53;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 53;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b1andg0_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "g0";
            //margin: left: 234, top: 59, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 59;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 59;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 59;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 59;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 59;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b1andf0_Click(object sender, EventArgs e)
        {
            string position = "m1b1and";
            string noteName = "f0";
            //margin: left: 234, top: 65, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 65;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 65;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 65;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 65;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 65;
                m1bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b2b2_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "b2";
            //margin: left: 290, top: 1, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 13;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 1;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 1;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 1;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 1;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b2a2_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "a2";
            //margin: left: 290, top: 7, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 7;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 7;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 7;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 7;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 7;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b2g1_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "g1";
            //margin: left: 290, top: 13, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 13;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 13;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 13;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 13;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 13;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b2f1_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "f1";
            //margin: left: 290, top: 20, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 20;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 20;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 20;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 20;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 20;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b2e1_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "e1";
            //margin: left: 290, top: 27, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 27;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 27;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 27;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 27;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 27;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b2d1_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "d1";
            //margin: left: 290, top: 33, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 33;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 33;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 33;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 33;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 33;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b2c1_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "c1";
            //margin: left: 290, top: 40, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 40;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 40;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 40;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 40;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 40;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b2b1_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "b1";
            //margin: left: 290, top: 47, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 47;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 47;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 47;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 47;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 47;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b2a1_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "a1";
            //margin: left: 290, top: 53, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 53;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 53;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 53;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 53;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 53;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b2g0_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "g0";
            //margin: left: 290, top: 59, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 59;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 59;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 59;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 59;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 59;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b2f0_Click(object sender, EventArgs e)
        {
            string position = "m1b2";
            string noteName = "f0";
            //margin: left: 290, top: 65, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 65;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 65;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 65;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 65;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 65;
                m1bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b2andb2_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "b2";
            //margin: left: 351, top: 1, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 1;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 1;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 1;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 1;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 1;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b2anda2_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "a1";
            //margin: left: 351, top: 7, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 7;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 7;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 7;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 7;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 7;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b2andg1_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "g1";
            //margin: left: 351, top: 13, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 13;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 13;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 13;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 13;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 13;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b2andf1_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "f1";
            //margin: left: 351, top: 20, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 20;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 20;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 20;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 20;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 20;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b2ande1_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "e1";
            //margin: left: 351, top: 27, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 27;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 27;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 27;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 27;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 27;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b2andd1_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "d1";
            //margin: left: 351, top: 33, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 33;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 33;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 33;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 33;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 33;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b2andc1_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "c1";
            //margin: left: 351, top: 40, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 40;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 40;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 40;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 40;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 40;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b2andb1_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "b1";
            //margin: left: 351, top: 47, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 47;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 47;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 47;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 47;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 47;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b2anda1_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "a1";
            //margin: left: 351, top: 53, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 53;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 53;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 53;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 53;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 53;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b2andg0_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "g0";
            //margin: left: 351, top: 59, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 59;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 59;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 59;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 59;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 59;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b2andf0_Click(object sender, EventArgs e)
        {
            string position = "m1b2and";
            string noteName = "f0";
            //margin: left: 351, top: 65, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 65;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 65;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 65;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 65;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 65;
                m1bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b3b2_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "b2";
            //margin: left: 406, top: 1, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 1;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 1;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 1;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 1;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 1;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b3a2_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "a2";
            //margin: left: 406, top: 7, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 7;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 7;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 7;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 7;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 7;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b3g1_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "g1";
            //margin: left: 406, top: 13, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 13;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 13;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 13;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 13;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 13;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b3f1_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "f1";
            //margin: left: 406, top: 20, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 20;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 20;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 20;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 20;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 20;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b3e1_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "e1";
            //margin: left: 406, top: 27, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 27;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 27;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 27;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 27;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 27;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b3d1_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "d1";
            //margin: left: 406, top: 33, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 33;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 33;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 33;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 33;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 33;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b3c1_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "c1";
            //margin: left: 406, top: 40, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 40;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 40;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 40;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 40;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 40;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b3b1_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "b1";
            //margin: left: 406, top: 47, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 47;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 47;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 47;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 47;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 47;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b3a1_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "a1";
            //margin: left: 406, top: 53, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 53;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 53;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 53;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 53;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 53;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b3g0_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "g0";
            //margin: left: 406, top: 59, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 59;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 59;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 59;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 59;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 59;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b3f0_Click(object sender, EventArgs e)
        {
            string position = "m1b3";
            string noteName = "f0";
            //margin: left: 406, top: 65, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 65;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 65;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 65;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 65;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 65;
                m1bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b3andb2_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "b2";
            //margin: left: 466, top: 1, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 1;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 1;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 1;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 1;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 1;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b3anda2_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "a2";
            //margin: left: 466, top: 7, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 7;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 7;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 7;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 7;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 7;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b3andg1_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "g1";
            //margin: left: 466, top: 13, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 13;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 13;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 13;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 466;
                margin.Top = 13;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 13;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b3andf1_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "f1";
            //margin: left: 466, top: 20, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 20;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 20;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 20;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 20;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 20;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b3ande1_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "e1";
            //margin: left: 466, top: 27, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 27;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 27;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 27;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 27;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 27;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b3andd1_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "d1";
            //margin: left: 466, top: 33, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 33;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 33;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 33;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 33;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 33;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b3andc1_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "c1";
            //margin: left: 466, top: 40, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 40;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 40;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 40;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 40;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 40;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b3andb1_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "b1";
            //margin: left: 466, top: 47, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 47;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 47;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 47;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 47;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 47;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b3anda1_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "a1";
            //margin: left: 466, top: 53, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 53;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 53;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 53;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 53;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 53;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b3andg0_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "g0";
            //margin: left: 466, top: 59, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 59;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 59;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 59;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 59;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 59;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b3andf0_Click(object sender, EventArgs e)
        {
            string position = "m1b3and";
            string noteName = "f0";
            //margin: left: 466, top: 65, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 65;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 65;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 65;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 65;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 65;
                m1bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b4b2_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "b2";
            //margin: left: 522, top: 1, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 1;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 1;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 1;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 1;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 1;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b4a2_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "a2";
            //margin: left: 522, top: 7, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 7;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 7;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 7;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 7;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 7;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b4g1_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "g1";
            //margin: left: 522, top: 13, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 13;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 13;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 13;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 13;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 13;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b4f1_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "f1";
            //margin: left: 522, top: 20, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 20;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 20;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 20;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 20;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 20;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b4e1_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "e1";
            //margin: left: 522, top: 27, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 27;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 27;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 27;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 27;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 27;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b4d1_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "d1";
            //margin: left: 522, top: 33, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 33;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 33;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 33;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 33;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 33;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b4c1_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "c1";
            //margin: left: 522, top: 40, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 40;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 40;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 40;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 40;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 522;
                margin.Top = 40;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b4b1_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "b1";
            //margin: left: 522, top: 47, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 47;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 47;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 47;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 47;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 47;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b4a1_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "a1";
            //margin: left: 522, top: 53, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 53;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 53;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 53;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 53;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 53;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b4g0_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "g0";
            //margin: left: 522, top: 59, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 59;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 59;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 59;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 59;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 59;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b4f0_Click(object sender, EventArgs e)
        {
            string position = "m1b4";
            string noteName = "f0";
            //margin: left: 522, top: 65, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 65;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 65;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 65;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 65;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 65;
                m1bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b4andb2_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "b2";
            //margin: left: 583, top: 1, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 1;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 1;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 1;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 1;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 1;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b4anda2_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "a2";
            //margin: left: 583, top: 7, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 7;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 7;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 7;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 7;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 7;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b4andg1_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "g1";
            //margin: left: 583, top: 13, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 13;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 13;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 13;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 13;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 13;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b4andf1_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "f1";
            //margin: left: 583, top: 20, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 20;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 20;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 20;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 20;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 20;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b4ande1_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "e1";
            //margin: left: 583, top: 27, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 27;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 27;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 27;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 27;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 27;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b4andd1_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "d1";
            //margin: left: 583, top: 33, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 33;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 33;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 33;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 33;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 33;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b4andc1_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "c1";
            //margin: left: 583, top: 40, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 40;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 40;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 40;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 40;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 40;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b4andb1_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "b1";
            //margin: left: 583, top: 47, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 47;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 47;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 47;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 47;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 47;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m1b4anda1_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "a1";
            //margin: left: 583, top: 53, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 53;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 53;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 53;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 53;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 53;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b4andg0_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "g0";
            //margin: left: 583, top: 59, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 59;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 59;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 59;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 59;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 59;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m1b4andf0_Click(object sender, EventArgs e)
        {
            string position = "m1b4and";
            string noteName = "f0";
            //margin: left: 583, top: 65, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 65;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 65;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 65;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 65;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m1bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 65;
                m1bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m1bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b1b2_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "b2";
            //margin: left: 174, top: 138, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 138;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 138;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 138;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 138;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 138;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b1a2_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "a2";
            //margin: left: 174, top: 144, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 144;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 144;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 144;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 144;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 144;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b1g1_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "g1";
            //margin: left: 174, top: 150, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 150;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 150;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 150;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 150;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 150;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b1f1_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "f1";
            //margin: left: 174, top: 157, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 157;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 157;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 157;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 157;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 160;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b1e1_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "e1";
            //margin: left: 174, top: 164, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 164;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 164;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 164;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 164;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 164;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b1d1_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "d1";
            //margin: left: 174, top: 170, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 170;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 170;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 170;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 170;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 170;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b1c1_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "c1";
            //margin: left: 174, top: 177, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 177;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 177;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 177;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 177;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 177;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b1b1_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "b1";
            //margin: left: 174, top: 184, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 184;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 184;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 184;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 184;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 184;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b1a1_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "a1";
            //margin: left: 174, top: 190, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 190;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 190;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 190;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 190;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 190;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b1g0_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "g0";
            //margin: left: 174, top: 196, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 196;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 196;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 196;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 196;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 196;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b1f0_Click(object sender, EventArgs e)
        {
            string position = "m2b1";
            string noteName = "f0";
            //margin: left: 174, top: 202, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 202;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 202;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 202;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 202;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb1.Margin;
                margin.Left = 174;
                margin.Top = 202;
                m2bar1pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b1andb2_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "b2";
            //margin: left: 234, top: 138, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 138;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 138;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 138;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 138;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 138;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b1anda2_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "a2";
            //margin: left: 234, top: 144, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 144;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 144;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 144;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 144;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 144;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b1andg1_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "g1";
            //margin: left: 234, top: 150, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 150;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 150;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 150;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 150;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 150;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b1andf1_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "f1";
            //margin: left: 234, top: 157, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 157;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 157;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 157;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 157;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 157;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b1ande1_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "e1";
            //margin: left: 234, top: 164, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 164;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 164;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 164;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 164;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 164;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b1andd1_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "d1";
            //margin: left: 234, top: 170, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 170;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 170;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 170;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 170;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 170;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b1andc1_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "c1";
            //margin: left: 234, top: 177, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 177;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 177;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 177;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 177;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 177;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b1andb1_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "b1";
            //margin: left: 234, top: 184, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 184;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 184;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 184;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 184;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 184;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b1anda1_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "a1";
            //margin: left: 234, top: 190, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 190;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 190;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 190;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 190;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 190;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b1andg0_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "g0";
            //margin: left: 234, top: 196, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 196;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 196;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 196;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 196;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 196;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b1andf0_Click(object sender, EventArgs e)
        {
            string position = "m2b1and";
            string noteName = "f0";
            //margin: left: 234, top: 202, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 202;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 202;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 202;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 202;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb2.Margin;
                margin.Left = 234;
                margin.Top = 202;
                m2bar1pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b2b2_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "b2";
            //margin: left: 290, top: 138, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 138;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 138;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 138;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 138;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 138;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b2a2_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "a2";
            //margin: left: 290, top: 144, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 144;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 144;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 144;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 144;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 144;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b2g1_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "g1";
            //margin: left: 290, top: 150, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 150;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 150;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 150;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 150;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 150;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b2f1_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "f1";
            //margin: left: 290, top: 157, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 157;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 157;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 157;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 157;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 157;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b2e1_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "e1";
            //margin: left: 290, top: 164, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 164;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 164;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 164;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 164;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 164;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b2d1_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "d1";
            //margin: left: 290, top: 170, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 170;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 170;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 170;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 170;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 170;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b2c1_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "c1";
            //margin: left: 290, top: 177, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 177;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 177;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 177;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 177;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 177;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b2b1_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "b1";
            //margin: left: 290, top: 184, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 184;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 184;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 184;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 184;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 184;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b2a1_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "a1";
            //margin: left: 290, top: 190, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 190;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 190;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 190;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 190;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 190;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b2g0_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "g0";
            //margin: left: 290, top: 196, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 196;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 196;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 196;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 196;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 196;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b2f0_Click(object sender, EventArgs e)
        {
            string position = "m2b2";
            string noteName = "f0";
            //margin: left: 290, top: 202, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 202;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 202;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 202;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 202;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb3.Margin;
                margin.Left = 290;
                margin.Top = 202;
                m2bar1pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b2andb2_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "b2";
            //margin: left: 351, top: 138, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 138;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 138;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 138;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 138;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 138;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b2anda2_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "a2";
            //margin: left: 351, top: 144, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 144;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 144;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 144;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 144;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 144;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b2andg1_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "g1";
            //margin: left: 351, top: 150, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 150;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 150;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 150;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 150;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 150;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b2andf1_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "f1";
            //margin: left: 351, top: 157, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 157;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 157;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 157;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 157;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 157;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void m2b2ande1_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "e1";
            //margin: left: 351, top: 164, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 164;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 164;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 164;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 164;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 164;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b2andd1_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "d1";
            //margin: left: 351, top: 170, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;

            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 170;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 170;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 170;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 170;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 170;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b2andc1_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "c1";
            //margin: left: 351, top: 177, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);

            if (length == 4)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 177;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 177;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 177;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 177;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 351;
                margin.Top = 177;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b2andb1_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "b1";
            //margin: left: 351, top: 184, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 184;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 184;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 184;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 184;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 184;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b2anda1_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "a1";
            //margin: left: 351, top: 190, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 190;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 190;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 190;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 190;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 190;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b2andg0_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "g0";
            //margin: left: 351, top: 196, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 196;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 196;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 196;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 196;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 196;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b2andf0_Click(object sender, EventArgs e)
        {
            string position = "m2b2and";
            string noteName = "f0";
            //margin: left: 351, top: 202, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 202;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 202;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 202;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 202;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar1pb4.Margin;
                margin.Left = 406;
                margin.Top = 202;
                m2bar1pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar1pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3b2_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "b2";
            //margin: left: 406, top: 138, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 138;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 138;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 138;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 138;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 138;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3a2_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "a2";
            //margin: left: 406, top: 144, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 144;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 144;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 144;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 144;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 144;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3g1_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "g1";
            //margin: left: 406, top: 150, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 150;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 150;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 150;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 150;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 150;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3f1_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "f1";
            //margin: left: 406, top: 157, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 157;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 157;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 157;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 157;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 157;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3e1_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "e1";
            //margin: left: 406, top: 164, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 164;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 164;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 164;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 164;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 164;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3d1_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "d1";
            //margin: left: 406, top: 170, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 170;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 170;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 170;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 170;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 170;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3c1_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "c1";
            //margin: left: 406, top: 177, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 177;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 177;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 177;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 177;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 177;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3b1_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "b1";
            //margin: left: 406, top: 184, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 184;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 184;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 184;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 184;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 184;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3a1_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "a1";
            //margin: left: 406, top: 190, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 190;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 190;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 190;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 190;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 190;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3g0_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "g0";
            //margin: left: 406, top: 196, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 196;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 196;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 196;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 196;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 196;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3f0_Click(object sender, EventArgs e)
        {
            string position = "m2b3";
            string noteName = "f0";
            //margin: left: 406, top: 202, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 202;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 202;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 202;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 202;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb1.Margin;
                margin.Left = 406;
                margin.Top = 202;
                m2bar2pb1.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb1.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3andb2_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "b2";
            //margin: left: 466, top: 138, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 138;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 138;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 138;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 138;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 138;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3anda2_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "a2";
            //margin: left: 466, top: 144, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 144;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 144;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 144;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 144;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 144;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3andg1_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "g1";
            //margin: left: 466, top: 153, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 150;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 150;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 150;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 150;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 150;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3andf1_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "f1";
            //margin: left: 466, top: 157, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 157;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 157;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 157;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 157;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 157;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3ande1_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "e1";
            //margin: left: 466, top: 164, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 164;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 164;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 164;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 164;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 164;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3andd1_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "d1";
            //margin: left: 466, top: 170, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 177;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 177;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 177;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 177;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 177;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3andc1_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "c1";
            //margin: left: 466, top: 177, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 177;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 177;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 177;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 177;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 177;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3andb1_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "b1";
            //margin: left: 466, top: 184, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 184;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 184;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 184;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 184;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 184;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3anda1_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "a1";
            //margin: left: 466, top: 190, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 190;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 190;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 190;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 190;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 190;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3andg0_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "g0";
            //margin: left: 466, top: 196, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 196;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 196;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 196;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 196;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 196;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b3andf0_Click(object sender, EventArgs e)
        {
            string position = "m2b3and";
            string noteName = "f0";
            //margin: left: 466, top: 202, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 202;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 202;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 202;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 202;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb2.Margin;
                margin.Left = 466;
                margin.Top = 202;
                m2bar2pb2.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb2.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4b2_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "b2";
            //margin: left: 522, top: 138, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 138;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 138;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 138;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 138;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 138;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4a2_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "a2";
            //margin: left: 522, top: 144, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 144;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 144;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 144;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 144;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 144;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4g1_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "g1";
            //margin: left: 522, top: 153, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 150;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 150;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 150;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 150;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 150;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4f1_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "f1";
            //margin: left: 522, top: 157, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 157;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 157;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 157;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 157;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 157;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4e1_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "e1";
            //margin: left: 522, top: 164, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 164;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 164;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 164;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 164;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 164;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4d1_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "d1";
            //margin: left: 522, top: 170, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 170;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 170;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 170;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 170;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 170;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4c1_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "c1";
            //margin: left: 522, top: 177, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 177;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 177;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 177;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 177;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 177;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4b1_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "b1";
            //margin: left: 522, top: 184, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 184;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 184;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 184;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 184;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 184;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4a1_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "a1";
            //margin: left: 522, top: 190, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 190;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 190;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 190;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 190;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 190;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4g0_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "g0";
            //margin: left: 522, top: 196, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 196;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 196;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 196;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 196;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 196;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4f0_Click(object sender, EventArgs e)
        {
            string position = "m2b4";
            string noteName = "f0";
            //margin: left: 522, top: 202, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 202;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 202;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 202;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 202;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb3.Margin;
                margin.Left = 522;
                margin.Top = 202;
                m2bar2pb3.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb3.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4andb2_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "b2";
            //margin: left: 583, top: 138, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 138;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 138;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 138;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 138;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 138;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4anda2_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "a2";
            //margin: left: 583, top: 144, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 144;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 144;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 144;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 144;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 144;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4andg1_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "g1";
            //margin: left: 583, top: 153, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 150;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 150;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 150;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 150;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 150;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4andf1_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "f1";
            //margin: left: 583, top: 157, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 157;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 157;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 157;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 157;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 157;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4ande1_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "e1";
            //margin: left: 583, top: 164, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 164;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 164;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 164;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 164;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 164;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4andd1_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "d1";
            //margin: left: 583, top: 170, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 170;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 170;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 170;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 170;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 170;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4andc1_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "c1";
            //margin: left: 583, top: 177, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 177;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 177;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 177;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 177;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 177;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4andb1_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "b1";
            //margin: left: 583, top: 184, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 190;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 190;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 190;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 190;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 190;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4anda1_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "a1";
            //margin: left: 583, top: 190, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 190;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 190;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 190;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 190;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 190;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4andg0_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "g0";
            //margin: left: 583, top: 196, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 196;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 196;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 196;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 196;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 196;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }
        private void m2b4andf0_Click(object sender, EventArgs e)
        {
            string position = "m2b4and";
            string noteName = "f0";
            //margin: left: 583, top: 202, right: 0, bottom: 0
            notes[numOfNotes, 1] = position;
            notes[numOfNotes, 2] = noteName;
            double length = Double.Parse(notes[numOfNotes, 0]);
            if (length == 4)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 202;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/wholenote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 3)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 202;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedhalfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 2)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 202;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/halfnote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1.5)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 202;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/dottedquarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            else if (length == 1)
            {
                Thickness margin = m2bar2pb4.Margin;
                margin.Left = 583;
                margin.Top = 202;
                m2bar2pb4.Margin = margin;
                Image finalImage = new Image();
                finalImage.Source = new BitmapImage(new Uri("pack://application:,,,/References/Images/quarternote.png"));
                m2bar2pb4.Source = finalImage.Source;
            }
            numOfNotes++;
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            PlayMusic();
            MovePlayer();
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
