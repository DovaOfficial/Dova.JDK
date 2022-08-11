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

namespace Dova.JDK.sun.nio.cs.ext;

[JniSignatureAttribute("Lsun/nio/cs/ext/IBM834;", "public")]
public partial class IBM834
	: Dova.JDK.java.nio.charset.Charset
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IBM834()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/cs/ext/IBM834;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newDecoder", "()Ljava/nio/charset/CharsetDecoder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newEncoder", "()Ljava/nio/charset/CharsetEncoder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/nio/charset/Charset;)Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public IBM834(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public IBM834() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/cs/ext/IBM834;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/nio/charset/CharsetDecoder;", "public")]
	public Dova.JDK.java.nio.charset.CharsetDecoder newDecoder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CharsetDecoder>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/charset/CharsetEncoder;", "public")]
	public Dova.JDK.java.nio.charset.CharsetEncoder newEncoder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CharsetEncoder>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/charset/Charset;)Z", "public")]
	public bool contains(Dova.JDK.java.nio.charset.Charset arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lsun/nio/cs/ext/IBM834$Encoder;", "protected static")]
	public partial class Encoder
		: Dova.JDK.sun.nio.cs.DoubleByte.Encoder_DBCSONLY
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Encoder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/cs/ext/IBM834$Encoder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/charset/Charset;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLegalReplacement", "([B)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeChar", "(C)I"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Encoder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/charset/Charset;)V", "public")]
		public Encoder(Dova.JDK.java.nio.charset.Charset arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/cs/ext/IBM834$Encoder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([B)Z", "public")]
		public bool isLegalReplacement(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(C)I", "public")]
		public int encodeChar(char arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}
}
