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

namespace Dova.JDK.jdk.@internal.org.objectweb.asm.commons;

[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/commons/RemappingSignatureAdapter;", "public")]
public partial class RemappingSignatureAdapter
	: Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RemappingSignatureAdapter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/objectweb/asm/commons/RemappingSignatureAdapter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureVisitor", "Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "remapper", "Ljdk/internal/org/objectweb/asm/commons/Remapper;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "className", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;Ljdk/internal/org/objectweb/asm/commons/Remapper;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjdk/internal/org/objectweb/asm/signature/SignatureVisitor;Ljdk/internal/org/objectweb/asm/commons/Remapper;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassBound", "()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInterfaceBound", "()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSuperclass", "()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInterface", "()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParameterType", "()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturnType", "()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExceptionType", "()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBaseType", "(C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVariable", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType", "()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInnerClassType", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeArgument", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeArgument", "(C)Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFormalTypeParameter", "(Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "private final")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor signatureVisitor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/commons/Remapper;", "private final")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.commons.Remapper remapper_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.commons.Remapper>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String className_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RemappingSignatureAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;Ljdk/internal/org/objectweb/asm/commons/Remapper;)V", "public")]
	public RemappingSignatureAdapter(Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.commons.Remapper arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(ILjdk/internal/org/objectweb/asm/signature/SignatureVisitor;Ljdk/internal/org/objectweb/asm/commons/Remapper;)V", "protected")]
	public RemappingSignatureAdapter(int arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.commons.Remapper arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/objectweb/asm/commons/RemappingSignatureAdapter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void visitEnd()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor visitClassBound()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor visitInterfaceBound()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor visitSuperclass()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor visitInterface()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor visitParameterType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor visitReturnType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor visitExceptionType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("(C)V", "public")]
	public void visitBaseType(char arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void visitTypeVariable(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor visitArrayType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void visitClassType(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void visitInnerClassType(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void visitTypeArgument()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("(C)Ljdk/internal/org/objectweb/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor visitTypeArgument(char arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void visitFormalTypeParameter(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}
}
