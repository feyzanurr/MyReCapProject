using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Brand brand)
        {
            throw new System.NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b => b.BrandId == brandId);
        }

        public IResult Update(Brand brand)
        {
            throw new System.NotImplementedException();
        }

        IDataResult<List<Brand>> IBrandService.GetAll()
        {
            throw new System.NotImplementedException();
        }

        IDataResult<Brand> IBrandService.GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}