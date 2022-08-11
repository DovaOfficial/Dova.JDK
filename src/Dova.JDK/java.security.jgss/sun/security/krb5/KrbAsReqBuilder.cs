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

namespace Dova.JDK.sun.security.krb5;

[JniSignatureAttribute("Lsun/security/krb5/KrbAsReqBuilder;", "public final")]
public partial class KrbAsReqBuilder
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KrbAsReqBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/KrbAsReqBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "options", "Lsun/security/krb5/internal/KDCOptions;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cname", "Lsun/security/krb5/PrincipalName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refCname", "Lsun/security/krb5/PrincipalName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sname", "Lsun/security/krb5/PrincipalName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "from", "Lsun/security/krb5/internal/KerberosTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "till", "Lsun/security/krb5/internal/KerberosTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rtime", "Lsun/security/krb5/internal/KerberosTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addresses", "Lsun/security/krb5/internal/HostAddresses;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "password", "[C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ktab", "Ljavax/security/auth/kerberos/KeyTab;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paList", "[Lsun/security/krb5/internal/PAData;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "req", "Lsun/security/krb5/KrbAsReq;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rep", "Lsun/security/krb5/KrbAsRep;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "state", "Lsun/security/krb5/KrbAsReqBuilder$State;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/krb5/PrincipalName;[C)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/krb5/PrincipalName;Ljavax/security/auth/kerberos/KeyTab;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lsun/security/krb5/KrbAsReqBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(Lsun/security/krb5/PrincipalName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "action", "()Lsun/security/krb5/KrbAsReqBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "destroy", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTarget", "(Lsun/security/krb5/PrincipalName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkState", "(Lsun/security/krb5/KrbAsReqBuilder$State;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "(Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/KrbAsReqBuilder$ReferralsState;)Lsun/security/krb5/KrbAsReq;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeys", "(Z)[Lsun/security/krb5/EncryptionKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "send", "()Lsun/security/krb5/KrbAsReqBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCreds", "()Lsun/security/krb5/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCCreds", "()Lsun/security/krb5/internal/ccache/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOptions", "(Lsun/security/krb5/internal/KDCOptions;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTill", "(Lsun/security/krb5/internal/KerberosTime;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRTime", "(Lsun/security/krb5/internal/KerberosTime;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAddresses", "(Lsun/security/krb5/internal/HostAddresses;)V"));
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/KDCOptions;", "private")]
	public Dova.JDK.sun.security.krb5.@internal.KDCOptions options_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.KDCOptions>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/PrincipalName;", "private")]
	public Dova.JDK.sun.security.krb5.PrincipalName cname_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/PrincipalName;", "private")]
	public Dova.JDK.sun.security.krb5.PrincipalName refCname_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/PrincipalName;", "private")]
	public Dova.JDK.sun.security.krb5.PrincipalName sname_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/KerberosTime;", "private")]
	public Dova.JDK.sun.security.krb5.@internal.KerberosTime from_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.KerberosTime>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/KerberosTime;", "private")]
	public Dova.JDK.sun.security.krb5.@internal.KerberosTime till_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.KerberosTime>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/KerberosTime;", "private")]
	public Dova.JDK.sun.security.krb5.@internal.KerberosTime rtime_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.KerberosTime>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/HostAddresses;", "private")]
	public Dova.JDK.sun.security.krb5.@internal.HostAddresses addresses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.HostAddresses>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[C", "private final")]
	public JavaArray<char> password_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/security/auth/kerberos/KeyTab;", "private final")]
	public Dova.JDK.javax.security.auth.kerberos.KeyTab ktab_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.kerberos.KeyTab>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/krb5/internal/PAData;", "private")]
	public JavaArray<Dova.JDK.sun.security.krb5.@internal.PAData> paList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.@internal.PAData>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/KrbAsReq;", "private")]
	public Dova.JDK.sun.security.krb5.KrbAsReq req_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.KrbAsReq>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/KrbAsRep;", "private")]
	public Dova.JDK.sun.security.krb5.KrbAsRep rep_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.KrbAsRep>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/KrbAsReqBuilder$State;", "private")]
	public Dova.JDK.sun.security.krb5.KrbAsReqBuilder.State state_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.KrbAsReqBuilder.State>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KrbAsReqBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;[C)V", "public")]
	public KrbAsReqBuilder(Dova.JDK.sun.security.krb5.PrincipalName arg0, JavaArray<char> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;Ljavax/security/auth/kerberos/KeyTab;)V", "public")]
	public KrbAsReqBuilder(Dova.JDK.sun.security.krb5.PrincipalName arg0, Dova.JDK.javax.security.auth.kerberos.KeyTab arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/KrbAsReqBuilder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/security/krb5/KrbAsReqBuilder;", "private")]
	public Dova.JDK.sun.security.krb5.KrbAsReqBuilder resolve()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.KrbAsReqBuilder>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;)V", "private")]
	public void init(Dova.JDK.sun.security.krb5.PrincipalName arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/KrbAsReqBuilder;", "public")]
	public Dova.JDK.sun.security.krb5.KrbAsReqBuilder action()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.KrbAsReqBuilder>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void destroy()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;)V", "public")]
	public void setTarget(Dova.JDK.sun.security.krb5.PrincipalName arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/KrbAsReqBuilder$State;Ljava/lang/String;)V", "private")]
	public void checkState(Dova.JDK.sun.security.krb5.KrbAsReqBuilder.State arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/KrbAsReqBuilder$ReferralsState;)Lsun/security/krb5/KrbAsReq;", "private")]
	public Dova.JDK.sun.security.krb5.KrbAsReq build(Dova.JDK.sun.security.krb5.EncryptionKey arg0, Dova.JDK.sun.security.krb5.KrbAsReqBuilder.ReferralsState arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.KrbAsReq>(ret);
	}

	[JniSignatureAttribute("(Z)[Lsun/security/krb5/EncryptionKey;", "public")]
	public JavaArray<Dova.JDK.sun.security.krb5.EncryptionKey> getKeys(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.EncryptionKey>>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/KrbAsReqBuilder;", "private")]
	public Dova.JDK.sun.security.krb5.KrbAsReqBuilder send()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.KrbAsReqBuilder>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/Credentials;", "public")]
	public Dova.JDK.sun.security.krb5.Credentials getCreds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/ccache/Credentials;", "public")]
	public Dova.JDK.sun.security.krb5.@internal.ccache.Credentials getCCreds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.Credentials>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/KDCOptions;)V", "public")]
	public void setOptions(Dova.JDK.sun.security.krb5.@internal.KDCOptions arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/KerberosTime;)V", "public")]
	public void setTill(Dova.JDK.sun.security.krb5.@internal.KerberosTime arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/KerberosTime;)V", "public")]
	public void setRTime(Dova.JDK.sun.security.krb5.@internal.KerberosTime arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/HostAddresses;)V", "public")]
	public void setAddresses(Dova.JDK.sun.security.krb5.@internal.HostAddresses arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("Lsun/security/krb5/KrbAsReqBuilder$State;", "private static final")]
	public partial class State
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static State()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/KrbAsReqBuilder$State;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INIT", "Lsun/security/krb5/KrbAsReqBuilder$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REQ_OK", "Lsun/security/krb5/KrbAsReqBuilder$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESTROYED", "Lsun/security/krb5/KrbAsReqBuilder$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/security/krb5/KrbAsReqBuilder$State;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/security/krb5/KrbAsReqBuilder$State;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/krb5/KrbAsReqBuilder$State;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/security/krb5/KrbAsReqBuilder$State;"));
		}

		[JniSignatureAttribute("Lsun/security/krb5/KrbAsReqBuilder$State;", "public static final")]
		public static Dova.JDK.sun.security.krb5.KrbAsReqBuilder.State INIT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.KrbAsReqBuilder.State>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/krb5/KrbAsReqBuilder$State;", "public static final")]
		public static Dova.JDK.sun.security.krb5.KrbAsReqBuilder.State REQ_OK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.KrbAsReqBuilder.State>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/krb5/KrbAsReqBuilder$State;", "public static final")]
		public static Dova.JDK.sun.security.krb5.KrbAsReqBuilder.State DESTROYED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.KrbAsReqBuilder.State>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lsun/security/krb5/KrbAsReqBuilder$State;", "private static final")]
		public static JavaArray<Dova.JDK.sun.security.krb5.KrbAsReqBuilder.State> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.KrbAsReqBuilder.State>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public State(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public State(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/krb5/KrbAsReqBuilder$State;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/security/krb5/KrbAsReqBuilder$State;", "public static")]
		public static JavaArray<Dova.JDK.sun.security.krb5.KrbAsReqBuilder.State> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.KrbAsReqBuilder.State>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/krb5/KrbAsReqBuilder$State;", "public static")]
		public static Dova.JDK.sun.security.krb5.KrbAsReqBuilder.State valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.KrbAsReqBuilder.State>(ret);
		}

		[JniSignatureAttribute("()[Lsun/security/krb5/KrbAsReqBuilder$State;", "private static")]
		public static JavaArray<Dova.JDK.sun.security.krb5.KrbAsReqBuilder.State> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.KrbAsReqBuilder.State>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/KrbAsReqBuilder$ReferralsState;", "static final")]
	public partial class ReferralsState
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ReferralsState()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/KrbAsReqBuilder$ReferralsState;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "canonicalizeConfig", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enabled", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sendCanonicalize", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isEnterpriseCname", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "count", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refreshComm", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reqBuilder", "Lsun/security/krb5/KrbAsReqBuilder;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/krb5/KrbAsReqBuilder;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initStatic", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnabled", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendCanonicalize", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "refreshComm", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleError", "(Lsun/security/krb5/KrbException;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateStatus", "()V"));
		}

		[JniSignatureAttribute("Z", "private static")]
		public static bool canonicalizeConfig_Property
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

		[JniSignatureAttribute("Z", "private")]
		public bool enabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool sendCanonicalize_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool isEnterpriseCname_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int count_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool refreshComm_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("Lsun/security/krb5/KrbAsReqBuilder;", "private")]
		public Dova.JDK.sun.security.krb5.KrbAsReqBuilder reqBuilder_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.KrbAsReqBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ReferralsState(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/krb5/KrbAsReqBuilder;)V", "")]
		public ReferralsState(Dova.JDK.sun.security.krb5.KrbAsReqBuilder arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/krb5/KrbAsReqBuilder$ReferralsState;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "static")]
		public static void initStatic()
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool sendCanonicalize()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool refreshComm()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Lsun/security/krb5/KrbException;)Z", "")]
		public bool handleError(Dova.JDK.sun.security.krb5.KrbException arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("()V", "private")]
		public void updateStatus()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}
	}
}
