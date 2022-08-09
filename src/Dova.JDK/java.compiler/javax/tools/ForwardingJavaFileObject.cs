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

namespace Dova.JDK.javax.tools;

[JniSignatureAttribute("Ljavax/tools/ForwardingJavaFileObject;", "public")]
public partial class ForwardingJavaFileObject
	: Dova.JDK.javax.tools.ForwardingFileObject
	, Dova.JDK.javax.tools.JavaFileObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ForwardingJavaFileObject()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/tools/ForwardingJavaFileObject;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ForwardingJavaFileObject", "(Ljavax/tools/JavaFileObject;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isNameCompatible", "(Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNestingKind", "()Ljavax/lang/model/element/NestingKind;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAccessLevel", "()Ljavax/lang/model/element/Modifier;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getKind", "()Ljavax/tools/JavaFileObject$Kind;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ForwardingJavaFileObject(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)V", "protected")]
	public ForwardingJavaFileObject(Dova.JDK.java.lang.Object arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/tools/ForwardingJavaFileObject;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;)Z", "public")]
	public bool isNameCompatible(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.tools.JavaFileObject.Kind arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/lang/model/element/NestingKind;", "public")]
	public Dova.JDK.javax.lang.model.element.NestingKind getNestingKind()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.NestingKind>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/element/Modifier;", "public")]
	public Dova.JDK.javax.lang.model.element.Modifier getAccessLevel()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Modifier>(ret);
	}

	[JniSignatureAttribute("()Ljavax/tools/JavaFileObject$Kind;", "public")]
	public Dova.JDK.javax.tools.JavaFileObject.Kind getKind()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject.Kind>(ret);
	}
}