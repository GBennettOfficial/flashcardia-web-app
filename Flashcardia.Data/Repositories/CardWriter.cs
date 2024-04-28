using Flashcardia.Global.Interfaces.DataAccess;
using Flashcardia.Global.Models;

namespace Flashcardia.Data.Repositories
{
    public class CardWriter : IDataAccessWriter<Card>
    {
        private readonly ApplicationDbContext _context;

        public CardWriter(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse> Create(Card card)
        {
            return await Task.Run(() =>
            {
                try
                {
                    _context.Cards.Add(card);
                    _context.SaveChanges();
                    return new ServiceResponse(isSuccess: true, message: "", exception: null);
                }
                catch (Exception ex)
                {
                    return new ServiceResponse(isSuccess: false, message: "failure adding card to database", exception: ex);
                }
            });
        }

        public async Task<ServiceResponse> Update(Card card)
        {
            return await Task.Run(() =>
            {
                try
                {
                    _context.Cards.Update(card);
                    _context.SaveChanges();
                    return new ServiceResponse(isSuccess: true, message: "", exception: null);
                }
                catch (Exception ex)
                {
                    return new ServiceResponse(isSuccess: false, message: "failure updating card in database", exception: ex);
                }
            });
        }

        public async Task<ServiceResponse> Delete(Card card)
        {
            return await Task.Run(() =>
            {
                try
                {
                    _context.Cards.Remove(card);
                    _context.SaveChanges();
                    return new ServiceResponse(isSuccess: true, message: "", exception: null);
                }
                catch (Exception ex)
                {
                    return new ServiceResponse(isSuccess: false, message: "failure deleting card from database", exception: ex);
                }
            });
        }
    }
}
