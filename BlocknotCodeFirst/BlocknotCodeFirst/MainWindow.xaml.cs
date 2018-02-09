using BlocknotCodeFirst.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BlocknotCodeFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataTable recordTable = new DataTable("Records");

        public MainWindow()
        {
            InitializeComponent();
            Table();

            
            using (BlocknoteContext context = new BlocknoteContext())
            {
                
                context.SaveChanges();
            }
        }

        private void Table()
        {
            DataColumn NameColumn = new DataColumn("Name", typeof(string));
            DataColumn SurenameColumn = new DataColumn("Surename", typeof(string));
            DataColumn PhoneColumn = new DataColumn("Phone", typeof(string));
            DataColumn EmailColumn = new DataColumn("Email", typeof(string));
            SurenameColumn.AllowDBNull = true;
            EmailColumn.AllowDBNull = true;
            recordTable.Columns.AddRange(new DataColumn[] { NameColumn, SurenameColumn, PhoneColumn, EmailColumn });

            RecordDG.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = recordTable });
            RecordDG.ColumnWidth = new DataGridLength(20, DataGridLengthUnitType.Star);
        }

    }
}
