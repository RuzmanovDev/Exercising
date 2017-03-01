using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Web.Models;

namespace Data
{
    public class Data : IData
    {
        private static ICollection<Post> AllData = new List<Post>()
        {
            new Post() { UserName = "Pesho", Content = "xaxaxaxaxaaxxaxa", CreatedOn = DateTime.Now, IsDeleted = false  },
            new Post() { UserName = "Stoyan", Content = "xoxoxox", CreatedOn = DateTime.Now, IsDeleted = false  },
        };

        public void AddData(Post model)
        {
            AllData.Add(model);
        }

        public IEnumerable<Post> GetAll()
        {
            return AllData;
        }
    }
}
