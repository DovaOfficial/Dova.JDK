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

namespace Dova.JDK.sun.security.provider.certpath;

[JniSignatureAttribute("Lsun/security/provider/certpath/ResponderId;", "public final")]
public partial class ResponderId
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ResponderId()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/provider/certpath/ResponderId;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lsun/security/provider/certpath/ResponderId$Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "responderName", "Ljavax/security/auth/x500/X500Principal;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "responderKeyId", "Lsun/security/x509/KeyIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "encodedRid", "[B"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([B)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/PublicKey;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/security/auth/x500/X500Principal;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "length", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lsun/security/provider/certpath/ResponderId$Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEncoded", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResponderName", "()Ljavax/security/auth/x500/X500Principal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeyIdentifier", "()Lsun/security/x509/KeyIdentifier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "principalToBytes", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "keyIdToBytes", "()[B"));
	}

	[JniSignatureAttribute("Lsun/security/provider/certpath/ResponderId$Type;", "private")]
	public Dova.JDK.sun.security.provider.certpath.ResponderId.Type type_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.ResponderId.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/security/auth/x500/X500Principal;", "private")]
	public Dova.JDK.javax.security.auth.x500.X500Principal responderName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.x500.X500Principal>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/x509/KeyIdentifier;", "private")]
	public Dova.JDK.sun.security.x509.KeyIdentifier responderKeyId_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.x509.KeyIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "private")]
	public JavaArray<byte> encodedRid_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ResponderId(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([B)V", "public")]
	public ResponderId(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/security/PublicKey;)V", "public")]
	public ResponderId(Dova.JDK.java.security.PublicKey arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Ljavax/security/auth/x500/X500Principal;)V", "public")]
	public ResponderId(Dova.JDK.javax.security.auth.x500.X500Principal arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/provider/certpath/ResponderId;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int length()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/security/provider/certpath/ResponderId$Type;", "public")]
	public Dova.JDK.sun.security.provider.certpath.ResponderId.Type getType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.ResponderId.Type>(ret);
	}

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> getEncoded()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Ljavax/security/auth/x500/X500Principal;", "public")]
	public Dova.JDK.javax.security.auth.x500.X500Principal getResponderName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.x500.X500Principal>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/x509/KeyIdentifier;", "public")]
	public Dova.JDK.sun.security.x509.KeyIdentifier getKeyIdentifier()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.x509.KeyIdentifier>(ret);
	}

	[JniSignatureAttribute("()[B", "private")]
	public JavaArray<byte> principalToBytes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()[B", "private")]
	public JavaArray<byte> keyIdToBytes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("Lsun/security/provider/certpath/ResponderId$Type;", "public static final")]
	public partial class Type
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Type()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/provider/certpath/ResponderId$Type;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BY_NAME", "Lsun/security/provider/certpath/ResponderId$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BY_KEY", "Lsun/security/provider/certpath/ResponderId$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tagNumber", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ridTypeName", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/security/provider/certpath/ResponderId$Type;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/security/provider/certpath/ResponderId$Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/provider/certpath/ResponderId$Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/security/provider/certpath/ResponderId$Type;"));
		}

		[JniSignatureAttribute("Lsun/security/provider/certpath/ResponderId$Type;", "public static final")]
		public static Dova.JDK.sun.security.provider.certpath.ResponderId.Type BY_NAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.ResponderId.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/provider/certpath/ResponderId$Type;", "public static final")]
		public static Dova.JDK.sun.security.provider.certpath.ResponderId.Type BY_KEY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.ResponderId.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int tagNumber_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String ridTypeName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lsun/security/provider/certpath/ResponderId$Type;", "private static final")]
		public static JavaArray<Dova.JDK.sun.security.provider.certpath.ResponderId.Type> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.provider.certpath.ResponderId.Type>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Type(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;IILjava/lang/String;)V", "private")]
		public Type(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/provider/certpath/ResponderId$Type;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int value()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()[Lsun/security/provider/certpath/ResponderId$Type;", "public static")]
		public static JavaArray<Dova.JDK.sun.security.provider.certpath.ResponderId.Type> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.provider.certpath.ResponderId.Type>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/provider/certpath/ResponderId$Type;", "public static")]
		public static Dova.JDK.sun.security.provider.certpath.ResponderId.Type valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.ResponderId.Type>(ret);
		}

		[JniSignatureAttribute("()[Lsun/security/provider/certpath/ResponderId$Type;", "private static")]
		public static JavaArray<Dova.JDK.sun.security.provider.certpath.ResponderId.Type> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.provider.certpath.ResponderId.Type>>(ret);
		}
	}
}
