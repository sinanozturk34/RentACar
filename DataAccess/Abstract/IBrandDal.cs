using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBrandDal
    {
        public List<Brand> GetList();
        public Brand? GetById(int id);
        public Brand Add(Brand brand);
    }
}
