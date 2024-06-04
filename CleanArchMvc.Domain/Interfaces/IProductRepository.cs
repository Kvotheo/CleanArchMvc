using CleanArchMvc.Domain.Entitites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IProductRepository
    {
        /// <summary>
        /// Pega todos os produtos
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Product>> GetProductsAsync();

        /// <summary>
        /// Pega os produtos pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Product> GetByIdAsync(int? id);

        /// <summary>
        /// Cria um novo produto
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Task<Product> CreateAsync(Product product);

        /// <summary>
        /// Realiza a atualização do produto
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Task<Product> UpdateAsync(Product product);

        /// <summary>
        /// Remove o produto
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Task<Product> RemoveAsync(Product product);

    }
}
