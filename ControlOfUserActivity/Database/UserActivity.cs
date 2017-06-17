using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlOfUserActivity.Database
{
    public class UserActivity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Quality { get; set; }
        public int Success { get; set; }
        public int Speed { get; set; }
    }
}
