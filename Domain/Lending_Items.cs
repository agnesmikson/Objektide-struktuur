using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Lending_Items
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int amount { get; set; }
        public Lending Lending { get; set; }
    }
}
