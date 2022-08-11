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

namespace Dova.JDK.com.sun.net.httpserver;

[JniSignatureAttribute("Lcom/sun/net/httpserver/SimpleFileServer;", "public final")]
public partial class SimpleFileServer
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SimpleFileServer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/net/httpserver/SimpleFileServer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MIME_TABLE", "Ljava/util/function/UnaryOperator;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createFileServer", "(Ljava/net/InetSocketAddress;Ljava/nio/file/Path;Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;)Lcom/sun/net/httpserver/HttpServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createFileHandler", "(Ljava/nio/file/Path;)Lcom/sun/net/httpserver/HttpHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createOutputFilter", "(Ljava/io/OutputStream;Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;)Lcom/sun/net/httpserver/Filter;"));
	}

	[JniSignatureAttribute("Ljava/util/function/UnaryOperator;", "private static final")]
	public static Dova.JDK.java.util.function.UnaryOperator MIME_TABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.UnaryOperator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SimpleFileServer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public SimpleFileServer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/net/httpserver/SimpleFileServer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;Ljava/nio/file/Path;Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;)Lcom/sun/net/httpserver/HttpServer;", "public static")]
	public static Dova.JDK.com.sun.net.httpserver.HttpServer createFileServer(Dova.JDK.java.net.InetSocketAddress arg0, Dova.JDK.java.nio.file.Path arg1, Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpServer>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/net/httpserver/HttpHandler;", "public static")]
	public static Dova.JDK.com.sun.net.httpserver.HttpHandler createFileHandler(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpHandler>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/OutputStream;Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;)Lcom/sun/net/httpserver/Filter;", "public static")]
	public static Dova.JDK.com.sun.net.httpserver.Filter createOutputFilter(Dova.JDK.java.io.OutputStream arg0, Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.Filter>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;", "public static final")]
	public partial class OutputLevel
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OutputLevel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NONE", "Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INFO", "Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VERBOSE", "Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;"));
		}

		[JniSignatureAttribute("Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;", "public static final")]
		public static Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel NONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;", "public static final")]
		public static Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel INFO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;", "public static final")]
		public static Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel VERBOSE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OutputLevel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public OutputLevel(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;", "public static")]
		public static Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/net/httpserver/SimpleFileServer$OutputLevel;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.net.httpserver.SimpleFileServer.OutputLevel>>(ret);
		}
	}
}
