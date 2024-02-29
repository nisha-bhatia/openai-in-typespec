// <auto-generated/>

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenAI.Internal.Models;

namespace OpenAI.Internal
{
    // Data plane generated sub-client.
    /// <summary> The Threads sub-client. </summary>
    internal partial class Threads
    {
        private const string AuthorizationHeader = "Authorization";
        private readonly ApiKeyCredential _credential;
        private const string AuthorizationApiKeyPrefix = "Bearer";
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Threads for mocking. </summary>
        protected Threads()
        {
        }

        /// <summary> Initializes a new instance of Threads. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="credential"> The key credential to copy. </param>
        /// <param name="endpoint"> OpenAI Endpoint. </param>
        internal Threads(ClientPipeline pipeline, ApiKeyCredential credential, Uri endpoint)
        {
            _pipeline = pipeline;
            _credential = credential;
            _endpoint = endpoint;
        }

        /// <summary> Create a thread. </summary>
        /// <param name="thread"> The <see cref="CreateThreadRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="thread"/> is null. </exception>
        public virtual async Task<ClientResult<ThreadObject>> CreateThreadAsync(CreateThreadRequest thread)
        {
            if (thread is null) throw new ArgumentNullException(nameof(thread));

            using BinaryContent content = BinaryContent.Create(thread);
            ClientResult result = await CreateThreadAsync(content, DefaultRequestContext).ConfigureAwait(false);
            return ClientResult.FromValue(ThreadObject.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Create a thread. </summary>
        /// <param name="thread"> The <see cref="CreateThreadRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="thread"/> is null. </exception>
        public virtual ClientResult<ThreadObject> CreateThread(CreateThreadRequest thread)
        {
            if (thread is null) throw new ArgumentNullException(nameof(thread));

            using BinaryContent content = BinaryContent.Create(thread);
            ClientResult result = CreateThread(content, DefaultRequestContext);
            return ClientResult.FromValue(ThreadObject.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Create a thread.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateThreadAsync(CreateThreadRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> CreateThreadAsync(BinaryContent content, RequestOptions options = null)
        {
            if (content is null) throw new ArgumentNullException(nameof(content));
            options ??= new RequestOptions();
            using PipelineMessage message = CreateCreateThreadRequest(content, options);
            await _pipeline.SendAsync(message).ConfigureAwait(false);
            PipelineResponse response = message.Response!;

            if (response.IsError && options.ErrorOptions == ClientErrorBehaviors.Default)
            {
                throw await ClientResultException.CreateAsync(response).ConfigureAwait(false);
            }

            return ClientResult.FromResponse(response);
        }

        /// <summary>
        /// [Protocol Method] Create a thread.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateThread(CreateThreadRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult CreateThread(BinaryContent content, RequestOptions options = null)
        {
            if (content is null) throw new ArgumentNullException(nameof(content));
            options ??= new RequestOptions();
            using PipelineMessage message = CreateCreateThreadRequest(content, options);
            _pipeline.Send(message);
            PipelineResponse response = message.Response!;

            if (response.IsError && options.ErrorOptions == ClientErrorBehaviors.Default)
            {
                throw new ClientResultException(response);
            }

            return ClientResult.FromResponse(response);
        }

        /// <summary> Retrieves a thread. </summary>
        /// <param name="threadId"> The ID of the thread to retrieve. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="threadId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="threadId"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual async Task<ClientResult<ThreadObject>> GetThreadAsync(string threadId)
        {
            if (threadId is null) throw new ArgumentNullException(nameof(threadId));
            if (string.IsNullOrEmpty(threadId)) throw new ArgumentException(nameof(threadId));

            ClientResult result = await GetThreadAsync(threadId, DefaultRequestContext).ConfigureAwait(false);
            return ClientResult.FromValue(ThreadObject.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Retrieves a thread. </summary>
        /// <param name="threadId"> The ID of the thread to retrieve. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="threadId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="threadId"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual ClientResult<ThreadObject> GetThread(string threadId)
        {
            if (threadId is null) throw new ArgumentNullException(nameof(threadId));
            if (string.IsNullOrEmpty(threadId)) throw new ArgumentException(nameof(threadId));

            ClientResult result = GetThread(threadId, DefaultRequestContext);
            return ClientResult.FromValue(ThreadObject.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Retrieves a thread.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetThreadAsync(string)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="threadId"> The ID of the thread to retrieve. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="threadId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="threadId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> GetThreadAsync(string threadId, RequestOptions options)
        {
            if (threadId is null) throw new ArgumentNullException(nameof(threadId));
            if (string.IsNullOrEmpty(threadId)) throw new ArgumentException(nameof(threadId));
            options ??= new RequestOptions();
            using PipelineMessage message = CreateGetThreadRequest(threadId, options);
            await _pipeline.SendAsync(message).ConfigureAwait(false);
            PipelineResponse response = message.Response!;

            if (response.IsError && options.ErrorOptions == ClientErrorBehaviors.Default)
            {
                throw await ClientResultException.CreateAsync(response).ConfigureAwait(false);
            }

            return ClientResult.FromResponse(response);
        }

        /// <summary>
        /// [Protocol Method] Retrieves a thread.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetThread(string)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="threadId"> The ID of the thread to retrieve. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="threadId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="threadId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult GetThread(string threadId, RequestOptions options)
        {
            if (threadId is null) throw new ArgumentNullException(nameof(threadId));
            if (string.IsNullOrEmpty(threadId)) throw new ArgumentException(nameof(threadId));
            options ??= new RequestOptions();
            using PipelineMessage message = CreateGetThreadRequest(threadId, options);
            _pipeline.Send(message);
            PipelineResponse response = message.Response!;

            if (response.IsError && options.ErrorOptions == ClientErrorBehaviors.Default)
            {
                throw new ClientResultException(response);
            }

            return ClientResult.FromResponse(response);
        }

        /// <summary> Modifies a thread. </summary>
        /// <param name="threadId"> The ID of the thread to modify. Only the `metadata` can be modified. </param>
        /// <param name="thread"> The <see cref="ModifyThreadRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="threadId"/> or <paramref name="thread"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="threadId"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual async Task<ClientResult<ThreadObject>> ModifyThreadAsync(string threadId, ModifyThreadRequest thread)
        {
            if (threadId is null) throw new ArgumentNullException(nameof(threadId));
            if (string.IsNullOrEmpty(threadId)) throw new ArgumentException(nameof(threadId));
            if (thread is null) throw new ArgumentNullException(nameof(thread));

            using BinaryContent content = BinaryContent.Create(thread);
            ClientResult result = await ModifyThreadAsync(threadId, content, DefaultRequestContext).ConfigureAwait(false);
            return ClientResult.FromValue(ThreadObject.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Modifies a thread. </summary>
        /// <param name="threadId"> The ID of the thread to modify. Only the `metadata` can be modified. </param>
        /// <param name="thread"> The <see cref="ModifyThreadRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="threadId"/> or <paramref name="thread"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="threadId"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual ClientResult<ThreadObject> ModifyThread(string threadId, ModifyThreadRequest thread)
        {
            if (threadId is null) throw new ArgumentNullException(nameof(threadId));
            if (string.IsNullOrEmpty(threadId)) throw new ArgumentException(nameof(threadId));
            if (thread is null) throw new ArgumentNullException(nameof(thread));

            using BinaryContent content = BinaryContent.Create(thread);
            ClientResult result = ModifyThread(threadId, content, DefaultRequestContext);
            return ClientResult.FromValue(ThreadObject.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Modifies a thread.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="ModifyThreadAsync(string,ModifyThreadRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="threadId"> The ID of the thread to modify. Only the `metadata` can be modified. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="threadId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="threadId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> ModifyThreadAsync(string threadId, BinaryContent content, RequestOptions options = null)
        {
            if (threadId is null) throw new ArgumentNullException(nameof(threadId));
            if (string.IsNullOrEmpty(threadId)) throw new ArgumentException(nameof(threadId));
            if (content is null) throw new ArgumentNullException(nameof(content));
            options ??= new RequestOptions();
            using PipelineMessage message = CreateModifyThreadRequest(threadId, content, options);
            await _pipeline.SendAsync(message).ConfigureAwait(false);
            PipelineResponse response = message.Response!;

            if (response.IsError && options.ErrorOptions == ClientErrorBehaviors.Default)
            {
                throw await ClientResultException.CreateAsync(response).ConfigureAwait(false);
            }

            return ClientResult.FromResponse(response);
        }

        /// <summary>
        /// [Protocol Method] Modifies a thread.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="ModifyThread(string,ModifyThreadRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="threadId"> The ID of the thread to modify. Only the `metadata` can be modified. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="threadId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="threadId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult ModifyThread(string threadId, BinaryContent content, RequestOptions options = null)
        {
            if (threadId is null) throw new ArgumentNullException(nameof(threadId));
            if (string.IsNullOrEmpty(threadId)) throw new ArgumentException(nameof(threadId));
            if (content is null) throw new ArgumentNullException(nameof(content));
            options ??= new RequestOptions();
            using PipelineMessage message = CreateModifyThreadRequest(threadId, content, options);
            _pipeline.Send(message);
            PipelineResponse response = message.Response!;

            if (response.IsError && options.ErrorOptions == ClientErrorBehaviors.Default)
            {
                throw new ClientResultException(response);
            }

            return ClientResult.FromResponse(response);
        }

        /// <summary> Delete a thread. </summary>
        /// <param name="threadId"> The ID of the thread to delete. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="threadId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="threadId"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual async Task<ClientResult<DeleteThreadResponse>> DeleteThreadAsync(string threadId)
        {
            if (threadId is null) throw new ArgumentNullException(nameof(threadId));
            if (string.IsNullOrEmpty(threadId)) throw new ArgumentException(nameof(threadId));

            ClientResult result = await DeleteThreadAsync(threadId, DefaultRequestContext).ConfigureAwait(false);
            return ClientResult.FromValue(DeleteThreadResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Delete a thread. </summary>
        /// <param name="threadId"> The ID of the thread to delete. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="threadId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="threadId"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual ClientResult<DeleteThreadResponse> DeleteThread(string threadId)
        {
            if (threadId is null) throw new ArgumentNullException(nameof(threadId));
            if (string.IsNullOrEmpty(threadId)) throw new ArgumentException(nameof(threadId));

            ClientResult result = DeleteThread(threadId, DefaultRequestContext);
            return ClientResult.FromValue(DeleteThreadResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Delete a thread.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="DeleteThreadAsync(string)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="threadId"> The ID of the thread to delete. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="threadId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="threadId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> DeleteThreadAsync(string threadId, RequestOptions options)
        {
            if (threadId is null) throw new ArgumentNullException(nameof(threadId));
            if (string.IsNullOrEmpty(threadId)) throw new ArgumentException(nameof(threadId));
            options ??= new RequestOptions();
            using PipelineMessage message = CreateDeleteThreadRequest(threadId, options);
            await _pipeline.SendAsync(message).ConfigureAwait(false);
            PipelineResponse response = message.Response!;

            if (response.IsError && options.ErrorOptions == ClientErrorBehaviors.Default)
            {
                throw await ClientResultException.CreateAsync(response).ConfigureAwait(false);
            }

            return ClientResult.FromResponse(response);
        }

        /// <summary>
        /// [Protocol Method] Delete a thread.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="DeleteThread(string)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="threadId"> The ID of the thread to delete. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="threadId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="threadId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult DeleteThread(string threadId, RequestOptions options)
        {
            if (threadId is null) throw new ArgumentNullException(nameof(threadId));
            if (string.IsNullOrEmpty(threadId)) throw new ArgumentException(nameof(threadId));
            options ??= new RequestOptions();
            using PipelineMessage message = CreateDeleteThreadRequest(threadId, options);
            _pipeline.Send(message);
            PipelineResponse response = message.Response!;

            if (response.IsError && options.ErrorOptions == ClientErrorBehaviors.Default)
            {
                throw new ClientResultException(response);
            }

            return ClientResult.FromResponse(response);
        }

        internal PipelineMessage CreateCreateThreadRequest(BinaryContent content, RequestOptions options)
        {
            PipelineMessage message = _pipeline.CreateMessage();
            message.ResponseClassifier = ResponseErrorClassifier200;
            PipelineRequest request = message.Request;
            request.Method = "POST";
            UriBuilder uriBuilder = new(_endpoint.ToString());
            StringBuilder path = new();
            path.Append("/threads");
            uriBuilder.Path += path.ToString();
            request.Uri = uriBuilder.Uri;
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("Content-Type", "application/json");
            request.Content = content;
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateGetThreadRequest(string threadId, RequestOptions options)
        {
            PipelineMessage message = _pipeline.CreateMessage();
            message.ResponseClassifier = ResponseErrorClassifier200;
            PipelineRequest request = message.Request;
            request.Method = "GET";
            UriBuilder uriBuilder = new(_endpoint.ToString());
            StringBuilder path = new();
            path.Append("/threads/");
            path.Append(threadId);
            uriBuilder.Path += path.ToString();
            request.Uri = uriBuilder.Uri;
            request.Headers.Set("Accept", "application/json");
            return message;
        }

        internal PipelineMessage CreateModifyThreadRequest(string threadId, BinaryContent content, RequestOptions options)
        {
            PipelineMessage message = _pipeline.CreateMessage();
            message.ResponseClassifier = ResponseErrorClassifier200;
            PipelineRequest request = message.Request;
            request.Method = "POST";
            UriBuilder uriBuilder = new(_endpoint.ToString());
            StringBuilder path = new();
            path.Append("/threads/");
            path.Append(threadId);
            uriBuilder.Path += path.ToString();
            request.Uri = uriBuilder.Uri;
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("Content-Type", "application/json");
            request.Content = content;
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateDeleteThreadRequest(string threadId, RequestOptions options)
        {
            PipelineMessage message = _pipeline.CreateMessage();
            message.ResponseClassifier = ResponseErrorClassifier200;
            PipelineRequest request = message.Request;
            request.Method = "DELETE";
            UriBuilder uriBuilder = new(_endpoint.ToString());
            StringBuilder path = new();
            path.Append("/threads/");
            path.Append(threadId);
            uriBuilder.Path += path.ToString();
            request.Uri = uriBuilder.Uri;
            request.Headers.Set("Accept", "application/json");
            return message;
        }

        private static RequestOptions DefaultRequestContext = new RequestOptions();

        private static PipelineMessageClassifier _responseErrorClassifier200;
        private static PipelineMessageClassifier ResponseErrorClassifier200 => _responseErrorClassifier200 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 200 });
    }
}
