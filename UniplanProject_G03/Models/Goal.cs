//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniplanProject_G03.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Goal
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public string Detail { get; set; }
        public int Percent { get; set; }
        public int GoalTypeID { get; set; }
        public string UserName { get; set; }
    
        public virtual GoalType GoalType { get; set; }
    }
}