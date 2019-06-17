using Microsoft.EntityFrameworkCore;
using Portal.Business.Contracts;
using Portal.Domain;
using Portal.Domain.Models;
using Portal.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal.Business.Services
{
    public class PersonService:IPersonService,IContactsService
    {

        private readonly ApplicationDbContext _context;

        public PersonService(ApplicationDbContext context)
        => _context = context;

        #region person
       
        //public PersonWriteViewModels find(Func<PersonWriteViewModels, bool> predicate)
        // => _context.Person.Include(s=>s.Contacts).Include(s=>s.Departments).Find(predicate);

        public IQueryable<PersonViewModel> Get(Func<PersonViewModel, bool> predicate = null)
        {
            var datacollection = new List<PersonViewModel>();
            var ds = (from u in _context.Person.Include(s => s.Departments)
                     join k in _context.Contacts
                     on u.Id equals k.PeronsId
                     select new
                     {
                         Id = u.Id,
                         CId = k.Id,
                         Name = u.Name,
                         Gender = u.Gender,
                         Department = u.Departments,
                         Phone = k.PhoneNumber,
                         Email = k.Email,
                         Address = k.HouseAddress
                     }).ToList();


            foreach(var item in ds)
            {
                datacollection.Add(new PersonViewModel
                {
                    Id = item.Id,
                    ContactId = item.CId,
                    Name = item.Name,
                    Gender = item.Gender,
                    Email = item.Email,
                    PhoneNumber = item.Phone,
                    Address = item.Address,
                    Departments = item.Department
                });
            }

            return predicate!=null ? datacollection.Where(predicate).AsQueryable()
                : datacollection.AsQueryable();
        }

        public PersonWriteViewModels find(Func<PersonWriteViewModels, bool> predicate )
        {
            var datacollection = new List<PersonWriteViewModels>();
            var ds = (from u in _context.Person.Include(s => s.Departments)
                      join k in _context.Contacts
                      on u.Id equals k.PeronsId
                      
                      select new
                      {
                          Id = u.Id,
                          CId = k.Id,
                          FirstName = u.FirstName,
                          OtherName = u.OtherName,
                          LastName = u.LastName,
                          Gender = u.Gender,
                          Department = u.Departments,
                          Phone = k.PhoneNumber,
                          Email = k.Email,
                          Address = k.HouseAddress
                      }).ToList();


            foreach (var item in ds)
            {
                datacollection.Add(new PersonWriteViewModels
                {
                    Id = item.Id,
                    CId = item.CId,                    
                    FirstName = item.FirstName,
                    LastName =  item.LastName,
                    OtherName = item.OtherName,
                    Gender = item.Gender,
                    Email = item.Email,
                    PhoneNumber = item.Phone,
                    HouseAddress = item.Address,
                    Department = item.Department.Id
                });
            }

            return datacollection.Where(predicate).SingleOrDefault();
        }

        public Notifications Save(PersonWriteViewModels entity)
        {
            var notification = new Notifications();
            try
            {
                var person = new Person
                {
                    Id = entity.Id,
                    FirstName = entity.FirstName,
                    OtherName = entity.OtherName,
                    LastName = entity.LastName,
                    Gender = entity.Gender,
                    DepartmentId = entity.Department
                };
                 _context.Person.Add(person);
                _context.SaveChanges();
                if (person.Id > 0)
                {
                    var contact = new Contacts
                    {
                        PhoneNumber = entity.PhoneNumber,
                        Email = entity.Email,
                        HouseAddress = entity.HouseAddress,
                        PeronsId = person.Id
                    };
                    _context.Contacts.Add(contact);
                    _context.SaveChanges();
                }


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

        public Notifications Edit(PersonWriteViewModels entity)
        {
            var notification = new Notifications();
            try
            {
                var person = new Person
                {
                    Id = entity.Id,
                    FirstName = entity.FirstName,
                    OtherName = entity.OtherName,
                    LastName = entity.LastName,
                    Gender = entity.Gender,
                    DepartmentId = entity.Department
                };
                _context.Entry(person).State = EntityState.Modified;
                _context.SaveChanges();
                if (person.Id > 0)
                {
                    var contact = new Contacts
                    {
                        Id = entity.CId,
                        PhoneNumber = entity.PhoneNumber,
                        Email = entity.Email,
                        HouseAddress = entity.HouseAddress,
                        PeronsId = person.Id
                    };
                    _context.Entry(contact).State = EntityState.Modified;
                    _context.SaveChanges();
                }
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

        public Notifications Delete(PersonWriteViewModels entity)
        {
            var notification = new Notifications();
            try
            {
                var person = new Person
                {
                    Id = entity.Id,
                    FirstName = entity.FirstName,
                    OtherName = entity.OtherName,
                    LastName = entity.LastName,
                    Gender = entity.Gender,
                    DepartmentId = entity.Department
                };
               
                _context.Entry(person).State = EntityState.Deleted;
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

        #endregion

        #region contact

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

      

        #endregion

    }
}
