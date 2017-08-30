using System.Collections.Generic;
using VendeBemVeiculos_Patterns.Interfaces;

namespace VendeBemVeiculos_Patterns.Controlers
{
    class EmployeesControl : PeopleControl<IEmployee>
    {
        public EmployeesControl()
        {
            this.peopleDB = new SellersTXTDataBase();
            this.People = (ICollection<IEmployee>)peopleDB.Recover();
        }
    }
}
