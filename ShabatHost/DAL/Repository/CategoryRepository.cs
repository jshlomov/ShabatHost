using ShabatHost.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ShabatHost.DAL.Repository
{
    public class CategoryRepository : IRepository<CategoryModel>
    {
        DBContext dbContext;

        public CategoryRepository(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<CategoryModel> FindAll()
        {
            try
            {
                List<CategoryModel> categories = new List<CategoryModel>();

                string query = "SELECT * FROM Categories";
                DataTable dt = dbContext.ExecuteQuery(query, null);
                foreach (DataRow dr in dt.Rows)
                {
                    categories.Add(new CategoryModel(dr));
                }
                return categories;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public CategoryModel FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(CategoryModel category)
        {
            try
            {
                string query = "INSERT INTO Categories (Name) VALUES (@CategoryName)";
                SqlParameter[] parameters = { new SqlParameter("@CategoryName", category.Name) };

                int rowsAffected = dbContext.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
