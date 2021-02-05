using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Covid_19_Chart
{
    public partial class Form1 : Form
    {
        MongoClient client = null;
        public Form1()
        {
            InitializeComponent();
            StartUp();
        }

        public void StartUp()
        {
            client = new MongoClient("mongodb://localhost:27017");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LaatCovidStaafGrafiek();
            pnlcovidgrafieken.Hide();
            pnlcovidstaafgrafiek.Show();
        }

        public void LaatCovidStaafGrafiek()
        {
            foreach (var series in covidstaafgrafiek.Series)
            {
                series.Points.Clear();
            }

            var database = client.GetDatabase("covid-19");
            var collection = database.GetCollection<BsonDocument>("covid-19-data");
            var list = collection.Find(new BsonDocument()).ToList();


            List<string> keys = new List<string>();
            foreach (var rover in collection.Find(new BsonDocument()).ToList())
            {
                rover.Names.ToList().ForEach(p => keys.Add(p));
            }

            List<string> tempkeys = keys.ToList();
            foreach (string key in tempkeys)
            {
                if (Regex.Matches(key, "/").Count != 2)
                {
                    keys.Remove(key);
                }
            }


            tempkeys = keys.Distinct().ToList();
            keys = tempkeys.ToList();

            for (int i = 0; i < keys.Count; i++)
            {
                int count = 0;
                foreach (var item in list)
                {
                    string key = keys[i];
                    int aantal = int.Parse(item.GetElement($"{key}").Value.ToString());
                    count += aantal;
                }
                covidstaafgrafiek.Series["Confirmed"].Points.AddXY($"{keys[i]}", count);
            }
        }

        public void LaatCovidGrafieken()
        {
            foreach (var series in covidgrafieken.Series)
            {
                series.Points.Clear();
            }

            var database = client.GetDatabase("covid-19");
            var collection = database.GetCollection<BsonDocument>("covid-19-data");
            var listCovidConfirmed = collection.Find(new BsonDocument()).ToList();

            collection = database.GetCollection<BsonDocument>("covid-19-recovered");
            var listCovidRecovered = collection.Find(new BsonDocument()).ToList();

            collection = database.GetCollection<BsonDocument>("covid-19-deaths");
            var listCovidDeaths = collection.Find(new BsonDocument()).ToList();


            List<string> keys = new List<string>();
            foreach (var row in listCovidConfirmed)
            {
                row.Names.ToList().ForEach(p => keys.Add(p));
            }

            List<string> tempkeys = keys.ToList();
            foreach (string key in tempkeys)
            {
                if (Regex.Matches(key, "/").Count != 2)
                {
                    keys.Remove(key);
                }
            }

            tempkeys = keys.Distinct().ToList();
            keys = tempkeys.ToList();


            List<Object> varList = new List<Object>();
            varList.Add(listCovidConfirmed);
            varList.Add(listCovidRecovered);
            varList.Add(listCovidDeaths);

            List<Dictionary<string, int>> dictonaries = new List<Dictionary<string, int>>();
            Dictionary<string, int> countdagenConfirmed = new Dictionary<string, int>();
            Dictionary<string, int> countdagenRecovered = new Dictionary<string, int>();
            Dictionary<string, int> countdagenDeaths = new Dictionary<string, int>();
            dictonaries.Add(countdagenConfirmed);
            dictonaries.Add(countdagenRecovered);
            dictonaries.Add(countdagenDeaths);

            for (int j = 0; j < dictonaries.Count; j++)
            {

                for (int k = 0; k < keys.Count; k++)
                {
                    dictonaries[j].Add(keys[k], 0);
                }

                for (int i = 0; i < dictonaries[j].Count; i++)
                {
                    int count = 0;
                    {
                        if (j == 0)
                        {
                            foreach (var item in listCovidConfirmed)
                            {
                                int aantal = int.Parse(item.GetElement($"{keys[i]}").Value.ToString());
                                count += aantal;
                            }
                        }
                        else if (j == 1)
                        {
                            foreach (var item in listCovidRecovered)
                            {
                                int aantal = int.Parse(item.GetElement($"{keys[i]}").Value.ToString());
                                count += aantal;
                            }
                        }
                        else
                        {
                            foreach (var item in listCovidDeaths)
                            {
                                int aantal = int.Parse(item.GetElement($"{keys[i]}").Value.ToString());
                                count += aantal;
                            }
                        }
                    }
                    dictonaries[j][keys[i]] = count;
                }

            }
            for (int i = 0; i < dictonaries.Count; i++)
            {
                foreach (KeyValuePair<string, int> entry in dictonaries[i])
                {
                    covidgrafieken.Series[i].Points.AddXY($"{entry.Key}", entry.Value);
                }
            }
        }

        private void btncovidgrafieken_Click(object sender, EventArgs e)
        {
            pnlcovidgrafieken.Show();
            pnlcovidstaafgrafiek.Hide();
            LaatCovidGrafieken();
        }

        private void btncovidstaafgrafiek_Click(object sender, EventArgs e)
        {
            pnlcovidgrafieken.Hide();
            pnlcovidstaafgrafiek.Show();
            LaatCovidStaafGrafiek();
        }
    }
}
