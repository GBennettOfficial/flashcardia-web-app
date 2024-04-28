using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcardia.Global.Interfaces.DataAccess
{
    public interface IReadCards
    {
        Task<ICollection<Card>> Get(int deckId);
    }
}
