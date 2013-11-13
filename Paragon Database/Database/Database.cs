using System.Data.Linq.Mapping;
using Paragon_Database.Settings;

namespace Paragon_Database.Database
{
    partial class ParagonDataContext
    {
        public ParagonDataContext()
            : base(ApplicationSettings.ConnectionString, mappingSource)
        {
            OnCreated();
        }
        partial void OnCreated()
        {
            //Put your desired timeout here.
            this.CommandTimeout = 1000;
        }
    }
}
