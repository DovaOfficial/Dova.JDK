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

[JniSignatureAttribute("Ljava/net/http/HttpRequest;", "public abstract")]
public partial class HttpRequest
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HttpRequest()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/http/HttpRequest;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "method", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "version", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uri", "()Ljava/net/URI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "timeout", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newBuilder", "()Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newBuilder", "(Ljava/net/http/HttpRequest;Ljava/util/function/BiPredicate;)Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newBuilder", "(Ljava/net/URI;)Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expectContinue", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bodyPublisher", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "headers", "()Ljava/net/http/HttpHeaders;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HttpRequest(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public HttpRequest() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/net/http/HttpRequest;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public final")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String method()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	public Dova.JDK.java.util.Optional version()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/net/URI;", "public abstract")]
	public Dova.JDK.java.net.URI uri()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	public Dova.JDK.java.util.Optional timeout()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpRequest$Builder;", "public static")]
	public static Dova.JDK.java.net.http.HttpRequest.Builder newBuilder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpRequest;Ljava/util/function/BiPredicate;)Ljava/net/http/HttpRequest$Builder;", "public static")]
	public static Dova.JDK.java.net.http.HttpRequest.Builder newBuilder(Dova.JDK.java.net.http.HttpRequest arg0, Dova.JDK.java.util.function.BiPredicate arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URI;)Ljava/net/http/HttpRequest$Builder;", "public static")]
	public static Dova.JDK.java.net.http.HttpRequest.Builder newBuilder(Dova.JDK.java.net.URI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool expectContinue()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	public Dova.JDK.java.util.Optional bodyPublisher()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpHeaders;", "public abstract")]
	public Dova.JDK.java.net.http.HttpHeaders headers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpHeaders>(ret);
	}

	[JniSignatureAttribute("Ljava/net/http/HttpRequest$Builder;", "public abstract static interface")]
	public partial interface Builder
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Builder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/http/HttpRequest$Builder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "method", "(Ljava/lang/String;Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "version", "(Ljava/net/http/HttpClient$Version;)Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uri", "(Ljava/net/URI;)Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "()Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "GET", "()Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "timeout", "(Ljava/time/Duration;)Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()Ljava/net/http/HttpRequest;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "DELETE", "()Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "header", "(Ljava/lang/String;Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "HEAD", "()Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "POST", "(Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "PUT", "(Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expectContinue", "(Z)Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "headers", "([Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;"));
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder method(Dova.JDK.java.lang.String arg0, Dova.JDK.java.net.http.HttpRequest.BodyPublisher arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/http/HttpClient$Version;)Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder version(Dova.JDK.java.net.http.HttpClient.Version arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/URI;)Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder uri(Dova.JDK.java.net.URI arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder copy()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder GET()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/Duration;)Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder timeout(Dova.JDK.java.time.Duration arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpRequest;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest build()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder DELETE()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder header(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpRequest$Builder;", "public")]
		Dova.JDK.java.net.http.HttpRequest.Builder HEAD()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder POST(Dova.JDK.java.net.http.HttpRequest.BodyPublisher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder PUT(Dova.JDK.java.net.http.HttpRequest.BodyPublisher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("(Z)Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder expectContinue(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder setHeader(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;", "public abstract transient")]
		Dova.JDK.java.net.http.HttpRequest.Builder headers(JavaArray<Dova.JDK.java.lang.String> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpRequest$BodyPublishers;", "public static")]
	public partial class BodyPublishers
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BodyPublishers()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/http/HttpRequest$BodyPublishers;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "concat", "([Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "noBody", "()Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofInputStream", "(Ljava/util/function/Supplier;)Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofByteArray", "([B)Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofByteArray", "([BII)Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofFile", "(Ljava/nio/file/Path;)Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofByteArrays", "(Ljava/lang/Iterable;)Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromPublisher", "(Ljava/util/concurrent/Flow$Publisher;J)Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromPublisher", "(Ljava/util/concurrent/Flow$Publisher;)Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofString", "(Ljava/lang/String;)Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofString", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/net/http/HttpRequest$BodyPublisher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BodyPublishers(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public BodyPublishers() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/net/http/HttpRequest$BodyPublishers;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$BodyPublisher;", "public static transient")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher concat(JavaArray<Dova.JDK.java.net.http.HttpRequest.BodyPublisher> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher noBody()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Supplier;)Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher ofInputStream(Dova.JDK.java.util.function.Supplier arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("([B)Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher ofByteArray(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("([BII)Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher ofByteArray(JavaArray<byte> arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher ofFile(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher ofByteArrays(Dova.JDK.java.lang.Iterable arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Publisher;J)Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher fromPublisher(Dova.JDK.java.util.concurrent.Flow.Publisher arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Publisher;)Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher fromPublisher(Dova.JDK.java.util.concurrent.Flow.Publisher arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher ofString(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher ofString(Dova.JDK.java.lang.String arg0, Dova.JDK.java.nio.charset.Charset arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpRequest$BodyPublisher;", "public abstract static interface")]
	public partial interface BodyPublisher
		: IJavaObject
		, Dova.JDK.java.util.concurrent.Flow.Publisher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BodyPublisher()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/http/HttpRequest$BodyPublisher;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contentLength", "()J"));
		}

		[JniSignatureAttribute("()J", "public abstract")]
		long contentLength()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}
	}
}
