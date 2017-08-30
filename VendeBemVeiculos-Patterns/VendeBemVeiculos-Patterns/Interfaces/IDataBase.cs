using System.Collections.Generic;

namespace VendeBemVeiculos_Patterns
{
    public interface IDataBase<T>
    {
        IEnumerable<T> Recover();
        void Update(IEnumerable<T> values);
    }
}
