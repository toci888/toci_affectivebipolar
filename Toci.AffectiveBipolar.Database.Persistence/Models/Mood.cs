using System;
using System.Collections.Generic;

#nullable disable

namespace Toci.AffectiveBipolar.Database.Persistence.Models
{
    public partial class Mood
    {
        public Mood()
        {
            Consciousmoodchangereasons = new HashSet<Consciousmoodchangereason>();
            Unconsciousmoodchangereasons = new HashSet<Unconsciousmoodchangereason>();
        }

        public int Id { get; set; }
        public string Mood1 { get; set; }

        public virtual ICollection<Consciousmoodchangereason> Consciousmoodchangereasons { get; set; }
        public virtual ICollection<Unconsciousmoodchangereason> Unconsciousmoodchangereasons { get; set; }
    }
}
