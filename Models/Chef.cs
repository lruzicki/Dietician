using System;
using System.Linq;
using Dietcian;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvcMovie.Dietician;
namespace Dietician.Models
{
    public class Chef
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation Properties
        public int? PublicationId { get; set; }
        public Publication? Publication { get; set; }
    }
}
