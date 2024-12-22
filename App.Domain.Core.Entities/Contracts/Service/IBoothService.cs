using App.Domain.Core.Entities;

namespace App.Domain.Core.Contracts.Service;

public interface IBoothService
{
    Task Create(Booth booth, CancellationToken cancellationToken);
    Task Delete(Booth booth, CancellationToken cancellationToken);
    Task Update(Booth booth, CancellationToken cancellationToken);
    Task<List<Booth>> GetAll(CancellationToken cancellationToken);
    Task<Booth> GetById(int id, CancellationToken cancellationToken);
    Task<Booth> GetBySalesMan(int salesMan, CancellationToken cancellationToken);
    Task AddProduct(Product product, int boothId, CancellationToken cancellationToken);
    Task AddImage(string imageUrl, int id, CancellationToken cancellationToken);
    Task<List<Product>> GetAllProducts(int boothId, CancellationToken cancellationToken);
    Task<List<Booth>> GetPartof(int num, CancellationToken cancellationToken);
}