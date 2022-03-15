using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projekt_01.Models
{
    public class StudentiDB
    {
        private List<Student> lista = new List<Student>();
        public StudentiDB() 
        {
            lista.Add(new Student()
                {
                    ID = 1,
                    Prezime = "Ivić",
                    Ime = "Milivoj",
                    Spol = 'M',
                    DatumRodjenja = new DateTime(1990, 04, 24),
                    Oib = "42722876577",
                    RedovanStudent = true
                }); lista.Add(new Student()
                {
                    ID = 2,
                    Prezime = "Ivić",
                    Ime = "Milivoj",
                    Spol = 'M',
                    DatumRodjenja = new DateTime(1990, 04, 24),
                    Oib = "42722876577",
                    RedovanStudent = true
                }); lista.Add(new Student()
                {
                    ID = 3,
                    Prezime = "Ivić",
                    Ime = "Milivoj",
                    Spol = 'M',
                    DatumRodjenja = new DateTime(1990, 04, 24),
                    Oib = "42722876577",
                    RedovanStudent = true
                }); lista.Add(new Student()
                {
                    ID = 4,
                    Prezime = "Ivić",
                    Ime = "Milivoj",
                    Spol = 'M',
                    DatumRodjenja = new DateTime(1990, 04, 24),
                    Oib = "42722876577",
                    RedovanStudent = true
                });
        }
        public List<Student> VratiListu()
        {
            return lista;
        }
    }
}