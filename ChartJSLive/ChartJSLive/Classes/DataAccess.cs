using ChartJSLive.Models;
using System.Data;

namespace ChartJSLive.Classes
{
    public class DataAccess
    {
        public static ViewData GetViewData()
        {
            DataSet ChartDataSet = new DataSet();
            string[] arrayOfDays = {
                "Mandag",
                "Tirsdag",
                "Onsdag",
                "Torsdag",
                "Fredag",
                "Lørdag",
                "Søndag"
            };
            Random rnd = new Random();

            ChartDataSet.Tables.Add("Scatters");

            ChartDataSet.Tables[0].Columns.Add("X", typeof(int));
            ChartDataSet.Tables[0].Columns.Add("Y", typeof(string));

            var ViewData = new ViewData();

            for (int i = 0; i < 7; i++)
            {
                ChartDataSet.Tables[0].Rows.Add(rnd.Next(0, 100), arrayOfDays[i]);
            }

            for(int tableIndex = 0; tableIndex < ChartDataSet.Tables.Count; tableIndex++)
            {
                for (int rowIndex = 0; rowIndex < ChartDataSet.Tables[tableIndex].Rows.Count; rowIndex++)
                {
                    var tempData = new Scatter();
                    tempData.X = int.Parse(ChartDataSet.Tables[tableIndex].Rows[rowIndex]["X"].ToString());
                    tempData.Y = ChartDataSet.Tables[tableIndex].Rows[rowIndex]["Y"].ToString();

                    ViewData.ListOfScatters.Add(tempData);
                }
            }
            return ViewData;
        }
    }
}
