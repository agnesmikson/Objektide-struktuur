using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class AccessName
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstAccess { get; set; }
        public string SecondAccess { get; set; }
        public string ThirdAccess { get; set; }
    }
}
