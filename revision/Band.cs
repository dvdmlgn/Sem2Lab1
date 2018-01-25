using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision
{
    

    public abstract class Band : IComparable<Band>
    {
        #region Properties
      // ---------------------------------------------------------------------------------------------------------------------------------------------------------

        public string   Name       { get; set; }
        public int      YearFormed { get; set; }

        public string[] Members    { get; set; }
        public Album[]  Albums     { get; set; }

        public Genre    Genre      { get; set; }

      // ---------------------------------------------------------------------------------------------------------------------------------------------------------
        #endregion

        //public Band(BandDB data)
        //{
        //    this.Name = data.Name;
        //    this.YearFormed = data.YearFormed;
        //    this.Members = data.Members;

        //    List<string> albumData = new List<string>();
        //    foreach(string album in data.albums)
        //    {
        //        albumData.Add(album);
        //    }

        //    string[] albumArray = albumData.ToArray();

        //    albums = new Album[albumArray.Length];

        //    for (int i = 0; i < albumArray.Length; i++)
        //    {
        //        albums[i].Name = albumArray[i];
        //    }
        //}

        #region Methods
      // ---------------------------------------------------------------------------------------------------------------------------------------------------------

        public override string ToString()
        {
            return this.GetType().Name;
        }


        public int CompareTo(Band other)
        {
            return this.Name.CompareTo(other.Name);
        }


        public string MembersString()
        {
            string members = "";

            foreach (string member in this.Members)
            {
                members += member + ", ";
            }

            // trims off the last ', ' from the string
            members = members.Substring(0, members.Length - 2);

            return members;
        }

      // ---------------------------------------------------------------------------------------------------------------------------------------------------------
        #endregion

        // public static Band GenerateNew(string typeOfBand)
        // {
        //   Band band =;

        //   RockBand newBand = band as RockBand;

        //based on type passed in create approp band

        // }

    }

    public class RockBand : Band
    {

        public static RockBand GenerateNew(BandData data)
        {
            RockBand band = new RockBand();

            band.Name = data.Name;
            band.YearFormed = data.YearFormed;

            band.Members = data.Members;
            band.Albums = data.Albums;

            return band;
        }

    }

    public class PopBand : Band
    {

        public static PopBand GenerateNew(BandData data)
        {
            PopBand band = new PopBand();

            band.Name = data.Name;
            band.YearFormed = data.YearFormed;

            band.Members = data.Members;
            band.Albums = data.Albums;

            return band;
        }

    }

    public class IndieBand : Band
    {

        public static IndieBand GenerateNew(BandData data)
        {
            IndieBand band = new IndieBand();

            band.Name = data.Name;
            band.YearFormed = data.YearFormed;

            band.Members = data.Members;
            band.Albums = data.Albums;

            return band;
        }

    }
}
