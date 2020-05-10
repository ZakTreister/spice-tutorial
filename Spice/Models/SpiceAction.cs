using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Models
{
    public class SpiceAction
    {
        public int Id { get; set; }
        public ActionType type { get; set; }
    }

    public enum ActionType
    {
        Edit,
        Create,
        Delete,
        Details
    }
}
