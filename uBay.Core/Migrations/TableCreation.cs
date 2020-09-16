using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uBay.Core.Models;
using Umbraco.Core.Migrations;

namespace uBay.Core.Migrations
{
    public class TableCreation : MigrationBase
    {
        public TableCreation(IMigrationContext context)
        : base(context)
        { }

        public override void Migrate()
        {
            if (!TableExists("bids"))
                Create.Table<Bid>().Do();

        }
    }
}
