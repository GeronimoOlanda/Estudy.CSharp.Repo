using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudos.Fundamentos.Console.Classes;
using System.Collections;

namespace Estudos.Fundamentos.Console.Fundamentos
{
    internal class WorkWithLinq
    {

        public WorkWithLinq()
        {

        }


        public void WorkWhere()
        {
    

            var pessoa = new List<Pessoa>();

            pessoa.Add(new Pessoa() { Id = 1, Name = "Geronimo", Age = 24 });
            pessoa.Add(new Pessoa() { Id = 2, Name = "Thalia", Age = 23 });
            pessoa.Add(new Pessoa() { Id = 3, Name = "Alice", Age = 22 });
            pessoa.Add(new Pessoa() { Id = 4, Name = "Milena", Age = 41 });
            pessoa.Add(new Pessoa() { Id = 5, Name = "Emannuel", Age = 66 });
            pessoa.Add(new Pessoa() { Id = 6, Name = "Gaspar", Age = 12 });


            var exibir = pessoa.Where(p => p.Id > 0).Where(p => p.Id < 6);
            foreach (var ex in exibir)
            {
                System.Console.WriteLine($"Id = {ex.Id}. Nome = {ex.Name}. Idade = {ex.Age}.");

            }

        }

    }


}
