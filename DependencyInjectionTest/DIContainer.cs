using System;
using System.Collections.Generic;

namespace DependencyInjectionTest {
  static class DIContainer {
    private static readonly Dictionary<Type, object[]> _instantiationTypes = new Dictionary<Type, object[]>();

    public static T Instantiate<T> (params object[] values) {
      return (T)Instantiate(typeof(T), values);
    }

    public static object Instantiate (Type type, params object[] values) {

      var constructorParams = new List<object>(values);

      if (values.Length == 0) {
        var constructor = type.GetConstructors()[0];
        foreach (var param in constructor.GetParameters()) {
          var obj = Instantiate(param.ParameterType, _instantiationTypes.GetValueOrDefault(param.ParameterType));
          constructorParams.Add(obj);
        }
      }

      return Activator.CreateInstance(type, constructorParams.ToArray());
    }

    public static void AddInstantiationType(Type type, params object[] values) {
      _instantiationTypes.Add(type, values);
    }
  }
}
