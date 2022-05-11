// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace Microsoft.Toolkit.Uwp.Notifications
{
    internal sealed class Element_ToastVisual : IHaveXmlName, IHaveXmlNamedProperties
    {
        internal const bool DEFAULT_ADD_IMAGE_QUERY = false;

        [NotificationXmlAttribute("addImageQuery")]
        public bool? AddImageQuery { get; set; }

        [NotificationXmlAttribute("baseUri")]
        public Uri BaseUri { get; set; }

        [NotificationXmlAttribute("lang")]
        public string Language { get; set; }

        [NotificationXmlAttribute("version")]
        public int? Version { get; set; }

        public IList<Element_ToastBinding> Bindings { get; private set; } = new List<Element_ToastBinding>();

        /// <inheritdoc/>
        string IHaveXmlName.Name => "visual";

        /// <inheritdoc/>
        IEnumerable<KeyValuePair<string, object>> IHaveXmlNamedProperties.EnumerateNamedProperties()
        {
            yield return new("addImageQuery", AddImageQuery);
            yield return new("baseUri", BaseUri);
            yield return new("lang", Language);
            yield return new("version", Version);
        }
    }
}