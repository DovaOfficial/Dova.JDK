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

namespace Dova.JDK.jdk.jshell;

[JniSignatureAttribute("Ljdk/jshell/OuterWrapMap;", "")]
public partial class OuterWrapMap
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static OuterWrapMap()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jshell/OuterWrapMap;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "state", "Ljdk/jshell/JShell;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "classOuters", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "OuterWrapMap", "(Ljdk/jshell/JShell;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "wrapInClass", "(Ljava/util/Set;Ljava/util/Collection;Ljava/util/List;Ljava/util/List;)Ljdk/jshell/OuterWrap;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "wrapImport", "(Ljdk/jshell/Wrap;Ljdk/jshell/Snippet;)Ljdk/jshell/OuterWrap;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "wrapInTrialClass", "(Ljdk/jshell/Wrap;)Ljdk/jshell/OuterWrap;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getOuter", "(Ljava/lang/String;)Ljdk/jshell/OuterSnippetsClassWrap;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "wrappedInClass", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljdk/jshell/Wrap$CompoundWrap;"));
	}

	[JniSignatureAttribute("Ljdk/jshell/JShell;", "private final")]
	public Dova.JDK.jdk.jshell.JShell state_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.JShell>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map classOuters_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public OuterWrapMap(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/jshell/JShell;)V", "")]
	public OuterWrapMap(Dova.JDK.jdk.jshell.JShell arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jshell/OuterWrapMap;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/Set;Ljava/util/Collection;Ljava/util/List;Ljava/util/List;)Ljdk/jshell/OuterWrap;", "")]
	public Dova.JDK.jdk.jshell.OuterWrap wrapInClass(Dova.JDK.java.util.Set arg0, Dova.JDK.java.util.Collection arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.OuterWrap>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/Wrap;Ljdk/jshell/Snippet;)Ljdk/jshell/OuterWrap;", "")]
	public Dova.JDK.jdk.jshell.OuterWrap wrapImport(Dova.JDK.jdk.jshell.Wrap arg0, Dova.JDK.jdk.jshell.Snippet arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.OuterWrap>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/Wrap;)Ljdk/jshell/OuterWrap;", "")]
	public Dova.JDK.jdk.jshell.OuterWrap wrapInTrialClass(Dova.JDK.jdk.jshell.Wrap arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.OuterWrap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/jshell/OuterSnippetsClassWrap;", "")]
	public Dova.JDK.jdk.jshell.OuterSnippetsClassWrap getOuter(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.OuterSnippetsClassWrap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljdk/jshell/Wrap$CompoundWrap;", "private")]
	public Dova.JDK.jdk.jshell.Wrap.CompoundWrap wrappedInClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.Wrap.CompoundWrap>(ret);
	}
}
