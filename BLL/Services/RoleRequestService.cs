using Hospital_System.BLL.Interfaces;
using Hospital_System.DAL.DB;
using Hospital_System.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.BLL.Services
{
    internal class RoleRequestService : IRoleRequestService
    {
        private readonly HospitalDbContext _dbContext;

        public RoleRequestService(HospitalDbContext context)
        {
            this._dbContext = context;
        }

        public bool AddRoleRequest(RoleRequest request)
        {
            try
            {
                _dbContext.RoleRequests.Add(request);
                bool isRoleRequested = _dbContext.SaveChanges() == 1;
                return isRoleRequested;
            }
            catch (Exception e)
            {
                throw new ArgumentException(ExceptionMessages.RoleRequestError);
            }
        }

        public List<RoleRequest> GetAllRoleRequests()
        {
            try
            {
                return this._dbContext.RoleRequests.ToList();
            }
            catch (Exception e) { throw new ArgumentException(ExceptionMessages.RoleRequestError); }
        }
    }
}
