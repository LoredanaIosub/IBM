using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SummerScool.DAL.DbModels
{
    public class User
    {
        [Key] //pt a se sti ca guid e cheie primara
        public Guid Id { get; set; } //guid genereaza un sir de caractere

        [Required]
        [MaxLength(35)]
        public string Email { get; set; } //proprietate(se incepe cu litera mare, fiecare cuvant cu litera mare)

        [MaxLength(35)]
        public string UserName { get; set; }//UserName column will be nvarchar(100)
        //public string email2 = "ceva"; //variabila

        [Required]
        [MaxLength(35)]
        public string Password { get; set; }

        [MaxLength(35)]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [MaxLength(35)]
        public string Addreess { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime CreateAt { get; set; } //coloane de tip datetime pt a pastra cand se face inregistrarea

        public Guid CreatedBy { get; set; } 

        public DateTime ModifiedAt { get; set; }

        public User ModifiedBy { get; set; } //contine un primary key din tabela user


     


    }

   

}