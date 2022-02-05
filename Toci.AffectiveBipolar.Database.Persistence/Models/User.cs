using System;
using System.Collections.Generic;

#nullable disable

namespace Toci.AffectiveBipolar.Database.Persistence.Models
{
    public partial class User
    {
        public User()
        {
            Consciousmoodchangereasons = new HashSet<Consciousmoodchangereason>();
            Consumptionorderhistories = new HashSet<Consumptionorderhistory>();
            Unconsciousmoodchangereasons = new HashSet<Unconsciousmoodchangereason>();
            Usercurrentstates = new HashSet<Usercurrentstate>();
            Usermedicamentdoses = new HashSet<Usermedicamentdose>();
            Userorderedmedicaments = new HashSet<Userorderedmedicament>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Consciousmoodchangereason> Consciousmoodchangereasons { get; set; }
        public virtual ICollection<Consumptionorderhistory> Consumptionorderhistories { get; set; }
        public virtual ICollection<Unconsciousmoodchangereason> Unconsciousmoodchangereasons { get; set; }
        public virtual ICollection<Usercurrentstate> Usercurrentstates { get; set; }
        public virtual ICollection<Usermedicamentdose> Usermedicamentdoses { get; set; }
        public virtual ICollection<Userorderedmedicament> Userorderedmedicaments { get; set; }
    }
}
