/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:58)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.java.net.http;

[JniSignatureAttribute("Ljava/net/http/HttpResponse;", "public abstract interface")]
public partial interface HttpResponse
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HttpResponse()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/http/HttpResponse;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "version", "()Ljava/net/http/HttpClient$Version;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uri", "()Ljava/net/URI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "statusCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "body", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "request", "()Ljava/net/http/HttpRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "headers", "()Ljava/net/http/HttpHeaders;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "previousResponse", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sslSession", "()Ljava/util/Optional;"));
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpClient$Version;", "public abstract")]
	Dova.JDK.java.net.http.HttpClient.Version version()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Version>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/URI;", "public abstract")]
	Dova.JDK.java.net.URI uri()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int statusCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object body()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpRequest;", "public abstract")]
	Dova.JDK.java.net.http.HttpRequest request()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpHeaders;", "public abstract")]
	Dova.JDK.java.net.http.HttpHeaders headers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpHeaders>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	Dova.JDK.java.util.Optional previousResponse()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	Dova.JDK.java.util.Optional sslSession()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("Ljava/net/http/HttpResponse$BodySubscribers;", "public static")]
	public partial class BodySubscribers
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BodySubscribers()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/http/HttpResponse$BodySubscribers;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mapping", "(Ljava/net/http/HttpResponse$BodySubscriber;Ljava/util/function/Function;)Ljava/net/http/HttpResponse$BodySubscriber;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "replacing", "(Ljava/lang/Object;)Ljava/net/http/HttpResponse$BodySubscriber;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "discarding", "()Ljava/net/http/HttpResponse$BodySubscriber;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromSubscriber", "(Ljava/util/concurrent/Flow$Subscriber;)Ljava/net/http/HttpResponse$BodySubscriber;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromSubscriber", "(Ljava/util/concurrent/Flow$Subscriber;Ljava/util/function/Function;)Ljava/net/http/HttpResponse$BodySubscriber;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromLineSubscriber", "(Ljava/util/concurrent/Flow$Subscriber;Ljava/util/function/Function;Ljava/nio/charset/Charset;Ljava/lang/String;)Ljava/net/http/HttpResponse$BodySubscriber;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromLineSubscriber", "(Ljava/util/concurrent/Flow$Subscriber;)Ljava/net/http/HttpResponse$BodySubscriber;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofString", "(Ljava/nio/charset/Charset;)Ljava/net/http/HttpResponse$BodySubscriber;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofByteArray", "()Ljava/net/http/HttpResponse$BodySubscriber;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofFile", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/net/http/HttpResponse$BodySubscriber;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofFile", "(Ljava/nio/file/Path;)Ljava/net/http/HttpResponse$BodySubscriber;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofByteArrayConsumer", "(Ljava/util/function/Consumer;)Ljava/net/http/HttpResponse$BodySubscriber;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofInputStream", "()Ljava/net/http/HttpResponse$BodySubscriber;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofLines", "(Ljava/nio/charset/Charset;)Ljava/net/http/HttpResponse$BodySubscriber;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofPublisher", "()Ljava/net/http/HttpResponse$BodySubscriber;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "buffering", "(Ljava/net/http/HttpResponse$BodySubscriber;I)Ljava/net/http/HttpResponse$BodySubscriber;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BodySubscribers(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public BodySubscribers() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/net/http/HttpResponse$BodySubscribers;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/net/http/HttpResponse$BodySubscriber;Ljava/util/function/Function;)Ljava/net/http/HttpResponse$BodySubscriber;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber mapping(Dova.JDK.java.net.http.HttpResponse.BodySubscriber arg0, Dova.JDK.java.util.function.Function arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/net/http/HttpResponse$BodySubscriber;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber replacing(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpResponse$BodySubscriber;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber discarding()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscriber;)Ljava/net/http/HttpResponse$BodySubscriber;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber fromSubscriber(Dova.JDK.java.util.concurrent.Flow.Subscriber arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscriber;Ljava/util/function/Function;)Ljava/net/http/HttpResponse$BodySubscriber;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber fromSubscriber(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.function.Function arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscriber;Ljava/util/function/Function;Ljava/nio/charset/Charset;Ljava/lang/String;)Ljava/net/http/HttpResponse$BodySubscriber;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber fromLineSubscriber(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.function.Function arg1, Dova.JDK.java.nio.charset.Charset arg2, Dova.JDK.java.lang.String arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscriber;)Ljava/net/http/HttpResponse$BodySubscriber;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber fromLineSubscriber(Dova.JDK.java.util.concurrent.Flow.Subscriber arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/charset/Charset;)Ljava/net/http/HttpResponse$BodySubscriber;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber ofString(Dova.JDK.java.nio.charset.Charset arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpResponse$BodySubscriber;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber ofByteArray()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/net/http/HttpResponse$BodySubscriber;", "public static transient")]
		public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber ofFile(Dova.JDK.java.nio.file.Path arg0, JavaArray<Dova.JDK.java.nio.file.OpenOption> arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/net/http/HttpResponse$BodySubscriber;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber ofFile(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)Ljava/net/http/HttpResponse$BodySubscriber;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber ofByteArrayConsumer(Dova.JDK.java.util.function.Consumer arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpResponse$BodySubscriber;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber ofInputStream()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/charset/Charset;)Ljava/net/http/HttpResponse$BodySubscriber;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber ofLines(Dova.JDK.java.nio.charset.Charset arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpResponse$BodySubscriber;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber ofPublisher()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/http/HttpResponse$BodySubscriber;I)Ljava/net/http/HttpResponse$BodySubscriber;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodySubscriber buffering(Dova.JDK.java.net.http.HttpResponse.BodySubscriber arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpResponse$BodySubscriber;", "public abstract static interface")]
	public partial interface BodySubscriber
		: IJavaObject
		, Dova.JDK.java.util.concurrent.Flow.Subscriber
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BodySubscriber()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/http/HttpResponse$BodySubscriber;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Ljava/util/concurrent/CompletionStage;"));
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/CompletionStage;", "public abstract")]
		Dova.JDK.java.util.concurrent.CompletionStage getBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionStage>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpResponse$PushPromiseHandler;", "public abstract static interface")]
	public partial interface PushPromiseHandler
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PushPromiseHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/http/HttpResponse$PushPromiseHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/util/function/Function;Ljava/util/concurrent/ConcurrentMap;)Ljava/net/http/HttpResponse$PushPromiseHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyPushPromise", "(Ljava/net/http/HttpRequest;Ljava/net/http/HttpRequest;Ljava/util/function/Function;)V"));
		}

		[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/util/concurrent/ConcurrentMap;)Ljava/net/http/HttpResponse$PushPromiseHandler;", "public static")]
		static Dova.JDK.java.net.http.HttpResponse.PushPromiseHandler of(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.util.concurrent.ConcurrentMap arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.PushPromiseHandler>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/http/HttpRequest;Ljava/net/http/HttpRequest;Ljava/util/function/Function;)V", "public abstract")]
		void applyPushPromise(Dova.JDK.java.net.http.HttpRequest arg0, Dova.JDK.java.net.http.HttpRequest arg1, Dova.JDK.java.util.function.Function arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpResponse$BodyHandlers;", "public static")]
	public partial class BodyHandlers
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BodyHandlers()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/http/HttpResponse$BodyHandlers;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "replacing", "(Ljava/lang/Object;)Ljava/net/http/HttpResponse$BodyHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "discarding", "()Ljava/net/http/HttpResponse$BodyHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromSubscriber", "(Ljava/util/concurrent/Flow$Subscriber;)Ljava/net/http/HttpResponse$BodyHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromSubscriber", "(Ljava/util/concurrent/Flow$Subscriber;Ljava/util/function/Function;)Ljava/net/http/HttpResponse$BodyHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromLineSubscriber", "(Ljava/util/concurrent/Flow$Subscriber;Ljava/util/function/Function;Ljava/lang/String;)Ljava/net/http/HttpResponse$BodyHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromLineSubscriber", "(Ljava/util/concurrent/Flow$Subscriber;)Ljava/net/http/HttpResponse$BodyHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofString", "()Ljava/net/http/HttpResponse$BodyHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofString", "(Ljava/nio/charset/Charset;)Ljava/net/http/HttpResponse$BodyHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofByteArray", "()Ljava/net/http/HttpResponse$BodyHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofFile", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/net/http/HttpResponse$BodyHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofFile", "(Ljava/nio/file/Path;)Ljava/net/http/HttpResponse$BodyHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofByteArrayConsumer", "(Ljava/util/function/Consumer;)Ljava/net/http/HttpResponse$BodyHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofInputStream", "()Ljava/net/http/HttpResponse$BodyHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofLines", "()Ljava/net/http/HttpResponse$BodyHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofPublisher", "()Ljava/net/http/HttpResponse$BodyHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "buffering", "(Ljava/net/http/HttpResponse$BodyHandler;I)Ljava/net/http/HttpResponse$BodyHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofFileDownload", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/net/http/HttpResponse$BodyHandler;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BodyHandlers(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public BodyHandlers() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/net/http/HttpResponse$BodyHandlers;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/net/http/HttpResponse$BodyHandler;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodyHandler replacing(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpResponse$BodyHandler;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodyHandler discarding()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscriber;)Ljava/net/http/HttpResponse$BodyHandler;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodyHandler fromSubscriber(Dova.JDK.java.util.concurrent.Flow.Subscriber arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscriber;Ljava/util/function/Function;)Ljava/net/http/HttpResponse$BodyHandler;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodyHandler fromSubscriber(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.function.Function arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscriber;Ljava/util/function/Function;Ljava/lang/String;)Ljava/net/http/HttpResponse$BodyHandler;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodyHandler fromLineSubscriber(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.function.Function arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Subscriber;)Ljava/net/http/HttpResponse$BodyHandler;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodyHandler fromLineSubscriber(Dova.JDK.java.util.concurrent.Flow.Subscriber arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpResponse$BodyHandler;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodyHandler ofString()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/charset/Charset;)Ljava/net/http/HttpResponse$BodyHandler;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodyHandler ofString(Dova.JDK.java.nio.charset.Charset arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpResponse$BodyHandler;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodyHandler ofByteArray()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/net/http/HttpResponse$BodyHandler;", "public static transient")]
		public static Dova.JDK.java.net.http.HttpResponse.BodyHandler ofFile(Dova.JDK.java.nio.file.Path arg0, JavaArray<Dova.JDK.java.nio.file.OpenOption> arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/net/http/HttpResponse$BodyHandler;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodyHandler ofFile(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)Ljava/net/http/HttpResponse$BodyHandler;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodyHandler ofByteArrayConsumer(Dova.JDK.java.util.function.Consumer arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpResponse$BodyHandler;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodyHandler ofInputStream()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpResponse$BodyHandler;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodyHandler ofLines()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpResponse$BodyHandler;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodyHandler ofPublisher()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/http/HttpResponse$BodyHandler;I)Ljava/net/http/HttpResponse$BodyHandler;", "public static")]
		public static Dova.JDK.java.net.http.HttpResponse.BodyHandler buffering(Dova.JDK.java.net.http.HttpResponse.BodyHandler arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/net/http/HttpResponse$BodyHandler;", "public static transient")]
		public static Dova.JDK.java.net.http.HttpResponse.BodyHandler ofFileDownload(Dova.JDK.java.nio.file.Path arg0, JavaArray<Dova.JDK.java.nio.file.OpenOption> arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpResponse$BodyHandler;", "public abstract static interface")]
	public partial interface BodyHandler
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BodyHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/http/HttpResponse$BodyHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Ljava/net/http/HttpResponse$ResponseInfo;)Ljava/net/http/HttpResponse$BodySubscriber;"));
		}

		[JniSignatureAttribute("(Ljava/net/http/HttpResponse$ResponseInfo;)Ljava/net/http/HttpResponse$BodySubscriber;", "public abstract")]
		Dova.JDK.java.net.http.HttpResponse.BodySubscriber apply(Dova.JDK.java.net.http.HttpResponse.ResponseInfo arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodySubscriber>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpResponse$ResponseInfo;", "public abstract static interface")]
	public partial interface ResponseInfo
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ResponseInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/http/HttpResponse$ResponseInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "version", "()Ljava/net/http/HttpClient$Version;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "statusCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "headers", "()Ljava/net/http/HttpHeaders;"));
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpClient$Version;", "public abstract")]
		Dova.JDK.java.net.http.HttpClient.Version version()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpClient.Version>(ret);
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int statusCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpHeaders;", "public abstract")]
		Dova.JDK.java.net.http.HttpHeaders headers()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpHeaders>(ret);
		}
	}
}
