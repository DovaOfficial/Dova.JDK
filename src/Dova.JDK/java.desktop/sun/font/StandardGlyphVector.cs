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

namespace Dova.JDK.sun.font;

[JniSignatureAttribute("Lsun/font/StandardGlyphVector;", "public")]
public partial class StandardGlyphVector
	: Dova.JDK.java.awt.font.GlyphVector
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StandardGlyphVector()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/StandardGlyphVector;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "font", "Ljava/awt/Font;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frc", "Ljava/awt/font/FontRenderContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "glyphs", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "userGlyphs", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "positions", "[F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "charIndices", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flags", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNINITIALIZED_FLAGS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gti", "Lsun/font/StandardGlyphVector$GlyphTransformInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ftx", "Ljava/awt/geom/AffineTransform;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dtx", "Ljava/awt/geom/AffineTransform;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "invdtx", "Ljava/awt/geom/AffineTransform;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frctx", "Ljava/awt/geom/AffineTransform;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "font2D", "Lsun/font/Font2D;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fsref", "Ljava/lang/ref/SoftReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lbcacheRef", "Ljava/lang/ref/SoftReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vbcacheRef", "Ljava/lang/ref/SoftReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLAG_USES_VERTICAL_BASELINE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLAG_USES_VERTICAL_METRICS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLAG_USES_ALTERNATE_ORIENTATION", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/font/GlyphVector;Ljava/awt/font/FontRenderContext;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Font;Ljava/awt/font/FontRenderContext;[I[F[II)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Font;Ljava/text/CharacterIterator;Ljava/awt/font/FontRenderContext;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Font;[ILjava/awt/font/FontRenderContext;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Font;Ljava/lang/String;Ljava/awt/font/FontRenderContext;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Font;[CLjava/awt/font/FontRenderContext;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Font;[CIILjava/awt/font/FontRenderContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/awt/font/GlyphVector;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(Ljava/awt/Font;[CIILjava/awt/font/FontRenderContext;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "()Lsun/font/StandardGlyphVector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphMetrics", "(I)Ljava/awt/font/GlyphMetrics;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphOutlineBounds", "(I)Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphOutline", "(I)Ljava/awt/Shape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphOutline", "(IFF)Ljava/awt/Shape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFont", "()Ljava/awt/Font;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontRenderContext", "()Ljava/awt/font/FontRenderContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphPixelBounds", "(ILjava/awt/font/FontRenderContext;FF)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "matchTX", "([DLjava/awt/geom/AffineTransform;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRenderTransform", "([D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultStrike", "()Lsun/font/StandardGlyphVector$GlyphStrike;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetDTX", "(Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equalNonTranslateTX", "(Ljava/awt/geom/AffineTransform;Ljava/awt/geom/AffineTransform;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNonTranslateTX", "(Ljava/awt/geom/AffineTransform;)Ljava/awt/geom/AffineTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphCodes", "(II[I)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDTX", "(Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "performDefaultLayout", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphCharIndex", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGlyphPosition", "(ILjava/awt/geom/Point2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphLogicalBounds", "(I)Ljava/awt/Shape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphJustificationInfo", "(I)Ljava/awt/font/GlyphJustificationInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisualBounds", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLogicalBounds", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPixelBounds", "(Ljava/awt/font/FontRenderContext;FF)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLayoutFlags", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphInfo", "()[F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphCharIndices", "(II[I)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphPositions", "(II[F)[F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphPositions", "([F)[F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGlyphPositions", "([F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGlyphPositions", "([FIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initGlyphVector", "(Ljava/awt/Font;Ljava/awt/font/FontRenderContext;[I[F[II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initFontData", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValidatedGlyphs", "([I)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearFlags", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFRCTX", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initPositions", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphVisualBounds", "(I)Ljava/awt/Shape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphsPixelBounds", "(Ljava/awt/font/FontRenderContext;FFII)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphsOutline", "(IIFF)Ljava/awt/Shape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearCaches", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearCaches", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addFlags", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphTransform", "(I)Ljava/awt/geom/AffineTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGlyphTransform", "(ILjava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalGetGlyphPositions", "(III[F)[F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphStrike", "(I)Lsun/font/StandardGlyphVector$GlyphStrike;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphPosition", "(I)Ljava/awt/geom/Point2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphTransforms", "()[Ljava/awt/geom/AffineTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphTransforms", "(II[Ljava/awt/geom/AffineTransform;)[Ljava/awt/geom/AffineTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGlyphTransforms", "([Ljava/awt/geom/AffineTransform;III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGlyphTransforms", "([Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumGlyphs", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTracking", "(Ljava/awt/Font;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphCode", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getStandardGV", "(Ljava/awt/font/GlyphVector;Lsun/java2d/loops/FontInfo;)Lsun/font/StandardGlyphVector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needsPositions", "([D)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setupGlyphImages", "([J[F[D)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutline", "(FF)Ljava/awt/Shape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutline", "()Ljava/awt/Shape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendString", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;"));
	}

	[JniSignatureAttribute("Ljava/awt/Font;", "private")]
	public Dova.JDK.java.awt.Font font_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/font/FontRenderContext;", "private")]
	public Dova.JDK.java.awt.font.FontRenderContext frc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.font.FontRenderContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> glyphs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> userGlyphs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[F", "private")]
	public JavaArray<float> positions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> charIndices_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int flags_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int UNINITIALIZED_FLAGS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Lsun/font/StandardGlyphVector$GlyphTransformInfo;", "private")]
	public Dova.JDK.sun.font.StandardGlyphVector.GlyphTransformInfo gti_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.font.StandardGlyphVector.GlyphTransformInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/AffineTransform;", "private")]
	public Dova.JDK.java.awt.geom.AffineTransform ftx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/AffineTransform;", "private")]
	public Dova.JDK.java.awt.geom.AffineTransform dtx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/AffineTransform;", "private")]
	public Dova.JDK.java.awt.geom.AffineTransform invdtx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/AffineTransform;", "private")]
	public Dova.JDK.java.awt.geom.AffineTransform frctx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/font/Font2D;", "private")]
	public Dova.JDK.sun.font.Font2D font2D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.font.Font2D>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/SoftReference;", "private")]
	public Dova.JDK.java.lang.@ref.SoftReference fsref_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.SoftReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/SoftReference;", "private")]
	public Dova.JDK.java.lang.@ref.SoftReference lbcacheRef_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.SoftReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/SoftReference;", "private")]
	public Dova.JDK.java.lang.@ref.SoftReference vbcacheRef_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.SoftReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int FLAG_USES_VERTICAL_BASELINE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int FLAG_USES_VERTICAL_METRICS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int FLAG_USES_ALTERNATE_ORIENTATION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StandardGlyphVector(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/font/GlyphVector;Ljava/awt/font/FontRenderContext;)V", "private")]
	public StandardGlyphVector(Dova.JDK.java.awt.font.GlyphVector arg0, Dova.JDK.java.awt.font.FontRenderContext arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Font;Ljava/awt/font/FontRenderContext;[I[F[II)V", "public")]
	public StandardGlyphVector(Dova.JDK.java.awt.Font arg0, Dova.JDK.java.awt.font.FontRenderContext arg1, JavaArray<int> arg2, JavaArray<float> arg3, JavaArray<int> arg4, int arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Font;Ljava/text/CharacterIterator;Ljava/awt/font/FontRenderContext;)V", "public")]
	public StandardGlyphVector(Dova.JDK.java.awt.Font arg0, Dova.JDK.java.text.CharacterIterator arg1, Dova.JDK.java.awt.font.FontRenderContext arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Font;[ILjava/awt/font/FontRenderContext;)V", "public")]
	public StandardGlyphVector(Dova.JDK.java.awt.Font arg0, JavaArray<int> arg1, Dova.JDK.java.awt.font.FontRenderContext arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Font;Ljava/lang/String;Ljava/awt/font/FontRenderContext;)V", "public")]
	public StandardGlyphVector(Dova.JDK.java.awt.Font arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.awt.font.FontRenderContext arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Font;[CLjava/awt/font/FontRenderContext;)V", "public")]
	public StandardGlyphVector(Dova.JDK.java.awt.Font arg0, JavaArray<char> arg1, Dova.JDK.java.awt.font.FontRenderContext arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[5], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Font;[CIILjava/awt/font/FontRenderContext;)V", "public")]
	public StandardGlyphVector(Dova.JDK.java.awt.Font arg0, JavaArray<char> arg1, int arg2, int arg3, Dova.JDK.java.awt.font.FontRenderContext arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[6], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/font/StandardGlyphVector;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/font/GlyphVector;)Z", "public")]
	public bool equals(Dova.JDK.java.awt.font.GlyphVector arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Font;[CIILjava/awt/font/FontRenderContext;I)V", "private")]
	public void init(Dova.JDK.java.awt.Font arg0, JavaArray<char> arg1, int arg2, int arg3, Dova.JDK.java.awt.font.FontRenderContext arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("()Lsun/font/StandardGlyphVector;", "public")]
	public Dova.JDK.sun.font.StandardGlyphVector copy()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.StandardGlyphVector>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/awt/font/GlyphMetrics;", "public")]
	public Dova.JDK.java.awt.font.GlyphMetrics getGlyphMetrics(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.font.GlyphMetrics>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D getGlyphOutlineBounds(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/awt/Shape;", "public")]
	public Dova.JDK.java.awt.Shape getGlyphOutline(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
	}

	[JniSignatureAttribute("(IFF)Ljava/awt/Shape;", "public")]
	public Dova.JDK.java.awt.Shape getGlyphOutline(int arg0, float arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Font;", "public")]
	public Dova.JDK.java.awt.Font getFont()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/font/FontRenderContext;", "public")]
	public Dova.JDK.java.awt.font.FontRenderContext getFontRenderContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.font.FontRenderContext>(ret);
	}

	[JniSignatureAttribute("(ILjava/awt/font/FontRenderContext;FF)Ljava/awt/Rectangle;", "public")]
	public Dova.JDK.java.awt.Rectangle getGlyphPixelBounds(int arg0, Dova.JDK.java.awt.font.FontRenderContext arg1, float arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("([DLjava/awt/geom/AffineTransform;)Z", "private static")]
	public static bool matchTX(JavaArray<double> arg0, Dova.JDK.java.awt.geom.AffineTransform arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([D)V", "private")]
	public void setRenderTransform(JavaArray<double> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()Lsun/font/StandardGlyphVector$GlyphStrike;", "private")]
	public Dova.JDK.sun.font.StandardGlyphVector.GlyphStrike getDefaultStrike()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.StandardGlyphVector.GlyphStrike>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;)V", "private")]
	public void resetDTX(Dova.JDK.java.awt.geom.AffineTransform arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;Ljava/awt/geom/AffineTransform;)Z", "private static")]
	public static bool equalNonTranslateTX(Dova.JDK.java.awt.geom.AffineTransform arg0, Dova.JDK.java.awt.geom.AffineTransform arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;)Ljava/awt/geom/AffineTransform;", "private static")]
	public static Dova.JDK.java.awt.geom.AffineTransform getNonTranslateTX(Dova.JDK.java.awt.geom.AffineTransform arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
	}

	[JniSignatureAttribute("(II[I)[I", "public")]
	public JavaArray<int> getGlyphCodes(int arg0, int arg1, JavaArray<int> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;)V", "private")]
	public void setDTX(Dova.JDK.java.awt.geom.AffineTransform arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void performDefaultLayout()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22]);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getGlyphCharIndex(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/awt/geom/Point2D;)V", "public")]
	public void setGlyphPosition(int arg0, Dova.JDK.java.awt.geom.Point2D arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Ljava/awt/Shape;", "public")]
	public Dova.JDK.java.awt.Shape getGlyphLogicalBounds(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/awt/font/GlyphJustificationInfo;", "public")]
	public Dova.JDK.java.awt.font.GlyphJustificationInfo getGlyphJustificationInfo(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.font.GlyphJustificationInfo>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "public")]
	public Dova.JDK.java.awt.geom.Rectangle2D getVisualBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "public")]
	public Dova.JDK.java.awt.geom.Rectangle2D getLogicalBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/font/FontRenderContext;FF)Ljava/awt/Rectangle;", "public")]
	public Dova.JDK.java.awt.Rectangle getPixelBounds(Dova.JDK.java.awt.font.FontRenderContext arg0, float arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getLayoutFlags()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[30]);
		return ret;
	}

	[JniSignatureAttribute("()[F", "public")]
	public JavaArray<float> getGlyphInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("(II[I)[I", "public")]
	public JavaArray<int> getGlyphCharIndices(int arg0, int arg1, JavaArray<int> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(II[F)[F", "public")]
	public JavaArray<float> getGlyphPositions(int arg0, int arg1, JavaArray<float> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("([F)[F", "public")]
	public JavaArray<float> getGlyphPositions(JavaArray<float> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("([F)V", "public")]
	public void setGlyphPositions(JavaArray<float> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("([FIII)V", "public")]
	public void setGlyphPositions(JavaArray<float> arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/awt/Font;Ljava/awt/font/FontRenderContext;[I[F[II)V", "public")]
	public void initGlyphVector(Dova.JDK.java.awt.Font arg0, Dova.JDK.java.awt.font.FontRenderContext arg1, JavaArray<int> arg2, JavaArray<float> arg3, JavaArray<int> arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("()V", "private")]
	public void initFontData()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38]);
	}

	[JniSignatureAttribute("([I)[I", "")]
	public JavaArray<int> getValidatedGlyphs(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void clearFlags(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void setFRCTX()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void initPositions()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42]);
	}

	[JniSignatureAttribute("(I)Ljava/awt/Shape;", "public")]
	public Dova.JDK.java.awt.Shape getGlyphVisualBounds(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/font/FontRenderContext;FFII)Ljava/awt/Rectangle;", "private")]
	public Dova.JDK.java.awt.Rectangle getGlyphsPixelBounds(Dova.JDK.java.awt.font.FontRenderContext arg0, float arg1, float arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(IIFF)Ljava/awt/Shape;", "private")]
	public Dova.JDK.java.awt.Shape getGlyphsOutline(int arg0, int arg1, float arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void clearCaches()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46]);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void clearCaches(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void addFlags(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
	}

	[JniSignatureAttribute("(I)Ljava/awt/geom/AffineTransform;", "public")]
	public Dova.JDK.java.awt.geom.AffineTransform getGlyphTransform(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
	}

	[JniSignatureAttribute("(ILjava/awt/geom/AffineTransform;)V", "public")]
	public void setGlyphTransform(int arg0, Dova.JDK.java.awt.geom.AffineTransform arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
	}

	[JniSignatureAttribute("(III[F)[F", "private")]
	public JavaArray<float> internalGetGlyphPositions(int arg0, int arg1, int arg2, JavaArray<float> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/font/StandardGlyphVector$GlyphStrike;", "private")]
	public Dova.JDK.sun.font.StandardGlyphVector.GlyphStrike getGlyphStrike(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.StandardGlyphVector.GlyphStrike>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/awt/geom/Point2D;", "public")]
	public Dova.JDK.java.awt.geom.Point2D getGlyphPosition(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
	}

	[JniSignatureAttribute("()[Ljava/awt/geom/AffineTransform;", "public")]
	public JavaArray<Dova.JDK.java.awt.geom.AffineTransform> getGlyphTransforms()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.geom.AffineTransform>>(ret);
	}

	[JniSignatureAttribute("(II[Ljava/awt/geom/AffineTransform;)[Ljava/awt/geom/AffineTransform;", "public")]
	public JavaArray<Dova.JDK.java.awt.geom.AffineTransform> getGlyphTransforms(int arg0, int arg1, JavaArray<Dova.JDK.java.awt.geom.AffineTransform> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.geom.AffineTransform>>(ret);
	}

	[JniSignatureAttribute("([Ljava/awt/geom/AffineTransform;III)V", "public")]
	public void setGlyphTransforms(JavaArray<Dova.JDK.java.awt.geom.AffineTransform> arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([Ljava/awt/geom/AffineTransform;)V", "public")]
	public void setGlyphTransforms(JavaArray<Dova.JDK.java.awt.geom.AffineTransform> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNumGlyphs()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[58]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Font;)F", "private")]
	public float getTracking(Dova.JDK.java.awt.Font arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getGlyphCode(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/font/GlyphVector;Lsun/java2d/loops/FontInfo;)Lsun/font/StandardGlyphVector;", "public static")]
	public static Dova.JDK.sun.font.StandardGlyphVector getStandardGV(Dova.JDK.java.awt.font.GlyphVector arg0, Dova.JDK.sun.java2d.loops.FontInfo arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[61], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.StandardGlyphVector>(ret);
	}

	[JniSignatureAttribute("([D)Z", "")]
	public bool needsPositions(JavaArray<double> arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return ret;
	}

	[JniSignatureAttribute("([J[F[D)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object setupGlyphImages(JavaArray<long> arg0, JavaArray<float> arg1, JavaArray<double> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(FF)Ljava/awt/Shape;", "public")]
	public Dova.JDK.java.awt.Shape getOutline(float arg0, float arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Shape;", "public")]
	public Dova.JDK.java.awt.Shape getOutline()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;", "")]
	public Dova.JDK.java.lang.StringBuffer appendString(Dova.JDK.java.lang.StringBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuffer>(ret);
	}

	[JniSignatureAttribute("Lsun/font/StandardGlyphVector$GlyphTransformInfo;", "static final")]
	public partial class GlyphTransformInfo
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GlyphTransformInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/StandardGlyphVector$GlyphTransformInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sgv", "Lsun/font/StandardGlyphVector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "indices", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transforms", "[D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strikesRef", "Ljava/lang/ref/SoftReference;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "haveAllStrikes", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/font/StandardGlyphVector;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/font/StandardGlyphVector;Lsun/font/StandardGlyphVector$GlyphTransformInfo;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Lsun/font/StandardGlyphVector$GlyphTransformInfo;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphsPixelBounds", "(Ljava/awt/geom/AffineTransform;FFII)Ljava/awt/Rectangle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphTransform", "(I)Ljava/awt/geom/AffineTransform;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGlyphTransform", "(ILjava/awt/geom/AffineTransform;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transformCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStrike", "(I)Lsun/font/StandardGlyphVector$GlyphStrike;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllStrikes", "()[Lsun/font/StandardGlyphVector$GlyphStrike;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStrikeArray", "()[Lsun/font/StandardGlyphVector$GlyphStrike;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStrikeAtIndex", "([Lsun/font/StandardGlyphVector$GlyphStrike;I)Lsun/font/StandardGlyphVector$GlyphStrike;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setupGlyphImages", "([J[FLjava/awt/geom/AffineTransform;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Lsun/font/StandardGlyphVector;", "")]
		public Dova.JDK.sun.font.StandardGlyphVector sgv_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.font.StandardGlyphVector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[I", "")]
		public JavaArray<int> indices_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[D", "")]
		public JavaArray<double> transforms_Property
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

		[JniSignatureAttribute("Ljava/lang/ref/SoftReference;", "")]
		public Dova.JDK.java.lang.@ref.SoftReference strikesRef_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.SoftReference>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool haveAllStrikes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GlyphTransformInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/font/StandardGlyphVector;)V", "")]
		public GlyphTransformInfo(Dova.JDK.sun.font.StandardGlyphVector arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lsun/font/StandardGlyphVector;Lsun/font/StandardGlyphVector$GlyphTransformInfo;)V", "")]
		public GlyphTransformInfo(Dova.JDK.sun.font.StandardGlyphVector arg0, Dova.JDK.sun.font.StandardGlyphVector.GlyphTransformInfo arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/font/StandardGlyphVector$GlyphTransformInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/font/StandardGlyphVector$GlyphTransformInfo;)Z", "public")]
		public bool equals(Dova.JDK.sun.font.StandardGlyphVector.GlyphTransformInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;FFII)Ljava/awt/Rectangle;", "")]
		public Dova.JDK.java.awt.Rectangle getGlyphsPixelBounds(Dova.JDK.java.awt.geom.AffineTransform arg0, float arg1, float arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/awt/geom/AffineTransform;", "")]
		public Dova.JDK.java.awt.geom.AffineTransform getGlyphTransform(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
		}

		[JniSignatureAttribute("(ILjava/awt/geom/AffineTransform;)V", "")]
		public void setGlyphTransform(int arg0, Dova.JDK.java.awt.geom.AffineTransform arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("()I", "")]
		public int transformCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(I)Lsun/font/StandardGlyphVector$GlyphStrike;", "")]
		public Dova.JDK.sun.font.StandardGlyphVector.GlyphStrike getStrike(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.font.StandardGlyphVector.GlyphStrike>(ret);
		}

		[JniSignatureAttribute("()[Lsun/font/StandardGlyphVector$GlyphStrike;", "private")]
		public JavaArray<Dova.JDK.sun.font.StandardGlyphVector.GlyphStrike> getAllStrikes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.font.StandardGlyphVector.GlyphStrike>>(ret);
		}

		[JniSignatureAttribute("()[Lsun/font/StandardGlyphVector$GlyphStrike;", "private")]
		public JavaArray<Dova.JDK.sun.font.StandardGlyphVector.GlyphStrike> getStrikeArray()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.font.StandardGlyphVector.GlyphStrike>>(ret);
		}

		[JniSignatureAttribute("([Lsun/font/StandardGlyphVector$GlyphStrike;I)Lsun/font/StandardGlyphVector$GlyphStrike;", "private")]
		public Dova.JDK.sun.font.StandardGlyphVector.GlyphStrike getStrikeAtIndex(JavaArray<Dova.JDK.sun.font.StandardGlyphVector.GlyphStrike> arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.font.StandardGlyphVector.GlyphStrike>(ret);
		}

		[JniSignatureAttribute("([J[FLjava/awt/geom/AffineTransform;)Ljava/lang/Object;", "")]
		public Dova.JDK.java.lang.Object setupGlyphImages(JavaArray<long> arg0, JavaArray<float> arg1, Dova.JDK.java.awt.geom.AffineTransform arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/font/StandardGlyphVector$ADL;", "static")]
	public partial class ADL
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ADL()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/StandardGlyphVector$ADL;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ascentX", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ascentY", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descentX", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descentY", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "leadingX", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "leadingY", "F"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStringBuffer", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;"));
		}

		[JniSignatureAttribute("F", "public")]
		public float ascentX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("F", "public")]
		public float ascentY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("F", "public")]
		public float descentX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("F", "public")]
		public float descentY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("F", "public")]
		public float leadingX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("F", "public")]
		public float leadingY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ADL(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public ADL() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/font/StandardGlyphVector$ADL;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;", "protected")]
		public Dova.JDK.java.lang.StringBuffer toStringBuffer(Dova.JDK.java.lang.StringBuffer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuffer>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/font/StandardGlyphVector$GlyphStrike;", "public static final")]
	public partial class GlyphStrike
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GlyphStrike()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/StandardGlyphVector$GlyphStrike;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sgv", "Lsun/font/StandardGlyphVector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strike", "Lsun/font/FontStrike;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dx", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dy", "F"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/font/StandardGlyphVector;Lsun/font/FontStrike;FF)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Lsun/font/StandardGlyphVector;Ljava/awt/geom/AffineTransform;Ljava/awt/geom/AffineTransform;)Lsun/font/StandardGlyphVector$GlyphStrike;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphOutlineBounds", "(IFF)Ljava/awt/geom/Rectangle2D;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendGlyphOutline", "(ILjava/awt/geom/GeneralPath;FF)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDefaultGlyphAdvance", "(ILjava/awt/geom/Point2D$Float;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getADL", "(Lsun/font/StandardGlyphVector$ADL;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphPosition", "(II[F[F)V"));
		}

		[JniSignatureAttribute("Lsun/font/StandardGlyphVector;", "")]
		public Dova.JDK.sun.font.StandardGlyphVector sgv_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.font.StandardGlyphVector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/font/FontStrike;", "")]
		public Dova.JDK.sun.font.FontStrike strike_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.font.FontStrike>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("F", "")]
		public float dx_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("F", "")]
		public float dy_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GlyphStrike(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/font/StandardGlyphVector;Lsun/font/FontStrike;FF)V", "private")]
		public GlyphStrike(Dova.JDK.sun.font.StandardGlyphVector arg0, Dova.JDK.sun.font.FontStrike arg1, float arg2, float arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/font/StandardGlyphVector$GlyphStrike;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/font/StandardGlyphVector;Ljava/awt/geom/AffineTransform;Ljava/awt/geom/AffineTransform;)Lsun/font/StandardGlyphVector$GlyphStrike;", "static")]
		public static Dova.JDK.sun.font.StandardGlyphVector.GlyphStrike create(Dova.JDK.sun.font.StandardGlyphVector arg0, Dova.JDK.java.awt.geom.AffineTransform arg1, Dova.JDK.java.awt.geom.AffineTransform arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.font.StandardGlyphVector.GlyphStrike>(ret);
		}

		[JniSignatureAttribute("(IFF)Ljava/awt/geom/Rectangle2D;", "")]
		public Dova.JDK.java.awt.geom.Rectangle2D getGlyphOutlineBounds(int arg0, float arg1, float arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
		}

		[JniSignatureAttribute("(ILjava/awt/geom/GeneralPath;FF)V", "")]
		public void appendGlyphOutline(int arg0, Dova.JDK.java.awt.geom.GeneralPath arg1, float arg2, float arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(ILjava/awt/geom/Point2D$Float;)V", "")]
		public void addDefaultGlyphAdvance(int arg0, Dova.JDK.java.awt.geom.Point2D.Float arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Lsun/font/StandardGlyphVector$ADL;)V", "")]
		public void getADL(Dova.JDK.sun.font.StandardGlyphVector.ADL arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(II[F[F)V", "")]
		public void getGlyphPosition(int arg0, int arg1, JavaArray<float> arg2, JavaArray<float> arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		}
	}
}
