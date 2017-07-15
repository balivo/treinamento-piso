using System;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GestaoComercial.Web.Conventions
{
    class DateTime2Convention : Convention
    {
        public DateTime2Convention()
        {
            Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
        }
    }
}