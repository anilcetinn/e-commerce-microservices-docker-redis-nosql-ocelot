﻿using ECommerce.Cargo.DataAccessLayer.Abstract;
using ECommerce.Cargo.DataAccessLayer.Concrete;
using ECommerce.Cargo.DataAccessLayer.Repositories;
using ECommerce.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Cargo.DataAccessLayer.EntityFramework
{
    public class EfCargoCompanyDal:GenericRepository<CargoCompany>,ICargoCompanyDal
    {
        public EfCargoCompanyDal(CargoContext context) : base(context) { 
            
        }
    }
}
