using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;

namespace PaintPortal.APIS
{
    public interface IApiCalls
    {
        Task<IEnumerable<Adress>> GetAdressAsync();
        Task<IEnumerable<Person>> GetPeopleAsync();
        Task<IEnumerable<PaintHouse>> GetPaintHouseAsync();
    }
}
