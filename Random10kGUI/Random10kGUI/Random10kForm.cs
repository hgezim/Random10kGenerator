using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Random10kGUI
{
    /// <summary>
    /// GUI to generate a desire number of random numbers. Allows you to choose a range too.
    /// </summary>
    public partial class Random10kGUIForm : Form
    {
        enum DisplayModes {Initial, Generating, Generated};

        /// <summary>
        /// Initialize form.
        /// </summary>
        public Random10kGUIForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clear random number list and generate new numbers.
        /// Random number list is made visible if it's not already visible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateButton_Click(object sender, EventArgs e)
        {
            this.updateGUI(DisplayModes.Generating);

            int lowRange = Convert.ToInt16(lowestNumberNumericUpDown.Value);
            int highRange = Convert.ToInt16(highestNumberNumericUpDown.Value);
            int listSize = Convert.ToInt16(numberOfRandomNumbersNumericUpDown.Value);

            // initialize Randomness and generate the numbers
            Randomness randomListGenerator = new Randomness(lowRange, highRange, listSize);
            int[] numberList = randomListGenerator.generate();

            // clear list box
            randomNumberListBox.Items.Clear();

            // popluate list
            for (int i=0; i<numberList.Length; i++)
            {
                randomNumberListBox.Items.Add(numberList[i]);
            }

            this.updateGUI(DisplayModes.Generated);
        }

        /// <summary>
        /// Remove selected numbers from the random number list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveSelectedButton_Click(object sender, EventArgs e)
        {
            while (randomNumberListBox.SelectedItems.Count > 0)
            {
                randomNumberListBox.Items.Remove(randomNumberListBox.SelectedItem);
            }
        }

        /// <summary>
        /// Updates the GUI to reflect the state of the program.
        /// </summary>
        /// <param name="mode">Can be a value of DisplayModes enum.</param>
        private void updateGUI(DisplayModes mode)
        {
            if (mode == DisplayModes.Generating)
            {
                // how GUI looks when random numbers are being generated
                generateButton.Text = "...";
            }
            else if (mode == DisplayModes.Generated)
            {
                // how GUI looks when random numbers are generated
                this.Height = 427;
                generateButton.Text = "Regenerate";
            }
        }
    }
}
