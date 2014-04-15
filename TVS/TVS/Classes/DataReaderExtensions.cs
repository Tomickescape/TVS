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
            //haalt de index van de kolom op
            int index = reader.GetOrdinal(columnName);

            //haalt de waarde van index op
            var value = reader.GetValue(index);

            //gaat kijken of de waarde null is, dan geeft hij de standaard waarde terug
            if (value is DBNull || value == null)
            { 
                return default(T);
            }

            //is het een integer, zo ja return de waarde nadat het geconverteerd is naar een int
            if (typeof(int) == typeof(T)) 
            {
                return (T)(object)Convert.ToInt32(value);
            }
            //is het een long, zo ja return de waarde nadat het geconverteerd is naar een long
            else if (typeof(long) == typeof(T))
            {
                return (T)(object)(long)Convert.ToInt64(value);
            }
            //geef de waarde terug
            return (T)value;
        }
    }
}