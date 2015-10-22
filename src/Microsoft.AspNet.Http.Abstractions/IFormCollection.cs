// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.Extensions.Primitives;

namespace Microsoft.AspNet.Http
{
    /// <summary>
    /// Represents the parsed form values sent with the HttpRequest.
    /// </summary>
    public interface IFormCollection : IEnumerable<KeyValuePair<string, StringValues>>
    {
        /// <summary>
        ///     Gets the number of elements contained in the <see cref="T:Microsoft.AspNet.Http.IFormCollection" />.
        /// </summary>
        /// <returns>
        ///     The number of elements contained in the <see cref="T:Microsoft.AspNet.Http.IFormCollection" />.
        /// </returns>
        int Count { get; }
        
        /// <summary>
        ///     Gets an <see cref="T:System.Collections.Generic.ICollection`1" /> containing the keys of the 
        ///     <see cref="T:Microsoft.AspNet.Http.IFormCollection" />.
        /// </summary>
        /// <returns>
        ///     An <see cref="T:System.Collections.Generic.ICollection`1" /> containing the keys of the object
        ///     that implements <see cref="T:Microsoft.AspNet.Http.IFormCollection" />.
        /// </returns>
        ICollection<string> Keys { get; }

        /// <summary>
        ///     Determines whether the <see cref="T:Microsoft.AspNet.Http.IFormCollection" /> contains an element
        ///     with the specified key.
        /// </summary>
        /// <param name="key">
        /// The key to locate in the <see cref="T:Microsoft.AspNet.Http.IFormCollection" />.
        /// </param>
        /// <returns>
        ///     true if the <see cref="T:Microsoft.AspNet.Http.IFormCollection" /> contains an element with
        ///     the key; otherwise, false.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///     key is null.
        /// </exception>
        bool ContainsKey(string key);

        /// <summary>
        ///    Gets the value associated with the specified key.
        /// </summary>
        /// <param name="key">
        ///     The key of the value to get.
        /// </param>
        /// <param name="value">
        ///     The key of the value to get.
        ///     When this method returns, the value associated with the specified key, if the
        ///     key is found; otherwise, the default value for the type of the value parameter.
        ///     This parameter is passed uninitialized.
        /// </param>
        /// <returns>
        ///    true if the object that implements <see cref="T:Microsoft.AspNet.Http.IFormCollection" /> contains
        ///     an element with the specified key; otherwise, false.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///     key is null.
        /// </exception>
        bool TryGetValue(string key, out StringValues value);

        /// <summary>
        ///     Gets the value with the specified key.
        /// </summary>
        /// <param name="key">
        ///     The key of the value to get.
        /// </param>
        /// <returns>
        ///     The element with the specified key, or <see cref="T:Microsoft.Extensions.Primitives.StringValues" />.Empty if the key is not present.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///     key is null.
        /// </exception>
        /// <remarks>
        ///     <see cref="T:Microsoft.AspNet.Http.IFormCollection" /> has a different indexer contract than 
        ///     <see cref="T:System.Collections.Generic.IDictionary`2" />, as it will return StringValues.Empty for missing entries
        ///     rather than throwing an Exception.
        /// </remarks>
        StringValues this[string key] { get; }

        /// <summary>
        /// The file collection sent with the request.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>The files included with the request.</returns>
        IFormFileCollection Files { get; }
    }
}
