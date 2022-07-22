using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleVsFirst
{
    public class Guest
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Phone { get; set; }

        public Gender Gender { get; set; }

        public int Age { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
