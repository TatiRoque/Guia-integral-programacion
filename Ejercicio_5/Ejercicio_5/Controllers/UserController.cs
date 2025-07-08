using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;

namespace Controllers
{
    public class UserController
    {
        private readonly DataRepository _repo;
        private readonly UserView _view = new();

        public UserController(DataRepository repo)
        {
            _repo = repo;
        }

        public void AddUser()
        {
            var user = _view.CreateUser();
            _repo.Users.Add(user);
        }

        public void ListUsers()
        {
            _view.ShowUsers(_repo.Users);
        }
    }
}
