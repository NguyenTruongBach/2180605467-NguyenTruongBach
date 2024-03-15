using System.Security.Cryptography.X509Certificates;

namespace Web_ban_hang.Models
{
    public class MockProductRepository : IProductRepository
    {
        private readonly List<Product> _products;
        public MockProductRepository()
        {
            _products = new List<Product>
        {
            new Product { Id = 1, Name = "Giày Cầu Lông Lining ChenLong AYZU011-1 ", Price = 1000, Description= "Giày cầu lông Lining ChenLong AYZU011-1 (Nội địa Trung) là mẫu giày cao cấp được Li-ning cho ra mắt với phiên bản Chen Long phục vụ người bán chuyên và chuyên nghiệp."},
    };
        }
        public IEnumerable<Product> GetAll()
        {
            return _products;
        }
        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
        public void Add(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
        }
        public void Update(Product product)
        {
            var index = _products.FindIndex(p => p.Id == product.Id);
            if (index != 1)
            {
                _products[index] = product;
            }
        }
        public void Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }

        public Product GetByID(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
