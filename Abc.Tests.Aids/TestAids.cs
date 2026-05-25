using System.Reflection;
using Microsoft.Testing.Platform.Extensions.Messages;
using Newtonsoft.Json.Bson;

namespace Abc.Tests.Aids
{
    public abstract class TestAids<TClass> where TClass : class, new()
        {
            protected TClass obj;
            protected const BindingFlags publicDeclared = BindingFlags.Public
                           | BindingFlags.DeclaredOnly
                           | BindingFlags.Instance
                           | BindingFlags.Static;


            protected static IEnumerable<string> GetProperties()
                => Abc.Aids.GetType.PropertyNames<TClass>(publicDeclared);


            protected static IEnumerable<string> GetMethods()
                => Abc.Aids.GetType.MethodNames<TClass>(publicDeclared, false);

            protected void IsProperty<T>(string name) {
                var p = typeof(TClass).GetProperty(name);
                Assert.IsNotNull(p, NoProperty(name));
                Assert.AreEqual(typeof(T), p.PropertyType, WrongType<T>(name,p));
            
            }

        private string WrongType<T>(string name, PropertyInfo p)
            => $"Property '{name}' in class '{typeof(TClass).Name}' is of "
               + $"type '{p.PropertyType.Name}', expected '{typeof(T).Name}'.";
        

        private string NoProperty(string name)
            => $"Property '{name}' not found in class '{typeof(TClass).Name}'.";
        
    }
    
}
