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

namespace Dova.JDK.javax.annotation.processing;

[JniSignatureAttribute("Ljavax/annotation/processing/Messager;", "public abstract interface")]
public partial interface Messager
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Messager()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/annotation/processing/Messager;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printWarning", "(Ljava/lang/CharSequence;Ljavax/lang/model/element/Element;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printWarning", "(Ljava/lang/CharSequence;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printMessage", "(Ljavax/tools/Diagnostic$Kind;Ljava/lang/CharSequence;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printMessage", "(Ljavax/tools/Diagnostic$Kind;Ljava/lang/CharSequence;Ljavax/lang/model/element/Element;Ljavax/lang/model/element/AnnotationMirror;Ljavax/lang/model/element/AnnotationValue;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printMessage", "(Ljavax/tools/Diagnostic$Kind;Ljava/lang/CharSequence;Ljavax/lang/model/element/Element;Ljavax/lang/model/element/AnnotationMirror;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printMessage", "(Ljavax/tools/Diagnostic$Kind;Ljava/lang/CharSequence;Ljavax/lang/model/element/Element;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printError", "(Ljava/lang/CharSequence;Ljavax/lang/model/element/Element;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printError", "(Ljava/lang/CharSequence;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printNote", "(Ljava/lang/CharSequence;Ljavax/lang/model/element/Element;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printNote", "(Ljava/lang/CharSequence;)V"));
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljavax/lang/model/element/Element;)V", "public")]
	void printWarning(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.javax.lang.model.element.Element arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)V", "public")]
	void printWarning(Dova.JDK.java.lang.CharSequence arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic$Kind;Ljava/lang/CharSequence;)V", "public abstract")]
	void printMessage(Dova.JDK.javax.tools.Diagnostic.Kind arg0, Dova.JDK.java.lang.CharSequence arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic$Kind;Ljava/lang/CharSequence;Ljavax/lang/model/element/Element;Ljavax/lang/model/element/AnnotationMirror;Ljavax/lang/model/element/AnnotationValue;)V", "public abstract")]
	void printMessage(Dova.JDK.javax.tools.Diagnostic.Kind arg0, Dova.JDK.java.lang.CharSequence arg1, Dova.JDK.javax.lang.model.element.Element arg2, Dova.JDK.javax.lang.model.element.AnnotationMirror arg3, Dova.JDK.javax.lang.model.element.AnnotationValue arg4)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic$Kind;Ljava/lang/CharSequence;Ljavax/lang/model/element/Element;Ljavax/lang/model/element/AnnotationMirror;)V", "public abstract")]
	void printMessage(Dova.JDK.javax.tools.Diagnostic.Kind arg0, Dova.JDK.java.lang.CharSequence arg1, Dova.JDK.javax.lang.model.element.Element arg2, Dova.JDK.javax.lang.model.element.AnnotationMirror arg3)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic$Kind;Ljava/lang/CharSequence;Ljavax/lang/model/element/Element;)V", "public abstract")]
	void printMessage(Dova.JDK.javax.tools.Diagnostic.Kind arg0, Dova.JDK.java.lang.CharSequence arg1, Dova.JDK.javax.lang.model.element.Element arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljavax/lang/model/element/Element;)V", "public")]
	void printError(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.javax.lang.model.element.Element arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)V", "public")]
	void printError(Dova.JDK.java.lang.CharSequence arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljavax/lang/model/element/Element;)V", "public")]
	void printNote(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.javax.lang.model.element.Element arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)V", "public")]
	void printNote(Dova.JDK.java.lang.CharSequence arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}
}
