using System.Collections.Generic;
using VendeBemVeiculos_Patterns.Interfaces;
using VendeBemVeiculos_Patterns.TXTDataBase;

namespace VendeBemVeiculos_Patterns.Controlers
{
    public class ClientsControl : PeopleControl<IPerson>
    {
        public ClientsControl()
        {
            this.peopleDB = new ClientTXT();
            this.People = (ICollection<IPerson>)peopleDB.Recover();
        }
    }
}
