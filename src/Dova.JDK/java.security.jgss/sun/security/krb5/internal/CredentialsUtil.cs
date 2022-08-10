/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.security.krb5.@internal;

[JniSignatureAttribute("Lsun/security/krb5/internal/CredentialsUtil;", "public")]
public partial class CredentialsUtil
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CredentialsUtil()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/internal/CredentialsUtil;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEBUG", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CredentialsUtil", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "handleS4U2SelfReferral", "([Lsun/security/krb5/internal/PAData;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Credentials;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "serviceCredsReferrals", "(Lsun/security/krb5/internal/KDCOptions;Lsun/security/krb5/Credentials;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Credentials;[Lsun/security/krb5/internal/PAData;)Lsun/security/krb5/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "handleS4U2ProxyReferral", "(Lsun/security/krb5/Credentials;[Lsun/security/krb5/Credentials;Lsun/security/krb5/PrincipalName;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "serviceCreds", "(Lsun/security/krb5/internal/KDCOptions;Lsun/security/krb5/Credentials;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Credentials;[Lsun/security/krb5/internal/PAData;Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;)Lsun/security/krb5/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "serviceCreds", "(Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Credentials;)Lsun/security/krb5/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "serviceCredsSingle", "(Lsun/security/krb5/internal/KDCOptions;Lsun/security/krb5/Credentials;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Credentials;[Lsun/security/krb5/internal/PAData;)Lsun/security/krb5/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTGTforRealm", "(Ljava/lang/String;Ljava/lang/String;Lsun/security/krb5/Credentials;[Z)Lsun/security/krb5/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "acquireServiceCreds", "(Ljava/lang/String;Lsun/security/krb5/Credentials;)Lsun/security/krb5/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "acquireS4U2selfCreds", "(Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Credentials;)Lsun/security/krb5/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "acquireS4U2proxyCreds", "(Ljava/lang/String;Lsun/security/krb5/Credentials;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Credentials;)Lsun/security/krb5/Credentials;"));
	}

	[JniSignatureAttribute("Z", "private static")]
	public static bool DEBUG_Property
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
	public CredentialsUtil(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CredentialsUtil() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/internal/CredentialsUtil;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Lsun/security/krb5/internal/PAData;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Credentials;)V", "private static")]
	public static void handleS4U2SelfReferral(JavaArray<Dova.JDK.sun.security.krb5.@internal.PAData> arg0, Dova.JDK.sun.security.krb5.PrincipalName arg1, Dova.JDK.sun.security.krb5.Credentials arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/KDCOptions;Lsun/security/krb5/Credentials;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Credentials;[Lsun/security/krb5/internal/PAData;)Lsun/security/krb5/Credentials;", "private static")]
	public static Dova.JDK.sun.security.krb5.Credentials serviceCredsReferrals(Dova.JDK.sun.security.krb5.@internal.KDCOptions arg0, Dova.JDK.sun.security.krb5.Credentials arg1, Dova.JDK.sun.security.krb5.PrincipalName arg2, Dova.JDK.sun.security.krb5.PrincipalName arg3, Dova.JDK.sun.security.krb5.@internal.CredentialsUtil.S4U2Type arg4, Dova.JDK.sun.security.krb5.PrincipalName arg5, Dova.JDK.sun.security.krb5.Credentials arg6, JavaArray<Dova.JDK.sun.security.krb5.@internal.PAData> arg7)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/Credentials;[Lsun/security/krb5/Credentials;Lsun/security/krb5/PrincipalName;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String handleS4U2ProxyReferral(Dova.JDK.sun.security.krb5.Credentials arg0, JavaArray<Dova.JDK.sun.security.krb5.Credentials> arg1, Dova.JDK.sun.security.krb5.PrincipalName arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/KDCOptions;Lsun/security/krb5/Credentials;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Credentials;[Lsun/security/krb5/internal/PAData;Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;)Lsun/security/krb5/Credentials;", "private static")]
	public static Dova.JDK.sun.security.krb5.Credentials serviceCreds(Dova.JDK.sun.security.krb5.@internal.KDCOptions arg0, Dova.JDK.sun.security.krb5.Credentials arg1, Dova.JDK.sun.security.krb5.PrincipalName arg2, Dova.JDK.sun.security.krb5.PrincipalName arg3, Dova.JDK.sun.security.krb5.PrincipalName arg4, Dova.JDK.sun.security.krb5.Credentials arg5, JavaArray<Dova.JDK.sun.security.krb5.@internal.PAData> arg6, Dova.JDK.sun.security.krb5.@internal.CredentialsUtil.S4U2Type arg7)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Credentials;)Lsun/security/krb5/Credentials;", "private static")]
	public static Dova.JDK.sun.security.krb5.Credentials serviceCreds(Dova.JDK.sun.security.krb5.PrincipalName arg0, Dova.JDK.sun.security.krb5.Credentials arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/KDCOptions;Lsun/security/krb5/Credentials;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Credentials;[Lsun/security/krb5/internal/PAData;)Lsun/security/krb5/Credentials;", "private static")]
	public static Dova.JDK.sun.security.krb5.Credentials serviceCredsSingle(Dova.JDK.sun.security.krb5.@internal.KDCOptions arg0, Dova.JDK.sun.security.krb5.Credentials arg1, Dova.JDK.sun.security.krb5.PrincipalName arg2, Dova.JDK.sun.security.krb5.PrincipalName arg3, Dova.JDK.sun.security.krb5.PrincipalName arg4, Dova.JDK.sun.security.krb5.PrincipalName arg5, Dova.JDK.sun.security.krb5.@internal.CredentialsUtil.S4U2Type arg6, Dova.JDK.sun.security.krb5.PrincipalName arg7, Dova.JDK.sun.security.krb5.Credentials arg8, JavaArray<Dova.JDK.sun.security.krb5.@internal.PAData> arg9)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lsun/security/krb5/Credentials;[Z)Lsun/security/krb5/Credentials;", "private static")]
	public static Dova.JDK.sun.security.krb5.Credentials getTGTforRealm(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.sun.security.krb5.Credentials arg2, JavaArray<bool> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lsun/security/krb5/Credentials;)Lsun/security/krb5/Credentials;", "public static")]
	public static Dova.JDK.sun.security.krb5.Credentials acquireServiceCreds(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.security.krb5.Credentials arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Credentials;)Lsun/security/krb5/Credentials;", "public static")]
	public static Dova.JDK.sun.security.krb5.Credentials acquireS4U2selfCreds(Dova.JDK.sun.security.krb5.PrincipalName arg0, Dova.JDK.sun.security.krb5.Credentials arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lsun/security/krb5/Credentials;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Credentials;)Lsun/security/krb5/Credentials;", "public static")]
	public static Dova.JDK.sun.security.krb5.Credentials acquireS4U2proxyCreds(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.security.krb5.Credentials arg1, Dova.JDK.sun.security.krb5.PrincipalName arg2, Dova.JDK.sun.security.krb5.Credentials arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;", "private static final")]
	public partial class S4U2Type
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static S4U2Type()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NONE", "Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SELF", "Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PROXY", "Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "S4U2Type", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;"));
		}

		[JniSignatureAttribute("Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;", "public static final")]
		public static Dova.JDK.sun.security.krb5.@internal.CredentialsUtil.S4U2Type NONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.CredentialsUtil.S4U2Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;", "public static final")]
		public static Dova.JDK.sun.security.krb5.@internal.CredentialsUtil.S4U2Type SELF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.CredentialsUtil.S4U2Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;", "public static final")]
		public static Dova.JDK.sun.security.krb5.@internal.CredentialsUtil.S4U2Type PROXY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.CredentialsUtil.S4U2Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;", "private static final")]
		public static JavaArray<Dova.JDK.sun.security.krb5.@internal.CredentialsUtil.S4U2Type> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.@internal.CredentialsUtil.S4U2Type>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public S4U2Type(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public S4U2Type(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;", "public static")]
		public static JavaArray<Dova.JDK.sun.security.krb5.@internal.CredentialsUtil.S4U2Type> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.@internal.CredentialsUtil.S4U2Type>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;", "public static")]
		public static Dova.JDK.sun.security.krb5.@internal.CredentialsUtil.S4U2Type valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.CredentialsUtil.S4U2Type>(ret);
		}

		[JniSignatureAttribute("()[Lsun/security/krb5/internal/CredentialsUtil$S4U2Type;", "private static")]
		public static JavaArray<Dova.JDK.sun.security.krb5.@internal.CredentialsUtil.S4U2Type> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.@internal.CredentialsUtil.S4U2Type>>(ret);
		}
	}
}
