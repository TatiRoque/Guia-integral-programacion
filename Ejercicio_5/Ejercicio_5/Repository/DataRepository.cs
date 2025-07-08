using Models;
using System.Text.Json;

namespace Repository
{
    public class RepositoryData
    {
        public List<Book> Books { get; set; } = new();
        public List<User> Users { get; set; } = new();
        public List<Loan> Loans { get; set; } = new();
    }

    public class DataRepository
    {
        private const string FilePath = "Repository/Data/data.json";

        public List<Book> Books { get; set; } = new();
        public List<User> Users { get; set; } = new();
        public List<Loan> Loans { get; set; } = new();

        public DataRepository()
        {
            Load();
        }

        public void Save()
        {
            Directory.CreateDirectory("Repository/Data");

            var data = new RepositoryData
            {
                Books = this.Books,
                Users = this.Users,
                Loans = this.Loans
            };

            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        private void Load()
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                var data = JsonSerializer.Deserialize<RepositoryData>(json);
                if (data != null)
                {
                    Books = data.Books;
                    Users = data.Users;
                    Loans = data.Loans;
                }
            }
        }
    }
}

