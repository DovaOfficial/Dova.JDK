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

namespace Dova.JDK.com.sun.source.util;

[JniSignatureAttribute("Lcom/sun/source/util/JavacTask;", "public abstract")]
public partial class JavacTask
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.tools.JavaCompiler.CompilationTask
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavacTask()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/util/JavacTask;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "JavacTask", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "instance", "(Ljavax/annotation/processing/ProcessingEnvironment;)Lcom/sun/source/util/JavacTask;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "()Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "generate", "()Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTypes", "()Ljavax/lang/model/util/Types;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setTaskListener", "(Lcom/sun/source/util/TaskListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeTaskListener", "(Lcom/sun/source/util/TaskListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setParameterNameProvider", "(Lcom/sun/source/util/ParameterNameProvider;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTypeMirror", "(Ljava/lang/Iterable;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getElements", "()Ljavax/lang/model/util/Elements;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "analyze", "()Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addTaskListener", "(Lcom/sun/source/util/TaskListener;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JavacTask(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public JavacTask() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/source/util/JavacTask;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/annotation/processing/ProcessingEnvironment;)Lcom/sun/source/util/JavacTask;", "public static")]
	public static Dova.JDK.com.sun.source.util.JavacTask instance(Dova.JDK.javax.annotation.processing.ProcessingEnvironment arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.JavacTask>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Iterable;", "public abstract")]
	public Dova.JDK.java.lang.Iterable parse()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Iterable;", "public abstract")]
	public Dova.JDK.java.lang.Iterable generate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/util/Types;", "public abstract")]
	public Dova.JDK.javax.lang.model.util.Types getTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Types>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TaskListener;)V", "public abstract")]
	public void setTaskListener(Dova.JDK.com.sun.source.util.TaskListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TaskListener;)V", "public abstract")]
	public void removeTaskListener(Dova.JDK.com.sun.source.util.TaskListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/ParameterNameProvider;)V", "public")]
	public void setParameterNameProvider(Dova.JDK.com.sun.source.util.ParameterNameProvider arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljavax/lang/model/type/TypeMirror;", "public abstract")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getTypeMirror(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/util/Elements;", "public abstract")]
	public Dova.JDK.javax.lang.model.util.Elements getElements()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Elements>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Iterable;", "public abstract")]
	public Dova.JDK.java.lang.Iterable analyze()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TaskListener;)V", "public abstract")]
	public void addTaskListener(Dova.JDK.com.sun.source.util.TaskListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}
}
