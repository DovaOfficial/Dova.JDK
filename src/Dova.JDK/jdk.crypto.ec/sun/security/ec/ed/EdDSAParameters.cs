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

namespace Dova.JDK.sun.security.ec.ed;

[JniSignatureAttribute("Lsun/security/ec/ed/EdDSAParameters;", "public")]
public partial class EdDSAParameters
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EdDSAParameters()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/ed/EdDSAParameters;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "namedParams", "Lsun/security/ec/ParametersMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "oid", "Lsun/security/util/ObjectIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "field", "Lsun/security/util/math/IntegerFieldModuloP;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "orderField", "Lsun/security/util/math/IntegerFieldModuloP;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "d", "Lsun/security/util/math/ImmutableIntegerModuloP;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "edOperations", "Lsun/security/ec/ed/EdECOperations;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "digester", "Lsun/security/ec/ed/EdDSAParameters$DigesterFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyLength", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bits", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "logCofactor", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dom", "Ljava/util/function/Function;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "prefixStr25519", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "prefixStr448", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lsun/security/util/ObjectIdentifier;Lsun/security/util/math/IntegerFieldModuloP;Lsun/security/util/math/IntegerFieldModuloP;Lsun/security/util/math/ImmutableIntegerModuloP;Lsun/security/ec/ed/EdECOperations;Lsun/security/ec/ed/EdDSAParameters$DigesterFactory;Ljava/util/function/Function;III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(Ljava/util/function/Function;Lsun/security/x509/AlgorithmId;)Lsun/security/ec/ed/EdDSAParameters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(Ljava/util/function/Function;Ljava/security/spec/AlgorithmParameterSpec;)Lsun/security/ec/ed/EdDSAParameters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getField", "()Lsun/security/util/math/IntegerFieldModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "digest", "([[B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dom", "(Ljava/security/spec/EdDSAParameterSpec;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeyLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEdOperations", "()Lsun/security/ec/ed/EdECOperations;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDigester", "()Lsun/security/ec/ed/EdDSAParameters$Digester;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDigester", "(I)Lsun/security/ec/ed/EdDSAParameters$Digester;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "domImpl", "(Ljava/lang/String;Ljava/security/spec/EdDSAParameterSpec;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getD", "()Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "dom2", "(Ljava/security/spec/EdDSAParameterSpec;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "dom4", "(Ljava/security/spec/EdDSAParameterSpec;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBySize", "(Ljava/util/function/Function;I)Lsun/security/ec/ed/EdDSAParameters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOrderField", "()Lsun/security/util/math/IntegerFieldModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOid", "()Lsun/security/util/ObjectIdentifier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBits", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLogCofactor", "()I"));
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

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/ObjectIdentifier;", "private final")]
	public Dova.JDK.sun.security.util.ObjectIdentifier oid_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.ObjectIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/math/IntegerFieldModuloP;", "private final")]
	public Dova.JDK.sun.security.util.math.IntegerFieldModuloP field_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.IntegerFieldModuloP>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/math/IntegerFieldModuloP;", "private final")]
	public Dova.JDK.sun.security.util.math.IntegerFieldModuloP orderField_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.IntegerFieldModuloP>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/math/ImmutableIntegerModuloP;", "private final")]
	public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP d_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ec/ed/EdECOperations;", "private final")]
	public Dova.JDK.sun.security.ec.ed.EdECOperations edOperations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.ed.EdECOperations>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ec/ed/EdDSAParameters$DigesterFactory;", "private final")]
	public Dova.JDK.sun.security.ec.ed.EdDSAParameters.DigesterFactory digester_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.ed.EdDSAParameters.DigesterFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int keyLength_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int bits_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int logCofactor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/function/Function;", "private final")]
	public Dova.JDK.java.util.function.Function dom_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String prefixStr25519_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String prefixStr448_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EdDSAParameters(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lsun/security/util/ObjectIdentifier;Lsun/security/util/math/IntegerFieldModuloP;Lsun/security/util/math/IntegerFieldModuloP;Lsun/security/util/math/ImmutableIntegerModuloP;Lsun/security/ec/ed/EdECOperations;Lsun/security/ec/ed/EdDSAParameters$DigesterFactory;Ljava/util/function/Function;III)V", "public")]
	public EdDSAParameters(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.security.util.ObjectIdentifier arg1, Dova.JDK.sun.security.util.math.IntegerFieldModuloP arg2, Dova.JDK.sun.security.util.math.IntegerFieldModuloP arg3, Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP arg4, Dova.JDK.sun.security.ec.ed.EdECOperations arg5, Dova.JDK.sun.security.ec.ed.EdDSAParameters.DigesterFactory arg6, Dova.JDK.java.util.function.Function arg7, int arg8, int arg9, int arg10) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ec/ed/EdDSAParameters;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Lsun/security/x509/AlgorithmId;)Lsun/security/ec/ed/EdDSAParameters;", "public static")]
	public static Dova.JDK.sun.security.ec.ed.EdDSAParameters get(Dova.JDK.java.util.function.Function arg0, Dova.JDK.sun.security.x509.AlgorithmId arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.ed.EdDSAParameters>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/security/spec/AlgorithmParameterSpec;)Lsun/security/ec/ed/EdDSAParameters;", "public static")]
	public static Dova.JDK.sun.security.ec.ed.EdDSAParameters get(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.ed.EdDSAParameters>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/IntegerFieldModuloP;", "public")]
	public Dova.JDK.sun.security.util.math.IntegerFieldModuloP getField()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.IntegerFieldModuloP>(ret);
	}

	[JniSignatureAttribute("([[B)[B", "public transient")]
	public JavaArray<byte> digest(JavaArray<JavaArray<byte>> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/spec/EdDSAParameterSpec;)[B", "public")]
	public JavaArray<byte> dom(Dova.JDK.java.security.spec.EdDSAParameterSpec arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getKeyLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/security/ec/ed/EdECOperations;", "public")]
	public Dova.JDK.sun.security.ec.ed.EdECOperations getEdOperations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.ed.EdECOperations>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/ec/ed/EdDSAParameters$Digester;", "public")]
	public Dova.JDK.sun.security.ec.ed.EdDSAParameters.Digester createDigester()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.ed.EdDSAParameters.Digester>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/security/ec/ed/EdDSAParameters$Digester;", "public")]
	public Dova.JDK.sun.security.ec.ed.EdDSAParameters.Digester createDigester(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.ed.EdDSAParameters.Digester>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/security/spec/EdDSAParameterSpec;)[B", "static")]
	public static JavaArray<byte> domImpl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.security.spec.EdDSAParameterSpec arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/ImmutableIntegerModuloP;", "public")]
	public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP getD()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/spec/EdDSAParameterSpec;)[B", "static")]
	public static JavaArray<byte> dom2(Dova.JDK.java.security.spec.EdDSAParameterSpec arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/spec/EdDSAParameterSpec;)[B", "static")]
	public static JavaArray<byte> dom4(Dova.JDK.java.security.spec.EdDSAParameterSpec arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;I)Lsun/security/ec/ed/EdDSAParameters;", "public static")]
	public static Dova.JDK.sun.security.ec.ed.EdDSAParameters getBySize(Dova.JDK.java.util.function.Function arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.ed.EdDSAParameters>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/math/IntegerFieldModuloP;", "public")]
	public Dova.JDK.sun.security.util.math.IntegerFieldModuloP getOrderField()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.IntegerFieldModuloP>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/util/ObjectIdentifier;", "public")]
	public Dova.JDK.sun.security.util.ObjectIdentifier getOid()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.ObjectIdentifier>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getBits()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getLogCofactor()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("Lsun/security/ec/ed/EdDSAParameters$DigesterFactory;", "public abstract static interface")]
	public partial interface DigesterFactory
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DigesterFactory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/ed/EdDSAParameters$DigesterFactory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "digest", "([[B)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDigester", "(I)Lsun/security/ec/ed/EdDSAParameters$Digester;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDigester", "()Lsun/security/ec/ed/EdDSAParameters$Digester;"));
		}

		[JniSignatureAttribute("([[B)[B", "public transient")]
		JavaArray<byte> digest(JavaArray<JavaArray<byte>> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(I)Lsun/security/ec/ed/EdDSAParameters$Digester;", "public")]
		Dova.JDK.sun.security.ec.ed.EdDSAParameters.Digester createDigester(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.ed.EdDSAParameters.Digester>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/ec/ed/EdDSAParameters$Digester;", "public abstract")]
		Dova.JDK.sun.security.ec.ed.EdDSAParameters.Digester createDigester()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.ed.EdDSAParameters.Digester>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ec/ed/EdDSAParameters$Digester;", "public abstract static interface")]
	public partial interface Digester
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Digester()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/ed/EdDSAParameters$Digester;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "(B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "([BII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "digest", "()[B"));
		}

		[JniSignatureAttribute("(B)V", "public abstract")]
		void update(byte arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("([BII)V", "public abstract")]
		void update(JavaArray<byte> arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()[B", "public abstract")]
		JavaArray<byte> digest()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ec/ed/EdDSAParameters$SHA512DigesterFactory;", "private static")]
	public partial class SHA512DigesterFactory
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ec.ed.EdDSAParameters.DigesterFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SHA512DigesterFactory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/ed/EdDSAParameters$SHA512DigesterFactory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDigester", "()Lsun/security/ec/ed/EdDSAParameters$Digester;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SHA512DigesterFactory(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SHA512DigesterFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ec/ed/EdDSAParameters$SHA512DigesterFactory;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lsun/security/ec/ed/EdDSAParameters$Digester;", "public")]
		public Dova.JDK.sun.security.ec.ed.EdDSAParameters.Digester createDigester()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.ed.EdDSAParameters.Digester>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ec/ed/EdDSAParameters$SHAKE256DigesterFactory;", "private static")]
	public partial class SHAKE256DigesterFactory
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ec.ed.EdDSAParameters.DigesterFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SHAKE256DigesterFactory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/ed/EdDSAParameters$SHAKE256DigesterFactory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDigester", "()Lsun/security/ec/ed/EdDSAParameters$Digester;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDigester", "(I)Lsun/security/ec/ed/EdDSAParameters$Digester;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SHAKE256DigesterFactory(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SHAKE256DigesterFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ec/ed/EdDSAParameters$SHAKE256DigesterFactory;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lsun/security/ec/ed/EdDSAParameters$Digester;", "public")]
		public Dova.JDK.sun.security.ec.ed.EdDSAParameters.Digester createDigester()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.ed.EdDSAParameters.Digester>(ret);
		}

		[JniSignatureAttribute("(I)Lsun/security/ec/ed/EdDSAParameters$Digester;", "public")]
		public Dova.JDK.sun.security.ec.ed.EdDSAParameters.Digester createDigester(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.ed.EdDSAParameters.Digester>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ec/ed/EdDSAParameters$SHAKE256Digester;", "private static")]
	public partial class SHAKE256Digester
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ec.ed.EdDSAParameters.Digester
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SHAKE256Digester()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/ed/EdDSAParameters$SHAKE256Digester;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "md", "Lsun/security/provider/SHAKE256;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "([BII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "(B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "digest", "()[B"));
		}

		[JniSignatureAttribute("Lsun/security/provider/SHAKE256;", "")]
		public Dova.JDK.sun.security.provider.SHAKE256 md_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.SHAKE256>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SHAKE256Digester(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "")]
		public SHAKE256Digester(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ec/ed/EdDSAParameters$SHAKE256Digester;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([BII)V", "public")]
		public void update(JavaArray<byte> arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(B)V", "public")]
		public void update(byte arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()[B", "public")]
		public JavaArray<byte> digest()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ec/ed/EdDSAParameters$MessageDigester;", "private static")]
	public partial class MessageDigester
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ec.ed.EdDSAParameters.Digester
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MessageDigester()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/ed/EdDSAParameters$MessageDigester;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "md", "Ljava/security/MessageDigest;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/MessageDigest;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "([BII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "(B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "digest", "()[B"));
		}

		[JniSignatureAttribute("Ljava/security/MessageDigest;", "private final")]
		public Dova.JDK.java.security.MessageDigest md_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.MessageDigest>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MessageDigester(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/security/MessageDigest;)V", "private")]
		public MessageDigester(Dova.JDK.java.security.MessageDigest arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ec/ed/EdDSAParameters$MessageDigester;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([BII)V", "public")]
		public void update(JavaArray<byte> arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(B)V", "public")]
		public void update(byte arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()[B", "public")]
		public JavaArray<byte> digest()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
	}
}
