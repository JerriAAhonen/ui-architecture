using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class TypeHelper
{
	public static Dictionary<Type, Component> GetDerivedTypesAndInstances<T>(GameObject parentObject) where T : Component
	{
		var derivedTypes = AppDomain.CurrentDomain.GetAssemblies()
			.SelectMany(assembly => assembly.GetTypes())
			.Where(type => typeof(T).IsAssignableFrom(type) && !type.IsAbstract)
			.ToArray();

		var instances = new Dictionary<Type, Component>(derivedTypes.Length);

		foreach (var type in derivedTypes)
		{
			var instance = parentObject.GetComponentInChildren(type);
			if (instance != null)
			{
				instances.Add(type, instance);
			}
		}

		return instances;
	}

	public static T GetInstanceOfType<T>(Dictionary<Type, Component> instances) where T : Component
	{
		var type = typeof(T);
		if (instances.TryGetValue(type, out var instance))
		{
			return instance as T;
		}
		return null;
	}
}
