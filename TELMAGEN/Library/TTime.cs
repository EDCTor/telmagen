using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TELMAGEN
{
    public class TTime
    {
        private int id = -1;
        public int hour = 0;
        public int minute = 0;
        private List<TPoint> tpoints = new List<TPoint>();

        public TTime(int id, int hour, int minute)
        {
            this.id = id;
            this.hour = hour;
            this.minute = minute;
        }

        public int ID
        {
            get { return this.id; }
        }
        public int GetLargestTPointID
        {
            get
            {
                int max_tpointid = 0;

                if (this.tpoints.Count > 0)
                {
                    foreach (TPoint p in this.tpoints)
                    {
                        if (p.ID > max_tpointid)
                        {
                            max_tpointid = p.ID;
                        }
                    }
                }

                return max_tpointid;
            }
        }
        public void AddTPoint(int x, int y, TColor color)
        {
            int id = this.GetLargestTPointID + 1;
            TPoint tpoint = new TPoint(id, x, y, color);

            this.tpoints.Add(tpoint);
        }
        public void RemoveTPoint(int id)
        {
            this.tpoints.RemoveAll(s => s.ID == id);
        }
        public TPoint[] TPoints
        {
            get { return this.tpoints.ToArray(); }
            set 
            {
                if ((value != null) && (value.Length > 0))
                {
                    foreach (TPoint p in value)
                    {
                        this.tpoints.Add(p);
                    }
                }
                else
                {
                    this.tpoints = new List<TPoint>();
                }
            }
        }
        public override string ToString()
        {
            string shour = this.hour.ToString();
            string sminute = this.minute.ToString();

            if (this.hour < 10) { shour = "0" + shour; }
            if (this.minute < 10) { sminute = "0" + sminute; }

            return shour + ":" + sminute;
        }
    }
}
