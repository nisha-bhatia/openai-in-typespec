// <auto-generated/>

using System;
using OpenAI.ClientShared.Internal;
using System.Collections.Generic;

namespace OpenAI.Internal.Models
{
    /// <summary> The FineTuningJobEvent. </summary>
    internal partial class FineTuningJobEvent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FineTuningJobEvent"/>. </summary>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="createdAt"></param>
        /// <param name="level"></param>
        /// <param name="message"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="object"/> or <paramref name="message"/> is null. </exception>
        internal FineTuningJobEvent(string id, string @object, DateTimeOffset createdAt, FineTuningJobEventLevel level, string message)
        {
            if (id is null) throw new ArgumentNullException(nameof(id));
            if (@object is null) throw new ArgumentNullException(nameof(@object));
            if (message is null) throw new ArgumentNullException(nameof(message));

            Id = id;
            Object = @object;
            CreatedAt = createdAt;
            Level = level;
            Message = message;
        }

        /// <summary> Initializes a new instance of <see cref="FineTuningJobEvent"/>. </summary>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="createdAt"></param>
        /// <param name="level"></param>
        /// <param name="message"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FineTuningJobEvent(string id, string @object, DateTimeOffset createdAt, FineTuningJobEventLevel level, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            CreatedAt = createdAt;
            Level = level;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FineTuningJobEvent"/> for deserialization. </summary>
        internal FineTuningJobEvent()
        {
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
        /// <summary> Gets the object. </summary>
        public string Object { get; }
        /// <summary> Gets the created at. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> Gets the level. </summary>
        public FineTuningJobEventLevel Level { get; }
        /// <summary> Gets the message. </summary>
        public string Message { get; }
    }
}
