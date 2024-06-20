using CleanArchMvc.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Interfaces
{
    public interface ICategoryService
    {

        /// <summary>
        /// Retornando as categorias
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<CategoryDTO>> GetCategories();

        /// <summary>
        /// Pega a categoria pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CategoryDTO> GetCategoryById(int? id);
        
        /// <summary>
        /// Adiciona uma nova categoria
        /// </summary>
        /// <param name="categoryDTO"></param>
        /// <returns></returns>
        Task Add(CategoryDTO categoryDTO);

        /// <summary>
        /// Realiza a alteração da categoria
        /// </summary>
        /// <param name="categoryDTO"></param>
        /// <returns></returns>
        Task Update(CategoryDTO categoryDTO);

        /// <summary>
        /// Remove a categoria
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Remove(int? id);

    }
}
