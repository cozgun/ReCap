using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.Utilities.Results;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarLeaseContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new CarLeaseContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }


        public List<OperationClaim> GetAllClaims()
        {
            using (var context = new CarLeaseContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             
                             select new OperationClaim {Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }

        public List<UserClaimsDto> GetClaimsNew(int userId)
        {
            using (var context = new CarLeaseContext())
            {
                var result = from o in context.OperationClaims
                             join uo in context.UserOperationClaims on o.Id equals uo.OperationClaimId
                             join u in context.Users on uo.UserId equals u.Id
                             where u.Id == userId
                             select new UserClaimsDto { UserId = u.Id, ClaimName = o.Name };
                return result.ToList();

            }
        }


        public bool IsAdmin(int userId)
        {
            using (var context = new CarLeaseContext())
            {
                var result = from o in context.OperationClaims
                             join uo in context.UserOperationClaims on o.Id equals uo.OperationClaimId
                             join u in context.Users on uo.UserId equals u.Id
                             where u.Id == userId && o.Name == "admin"
                             select new UserClaimsDto { UserId = u.Id, ClaimName = o.Name };
                           
                if(result.ToList().Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}