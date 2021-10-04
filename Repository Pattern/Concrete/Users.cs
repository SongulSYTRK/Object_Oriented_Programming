using Abstraction.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Entities.Concrete
{
    public enum Status { Active = 1, Modified = 2, Passive = 0 };
    public class Users
    {
       
        public List<Tellephones<int>> GetTakeTelephone { get; set; }
        public Users() // Created constructer
        {

            GetTakeTelephone = new List<Tellephones<int>>();
        }
        public string UserName { get; set; }
        public string  UserSurname  { get; set; }

        private DateTime _TakeTime = DateTime.Now;
        public DateTime TakeTime { get => _TakeTime; set => _TakeTime = value; }

        private Status _status = Status.Passive;
        public Status Status { get => _status; set => _status = value; }
    }
}
