using SfDataGridSample;
using Syncfusion.Maui.Data;
using Syncfusion.Maui.DataGrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample
{

    public class OrderInfoRepository
    {
        public string Demo = "Solution";

        private string headerText;


        public string HeaderText
        {
            get { return headerText; }
            set
            {
                headerText = value;
            }
        }
        private ObservableCollection<OrderInfo> orderInfo;

        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get { return orderInfo; }
            set { this.orderInfo = value; }
        }
      

        public OrderInfoRepository()
        {
            orderInfo = new ObservableCollection<OrderInfo>();
            this.CustomerNames = Customers.ToObservableCollection();
            this.GenerateOrders();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Dictionary<string, object> Values { get; } = new Dictionary<string, object>();
        public ObservableCollection<string> CustomerNames { get; set; }

        internal string[] Customers = new string[] { "Adams", "Crowley", "Ellis", "Gable", "Irvine", "Keefe", "Mendoza", "Owens", "Rooney", "Wadded", };


        public void GenerateOrders()
        {
            //for (int i = 1; i <= 50; i++)
            //{
            //    orderInfo.Add(new OrderInfo(i, new DateTime(2023, 12, 6, 10, 30, 0), "Adams", "Germany", "ALFKI", "Berlin", true, 20000, "Maria Anders", "Germany", "ALFKI", "Berlin", true, "1003", "Maria Anders", "Germany", "ALFKI", "Berlin", true));

            //    //orderInfo.Add(new OrderInfo(i, "Maria Anders", "India", "ALFKI", "Berlin", true, 1001, "Maria Anders", "Germany", "ALFKI", "Berlin", true, "1001", "Maria Anders", "Germany", "ALFKI", "Berlin", true));
            //}

            //orderInfo.Add(new OrderInfo(1001, "Adams", "Germany", "ALFKI", "Berlin", true, 20000, "Maria Anders", "Germany", "ALFKI", "Berlin", true, "1003", "Maria Anders", "Germany", "ALFKI", "Berlin", true));
            //orderInfo.Add(new OrderInfo(1001, "Adams", "Germany", "ALFKI", "Berlin", true, 20000, "Maria Anders", "Germany", "ALFKI", "Berlin", true, "1003", "Maria Anders", "Germany", "ALFKI", "Berlin", true));
            orderInfo.Add(new OrderInfo(1001, "Adams", "Germany", "ALFKI", "Berlin", true, 20000, "Maria Anders", "Germany", "ALFKI", "Berlin", true, "1003", "Maria Anders", "Germany", "ALFKI", "Berlin", true));
            orderInfo.Add(new OrderInfo(1002, "Kumar", "India", "ALFKI", "Chennai", true, 20000, "Maria Anders", "Germany", "ALFKI", "Berlin", true, "1004", "Maria Anders", "Germany", "ALFKI", "Berlin", true));
            orderInfo.Add(new OrderInfo(1003, "Adams", "Japan", "ALFKI", "Tokyo", true, 21000, "Sanjay", "France", "Sudhar", "India", false, "1005", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1004, "Tim", "Germany", "Som", "Berlin", true, 21000, "Maria Anders", "Germany", "ALFKI", "Berlin", true, "1001", "Maria Anders", "Germany", "ALFKI", "Berlin", true));
            orderInfo.Add(new OrderInfo(1005, "Maria", "France", "ALFKI", "Paris", false, 21000, "Maria Anders", "Germany", "ALFKI", "Berlin", true, "1002", "Maria Anders", "Germany", "ALFKI", "Berlin", true));
            orderInfo.Add(new OrderInfo(1006, "Adams", "Germany", "ALFKI", "Berlin", true, 1003, "Maria Anders", "Germany", "ALFKI", "Berlin", true, "1003", "Maria Anders", "Germany", "ALFKI", "Berlin", true));
            orderInfo.Add(new OrderInfo(1007, "Maria", "Germany", "ALFKI", "Berlin", true, 1007, "Sanjay", "France", "Sudhar", "India", true, "1007", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1008, "Maria", "Nepal", "ALFKI", "Berlin", true, 1008, "Sanjay", "France", "Sudhar", "India", false, "1008", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1009, "Maria", "Nepal", "ALFKI", "Berlin", true, 1009, "Sanjay", "France", "Sudhar", "India", false, "1009", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1010, "Adams", "Nepal", "ALFKI", "Berlin", false, 1010, "Sanjay", "France", "Sudhar", "India", false, "1010", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1011, "Maria", "Germany", "ALFKI", "Berlin", true, 1011, "Sanjay", "France", "Sudhar", "India", false, "1011", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1012, "Maria", "Germany", "ALFKI", "Berlin", true, 1012, "Sanjay", "France", "Sudhar", "India", true, "1012", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1013, "Maria", "Germany", "ALFKI", "Berlin", true, 1013, "Sanjay", "France", "Sudhar", "India", false, "1013", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1014, "Adams", "Germany", "ALFKI", "Berlin", true, 1014, "Sanjay", "France", "Sudhar", "India", false, "1014", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1015, "Maria", "Germany", "ALFKI", "Berlin", true, 1015, "Sanjay", "France", "Sudhar", "India", false, "1015", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1016, "Adams", "Germany", "ALFKI", "Berlin", false, 1016, "Sanjay", "France", "Sudhar", "India", true, "1016", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1017, "Maria", "Japan", "ALFKI", "Berlin", true, 1017, "Sanjay", "France", "Sudhar", "India", false, "1017", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1018, "Maria", "Japan", "ALFKI", "Berlin", true, 1018, "Sanjay", "France", "Sudhar", "India", false, "1018", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1019, "Adams", "Germany", "ALFKI", "Berlin", true, 1019, "Sanjay", "France", "Sudhar", "India", false, "1019", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1020, "Adams", "Germany", "ALFKI", "Berlin", true, 1020, "Sanjay", "France", "Sudhar", "India", true, "1020", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1021, "Adams", "Germany", "ALFKI", "Berlin", true, 1021, "Sanjay", "France", "Sudhar", "India", false, "1021", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1022, "Maria", "Germany", "ALFKI", "Berlin", false, 1022, "Sanjay", "France", "Sudhar", "India", false, "1022", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1023, "Maria", "Germany", "ALFKI", "Berlin", true, 1023, "Sanjay", "France", "Sudhar", "India", false, "1023", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1024, "Maria", "India", "ALFKI", "Berlin", true, 1024, "Sanjay", "France", "Sudhar", "India", false, "1024", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1025, "Maria", "Germany", "ALFKI", "Berlin", true, 1025, "Sanjay", "France", "Sudhar", "India", false, "1025", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1026, "Adams", "Germany", "ALFKI", "Berlin", true, 1026, "Sanjay", "France", "Sudhar", "India", true, "1026", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1027, "Maria", "Germany", "ALFKI", "Berlin", false, 1027, "Sanjay", "France", "Sudhar", "India", false, "1027", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1028, "Adams", "Germany", "ALFKI", "Berlin", true, 1028, "Sanjay", "France", "Sudhar", "India", false, "1028", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1029, "Maria", "Germany", "ALFKI", "Berlin", true, 1029, "Sanjay", "France", "Sudhar", "India", true, "1029", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1030, "Adams", "Germany", "ALFKI", "Berlin", true, 1030, "Sanjay", "France", "Sudhar", "India", false, "1030", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1031, "Maria Anders", "Germany", "ALFKI", "Berlin", true, 1031, "Sanjay", "France", "Sudhar", "India", false, "1031", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1032, "Tim Adams", "Germany", "ALFKI", "Berlin", true, 1032, "Sanjay", "France", "Sudhar", "India", false, "1032", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1033, "Maria Anders", "Germany", "ALFKI", "Berlin", true, 1033, "Sanjay", "France", "Sudhar", "India", true, "1033", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1034, "Maria Anders", "Germany", "ALFKI", "Berlin", true, 1034, "Sanjay", "France", "Sudhar", "India", true, "1034", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1035, "Tim Adams", "Germany", "ALFKI", "Berlin", true, 1035, "Sanjay", "France", "Sudhar", "India", false, "1035", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1036, "Tim Adams", "India", "ALFKI", "Berlin", true, 1036, "Sanjay", "France", "Sudhar", "India", false, "1036", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));


        }

    }
}
