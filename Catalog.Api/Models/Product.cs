using BuildingBlocks.CQRS;


namespace Catalog.Api.Models
{
	public class Product
	{
		public Guid Id { get; set; } = default!;
		public string Name { get; set; } = default!;
		public List<string> Category { get; set; } = new();
		public string Description { get; set; } = default!;
		public string ImageFile { get; set; } = default!;
		public decimal Price { get; set; }

		public record CreateProduct(string name, List<string> category, string description, string imageFile, decimal price) : ICommand<CreateProduct>;
		public record ProductResult(Guid guid);

		internal class CreateProdutctHandler : ICommandHandler<CreateProduct, ProductResult>
		{
			public Task<ProductResult> Handle(CreateProduct request, CancellationToken cancellationToken)
			{
				throw new NotImplementedException();
			}
		}
	}
}
