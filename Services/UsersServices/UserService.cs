using exam_webapi.DTOs.UserDTOs;
using exam_webapi.Models;
using exam_webapi.Repositories;

namespace exam_webapi.Services.UserServices
{
    public class UserService : IUserService
    {
        public UserRepository _repo { get; }
        public UserService(UserRepository collection)
        {
            this._repo = collection;
        }
        public User CreateUser(CreateUserDTO nwUser)
        {
            User nw = new User(){
                UserId = _repo.collection.Count + 1,
                Name = nwUser.Name,
                Phone = nwUser.Phone,
                Email = nwUser.Email,
                UserType = (UserType_Enum) nwUser.UserType
            };
            _repo.collection.Add(nw);
            return nw;
        }

        public User GetUser(int id)
        {
            return _repo.collection.Where(u => u.UserId == id).SingleOrDefault();
            
        }

        public User UpdateUser(UserDTO nwUser)
        {
            User oldUser = _repo.collection.Find(u => u.UserId == nwUser.UserId);
            if (oldUser != null)
            {
                int index = _repo.collection.IndexOf(oldUser);
                User nw = new User(){
                    UserId = _repo.collection.Count + 1,
                    Name = nwUser.Name,
                    Phone = nwUser.Phone,
                    Email = nwUser.Email,
                    UserType = (UserType_Enum) nwUser.UserType
                };
                _repo.collection[index] = nw;
                return _repo.collection[index];
            }else{
                return new User();
            }
        }


        User IUserService.DeleteUser(int id)
        {
            User oldUser = _repo.collection.Find(u => u.UserId == id);

            _repo.collection.Remove(oldUser);
            return oldUser; 
        }
    }
}