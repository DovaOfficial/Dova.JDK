/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.security.pkcs11.wrapper;

[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "public")]
public partial class CK_ATTRIBUTE
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CK_ATTRIBUTE()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TOKEN_FALSE", "Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SENSITIVE_FALSE", "Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXTRACTABLE_TRUE", "Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENCRYPT_TRUE", "Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DECRYPT_TRUE", "Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WRAP_TRUE", "Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNWRAP_TRUE", "Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIGN_TRUE", "Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VERIFY_TRUE", "Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIGN_RECOVER_TRUE", "Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VERIFY_RECOVER_TRUE", "Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DERIVE_TRUE", "Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENCRYPT_NULL", "Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DECRYPT_NULL", "Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WRAP_NULL", "Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNWRAP_NULL", "Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pValue", "Ljava/lang/Object;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JLjava/math/BigInteger;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JJ)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JZ)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JLjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBoolean", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBigInteger", "()Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharArray", "()[C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByteArray", "()[B"));
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "public static final")]
	public static Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE TOKEN_FALSE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "public static final")]
	public static Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE SENSITIVE_FALSE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "public static final")]
	public static Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE EXTRACTABLE_TRUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "public static final")]
	public static Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE ENCRYPT_TRUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "public static final")]
	public static Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE DECRYPT_TRUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "public static final")]
	public static Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE WRAP_TRUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "public static final")]
	public static Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE UNWRAP_TRUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "public static final")]
	public static Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE SIGN_TRUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "public static final")]
	public static Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE VERIFY_TRUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "public static final")]
	public static Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE SIGN_RECOVER_TRUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "public static final")]
	public static Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE VERIFY_RECOVER_TRUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "public static final")]
	public static Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE DERIVE_TRUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "public static final")]
	public static Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE ENCRYPT_NULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "public static final")]
	public static Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE DECRYPT_NULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "public static final")]
	public static Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE WRAP_NULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "public static final")]
	public static Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE UNWRAP_NULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "public")]
	public long type_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object pValue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CK_ATTRIBUTE(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(JLjava/math/BigInteger;)V", "public")]
	public CK_ATTRIBUTE(long arg0, Dova.JDK.java.math.BigInteger arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(JJ)V", "public")]
	public CK_ATTRIBUTE(long arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(JZ)V", "public")]
	public CK_ATTRIBUTE(long arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CK_ATTRIBUTE() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3]))
	{
	}

	[JniSignatureAttribute("(J)V", "public")]
	public CK_ATTRIBUTE(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0))
	{
	}

	[JniSignatureAttribute("(JLjava/lang/Object;)V", "public")]
	public CK_ATTRIBUTE(long arg0, Dova.JDK.java.lang.Object arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[5], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getBoolean()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getLong()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/math/BigInteger;", "public")]
	public Dova.JDK.java.math.BigInteger getBigInteger()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("()[C", "public")]
	public JavaArray<char> getCharArray()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
	}

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> getByteArray()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}
}
