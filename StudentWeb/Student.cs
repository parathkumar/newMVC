//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentWeb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Student
    {
        
        [Key]
        public int Sid { get; set; }
        [Required(ErrorMessage ="Please enter your name")]
        public string Sname { get; set; }
        [Range(0,100,ErrorMessage ="Enter marks between 0 and 100")]
        public Nullable<decimal> Marks { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage ="Enter your password")]
        [DataType(DataType.Password)]
        public string Pwd { get; set; }
        [DataType(DataType.DateTime)]
        public Nullable<System.DateTime> Dob { get; set; }
    }
}
