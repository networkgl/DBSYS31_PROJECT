//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMS.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_display_reservation_details
    {
        public int ID { get; set; }
        public Nullable<int> Guest { get; set; }
        public string Name { get; set; }
        public string RoomType { get; set; }
        public System.DateTime DateIn { get; set; }
        public System.DateTime DateOut { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
    }
}