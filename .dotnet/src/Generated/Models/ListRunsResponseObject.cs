// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> The ListRunsResponse_object. </summary>
    internal readonly partial struct ListRunsResponseObject : IEquatable<ListRunsResponseObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ListRunsResponseObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ListRunsResponseObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ListValue = "list";

        /// <summary> list. </summary>
        public static ListRunsResponseObject List { get; } = new ListRunsResponseObject(ListValue);
        /// <summary> Determines if two <see cref="ListRunsResponseObject"/> values are the same. </summary>
        public static bool operator ==(ListRunsResponseObject left, ListRunsResponseObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ListRunsResponseObject"/> values are not the same. </summary>
        public static bool operator !=(ListRunsResponseObject left, ListRunsResponseObject right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ListRunsResponseObject"/>. </summary>
        public static implicit operator ListRunsResponseObject(string value) => new ListRunsResponseObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ListRunsResponseObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ListRunsResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
