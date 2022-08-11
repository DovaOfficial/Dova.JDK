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

namespace Dova.JDK.sun.net.httpserver.simpleserver;

[JniSignatureAttribute("Lsun/net/httpserver/simpleserver/OutputFilter;", "public final")]
public partial class OutputFilter
	: Dova.JDK.com.sun.net.httpserver.Filter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static OutputFilter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/httpserver/simpleserver/OutputFilter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORMATTER", "Ljava/time/format/DateTimeFormatter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "printStream", "Ljava/io/PrintStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outputLevel", "Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filter", "Lcom/sun/net/httpserver/Filter;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/OutputStream;Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/io/OutputStream;Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;)Lsun/net/httpserver/simpleserver/OutputFilter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "description", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportError", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "logHeaders", "(Ljava/lang/String;Lcom/sun/net/httpserver/Headers;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doFilter", "(Lcom/sun/net/httpserver/HttpExchange;Lcom/sun/net/httpserver/Filter$Chain;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "operation", "()Ljava/util/function/Consumer;"));
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "private static final")]
	public static Dova.JDK.java.time.format.DateTimeFormatter FORMATTER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/PrintStream;", "private final")]
	public Dova.JDK.java.io.PrintStream printStream_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;", "private final")]
	public Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel outputLevel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/net/httpserver/Filter;", "private final")]
	public Dova.JDK.com.sun.net.httpserver.Filter filter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.Filter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public OutputFilter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/io/OutputStream;Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;)V", "private")]
	public OutputFilter(Dova.JDK.java.io.OutputStream arg0, Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/httpserver/simpleserver/OutputFilter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/OutputStream;Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;)Lsun/net/httpserver/simpleserver/OutputFilter;", "public static")]
	public static Dova.JDK.sun.net.httpserver.simpleserver.OutputFilter create(Dova.JDK.java.io.OutputStream arg0, Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.httpserver.simpleserver.OutputFilter>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String description()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public void reportError(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/net/httpserver/Headers;)V", "private")]
	public void logHeaders(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.net.httpserver.Headers arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/net/httpserver/HttpExchange;Lcom/sun/net/httpserver/Filter$Chain;)V", "public")]
	public void doFilter(Dova.JDK.com.sun.net.httpserver.HttpExchange arg0, Dova.JDK.com.sun.net.httpserver.Filter.Chain arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/util/function/Consumer;", "private")]
	public Dova.JDK.java.util.function.Consumer operation()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Consumer>(ret);
	}
}
