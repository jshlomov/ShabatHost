using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabatHost.DAL.Model
{
    public class CategoryModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public CategoryModel(string categoryName, int categoryID)
        {
            Name = categoryName;
            ID = categoryID;
        }

        public CategoryModel(DataRow row)
        {
            if (row == null || row["Name"] == null)
            {
                throw new System.ArgumentNullException(nameof(row));
            }
            Name = row["Name"].ToString();
            ID = (int)row["ID"];
        }
    }
}
