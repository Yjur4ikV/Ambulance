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
    
    public partial class m_sister
    {
        public m_sister()
        {
            this.ambulance_user = new HashSet<ambulance_user>();
        }
    
        public long M_id { get; set; }
        public string M_Name { get; set; }
        public Nullable<long> OtdNumb { get; set; }
        public System.DateTime Date_in { get; set; }
        public System.DateTime Date_out { get; set; }
    
        public virtual ICollection<ambulance_user> ambulance_user { get; set; }
    }
}
