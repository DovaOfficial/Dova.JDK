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

namespace Dova.JDK.java.awt;

[JniSignatureAttribute("Ljava/awt/Rectangle;", "public")]
public partial class Rectangle
	: Dova.JDK.java.awt.geom.Rectangle2D
	, Dova.JDK.java.awt.Shape
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Rectangle()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/Rectangle;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "y", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "width", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "height", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIII)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(II)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Dimension;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Point;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Rectangle;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Point;Ljava/awt/Dimension;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/awt/Rectangle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/awt/Point;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(IIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/awt/Rectangle;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/awt/Point;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocation", "()Ljava/awt/Point;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "()Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "grow", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resize", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initIDs", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "move", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSize", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSize", "(Ljava/awt/Dimension;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "union", "(Ljava/awt/Rectangle;)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocation", "(Ljava/awt/Point;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocation", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWidth", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeight", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reshape", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getY", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBounds", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBounds", "(Ljava/awt/Rectangle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intersection", "(Ljava/awt/Rectangle;)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inside", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "clip", "(DZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds2D", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRect", "(DDDD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intersects", "(Ljava/awt/Rectangle;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "outcode", "(DD)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createIntersection", "(Ljava/awt/geom/Rectangle2D;)Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createUnion", "(Ljava/awt/geom/Rectangle2D;)Ljava/awt/geom/Rectangle2D;"));
	}

	[JniSignatureAttribute("I", "public")]
	public int x_Property
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

	[JniSignatureAttribute("I", "public")]
	public int y_Property
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

	[JniSignatureAttribute("I", "public")]
	public int width_Property
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

	[JniSignatureAttribute("I", "public")]
	public int height_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Rectangle(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public Rectangle(int arg0, int arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(II)V", "public")]
	public Rectangle(int arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Dimension;)V", "public")]
	public Rectangle(Dova.JDK.java.awt.Dimension arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Point;)V", "public")]
	public Rectangle(Dova.JDK.java.awt.Point arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)V", "public")]
	public Rectangle(Dova.JDK.java.awt.Rectangle arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Rectangle() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[5]))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Point;Ljava/awt/Dimension;)V", "public")]
	public Rectangle(Dova.JDK.java.awt.Point arg0, Dova.JDK.java.awt.Dimension arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[6], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/Rectangle;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)V", "public")]
	public void add(Dova.JDK.java.awt.Rectangle arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Point;)V", "public")]
	public void add(Dova.JDK.java.awt.Point arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void add(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isEmpty()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(IIII)Z", "public")]
	public bool contains(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)Z", "public")]
	public bool contains(Dova.JDK.java.awt.Rectangle arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Point;)Z", "public")]
	public bool contains(Dova.JDK.java.awt.Point arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)Z", "public")]
	public bool contains(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public")]
	public Dova.JDK.java.awt.Rectangle getBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Point;", "public")]
	public Dova.JDK.java.awt.Point getLocation()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void grow(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void resize(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private static native")]
	public static void initIDs()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[15]);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void move(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void setSize(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Dimension;)V", "public")]
	public void setSize(Dova.JDK.java.awt.Dimension arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)Ljava/awt/Rectangle;", "public")]
	public Dova.JDK.java.awt.Rectangle union(Dova.JDK.java.awt.Rectangle arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Point;)V", "public")]
	public void setLocation(Dova.JDK.java.awt.Point arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void setLocation(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("()D", "public")]
	public double getWidth()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double getHeight()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void reshape(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()D", "public")]
	public double getX()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double getY()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void setBounds(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)V", "public")]
	public void setBounds(Dova.JDK.java.awt.Rectangle arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)Ljava/awt/Rectangle;", "public")]
	public Dova.JDK.java.awt.Rectangle intersection(Dova.JDK.java.awt.Rectangle arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void translate(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
	}

	[JniSignatureAttribute("(II)Z", "public")]
	public bool inside(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(DZ)I", "private static")]
	public static int clip(double arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "public")]
	public Dova.JDK.java.awt.geom.Rectangle2D getBounds2D()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(DDDD)V", "public")]
	public void setRect(double arg0, double arg1, double arg2, double arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)Z", "public")]
	public bool intersects(Dova.JDK.java.awt.Rectangle arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return ret;
	}

	[JniSignatureAttribute("(DD)I", "public")]
	public int outcode(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Rectangle2D;)Ljava/awt/geom/Rectangle2D;", "public")]
	public Dova.JDK.java.awt.geom.Rectangle2D createIntersection(Dova.JDK.java.awt.geom.Rectangle2D arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Rectangle2D;)Ljava/awt/geom/Rectangle2D;", "public")]
	public Dova.JDK.java.awt.geom.Rectangle2D createUnion(Dova.JDK.java.awt.geom.Rectangle2D arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}
}
