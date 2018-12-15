﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vidly_RESTful_API.Contexts;
using Vidly_RESTful_API.Models;

namespace Vidly_RESTful_API.Services
{
    public class VidlyRepository : IVidlyRepository
    {
        private readonly VidlyContext _context;

        public VidlyRepository(VidlyContext context)
        {
            _context = context;
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetCustomerAsync(int customerId)
        {
            return await _context.Customers.FirstOrDefaultAsync(c => c.Id == customerId);
        }

        public void DeleteCustomer(Customer customer)
        {
            _context.Customers.Remove(customer);
        }

        public void AddGenre(Genre genre)
        {
            _context.Genres.Add(genre);
        }

        public async Task<IEnumerable<Genre>> GetGenresAsync()
        {
            return await _context.Genres.ToListAsync();
        }

        public async Task<Genre> GetGenreAsync(int genreId)
        {
            return await _context.Genres.FirstOrDefaultAsync(g => g.Id == genreId);
        }

        public void DeleteGenre(Genre genre)
        {
            _context.Genres.Remove(genre);
        }
    }
}