using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoNETCompleto.Models
{
    public class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime DateCreate { get; set; }

        public Person() { }

        public Person(long id, string name, string mail, DateTime dateCreate)
        {
            Id = id;
            Name = name;
            Mail = mail;
            DateCreate = dateCreate;
        }

        

    }



}