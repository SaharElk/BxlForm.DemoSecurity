using BxlForm.DemoSecurity.Models.Global.Data;
using BxlForm.DemoSecurity.Models.Global.Mappers;
using BxlForm.DemoSecurity.Models.Global.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Tools.Connections.Database;

namespace BxlForm.DemoSecurity.Models.Global.Services
{
    public class CategoryService : ICategoryRepository
    {
        private readonly Connection _connection;

        public CategoryService(Connection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Category> Get()
        {
            Command command = new Command("Select Id, Name From Category;", false);
            return _connection.ExecuteReader(command, dr => dr.ToCategory());
        }

        public void Insert(Category category)
        {
            Command command = new Command("BFSP_AddCategory", true);
            command.AddParameter("Name", category.Name);

            _connection.ExecuteNonQuery(command);
        }

        public void Update(int id, Category category)
        {
            Command command = new Command("Update Category SET Name = @Name WHERE Id = @Id;", false);
            command.AddParameter("Name", category.Name);
            command.AddParameter("Id", id);

            _connection.ExecuteNonQuery(command);
        }

        public void Delete(int id)
        {
            Command command = new Command("BFSP_DeleteCategory", true);
            command.AddParameter("Id", id);

            _connection.ExecuteNonQuery(command);
        }
    }
}
