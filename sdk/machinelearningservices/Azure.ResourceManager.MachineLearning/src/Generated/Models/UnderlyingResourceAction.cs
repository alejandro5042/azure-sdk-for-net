// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnderlyingResourceAction. </summary>
    public readonly partial struct UnderlyingResourceAction : IEquatable<UnderlyingResourceAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UnderlyingResourceAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UnderlyingResourceAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeleteValue = "Delete";
        private const string DetachValue = "Detach";

        /// <summary> Delete. </summary>
        public static UnderlyingResourceAction Delete { get; } = new UnderlyingResourceAction(DeleteValue);
        /// <summary> Detach. </summary>
        public static UnderlyingResourceAction Detach { get; } = new UnderlyingResourceAction(DetachValue);
        /// <summary> Determines if two <see cref="UnderlyingResourceAction"/> values are the same. </summary>
        public static bool operator ==(UnderlyingResourceAction left, UnderlyingResourceAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UnderlyingResourceAction"/> values are not the same. </summary>
        public static bool operator !=(UnderlyingResourceAction left, UnderlyingResourceAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UnderlyingResourceAction"/>. </summary>
        public static implicit operator UnderlyingResourceAction(string value) => new UnderlyingResourceAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UnderlyingResourceAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UnderlyingResourceAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
