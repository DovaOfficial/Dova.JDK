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

namespace Dova.JDK.jdk.dynalink.beans;

[JniSignatureAttribute("Ljdk/dynalink/beans/LinkerServicesWithMissingMemberHandlerFactory;", "final")]
public partial class LinkerServicesWithMissingMemberHandlerFactory
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.dynalink.linker.LinkerServices
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LinkerServicesWithMissingMemberHandlerFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/beans/LinkerServicesWithMissingMemberHandlerFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "linkerServices", "Ljdk/dynalink/linker/LinkerServices;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "missingMemberHandlerFactory", "Ljdk/dynalink/beans/MissingMemberHandlerFactory;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/dynalink/linker/LinkerServices;Ljdk/dynalink/beans/MissingMemberHandlerFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(Ljdk/dynalink/linker/LinkerServices;Ljdk/dynalink/beans/MissingMemberHandlerFactory;)Ljdk/dynalink/linker/LinkerServices;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asType", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canConvert", "(Ljava/lang/Class;Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGuardedInvocation", "(Ljdk/dynalink/linker/LinkRequest;)Ljdk/dynalink/linker/GuardedInvocation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeConverter", "(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareConversion", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)Ljdk/dynalink/linker/ConversionComparator$Comparison;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filterInternalObjects", "(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWithLookup", "(Ljava/util/function/Supplier;Ljdk/dynalink/SecureLookupSupplier;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("Ljdk/dynalink/linker/LinkerServices;", "final")]
	public Dova.JDK.jdk.dynalink.linker.LinkerServices linkerServices_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.LinkerServices>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/dynalink/beans/MissingMemberHandlerFactory;", "final")]
	public Dova.JDK.jdk.dynalink.beans.MissingMemberHandlerFactory missingMemberHandlerFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.MissingMemberHandlerFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LinkerServicesWithMissingMemberHandlerFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/dynalink/linker/LinkerServices;Ljdk/dynalink/beans/MissingMemberHandlerFactory;)V", "private")]
	public LinkerServicesWithMissingMemberHandlerFactory(Dova.JDK.jdk.dynalink.linker.LinkerServices arg0, Dova.JDK.jdk.dynalink.beans.MissingMemberHandlerFactory arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/dynalink/beans/LinkerServicesWithMissingMemberHandlerFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/dynalink/linker/LinkerServices;Ljdk/dynalink/beans/MissingMemberHandlerFactory;)Ljdk/dynalink/linker/LinkerServices;", "static")]
	public static Dova.JDK.jdk.dynalink.linker.LinkerServices get(Dova.JDK.jdk.dynalink.linker.LinkerServices arg0, Dova.JDK.jdk.dynalink.beans.MissingMemberHandlerFactory arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.LinkerServices>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "public")]
	public Dova.JDK.java.lang.invoke.MethodHandle asType(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodType arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;)Z", "public")]
	public bool canConvert(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/dynalink/linker/LinkRequest;)Ljdk/dynalink/linker/GuardedInvocation;", "public")]
	public Dova.JDK.jdk.dynalink.linker.GuardedInvocation getGuardedInvocation(Dova.JDK.jdk.dynalink.linker.LinkRequest arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.GuardedInvocation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public")]
	public Dova.JDK.java.lang.invoke.MethodHandle getTypeConverter(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)Ljdk/dynalink/linker/ConversionComparator$Comparison;", "public")]
	public Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison compareConversion(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "public")]
	public Dova.JDK.java.lang.invoke.MethodHandle filterInternalObjects(Dova.JDK.java.lang.invoke.MethodHandle arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljdk/dynalink/SecureLookupSupplier;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getWithLookup(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.jdk.dynalink.SecureLookupSupplier arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
