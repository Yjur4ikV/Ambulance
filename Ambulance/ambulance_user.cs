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
    using System.ComponentModel.DataAnnotations;
    
    public partial class ambulance_user
    {
        public long id { get; set; }
        [Required(ErrorMessage="����������� ������ �����",AllowEmptyStrings=false)]
        public string login { get; set; }
        [Required(ErrorMessage="������ ������ �������",AllowEmptyStrings=false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string password { get; set; }
        public long role_id { get; set; }
        public long prof_id { get; set; }
    
        public virtual role role { get; set; }
        public virtual doctors doctors { get; set; }
        public virtual m_sister m_sister { get; set; }
    }
}
