using System.Collections.Generic;
using System.Data;

namespace OS.Core.Data.Queries.Extensions
{
    public static class EnumerableExtensions
    {
        public static DataTable ConvertToIdsDataTable(this IEnumerable<int> source)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));

            foreach (var item in source)
            {
                dataTable.Rows.Add(item);
            }

            return dataTable;
        }
    }
}
