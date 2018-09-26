//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Commentaire
    {
        public int IDCom { get; set; }
        public string DateCom { get; set; }
        public string Auteur { get; set; }

        [DisplayName("Contenu du cmmentaire")]
        [Required(ErrorMessage = "Contenu requis")]
        [StringLength(200, ErrorMessage = "Longueur Max=200")]
        public string Contenu { get; set; }
        public Nullable<int> Idart { get; set; }
    
        public virtual Article Article { get; set; }
    }
}
