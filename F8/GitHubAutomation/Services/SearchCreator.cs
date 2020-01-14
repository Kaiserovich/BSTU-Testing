using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Models;
using GitHubAutomation.Services;

namespace Framework.Services
{
    class SearchCreator
    {
        public static Search WithAllProperties()
        {
            return new Search(TestDataReader.GetData("SearchText"));
        }
    }
}
