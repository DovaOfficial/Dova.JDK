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

namespace Dova.JDK.com.sun.naming.@internal;

[JniSignatureAttribute("Lcom/sun/naming/internal/ObjectFactoriesFilter;", "public final")]
public partial class ObjectFactoriesFilter
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ObjectFactoriesFilter()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/naming/internal/ObjectFactoriesFilter;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "FACTORIES_FILTER_PROPNAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DEFAULT_SP_VALUE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GLOBAL", "Ljava/io/ObjectInputFilter;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ObjectFactoriesFilter", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "checkInput", "(Lcom/sun/naming/internal/ObjectFactoriesFilter$FactoryInfo;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "canInstantiateObjectsFactory", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getFilterPropertyValue", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String FACTORIES_FILTER_PROPNAME_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String DEFAULT_SP_VALUE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/io/ObjectInputFilter;", "private static final")]
	public static Dova.JDK.java.io.ObjectInputFilter GLOBAL_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ObjectFactoriesFilter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public ObjectFactoriesFilter() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/naming/internal/ObjectFactoriesFilter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/naming/internal/ObjectFactoriesFilter$FactoryInfo;)Z", "private static")]
	public static bool checkInput(Dova.JDK.com.sun.naming.@internal.ObjectFactoriesFilter.FactoryInfo arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public static")]
	public static bool canInstantiateObjectsFactory(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String getFilterPropertyValue()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/naming/internal/ObjectFactoriesFilter$FactoryInfo;", "private abstract static interface")]
	public partial interface FactoryInfo
		: IJavaObject
		, Dova.JDK.java.io.ObjectInputFilter.FilterInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FactoryInfo()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/naming/internal/ObjectFactoriesFilter$FactoryInfo;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "depth", "()J"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "arrayLength", "()J"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "streamBytes", "()J"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "references", "()J"));
		}

		[JniSignatureAttribute("()J", "public")]
		long depth()
		{
			var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()J", "public")]
		long arrayLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()J", "public")]
		long streamBytes()
		{
			var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()J", "public")]
		long references()
		{
			var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}
	}
}