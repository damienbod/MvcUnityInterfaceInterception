using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using MvcUnityBootstrapperTest.UnityExtensions;

namespace MvcUnityBootstrapperTest.Business
{
    public interface IBusinessClass : IDisposable
    {
        string Hello();
    }
}
