using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerCharacter
    {
        public string Name { get; set; }
        public int? DaysSinceLastLogin { get; set; }  //short hand int?  instead of Nullable<int>
        public DateTime? DateOfBirth { get; set; }  // same as above

        public PlayerCharacter()
        {
            DateOfBirth = null;
            DaysSinceLastLogin = null;

            // Using Magic Numbers Not the Preferred Way to Do this
            //DateOfBirth = DateTime.MinValue;  //magic number
            //DaysSinceLastLogin = -1; // magic number
        }
    }
}
