﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }
        
        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }
      
        public IDataResult<List<Customer>> GetAll()
        {
            var result = _customerDal.GetAll();
            return new SuccessDataResult<List<Customer>>(result, Messages.CustomersListed);

        }
        public IDataResult<Customer> GetById(int customerid)
        {
            var result = _customerDal.Get(c => c.CustomerId == customerid);
            return new SuccessDataResult<Customer>(result, Messages.CustomerListed);
        }
        public IDataResult<Customer> GetCustomersByUserId(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.UserId == id));
        }
        
        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
        public IDataResult<List<CustomerDetailDto>> GetCustomerDetails()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetails());
        }
        public IResult TransactionalOperation(Customer customer)
        {
            _customerDal.Update(customer);
            _customerDal.Add(customer);
            return new SuccessResult();
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            throw new System.NotImplementedException();
        }
    }
}