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

namespace Dova.JDK.com.sun.crypto.provider;

[JniSignatureAttribute("Lcom/sun/crypto/provider/PBEKeyFactory;", "abstract")]
public partial class PBEKeyFactory
	: Dova.JDK.javax.crypto.SecretKeyFactorySpi
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PBEKeyFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/PBEKeyFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "type", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "validTypes", "Ljava/util/HashSet;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PBEKeyFactory", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "engineGetKeySpec", "(Ljavax/crypto/SecretKey;Ljava/lang/Class;)Ljava/security/spec/KeySpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "engineTranslateKey", "(Ljavax/crypto/SecretKey;)Ljavax/crypto/SecretKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "engineGenerateSecret", "(Ljava/security/spec/KeySpec;)Ljavax/crypto/SecretKey;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String type_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashSet;", "private static")]
	public static Dova.JDK.java.util.HashSet validTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PBEKeyFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public PBEKeyFactory(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/PBEKeyFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/crypto/SecretKey;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", "protected")]
	public Dova.JDK.java.security.spec.KeySpec engineGetKeySpec(Dova.JDK.javax.crypto.SecretKey arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.KeySpec>(ret);
	}

	[JniSignatureAttribute("(Ljavax/crypto/SecretKey;)Ljavax/crypto/SecretKey;", "protected")]
	public Dova.JDK.javax.crypto.SecretKey engineTranslateKey(Dova.JDK.javax.crypto.SecretKey arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/spec/KeySpec;)Ljavax/crypto/SecretKey;", "protected")]
	public Dova.JDK.javax.crypto.SecretKey engineGenerateSecret(Dova.JDK.java.security.spec.KeySpec arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA512AndAES_256;", "public static final")]
	public partial class PBEWithHmacSHA512AndAES_256
		: Dova.JDK.com.sun.crypto.provider.PBEKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PBEWithHmacSHA512AndAES_256()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA512AndAES_256;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PBEWithHmacSHA512AndAES_256", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PBEWithHmacSHA512AndAES_256(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PBEWithHmacSHA512AndAES_256() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA512AndAES_256;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA384AndAES_256;", "public static final")]
	public partial class PBEWithHmacSHA384AndAES_256
		: Dova.JDK.com.sun.crypto.provider.PBEKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PBEWithHmacSHA384AndAES_256()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA384AndAES_256;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PBEWithHmacSHA384AndAES_256", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PBEWithHmacSHA384AndAES_256(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PBEWithHmacSHA384AndAES_256() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA384AndAES_256;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA256AndAES_256;", "public static final")]
	public partial class PBEWithHmacSHA256AndAES_256
		: Dova.JDK.com.sun.crypto.provider.PBEKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PBEWithHmacSHA256AndAES_256()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA256AndAES_256;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PBEWithHmacSHA256AndAES_256", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PBEWithHmacSHA256AndAES_256(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PBEWithHmacSHA256AndAES_256() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA256AndAES_256;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA224AndAES_256;", "public static final")]
	public partial class PBEWithHmacSHA224AndAES_256
		: Dova.JDK.com.sun.crypto.provider.PBEKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PBEWithHmacSHA224AndAES_256()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA224AndAES_256;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PBEWithHmacSHA224AndAES_256", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PBEWithHmacSHA224AndAES_256(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PBEWithHmacSHA224AndAES_256() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA224AndAES_256;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA1AndAES_256;", "public static final")]
	public partial class PBEWithHmacSHA1AndAES_256
		: Dova.JDK.com.sun.crypto.provider.PBEKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PBEWithHmacSHA1AndAES_256()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA1AndAES_256;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PBEWithHmacSHA1AndAES_256", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PBEWithHmacSHA1AndAES_256(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PBEWithHmacSHA1AndAES_256() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA1AndAES_256;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA512AndAES_128;", "public static final")]
	public partial class PBEWithHmacSHA512AndAES_128
		: Dova.JDK.com.sun.crypto.provider.PBEKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PBEWithHmacSHA512AndAES_128()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA512AndAES_128;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PBEWithHmacSHA512AndAES_128", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PBEWithHmacSHA512AndAES_128(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PBEWithHmacSHA512AndAES_128() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA512AndAES_128;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA384AndAES_128;", "public static final")]
	public partial class PBEWithHmacSHA384AndAES_128
		: Dova.JDK.com.sun.crypto.provider.PBEKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PBEWithHmacSHA384AndAES_128()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA384AndAES_128;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PBEWithHmacSHA384AndAES_128", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PBEWithHmacSHA384AndAES_128(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PBEWithHmacSHA384AndAES_128() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA384AndAES_128;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA256AndAES_128;", "public static final")]
	public partial class PBEWithHmacSHA256AndAES_128
		: Dova.JDK.com.sun.crypto.provider.PBEKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PBEWithHmacSHA256AndAES_128()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA256AndAES_128;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PBEWithHmacSHA256AndAES_128", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PBEWithHmacSHA256AndAES_128(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PBEWithHmacSHA256AndAES_128() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA256AndAES_128;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA224AndAES_128;", "public static final")]
	public partial class PBEWithHmacSHA224AndAES_128
		: Dova.JDK.com.sun.crypto.provider.PBEKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PBEWithHmacSHA224AndAES_128()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA224AndAES_128;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PBEWithHmacSHA224AndAES_128", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PBEWithHmacSHA224AndAES_128(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PBEWithHmacSHA224AndAES_128() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA224AndAES_128;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA1AndAES_128;", "public static final")]
	public partial class PBEWithHmacSHA1AndAES_128
		: Dova.JDK.com.sun.crypto.provider.PBEKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PBEWithHmacSHA1AndAES_128()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA1AndAES_128;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PBEWithHmacSHA1AndAES_128", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PBEWithHmacSHA1AndAES_128(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PBEWithHmacSHA1AndAES_128() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithHmacSHA1AndAES_128;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithMD5AndTripleDES;", "public static final")]
	public partial class PBEWithMD5AndTripleDES
		: Dova.JDK.com.sun.crypto.provider.PBEKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PBEWithMD5AndTripleDES()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithMD5AndTripleDES;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PBEWithMD5AndTripleDES", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PBEWithMD5AndTripleDES(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PBEWithMD5AndTripleDES() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithMD5AndTripleDES;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithSHA1AndRC4_128;", "public static final")]
	public partial class PBEWithSHA1AndRC4_128
		: Dova.JDK.com.sun.crypto.provider.PBEKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PBEWithSHA1AndRC4_128()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithSHA1AndRC4_128;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PBEWithSHA1AndRC4_128", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PBEWithSHA1AndRC4_128(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PBEWithSHA1AndRC4_128() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithSHA1AndRC4_128;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithSHA1AndRC4_40;", "public static final")]
	public partial class PBEWithSHA1AndRC4_40
		: Dova.JDK.com.sun.crypto.provider.PBEKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PBEWithSHA1AndRC4_40()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithSHA1AndRC4_40;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PBEWithSHA1AndRC4_40", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PBEWithSHA1AndRC4_40(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PBEWithSHA1AndRC4_40() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithSHA1AndRC4_40;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithSHA1AndRC2_128;", "public static final")]
	public partial class PBEWithSHA1AndRC2_128
		: Dova.JDK.com.sun.crypto.provider.PBEKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PBEWithSHA1AndRC2_128()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithSHA1AndRC2_128;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PBEWithSHA1AndRC2_128", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PBEWithSHA1AndRC2_128(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PBEWithSHA1AndRC2_128() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithSHA1AndRC2_128;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithSHA1AndRC2_40;", "public static final")]
	public partial class PBEWithSHA1AndRC2_40
		: Dova.JDK.com.sun.crypto.provider.PBEKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PBEWithSHA1AndRC2_40()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithSHA1AndRC2_40;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PBEWithSHA1AndRC2_40", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PBEWithSHA1AndRC2_40(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PBEWithSHA1AndRC2_40() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithSHA1AndRC2_40;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithSHA1AndDESede;", "public static final")]
	public partial class PBEWithSHA1AndDESede
		: Dova.JDK.com.sun.crypto.provider.PBEKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PBEWithSHA1AndDESede()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithSHA1AndDESede;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PBEWithSHA1AndDESede", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PBEWithSHA1AndDESede(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PBEWithSHA1AndDESede() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithSHA1AndDESede;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithMD5AndDES;", "public static final")]
	public partial class PBEWithMD5AndDES
		: Dova.JDK.com.sun.crypto.provider.PBEKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PBEWithMD5AndDES()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithMD5AndDES;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PBEWithMD5AndDES", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PBEWithMD5AndDES(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PBEWithMD5AndDES() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/PBEKeyFactory$PBEWithMD5AndDES;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
