﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, CarRentingContext>, ICarImageDal
    {
        public bool DoesExist(int id)
        {
            using (CarRentingContext context = new CarRentingContext())
            {
                return context.CarImages.Any(p => p.Id == id);
            }
        }

    }
}