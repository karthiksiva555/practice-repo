using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public class ContactManagerInitializer: DropCreateDatabaseIfModelChanges<ContactManagerContext>
    {
        protected override void Seed(ContactManagerContext context)
        {
            //base.Seed(context);

            var contacts = new List<Contact> {
                new Contact { FirstName = "Siva", LastName = "Narisetty", Nickname = "Koti", EmailAddress = "karthik.siva555@gmail.com" },
                new Contact { FirstName = "Hari", LastName = "Krishna", Nickname = "Kanthri", EmailAddress = "harikrishna.p@gmail.com" },
            };

            contacts.ForEach(contact => context.Contacts.Add(contact));
            context.SaveChanges();

            var phoneNums = new List<PhoneNumber>() {
                new PhoneNumber { NumberAsString = "+1 416 627 4491",ContactId = 1 },
                new PhoneNumber{NumberAsString = "+1 647 426 1989",ContactId = 1} ,
                new PhoneNumber { NumberAsString = "+1 416 666 4455",ContactId = 2 },
                new PhoneNumber{NumberAsString = "+1 647 939 2015",ContactId = 2}
            };

            phoneNums.ForEach(num => context.PhoneNumbers.Add(num));
            context.SaveChanges();

        }
    }
}