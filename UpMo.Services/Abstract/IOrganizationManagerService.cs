using System.Threading.Tasks;
using UpMo.Common.DTO.Request;
using UpMo.Common.Response;

namespace UpMo.Services.Abstract
{
    public interface IOrganizationManagerService
    {
        /// <summary>
        /// Creates manager for organization.
        /// <para>Authenticated user must be creator of the Organization</para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns><see cref="ApiResponse"/> with <see cref="ResponseStatus.Created"/>, <see cref="ResponseStatus.BadRequest"/>, <see cref="ResponseStatus.NotFound"/> or <see cref="ResponseStatus.Forbid"/></returns>
        Task<ApiResponse> CreateByRequestAsync(OrganizationManagerCreateRequest request);

        /// <summary>
        /// Updates created manager 
        /// <para>Authenticated user must be creator of the Organization</para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns><see cref="ApiResponse"/> with <see cref="ResponseStatus.OK"/>, <see cref="ResponseStatus.NotFound"/> or <see cref="ResponseStatus.Forbid"/></returns>
        Task<ApiResponse> UpdateByRequestAsync(OrganizationManagerUpdateRequest request);
    }
}