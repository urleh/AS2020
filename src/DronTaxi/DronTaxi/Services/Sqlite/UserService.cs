using Dapper;
using DronTaxi.Factories.Interfaces;
using DronTaxi.Models;
using DronTaxi.Services.Abstract;
using DronTaxi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronTaxi.Services.Sqlite
{
    class UserService : AbstractService, IUserService
    {
        public UserService(IConnectionFactory factory) : base(factory)
        {
        }

        public List<Right> GetRights()
        {
            var sql = @"select Id, RightBase, RightName from Rights";

            return Connection.Query<Right>(sql).ToList();

        }

        public List<Role> GetRoles()
        {
            var sql = @"SELECT a.Id, a.RoleBase, a.RoleName, 
            c.Id, c.RightBase, c.RightName
            FROM Roles a
            LEFT JOIN RoleRights b ON b.RoleId = a.Id
            LEFT JOIN Rights c ON c.Id = b.RightId";

            var lookup = new Dictionary<int, Role>();

            Connection.Query<Role, Right, Role>(sql, (role, right) => {

                Role curRole;

                if (!lookup.TryGetValue(role.Id, out curRole))
                    lookup.Add(role.Id, curRole = role);

                curRole.Rights.Add(right);

                return curRole;
            }, splitOn: "Id" ).AsQueryable();

            return lookup.Values.ToList();
        }

        public List<User> GetUsers()
        {
            var sql = @"SELECT
            a.Id, a.UserName, a.FirstName, a.SecondName, a.LastName, a.Phone, a.Password, a.Email, a.BirthDate, a.Gender, a.Image,
            c.Id, c.RoleBase, c.RoleName, b.AssignDate, b.ExpirationDate,
            e.Id, e.RightBase, e.RightName
            FROM Users a
            LEFT JOIN UserRoles b ON b.UserId=a.Id
            LEFT JOIN Roles c ON c.Id=b.RoleId
            LEFT JOIN RoleRights d ON d.RoleId = c.Id
            LEFT JOIN Rights e ON e.Id = d.RightId";

            var lookup = new Dictionary<int, User>();

            Connection.Query<User, Role, Right, User>(sql, (user, role, right) => {

                User curUser;

                if (!lookup.TryGetValue(user.Id, out curUser))
                    lookup.Add(user.Id, curUser = user);

                if (!curUser.Roles.Any(a => a.Id == role.Id))
                {
                    curUser.Roles.Add(role);
                }

                var curRole = curUser.Roles.First(a => a.Id == role.Id);

                if (!curRole.Rights.Any(a => a.Id == right.Id))
                {
                    curRole.Rights.Add(right);
                }

                return curUser;
            }, splitOn: "Id").AsQueryable();

            return lookup.Values.ToList();

        }
    }
}
