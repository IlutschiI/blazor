using BlazorDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BspBlazorDB.DataAccess
{
    public class TodoContext : StorageContext
    {
        public StorageSet<Todo> Todos { get; set; }
    }
}
