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

[JniSignatureAttribute("Ljdk/dynalink/beans/BeansLinker;", "public")]
public partial class BeansLinker
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.dynalink.linker.GuardingDynamicLinker
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BeansLinker()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/beans/BeansLinker;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "linkers", "Ljava/lang/ClassValue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "missingMemberHandlerFactory", "Ljdk/dynalink/beans/MissingMemberHandlerFactory;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/dynalink/beans/MissingMemberHandlerFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getConstructorMethod", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGuardedInvocation", "(Ljdk/dynalink/linker/LinkRequest;Ljdk/dynalink/linker/LinkerServices;)Ljdk/dynalink/linker/GuardedInvocation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getStaticLinkerForClass", "(Ljava/lang/Class;)Ljdk/dynalink/linker/TypeBasedGuardingDynamicLinker;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getReadableStaticPropertyNames", "(Ljava/lang/Class;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getWritableStaticPropertyNames", "(Ljava/lang/Class;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getStaticMethodNames", "(Ljava/lang/Class;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLinkerForClass", "(Ljava/lang/Class;)Ljdk/dynalink/linker/TypeBasedGuardingDynamicLinker;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDynamicMethod", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDynamicConstructor", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getReadableInstancePropertyNames", "(Ljava/lang/Class;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getWritableInstancePropertyNames", "(Ljava/lang/Class;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstanceMethodNames", "(Ljava/lang/Class;)Ljava/util/Set;"));
	}

	[JniSignatureAttribute("Ljava/lang/ClassValue;", "private static final")]
	public static Dova.JDK.java.lang.ClassValue linkers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassValue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/dynalink/beans/MissingMemberHandlerFactory;", "private final")]
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
	public BeansLinker(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public BeansLinker() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljdk/dynalink/beans/MissingMemberHandlerFactory;)V", "public")]
	public BeansLinker(Dova.JDK.jdk.dynalink.beans.MissingMemberHandlerFactory arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/dynalink/beans/BeansLinker;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;", "public static")]
	public static Dova.JDK.java.lang.Object getConstructorMethod(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/linker/LinkRequest;Ljdk/dynalink/linker/LinkerServices;)Ljdk/dynalink/linker/GuardedInvocation;", "public")]
	public Dova.JDK.jdk.dynalink.linker.GuardedInvocation getGuardedInvocation(Dova.JDK.jdk.dynalink.linker.LinkRequest arg0, Dova.JDK.jdk.dynalink.linker.LinkerServices arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.GuardedInvocation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljdk/dynalink/linker/TypeBasedGuardingDynamicLinker;", "static")]
	public static Dova.JDK.jdk.dynalink.linker.TypeBasedGuardingDynamicLinker getStaticLinkerForClass(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.TypeBasedGuardingDynamicLinker>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/util/Set;", "public static")]
	public static Dova.JDK.java.util.Set getReadableStaticPropertyNames(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/util/Set;", "public static")]
	public static Dova.JDK.java.util.Set getWritableStaticPropertyNames(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/util/Set;", "public static")]
	public static Dova.JDK.java.util.Set getStaticMethodNames(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljdk/dynalink/linker/TypeBasedGuardingDynamicLinker;", "public")]
	public Dova.JDK.jdk.dynalink.linker.TypeBasedGuardingDynamicLinker getLinkerForClass(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.TypeBasedGuardingDynamicLinker>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public static")]
	public static bool isDynamicMethod(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public static")]
	public static bool isDynamicConstructor(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/util/Set;", "public static")]
	public static Dova.JDK.java.util.Set getReadableInstancePropertyNames(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/util/Set;", "public static")]
	public static Dova.JDK.java.util.Set getWritableInstancePropertyNames(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/util/Set;", "public static")]
	public static Dova.JDK.java.util.Set getInstanceMethodNames(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("Ljdk/dynalink/beans/BeansLinker$NoSuchMemberHandlerBindingLinker;", "private static")]
	public partial class NoSuchMemberHandlerBindingLinker
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.dynalink.linker.TypeBasedGuardingDynamicLinker
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NoSuchMemberHandlerBindingLinker()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/beans/BeansLinker$NoSuchMemberHandlerBindingLinker;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "linker", "Ljdk/dynalink/linker/TypeBasedGuardingDynamicLinker;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "missingMemberHandlerFactory", "Ljdk/dynalink/beans/MissingMemberHandlerFactory;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/dynalink/linker/TypeBasedGuardingDynamicLinker;Ljdk/dynalink/beans/MissingMemberHandlerFactory;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canLinkType", "(Ljava/lang/Class;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGuardedInvocation", "(Ljdk/dynalink/linker/LinkRequest;Ljdk/dynalink/linker/LinkerServices;)Ljdk/dynalink/linker/GuardedInvocation;"));
		}

		[JniSignatureAttribute("Ljdk/dynalink/linker/TypeBasedGuardingDynamicLinker;", "private final")]
		public Dova.JDK.jdk.dynalink.linker.TypeBasedGuardingDynamicLinker linker_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.TypeBasedGuardingDynamicLinker>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/dynalink/beans/MissingMemberHandlerFactory;", "private final")]
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
		public NoSuchMemberHandlerBindingLinker(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/dynalink/linker/TypeBasedGuardingDynamicLinker;Ljdk/dynalink/beans/MissingMemberHandlerFactory;)V", "")]
		public NoSuchMemberHandlerBindingLinker(Dova.JDK.jdk.dynalink.linker.TypeBasedGuardingDynamicLinker arg0, Dova.JDK.jdk.dynalink.beans.MissingMemberHandlerFactory arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/dynalink/beans/BeansLinker$NoSuchMemberHandlerBindingLinker;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public")]
		public bool canLinkType(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljdk/dynalink/linker/LinkRequest;Ljdk/dynalink/linker/LinkerServices;)Ljdk/dynalink/linker/GuardedInvocation;", "public")]
		public Dova.JDK.jdk.dynalink.linker.GuardedInvocation getGuardedInvocation(Dova.JDK.jdk.dynalink.linker.LinkRequest arg0, Dova.JDK.jdk.dynalink.linker.LinkerServices arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.GuardedInvocation>(ret);
		}
	}
}
