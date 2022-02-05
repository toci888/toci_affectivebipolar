using System;
using System.Collections.Generic;

#nullable disable

namespace Toci.AffectiveBipolar.Database.Persistence.Models
{
    public partial class Medicament
    {
        public Medicament()
        {
            Consumptionorderhistories = new HashSet<Consumptionorderhistory>();
            Usermedicamentdoses = new HashSet<Usermedicamentdose>();
            Userorderedmedicaments = new HashSet<Userorderedmedicament>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Idsubstance { get; set; }

        public virtual Substance IdsubstanceNavigation { get; set; }
        public virtual ICollection<Consumptionorderhistory> Consumptionorderhistories { get; set; }
        public virtual ICollection<Usermedicamentdose> Usermedicamentdoses { get; set; }
        public virtual ICollection<Userorderedmedicament> Userorderedmedicaments { get; set; }
    }
}
