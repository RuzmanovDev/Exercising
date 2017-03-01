using AutoMapper;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Web.Models;

namespace Services
{
    public class Service : IService
    {
        private readonly IData data;
        private readonly IMapper mapper;

        public Service(IData data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper;
        }

        public IEnumerable<PostViewModel> GetAllData()
        {
            var data = this.data.GetAll();

            var result = this.mapper.Map<IEnumerable<PostViewModel>>(data);

            return result;
        }

        public void Add(PostViewModel model)
        {
            var model2 = new Post()
            {
                Content = model.Content,
                CreatedOn = DateTime.Now,
                UserName = model.UserName
            };

            this.data.AddData(model2);
        }
    }
}
