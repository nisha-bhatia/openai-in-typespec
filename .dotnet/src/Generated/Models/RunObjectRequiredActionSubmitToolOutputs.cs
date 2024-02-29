// <auto-generated/>

using System;
using OpenAI.ClientShared.Internal;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Internal.Models
{
    /// <summary> The RunObjectRequiredActionSubmitToolOutputs. </summary>
    internal partial class RunObjectRequiredActionSubmitToolOutputs
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

        /// <summary> Initializes a new instance of <see cref="RunObjectRequiredActionSubmitToolOutputs"/>. </summary>
        /// <param name="toolCalls"> A list of the relevant tool calls. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="toolCalls"/> is null. </exception>
        internal RunObjectRequiredActionSubmitToolOutputs(IEnumerable<RunToolCallObject> toolCalls)
        {
            if (toolCalls is null) throw new ArgumentNullException(nameof(toolCalls));

            ToolCalls = toolCalls.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="RunObjectRequiredActionSubmitToolOutputs"/>. </summary>
        /// <param name="toolCalls"> A list of the relevant tool calls. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RunObjectRequiredActionSubmitToolOutputs(IReadOnlyList<RunToolCallObject> toolCalls, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ToolCalls = toolCalls;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RunObjectRequiredActionSubmitToolOutputs"/> for deserialization. </summary>
        internal RunObjectRequiredActionSubmitToolOutputs()
        {
        }

        /// <summary> A list of the relevant tool calls. </summary>
        public IReadOnlyList<RunToolCallObject> ToolCalls { get; }
    }
}
