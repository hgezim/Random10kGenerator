using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random10kGUI
{
    /// <summary>
    /// Generates random numbers given a range and desired numbers.
    /// Uniqueness is guaranteed, if number range and list length match.
    /// </summary>
    class Randomness
    {
        private int _lowestNumber;
        private int _highestNumber;
        private int _listLength;
        private Random _random;

        /// <summary>
        /// Initialize "randomness" object. 
        /// </summary>
        /// <param name="low">
        /// A <see cref="System.Int32"/>
        /// The lowest number in the random range.
        /// </param>
        /// <param name="high">
        /// A <see cref="System.Int32"/>
        /// The highest number in the random range.
        /// </param>
        /// <param name="length">
        /// A <see cref="System.Int32"/>
        /// The number of random numbers you need.
        /// </param>
        public Randomness(int low, int high, int length)
        {
            if (low >= high)
            {
                throw new ArgumentException("'low' argument must be smaller than 'high'.");
            }

            _lowestNumber = low;
            _highestNumber = high;
            _listLength = length;

            // get random number
            _random = new Random();
        }

        /// <summary>
        /// Return the list. Print the top half of the list first, then the bottom half.
        /// </summary>
        public int[] generate()
        {
            int[] randomList = new int[_listLength];

            // determine whether they can be unique
            bool generateUnique = (_highestNumber - _lowestNumber + 1) == _listLength;

            if (generateUnique)
            {
                // fill array incrementally (it will be shuffled later)
                for (int i = 0; i < _listLength; i++)
                {
                    int indexValue = i + 1;
                    randomList[i] = indexValue;
                }

                // sort array randomly
                for (int i = 0; i < _listLength; i++)
                {
                    int swapIndex = _random.Next(_lowestNumber, _highestNumber);
                    int tempNumber = randomList[swapIndex];
                    randomList[swapIndex] = randomList[i];
                    randomList[i] = tempNumber;
                }
            }
            else
            {
                // fill array with random numbers
                for (int i = 0; i < _listLength; i++)
                {
                    randomList[i] = _random.Next(_lowestNumber, _highestNumber + 1);
                }

            }

            return randomList;
        }

    }
}
