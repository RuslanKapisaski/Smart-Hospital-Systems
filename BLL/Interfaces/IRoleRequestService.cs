using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.BLL.Interfaces
{
    internal interface IRoleRequestService
    {
        bool AddRoleRequest(RoleRequest request);

        public List<RoleRequest> GetAllRoleRequests();
    }
}
