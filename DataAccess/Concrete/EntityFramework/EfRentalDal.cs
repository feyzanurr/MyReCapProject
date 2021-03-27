using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentingContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            throw new NotImplementedException();
        }

        public bool IsAvailable(int id)
        {
            throw new NotImplementedException();
        }
    }
}
