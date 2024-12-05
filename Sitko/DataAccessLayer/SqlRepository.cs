using Microsoft.EntityFrameworkCore;
using Sitko.Abstract;
using Sitko.Data;
using Sitko.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;

namespace Sitko.DataAccessLayer
{
    public class SqlRepository : IRepository<LineModel>
    {
        private readonly AppDbContext _context;
        public SqlRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Create(LineModel entity)
        {
            _context.lines.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var entry = _context.lines.Find(id);
            _context.lines.Remove(entry);
            _context.SaveChanges();
        }

        public LineModel Read(long? Id)
        {
            return _context.lines.Find(Id);
        }

        public IEnumerable<LineModel> ReadList()
        {
            return _context.lines;
        }

        public void Update(LineModel entity)
        {
            _context.lines.Update(entity);
            _context.SaveChanges();
        }
    }
}
