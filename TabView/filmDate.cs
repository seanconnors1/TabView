using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabView
{
    public class filmDate
    {
        public string name { get; set; }

        public string summary { get; set; }

        public DateTime releaseDate { get; set; }

        public filmDate()
        {
            name = string.Empty;
            summary = string.Empty;
            releaseDate = new DateTime();
        }

        public filmDate(string iName, string iSummary, DateTime ireleaseDate)
        {
            name = iName;
            summary = iSummary;
            releaseDate = ireleaseDate;
        }

        public override string ToString()
        {

            //if there was no release date in the API, and it was assigned the
            //default value, do not print out the date.
            if(this.getReleaseDate() == new DateTime (1776, 04, 7)){
                return (name + "\r\n" + summary);
            }else
            {
                return (name + "\r\n" + summary + "\r\n" + releaseDate);
            }
        }

        public DateTime getReleaseDate()
        {
            return releaseDate;
        }

        public String getName()
        {
            return name;
        }

    }    
}