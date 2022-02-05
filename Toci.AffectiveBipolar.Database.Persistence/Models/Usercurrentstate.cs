using System;
using System.Collections.Generic;

#nullable disable

namespace Toci.AffectiveBipolar.Database.Persistence.Models
{
    public partial class Usercurrentstate
    {
        public int Id { get; set; }
        public int? Iduser { get; set; }
        public DateTime? Currentdate { get; set; }
        public int? Idaffectivebipolarstate { get; set; }

        public virtual Affectivebipolarstate IdaffectivebipolarstateNavigation { get; set; }
        public virtual User IduserNavigation { get; set; }
    }
}
