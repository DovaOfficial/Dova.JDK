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

namespace Dova.JDK.jdk.dynalink.linker.support;

[JniSignatureAttribute("Ljdk/dynalink/linker/support/CompositeTypeBasedGuardingDynamicLinker;", "public")]
public partial class CompositeTypeBasedGuardingDynamicLinker
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.dynalink.linker.TypeBasedGuardingDynamicLinker
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CompositeTypeBasedGuardingDynamicLinker()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/linker/support/CompositeTypeBasedGuardingDynamicLinker;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToLinker", "Ljava/lang/ClassValue;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Iterable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "optimize", "(Ljava/lang/Iterable;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addTypeBased", "(Ljava/util/List;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canLinkType", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGuardedInvocation", "(Ljdk/dynalink/linker/LinkRequest;Ljdk/dynalink/linker/LinkerServices;)Ljdk/dynalink/linker/GuardedInvocation;"));
	}

	[JniSignatureAttribute("Ljava/lang/ClassValue;", "private final")]
	public Dova.JDK.java.lang.ClassValue classToLinker_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassValue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CompositeTypeBasedGuardingDynamicLinker(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)V", "public")]
	public CompositeTypeBasedGuardingDynamicLinker(Dova.JDK.java.lang.Iterable arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/dynalink/linker/support/CompositeTypeBasedGuardingDynamicLinker;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/util/List;", "public static")]
	public static Dova.JDK.java.util.List optimize(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;)V", "private static")]
	public static void addTypeBased(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public")]
	public bool canLinkType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/dynalink/linker/LinkRequest;Ljdk/dynalink/linker/LinkerServices;)Ljdk/dynalink/linker/GuardedInvocation;", "public")]
	public Dova.JDK.jdk.dynalink.linker.GuardedInvocation getGuardedInvocation(Dova.JDK.jdk.dynalink.linker.LinkRequest arg0, Dova.JDK.jdk.dynalink.linker.LinkerServices arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.GuardedInvocation>(ret);
	}

	[JniSignatureAttribute("Ljdk/dynalink/linker/support/CompositeTypeBasedGuardingDynamicLinker$ClassToLinker;", "private static")]
	public partial class ClassToLinker
		: Dova.JDK.java.lang.ClassValue
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClassToLinker()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/linker/support/CompositeTypeBasedGuardingDynamicLinker$ClassToLinker;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_LINKER", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "linkers", "[Ljdk/dynalink/linker/TypeBasedGuardingDynamicLinker;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "singletonLinkers", "[Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljdk/dynalink/linker/TypeBasedGuardingDynamicLinker;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeValue_0", "(Ljava/lang/Class;)Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeValue_1", "(Ljava/lang/Class;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private static final")]
		public static Dova.JDK.java.util.List NO_LINKER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/dynalink/linker/TypeBasedGuardingDynamicLinker;", "private final")]
		public JavaArray<Dova.JDK.jdk.dynalink.linker.TypeBasedGuardingDynamicLinker> linkers_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.dynalink.linker.TypeBasedGuardingDynamicLinker>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/util/List;", "private final")]
		public JavaArray<Dova.JDK.java.util.List> singletonLinkers_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.List>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ClassToLinker(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Ljdk/dynalink/linker/TypeBasedGuardingDynamicLinker;)V", "")]
		public ClassToLinker(JavaArray<Dova.JDK.jdk.dynalink.linker.TypeBasedGuardingDynamicLinker> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/dynalink/linker/support/CompositeTypeBasedGuardingDynamicLinker$ClassToLinker;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/util/List;", "protected")]
		public Dova.JDK.java.util.List computeValue_0(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Object;", "protected volatile")]
		public Dova.JDK.java.lang.Object computeValue_1(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
