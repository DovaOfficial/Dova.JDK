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

namespace Dova.JDK.com.sun.media.sound;

[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter;", "public abstract")]
public partial class AudioFloatConverter
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AudioFloatConverter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "format", "Ljavax/sound/sampled/AudioFormat;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FI[BI)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([F[B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FI[B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFormat", "()Ljavax/sound/sampled/AudioFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getConverter", "(Ljavax/sound/sampled/AudioFormat;)Lcom/sun/media/sound/AudioFloatConverter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([B[FI)[F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([B[FII)[F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FI)[F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([B[F)[F"));
	}

	[JniSignatureAttribute("Ljavax/sound/sampled/AudioFormat;", "private")]
	public Dova.JDK.javax.sound.sampled.AudioFormat format_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioFormat>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AudioFloatConverter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public AudioFloatConverter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([FI[BI)[B", "public final")]
	public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, JavaArray<byte> arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([FII[B)[B", "public final")]
	public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([FII[BI)[B", "public abstract")]
	public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([F[B)[B", "public final")]
	public JavaArray<byte> toByteArray(JavaArray<float> arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([FI[B)[B", "public final")]
	public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, JavaArray<byte> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sound/sampled/AudioFormat;", "public final")]
	public Dova.JDK.javax.sound.sampled.AudioFormat getFormat()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.sampled.AudioFormat>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sound/sampled/AudioFormat;)Lcom/sun/media/sound/AudioFloatConverter;", "public static")]
	public static Dova.JDK.com.sun.media.sound.AudioFloatConverter getConverter(Dova.JDK.javax.sound.sampled.AudioFormat arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.AudioFloatConverter>(ret);
	}

	[JniSignatureAttribute("([BI[FII)[F", "public abstract")]
	public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("([B[FI)[F", "public final")]
	public JavaArray<float> toFloatArray(JavaArray<byte> arg0, JavaArray<float> arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("([B[FII)[F", "public final")]
	public JavaArray<float> toFloatArray(JavaArray<byte> arg0, JavaArray<float> arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("([BI[FI)[F", "public final")]
	public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("([B[F)[F", "public final")]
	public JavaArray<float> toFloatArray(JavaArray<byte> arg0, JavaArray<float> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion8S;", "private static")]
	public partial class AudioFloatConversion8S
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion8S()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion8S;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion8S(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AudioFloatConversion8S() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion8S;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion16SB;", "private static")]
	public partial class AudioFloatConversion16SB
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion16SB()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion16SB;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion16SB(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AudioFloatConversion16SB() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion16SB;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion24SB;", "private static")]
	public partial class AudioFloatConversion24SB
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion24SB()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion24SB;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion24SB(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AudioFloatConversion24SB() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion24SB;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32SB;", "private static")]
	public partial class AudioFloatConversion32SB
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion32SB()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32SB;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion32SB(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AudioFloatConversion32SB() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32SB;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32xSB;", "private static")]
	public partial class AudioFloatConversion32xSB
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion32xSB()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32xSB;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xbytes", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("I", "private final")]
		public int xbytes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion32xSB(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "")]
		public AudioFloatConversion32xSB(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32xSB;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion16SL;", "private static")]
	public partial class AudioFloatConversion16SL
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion16SL()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion16SL;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion16SL(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AudioFloatConversion16SL() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion16SL;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion24SL;", "private static")]
	public partial class AudioFloatConversion24SL
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion24SL()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion24SL;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion24SL(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AudioFloatConversion24SL() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion24SL;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32SL;", "private static")]
	public partial class AudioFloatConversion32SL
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion32SL()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32SL;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion32SL(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AudioFloatConversion32SL() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32SL;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32xSL;", "private static")]
	public partial class AudioFloatConversion32xSL
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion32xSL()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32xSL;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xbytes", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("I", "private final")]
		public int xbytes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion32xSL(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "")]
		public AudioFloatConversion32xSL(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32xSL;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion8U;", "private static")]
	public partial class AudioFloatConversion8U
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion8U()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion8U;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion8U(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AudioFloatConversion8U() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion8U;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion16UB;", "private static")]
	public partial class AudioFloatConversion16UB
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion16UB()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion16UB;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion16UB(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AudioFloatConversion16UB() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion16UB;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion24UB;", "private static")]
	public partial class AudioFloatConversion24UB
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion24UB()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion24UB;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion24UB(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AudioFloatConversion24UB() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion24UB;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32UB;", "private static")]
	public partial class AudioFloatConversion32UB
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion32UB()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32UB;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion32UB(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AudioFloatConversion32UB() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32UB;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32xUB;", "private static")]
	public partial class AudioFloatConversion32xUB
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion32xUB()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32xUB;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xbytes", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("I", "private final")]
		public int xbytes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion32xUB(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "")]
		public AudioFloatConversion32xUB(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32xUB;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion16UL;", "private static")]
	public partial class AudioFloatConversion16UL
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion16UL()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion16UL;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion16UL(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AudioFloatConversion16UL() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion16UL;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion24UL;", "private static")]
	public partial class AudioFloatConversion24UL
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion24UL()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion24UL;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion24UL(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AudioFloatConversion24UL() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion24UL;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32UL;", "private static")]
	public partial class AudioFloatConversion32UL
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion32UL()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32UL;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion32UL(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AudioFloatConversion32UL() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32UL;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32xUL;", "private static")]
	public partial class AudioFloatConversion32xUL
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion32xUL()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32xUL;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xbytes", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("I", "private final")]
		public int xbytes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion32xUL(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "")]
		public AudioFloatConversion32xUL(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32xUL;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32B;", "private static")]
	public partial class AudioFloatConversion32B
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion32B()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32B;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bytebuffer", "Ljava/nio/ByteBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "floatbuffer", "Ljava/nio/FloatBuffer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("Ljava/nio/ByteBuffer;", "")]
		public Dova.JDK.java.nio.ByteBuffer bytebuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/FloatBuffer;", "")]
		public Dova.JDK.java.nio.FloatBuffer floatbuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.FloatBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion32B(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AudioFloatConversion32B() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32B;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32L;", "private static")]
	public partial class AudioFloatConversion32L
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion32L()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32L;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bytebuffer", "Ljava/nio/ByteBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "floatbuffer", "Ljava/nio/FloatBuffer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("Ljava/nio/ByteBuffer;", "")]
		public Dova.JDK.java.nio.ByteBuffer bytebuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/FloatBuffer;", "")]
		public Dova.JDK.java.nio.FloatBuffer floatbuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.FloatBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion32L(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AudioFloatConversion32L() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion32L;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion64B;", "private static")]
	public partial class AudioFloatConversion64B
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion64B()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion64B;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bytebuffer", "Ljava/nio/ByteBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "floatbuffer", "Ljava/nio/DoubleBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "double_buff", "[D"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("Ljava/nio/ByteBuffer;", "")]
		public Dova.JDK.java.nio.ByteBuffer bytebuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/DoubleBuffer;", "")]
		public Dova.JDK.java.nio.DoubleBuffer floatbuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[D", "")]
		public JavaArray<double> double_buff_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion64B(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AudioFloatConversion64B() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion64B;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion64L;", "private static")]
	public partial class AudioFloatConversion64L
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatConversion64L()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion64L;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bytebuffer", "Ljava/nio/ByteBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "floatbuffer", "Ljava/nio/DoubleBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "double_buff", "[D"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("Ljava/nio/ByteBuffer;", "")]
		public Dova.JDK.java.nio.ByteBuffer bytebuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/DoubleBuffer;", "")]
		public Dova.JDK.java.nio.DoubleBuffer floatbuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[D", "")]
		public JavaArray<double> double_buff_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatConversion64L(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AudioFloatConversion64L() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatConversion64L;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatLSBFilter;", "private static")]
	public partial class AudioFloatLSBFilter
		: Dova.JDK.com.sun.media.sound.AudioFloatConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AudioFloatLSBFilter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/AudioFloatConverter$AudioFloatLSBFilter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "converter", "Lcom/sun/media/sound/AudioFloatConverter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stepsize", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mask", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mask_buffer", "[B"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/media/sound/AudioFloatConverter;Ljavax/sound/sampled/AudioFormat;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "([FII[BI)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFloatArray", "([BI[FII)[F"));
		}

		[JniSignatureAttribute("Lcom/sun/media/sound/AudioFloatConverter;", "private final")]
		public Dova.JDK.com.sun.media.sound.AudioFloatConverter converter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.AudioFloatConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int offset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int stepsize_Property
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

		[JniSignatureAttribute("B", "private final")]
		public byte mask_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("[B", "private")]
		public JavaArray<byte> mask_buffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AudioFloatLSBFilter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/media/sound/AudioFloatConverter;Ljavax/sound/sampled/AudioFormat;)V", "")]
		public AudioFloatLSBFilter(Dova.JDK.com.sun.media.sound.AudioFloatConverter arg0, Dova.JDK.javax.sound.sampled.AudioFormat arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/media/sound/AudioFloatConverter$AudioFloatLSBFilter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([FII[BI)[B", "public")]
		public JavaArray<byte> toByteArray(JavaArray<float> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([BI[FII)[F", "public")]
		public JavaArray<float> toFloatArray(JavaArray<byte> arg0, int arg1, JavaArray<float> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
	}
}
