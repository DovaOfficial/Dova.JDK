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

[JniSignatureAttribute("Lsun/font/FreetypeFontScaler;", "")]
public partial class FreetypeFontScaler
	: Dova.JDK.sun.font.FontScaler
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FreetypeFontScaler()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/FreetypeFontScaler;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRUETYPE_FONT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE1_FONT", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/font/Font2D;IZI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initIDs", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontMetrics", "(J)Lsun/font/StrikeMetrics;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumGlyphs", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMissingGlyphCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphOutline", "(JIFF)Ljava/awt/geom/GeneralPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphCode", "(C)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphMetrics", "(JILjava/awt/geom/Point2D$Float;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnitsPerEm", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createScalerContext", "([DIIFF)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initNativeScaler", "(Lsun/font/Font2D;IIZI)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontMetricsNative", "(Lsun/font/Font2D;JJ)Lsun/font/StrikeMetrics;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphAdvanceNative", "(Lsun/font/Font2D;JJI)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphMetricsNative", "(Lsun/font/Font2D;JJILjava/awt/geom/Point2D$Float;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphImageNative", "(Lsun/font/Font2D;JJI)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphOutlineBoundsNative", "(Lsun/font/Font2D;JJI)Ljava/awt/geom/Rectangle2D$Float;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphOutlineNative", "(Lsun/font/Font2D;JJIFF)Ljava/awt/geom/GeneralPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphVectorOutlineNative", "(Lsun/font/Font2D;JJ[IIFF)Ljava/awt/geom/GeneralPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "disposeNativeScaler", "(Lsun/font/Font2D;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumGlyphsNative", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMissingGlyphCodeNative", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphCodeNative", "(Lsun/font/Font2D;JC)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphPointNative", "(Lsun/font/Font2D;JJII)Ljava/awt/geom/Point2D$Float;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnitsPerEMNative", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createScalerContextNative", "(J[DIIFF)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidateScaler", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphPoint", "(JII)Ljava/awt/geom/Point2D$Float;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidateScalerContext", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "disposeScaler", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphAdvance", "(JI)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphImage", "(JI)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphOutlineBounds", "(JI)Ljava/awt/geom/Rectangle2D$Float;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphVectorOutline", "(J[IIFF)Ljava/awt/geom/GeneralPath;"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int TRUETYPE_FONT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int TYPE1_FONT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FreetypeFontScaler(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;IZI)V", "public")]
	public FreetypeFontScaler(Dova.JDK.sun.font.Font2D arg0, int arg1, bool arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/font/FreetypeFontScaler;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "private static native")]
	public static void initIDs(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(J)Lsun/font/StrikeMetrics;", "synchronized")]
	public Dova.JDK.sun.font.StrikeMetrics getFontMetrics(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.StrikeMetrics>(ret);
	}

	[JniSignatureAttribute("()I", "synchronized")]
	public int getNumGlyphs()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()I", "synchronized")]
	public int getMissingGlyphCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(JIFF)Ljava/awt/geom/GeneralPath;", "synchronized")]
	public Dova.JDK.java.awt.geom.GeneralPath getGlyphOutline(long arg0, int arg1, float arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.GeneralPath>(ret);
	}

	[JniSignatureAttribute("(C)I", "synchronized")]
	public int getGlyphCode(char arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JILjava/awt/geom/Point2D$Float;)V", "synchronized")]
	public void getGlyphMetrics(long arg0, int arg1, Dova.JDK.java.awt.geom.Point2D.Float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()J", "synchronized")]
	public long getUnitsPerEm()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("([DIIFF)J", "synchronized")]
	public long createScalerContext(JavaArray<double> arg0, int arg1, int arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;IIZI)J", "private native")]
	public long initNativeScaler(Dova.JDK.sun.font.Font2D arg0, int arg1, int arg2, bool arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;JJ)Lsun/font/StrikeMetrics;", "private native")]
	public Dova.JDK.sun.font.StrikeMetrics getFontMetricsNative(Dova.JDK.sun.font.Font2D arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.StrikeMetrics>(ret);
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;JJI)F", "private native")]
	public float getGlyphAdvanceNative(Dova.JDK.sun.font.Font2D arg0, long arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;JJILjava/awt/geom/Point2D$Float;)V", "private native")]
	public void getGlyphMetricsNative(Dova.JDK.sun.font.Font2D arg0, long arg1, long arg2, int arg3, Dova.JDK.java.awt.geom.Point2D.Float arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;JJI)J", "private native")]
	public long getGlyphImageNative(Dova.JDK.sun.font.Font2D arg0, long arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;JJI)Ljava/awt/geom/Rectangle2D$Float;", "private native")]
	public Dova.JDK.java.awt.geom.Rectangle2D.Float getGlyphOutlineBoundsNative(Dova.JDK.sun.font.Font2D arg0, long arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D.Float>(ret);
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;JJIFF)Ljava/awt/geom/GeneralPath;", "private native")]
	public Dova.JDK.java.awt.geom.GeneralPath getGlyphOutlineNative(Dova.JDK.sun.font.Font2D arg0, long arg1, long arg2, int arg3, float arg4, float arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.GeneralPath>(ret);
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;JJ[IIFF)Ljava/awt/geom/GeneralPath;", "private native")]
	public Dova.JDK.java.awt.geom.GeneralPath getGlyphVectorOutlineNative(Dova.JDK.sun.font.Font2D arg0, long arg1, long arg2, JavaArray<int> arg3, int arg4, float arg5, float arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.GeneralPath>(ret);
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;J)V", "private native")]
	public void disposeNativeScaler(Dova.JDK.sun.font.Font2D arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
	}

	[JniSignatureAttribute("(J)I", "private native")]
	public int getNumGlyphsNative(long arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)I", "private native")]
	public int getMissingGlyphCodeNative(long arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;JC)I", "private native")]
	public int getGlyphCodeNative(Dova.JDK.sun.font.Font2D arg0, long arg1, char arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;JJII)Ljava/awt/geom/Point2D$Float;", "private native")]
	public Dova.JDK.java.awt.geom.Point2D.Float getGlyphPointNative(Dova.JDK.sun.font.Font2D arg0, long arg1, long arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D.Float>(ret);
	}

	[JniSignatureAttribute("(J)J", "private native")]
	public long getUnitsPerEMNative(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J[DIIFF)J", "private native")]
	public long createScalerContextNative(long arg0, JavaArray<double> arg1, int arg2, int arg3, float arg4, float arg5)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void invalidateScaler()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25]);
	}

	[JniSignatureAttribute("(JII)Ljava/awt/geom/Point2D$Float;", "synchronized")]
	public Dova.JDK.java.awt.geom.Point2D.Float getGlyphPoint(long arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D.Float>(ret);
	}

	[JniSignatureAttribute("(J)V", "")]
	public void invalidateScalerContext(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void disposeScaler()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28]);
	}

	[JniSignatureAttribute("(JI)F", "synchronized")]
	public float getGlyphAdvance(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JI)J", "synchronized")]
	public long getGlyphImage(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JI)Ljava/awt/geom/Rectangle2D$Float;", "synchronized")]
	public Dova.JDK.java.awt.geom.Rectangle2D.Float getGlyphOutlineBounds(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D.Float>(ret);
	}

	[JniSignatureAttribute("(J[IIFF)Ljava/awt/geom/GeneralPath;", "synchronized")]
	public Dova.JDK.java.awt.geom.GeneralPath getGlyphVectorOutline(long arg0, JavaArray<int> arg1, int arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.GeneralPath>(ret);
	}
}
