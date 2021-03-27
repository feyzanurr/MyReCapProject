using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarRentingContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()

        {
            using (CarRentingContext context = new CarRentingContext())
            {
                var result = from m in context.Customers
                             join k in context.Users
                             on m.UserId equals k.Id
                             select new CustomerDetailDto
                             {
                                 FirstName = k.FirstName,
                                 LastName = k.LastName,
                                 Email = k.Email,
                                 Password = k.PasswordHash.ToString() + k.PasswordSalt.ToString(),
                                 CustomerId = m.CustomerId,
                                 CompanyName = m.CompanyName,
                                 UserId = k.Id
                             };
                return result.ToList();


            }
        }
    }
}