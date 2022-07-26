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

namespace Dova.JDK.jdk.@internal.net.http;

[JniSignatureAttribute("Ljdk/internal/net/http/PushGroup;", "")]
public partial class PushGroup
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PushGroup()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/PushGroup;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initiatingRequest", "Ljava/net/http/HttpRequest;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "noMorePushesCF", "Ljava/util/concurrent/CompletableFuture;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "error", "Ljava/lang/Throwable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pushPromiseHandler", "Ljava/net/http/HttpResponse$PushPromiseHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "executor", "Ljava/util/concurrent/Executor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numberOfPushes", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "remainingPushes", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "noMorePushes", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/http/HttpResponse$PushPromiseHandler;Ljdk/internal/net/http/HttpRequestImpl;Ljava/util/concurrent/Executor;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/http/HttpResponse$PushPromiseHandler;Ljdk/internal/net/http/HttpRequestImpl;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/Executor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkIfCompleted", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pushesCF", "()Ljava/util/concurrent/CompletableFuture;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "noMorePushes", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "noMorePushes", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pushError", "(Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptPushRequest", "(Ljava/net/http/HttpRequest;)Ljdk/internal/net/http/PushGroup$Acceptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pushCompleted", "()V"));
	}

	[JniSignatureAttribute("Ljava/net/http/HttpRequest;", "private final")]
	public Dova.JDK.java.net.http.HttpRequest initiatingRequest_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpRequest>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "final")]
	public Dova.JDK.java.util.concurrent.CompletableFuture noMorePushesCF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Throwable;", "volatile")]
	public Dova.JDK.java.lang.Throwable error_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Throwable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpResponse$PushPromiseHandler;", "final")]
	public Dova.JDK.java.net.http.HttpResponse.PushPromiseHandler pushPromiseHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.PushPromiseHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/Executor;", "private final")]
	public Dova.JDK.java.util.concurrent.Executor executor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int numberOfPushes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int remainingPushes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool noMorePushes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PushGroup(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpResponse$PushPromiseHandler;Ljdk/internal/net/http/HttpRequestImpl;Ljava/util/concurrent/Executor;)V", "")]
	public PushGroup(Dova.JDK.java.net.http.HttpResponse.PushPromiseHandler arg0, Dova.JDK.jdk.@internal.net.http.HttpRequestImpl arg1, Dova.JDK.java.util.concurrent.Executor arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpResponse$PushPromiseHandler;Ljdk/internal/net/http/HttpRequestImpl;Ljava/util/concurrent/CompletableFuture;Ljava/util/concurrent/Executor;)V", "private")]
	public PushGroup(Dova.JDK.java.net.http.HttpResponse.PushPromiseHandler arg0, Dova.JDK.jdk.@internal.net.http.HttpRequestImpl arg1, Dova.JDK.java.util.concurrent.CompletableFuture arg2, Dova.JDK.java.util.concurrent.Executor arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/PushGroup;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "synchronized")]
	public void checkIfCompleted()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture;", "synchronized")]
	public Dova.JDK.java.util.concurrent.CompletableFuture pushesCF()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
	}

	[JniSignatureAttribute("(Z)V", "synchronized")]
	public void noMorePushes(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Z", "synchronized")]
	public bool noMorePushes()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "synchronized")]
	public void pushError(Dova.JDK.java.lang.Throwable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpRequest;)Ljdk/internal/net/http/PushGroup$Acceptor;", "")]
	public Dova.JDK.jdk.@internal.net.http.PushGroup.Acceptor acceptPushRequest(Dova.JDK.java.net.http.HttpRequest arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.PushGroup.Acceptor>(ret);
	}

	[JniSignatureAttribute("()V", "synchronized")]
	public void pushCompleted()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/PushGroup$AcceptorImpl;", "private static")]
	public partial class AcceptorImpl
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.net.http.PushGroup.Acceptor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AcceptorImpl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/PushGroup$AcceptorImpl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "executor", "Ljava/util/concurrent/Executor;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bodyHandler", "Ljava/net/http/HttpResponse$BodyHandler;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cf", "Ljava/util/concurrent/CompletableFuture;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/net/http/HttpResponse$BodyHandler;)Ljava/util/concurrent/CompletableFuture;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cf", "()Ljava/util/concurrent/CompletableFuture;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accepted", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bodyHandler", "()Ljava/net/http/HttpResponse$BodyHandler;"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/Executor;", "private final")]
		public Dova.JDK.java.util.concurrent.Executor executor_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/net/http/HttpResponse$BodyHandler;", "private volatile")]
		public Dova.JDK.java.net.http.HttpResponse.BodyHandler bodyHandler_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "private volatile")]
		public Dova.JDK.java.util.concurrent.CompletableFuture cf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AcceptorImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Executor;)V", "")]
		public AcceptorImpl(Dova.JDK.java.util.concurrent.Executor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/net/http/PushGroup$AcceptorImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/net/http/HttpResponse$BodyHandler;)Ljava/util/concurrent/CompletableFuture;", "")]
		public Dova.JDK.java.util.concurrent.CompletableFuture accept(Dova.JDK.java.net.http.HttpResponse.BodyHandler arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture;", "public")]
		public Dova.JDK.java.util.concurrent.CompletableFuture cf()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool accepted()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpResponse$BodyHandler;", "public")]
		public Dova.JDK.java.net.http.HttpResponse.BodyHandler bodyHandler()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/PushGroup$Acceptor;", "abstract static interface")]
	public partial interface Acceptor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Acceptor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/PushGroup$Acceptor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cf", "()Ljava/util/concurrent/CompletableFuture;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accepted", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bodyHandler", "()Ljava/net/http/HttpResponse$BodyHandler;"));
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/CompletableFuture;", "public abstract")]
		Dova.JDK.java.util.concurrent.CompletableFuture cf()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool accepted()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/net/http/HttpResponse$BodyHandler;", "public abstract")]
		Dova.JDK.java.net.http.HttpResponse.BodyHandler bodyHandler()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpResponse.BodyHandler>(ret);
		}
	}
}
