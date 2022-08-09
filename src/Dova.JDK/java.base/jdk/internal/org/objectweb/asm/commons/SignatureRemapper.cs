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

namespace Dova.JDK.jdk.@internal.org.objectweb.asm.commons;

[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/commons/SignatureRemapper;", "public")]
public partial class SignatureRemapper
	: Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SignatureRemapper()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/org/objectweb/asm/commons/SignatureRemapper;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "signatureVisitor", "Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "remapper", "Ljdk/internal/org/objectweb/asm/commons/Remapper;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "classNames", "Ljava/util/ArrayList;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "SignatureRemapper", "(Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;Ljdk/internal/org/objectweb/asm/commons/Remapper;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "SignatureRemapper", "(ILjdk/internal/org/objectweb/asm/signature/SignatureVisitor;Ljdk/internal/org/objectweb/asm/commons/Remapper;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitEnd", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitClassBound", "()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitInterfaceBound", "()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitSuperclass", "()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitInterface", "()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitParameterType", "()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitReturnType", "()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitExceptionType", "()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitBaseType", "(C)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitTypeVariable", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitArrayType", "()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitClassType", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitInnerClassType", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitTypeArgument", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitTypeArgument", "(C)Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitFormalTypeParameter", "(Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "private final")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor signatureVisitor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/commons/Remapper;", "private final")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.commons.Remapper remapper_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.commons.Remapper>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/ArrayList;", "private")]
	public Dova.JDK.java.util.ArrayList classNames_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SignatureRemapper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;Ljdk/internal/org/objectweb/asm/commons/Remapper;)V", "public")]
	public SignatureRemapper(Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.commons.Remapper arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(ILjdk/internal/org/objectweb/asm/signature/SignatureVisitor;Ljdk/internal/org/objectweb/asm/commons/Remapper;)V", "protected")]
	public SignatureRemapper(int arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.commons.Remapper arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/objectweb/asm/commons/SignatureRemapper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void visitEnd()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor visitClassBound()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor visitInterfaceBound()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor visitSuperclass()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor visitInterface()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor visitParameterType()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor visitReturnType()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor visitExceptionType()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("(C)V", "public")]
	public void visitBaseType(char arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void visitTypeVariable(Dova.JDK.java.lang.String arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor visitArrayType()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void visitClassType(Dova.JDK.java.lang.String arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void visitInnerClassType(Dova.JDK.java.lang.String arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void visitTypeArgument()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("(C)Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor visitTypeArgument(char arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void visitFormalTypeParameter(Dova.JDK.java.lang.String arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}
}