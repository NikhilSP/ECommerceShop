namespace Catalog.API.Exceptions;

public class ProductNotFoundException : Exception
{
    public ProductNotFoundException(Guid Id) : base(Id.ToString())
    {
    }
}
