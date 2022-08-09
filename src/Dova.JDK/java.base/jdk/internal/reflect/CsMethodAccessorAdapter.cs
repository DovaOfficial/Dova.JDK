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

namespace Dova.JDK.jdk.@internal.reflect;

[JniSignatureAttribute("Ljdk/internal/reflect/CsMethodAccessorAdapter;", "")]
public partial class CsMethodAccessorAdapter
	: Dova.JDK.jdk.@internal.reflect.MethodAccessorImpl
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CsMethodAccessorAdapter()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/reflect/CsMethodAccessorAdapter;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "csmAdapter", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "accessor", "Ljdk/internal/reflect/MethodAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CsMethodAccessorAdapter", "(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljdk/internal/reflect/MethodAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "invoke", "(Ljava/lang/Object;[Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "invoke", "(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
	public Dova.JDK.java.lang.reflect.Method csmAdapter_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/reflect/MethodAccessor;", "private final")]
	public Dova.JDK.jdk.@internal.reflect.MethodAccessor accessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.MethodAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CsMethodAccessorAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljdk/internal/reflect/MethodAccessor;)V", "")]
	public CsMethodAccessorAdapter(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.lang.reflect.Method arg1, Dova.JDK.jdk.@internal.reflect.MethodAccessor arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/reflect/CsMethodAccessorAdapter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;[Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object invoke(Dova.JDK.java.lang.Object arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object invoke(Dova.JDK.java.lang.Object arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}