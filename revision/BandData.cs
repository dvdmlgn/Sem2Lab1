using System.Reflection;

namespace revision
{
    // this is to be used with Reading/Writing different bands data
    // to and from JSON files

    public struct BandData
    {
        #region Properties
      // ---------------------------------------------------------------------------------------------------------------------------------------------------------

        public string   Name        { get; set; }
        public int      YearFormed  { get; set; }

        public string[] Members     { get; set; }
        public Album[]  Albums      { get; set; }

        public Genre    Genre       { get; set; }

      // ---------------------------------------------------------------------------------------------------------------------------------------------------------
        #endregion


        #region Error Handling
      // ---------------------------------------------------------------------------------------------------------------------------------------------------------

        public static bool Validate(BandData data)  // tests to see if any of the bands data is null
        {
            PropertyInfo[] properties = data.GetType().GetProperties();

            foreach(var property in properties)
            {
                if (property == null) { return false; }
            }

            return true;
        }

      // ---------------------------------------------------------------------------------------------------------------------------------------------------------
        #endregion
    }
}
