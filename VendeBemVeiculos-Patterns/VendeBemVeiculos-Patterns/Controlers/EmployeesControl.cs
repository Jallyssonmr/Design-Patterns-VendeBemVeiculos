using System.Collections.Generic;
using VendeBemVeiculos_Patterns.Interfaces;
using VendeBemVeiculos_Patterns.TXTDataBase;

namespace VendeBemVeiculos_Patterns.Controlers
{
    class EmployeesControl : PeopleControl<IEmployee>
    {
        public EmployeesControl()
        {
            this.peopleDB = new SellerTXT();
            this.People = (ICollection<IEmployee>)peopleDB.Recover();
        }
    }
}
