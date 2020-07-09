using System;
using System.Collections.Generic;

namespace PruebaGenericos
{
    class dbContext
    {
        public virtual List<Category> Category { get {
            var list  = new List<Category>();
            var i =0;

            list.Add(new Category{ Id=i++, Descripcion = nameof(Category) + i });
            list.Add(new Category{ Id=i++, Descripcion = nameof(Category) + i });
            list.Add(new Category{ Id=i++, Descripcion = nameof(Category) + i });

            return list;
        }}
        public virtual List<Provider> Provider { get {
            var list  = new List<Provider>();
            var i =0;

            list.Add(new Provider{ Id=i++, Descripcion = nameof(Provider) + i });
            list.Add(new Provider{ Id=i++, Descripcion = nameof(Provider) + i });
            list.Add(new Provider{ Id=i++, Descripcion = nameof(Provider) + i });
            
            return list;
        }}
        public virtual List<Customer> Customer { get {
            var list  = new List<Customer>();
            var i =0;

            list.Add(new Customer{ Id=i++, Descripcion = nameof(Customer) + i });
            list.Add(new Customer{ Id=i++, Descripcion = nameof(Customer) + i });
            list.Add(new Customer{ Id=i++, Descripcion = nameof(Customer) + i });
            
            return list;
        }}
    }
}
