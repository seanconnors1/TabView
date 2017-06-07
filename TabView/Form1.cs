using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//downloaded this from "manage NuGet Packages". Helps parse JSON files
using Newtonsoft.Json;

namespace TabView
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

//<Form button methods>

        private void button1_Click(object sender, EventArgs e)
        {

            login lG = new login();

            if (lG.ShowDialog() == DialogResult.OK)
            {
                label1.Text = ("Welcome " + lG.UserName);
                button1.Visible = false;
            }
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if ( (comboBox1.Text == "") || (comboBox2.Text == "") || (comboBox3.Text == "") )
            {
                MessageBox.Show("Invalid input. Please fill out form.");
            }
            else
            {
                questionReview qR = new questionReview(comboBox1.Text, comboBox2.Text, comboBox3.Text);
                qR.Show();
            }
        }
       
//</Form button methods>
        /// <summary>
        /// Name: converDate
        ///     Converst NYTimes date (YYYY-MM-DD) to c#'s DateTime
        ///     format (DD-MM-YYYY)
        /// </summary>
        /// <param name="originalDate"></param>
        /// <returns></returns>

        private DateTime convertDate(string originalDate)
        {
            //based off of the NYTimesd Json notion which follows the following pattern:
            //YYYY-MM-DD

            int year = 0;
            int month = 0;
            int day = 0;

            DateTime newDate = new DateTime();

            Console.Write("OUTPUT: " + originalDate);
            if (originalDate != "")
            {
                year = Int32.Parse(originalDate.Substring(0, 4));
                month = Int32.Parse(originalDate.Substring(5, 2));
                day = Int32.Parse(originalDate.Substring(8, 2));
                
            }
            if (!(year == 0 || month == 0 || day == 0))
            {
                newDate = new DateTime(year, month, day);
            }else
            {
                newDate = new DateTime(1776, 04, 7);
            }
            
            return newDate;

        }

        //<JSON methods>

        /// <summary>
        /// Function: generatEndPoint
        ///     Generates HTTP request for API
        /// </summary>
        /// <param name="query">name of query user is searching for</param>
        /// <returns>returns HTTP request</returns>
        private string generateEndPoint (string query)
        {
            string endQuery = "http://api.nytimes.com/svc/movies/v2/reviews/searchjson?api-key=887a8ea540f1b1c44a32584e84ee9383%3A9%3A64325990&query=";

            for(int i = 0; i < query.Length; i++)
            {
                if(query[i] == ' ')
                {
                    endQuery = endQuery + "%20";
                }
                else
                {
                    endQuery = endQuery + query[i];
                }
            }
            return (endQuery);
        }

        private dynamic JsonConverter(string searchInput)
        {
            //calls Rest Client
            restClient rClient = new restClient();
            rClient.endPoint = generateEndPoint(searchInput);

            string strResponse = string.Empty;

            strResponse = rClient.makeRequest();

            //translates Json into something that c# can work with.
            dynamic stuff = JsonConvert.DeserializeObject(strResponse);

            return stuff;
        }

        //</JSON methods>

            /// <summary>
            /// Name: grabQuery
            ///     Takes in query parameters and outputs a list of
            ///     all films matching it
            /// </summary>
            /// <param name="searchInput"></param>
            /// <param name="sortBy"></param>
            /// <returns></returns>
        public String grabQuery (string searchInput, string sortBy){

            dynamic jsonContent = JsonConverter(searchInput);

            filmDates fDS = new filmDates();
            filmDate tempFilmDate = new filmDate();

            string tempString = string.Empty;

            //If a movie is input that does not have any entries, no
            //display_title property will exist for them, and this will
            //result in an error. This conditional checks for that.
            if ((Convert.ToString(jsonContent)).Contains("display_title") && (searchInput != ""))
            {

                //Loops through "stuff" and adds values to fDS                
                for (int i = 0; i < jsonContent.results.Count; i++)
                {
                    tempFilmDate = new filmDate(Convert.ToString(jsonContent.results[i].display_title),
                                                Convert.ToString(jsonContent.results[i].summary_short),
                                                convertDate(Convert.ToString(jsonContent.results[i].opening_date)));
                    fDS.addFilm(tempFilmDate);
                }

                //call sort to see what this list looks like when sorted
                switch (sortBy)
                {

                    case "Alphabetically":
                        fDS.sortAlphabetically();
                        break;
                    case "Newest First":
                        fDS.sortAscending();
                        break;
                    case "Oldest First":
                        fDS.sortDescending();
                        break;
                }

                foreach (filmDate f in fDS)
                {
                    tempString = (tempString + f + "\r\n\r\n");
                }
                           
            }
            return tempString;
        }


        /// <summary>
        /// Name: getButton_Click
        ///     triggers when button is clicked. Calls method for querying 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getButtonTop_Click(object sender, EventArgs e)
        {
            topOutPutBox.Text = grabQuery( topQueryInputBox.Text, topSortChoice.Text );
        }

        private void getButtonBot_Click(object sender, EventArgs e)
        {
            botOutPutBox.Text = grabQuery( botQueryInputBox.Text, botSortChoice.Text );
        }
    }
}
