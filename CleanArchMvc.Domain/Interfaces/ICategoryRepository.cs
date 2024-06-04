using CleanArchMvc.Domain.Entitites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface ICategoryRepository
    {

        /// <summary>
        /// Pega todas as categorios 
        /// </summary>
        /// <returns></returns>
       Task<IEnumerable<Category>> GetCategoriesAsync();

        /// <summary>
        /// Pega as categorias pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       Task<Category> GetByIdAsync(int? id);

        /// <summary>
        /// Cria uma nova categoria
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        Task<Category> CreateAsync(Category category);
        
        /// <summary>
        /// Faz a atualização da categoria
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        Task<Category> UpdateAsync(Category category);

        /// <summary>
        /// Remove a categoria
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        Task<Category> RemoveAsync(Category category);
    }
}
