// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The ScopeProperties. </summary>
    public partial class ScopeProperties
    {
        /// <summary> Initializes a new instance of ScopeProperties. </summary>
        internal ScopeProperties()
        {
        }

        /// <summary> Initializes a new instance of ScopeProperties. </summary>
        /// <param name="scope"></param>
        /// <param name="valid"></param>
        internal ScopeProperties(string scope, bool? valid)
        {
            Scope = scope;
            Valid = valid;
        }

        /// <summary> Gets the scope. </summary>
        public string Scope { get; }
        /// <summary> Gets the valid. </summary>
        public bool? Valid { get; }
    }
}
