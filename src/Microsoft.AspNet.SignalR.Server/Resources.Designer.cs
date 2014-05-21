﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNet.SignalR
{
    using System;
    using System.Reflection;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNet.SignalR.Server.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to             /// &lt;summary&gt;Calls the {0} method on the server-side {1} hub.&amp;#10;Returns a jQuery.Deferred() promise.&lt;/summary&gt;.
        /// </summary>
        internal static string DynamicComment_CallsMethodOnServerSideDeferredPromise
        {
            get
            {
                return ResourceManager.GetString("DynamicComment_CallsMethodOnServerSideDeferredPromise", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to             /// &lt;param name=\&quot;{0}\&quot; type=\&quot;{1}\&quot;&gt;Server side type is {2}&lt;/param&gt;.
        /// </summary>
        internal static string DynamicComment_ServerSideTypeIs
        {
            get
            {
                return ResourceManager.GetString("DynamicComment_ServerSideTypeIs", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Ambiguous message. Unable to send to both &apos;{0}&apos; and &apos;{1}&apos;..
        /// </summary>
        internal static string Error_AmbiguousMessage
        {
            get
            {
                return ResourceManager.GetString("Error_AmbiguousMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Argument cannot be null or empty.
        /// </summary>
        internal static string Error_ArgumentNullOrEmpty
        {
            get
            {
                return ResourceManager.GetString("Error_ArgumentNullOrEmpty", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The buffer size &apos;{0}&apos; is out of range..
        /// </summary>
        internal static string Error_BufferSizeOutOfRange
        {
            get
            {
                return ResourceManager.GetString("Error_BufferSizeOutOfRange", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Caller is not authorized to invoke the {0} method on {1}..
        /// </summary>
        internal static string Error_CallerNotAuthorizedToInvokeMethodOn
        {
            get
            {
                return ResourceManager.GetString("Error_CallerNotAuthorizedToInvokeMethodOn", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The ConnectionId is in the incorrect format..
        /// </summary>
        internal static string Error_ConnectionIdIncorrectFormat
        {
            get
            {
                return ResourceManager.GetString("Error_ConnectionIdIncorrectFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The PersistentConnection is not initialized..
        /// </summary>
        internal static string Error_ConnectionNotInitialized
        {
            get
            {
                return ResourceManager.GetString("Error_ConnectionNotInitialized", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to DisconnectTimeout cannot be configured after the KeepAlive..
        /// </summary>
        internal static string Error_DisconnectTimeoutCannotBeConfiguredAfterKeepAlive
        {
            get
            {
                return ResourceManager.GetString("Error_DisconnectTimeoutCannotBeConfiguredAfterKeepAlive", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to DisconnectTimeout must be at least six seconds..
        /// </summary>
        internal static string Error_DisconnectTimeoutMustBeAtLeastSixSeconds
        {
            get
            {
                return ResourceManager.GetString("Error_DisconnectTimeoutMustBeAtLeastSixSeconds", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Do not read RequireOutgoing. Use protected _requireOutgoing instead..
        /// </summary>
        internal static string Error_DoNotReadRequireOutgoing
        {
            get
            {
                return ResourceManager.GetString("Error_DoNotReadRequireOutgoing", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Two Hubs must not share the same name. &apos;{0}&apos; and &apos;{1}&apos; both share the name &apos;{2}&apos;..
        /// </summary>
        internal static string Error_DuplicateHubNames
        {
            get
            {
                return ResourceManager.GetString("Error_DuplicateHubNames", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Duplicate Hub names found..
        /// </summary>
        internal static string Error_DuplicateHubNamesInConnectionData
        {
            get
            {
                return ResourceManager.GetString("Error_DuplicateHubNamesInConnectionData", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Duplicate payload id detected for stream &apos;{0}&apos;..
        /// </summary>
        internal static string Error_DuplicatePayloadsForStream
        {
            get
            {
                return ResourceManager.GetString("Error_DuplicatePayloadsForStream", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error creating Hub {0}. .
        /// </summary>
        internal static string Error_ErrorCreatingHub
        {
            get
            {
                return ResourceManager.GetString("Error_ErrorCreatingHub", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The ExceptionContext has already been modified once and cannot be modified again..
        /// </summary>
        internal static string Error_ExceptionContextCanOnlyBeModifiedOnce
        {
            get
            {
                return ResourceManager.GetString("Error_ExceptionContextCanOnlyBeModifiedOnce", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; Hub could not be resolved..
        /// </summary>
        internal static string Error_HubCouldNotBeResolved
        {
            get
            {
                return ResourceManager.GetString("Error_HubCouldNotBeResolved", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to There was an error invoking Hub method &apos;{0}.{1}&apos;..
        /// </summary>
        internal static string Error_HubInvocationFailed
        {
            get
            {
                return ResourceManager.GetString("Error_HubInvocationFailed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to You cannot report progress on a hub method invocation that has already completed..
        /// </summary>
        internal static string Error_HubProgressOnlyReportableBeforeMethodReturns
        {
            get
            {
                return ResourceManager.GetString("Error_HubProgressOnlyReportableBeforeMethodReturns", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid cursor..
        /// </summary>
        internal static string Error_InvalidCursorFormat
        {
            get
            {
                return ResourceManager.GetString("Error_InvalidCursorFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The supplied frameId is in the incorrect format..
        /// </summary>
        internal static string Error_InvalidForeverFrameId
        {
            get
            {
                return ResourceManager.GetString("Error_InvalidForeverFrameId", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a {1}..
        /// </summary>
        internal static string Error_IsNotA
        {
            get
            {
                return ResourceManager.GetString("Error_IsNotA", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to SignalR: JavaScript Hub proxy generation has been disabled..
        /// </summary>
        internal static string Error_JavaScriptProxyDisabled
        {
            get
            {
                return ResourceManager.GetString("Error_JavaScriptProxyDisabled", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to KeepAlive value must be greater than two seconds..
        /// </summary>
        internal static string Error_KeepAliveMustBeGreaterThanTwoSeconds
        {
            get
            {
                return ResourceManager.GetString("Error_KeepAliveMustBeGreaterThanTwoSeconds", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to KeepAlive value must be no more than a third of the DisconnectTimeout..
        /// </summary>
        internal static string Error_KeepAliveMustBeNoMoreThanAThirdOfTheDisconnectTimeout
        {
            get
            {
                return ResourceManager.GetString("Error_KeepAliveMustBeNoMoreThanAThirdOfTheDisconnectTimeout", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; method could not be resolved. No method found with that name..
        /// </summary>
        internal static string Error_MethodCouldNotBeResolved
        {
            get
            {
                return ResourceManager.GetString("Error_MethodCouldNotBeResolved", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; method could not be resolved. Potential candidates are: {1}.
        /// </summary>
        internal static string Error_MethodCouldNotBeResolvedCandidates {
            get {
                return ResourceManager.GetString("Error_MethodCouldNotBeResolvedCandidates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Outgoing authorization can only be required for an entire Hub, not a specific method..
        /// </summary>
        internal static string Error_MethodLevelOutgoingAuthorization
        {
            get
            {
                return ResourceManager.GetString("Error_MethodLevelOutgoingAuthorization", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; parameter of &apos;{1}.{2}&apos; must not be an out parameter..
        /// </summary>
        internal static string Error_MethodMustNotTakeOutParameter
        {
            get
            {
                return ResourceManager.GetString("Error_MethodMustNotTakeOutParameter", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; parameter of &apos;{1}.{2}&apos; must not be a ref parameter..
        /// </summary>
        internal static string Error_MethodMustNotTakeRefParameter
        {
            get
            {
                return ResourceManager.GetString("Error_MethodMustNotTakeRefParameter", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The return type of &apos;{0}.{1}&apos; must be void or Task..
        /// </summary>
        internal static string Error_MethodMustReturnVoidOrTask
        {
            get
            {
                return ResourceManager.GetString("Error_MethodMustReturnVoidOrTask", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Multiple activators for type {0} are registered. Please call GetServices instead..
        /// </summary>
        internal static string Error_MultipleActivatorsAreaRegisteredCallGetServices
        {
            get
            {
                return ResourceManager.GetString("Error_MultipleActivatorsAreaRegisteredCallGetServices", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A configuration object must be specified..
        /// </summary>
        internal static string Error_NoConfiguration
        {
            get
            {
                return ResourceManager.GetString("Error_NoConfiguration", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A dependency resolver must be specified..
        /// </summary>
        internal static string Error_NoDependencyResolver
        {
            get
            {
                return ResourceManager.GetString("Error_NoDependencyResolver", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Not a valid web socket request..
        /// </summary>
        internal static string Error_NotWebSocketRequest
        {
            get
            {
                return ResourceManager.GetString("Error_NotWebSocketRequest", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unexpected end when reading object..
        /// </summary>
        internal static string Error_ParseObjectFailed
        {
            get
            {
                return ResourceManager.GetString("Error_ParseObjectFailed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Protocol error: Missing connection token..
        /// </summary>
        internal static string Error_ProtocolErrorMissingConnectionToken
        {
            get
            {
                return ResourceManager.GetString("Error_ProtocolErrorMissingConnectionToken", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Protocol error: Unknown transport..
        /// </summary>
        internal static string Error_ProtocolErrorUnknownTransport
        {
            get
            {
                return ResourceManager.GetString("Error_ProtocolErrorUnknownTransport", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scaleout queuing is enabled but maximum queue size is 0.
        /// </summary>
        internal static string Error_ScaleoutQueuingConfig {
            get {
                return ResourceManager.GetString("Error_ScaleoutQueuingConfig", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to State has exceeded the maximum length of 4096 bytes..
        /// </summary>
        internal static string Error_StateExceededMaximumLength
        {
            get
            {
                return ResourceManager.GetString("Error_StateExceededMaximumLength", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The stream has been closed..
        /// </summary>
        internal static string Error_StreamClosed
        {
            get
            {
                return ResourceManager.GetString("Error_StreamClosed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The stream is not open..
        /// </summary>
        internal static string Error_StreamNotOpen
        {
            get
            {
                return ResourceManager.GetString("Error_StreamNotOpen", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The queue is full..
        /// </summary>
        internal static string Error_TaskQueueFull
        {
            get
            {
                return ResourceManager.GetString("Error_TaskQueueFull", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The type T, &apos;{0}&apos;, passed to Hub&lt;T&gt; must be an interface..
        /// </summary>
        internal static string Error_TypeMustBeInterface
        {
            get
            {
                return ResourceManager.GetString("Error_TypeMustBeInterface", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The interface &apos;{0}&apos; must not contain any events..
        /// </summary>
        internal static string Error_TypeMustNotContainEvents
        {
            get
            {
                return ResourceManager.GetString("Error_TypeMustNotContainEvents", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The interface &apos;{0}&apos; must not contain any properties..
        /// </summary>
        internal static string Error_TypeMustNotContainProperties
        {
            get
            {
                return ResourceManager.GetString("Error_TypeMustNotContainProperties", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unable to add module. The HubPipeline has already been invoked..
        /// </summary>
        internal static string Error_UnableToAddModulePiplineAlreadyInvoked
        {
            get
            {
                return ResourceManager.GetString("Error_UnableToAddModulePiplineAlreadyInvoked", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unrecognized user identity.  The user identity cannot change during an active SignalR connection..
        /// </summary>
        internal static string Error_UnrecognizedUserIdentity
        {
            get
            {
                return ResourceManager.GetString("Error_UnrecognizedUserIdentity", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Using a Hub instance not created by the HubPipeline is unsupported..
        /// </summary>
        internal static string Error_UsingHubInstanceNotCreatedUnsupported
        {
            get
            {
                return ResourceManager.GetString("Error_UsingHubInstanceNotCreatedUnsupported", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to WebSockets is not supported..
        /// </summary>
        internal static string Error_WebSocketsNotSupported
        {
            get
            {
                return ResourceManager.GetString("Error_WebSocketsNotSupported", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Forbidden: JSONP is disabled..
        /// </summary>
        internal static string Forbidden_JSONPDisabled
        {
            get
            {
                return ResourceManager.GetString("Forbidden_JSONPDisabled", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to None of the classes from assembly &quot;{0}&quot; could be loaded when searching for Hubs. [{1}]
        ///
        ///Original exception type: {2}
        ///Original exception message: {3}
        ///
        ///.
        /// </summary>
        internal static string Warning_AssemblyGetTypesException
        {
            get
            {
                return ResourceManager.GetString("Warning_AssemblyGetTypesException", resourceCulture);
            }
        }
    }
}
