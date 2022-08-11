/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.tools.javac.api;

[JniSignatureAttribute("Lcom/sun/tools/javac/api/BasicJavacTask;", "public")]
public partial class BasicJavacTask
	: Dova.JDK.com.sun.source.util.JavacTask
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BasicJavacTask()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/api/BasicJavacTask;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "context", "Lcom/sun/tools/javac/util/Context;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "options", "Lcom/sun/tools/javac/util/Options;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "taskListener", "Lcom/sun/source/util/TaskListener;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Context;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContext", "()Lcom/sun/tools/javac/util/Context;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/source/util/JavacTask;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "()Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addModules", "(Ljava/lang/Iterable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generate", "()Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocale", "(Ljava/util/Locale;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "call_0", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "call_1", "()Ljava/lang/Boolean;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypes", "()Ljavax/lang/model/util/Types;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setProcessors", "(Ljava/lang/Iterable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initDocLint", "(Lcom/sun/tools/javac/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initPlugin", "(Lcom/sun/source/util/Plugin;[Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initPlugins", "(Ljava/util/Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTaskListeners", "()Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTaskListener", "(Lcom/sun/source/util/TaskListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeTaskListener", "(Lcom/sun/source/util/TaskListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setParameterNameProvider", "(Lcom/sun/source/util/ParameterNameProvider;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeMirror", "(Ljava/lang/Iterable;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElements", "()Ljavax/lang/model/util/Elements;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyze", "()Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTaskListener", "(Lcom/sun/source/util/TaskListener;)V"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Context;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.Context context_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Context>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Options;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.Options options_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Options>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/source/util/TaskListener;", "private")]
	public Dova.JDK.com.sun.source.util.TaskListener taskListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TaskListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BasicJavacTask(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;Z)V", "public")]
	public BasicJavacTask(Dova.JDK.com.sun.tools.javac.util.Context arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/api/BasicJavacTask;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Context;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.Context getContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Context>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/source/util/JavacTask;", "public static")]
	public static Dova.JDK.com.sun.source.util.JavacTask instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.JavacTask>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Iterable;", "public")]
	public Dova.JDK.java.lang.Iterable parse()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)V", "public")]
	public void addModules(Dova.JDK.java.lang.Iterable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/Iterable;", "public")]
	public Dova.JDK.java.lang.Iterable generate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)V", "public")]
	public void setLocale(Dova.JDK.java.util.Locale arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object call_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Boolean;", "public")]
	public Dova.JDK.java.lang.Boolean call_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/util/Types;", "public")]
	public Dova.JDK.javax.lang.model.util.Types getTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Types>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)V", "public")]
	public void setProcessors(Dova.JDK.java.lang.Iterable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)V", "public")]
	public void initDocLint(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/Plugin;[Ljava/lang/String;)V", "private transient")]
	public void initPlugin(Dova.JDK.com.sun.source.util.Plugin arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/Set;)V", "public")]
	public void initPlugins(Dova.JDK.java.util.Set arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/Collection;", "public")]
	public Dova.JDK.java.util.Collection getTaskListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TaskListener;)V", "public")]
	public void setTaskListener(Dova.JDK.com.sun.source.util.TaskListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TaskListener;)V", "public")]
	public void removeTaskListener(Dova.JDK.com.sun.source.util.TaskListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/ParameterNameProvider;)V", "public")]
	public void setParameterNameProvider(Dova.JDK.com.sun.source.util.ParameterNameProvider arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljavax/lang/model/type/TypeMirror;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getTypeMirror(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/util/Elements;", "public")]
	public Dova.JDK.javax.lang.model.util.Elements getElements()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Elements>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Iterable;", "public")]
	public Dova.JDK.java.lang.Iterable analyze()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TaskListener;)V", "public")]
	public void addTaskListener(Dova.JDK.com.sun.source.util.TaskListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}
}
