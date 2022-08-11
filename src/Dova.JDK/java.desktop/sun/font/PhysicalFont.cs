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

[JniSignatureAttribute("Lsun/font/PhysicalFont;", "public abstract")]
public partial class PhysicalFont
	: Dova.JDK.sun.font.Font2D
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PhysicalFont()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/PhysicalFont;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "platName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nativeNames", "Ljava/lang/Object;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphPoint", "(JII)Ljava/awt/geom/Point2D$Float;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphAdvance", "(JI)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphMetrics", "(JILjava/awt/geom/Point2D$Float;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphImage", "(JI)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphOutlineBounds", "(JI)Ljava/awt/geom/Rectangle2D$Float;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphOutline", "(JIFF)Ljava/awt/geom/GeneralPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphVectorOutline", "(J[IIFF)Ljava/awt/geom/GeneralPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontMetrics", "(J)Lsun/font/StrikeMetrics;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String platName_Property
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

	[JniSignatureAttribute("Ljava/lang/Object;", "protected")]
	public Dova.JDK.java.lang.Object nativeNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PhysicalFont(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public PhysicalFont() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "")]
	public PhysicalFont(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/font/PhysicalFont;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(JII)Ljava/awt/geom/Point2D$Float;", "")]
	public Dova.JDK.java.awt.geom.Point2D.Float getGlyphPoint(long arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D.Float>(ret);
	}

	[JniSignatureAttribute("(JI)F", "abstract")]
	public float getGlyphAdvance(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JILjava/awt/geom/Point2D$Float;)V", "abstract")]
	public void getGlyphMetrics(long arg0, int arg1, Dova.JDK.java.awt.geom.Point2D.Float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JI)J", "abstract")]
	public long getGlyphImage(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JI)Ljava/awt/geom/Rectangle2D$Float;", "abstract")]
	public Dova.JDK.java.awt.geom.Rectangle2D.Float getGlyphOutlineBounds(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D.Float>(ret);
	}

	[JniSignatureAttribute("(JIFF)Ljava/awt/geom/GeneralPath;", "abstract")]
	public Dova.JDK.java.awt.geom.GeneralPath getGlyphOutline(long arg0, int arg1, float arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.GeneralPath>(ret);
	}

	[JniSignatureAttribute("(J[IIFF)Ljava/awt/geom/GeneralPath;", "abstract")]
	public Dova.JDK.java.awt.geom.GeneralPath getGlyphVectorOutline(long arg0, JavaArray<int> arg1, int arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.GeneralPath>(ret);
	}

	[JniSignatureAttribute("(J)Lsun/font/StrikeMetrics;", "abstract")]
	public Dova.JDK.sun.font.StrikeMetrics getFontMetrics(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.StrikeMetrics>(ret);
	}
}
