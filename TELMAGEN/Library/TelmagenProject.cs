using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

using System.IO;
using System.Xml;
using TELMAGEN.IO;
using TELMAGEN.Library;

namespace TELMAGEN
{
    public class TelmagenProject
    {
        #region XML Constants
        private const string XML_PROJECT = "project";
        private const string XML_NAME = "Name";
        private const string XML_INTERVAL = "interval";
        private const string XML_IMAGENAME = "ImageName";
        private const string XML_TTIMES = "TTIMES";
        private const string XML_TTIME = "TTIME";
        private const string XML_HOUR= "HOUR";
        private const string XML_MINUTE = "MINUTE";
        private const string XML_TTIME_ID = "TTIME_ID";
        private const string XML_TPOINTS = "TPOINTS";
        private const string XML_TPOINT = "TPOINT";
        private const string XML_TPOINT_ID = "TPOINT_ID";
        private const string XML_COLOR = "COLOR";
        private const string XML_X = "X";
        private const string XML_Y = "Y";

        private const string XML_COLOR_LABELS = "COLOR_LABELS";
        private const string XML_RED_LABEL = "RED_LABEL";
        private const string XML_BLUE_LABEL = "BLUE_LABEL";
        private const string XML_GREEN_LABEL = "GREEN_LABEL";
        private const string XML_YELLOW_LABEL = "YELLOW_LABEL";
        private const string XML_PINK_LABEL = "PINK_LABEL";
        private const string XML_ORANGE_LABEL = "ORANGE_LABEL";
        private const string XML_PURPLE_LABEL = "PURPLE_LABEL";
        private const string XML_LTGREEN_LABEL = "LTGREEN_LABEL";
        private const string XML_LTPINK_LABEL = "LTPINK_LABEL";
        private const string XML_LTBLUE_LABEL = "LTBLUE_LABEL";
        private const string XML_GREY_LABEL = "GREY_LABEL";
        private const string XML_WHITE_LABEL = "WHITE_LABEL";
        private const string XML_BLACK_LABEL = "BLACK_LABEL";
        #endregion

        private string name = string.Empty;
        private int interval = 15;
        private string imagename = string.Empty;
        private Bitmap image = null;
        private ColorLabel labels = new ColorLabel();

        public TTime[] TTimes = null;

        public TelmagenProject() { }
        public TelmagenProject(string Name, int interval, string ImageName, ColorLabel labels)
        {
            if ((interval < 1) || (interval > 1440))
            {
                throw new InvalidOperationException("Invalid interval, interval (in minutes) should be between 1 and 1440");
            }
            if (string.IsNullOrEmpty(Name)) { throw new InvalidOperationException("Must have a Name"); }
            if (string.IsNullOrEmpty(ImageName)) { throw new InvalidOperationException("Must have an Image Name"); }
            if (!File.Exists(ImageName)) { throw new FileNotFoundException("File " + ImageName + " does not exist"); }
            if (labels == null) { throw new InvalidOperationException("Must have a color label"); }

            this.name = Name;
            this.interval = interval;
            this.labels = labels;

            #region initialize the time periods
            List<TTime> items = new List<TTime>();
            int id = 0;
            for (int i = 0; i <= 1440; i += interval)
            {
                id += 1; // ensure this is unique for each item

                DateTime d = new DateTime(2000,1,1,0,0,0);
                d = d.AddMinutes(i);
                TTime ttime = new TTime(id, d.Hour, d.Minute);
                
                items.Add(ttime);
            }
            this.TTimes = items.ToArray();
            #endregion

            #region set the image
            this.image = new Bitmap(ImageName);
            #endregion

            // after the initial record creation we only deal with relative paths
            FilePath p = new FilePath(ImageName);
            this.imagename = p.Name;
        }

        #region public properties
        public string Name
        {
            get { return this.name; }
        }
        public string ImageName
        {
            get { return this.imagename; }
        }
        public int Interval
        {
            get { return this.interval; }
        }
        public Bitmap Image
        {
            get
            {
                return this.image;
            }
            set
            {
                //using (Bitmap cloneimage = value.Clone() as Bitmap)
                //{
                //    this.image = cloneimage;
                //}
                this.image = value;
            }
        }
        public string Serialize
        {
            get
            {
                string s = string.Empty;

                XmlWriterSettings xml_settings = new XmlWriterSettings();
                xml_settings.Indent = true;
                xml_settings.Encoding = Encoding.Unicode;

                using (StringWriter sw = new StringWriter())
                {
                    using (XmlWriter xw = XmlWriter.Create(sw, xml_settings))
                    {
                        // write the header
                        xw.WriteStartDocument();
                        xw.WriteComment("This file was automatically generated by TELMAGEN");
                        xw.WriteStartElement(XML_PROJECT, "http://tempuri.org/appsettings");

                        // write all elements that are relevant to the re-creation of this object
                        xw.WriteElementString(XML_NAME, this.Name);
                        xw.WriteElementString(XML_INTERVAL, this.Interval.ToString());
                        xw.WriteElementString(XML_IMAGENAME, this.ImageName);

                        #region times
                        xw.WriteStartElement(XML_TTIMES);
                        if ((this.TTimes != null) && (this.TTimes.Length > 0))
                        {
                            foreach (TTime ttime in this.TTimes)
                            {
                                xw.WriteStartElement(XML_TTIME);
                                xw.WriteElementString(XML_TTIME_ID, ttime.ID.ToString());
                                xw.WriteElementString(XML_HOUR, ttime.hour.ToString());
                                xw.WriteElementString(XML_MINUTE, ttime.minute.ToString());

                                xw.WriteStartElement(XML_TPOINTS);
                                if ((ttime.TPoints != null) && (ttime.TPoints.Length > 0))
                                {
                                    foreach (TPoint tpoint in ttime.TPoints)
                                    {
                                        xw.WriteStartElement(XML_TPOINT);
                                        xw.WriteElementString(XML_TPOINT_ID, tpoint.ID.ToString());
                                        xw.WriteElementString(XML_X, tpoint.x.ToString());
                                        xw.WriteElementString(XML_Y, tpoint.y.ToString());
                                        xw.WriteElementString(XML_COLOR, tpoint.TColor.ToString());
                                        xw.WriteEndElement();
                                    }
                                }
                                xw.WriteEndElement();
                                xw.WriteEndElement();
                            }
                        }
                        xw.WriteEndElement();
                        #endregion
                        
                        #region color labels
                        xw.WriteStartElement(XML_COLOR_LABELS);
                        xw.WriteElementString(XML_RED_LABEL, this.labels.red);
                        xw.WriteElementString(XML_BLUE_LABEL, this.labels.blue);
                        xw.WriteElementString(XML_YELLOW_LABEL, this.labels.yellow);
                        xw.WriteElementString(XML_GREEN_LABEL, this.labels.green);
                        xw.WriteElementString(XML_PURPLE_LABEL, this.labels.purple);
                        xw.WriteElementString(XML_PINK_LABEL, this.labels.pink);
                        xw.WriteElementString(XML_ORANGE_LABEL, this.labels.orange);
                        xw.WriteElementString(XML_LTBLUE_LABEL, this.labels.ltblue);
                        xw.WriteElementString(XML_LTGREEN_LABEL, this.labels.ltgreen);
                        xw.WriteElementString(XML_LTPINK_LABEL, this.labels.ltpink);
                        xw.WriteElementString(XML_GREY_LABEL, this.labels.grey);
                        xw.WriteElementString(XML_BLACK_LABEL, this.labels.black);
                        xw.WriteElementString(XML_WHITE_LABEL, this.labels.white);
                        xw.WriteEndElement();
                        #endregion

                        // write the footer
                        xw.WriteEndElement();
                        xw.WriteEndDocument();
                        xw.Close();

                    }
                    s = sw.ToString();
                }

                return s;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NotSupportedException("Invalid deserialization detected, empty string provided as input");
                }

                XmlDocument x = new XmlDocument();
                x.LoadXml(value);
                XmlNode node = x[XML_PROJECT];

                Console.WriteLine("------------------ Element ------------------");
                Console.WriteLine("Name: " + node[XML_NAME].InnerText);
                Console.WriteLine("Interval: " + node[XML_INTERVAL].InnerText);
                Console.WriteLine("Image: " + node[XML_IMAGENAME].InnerText);

                this.name = node[XML_NAME].InnerText;
                int? i = DataHelpers.C2I(node[XML_INTERVAL].InnerText);
                this.interval = i.Value;
                this.imagename = node[XML_IMAGENAME].InnerText;

                #region times
                List<TTime> ttimes = new List<TTime>();
                foreach (XmlNode ttime_node in node[XML_TTIMES].ChildNodes)
                {
                    if (ttime_node is XmlElement)
                    {
                        //Console.WriteLine("------------------ TTIME ------------------");
                        //Console.WriteLine("ID: " + ttime_node[XML_TTIME_ID].InnerText);
                        //Console.WriteLine("Hour: " + ttime_node[XML_HOUR].InnerText);
                        //Console.WriteLine("Minute: " + ttime_node[XML_MINUTE].InnerText);
                        
                        int? ttimeid = DataHelpers.C2I(ttime_node[XML_TTIME_ID].InnerText);
                        int? hour = DataHelpers.C2I(ttime_node[XML_HOUR].InnerText);
                        int? minute = DataHelpers.C2I(ttime_node[XML_MINUTE].InnerText);

                        // get the points within this time
                        List<TPoint> tpoints = new List<TPoint>();
                        foreach (XmlNode tpoint_node in ttime_node[XML_TPOINTS].ChildNodes)
                        {
                            if (tpoint_node is XmlElement)
                            {
                                //Console.WriteLine("\t------------------ TPOINT ------------------");
                                //Console.WriteLine("\tID: " + tpoint_node[XML_TPOINT_ID].InnerText);
                                //Console.WriteLine("\tX: " + tpoint_node[XML_X].InnerText);
                                //Console.WriteLine("\tY: " + tpoint_node[XML_Y].InnerText);
                                //Console.WriteLine("\tColor: " + tpoint_node[XML_COLOR].InnerText);
                                //Console.WriteLine("\t-------------------------------------------");

                                int? tpointid = DataHelpers.C2I(tpoint_node[XML_TPOINT_ID].InnerText);
                                int? xcoor = DataHelpers.C2I(tpoint_node[XML_X].InnerText);
                                int? ycoor = DataHelpers.C2I(tpoint_node[XML_Y].InnerText);
                                string scolor = tpoint_node[XML_COLOR].InnerText;

                                // convert the string color to the TColor object
                                TColor tcolor = (TColor)Enum.Parse(typeof(TColor), scolor, true);

                                TPoint tpoint = new TPoint(tpointid.Value, xcoor.Value, ycoor.Value, tcolor);
                                tpoints.Add(tpoint);
                            }
                        }

                        //Console.WriteLine("-------------------------------------------");

                        TTime ttime = new TTime(ttimeid.Value, hour.Value, minute.Value);
                        ttime.TPoints = tpoints.ToArray();
                        
                        ttimes.Add(ttime);
                    }
                }
                this.TTimes = ttimes.ToArray();
                #endregion

                XmlNode color_labels = node[XML_COLOR_LABELS];
                if (color_labels is XmlElement)
                {
                    this.labels.red = color_labels[XML_RED_LABEL].InnerText;
                    this.labels.blue = color_labels[XML_BLUE_LABEL].InnerText;
                    this.labels.green = color_labels[XML_GREEN_LABEL].InnerText;
                    this.labels.yellow = color_labels[XML_YELLOW_LABEL].InnerText;
                    this.labels.orange = color_labels[XML_ORANGE_LABEL].InnerText;
                    this.labels.purple = color_labels[XML_PURPLE_LABEL].InnerText;
                    this.labels.pink = color_labels[XML_PINK_LABEL].InnerText;
                    this.labels.ltblue = color_labels[XML_LTBLUE_LABEL].InnerText;
                    this.labels.ltgreen = color_labels[XML_LTGREEN_LABEL].InnerText;
                    this.labels.ltpink = color_labels[XML_LTPINK_LABEL].InnerText;
                    this.labels.grey = color_labels[XML_GREY_LABEL].InnerText;
                    this.labels.white = color_labels[XML_WHITE_LABEL].InnerText;
                    this.labels.black = color_labels[XML_BLACK_LABEL].InnerText;
                }

            }
        }
        public ColorLabel Labels
        {
            get
            {
                return this.labels;
            }
            set
            {
                this.labels = value;
            }
        }
        #endregion
        #region public methods
        public int GetFirstTTime()
        {
            if ((this.TTimes != null) && (this.TTimes.Length > 0))
            {
                // there should probably be more logic here, but for now once TTimes are created
                // (at project creation time) there isnt a way to rearrange or alter their hours and minutes.
                // therefore id of 1 is always the smalles id
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public int GetLastTTime()
        {
            if ((this.TTimes != null) && (this.TTimes.Length > 0))
            {
                // get the largest id of all the ttimes
                int max = -1;
                foreach (TTime ttime in this.TTimes)
                {
                    if (max < ttime.ID)
                    {
                        max = ttime.ID;
                    }
                }
                return max;
            }
            else
            {
                return -1;
            }
        }
        public TTime GetTTime(int ttimeid)
        {
            if ((this.TTimes != null) && (this.TTimes.Length > 0))
            {
                foreach (TTime ttime in this.TTimes)
                {
                    if (ttime.ID == ttimeid)
                    {
                        return ttime;
                    }
                }
                return null;
            }
            else
            {
                return null;
            }
        }
        public void SetTTimeTPoints(int ttimeid, TPoint[] points)
        {
            if ((this.TTimes != null) && (this.TTimes.Length > 0))
            {
                foreach (TTime t in this.TTimes)
                {
                    if (t.ID == ttimeid)
                    {
                        t.TPoints = points;
                    }
                }
            }
        }
        public int ConvertDisplayedXCoor(int display_width, int display_x)
        {
            if (this.image == null) { return -1; }

            //
            // display_x              ?
            // -------------- = -------------
            // display_width    actual_width 
            //

            int actual_width = this.image.Width;
            int mapped_x = (display_x * actual_width) / display_width; 
            return mapped_x;
        }
        public int ConvertDisplayedYCoor(int display_height, int display_y)
        {
            if (this.image == null) { return -1; }

            //
            // display_y              ?
            // -------------- = -------------
            // display_height    actual_height 
            //

            int actual_height = this.image.Height;
            int mapped_y = (display_y * actual_height) / display_height;
            return mapped_y;
        }
        #endregion

    }

    

    
}
