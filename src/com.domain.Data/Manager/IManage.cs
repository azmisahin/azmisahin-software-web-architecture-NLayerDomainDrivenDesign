using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.domain.Data.Manager
{
    /// <summary>
    /// Manage Interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class IManage<T> : IDisposable
    {
        /// <summary>
        /// Base Context
        /// </summary>
        public ModelsContext DB;
        

        /// <summary>
        /// Constractor
        /// </summary>
        public IManage()
        {
            if (DB == null)
            {
                DB = new ModelsContext();
                DB.Configuration.ProxyCreationEnabled = false;
                DB.Configuration.LazyLoadingEnabled = false;
                DB.Configuration.AutoDetectChangesEnabled = false;
            }
        }

        /// <summary>
        /// List
        /// </summary>
        /// <returns></returns>
        public abstract List<T> List();

        /// <summary>
        /// List
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public abstract List<T> List(int id);

        /// <summary>
        /// List
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public abstract List<T> List(int id, T model);

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public abstract T Get();

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public abstract T Get(int id);

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public abstract T Get(T model);

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public abstract T Get(int id, T model);

        /// <summary>
        /// Post
        /// Record not found is Create record
        /// or New Record
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public abstract T Post(int id, T model);

        /// <summary>
        /// Post
        /// Record not found is Create record
        /// or New Record
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public abstract T Post(T model);

        /// <summary>
        /// Put
        /// New Record
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public abstract T Put(int id);

        /// <summary>
        /// Put
        /// New Record
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public abstract T Put(T model);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public abstract T Delete(int id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public abstract T Delete(T model);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public abstract T Delete(int id, T model);

        /// <summary>
        /// Disposing Progress
        /// </summary>
        /// <param name="disposing"></param>
        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DB != null)
                {
                    DB.Dispose();
                    DB = null;
                }
            }
        }

        /// <summary>
        /// Super Dispose :)
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
