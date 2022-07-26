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

namespace Dova.JDK.jdk.javadoc.@internal.tool;

[JniSignatureAttribute("Ljdk/javadoc/internal/tool/JavadocTool;", "public")]
public partial class JavadocTool
	: Dova.JDK.com.sun.tools.javac.main.JavaCompiler
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavadocTool()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/tool/JavadocTool;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toolEnv", "Ljdk/javadoc/internal/tool/ToolEnvironment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "log", "Ljdk/javadoc/internal/tool/JavadocLog;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "javadocFinder", "Lcom/sun/tools/javac/code/ClassFinder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dcfh", "Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "javadocEnter", "Lcom/sun/tools/javac/comp/Enter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "uniquefiles", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "surrogatesSupported", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/lang/Iterable;Lcom/sun/tools/javac/util/ListBuffer;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRegularFile", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isValidClassName", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "keepComments", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValidPackageName", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listClasses", "(Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValidPackageName0", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "surrogatesSupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "make0", "(Lcom/sun/tools/javac/util/Context;)Ljdk/javadoc/internal/tool/JavadocTool;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnvironment", "(Ljdk/javadoc/internal/tool/ToolOptions;Ljava/util/List;Ljava/lang/Iterable;)Ljdk/javadoc/doclet/DocletEnvironment;"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/tool/ToolEnvironment;", "")]
	public Dova.JDK.jdk.javadoc.@internal.tool.ToolEnvironment toolEnv_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.tool.ToolEnvironment>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/tool/JavadocLog;", "final")]
	public Dova.JDK.jdk.javadoc.@internal.tool.JavadocLog log_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.tool.JavadocLog>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/ClassFinder;", "final")]
	public Dova.JDK.com.sun.tools.javac.code.ClassFinder javadocFinder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.ClassFinder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler;", "final")]
	public Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler dcfh_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Enter;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.Enter javadocEnter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Enter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "final")]
	public Dova.JDK.java.util.Set uniquefiles_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool surrogatesSupported_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JavadocTool(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "protected")]
	public JavadocTool(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/tool/JavadocTool;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Iterable;Lcom/sun/tools/javac/util/ListBuffer;Z)V", "private")]
	public void parse(Dova.JDK.java.lang.Iterable arg0, Dova.JDK.com.sun.tools.javac.util.ListBuffer arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool isRegularFile(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public static")]
	public static bool isValidClassName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool keepComments()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "")]
	public bool isValidPackageName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/List;", "")]
	public Dova.JDK.java.util.List listClasses(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool isValidPackageName0(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private static")]
	public static bool surrogatesSupported()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Ljdk/javadoc/internal/tool/JavadocTool;", "public static")]
	public static Dova.JDK.jdk.javadoc.@internal.tool.JavadocTool make0(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.tool.JavadocTool>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/tool/ToolOptions;Ljava/util/List;Ljava/lang/Iterable;)Ljdk/javadoc/doclet/DocletEnvironment;", "public")]
	public Dova.JDK.jdk.javadoc.doclet.DocletEnvironment getEnvironment(Dova.JDK.jdk.javadoc.@internal.tool.ToolOptions arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.Iterable arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment>(ret);
	}
}
