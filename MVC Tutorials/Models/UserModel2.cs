namespace MVC_Tutorials.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserModel2
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column("First Name")]
        public string First_Name { get; set; }

        [Column("Last Name")]
        public string Last_Name { get; set; }

        public int? Age { get; set; }
    }
}
