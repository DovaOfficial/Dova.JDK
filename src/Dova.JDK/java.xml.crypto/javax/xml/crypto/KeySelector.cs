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

namespace Dova.JDK.javax.xml.crypto;

[JniSignatureAttribute("Ljavax/xml/crypto/KeySelector;", "public abstract")]
public partial class KeySelector
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KeySelector()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/crypto/KeySelector;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "singletonKeySelector", "(Ljava/security/Key;)Ljavax/xml/crypto/KeySelector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "select", "(Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;Ljavax/xml/crypto/KeySelector$Purpose;Ljavax/xml/crypto/AlgorithmMethod;Ljavax/xml/crypto/XMLCryptoContext;)Ljavax/xml/crypto/KeySelectorResult;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KeySelector(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public KeySelector() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/xml/crypto/KeySelector;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/security/Key;)Ljavax/xml/crypto/KeySelector;", "public static")]
	public static Dova.JDK.javax.xml.crypto.KeySelector singletonKeySelector(Dova.JDK.java.security.Key arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.KeySelector>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;Ljavax/xml/crypto/KeySelector$Purpose;Ljavax/xml/crypto/AlgorithmMethod;Ljavax/xml/crypto/XMLCryptoContext;)Ljavax/xml/crypto/KeySelectorResult;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.KeySelectorResult select(Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfo arg0, Dova.JDK.javax.xml.crypto.KeySelector.Purpose arg1, Dova.JDK.javax.xml.crypto.AlgorithmMethod arg2, Dova.JDK.javax.xml.crypto.XMLCryptoContext arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.KeySelectorResult>(ret);
	}

	[JniSignatureAttribute("Ljavax/xml/crypto/KeySelector$SingletonKeySelector;", "private static")]
	public partial class SingletonKeySelector
		: Dova.JDK.javax.xml.crypto.KeySelector
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SingletonKeySelector()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/crypto/KeySelector$SingletonKeySelector;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Ljava/security/Key;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/Key;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "select", "(Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;Ljavax/xml/crypto/KeySelector$Purpose;Ljavax/xml/crypto/AlgorithmMethod;Ljavax/xml/crypto/XMLCryptoContext;)Ljavax/xml/crypto/KeySelectorResult;"));
		}

		[JniSignatureAttribute("Ljava/security/Key;", "private final")]
		public Dova.JDK.java.security.Key key_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.Key>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SingletonKeySelector(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/security/Key;)V", "")]
		public SingletonKeySelector(Dova.JDK.java.security.Key arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/xml/crypto/KeySelector$SingletonKeySelector;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;Ljavax/xml/crypto/KeySelector$Purpose;Ljavax/xml/crypto/AlgorithmMethod;Ljavax/xml/crypto/XMLCryptoContext;)Ljavax/xml/crypto/KeySelectorResult;", "public")]
		public Dova.JDK.javax.xml.crypto.KeySelectorResult select(Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfo arg0, Dova.JDK.javax.xml.crypto.KeySelector.Purpose arg1, Dova.JDK.javax.xml.crypto.AlgorithmMethod arg2, Dova.JDK.javax.xml.crypto.XMLCryptoContext arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.KeySelectorResult>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/xml/crypto/KeySelector$Purpose;", "public static")]
	public partial class Purpose
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Purpose()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/crypto/KeySelector$Purpose;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIGN", "Ljavax/xml/crypto/KeySelector$Purpose;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VERIFY", "Ljavax/xml/crypto/KeySelector$Purpose;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENCRYPT", "Ljavax/xml/crypto/KeySelector$Purpose;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DECRYPT", "Ljavax/xml/crypto/KeySelector$Purpose;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
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

		[JniSignatureAttribute("Ljavax/xml/crypto/KeySelector$Purpose;", "public static final")]
		public static Dova.JDK.javax.xml.crypto.KeySelector.Purpose SIGN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.KeySelector.Purpose>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/xml/crypto/KeySelector$Purpose;", "public static final")]
		public static Dova.JDK.javax.xml.crypto.KeySelector.Purpose VERIFY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.KeySelector.Purpose>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/xml/crypto/KeySelector$Purpose;", "public static final")]
		public static Dova.JDK.javax.xml.crypto.KeySelector.Purpose ENCRYPT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.KeySelector.Purpose>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/xml/crypto/KeySelector$Purpose;", "public static final")]
		public static Dova.JDK.javax.xml.crypto.KeySelector.Purpose DECRYPT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.KeySelector.Purpose>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Purpose(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
		public Purpose(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/xml/crypto/KeySelector$Purpose;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}
}
