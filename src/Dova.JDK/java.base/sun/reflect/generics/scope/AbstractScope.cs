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

namespace Dova.JDK.sun.reflect.generics.scope;

[JniSignatureAttribute("Lsun/reflect/generics/scope/AbstractScope;", "public abstract")]
public partial class AbstractScope
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.reflect.generics.scope.Scope
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractScope()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/generics/scope/AbstractScope;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recvr", "Ljava/lang/reflect/GenericDeclaration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enclosingScope", "Lsun/reflect/generics/scope/Scope;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/GenericDeclaration;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookup", "(Ljava/lang/String;)Ljava/lang/reflect/TypeVariable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecvr", "()Ljava/lang/reflect/GenericDeclaration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeEnclosingScope", "()Lsun/reflect/generics/scope/Scope;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingScope", "()Lsun/reflect/generics/scope/Scope;"));
	}

	[JniSignatureAttribute("Ljava/lang/reflect/GenericDeclaration;", "private final")]
	public Dova.JDK.java.lang.Object recvr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/reflect/generics/scope/Scope;", "private volatile")]
	public Dova.JDK.sun.reflect.generics.scope.Scope enclosingScope_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.scope.Scope>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractScope(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/GenericDeclaration;)V", "protected")]
	public AbstractScope(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/reflect/generics/scope/AbstractScope;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/reflect/TypeVariable;", "public")]
	public Dova.JDK.java.lang.reflect.TypeVariable lookup(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.TypeVariable>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/GenericDeclaration;", "protected")]
	public Dova.JDK.java.lang.Object getRecvr()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/scope/Scope;", "protected abstract")]
	public Dova.JDK.sun.reflect.generics.scope.Scope computeEnclosingScope()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.scope.Scope>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/scope/Scope;", "protected")]
	public Dova.JDK.sun.reflect.generics.scope.Scope getEnclosingScope()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.scope.Scope>(ret);
	}
}
