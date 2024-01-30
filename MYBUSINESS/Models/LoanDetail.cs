//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MYBUSINESS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoanDetail
    {
        public decimal Auto { get; set; }
        public string POId { get; set; }
        public Nullable<int> PODId { get; set; }
        public Nullable<decimal> ProductId { get; set; }
        public Nullable<decimal> OpeningStock { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> PurchasePrice { get; set; }
        public Nullable<decimal> PerPack { get; set; }
        public Nullable<bool> IsPack { get; set; }
        public Nullable<bool> SaleType { get; set; }
        public string Remarks { get; set; }
    
        public virtual Loan Loan { get; set; }
        public virtual Product Product { get; set; }
    }
}
