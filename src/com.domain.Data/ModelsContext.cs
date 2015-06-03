using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.domain.Data
{
    using com.domain.Data.Models;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    /// <summary>
    /// Data Context
    /// </summary>
    public class ModelsContext : DbContext
    {
        /// <summary>
        /// Base
        /// </summary>
        public ModelsContext() : base("name=DefaultConnection") { }

        /// <summary>
        /// Setup Configuration
        /// </summary>
        public virtual DbSet<Setup> Setup { get; set; }
    }
}
