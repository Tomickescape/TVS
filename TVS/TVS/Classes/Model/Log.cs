using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS
{
    public class Log
    {

        private int _tramId ;
        private int _segmentId;

        private Log(int id, int tramId, int segmentId, DateTime created)
        {
            Id = id;
            _tramId = tramId;
            _segmentId = segmentId;
            Created = created;
        }

        public int Id { get; private set; }
        public DateTime Created { get; private set; }
        public Tram Tram { get { return Tram.GetById(_tramId); } }
        public Segment Segment { get { return Segment.GetById(_segmentId); } }

        public static List<Log> GetAll()
        {
            List<Log> logs = new List<Log>();

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT * FROM tram_log");
                while (db.Read())
                {
                    logs.Add(new Log(db.GetValueByColumn<int>("id"), db.GetValueByColumn<int>("tram_id"),db.GetValueByColumn<int>("segment_id"),db.GetValueByColumn<DateTime>("created")));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Close();
            }

            return logs;
        }

    }
}
