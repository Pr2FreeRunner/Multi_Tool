﻿using System.Globalization;
using System.Text;

namespace DataAccess.Accessors
{
    internal class NewestLevels 
    {

        private const string SEARCH_LINK = "https://pr2hub.com/files/lists/newest/";

        public string Result { get; set; }
        internal NewestLevels(int page)
        {
            string link = SEARCH_LINK 
                        + page.ToString(CultureInfo.InvariantCulture) 
                        + GetSearchQuery();

            Result = GetAccessor.Download(link);
        }

        private string GetSearchQuery()
        {
            var query = new StringBuilder();

            query.Append("?rand=");
            query.Append("&token=");

            return query.ToString(); ;
        }
    }
}
