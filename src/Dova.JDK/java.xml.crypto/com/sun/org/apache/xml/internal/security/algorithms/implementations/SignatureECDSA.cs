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

namespace Dova.JDK.com.sun.org.apache.xml.@internal.security.algorithms.implementations;

[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA;", "public abstract")]
public partial class SignatureECDSA
	: Dova.JDK.com.sun.org.apache.xml.@internal.security.algorithms.SignatureAlgorithmSpi
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SignatureECDSA()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOG", "Lcom/sun/org/slf4j/internal/Logger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureAlgorithm", "Ljava/security/Signature;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signIntLen", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/Provider;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineUpdate", "([BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineUpdate", "(B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineUpdate", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineSetParameter", "(Ljava/security/spec/AlgorithmParameterSpec;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineVerify", "([B)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInitSign", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInitSign", "(Ljava/security/Key;Ljava/security/SecureRandom;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInitSign", "(Ljava/security/Key;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInitVerify", "(Ljava/security/Key;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineSign", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineSetHMACOutputLength", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetJCEAlgorithmString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetJCEProviderName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertASN1toXMLDSIG", "([BI)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertXMLDSIGtoASN1", "([B)[B"));
	}

	[JniSignatureAttribute("Lcom/sun/org/slf4j/internal/Logger;", "private static final")]
	public static Dova.JDK.com.sun.org.slf4j.@internal.Logger LOG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.slf4j.@internal.Logger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/Signature;", "private final")]
	public Dova.JDK.java.security.Signature signatureAlgorithm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.Signature>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int signIntLen_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SignatureECDSA(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/security/Provider;)V", "public")]
	public SignatureECDSA(Dova.JDK.java.security.Provider arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SignatureECDSA() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([BII)V", "protected")]
	public void engineUpdate(JavaArray<byte> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(B)V", "protected")]
	public void engineUpdate(byte arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("([B)V", "protected")]
	public void engineUpdate(JavaArray<byte> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/security/spec/AlgorithmParameterSpec;)V", "protected")]
	public void engineSetParameter(Dova.JDK.java.security.spec.AlgorithmParameterSpec arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("([B)Z", "protected")]
	public bool engineVerify(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", "protected")]
	public void engineInitSign(Dova.JDK.java.security.Key arg0, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/security/Key;Ljava/security/SecureRandom;)V", "protected")]
	public void engineInitSign(Dova.JDK.java.security.Key arg0, Dova.JDK.java.security.SecureRandom arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/security/Key;)V", "protected")]
	public void engineInitSign(Dova.JDK.java.security.Key arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljava/security/Key;)V", "protected")]
	public void engineInitVerify(Dova.JDK.java.security.Key arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()[B", "protected")]
	public JavaArray<byte> engineSign()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void engineSetHMACOutputLength(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String engineGetJCEAlgorithmString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String engineGetJCEProviderName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([BI)[B", "public static")]
	public static JavaArray<byte> convertASN1toXMLDSIG(JavaArray<byte> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B)[B", "public static")]
	public static JavaArray<byte> convertXMLDSIGtoASN1(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA$SignatureECDSARIPEMD160;", "public static")]
	public partial class SignatureECDSARIPEMD160
		: Dova.JDK.com.sun.org.apache.xml.@internal.security.algorithms.implementations.SignatureECDSA
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SignatureECDSARIPEMD160()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA$SignatureECDSARIPEMD160;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/Provider;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetURI", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SignatureECDSARIPEMD160(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public SignatureECDSARIPEMD160() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/security/Provider;)V", "public")]
		public SignatureECDSARIPEMD160(Dova.JDK.java.security.Provider arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA$SignatureECDSARIPEMD160;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String engineGetURI()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA$SignatureECDSASHA512;", "public static")]
	public partial class SignatureECDSASHA512
		: Dova.JDK.com.sun.org.apache.xml.@internal.security.algorithms.implementations.SignatureECDSA
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SignatureECDSASHA512()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA$SignatureECDSASHA512;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/Provider;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetURI", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SignatureECDSASHA512(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public SignatureECDSASHA512() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/security/Provider;)V", "public")]
		public SignatureECDSASHA512(Dova.JDK.java.security.Provider arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA$SignatureECDSASHA512;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String engineGetURI()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA$SignatureECDSASHA384;", "public static")]
	public partial class SignatureECDSASHA384
		: Dova.JDK.com.sun.org.apache.xml.@internal.security.algorithms.implementations.SignatureECDSA
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SignatureECDSASHA384()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA$SignatureECDSASHA384;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/Provider;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetURI", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SignatureECDSASHA384(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public SignatureECDSASHA384() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/security/Provider;)V", "public")]
		public SignatureECDSASHA384(Dova.JDK.java.security.Provider arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA$SignatureECDSASHA384;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String engineGetURI()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA$SignatureECDSASHA256;", "public static")]
	public partial class SignatureECDSASHA256
		: Dova.JDK.com.sun.org.apache.xml.@internal.security.algorithms.implementations.SignatureECDSA
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SignatureECDSASHA256()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA$SignatureECDSASHA256;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/Provider;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetURI", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SignatureECDSASHA256(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public SignatureECDSASHA256() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/security/Provider;)V", "public")]
		public SignatureECDSASHA256(Dova.JDK.java.security.Provider arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA$SignatureECDSASHA256;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String engineGetURI()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA$SignatureECDSASHA224;", "public static")]
	public partial class SignatureECDSASHA224
		: Dova.JDK.com.sun.org.apache.xml.@internal.security.algorithms.implementations.SignatureECDSA
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SignatureECDSASHA224()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA$SignatureECDSASHA224;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/Provider;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetURI", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SignatureECDSASHA224(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public SignatureECDSASHA224() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/security/Provider;)V", "public")]
		public SignatureECDSASHA224(Dova.JDK.java.security.Provider arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA$SignatureECDSASHA224;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String engineGetURI()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA$SignatureECDSASHA1;", "public static")]
	public partial class SignatureECDSASHA1
		: Dova.JDK.com.sun.org.apache.xml.@internal.security.algorithms.implementations.SignatureECDSA
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SignatureECDSASHA1()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA$SignatureECDSASHA1;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/Provider;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetURI", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SignatureECDSASHA1(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public SignatureECDSASHA1() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/security/Provider;)V", "public")]
		public SignatureECDSASHA1(Dova.JDK.java.security.Provider arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/security/algorithms/implementations/SignatureECDSA$SignatureECDSASHA1;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String engineGetURI()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}
}
