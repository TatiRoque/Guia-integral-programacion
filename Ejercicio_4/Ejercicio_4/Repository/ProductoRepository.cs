using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Models;
using Controllers;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductoRepository
    {
        private readonly string _path = "Repository/Data/productos.json";
        private List<Product> _productos;

        public ProductoRepository()
        {
            _productos = Load();
        }

        public List<Product> GetAll() => _productos;

        public void Add(Product producto)
        {
            _productos.Add(producto);
        }

        public bool Delete(int id)
        {
            var prod = _productos.FirstOrDefault(p => p.Id == id);
            if (prod != null)
            {
                _productos.Remove(prod);
                return true;
            }
            return false;
        }

        public bool Update(int id, Action<Product> update)
        {
            var prod = _productos.FirstOrDefault(p => p.Id == id);
            if (prod != null)
            {
                update(prod);
                return true;
            }
            return false;
        }

        public void Save()
        {
            Directory.CreateDirectory("Repository/Data"); // Asegura que exista la carpeta
            var json = JsonSerializer.Serialize(_productos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_path, json);
        }

        private List<Product> Load()
        {
            if (!File.Exists(_path)) return new List<Product>();

            var json = File.ReadAllText(_path);
            return JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
        }
    }
}
