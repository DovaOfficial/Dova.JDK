/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.net.httpserver;

[JniSignatureAttribute("Lcom/sun/net/httpserver/Filter;", "public abstract")]
public partial class Filter
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Filter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/net/httpserver/Filter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Filter", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "description", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "beforeHandler", "(Ljava/lang/String;Ljava/util/function/Consumer;)Lcom/sun/net/httpserver/Filter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "afterHandler", "(Ljava/lang/String;Ljava/util/function/Consumer;)Lcom/sun/net/httpserver/Filter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "adaptRequest", "(Ljava/lang/String;Ljava/util/function/UnaryOperator;)Lcom/sun/net/httpserver/Filter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "doFilter", "(Lcom/sun/net/httpserver/HttpExchange;Lcom/sun/net/httpserver/Filter$Chain;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Filter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public Filter() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/net/httpserver/Filter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String description()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/function/Consumer;)Lcom/sun/net/httpserver/Filter;", "public static")]
	public static Dova.JDK.com.sun.net.httpserver.Filter beforeHandler(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.function.Consumer arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.Filter>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/function/Consumer;)Lcom/sun/net/httpserver/Filter;", "public static")]
	public static Dova.JDK.com.sun.net.httpserver.Filter afterHandler(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.function.Consumer arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.Filter>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/function/UnaryOperator;)Lcom/sun/net/httpserver/Filter;", "public static")]
	public static Dova.JDK.com.sun.net.httpserver.Filter adaptRequest(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.function.UnaryOperator arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.Filter>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/net/httpserver/HttpExchange;Lcom/sun/net/httpserver/Filter$Chain;)V", "public abstract")]
	public void doFilter(Dova.JDK.com.sun.net.httpserver.HttpExchange arg0, Dova.JDK.com.sun.net.httpserver.Filter.Chain arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("Lcom/sun/net/httpserver/Filter$Chain;", "public static")]
	public partial class Chain
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Chain()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/net/httpserver/Filter$Chain;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "iter", "Ljava/util/ListIterator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "handler", "Lcom/sun/net/httpserver/HttpHandler;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Chain", "(Ljava/util/List;Lcom/sun/net/httpserver/HttpHandler;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "doFilter", "(Lcom/sun/net/httpserver/HttpExchange;)V"));
		}

		[JniSignatureAttribute("Ljava/util/ListIterator;", "private")]
		public Dova.JDK.java.util.ListIterator iter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ListIterator>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/net/httpserver/HttpHandler;", "private")]
		public Dova.JDK.com.sun.net.httpserver.HttpHandler handler_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpHandler>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Chain(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;Lcom/sun/net/httpserver/HttpHandler;)V", "public")]
		public Chain(Dova.JDK.java.util.List arg0, Dova.JDK.com.sun.net.httpserver.HttpHandler arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/net/httpserver/Filter$Chain;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/net/httpserver/HttpExchange;)V", "public")]
		public void doFilter(Dova.JDK.com.sun.net.httpserver.HttpExchange arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}
}
