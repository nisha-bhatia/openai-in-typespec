// <auto-generated/>

using System;
using OpenAI.ClientShared.Internal;
using System.Collections.Generic;

namespace OpenAI.Internal.Models
{
    /// <summary> The ChatCompletionResponseMessage. </summary>
    internal partial class ChatCompletionResponseMessage
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

        /// <summary> Initializes a new instance of <see cref="ChatCompletionResponseMessage"/>. </summary>
        /// <param name="content"> The contents of the message. </param>
        internal ChatCompletionResponseMessage(string content)
        {
            Content = content;
            ToolCalls = new OptionalList<ChatCompletionMessageToolCall>();
        }

        /// <summary> Initializes a new instance of <see cref="ChatCompletionResponseMessage"/>. </summary>
        /// <param name="content"> The contents of the message. </param>
        /// <param name="toolCalls"></param>
        /// <param name="role"> The role of the author of this message. </param>
        /// <param name="functionCall"> Deprecated and replaced by `tool_calls`. The name and arguments of a function that should be called, as generated by the model. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatCompletionResponseMessage(string content, IReadOnlyList<ChatCompletionMessageToolCall> toolCalls, ChatCompletionResponseMessageRole role, ChatCompletionResponseMessageFunctionCall functionCall, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Content = content;
            ToolCalls = toolCalls;
            Role = role;
            FunctionCall = functionCall;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ChatCompletionResponseMessage"/> for deserialization. </summary>
        internal ChatCompletionResponseMessage()
        {
        }

        /// <summary> The contents of the message. </summary>
        public string Content { get; }
        /// <summary> Gets the tool calls. </summary>
        public IReadOnlyList<ChatCompletionMessageToolCall> ToolCalls { get; }
        /// <summary> The role of the author of this message. </summary>
        public ChatCompletionResponseMessageRole Role { get; } = ChatCompletionResponseMessageRole.Assistant;

        /// <summary> Deprecated and replaced by `tool_calls`. The name and arguments of a function that should be called, as generated by the model. </summary>
        public ChatCompletionResponseMessageFunctionCall FunctionCall { get; }
    }
}
