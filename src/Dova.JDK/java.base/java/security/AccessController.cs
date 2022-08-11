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

namespace Dova.JDK.java.security;

[JniSignatureAttribute("Ljava/security/AccessController;", "public final")]
public partial class AccessController
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AccessController()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/security/AccessController;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "executePrivileged", "(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "executePrivileged", "(Ljava/security/PrivilegedExceptionAction;Ljava/security/AccessControlContext;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getProtectionDomain", "(Ljava/lang/Class;)Ljava/security/ProtectionDomain;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkPermission", "(Ljava/security/Permission;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedExceptionAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;[Ljava/security/Permission;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedExceptionAction;Ljava/security/AccessControlContext;[Ljava/security/Permission;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getContext", "()Ljava/security/AccessControlContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isPrivileged", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInheritedAccessControlContext", "()Ljava/security/AccessControlContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getStackAccessControlContext", "()Ljava/security/AccessControlContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "preserveCombiner", "(Ljava/security/DomainCombiner;Ljava/lang/Class;)Ljava/security/AccessControlContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkContext", "(Ljava/security/AccessControlContext;Ljava/lang/Class;)Ljava/security/AccessControlContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createWrapper", "(Ljava/security/DomainCombiner;Ljava/lang/Class;Ljava/security/AccessControlContext;Ljava/security/AccessControlContext;[Ljava/security/Permission;)Ljava/security/AccessControlContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "wrapException", "(Ljava/lang/Exception;)Ljava/security/PrivilegedActionException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInnocuousAcc", "()Ljava/security/AccessControlContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ensureMaterializedForStackWalk", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivilegedWithCombiner", "(Ljava/security/PrivilegedExceptionAction;Ljava/security/AccessControlContext;[Ljava/security/Permission;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivilegedWithCombiner", "(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;[Ljava/security/Permission;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivilegedWithCombiner", "(Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivilegedWithCombiner", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AccessController(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public AccessController() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/security/AccessController;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;Ljava/lang/Class;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object executePrivileged(Dova.JDK.java.security.PrivilegedAction arg0, Dova.JDK.java.security.AccessControlContext arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedExceptionAction;Ljava/security/AccessControlContext;Ljava/lang/Class;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object executePrivileged(Dova.JDK.java.security.PrivilegedExceptionAction arg0, Dova.JDK.java.security.AccessControlContext arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/security/ProtectionDomain;", "private static native")]
	public static Dova.JDK.java.security.ProtectionDomain getProtectionDomain(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Permission;)V", "public static")]
	public static void checkPermission(Dova.JDK.java.security.Permission arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "public static")]
	public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;", "public static")]
	public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedExceptionAction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedExceptionAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;", "public static")]
	public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedExceptionAction arg0, Dova.JDK.java.security.AccessControlContext arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;", "public static")]
	public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0, Dova.JDK.java.security.AccessControlContext arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;[Ljava/security/Permission;)Ljava/lang/Object;", "public static transient")]
	public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0, Dova.JDK.java.security.AccessControlContext arg1, JavaArray<Dova.JDK.java.security.Permission> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedExceptionAction;Ljava/security/AccessControlContext;[Ljava/security/Permission;)Ljava/lang/Object;", "public static transient")]
	public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedExceptionAction arg0, Dova.JDK.java.security.AccessControlContext arg1, JavaArray<Dova.JDK.java.security.Permission> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/AccessControlContext;", "public static")]
	public static Dova.JDK.java.security.AccessControlContext getContext()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
	}

	[JniSignatureAttribute("()Z", "private static")]
	public static bool isPrivileged()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/security/AccessControlContext;", "static native")]
	public static Dova.JDK.java.security.AccessControlContext getInheritedAccessControlContext()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/AccessControlContext;", "private static native")]
	public static Dova.JDK.java.security.AccessControlContext getStackAccessControlContext()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/DomainCombiner;Ljava/lang/Class;)Ljava/security/AccessControlContext;", "private static")]
	public static Dova.JDK.java.security.AccessControlContext preserveCombiner(Dova.JDK.java.security.DomainCombiner arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/AccessControlContext;Ljava/lang/Class;)Ljava/security/AccessControlContext;", "private static")]
	public static Dova.JDK.java.security.AccessControlContext checkContext(Dova.JDK.java.security.AccessControlContext arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/DomainCombiner;Ljava/lang/Class;Ljava/security/AccessControlContext;Ljava/security/AccessControlContext;[Ljava/security/Permission;)Ljava/security/AccessControlContext;", "private static")]
	public static Dova.JDK.java.security.AccessControlContext createWrapper(Dova.JDK.java.security.DomainCombiner arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.security.AccessControlContext arg2, Dova.JDK.java.security.AccessControlContext arg3, JavaArray<Dova.JDK.java.security.Permission> arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Exception;)Ljava/security/PrivilegedActionException;", "private static")]
	public static Dova.JDK.java.security.PrivilegedActionException wrapException(Dova.JDK.java.lang.Exception arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivilegedActionException>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/AccessControlContext;", "private static")]
	public static Dova.JDK.java.security.AccessControlContext getInnocuousAcc()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "private static native")]
	public static void ensureMaterializedForStackWalk(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedExceptionAction;Ljava/security/AccessControlContext;[Ljava/security/Permission;)Ljava/lang/Object;", "public static transient")]
	public static Dova.JDK.java.lang.Object doPrivilegedWithCombiner(Dova.JDK.java.security.PrivilegedExceptionAction arg0, Dova.JDK.java.security.AccessControlContext arg1, JavaArray<Dova.JDK.java.security.Permission> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;[Ljava/security/Permission;)Ljava/lang/Object;", "public static transient")]
	public static Dova.JDK.java.lang.Object doPrivilegedWithCombiner(Dova.JDK.java.security.PrivilegedAction arg0, Dova.JDK.java.security.AccessControlContext arg1, JavaArray<Dova.JDK.java.security.Permission> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;", "public static")]
	public static Dova.JDK.java.lang.Object doPrivilegedWithCombiner(Dova.JDK.java.security.PrivilegedExceptionAction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "public static")]
	public static Dova.JDK.java.lang.Object doPrivilegedWithCombiner(Dova.JDK.java.security.PrivilegedAction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("Ljava/security/AccessController$AccHolder;", "private static")]
	public partial class AccHolder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccHolder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/security/AccessController$AccHolder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "innocuousAcc", "Ljava/security/AccessControlContext;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Ljava/security/AccessControlContext;", "static final")]
		public static Dova.JDK.java.security.AccessControlContext innocuousAcc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AccHolder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AccHolder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/security/AccessController$AccHolder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
