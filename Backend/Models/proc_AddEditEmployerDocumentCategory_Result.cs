//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Backend.Models
{
    using System;
    
    public partial class proc_AddEditEmployerDocumentCategory_Result
    {
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Active { get; set; }
        public byte[] Timestamp { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
    }
}
