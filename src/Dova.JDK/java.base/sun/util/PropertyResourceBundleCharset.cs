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

namespace Dova.JDK.sun.util;

[JniSignatureAttribute("Lsun/util/PropertyResourceBundleCharset;", "public")]
public partial class PropertyResourceBundleCharset
	: Dova.JDK.java.nio.charset.Charset
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PropertyResourceBundleCharset()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/PropertyResourceBundleCharset;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strictUTF8", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;[Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newDecoder", "()Ljava/nio/charset/CharsetDecoder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newEncoder", "()Ljava/nio/charset/CharsetEncoder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/nio/charset/Charset;)Z"));
	}

	[JniSignatureAttribute("Z", "private")]
	public bool strictUTF8_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PropertyResourceBundleCharset(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public PropertyResourceBundleCharset(bool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/String;)V", "public")]
	public PropertyResourceBundleCharset(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.String> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/util/PropertyResourceBundleCharset;";
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

	[JniSignatureAttribute("Lsun/util/PropertyResourceBundleCharset$PropertiesFileDecoder;", "private final")]
	public partial class PropertiesFileDecoder
		: Dova.JDK.java.nio.charset.CharsetDecoder
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PropertiesFileDecoder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/PropertyResourceBundleCharset$PropertiesFileDecoder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cdUTF_8", "Ljava/nio/charset/CharsetDecoder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cdISO_8859_1", "Ljava/nio/charset/CharsetDecoder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/util/PropertyResourceBundleCharset;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/util/PropertyResourceBundleCharset;Ljava/nio/charset/Charset;FF)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeLoop", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;"));
		}

		[JniSignatureAttribute("Ljava/nio/charset/CharsetDecoder;", "private")]
		public Dova.JDK.java.nio.charset.CharsetDecoder cdUTF_8_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CharsetDecoder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/charset/CharsetDecoder;", "private")]
		public Dova.JDK.java.nio.charset.CharsetDecoder cdISO_8859_1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CharsetDecoder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Lsun/util/PropertyResourceBundleCharset;", "final")]
		public Dova.JDK.sun.util.PropertyResourceBundleCharset this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.util.PropertyResourceBundleCharset>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PropertiesFileDecoder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/util/PropertyResourceBundleCharset;Ljava/nio/charset/Charset;FF)V", "protected")]
		public PropertiesFileDecoder(Dova.JDK.sun.util.PropertyResourceBundleCharset arg0, Dova.JDK.java.nio.charset.Charset arg1, float arg2, float arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/util/PropertyResourceBundleCharset$PropertiesFileDecoder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;", "protected")]
		public Dova.JDK.java.nio.charset.CoderResult decodeLoop(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.nio.CharBuffer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
		}
	}
}
