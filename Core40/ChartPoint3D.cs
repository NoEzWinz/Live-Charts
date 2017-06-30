﻿//The MIT License(MIT)

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

using LiveCharts.Definitions.Charts;
using LiveCharts.Definitions.Points;
using LiveCharts.Definitions.Series;
using LiveCharts.Dtos;

namespace LiveCharts
{
    /// <summary>
    /// Defines a point in the chart
    /// </summary>
    public class ChartPoint3D : ChartPoint
    {

        #region Cartesian 

        /// <summary>
        /// Gets the Z point value
        /// </summary>
        public double Z { get; internal set; }

        #endregion


        /// <summary>
        /// Gets the series where the point belongs to
        /// </summary>
        public new ISeriesView3D SeriesView { get; internal set; }




        /// <summary>
        /// Gets the chart view.
        /// </summary>
        /// <value>
        /// The chart view.
        /// </value>
        public new IChartView3D ChartView { get { return SeriesView.Model.Chart.View; } }


    }
}