using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MusicAppAT.ViewModels
{
    public class Functions
    {
        int[] beats = new int[16];
        int count = 0;
        int note = 0;

        private void GetCount()
        {
            foreach (int i in beats)
            {
                count += count;
            }
        }

        private void OnClick()
        {
            GetCount();

            // whole note
            if (note == 4) {
                if (count > 0) {
                    MessageBox.Show("No more than 4 beats per bar!");
                }
                else
                {
                    //code to make whole note photo visible;
                }
            }

            //dotted half note
            if (note == 3) {
                if (count > 1) {
                    MessageBox.Show("No more than 4 beats per bar!");
                }
                else
                {
                    //code to make dotted half note photo visible;
                }
            }

            //dotted quarter note
            if (note == 2.5) {
                if (count > 2) {
                    MessageBox.Show("No more than 4 beats per bar!");
                }
                else
                {
                    //code to make dotted quarter note photo visible;
                }
            }

            // half note
            if (note == 2) {
                if (count > 2) {
                    MessageBox.Show("No more than 4 beats per bar!");
                }
                else
                {
                    //code to make half note photo visible;
                }
            }

            //quarter note
            if (note == 1) {
                if (count > 3) {
                    MessageBox.Show("No more than 4 beats per bar!");
                }
                else
                {
                    //code to make quarter note photo visible;
                }
            }
        }

    }
}
