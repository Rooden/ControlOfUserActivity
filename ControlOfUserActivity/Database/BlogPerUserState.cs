using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlOfUserActivity.Database
{
    public class BlogPerUserState
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BlogPostId { get; set; }
        public int Checked { get; set; }
    }
}
