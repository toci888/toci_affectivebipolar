using System;
using System.Collections.Generic;

#nullable disable

namespace Toci.AffectiveBipolar.Database.Persistence.Models
{
    public partial class Usermedicamentdose
    {
        public int Id { get; set; }
        public int? Iduser { get; set; }
        public int? Idmedicament { get; set; }
        public double? Dose { get; set; }
        public DateTime? Consumptiondate { get; set; }

        public virtual Medicament IdmedicamentNavigation { get; set; }
        public virtual User IduserNavigation { get; set; }
    }
}
