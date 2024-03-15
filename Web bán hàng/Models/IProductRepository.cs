namespace Web_ban_hang.Models;

    public interface IProductRepository
    {
    IEnumerable<Product> GetAll();
    Product GetByID(int id);
    void Add(Product product);
    void Update(Product product);
    void Delete(int id);
    }
