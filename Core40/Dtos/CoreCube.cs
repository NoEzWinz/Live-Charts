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

using System;

namespace LiveCharts.Dtos
{

    /// <summary>
    /// 
    /// </summary>
    public class CoreCube : CoreRectangle
    {

        private double _depth;

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreCube"/> class.
        /// </summary>
        public CoreCube()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreCube"/> class.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="top">The top.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="depth">The height.</param>
        public CoreCube(double left, double top, double width, double height, double depth) : base(left,top,width,height)
        {

            Depth = depth;
        }

        /// <summary>
        /// Occurs when [set depth].
        /// </summary>
        public event Action<double> SetDepth;

        /// <summary>
        /// Gets or sets the depth.
        /// </summary>
        /// <value>
        /// The left.
        /// </value>
        public double Depth
        {
            get { return _depth; }
            set
            {
                _depth = value;
                if (SetDepth != null) SetDepth.Invoke(value);
            }
        }

    }
}