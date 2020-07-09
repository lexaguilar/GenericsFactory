using System;
using System.Collections.Generic;

namespace PruebaGenericos
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private IEnumerable<Category> GetCategories(){
             var factory = new GenericFactory<Category>();
            return factory.GetAll();
        }
        private IEnumerable<Customer> GetCustomers(){
             var factory = new GenericFactory<Customer>();
            return factory.GetAll();
        }
        private IEnumerable<Provider> GetProviders(){
             var factory = new GenericFactory<Provider>();
            return factory.GetAll();
        }

        private IEnumerable<Object> GetCatalogo(string catalogName){
            //...
            //

            return new List<Object>();
        }


    }

    

    public class GenericFactory<T> : IGenericFactory<T> where T : class
    {
        private dbContext db = null;
        private List<T> entity = null;
        public GenericFactory()
        {
            this.db = new dbContext();
            entity = new List<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entity.ToArray();
        }
    }

    public interface IGenericFactory<T> where T : class
    {
        IEnumerable<T> GetAll();

    }
}
