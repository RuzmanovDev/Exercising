using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Web.Models;

namespace Data
{
    public interface IData
    {
        IEnumerable<Post> GetAll();

        void AddData(Post model);
    }
}
