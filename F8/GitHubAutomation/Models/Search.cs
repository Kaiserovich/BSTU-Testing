using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models
{
    class Search
    {
        public string SearchText { get; set; }

        public Search(string searchText)
        {
            SearchText = searchText;
        }
    }
}
