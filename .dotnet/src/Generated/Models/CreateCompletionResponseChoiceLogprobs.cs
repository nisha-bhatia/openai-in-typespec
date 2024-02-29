// <auto-generated/>

using System;
using OpenAI.ClientShared.Internal;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Internal.Models
{
    /// <summary> The CreateCompletionResponseChoiceLogprobs. </summary>
    internal partial class CreateCompletionResponseChoiceLogprobs
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

        /// <summary> Initializes a new instance of <see cref="CreateCompletionResponseChoiceLogprobs"/>. </summary>
        /// <param name="tokens"></param>
        /// <param name="tokenLogprobs"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="textOffset"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="tokens"/>, <paramref name="tokenLogprobs"/>, <paramref name="topLogprobs"/> or <paramref name="textOffset"/> is null. </exception>
        internal CreateCompletionResponseChoiceLogprobs(IEnumerable<string> tokens, IEnumerable<double> tokenLogprobs, IEnumerable<IDictionary<string, long>> topLogprobs, IEnumerable<long> textOffset)
        {
            if (tokens is null) throw new ArgumentNullException(nameof(tokens));
            if (tokenLogprobs is null) throw new ArgumentNullException(nameof(tokenLogprobs));
            if (topLogprobs is null) throw new ArgumentNullException(nameof(topLogprobs));
            if (textOffset is null) throw new ArgumentNullException(nameof(textOffset));

            Tokens = tokens.ToList();
            TokenLogprobs = tokenLogprobs.ToList();
            TopLogprobs = topLogprobs.ToList();
            TextOffset = textOffset.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CreateCompletionResponseChoiceLogprobs"/>. </summary>
        /// <param name="tokens"></param>
        /// <param name="tokenLogprobs"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="textOffset"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateCompletionResponseChoiceLogprobs(IReadOnlyList<string> tokens, IReadOnlyList<double> tokenLogprobs, IReadOnlyList<IDictionary<string, long>> topLogprobs, IReadOnlyList<long> textOffset, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tokens = tokens;
            TokenLogprobs = tokenLogprobs;
            TopLogprobs = topLogprobs;
            TextOffset = textOffset;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateCompletionResponseChoiceLogprobs"/> for deserialization. </summary>
        internal CreateCompletionResponseChoiceLogprobs()
        {
        }

        /// <summary> Gets the tokens. </summary>
        public IReadOnlyList<string> Tokens { get; }
        /// <summary> Gets the token logprobs. </summary>
        public IReadOnlyList<double> TokenLogprobs { get; }
        /// <summary> Gets the top logprobs. </summary>
        public IReadOnlyList<IDictionary<string, long>> TopLogprobs { get; }
        /// <summary> Gets the text offset. </summary>
        public IReadOnlyList<long> TextOffset { get; }
    }
}
