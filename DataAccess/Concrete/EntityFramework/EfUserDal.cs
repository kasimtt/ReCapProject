﻿using Core.DataAccess.EnitityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal: EfEntityRepositoryBase<User, ReCarDatabaseContext>, IUserDal
    {

    }
}
