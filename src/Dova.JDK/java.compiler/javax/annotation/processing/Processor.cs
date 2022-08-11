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

namespace Dova.JDK.javax.annotation.processing;

[JniSignatureAttribute("Ljavax/annotation/processing/Processor;", "public abstract interface")]
public partial interface Processor
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Processor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/annotation/processing/Processor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(Ljavax/annotation/processing/ProcessingEnvironment;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "process", "(Ljava/util/Set;Ljavax/annotation/processing/RoundEnvironment;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSupportedOptions", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSupportedAnnotationTypes", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSupportedSourceVersion", "()Ljavax/lang/model/SourceVersion;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompletions", "(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/AnnotationMirror;Ljavax/lang/model/element/ExecutableElement;Ljava/lang/String;)Ljava/lang/Iterable;"));
	}

	[JniSignatureAttribute("(Ljavax/annotation/processing/ProcessingEnvironment;)V", "public abstract")]
	void init(Dova.JDK.javax.annotation.processing.ProcessingEnvironment arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljavax/annotation/processing/RoundEnvironment;)Z", "public abstract")]
	bool process(Dova.JDK.java.util.Set arg0, Dova.JDK.javax.annotation.processing.RoundEnvironment arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
	Dova.JDK.java.util.Set getSupportedOptions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
	Dova.JDK.java.util.Set getSupportedAnnotationTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/SourceVersion;", "public abstract")]
	Dova.JDK.javax.lang.model.SourceVersion getSupportedSourceVersion()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.SourceVersion>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/AnnotationMirror;Ljavax/lang/model/element/ExecutableElement;Ljava/lang/String;)Ljava/lang/Iterable;", "public abstract")]
	Dova.JDK.java.lang.Iterable getCompletions(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.javax.lang.model.element.AnnotationMirror arg1, Dova.JDK.javax.lang.model.element.ExecutableElement arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}
}
