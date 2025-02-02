// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> The RunStepDetailsToolCallsFunctionObject_type. </summary>
    internal readonly partial struct RunStepDetailsToolCallsFunctionObjectType : IEquatable<RunStepDetailsToolCallsFunctionObjectType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RunStepDetailsToolCallsFunctionObjectType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RunStepDetailsToolCallsFunctionObjectType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FunctionValue = "function";

        /// <summary> function. </summary>
        public static RunStepDetailsToolCallsFunctionObjectType Function { get; } = new RunStepDetailsToolCallsFunctionObjectType(FunctionValue);
        /// <summary> Determines if two <see cref="RunStepDetailsToolCallsFunctionObjectType"/> values are the same. </summary>
        public static bool operator ==(RunStepDetailsToolCallsFunctionObjectType left, RunStepDetailsToolCallsFunctionObjectType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RunStepDetailsToolCallsFunctionObjectType"/> values are not the same. </summary>
        public static bool operator !=(RunStepDetailsToolCallsFunctionObjectType left, RunStepDetailsToolCallsFunctionObjectType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RunStepDetailsToolCallsFunctionObjectType"/>. </summary>
        public static implicit operator RunStepDetailsToolCallsFunctionObjectType(string value) => new RunStepDetailsToolCallsFunctionObjectType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RunStepDetailsToolCallsFunctionObjectType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RunStepDetailsToolCallsFunctionObjectType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
