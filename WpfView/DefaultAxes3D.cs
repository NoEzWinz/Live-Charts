//The MIT License(MIT)

//Copyright(c) 2016 Alberto Rodriguez & LiveCharts Contributors

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

using System.Windows;

namespace LiveCharts.Wpf
{
    /// <summary>
    /// Contains a collection of already defined axes.
    /// </summary>
    public static class DefaultAxes3D
    {
        /// <summary>
        /// Returns default axis
        /// </summary>
        public static AxesCollection3D DefaultAxis
        {
            get { return new AxesCollection3D {new Axis3D()}; }
        }

        /// <summary>
        /// Return an axis without separators at all
        /// </summary>
        public static AxesCollection3D CleanAxis
        {
            get
            {
                return new AxesCollection3D
                {
                    new Axis3D
                    {
                        IsEnabled = false,
                        Separator = CleanSeparator
                    }
                };
            }
        }

        /// <summary>
        /// Returns an axis that only displays a line for zero
        /// </summary>
        public static AxesCollection3D OnlyZerosAxis
        {
            get
            {
                return new AxesCollection3D
                {
                    new Axis3D
                    {
                        IsEnabled = true,
                        Separator = CleanSeparator
                    }
                };
            }
        }


        //Returns a clean separator
        /// <summary>
        /// Gets the clean separator.
        /// </summary>
        /// <value>
        /// The clean separator.
        /// </value>
        public static Separator3D CleanSeparator
        {
            get
            {
                return new Separator3D
                {
                    Visibility = Visibility.Collapsed
                };
            }
        }

    }
}