//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ambulance
{
    using System;
    using System.Collections.Generic;
    
    public partial class ill_history
    {
        public ill_history()
        {
            this.historystr = new HashSet<historystr>();
        }
    
        public long ill_id { get; set; }
        public string PName { get; set; }
        public string PAdress { get; set; }
        public long NPasport { get; set; }
        public System.DateTime Date_in { get; set; }
        public System.DateTime Date_out { get; set; }
        public string Diagn_in { get; set; }
        public string Diagn_out { get; set; }
        public long shifr { get; set; }
        public Nullable<long> Pal_id { get; set; }
    
        public virtual doctors doctors { get; set; }
        public virtual ICollection<historystr> historystr { get; set; }
        public virtual palata palata { get; set; }
    }
}
