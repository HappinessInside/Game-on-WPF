using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Configuration;
using System.Windows.Navigation;
using System.IO;

namespace MyGame
{
    [Serializable]
    public class Record
    {
        public int NumberOfStrokes { get; set; }
        public int NumberOfPoints { get; set; }
        public string Status { get; set; }

        public Record(int numberOfStrokes, bool status )
        {
            NumberOfStrokes = numberOfStrokes;
            
            if(status)
            {
                Status = "Is won";
            }
            else
            {
                Status = "Is lost";
            }
            if (Status == "Is won")
            {
                NumberOfPoints = 10000 / numberOfStrokes;
            }
            else
            {
                NumberOfPoints = 0;
            }
         }
       public Record()
        { 
          

        }

    }
    [Serializable]
    public  class Config
    {  public List<Record> records;

        public Config()
        {
            records = new List<Record>();
        }
        public void AddRecord(Record r)
        {
            records.Add(r);
        }
        public double GetNumberOfRecords()
        { 
            return records.Count;
        }

        public double GetNumberOfWonGames()
        {
            int count = 0;
            if (records.Count > 0)
            {
                count = (from r in records where r.Status == "Is won" select r).Count();
            }
            return count ;
        }

        public double PercentOfWinnings()
        {
            double res = GetNumberOfWonGames()*100/GetNumberOfRecords();
            res = Math.Round(res, 2);
            return res;
        }

        public string GetBestRecord()
        {
            int count = 0;
            string res = null;
            Record TheBestRecord= new Record();
            if(GetNumberOfWonGames()>0)
            {
                foreach (var record in records)
            {
                if (record.NumberOfPoints > count && record.Status=="Is won")
                {
                    count = record.NumberOfPoints;
                    TheBestRecord = record;
                }
            }
            res = "Number of strokes:" + " " + TheBestRecord.NumberOfStrokes + ","+ "  " + "Number of points:" + " "+TheBestRecord.NumberOfPoints;
                
            }
            
            return res;
         }
     }
    [Serializable]
    public class Saver
    {
        public  string FileName;

        public Saver()
        {
             FileName =ConfigurationManager.AppSettings["FileName"];

        }
        public Config GetConfig()
        {
            Config cfg;
            if (File.Exists(FileName))
            {
                var xmlSerlz = new XmlSerializer(typeof(Config));
                var file = new FileStream(FileName, FileMode.Open);
                cfg = (Config)xmlSerlz.Deserialize(file);
                file.Close();
            }
            else cfg = new Config();
            return cfg;
        }

        public void Save(Config cfg)
        {
            
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Config));
            using (Stream fStream = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
            {
                xmlFormat.Serialize(fStream, cfg);
            }
        }
    }
}
