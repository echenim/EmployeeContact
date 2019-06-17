using Microsoft.EntityFrameworkCore;
using Portal.Business.Contracts;
using Portal.Domain;
using Portal.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal.Business.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly ApplicationDbContext _context;

        public DepartmentService(ApplicationDbContext context)
        => _context = context;

        public Departments find(Func<Departments, bool> predicate)
         => _context.Departments.Where(predicate).SingleOrDefault();

        public IQueryable<Departments> Get(Func<Departments, bool> predicate = null)
        => predicate != null 
            ? _context.Departments.Include(s=>s.People).Where(predicate: predicate).AsQueryable() 
            :  _context.Departments.Include(s => s.People).OrderBy(s => s.Name).AsQueryable();

        public Notifications Save(Departments entity)
        {
            var notification = new Notifications();
            try
            {
               
                    _context.Departments.Add(entity);
                    _context.SaveChanges();
                    notification.Id = entity.Id.ToString();
                    notification.Success = true;
              
            }
            catch(Exception e)
            {
                notification.Success = false;
                notification.Message = e.Message;
            }

            return notification;
        }

        public Notifications Edit(Departments entity)
        {
            var notification = new Notifications();
            try
            {
                
                    _context.Entry(entity).State = EntityState.Modified;
                    _context.SaveChanges();
                    notification.Id = entity.Id.ToString();
                    notification.Success = true;
            }
            catch (Exception e)
            {
                notification.Success = false;
                notification.Message = e.Message;
            }

            return notification;
        }

        public Notifications Delete(Departments entity)
        {
            var notification = new Notifications();
            try
            {

                _context.Entry(entity).State = EntityState.Deleted;
                _context.SaveChanges();
                notification.Id = entity.Id.ToString();
                notification.Success = true;
            }
            catch (Exception e)
            {
                notification.Success = false;
                notification.Message = e.Message;
            }

            return notification;
        }
    }
}
