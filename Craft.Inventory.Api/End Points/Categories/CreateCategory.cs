using huzcodes.Endpoints.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Craft.Inventory.Api.End_Points.Categories
{
    public class CreateCategory : EndpointsAsync.WithRequest<CreateCategoriesRequest>
                                                .WithActionResult<CreateCategoriesResponse>
    {
        [HttpPost(Routes.CategoriesRoutes.CreateCategory)]
        public async override Task<ActionResult<CreateCategoriesResponse>> HandleAsync(CreateCategoriesRequest request, CancellationToken cancellationToken = default)
        {
            var res = new CreateCategoriesResponse(request.Name, request.Description);
            return Ok(res);
        }
    }
}
