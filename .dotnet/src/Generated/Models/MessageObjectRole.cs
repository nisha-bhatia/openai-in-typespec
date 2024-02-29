// <auto-generated/>

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> Enum for role in MessageObject. </summary>
    internal readonly partial struct MessageObjectRole : IEquatable<MessageObjectRole>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MessageObjectRole"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MessageObjectRole(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UserValue = "user";
        private const string AssistantValue = "assistant";

        /// <summary> user. </summary>
        public static MessageObjectRole User { get; } = new MessageObjectRole(UserValue);
        /// <summary> assistant. </summary>
        public static MessageObjectRole Assistant { get; } = new MessageObjectRole(AssistantValue);
        /// <summary> Determines if two <see cref="MessageObjectRole"/> values are the same. </summary>
        public static bool operator ==(MessageObjectRole left, MessageObjectRole right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MessageObjectRole"/> values are not the same. </summary>
        public static bool operator !=(MessageObjectRole left, MessageObjectRole right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MessageObjectRole"/>. </summary>
        public static implicit operator MessageObjectRole(string value) => new MessageObjectRole(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MessageObjectRole other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MessageObjectRole other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
