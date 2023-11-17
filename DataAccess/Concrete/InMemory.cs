using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        private readonly List<Brand> _brands = new List<Brand>();


        public List<Brand> GetList()
        {
            return _brands;
        }


        public Brand? GetById(int id) 
        {
            Brand? brand = _brands.FirstOrDefault(b => b.Id == id);
            return brand;
        
        }
        public Brand Add(Brand brand) 
        {
            Brand? brandThatHasMaxIdValue = _brands.MaxBy(brandToSelectKey => brandToSelectKey.Id);
            
            int nextIdValue;
            if (brandThatHasMaxIdValue != null)
            {
                nextIdValue = brandThatHasMaxIdValue.Id + 1;
            }
            else
            {
                nextIdValue = 1;
            }
            brand.Id = nextIdValue;

            brand.CreatedAt = DateTime.UtcNow; 

            
            _brands.Add(brand); 

            return brand;
        }

    }
}
