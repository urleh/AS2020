using DronTaxi.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronTaxi.Services.Abstract
{
    public abstract class AbstractService
    {
        protected IConnectionFactory Factory;
        protected IDbConnection Connection;

        public AbstractService(IConnectionFactory factory)
        {
            Factory = factory;
            Connection = Factory.GetConnection();
        }
    }
}
