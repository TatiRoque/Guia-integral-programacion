using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Views;

namespace Controllers
{
    public class ProductController
    {
        private readonly ProductoRepository _repo;
        private readonly ProductView _view;

        public ProductController()
        {
            _repo = new ProductoRepository();
            _view = new ProductView();
        }

        public void Run()
        {
            int option;
            do
            {
                _view.ShowMenu();
                int.TryParse(Console.ReadLine(), out option);
                Console.Clear();

                switch (option)
                {
                    case 1: Add(); break;
                    case 2: Delete(); break;
                    case 3: Update(); break;
                    case 4: List(); break;
                }

            } while (option != 0);

            _repo.Save();
            _view.ShowMessage("Data saved. Goodbye.");
        }

        private void Add()
        {
            int newId = _repo.GetAll().Count > 0 ? _repo.GetAll().Max(p => p.Id) + 1 : 1;
            var product = _view.RequestProductData(newId);
            _repo.Add(product);
            _view.ShowMessage("Product added.");
        }

        private void Delete()
        {
            int id = _view.RequestId("Enter product ID to delete: ");
            if (_repo.Delete(id))
                _view.ShowMessage("Product deleted.");
            else
                _view.ShowMessage("Product not found.");
        }

        private void Update()
        {
            int id = _view.RequestId("Enter product ID to update: ");
            var product = _repo.GetAll().FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                _view.ShowMessage("Product not found.");
                return;
            }

            int field = _view.SelectFieldToUpdate();
            _repo.Update(id, p =>
            {
                switch (field)
                {
                    case 1: p.Name = _view.RequestText("name"); break;
                    case 2: p.Price = _view.RequestDecimal("price"); break;
                    case 3: p.Stock = _view.RequestInt("stock"); break;
                }
            });

            _view.ShowMessage("Product updated.");
        }

        private void List()
        {
            var products = _repo.GetAll();
            _view.ShowProducts(products);
        }
    }
}
