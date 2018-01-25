using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision
{
    public static class BandFactory
    {
        
        public static Band MakeNewBand(Genre genre, BandData data)
        {
            Band band = new RockBand(); // it doesn't matter what type of band we use,
                                        // we just need to instantiate the 'band' object to a non-abstract type 

            CastToGenre(ref band, genre);

            PopulateProperties(ref band, data, genre);


            return band;
        }


        private static void CastToGenre(ref Band band, Genre genre)
        {
            switch (genre)
            {
                // we don't check for the 'Rock' genre, because
                // 'band' is currently a 'RockBand' type when it's created

                case Genre.Pop:
                    band = new PopBand();
                    break;

                case Genre.Indie:
                    band = new IndieBand();
                    break;
            }
        }


        private static void PopulateProperties(ref Band band, BandData data, Genre genre)
        {
            band.Name = data.Name;
            band.YearFormed = data.YearFormed;

            band.Members = data.Members;
            band.Albums = data.Albums;

            band.Genre = genre;
        }

    }
}
