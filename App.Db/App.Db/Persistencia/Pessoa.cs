//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.Db.Persistencia
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pessoa
    {
        public Pessoa()
        {
            this.Telefone = new HashSet<Telefone>();
        }
    
        public int Codigo { get; set; }
        public string Nome { get; set; }
    
        public virtual ICollection<Telefone> Telefone { get; set; }
    }
}