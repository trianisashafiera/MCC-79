using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity.Controllers
{
    public class HistoryController
    {
        private History _history = new History();
        private HistoryView _historyView = new HistoryView();

        public void GetAll()
        {
            _historyView.All(_history.GetAll());
            Console.ReadKey();
            Console.Clear();
        }
    }
}
