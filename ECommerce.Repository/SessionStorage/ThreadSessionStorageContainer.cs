using System.Collections;
using NHibernate;

namespace ECommerce.Repository.SessionStorage
{
    public class ThreadSessionStorageContainer : ISessionStorageContainer
    {
        private static readonly Hashtable Sessions = new Hashtable();

        public ISession GetCurrentSession()
        {
            ISession nhSession = null;

            if (Sessions.Contains(GetThreadName()))
                nhSession = (ISession)Sessions[GetThreadName()];

            return nhSession;
        }

        public void Store(ISession session)
        {
            if (Sessions.Contains(GetThreadName()))
                Sessions[GetThreadName()] = session;
            else
                Sessions.Add(GetThreadName(), session);
        }

        private static string GetThreadName()
        {
            return "";
        }
    }

}
