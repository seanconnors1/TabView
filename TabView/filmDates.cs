using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabView
{
    public class filmDates : IEnumerator, IEnumerable
    {
        public List<filmDate> fList;
        int position = -1;
        DateTime date1 = new DateTime(2008, 5, 1, 8, 30, 52);

        public filmDates()
        {
            fList = new List<filmDate>
            {
                /*
                new filmDate("TITLE_1", "DESCRIPTION_1", date1),
                new filmDate("TITLE_2", "DESCRIPTION_2", date1),
                new filmDate("TITLE_3", "DESCRIPTION_3", date1),
                new filmDate("TITLE_4", "DESCRIPTION_4", date1),
                */
            };
        }

        public Boolean addFilm(filmDate input)
        {

            fList.Add(input);

            return true;
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            position++;
            return (position < fList.Count);
        }

        public void Reset()
        {
            position = 0;
        }

        public object Current
        {
            get
            { return fList[position]; }
        }

        //created new compare method to compare two dates using datetime's CompareTo call.
        //If value is less than zero, f1 isn ealier than f2.
        //If value is zero, than f1 and f2 are the same date.
        //Else, f1 is later than f2.
        private static int compareDates(filmDate f1, filmDate f2)
        {
            return ( f1.getReleaseDate().CompareTo(f2.getReleaseDate()) );
        }

        private static int compareNames(filmDate f1, filmDate f2)
        {
            return (f1.getName().CompareTo(f2.getName()));
        }

        public void sortAscending()
        {
            fList.Sort((a, b) => compareDates(a, b));   
        }

        public void sortDescending()
        {
            fList.Sort((a, b) => compareDates(b, a));
        }

        public void sortAlphabetically()
        {
            fList.Sort( (a, b) => compareNames(a, b) );
        }

    }
}
