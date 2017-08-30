using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VendeBemVeiculos_Patterns.Interfaces;

namespace VendeBemVeiculos_Patterns.Controlers
{
    public abstract class PeopleControl<T> where T : IPerson
    {
        private const string ALREADY_REGISTERED = "CPF já possui cadastro.";

        protected IDataBase<T> peopleDB;

        public ICollection<T> People { get; protected set; } 

        public void Add(T person)
        {
            if (this.IsRegistered(person.CPFDocument))
            {
                MessageBox.Show(ALREADY_REGISTERED);
                return;
            }

            this.People.Add(person);
            this.peopleDB.Update(this.People);
        }

        public IEnumerable<string> GetCPFDocuments()
        {
            return this.People.Select(person => person.CPFDocument);
        }

        public T Select(string cpf)
        {
            return this.People.Where(person => person.CPFDocument == cpf).FirstOrDefault();
        }      

        public bool IsRegistered(string cpf)
        {
            var documents = this.GetCPFDocuments();
            return documents.Contains(cpf);
        }
    }
}
