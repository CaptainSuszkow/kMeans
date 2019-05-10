using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.WindowsForms;
using OxyPlot.Series;
using OxyPlot.Axes;

namespace Kmeans
{
    public partial class Form2 : Form
    {
        public List<double> PlotData;

        public Form2(List<double> data)
        {
            PlotData = data;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Controls.Add(pv);
            PlotModel pm = new PlotModel();
            pv.Model = pm;

            LineSeries plotSeries = new LineSeries()
            {
                LineStyle = LineStyle.Solid,
                MarkerType = MarkerType.Diamond,
                Color = OxyColors.Blue,
                MarkerSize = 1,
                MarkerStroke = OxyColors.Blue,
                Title = "Quantization Error"
            };

            for (int i = 0; i < PlotData.Count; i++)
            {
                plotSeries.Points.Add(new DataPoint(i, PlotData[i]));
            }

            pm.Axes.Add(new OxyPlot.Axes.LinearAxis
            {
                Position = OxyPlot.Axes.AxisPosition.Bottom,
                MinimumPadding = 0.1,
                MaximumPadding = 0.1,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                Title = "Epoch"
            });
            pm.Axes.Add(new OxyPlot.Axes.LinearAxis
            {
                Position = OxyPlot.Axes.AxisPosition.Left,
                MinimumPadding = 0.1,
                MaximumPadding = 0.1,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                Title = "Average distansce from centroids"
            });

            pm.Series.Add(plotSeries);
        }
    }
}
