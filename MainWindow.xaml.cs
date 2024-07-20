using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WPF;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Trial
{
    public partial class MainWindow : Window
    {
        string connectionString = "Server=localhost;Database=test;Integrated Security=true;TrustServerCertificate=true;";

        ObservableCollection<ObservableValue> main1List = new ObservableCollection<ObservableValue>();
        ObservableCollection<ObservableValue> main2List = new ObservableCollection<ObservableValue>();
        ObservableCollection<ObservableValue> main3List = new ObservableCollection<ObservableValue>();
        List<DateTime> dates = new List<DateTime>();
        public ISeries[] SeriesCollection { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            GetPieData();
            LoadPieChart();
        }

        private void LoadPieChart()
        {
            SeriesCollection = new ISeries[]
            {
                new PieSeries<ObservableValue> { Values = main1List, Name = "Main1" },
                new PieSeries<ObservableValue> { Values = main2List, Name = "Main2" },
                new PieSeries<ObservableValue> { Values = main3List, Name = "Main3" }
            };
            samplePie.Series = SeriesCollection;
        }

        private void GetPieData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM table_1";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            main1List.Add(new ObservableValue { Value = reader.GetDouble(reader.GetOrdinal("Main1")) });
                            main2List.Add(new ObservableValue { Value = reader.GetDouble(reader.GetOrdinal("Main2")) });
                            main3List.Add(new ObservableValue { Value = reader.GetDouble(reader.GetOrdinal("Main3")) });
                           
                        }
                    }
                }
            }
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            DateTime petsa = DateTime.Parse(date.SelectedDate.ToString());
            string first = main1.Text;
            string second = main2.Text;
            string third = main3.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO [dbo].[Table_1]
                                 ([Date], [Main1], [Main2], [Main3])
                                 VALUES
                                 (@date, @value1, @value2, @value3)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@date", petsa);
                    command.Parameters.AddWithValue("@value1", first);
                    command.Parameters.AddWithValue("@value2", second);
                    command.Parameters.AddWithValue("@value3", third);

                    var result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("yeey! uploaded!");
                        // Clear existing lists
                        main1List.Clear();
                        main2List.Clear();
                        main3List.Clear();
                        // Reload data
                        GetPieData();
                        // Refresh the chart
                        LoadPieChart();
                    }
                    else
                    {
                        MessageBox.Show("Oh noooo");
                    }
                }
            }
        }
    }
}
