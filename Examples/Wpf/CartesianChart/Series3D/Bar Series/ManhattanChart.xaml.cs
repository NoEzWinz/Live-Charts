using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;

namespace Wpf.CartesianChart.Series3D.Bar_Series
{
    /// <summary>
    /// Interaction logic for ManhattanChart.xaml
    /// </summary>
    public partial class ManhattanChart : UserControl
    {
        public ManhattanChart()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection3D
            {
                new ManhattanBarSeries()
                {
                    Title = "2015",
                    Values = new ChartValues3D<double> { 10, 50, 39, 50 }
                }
            };

            //adding series will update and animate the chart automatically
            SeriesCollection.Add(new ManhattanBarSeries
            {
                Title = "2016",
                Values = new ChartValues3D<double> { 11, 56, 42 }
            });

            //also adding values updates and animates the chart automatically
            SeriesCollection[1].Values.Add(48d);

            Labels = new[] { "Maria", "Susan", "Charles", "Frida" };
            Formatter = value => value.ToString("N");

            DataContext = this;
        }

        public SeriesCollection3D SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }
    }
}
