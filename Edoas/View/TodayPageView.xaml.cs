using Edoas.DataAccess;
using Edoas.DataAccess.DataEntity;
using System;
using System.Collections.Generic;
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

namespace Edoas.View
{
    /// <summary>
    /// TodayPageView.xaml 的交互逻辑
    /// </summary>
    public partial class TodayPageView : UserControl
    {
        public TodayPageView()
        {
            InitializeComponent();
        }

        private void testdb(object sender, RoutedEventArgs e)
        {



            var db = new SentMessageDB();
            db.Database.CreateIfNotExists();
            var book = db.SentMessages.Single(x=>x.id==1);
            book.Recipients.Add(new RecipientEntity { Name="we",IsReaded=true});
            book.Recipients.Add(new RecipientEntity { Name="we1",IsReaded=false});
            db.SaveChanges();
            var books = db.SentMessages.ToList();
                
                //this.Text = $"{DateTime.Now}, 查到{books.Count}条记录";
            this.list.ItemsSource = books;
        }

    }
}
