using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Api.Catalog;

public class Api(IValidator<CreateCatalogItemRequest> validator) : ControllerBase
{
    [HttpPost("/catalog")]
    public async Task<ActionResult> AddACatalogItemAsync([FromBody] CreateCatalogItemRequest request, CancellationToken token)
    {
        // get the JSON data they sent and look at it. Is it cool?
        // If not, send them an error (400, with some details)
        // if it is cool, maybe save it to a database or something?
        // we have to create the entity to save from the request, and add it to the database, etc.
        // save it
        // and what are we going to return
        // return to them, from the entity, the thing we are giving them as the "receipt"

        var response = new CatalogItemResponse(Guid.NewGuid(), request.Title, request.Description);

        return Ok(response); // I have stored this thing in such a way that you can get it again, it is now part of this collection

    }
}
