using GoogleCSE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GoogleQuery
{
    class GoggolApi
    {
        public IEnumerable<GoogleSearchResult> Search(string term)
        {
            var gs = new GoogleSearch("016976589848602941170:e0rsagztt6w", key: "AIzaSyDx9z_1Y2x4EF6OQyiY1y2emRG8QHD2CTM");
            //basic search
            return gs.Search(term);
        }
    }
}