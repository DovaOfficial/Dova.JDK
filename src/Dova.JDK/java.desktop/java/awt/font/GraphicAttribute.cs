/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.java.awt.font;

[JniSignatureAttribute("Ljava/awt/font/GraphicAttribute;", "public abstract")]
public partial class GraphicAttribute
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GraphicAttribute()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/awt/font/GraphicAttribute;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fAlignment", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TOP_ALIGNMENT", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BOTTOM_ALIGNMENT", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ROMAN_BASELINE", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CENTER_BASELINE", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HANGING_BASELINE", "I"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "GraphicAttribute", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getBounds", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAlignment", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "draw", "(Ljava/awt/Graphics2D;FF)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getOutline", "(Ljava/awt/geom/AffineTransform;)Ljava/awt/Shape;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getJustificationInfo", "()Ljava/awt/font/GlyphJustificationInfo;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAscent", "()F"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAdvance", "()F"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDescent", "()F"));
	}

	[JniSignatureAttribute("I", "private")]
	public int fAlignment_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int TOP_ALIGNMENT_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int BOTTOM_ALIGNMENT_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ROMAN_BASELINE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CENTER_BASELINE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int HANGING_BASELINE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GraphicAttribute(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public GraphicAttribute(int arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/font/GraphicAttribute;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "public")]
	public Dova.JDK.java.awt.geom.Rectangle2D getBounds()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int getAlignment()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;FF)V", "public abstract")]
	public void draw(Dova.JDK.java.awt.Graphics2D arg0, float arg1, float arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;)Ljava/awt/Shape;", "public")]
	public Dova.JDK.java.awt.Shape getOutline(Dova.JDK.java.awt.geom.AffineTransform arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/font/GlyphJustificationInfo;", "public")]
	public Dova.JDK.java.awt.font.GlyphJustificationInfo getJustificationInfo()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.font.GlyphJustificationInfo>(ret);
	}

	[JniSignatureAttribute("()F", "public abstract")]
	public float getAscent()
	{
		var ret = DovaJvm.Vm.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()F", "public abstract")]
	public float getAdvance()
	{
		var ret = DovaJvm.Vm.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()F", "public abstract")]
	public float getDescent()
	{
		var ret = DovaJvm.Vm.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}
}
