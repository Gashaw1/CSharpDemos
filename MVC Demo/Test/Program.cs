using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayers;
using System.Data;

namespace Test
{
    class Program 
    {
        static void Main(string[] args)
        {
            DataAccessLayers.DataAccess dacc = new DataAccessLayers.DataAccess();
            DataTable  myDataTable = dacc.ReturnData(1050);
            dacc.UpdateData(myDataTable);

        }
    }
}
