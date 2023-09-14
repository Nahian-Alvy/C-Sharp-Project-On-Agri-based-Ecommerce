using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project2
{
    public partial class AdminRevenue : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public AdminRevenue()
        {
            InitializeComponent();
        }
        private void LoadChartData()
        {

            using (SqlConnection connection = new SqlConnection(cs))
            {
                string query = "SELECT Amount, Serialno FROM Revenue";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<int> months = new List<int>();
                        List<int> revenues = new List<int>();

                        while (reader.Read())
                        {
                            months.Add(Convert.ToInt32(reader["Serialno"]));
                            revenues.Add(Convert.ToInt32(reader["Amount"]));
                        }

                        // Clear existing data in the chart
                        chart1.Series.Clear();

                        // Add a new series to the chart
                        Series series = new Series("Total Purchase By A Customer");
                        series.ChartType = SeriesChartType.Column;

                        // Add data points to the series
                        for (int i = 0; i < months.Count; i++)
                        {
                            series.Points.AddXY(months[i], revenues[i]);
                        }

                        // Add the series to the chart
                        chart1.Series.Add(series);
                        chart1.Refresh();
                    }
                }
            }
        }
        private void AdminRevenue_Load(object sender, EventArgs e)
        {
            LoadChartData();
        }
    }
}
