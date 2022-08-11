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

namespace Dova.JDK.javax.security.auth;

[JniSignatureAttribute("Ljavax/security/auth/SubjectDomainCombiner;", "public")]
public partial class SubjectDomainCombiner
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.security.DomainCombiner
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SubjectDomainCombiner()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/security/auth/SubjectDomainCombiner;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subject", "Ljavax/security/auth/Subject;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cachedPDs", "Ljavax/security/auth/SubjectDomainCombiner$WeakKeyValueMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "principalSet", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "principals", "[Ljava/security/Principal;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "debug", "Lsun/security/util/Debug;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/security/auth/Subject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "combine", "([Ljava/security/ProtectionDomain;[Ljava/security/ProtectionDomain;)[Ljava/security/ProtectionDomain;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "optimize", "([Ljava/security/ProtectionDomain;)[Ljava/security/ProtectionDomain;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSubject", "()Ljavax/security/auth/Subject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "printInputDomains", "([Ljava/security/ProtectionDomain;[Ljava/security/ProtectionDomain;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "printDomain", "(Ljava/security/ProtectionDomain;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljavax/security/auth/Subject;", "private")]
	public Dova.JDK.javax.security.auth.Subject subject_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.Subject>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/security/auth/SubjectDomainCombiner$WeakKeyValueMap;", "private")]
	public Dova.JDK.javax.security.auth.SubjectDomainCombiner.WeakKeyValueMap cachedPDs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.SubjectDomainCombiner.WeakKeyValueMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set principalSet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/security/Principal;", "private")]
	public JavaArray<Dova.JDK.java.security.Principal> principals_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.Principal>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/Debug;", "private static final")]
	public static Dova.JDK.sun.security.util.Debug debug_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.Debug>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SubjectDomainCombiner(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/security/auth/Subject;)V", "public")]
	public SubjectDomainCombiner(Dova.JDK.javax.security.auth.Subject arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/security/auth/SubjectDomainCombiner;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljava/security/ProtectionDomain;[Ljava/security/ProtectionDomain;)[Ljava/security/ProtectionDomain;", "public")]
	public JavaArray<Dova.JDK.java.security.ProtectionDomain> combine(JavaArray<Dova.JDK.java.security.ProtectionDomain> arg0, JavaArray<Dova.JDK.java.security.ProtectionDomain> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.ProtectionDomain>>(ret);
	}

	[JniSignatureAttribute("([Ljava/security/ProtectionDomain;)[Ljava/security/ProtectionDomain;", "private static")]
	public static JavaArray<Dova.JDK.java.security.ProtectionDomain> optimize(JavaArray<Dova.JDK.java.security.ProtectionDomain> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.ProtectionDomain>>(ret);
	}

	[JniSignatureAttribute("()Ljavax/security/auth/Subject;", "public")]
	public Dova.JDK.javax.security.auth.Subject getSubject()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.Subject>(ret);
	}

	[JniSignatureAttribute("([Ljava/security/ProtectionDomain;[Ljava/security/ProtectionDomain;)V", "private static")]
	public static void printInputDomains(JavaArray<Dova.JDK.java.security.ProtectionDomain> arg0, JavaArray<Dova.JDK.java.security.ProtectionDomain> arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/security/ProtectionDomain;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String printDomain(Dova.JDK.java.security.ProtectionDomain arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Ljavax/security/auth/SubjectDomainCombiner$WeakKeyValueMap;", "private static")]
	public partial class WeakKeyValueMap
		: Dova.JDK.java.util.WeakHashMap
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WeakKeyValueMap()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/security/auth/SubjectDomainCombiner$WeakKeyValueMap;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "(Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putValue", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WeakKeyValueMap(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public WeakKeyValueMap() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/security/auth/SubjectDomainCombiner$WeakKeyValueMap;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object getValue(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object putValue(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
