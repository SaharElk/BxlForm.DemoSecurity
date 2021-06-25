using BxlForm.DemoSecurity.Models.Client.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BxlForm.DemoSecurity.Models.Client.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Get();
    }
}
