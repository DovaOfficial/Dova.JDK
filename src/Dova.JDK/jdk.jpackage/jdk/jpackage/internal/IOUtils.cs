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

namespace Dova.JDK.jdk.jpackage.@internal;

[JniSignatureAttribute("Ljdk/jpackage/internal/IOUtils;", "public")]
public partial class IOUtils
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IOUtils()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jpackage/internal/IOUtils;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "run", "(Ljava/lang/String;Ljava/nio/file/Path;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getParent", "(Ljava/nio/file/Path;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFileName", "(Ljava/nio/file/Path;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "exists", "(Ljava/nio/file/Path;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "exec", "(Ljava/lang/ProcessBuilder;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "exec", "(Ljava/lang/ProcessBuilder;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "exec", "(Ljava/lang/ProcessBuilder;ZLjava/io/PrintStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "exec", "(Ljava/lang/ProcessBuilder;ZLjava/io/PrintStream;ZJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "exec", "(Ljava/lang/ProcessBuilder;ZLjava/io/PrintStream;ZJZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "exec", "(Ljava/lang/ProcessBuilder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPID", "(Ljava/lang/Process;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "deleteRecursive", "(Ljava/nio/file/Path;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyRecursive", "(Ljava/nio/file/Path;Ljava/nio/file/Path;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyRecursive", "(Ljava/nio/file/Path;Ljava/nio/file/Path;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSuffix", "(Ljava/nio/file/Path;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "writableOutputDir", "(Ljava/nio/file/Path;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getProcessOutput", "(Ljava/util/List;[Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addSuffix", "(Ljava/nio/file/Path;Ljava/lang/String;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "replaceSuffix", "(Ljava/nio/file/Path;Ljava/lang/String;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createXml", "(Ljava/nio/file/Path;Ljdk/jpackage/internal/IOUtils$XmlConsumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyFile", "(Ljava/nio/file/Path;Ljava/nio/file/Path;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public IOUtils(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public IOUtils() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jpackage/internal/IOUtils;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/nio/file/Path;)V", "public static")]
	public static void run(Dova.JDK.java.lang.String arg0, Dova.JDK.java.nio.file.Path arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/nio/file/Path;", "public static")]
	public static Dova.JDK.java.nio.file.Path getParent(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/nio/file/Path;", "public static")]
	public static Dova.JDK.java.nio.file.Path getFileName(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "public static")]
	public static bool exists(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/ProcessBuilder;Z)V", "public static")]
	public static void exec(Dova.JDK.java.lang.ProcessBuilder arg0, bool arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/ProcessBuilder;J)V", "public static")]
	public static void exec(Dova.JDK.java.lang.ProcessBuilder arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/ProcessBuilder;ZLjava/io/PrintStream;)V", "static")]
	public static void exec(Dova.JDK.java.lang.ProcessBuilder arg0, bool arg1, Dova.JDK.java.io.PrintStream arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/ProcessBuilder;ZLjava/io/PrintStream;ZJ)V", "static")]
	public static void exec(Dova.JDK.java.lang.ProcessBuilder arg0, bool arg1, Dova.JDK.java.io.PrintStream arg2, bool arg3, long arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/ProcessBuilder;ZLjava/io/PrintStream;ZJZ)V", "static")]
	public static void exec(Dova.JDK.java.lang.ProcessBuilder arg0, bool arg1, Dova.JDK.java.io.PrintStream arg2, bool arg3, long arg4, bool arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/lang/ProcessBuilder;)V", "public static")]
	public static void exec(Dova.JDK.java.lang.ProcessBuilder arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Process;)J", "public static")]
	public static long getPID(Dova.JDK.java.lang.Process arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)V", "public static")]
	public static void deleteRecursive(Dova.JDK.java.nio.file.Path arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/nio/file/Path;)V", "public static")]
	public static void copyRecursive(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.nio.file.Path arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/nio/file/Path;Ljava/util/List;)V", "public static")]
	public static void copyRecursive(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.nio.file.Path arg1, Dova.JDK.java.util.List arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getSuffix(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)V", "static")]
	public static void writableOutputDir(Dova.JDK.java.nio.file.Path arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/List;[Ljava/lang/String;)I", "public static transient")]
	public static int getProcessOutput(Dova.JDK.java.util.List arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/String;)Ljava/nio/file/Path;", "public static")]
	public static Dova.JDK.java.nio.file.Path addSuffix(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/String;)Ljava/nio/file/Path;", "public static")]
	public static Dova.JDK.java.nio.file.Path replaceSuffix(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljdk/jpackage/internal/IOUtils$XmlConsumer;)V", "public static")]
	public static void createXml(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.jdk.jpackage.@internal.IOUtils.XmlConsumer arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/nio/file/Path;)V", "public static")]
	public static void copyFile(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.nio.file.Path arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/IOUtils$PrettyPrintHandler;", "private static")]
	public partial class PrettyPrintHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.reflect.InvocationHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PrettyPrintHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jpackage/internal/IOUtils$PrettyPrintHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Ljavax/xml/stream/XMLStreamWriter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "depth", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasChildElement", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INDENT", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EOL", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/xml/stream/XMLStreamWriter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "repeat", "(ILjava/lang/String;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljavax/xml/stream/XMLStreamWriter;", "private final")]
		public Dova.JDK.javax.xml.stream.XMLStreamWriter target_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLStreamWriter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int depth_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map hasChildElement_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String INDENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String EOL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PrettyPrintHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/xml/stream/XMLStreamWriter;)V", "")]
		public PrettyPrintHandler(Dova.JDK.javax.xml.stream.XMLStreamWriter arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jpackage/internal/IOUtils$PrettyPrintHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object invoke(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.reflect.Method arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(ILjava/lang/String;)Ljava/lang/String;", "private static")]
		public static Dova.JDK.java.lang.String repeat(int arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/IOUtils$XmlConsumer;", "public abstract static interface")]
	public partial interface XmlConsumer
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XmlConsumer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jpackage/internal/IOUtils$XmlConsumer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljavax/xml/stream/XMLStreamWriter;)V"));
		}

		[JniSignatureAttribute("(Ljavax/xml/stream/XMLStreamWriter;)V", "public abstract")]
		void accept(Dova.JDK.javax.xml.stream.XMLStreamWriter arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}
}
