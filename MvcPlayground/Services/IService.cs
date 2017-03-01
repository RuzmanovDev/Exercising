using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Web.Models;

namespace Services
{
    public interface IService
    {
        IEnumerable<PostViewModel> GetAllData();

        void Add(PostViewModel model);
    }
}
