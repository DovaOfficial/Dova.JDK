/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

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
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/net/http/HttpRequest;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "HttpRequest", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "method", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "version", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "uri", "()Ljava/net/URI;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "timeout", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "newBuilder", "()Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "newBuilder", "(Ljava/net/http/HttpRequest;Ljava/util/function/BiPredicate;)Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "newBuilder", "(Ljava/net/URI;)Ljava/net/http/HttpRequest$Builder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "expectContinue", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "bodyPublisher", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "headers", "()Ljava/net/http/HttpHeaders;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HttpRequest(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public HttpRequest() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/net/http/HttpRequest;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public final")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String method()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	public Dova.JDK.java.util.Optional version()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int hashCode()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/net/URI;", "public abstract")]
	public Dova.JDK.java.net.URI uri()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	public Dova.JDK.java.util.Optional timeout()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpRequest$Builder;", "public static")]
	public static Dova.JDK.java.net.http.HttpRequest.Builder newBuilder()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpRequest;Ljava/util/function/BiPredicate;)Ljava/net/http/HttpRequest$Builder;", "public static")]
	public static Dova.JDK.java.net.http.HttpRequest.Builder newBuilder(Dova.JDK.java.net.http.HttpRequest arg0, Dova.JDK.java.util.function.BiPredicate arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URI;)Ljava/net/http/HttpRequest$Builder;", "public static")]
	public static Dova.JDK.java.net.http.HttpRequest.Builder newBuilder(Dova.JDK.java.net.URI arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool expectContinue()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public abstract")]
	public Dova.JDK.java.util.Optional bodyPublisher()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpHeaders;", "public abstract")]
	public Dova.JDK.java.net.http.HttpHeaders headers()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/net/http/HttpRequest$Builder;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "method", "(Ljava/lang/String;Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "version", "(Ljava/net/http/HttpClient$Version;)Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "uri", "(Ljava/net/URI;)Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "copy", "()Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "GET", "()Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "timeout", "(Ljava/time/Duration;)Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "build", "()Ljava/net/http/HttpRequest;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DELETE", "()Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "header", "(Ljava/lang/String;Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "HEAD", "()Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "POST", "(Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PUT", "(Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "expectContinue", "(Z)Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "headers", "([Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;"));
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder method(Dova.JDK.java.lang.String arg0, Dova.JDK.java.net.http.HttpRequest.BodyPublisher arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/http/HttpClient$Version;)Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder version(Dova.JDK.java.net.http.HttpClient.Version arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/URI;)Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder uri(Dova.JDK.java.net.URI arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder copy()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder GET()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/Duration;)Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder timeout(Dova.JDK.java.time.Duration arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpRequest;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest build()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder DELETE()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder header(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpRequest$Builder;", "public")]
		Dova.JDK.java.net.http.HttpRequest.Builder HEAD()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder POST(Dova.JDK.java.net.http.HttpRequest.BodyPublisher arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder PUT(Dova.JDK.java.net.http.HttpRequest.BodyPublisher arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("(Z)Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder expectContinue(bool arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;", "public abstract")]
		Dova.JDK.java.net.http.HttpRequest.Builder setHeader(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.Builder>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;", "public abstract transient")]
		Dova.JDK.java.net.http.HttpRequest.Builder headers(JavaArray<Dova.JDK.java.lang.String> arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/net/http/HttpRequest$BodyPublishers;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "BodyPublishers", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "concat", "([Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "noBody", "()Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "ofInputStream", "(Ljava/util/function/Supplier;)Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "ofByteArray", "([B)Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "ofByteArray", "([BII)Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "ofFile", "(Ljava/nio/file/Path;)Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "ofByteArrays", "(Ljava/lang/Iterable;)Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "fromPublisher", "(Ljava/util/concurrent/Flow$Publisher;J)Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "fromPublisher", "(Ljava/util/concurrent/Flow$Publisher;)Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "ofString", "(Ljava/lang/String;)Ljava/net/http/HttpRequest$BodyPublisher;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "ofString", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/net/http/HttpRequest$BodyPublisher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BodyPublishers(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public BodyPublishers() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/net/http/HttpRequest$BodyPublishers;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$BodyPublisher;", "public static transient")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher concat(JavaArray<Dova.JDK.java.net.http.HttpRequest.BodyPublisher> arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher noBody()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Supplier;)Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher ofInputStream(Dova.JDK.java.util.function.Supplier arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("([B)Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher ofByteArray(JavaArray<byte> arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("([BII)Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher ofByteArray(JavaArray<byte> arg0, int arg1, int arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher ofFile(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher ofByteArrays(Dova.JDK.java.lang.Iterable arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Publisher;J)Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher fromPublisher(Dova.JDK.java.util.concurrent.Flow.Publisher arg0, long arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Flow$Publisher;)Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher fromPublisher(Dova.JDK.java.util.concurrent.Flow.Publisher arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher ofString(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest.BodyPublisher>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/net/http/HttpRequest$BodyPublisher;", "public static")]
		public static Dova.JDK.java.net.http.HttpRequest.BodyPublisher ofString(Dova.JDK.java.lang.String arg0, Dova.JDK.java.nio.charset.Charset arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
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
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/net/http/HttpRequest$BodyPublisher;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "contentLength", "()J"));
		}

		[JniSignatureAttribute("()J", "public abstract")]
		long contentLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}
	}
}
