using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class ClientFactory
    {
        public Client GetClient(string name)
        {
            switch (name)
            {
                case "Credit":
                    return new RetiredClient("none","none",new Guid());
                case "StudentClient":
                    return new StudentClient("none", "none", new Guid());
                case "UsualClient":
                    return new UsualClient("none", "none", new Guid());
                case "VIPClient":
                    return new VIPClient("none", "none", new Guid());
                default:
                    return null;
            }
        }
    }
}
