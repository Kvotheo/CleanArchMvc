using CleanArchMvc.Domain.Validation;
using System.Collections;
using System.Collections.Generic;

namespace CleanArchMvc.Domain.Entitites
{
    public sealed class Category : Entity
    {
        public string Name { get; set; }

        public Category(string name)
        {
            ValidationDomain(name);
        }

        public void Update(string name)
        {
            ValidationDomain(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            ValidationDomain(name);
        }

        //IColletion porque uma categoria pode ter vários produtos
        public ICollection<Product> Products { get; set; }

        private void ValidationDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name. Too short, minimum 3 characters");

            Name = name;
        }
    }
}
