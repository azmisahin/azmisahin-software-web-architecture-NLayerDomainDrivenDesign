using com.domain.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.domain.Data.Manager
{
    /// <summary>
    /// Manage Shared Base
    /// </summary>
    public partial class Manage
    {
        private static volatile SetupManager SetupInstance;
        public static IManage<Setup> Setup
        {
            get { if (SetupInstance == null) SetupInstance = new SetupManager(); return SetupInstance; }
        }
    }

    /// <summary>
    /// Setup Manager
    /// </summary>
    public class SetupManager : IManage<Setup>
    {
        public override Setup Delete(Setup model)
        {
            throw new NotImplementedException();
        }

        public override Setup Delete(int id)
        {
            var query = Get(id: id);
            DB.Setup.Remove(query);
            DB.SaveChanges();
            return query;
        }

        public override Setup Delete(int id, Setup model)
        {
            throw new NotImplementedException();
        }

        public override Setup Get()
        {
            throw new NotImplementedException();
        }

        public override Setup Get(Setup model)
        {
            throw new NotImplementedException();
        }

        public override Setup Get(int id)
        {
            var query = (from item in DB.Setup
                         where item.Id == id
                         select item).FirstOrDefault();
            return query;
        }

        public override Setup Get(int id, Setup model)
        {
            throw new NotImplementedException();
        }

        public override List<Setup> List()
        {
            var query = DB
                .Setup
                .ToList();
            return query;
        }

        public override List<Setup> List(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Setup> List(int id, Setup model)
        {
            throw new NotImplementedException();
        }

        public override Setup Post(Setup model)
        {
            throw new NotImplementedException();
        }

        public override Setup Post(int id, Setup model)
        {
            var query = model;
            DB.Setup.AddOrUpdate<Setup>(model);
            DB.SaveChanges();
            return query;
        }

        public override Setup Put(Setup model)
        {
            var query = model;
            DB.Setup.AddOrUpdate<Setup>(model);
            DB.SaveChanges();
            return query;
        }

        public override Setup Put(int id)
        {
            throw new NotImplementedException();
        }
    }
}
