using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.IO;

namespace revision
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();

        List<Band> bands = new List<Band>();

        public MainWindow()
        {

            #region JSON stuf -- @todo cleanup, later
            //bool isReal = File.Exists(@"C:\Users\David\Desktop\bands.json");

            //string json = File.ReadAllText(@"C:\Users\David\Desktop\bands.json");

            //BandDB[] jsonBands = JsonConvert.DeserializeObject<BandDB[]>(json);


            //RockBand rockBand = new RockBand(jsonBands[1]);
            //PopBand popBand = new PopBand(jsonBands[0]);
            #endregion


            #region temp stuff
            Album album1 = new Album
            {
                Name         = "first",
                YearReleased = Album.GenerateReleaseYear(),
                SalesCount   = 10000
            };
            Album[] band1Albums = new Album[] { album1, album1 };

            BandData band1Data = new BandData
            {
                Name       = "thiswon",
                YearFormed = 1984,
                Members    = new string[] { "bob", "alan" },
                Albums     = band1Albums
            };


            RockBand  band1 = RockBand.GenerateNew(band1Data);
            PopBand   band2 = PopBand.GenerateNew(band1Data);
            IndieBand band3 = IndieBand.GenerateNew(band1Data);

            PopBand   band4 = BandFactory.MakeNewBand(Genre.Pop,   band1Data) as PopBand;
            RockBand  band5 = BandFactory.MakeNewBand(Genre.Rock,  band1Data) as RockBand;
            IndieBand band6 = BandFactory.MakeNewBand(Genre.Indie, band1Data) as IndieBand;

            PopBand   band7 = BandFactory.MakeNewBand(Genre.Pop,   band1Data) as PopBand;
            RockBand  band8 = BandFactory.MakeNewBand(Genre.Rock,  band1Data) as RockBand;
            IndieBand band9 = BandFactory.MakeNewBand(Genre.Indie, band1Data) as IndieBand;
            #endregion




            Band[] bands = { band1, band2, band3, band4, band5, band6, band7, band8, band9 };

            Array.Sort(bands);



            InitializeComponent();

            //textBoxFormed.Text = json;

            listBoxBands.ItemsSource = bands;

            comboBoxGenres.ItemsSource = Enum.GetNames(typeof(Genre));
        }

        private void listBoxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = listBoxBands.SelectedItem as Band;

            if(selectedItem != null)
            { 
                textBoxFormed.Text = selectedItem.YearFormed.ToString();

                textBoxMembers.Text = selectedItem.MembersString();
            }
        }


    }
}
