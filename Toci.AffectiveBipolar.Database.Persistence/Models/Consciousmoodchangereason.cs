using System;
using System.Collections.Generic;

#nullable disable

namespace Toci.AffectiveBipolar.Database.Persistence.Models
{
    public partial class Consciousmoodchangereason
    {
        public int Id { get; set; }
        public int? Iduser { get; set; }
        public string Reason { get; set; }
        public DateTime? Currentdate { get; set; }
        public int? Idmood { get; set; }
        public double? Percentagetransition { get; set; }

        public virtual Mood IdmoodNavigation { get; set; }
        public virtual User IduserNavigation { get; set; }
    }
}
