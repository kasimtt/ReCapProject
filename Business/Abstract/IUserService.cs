using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService 
    {
        IResult Add(User user); 
        IResult Delete(User user); 
        IResult Update(User user);
        IDataResult<List<User>> getAll(); 
        IDataResult<User> getById(int id); 
    }
}
