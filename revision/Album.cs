using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace revision
{
    public class Album
    {
        #region Properties
      // ---------------------------------------------------------------------------------------------------------------------------------------------------------

        public string   Name         { get; set; }
        public DateTime YearReleased { get; set; }
        public int      SalesCount   { get; set; }

      // ---------------------------------------------------------------------------------------------------------------------------------------------------------
        #endregion


        #region Methods
      // ---------------------------------------------------------------------------------------------------------------------------------------------------------

        public static DateTime GenerateReleaseYear()
        {
            return Miscella.GetRandomDate();
        }


        public static int GenerateSalesCount()
        {
            return 1;
        }

      // ---------------------------------------------------------------------------------------------------------------------------------------------------------
        #endregion


        #region Error Handling
      // ---------------------------------------------------------------------------------------------------------------------------------------------------------

        public static bool Validate(Album album)  // tests to see if any of the albums data is null
        {
            PropertyInfo[] properties = album.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (property == null) { return false; }
            }

            return true;
        }

      // ---------------------------------------------------------------------------------------------------------------------------------------------------------
        #endregion

    }
}
