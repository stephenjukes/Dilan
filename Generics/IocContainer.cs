using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class IocContainer
    {
        private readonly Dictionary<Type, Type> registrations = new Dictionary<Type, Type>();

        public void Register<Abstract, Concrete>() where Concrete : Abstract
        {
            registrations.Add(typeof(Abstract), typeof(Concrete));
        }

        public void Resolve(Type type)
        {
            var resolvedType = registrations[type];
            var constructor = resolvedType.GetConstructors()[0];
            var parameters = constructor.GetParameters();

            //return parameters.Any()
            //    ? constructor.Invoke(parameters.Select<Type, object>(p => Resolve(p.ParameterType)).ToList())
            //    : Activator.CreateInstance(resolvedType);
            
        }
    }
}
