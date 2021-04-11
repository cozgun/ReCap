using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<List<User>> GetAll();
        User GetByEmail(string email);
        IDataResult<User> GetById(int userId);

        IDataResult<List<User>> GetDetailsByEmail(string email);

        //List<OperationClaim> GetClaims(User user);
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<List<OperationClaim>> GetAllClaims();
        IDataResult<List<UserClaimsDto>> GetClaimsNew(int userId);
        IResult IsAdmin(int userId);

    }
}