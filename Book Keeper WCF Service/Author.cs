//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Book_Keeper_WCF_Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class Author
    {
        public Author()
        {
            this.BookXAuthors = new HashSet<BookXAuthor>();
        }
    
        public int Authorid { get; set; }
        public string Name { get; set; }
        public bool Hidden { get; set; }
    
        public virtual ICollection<BookXAuthor> BookXAuthors { get; set; }
    }
}
