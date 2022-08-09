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

namespace Dova.JDK.sun.security.provider.certpath;

[JniSignatureAttribute("Lsun/security/provider/certpath/PKIX;", "")]
public partial class PKIX
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PKIX()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/provider/certpath/PKIX;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "debug", "Lsun/security/util/Debug;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PKIX", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "checkBuilderParams", "(Ljava/security/cert/CertPathParameters;)Lsun/security/provider/certpath/PKIX$BuilderParams;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "checkParams", "(Ljava/security/cert/CertPath;Ljava/security/cert/CertPathParameters;)Lsun/security/provider/certpath/PKIX$ValidatorParams;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isDSAPublicKeyWithoutParams", "(Ljava/security/PublicKey;)Z"));
	}

	[JniSignatureAttribute("Lsun/security/util/Debug;", "private static final")]
	public static Dova.JDK.sun.security.util.Debug debug_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.Debug>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PKIX(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public PKIX() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/provider/certpath/PKIX;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/security/cert/CertPathParameters;)Lsun/security/provider/certpath/PKIX$BuilderParams;", "static")]
	public static Dova.JDK.sun.security.provider.certpath.PKIX.BuilderParams checkBuilderParams(Dova.JDK.java.security.cert.CertPathParameters arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.PKIX.BuilderParams>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/cert/CertPath;Ljava/security/cert/CertPathParameters;)Lsun/security/provider/certpath/PKIX$ValidatorParams;", "static")]
	public static Dova.JDK.sun.security.provider.certpath.PKIX.ValidatorParams checkParams(Dova.JDK.java.security.cert.CertPath arg0, Dova.JDK.java.security.cert.CertPathParameters arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.PKIX.ValidatorParams>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PublicKey;)Z", "static")]
	public static bool isDSAPublicKeyWithoutParams(Dova.JDK.java.security.PublicKey arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lsun/security/provider/certpath/PKIX$ValidatorParams;", "static")]
	public partial class ValidatorParams
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ValidatorParams()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/provider/certpath/PKIX$ValidatorParams;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "params", "Ljava/security/cert/PKIXParameters;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "certPath", "Ljava/security/cert/CertPath;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "checkers", "Ljava/util/List;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "stores", "Ljava/util/List;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "gotDate", "Z"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "date", "Ljava/util/Date;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "policies", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "gotConstraints", "Z"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "constraints", "Ljava/security/cert/CertSelector;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "anchors", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "certs", "Ljava/util/List;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "timestamp", "Ljava/security/Timestamp;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "timestampDate", "Ljava/util/Date;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "variant", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ValidatorParams", "(Ljava/security/cert/CertPath;Ljava/security/cert/PKIXParameters;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ValidatorParams", "(Ljava/security/cert/PKIXParameters;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "timestamp", "()Ljava/util/Date;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "certPath", "()Ljava/security/cert/CertPath;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "sigProvider", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "date", "()Ljava/util/Date;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "variant", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setCertPath", "(Ljava/security/cert/CertPath;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPKIXParameters", "()Ljava/security/cert/PKIXParameters;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "targetCertConstraints", "()Ljava/security/cert/CertSelector;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "certificates", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trustAnchors", "()Ljava/util/Set;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "revocationEnabled", "()Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "explicitPolicyRequired", "()Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "policyMappingInhibited", "()Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "anyPolicyInhibited", "()Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "policyQualifiersRejected", "()Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "certPathCheckers", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "certStores", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "initialPolicies", "()Ljava/util/Set;"));
		}

		[JniSignatureAttribute("Ljava/security/cert/PKIXParameters;", "private final")]
		public Dova.JDK.java.security.cert.PKIXParameters @params_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.PKIXParameters>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/security/cert/CertPath;", "private")]
		public Dova.JDK.java.security.cert.CertPath certPath_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.CertPath>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/List;", "private")]
		public Dova.JDK.java.util.List checkers_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/List;", "private")]
		public Dova.JDK.java.util.List stores_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "private")]
		public bool gotDate_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("Ljava/util/Date;", "private")]
		public Dova.JDK.java.util.Date date_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Date>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private")]
		public Dova.JDK.java.util.Set policies_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "private")]
		public bool gotConstraints_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("Ljava/security/cert/CertSelector;", "private")]
		public Dova.JDK.java.security.cert.CertSelector constraints_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.CertSelector>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private")]
		public Dova.JDK.java.util.Set anchors_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/List;", "private")]
		public Dova.JDK.java.util.List certs_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/security/Timestamp;", "private")]
		public Dova.JDK.java.security.Timestamp timestamp_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.Timestamp>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Date;", "private")]
		public Dova.JDK.java.util.Date timestampDate_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Date>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String variant_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ValidatorParams(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/security/cert/CertPath;Ljava/security/cert/PKIXParameters;)V", "")]
		public ValidatorParams(Dova.JDK.java.security.cert.CertPath arg0, Dova.JDK.java.security.cert.PKIXParameters arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/security/cert/PKIXParameters;)V", "")]
		public ValidatorParams(Dova.JDK.java.security.cert.PKIXParameters arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/provider/certpath/PKIX$ValidatorParams;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/Date;", "")]
		public Dova.JDK.java.util.Date timestamp()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Date>(ret);
		}

		[JniSignatureAttribute("()Ljava/security/cert/CertPath;", "")]
		public Dova.JDK.java.security.cert.CertPath certPath()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.CertPath>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String sigProvider()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Date;", "")]
		public Dova.JDK.java.util.Date date()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Date>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String variant()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/cert/CertPath;)V", "")]
		public void setCertPath(Dova.JDK.java.security.cert.CertPath arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()Ljava/security/cert/PKIXParameters;", "")]
		public Dova.JDK.java.security.cert.PKIXParameters getPKIXParameters()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.PKIXParameters>(ret);
		}

		[JniSignatureAttribute("()Ljava/security/cert/CertSelector;", "")]
		public Dova.JDK.java.security.cert.CertSelector targetCertConstraints()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.CertSelector>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "")]
		public Dova.JDK.java.util.List certificates()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Set;", "")]
		public Dova.JDK.java.util.Set trustAnchors()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool revocationEnabled()
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool explicitPolicyRequired()
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool policyMappingInhibited()
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool anyPolicyInhibited()
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool policyQualifiersRejected()
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/List;", "")]
		public Dova.JDK.java.util.List certPathCheckers()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "")]
		public Dova.JDK.java.util.List certStores()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Set;", "")]
		public Dova.JDK.java.util.Set initialPolicies()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/provider/certpath/PKIX$BuilderParams;", "static")]
	public partial class BuilderParams
		: Dova.JDK.sun.security.provider.certpath.PKIX.ValidatorParams
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BuilderParams()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/provider/certpath/PKIX$BuilderParams;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "params", "Ljava/security/cert/PKIXBuilderParameters;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "stores", "Ljava/util/List;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "targetSubject", "Ljavax/security/auth/x500/X500Principal;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "BuilderParams", "(Ljava/security/cert/PKIXBuilderParameters;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "params", "()Ljava/security/cert/PKIXBuilderParameters;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getTargetSubject", "(Ljava/util/List;Ljava/security/cert/X509CertSelector;)Ljavax/security/auth/x500/X500Principal;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "targetSubject", "()Ljavax/security/auth/x500/X500Principal;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "checkParams", "(Ljava/security/cert/PKIXBuilderParameters;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "maxPathLength", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "certStores", "()Ljava/util/List;"));
		}

		[JniSignatureAttribute("Ljava/security/cert/PKIXBuilderParameters;", "private")]
		public Dova.JDK.java.security.cert.PKIXBuilderParameters @params_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.PKIXBuilderParameters>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/List;", "private")]
		public Dova.JDK.java.util.List stores_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/security/auth/x500/X500Principal;", "private")]
		public Dova.JDK.javax.security.auth.x500.X500Principal targetSubject_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.x500.X500Principal>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BuilderParams(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/security/cert/PKIXBuilderParameters;)V", "")]
		public BuilderParams(Dova.JDK.java.security.cert.PKIXBuilderParameters arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/provider/certpath/PKIX$BuilderParams;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/security/cert/PKIXBuilderParameters;", "")]
		public Dova.JDK.java.security.cert.PKIXBuilderParameters @params()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.PKIXBuilderParameters>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;Ljava/security/cert/X509CertSelector;)Ljavax/security/auth/x500/X500Principal;", "private static")]
		public static Dova.JDK.javax.security.auth.x500.X500Principal getTargetSubject(Dova.JDK.java.util.List arg0, Dova.JDK.java.security.cert.X509CertSelector arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.x500.X500Principal>(ret);
		}

		[JniSignatureAttribute("()Ljavax/security/auth/x500/X500Principal;", "")]
		public Dova.JDK.javax.security.auth.x500.X500Principal targetSubject()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.x500.X500Principal>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/cert/PKIXBuilderParameters;)V", "private")]
		public void checkParams(Dova.JDK.java.security.cert.PKIXBuilderParameters arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()I", "")]
		public int maxPathLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/List;", "")]
		public Dova.JDK.java.util.List certStores()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/provider/certpath/PKIX$CertStoreComparator;", "private static")]
	public partial class CertStoreComparator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Comparator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CertStoreComparator()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/provider/certpath/PKIX$CertStoreComparator;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CertStoreComparator", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "compare", "(Ljava/security/cert/CertStore;Ljava/security/cert/CertStore;)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CertStoreComparator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public CertStoreComparator() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/provider/certpath/PKIX$CertStoreComparator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/security/cert/CertStore;Ljava/security/cert/CertStore;)I", "public")]
		public int compare(Dova.JDK.java.security.cert.CertStore arg0, Dova.JDK.java.security.cert.CertStore arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)I", "public volatile")]
		public int compare(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/security/provider/certpath/PKIX$CertStoreTypeException;", "static")]
	public partial class CertStoreTypeException
		: Dova.JDK.java.security.cert.CertStoreException
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CertStoreTypeException()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/provider/certpath/PKIX$CertStoreTypeException;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "type", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CertStoreTypeException", "(Ljava/lang/String;Ljava/security/cert/CertStoreException;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getType", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String type_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CertStoreTypeException(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/security/cert/CertStoreException;)V", "")]
		public CertStoreTypeException(Dova.JDK.java.lang.String arg0, Dova.JDK.java.security.cert.CertStoreException arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/provider/certpath/PKIX$CertStoreTypeException;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String getType()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}
}
