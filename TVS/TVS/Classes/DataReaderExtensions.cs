using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle.DataAccess.Client
{
    public static class DataReaderExtensions
    {
        public static T GetValueByColumn<T>(this OracleDataReader reader, string columnName)
        {
            int index = reader.GetOrdinal(columnName);

            var value = reader.GetValue(index);

            if (value is DBNull || value == null)
            { 
                return default(T);
            }

            if (typeof(int) == typeof(T)) //2e x mis
            {
                return (T)(object)Convert.ToInt32(value);
            }
            else if (typeof(long) == typeof(T))
            {
                return (T)(object)(long)Convert.ToInt64(value);
            }

            return (T)value;
        }
    }
}