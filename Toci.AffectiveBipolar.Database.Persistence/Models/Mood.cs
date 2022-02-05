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
        }

        public int Id { get; set; }
        public string Mood1 { get; set; }

        public virtual ICollection<Consciousmoodchangereason> Consciousmoodchangereasons { get; set; }
    }
}
