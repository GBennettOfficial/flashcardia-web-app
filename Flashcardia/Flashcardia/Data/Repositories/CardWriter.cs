﻿namespace Flashcardia.Models
{
    public class CardWriter
    {
        private readonly ApplicationDbContext _context;

        public CardWriter(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(Deck deck)
        {
            await _context.Decks.AddAsync(deck);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Deck deck)
        {
            _context.Update(deck);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Deck deck)
        {
            _context.Remove(deck);
            await _context.SaveChangesAsync();
        }
    }
}