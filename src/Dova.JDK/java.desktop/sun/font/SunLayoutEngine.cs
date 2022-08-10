/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.font;

[JniSignatureAttribute("Lsun/font/SunLayoutEngine;", "public final")]
public partial class SunLayoutEngine
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.font.GlyphLayout.LayoutEngine
	, Dova.JDK.sun.font.GlyphLayout.LayoutEngineFactory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SunLayoutEngine()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/SunLayoutEngine;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "key", "Lsun/font/GlyphLayout$LayoutEngineKey;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "instance", "Lsun/font/GlyphLayout$LayoutEngineFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cacheref", "Ljava/lang/ref/SoftReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "facePtr", "Ljava/util/WeakHashMap;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SunLayoutEngine", "(Lsun/font/GlyphLayout$LayoutEngineKey;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SunLayoutEngine", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "instance", "()Lsun/font/GlyphLayout$LayoutEngineFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "shape", "(Lsun/font/Font2D;Lsun/font/FontStrike;F[FJ[CLsun/font/GlyphLayout$GVData;IIIILjava/awt/geom/Point2D$Float;II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getEngine", "(Lsun/font/GlyphLayout$LayoutEngineKey;)Lsun/font/GlyphLayout$LayoutEngine;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getEngine", "(Lsun/font/Font2D;II)Lsun/font/GlyphLayout$LayoutEngine;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFacePtr", "(Lsun/font/Font2D;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createFace", "(Lsun/font/Font2D;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "disposeFace", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "layout", "(Lsun/font/FontStrikeDesc;[FFIILsun/font/TextRecord;ILjava/awt/geom/Point2D$Float;Lsun/font/GlyphLayout$GVData;)V"));
	}

	[JniSignatureAttribute("Lsun/font/GlyphLayout$LayoutEngineKey;", "private")]
	public Dova.JDK.sun.font.GlyphLayout.LayoutEngineKey key_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.font.GlyphLayout.LayoutEngineKey>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/font/GlyphLayout$LayoutEngineFactory;", "private static")]
	public static Dova.JDK.sun.font.GlyphLayout.LayoutEngineFactory instance_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.font.GlyphLayout.LayoutEngineFactory>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/ref/SoftReference;", "private")]
	public Dova.JDK.java.lang.@ref.SoftReference cacheref_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.SoftReference>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/WeakHashMap;", "private static final")]
	public static Dova.JDK.java.util.WeakHashMap facePtr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.WeakHashMap>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SunLayoutEngine(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/font/GlyphLayout$LayoutEngineKey;)V", "private")]
	public SunLayoutEngine(Dova.JDK.sun.font.GlyphLayout.LayoutEngineKey arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public SunLayoutEngine() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/font/SunLayoutEngine;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/font/GlyphLayout$LayoutEngineFactory;", "public static")]
	public static Dova.JDK.sun.font.GlyphLayout.LayoutEngineFactory instance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.GlyphLayout.LayoutEngineFactory>(ret);
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;Lsun/font/FontStrike;F[FJ[CLsun/font/GlyphLayout$GVData;IIIILjava/awt/geom/Point2D$Float;II)Z", "private static native")]
	public static bool shape(Dova.JDK.sun.font.Font2D arg0, Dova.JDK.sun.font.FontStrike arg1, float arg2, JavaArray<float> arg3, long arg4, JavaArray<char> arg5, Dova.JDK.sun.font.GlyphLayout.GVData arg6, int arg7, int arg8, int arg9, int arg10, Dova.JDK.java.awt.geom.Point2D.Float arg11, int arg12, int arg13)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/font/GlyphLayout$LayoutEngineKey;)Lsun/font/GlyphLayout$LayoutEngine;", "public")]
	public Dova.JDK.sun.font.GlyphLayout.LayoutEngine getEngine(Dova.JDK.sun.font.GlyphLayout.LayoutEngineKey arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.GlyphLayout.LayoutEngine>(ret);
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;II)Lsun/font/GlyphLayout$LayoutEngine;", "public")]
	public Dova.JDK.sun.font.GlyphLayout.LayoutEngine getEngine(Dova.JDK.sun.font.Font2D arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.GlyphLayout.LayoutEngine>(ret);
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;)J", "private")]
	public long getFacePtr(Dova.JDK.sun.font.Font2D arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;J)J", "private static native")]
	public static long createFace(Dova.JDK.sun.font.Font2D arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "private static native")]
	public static void disposeFace(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lsun/font/FontStrikeDesc;[FFIILsun/font/TextRecord;ILjava/awt/geom/Point2D$Float;Lsun/font/GlyphLayout$GVData;)V", "public")]
	public void layout(Dova.JDK.sun.font.FontStrikeDesc arg0, JavaArray<float> arg1, float arg2, int arg3, int arg4, Dova.JDK.sun.font.TextRecord arg5, int arg6, Dova.JDK.java.awt.geom.Point2D.Float arg7, Dova.JDK.sun.font.GlyphLayout.GVData arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("Lsun/font/SunLayoutEngine$FaceRef;", "private static")]
	public partial class FaceRef
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.java2d.DisposerRecord
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FaceRef()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/SunLayoutEngine$FaceRef;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "font", "Lsun/font/Font2D;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "facePtr", "Ljava/lang/Long;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FaceRef", "(Lsun/font/Font2D;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dispose", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNativePtr", "()J"));
		}

		[JniSignatureAttribute("Lsun/font/Font2D;", "private")]
		public Dova.JDK.sun.font.Font2D font_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.font.Font2D>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Long;", "private")]
		public Dova.JDK.java.lang.Long facePtr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Long>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FaceRef(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/font/Font2D;)V", "private")]
		public FaceRef(Dova.JDK.sun.font.Font2D arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/font/SunLayoutEngine$FaceRef;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void dispose()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()J", "private synchronized")]
		public long getNativePtr()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}
}
