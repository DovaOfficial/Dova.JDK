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

namespace Dova.JDK.sun.security.ec;

[JniSignatureAttribute("Lsun/security/ec/XECParameters;", "public")]
public partial class XECParameters
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XECParameters()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/XECParameters;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "namedParams", "Lsun/security/ec/ParametersMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "oid", "Lsun/security/util/ObjectIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bits", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "p", "Ljava/math/BigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "logCofactor", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "a24", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "basePoint", "B"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/math/BigInteger;IBILsun/security/util/ObjectIdentifier;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(Ljava/util/function/Function;Ljava/security/spec/AlgorithmParameterSpec;)Lsun/security/ec/XECParameters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(Ljava/util/function/Function;Lsun/security/x509/AlgorithmId;)Lsun/security/ec/XECParameters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBytes", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getP", "()Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBySize", "(Ljava/util/function/Function;I)Lsun/security/ec/XECParameters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOid", "()Lsun/security/util/ObjectIdentifier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addParameters", "(ILjava/math/BigInteger;IBILjava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBits", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLogCofactor", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getA24", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBasePoint", "()B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "oidEquals", "(Lsun/security/ec/XECParameters;)Z"));
	}

	[JniSignatureAttribute("Lsun/security/ec/ParametersMap;", "static")]
	public static Dova.JDK.sun.security.ec.ParametersMap namedParams_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.ParametersMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/ObjectIdentifier;", "private final")]
	public Dova.JDK.sun.security.util.ObjectIdentifier oid_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.ObjectIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int bits_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljava/math/BigInteger;", "private final")]
	public Dova.JDK.java.math.BigInteger p_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int logCofactor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int a24_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("B", "private final")]
	public byte basePoint_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XECParameters(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILjava/math/BigInteger;IBILsun/security/util/ObjectIdentifier;Ljava/lang/String;)V", "public")]
	public XECParameters(int arg0, Dova.JDK.java.math.BigInteger arg1, int arg2, byte arg3, int arg4, Dova.JDK.sun.security.util.ObjectIdentifier arg5, Dova.JDK.java.lang.String arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ec/XECParameters;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/security/spec/AlgorithmParameterSpec;)Lsun/security/ec/XECParameters;", "public static")]
	public static Dova.JDK.sun.security.ec.XECParameters get(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.XECParameters>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Lsun/security/x509/AlgorithmId;)Lsun/security/ec/XECParameters;", "public static")]
	public static Dova.JDK.sun.security.ec.XECParameters get(Dova.JDK.java.util.function.Function arg0, Dova.JDK.sun.security.x509.AlgorithmId arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.XECParameters>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getBytes()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/math/BigInteger;", "public")]
	public Dova.JDK.java.math.BigInteger getP()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;I)Lsun/security/ec/XECParameters;", "public static")]
	public static Dova.JDK.sun.security.ec.XECParameters getBySize(Dova.JDK.java.util.function.Function arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.XECParameters>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/ObjectIdentifier;", "public")]
	public Dova.JDK.sun.security.util.ObjectIdentifier getOid()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.ObjectIdentifier>(ret);
	}

	[JniSignatureAttribute("(ILjava/math/BigInteger;IBILjava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;)V", "private static")]
	public static void addParameters(int arg0, Dova.JDK.java.math.BigInteger arg1, int arg2, byte arg3, int arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.java.lang.String arg6, Dova.JDK.java.util.Map arg7, Dova.JDK.java.util.Map arg8, Dova.JDK.java.util.Map arg9)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getBits()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getLogCofactor()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getA24()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()B", "public")]
	public byte getBasePoint()
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/ec/XECParameters;)Z", "")]
	public bool oidEquals(Dova.JDK.sun.security.ec.XECParameters arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}
}
