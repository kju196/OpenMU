﻿// <copyright file="ObjectExtensions.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.AdminPanelBlazor
{
    using System;
    using System.Collections.Concurrent;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Extensions for objects.
    /// </summary>
    internal static class ObjectExtensions
    {
        private static readonly ConcurrentDictionary<Type, PropertyInfo> IdProperties = new ConcurrentDictionary<Type, PropertyInfo>();

        /// <summary>
        /// Gets the guid identifier of an object, which has the name "Id".
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The guid identifier of an object, which has the name "Id".</returns>
        public static Guid GetId(this object item)
        {
            if (!IdProperties.TryGetValue(item.GetType(), out var idProperty))
            {
                idProperty = item.GetType().GetProperties().FirstOrDefault(p => p.Name.Equals("Id") && p.PropertyType == typeof(Guid));
                IdProperties.TryAdd(item.GetType(), idProperty);
            }

            if (idProperty == null)
            {
                return Guid.Empty;
            }

            return (Guid)idProperty.GetValue(item);
        }
    }
}