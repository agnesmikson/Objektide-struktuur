using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Children
    {
        [Key]
        public Guid Id { get; set; }
        public string name { get; set; }
        public Employee Employee { get; set; }
    }
}
