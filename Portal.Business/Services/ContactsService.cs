using Microsoft.EntityFrameworkCore;
using Portal.Business.Contracts;
using Portal.Domain;
using Portal.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Business.Services
{
    public class ContactsService : IContactsService
    {

        private readonly ApplicationDbContext _context;

        public ContactsService(ApplicationDbContext context)
        => _context = context;


        public Notifications Save(Contacts entity)
        {
            var notification = new Notifications();
            try
            {

                _context.Contacts.Add(entity);
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

        public Notifications Edit(Contacts entity)
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

        public Notifications Delete(Contacts entity)
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
