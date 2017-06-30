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
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using LiveCharts.Charts;


namespace LiveCharts.Wpf.Charts.Base
{
    /// <summary>
    /// Base chart class
    /// </summary>
    public abstract class Chart3D : Chart
    {
        /// <summary>
        /// Chart core model, the model calculates the chart.
        /// </summary>
       protected new ChartCore3D ChartCoreModel;



        static Chart3D()
        {
            Randomizer = new Random();
        }

        /// <summary>
        /// The axis y property
        /// </summary>
        public new static readonly DependencyProperty AxisYProperty = DependencyProperty.Register(
            "AxisY", typeof(AxesCollection3D), typeof(Chart3D),
            new PropertyMetadata(null, AxisInstancechanged(AxisOrientation.Y)));
        /// <summary>
        /// Gets or sets vertical axis
        /// </summary>
        public new AxesCollection3D AxisY
        {
            get { return (AxesCollection3D)GetValue(AxisYProperty); }
            set { SetValue(AxisYProperty, value); }
        }

        /// <summary>
        /// The axis x property
        /// </summary>
        public new static readonly DependencyProperty AxisXProperty = DependencyProperty.Register(
            "AxisX", typeof(AxesCollection3D), typeof(Chart3D),
            new PropertyMetadata(null, AxisInstancechanged(AxisOrientation.X)));

        /// <summary>
        /// Gets or sets horizontal axis
        /// </summary>
        public new AxesCollection3D AxisX
        {
            get { return (AxesCollection3D)GetValue(AxisXProperty); }
            set { SetValue(AxisXProperty, value); }
        }
        /// <summary>
        /// The axis x property
        /// </summary>
        public static readonly DependencyProperty AxisZProperty = DependencyProperty.Register(
            "AxisZ", typeof(AxesCollection3D), typeof(Chart3D),
            new PropertyMetadata(null, AxisInstancechanged(AxisOrientation.Z)));

        /// <summary>
        /// Gets or sets horizontal axis
        /// </summary>
        public AxesCollection3D AxisZ
        {
            get { return (AxesCollection3D)GetValue(AxisZProperty); }
            set { SetValue(AxisZProperty, value); }
        }


       
        /// <summary>
        /// Gets the chart model, the model is who calculates everything, is the engine of the chart
        /// </summary>
        public new ChartCore3D Model
        {
            get { return ChartCoreModel; }
        }

        

        #region Public Methods

       

        /// <summary>
        /// Maps the x axes.
        /// </summary>
        /// <param name="chart">The chart.</param>
        /// <returns></returns>
        public List<AxisCore> MapXAxes(ChartCore3D chart)
        {
            if (DesignerProperties.GetIsInDesignMode(this) && AxisX == null)
                AxisX = DefaultAxes3D.DefaultAxis;

            if (AxisX.Count == 0)
                AxisX.Add(new Axis {Separator = new Separator()});

            AxisX.Chart3D = this;

            return AxisX.Select(x =>
            {
                if (x.Parent == null)
                {
                    x.AxisOrientation = AxisOrientation.X;
                    if (x.Separator != null) chart.View.AddToView(x.Separator);
                    chart.View.AddToView(x);
                }
                return x.AsCoreElement(Model, AxisOrientation.X);
            }).ToList();
        }

        /// <summary>
        /// Maps the y axes.
        /// </summary>
        /// <param name="chart">The chart.</param>
        /// <returns></returns>
        public List<AxisCore> MapYAxes(ChartCore3D chart)
        {
            if (DesignerProperties.GetIsInDesignMode(this) && AxisY == null)
                AxisY = DefaultAxes3D.DefaultAxis;

            if (AxisY.Count == 0)
                AxisY.Add(new Axis { Separator = new Separator() });

            AxisY.Chart3D = this;

            return AxisY.Select(y =>
            {
                if (y.Parent == null)
                {
                    y.AxisOrientation = AxisOrientation.Y;
                    if (y.Separator != null) chart.View.AddToView(y.Separator);
                    chart.View.AddToView(y);
                }
                return y.AsCoreElement(Model, AxisOrientation.Y);
            }).ToList();
        }



        /// <summary>
        /// Maps the z axes.
        /// </summary>
        /// <param name="chart">The chart.</param>
        /// <returns></returns>
        public List<AxisCore> MapZAxes(ChartCore3D chart)
        {
            if (DesignerProperties.GetIsInDesignMode(this) && AxisZ== null)
                AxisZ = DefaultAxes3D.DefaultAxis;

            if (AxisZ.Count == 0)
                AxisZ.Add(new Axis {Separator = new Separator()});

            AxisZ.Chart3D = this;

            return AxisZ.Select(z =>
            {
                if (z.Parent == null)
                {
                    z.AxisOrientation = AxisOrientation.Z;
                    if (z.Separator != null) chart.View.AddToView(z.Separator);
                    chart.View.AddToView(z);
                }
                return z.AsCoreElement(Model, AxisOrientation.Z);
            }).ToList();
        }

      
       
        #endregion





     }
}
