using NHibernate.Cfg;
using NHibernateSuccintlyDemo.Models;
using System;

namespace NHibernateSuccintlyDemo
{
    public class NHibernateSaveScenarios
    {

        public NHibernateSaveScenarios()
        {

        }

        public void RunTest()
        {
            // Save a Shopper entity
            //SaveShopperTest();

            //OneToOneSaveTest();

            //ManyToOneSaveTest();

            ManyToManySaveTest();
        }

        public void SaveShopperTest()
        {
            var config = new Configuration().
                AddAssembly("NHibernateSuccintlyDemo");
            
            var shopper = new Shopper { ShopperName = "Siva" };

            using(var sessionFactory = config.BuildSessionFactory())
            {
                using(var session = sessionFactory.OpenSession())
                {

                    var transaction = session.BeginTransaction();

                    session.Save(shopper);
                    session.Flush();
                    transaction.Commit();
                    session.Close();
                }
            }
        }

        public void OneToOneSaveTest()
        {
            var config = new Configuration().
                AddAssembly("NHibernateSuccintlyDemo");

            using(var sessionFactory = config.BuildSessionFactory())
            using(var session = sessionFactory.OpenSession())
            using(var transaction = session.BeginTransaction())
            {
                try
                {
                    var shoppingPoints = new ShoppingPoints { Points = 255.00};
                    var shopper = new Shopper { ShopperName = "Karthik", ShoppingPoints = shoppingPoints };
                    shoppingPoints.Shopper = shopper;
                    session.Save(shopper);
                    session.Flush();
                    transaction.Commit();
                }
                catch(Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public void ManyToOneSaveTest()
        {
            var config = new Configuration().
                AddAssembly("NHibernateSuccintlyDemo");

            using (var sessionFactory = config.BuildSessionFactory())
            using (var session = sessionFactory.OpenSession())
            using(var transaction = session.BeginTransaction())
            {
                try
                {
                    var student = new Student { StudentName = "Stephen" };
                    var address1 = new Address { AddressLine1 = "Ramji Nagar", City = "Nellore", Student = student };
                    var address2 = new Address { AddressLine1 = "Hollingworth Drive", City = "Toronto", Student = student };
                    session.Save(address1);
                    session.Save(address2);
                    session.Flush();
                    transaction.Commit();
                }
                catch(Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                
            }
        }

        public void ManyToManySaveTest()
        {
            var config = new Configuration().
                AddAssembly("NHibernateSuccintlyDemo");

            using (var sessionFactory = config.BuildSessionFactory())
            using (var session = sessionFactory.OpenSession())
            using(var transaction = session.BeginTransaction())
            {
                try
                {
                    transaction.Commit();
                }
                catch(Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }
    }
}