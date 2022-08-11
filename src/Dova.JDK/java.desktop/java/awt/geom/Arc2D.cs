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

namespace Dova.JDK.java.awt.geom;

[JniSignatureAttribute("Ljava/awt/geom/Arc2D;", "public abstract")]
public partial class Arc2D
	: Dova.JDK.java.awt.geom.RectangularShape
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Arc2D()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/geom/Arc2D;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OPEN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHORD", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PIE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(DD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(DDDDLjava/awt/geom/Rectangle2D;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/awt/geom/Rectangle2D;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(DDDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartPoint", "()Ljava/awt/geom/Point2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndPoint", "()Ljava/awt/geom/Point2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setArcType", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAngleStart", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAngleExtent", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setArc", "(Ljava/awt/geom/Point2D;Ljava/awt/geom/Dimension2D;DDI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setArc", "(DDDDDDI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setArc", "(Ljava/awt/geom/Rectangle2D;DDI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setArc", "(Ljava/awt/geom/Arc2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setArcByCenter", "(DDDDDI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAngleStart", "(Ljava/awt/geom/Point2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAngleStart", "(D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAngleExtent", "(D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAngles", "(DDDD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAngles", "(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeBounds", "(DDDD)Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArcType", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsAngle", "(D)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "normalizeDegrees", "(D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setArcByTangent", "(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFrame", "(DDDD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds2D", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPathIterator", "(Ljava/awt/geom/AffineTransform;)Ljava/awt/geom/PathIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intersects", "(DDDD)Z"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int OPEN_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int CHORD_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int PIE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int type_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Arc2D(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public Arc2D() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public Arc2D(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/geom/Arc2D;";
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

	[JniSignatureAttribute("(DD)Z", "public")]
	public bool contains(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(DDDDLjava/awt/geom/Rectangle2D;)Z", "private")]
	public bool contains(double arg0, double arg1, double arg2, double arg3, Dova.JDK.java.awt.geom.Rectangle2D arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Rectangle2D;)Z", "public")]
	public bool contains(Dova.JDK.java.awt.geom.Rectangle2D arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(DDDD)Z", "public")]
	public bool contains(double arg0, double arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Point2D;", "public")]
	public Dova.JDK.java.awt.geom.Point2D getStartPoint()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Point2D;", "public")]
	public Dova.JDK.java.awt.geom.Point2D getEndPoint()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setArcType(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getAngleStart()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getAngleExtent()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Point2D;Ljava/awt/geom/Dimension2D;DDI)V", "public")]
	public void setArc(Dova.JDK.java.awt.geom.Point2D arg0, Dova.JDK.java.awt.geom.Dimension2D arg1, double arg2, double arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(DDDDDDI)V", "public abstract")]
	public void setArc(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Rectangle2D;DDI)V", "public")]
	public void setArc(Dova.JDK.java.awt.geom.Rectangle2D arg0, double arg1, double arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Arc2D;)V", "public")]
	public void setArc(Dova.JDK.java.awt.geom.Arc2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(DDDDDI)V", "public")]
	public void setArcByCenter(double arg0, double arg1, double arg2, double arg3, double arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Point2D;)V", "public")]
	public void setAngleStart(Dova.JDK.java.awt.geom.Point2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(D)V", "public abstract")]
	public void setAngleStart(double arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(D)V", "public abstract")]
	public void setAngleExtent(double arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(DDDD)V", "public")]
	public void setAngles(double arg0, double arg1, double arg2, double arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;)V", "public")]
	public void setAngles(Dova.JDK.java.awt.geom.Point2D arg0, Dova.JDK.java.awt.geom.Point2D arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("(DDDD)Ljava/awt/geom/Rectangle2D;", "protected abstract")]
	public Dova.JDK.java.awt.geom.Rectangle2D makeBounds(double arg0, double arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getArcType()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("(D)Z", "public")]
	public bool containsAngle(double arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(D)D", "static")]
	public static double normalizeDegrees(double arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;D)V", "public")]
	public void setArcByTangent(Dova.JDK.java.awt.geom.Point2D arg0, Dova.JDK.java.awt.geom.Point2D arg1, Dova.JDK.java.awt.geom.Point2D arg2, double arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(DDDD)V", "public")]
	public void setFrame(double arg0, double arg1, double arg2, double arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "public")]
	public Dova.JDK.java.awt.geom.Rectangle2D getBounds2D()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;)Ljava/awt/geom/PathIterator;", "public")]
	public Dova.JDK.java.awt.geom.PathIterator getPathIterator(Dova.JDK.java.awt.geom.AffineTransform arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.PathIterator>(ret);
	}

	[JniSignatureAttribute("(DDDD)Z", "public")]
	public bool intersects(double arg0, double arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("Ljava/awt/geom/Arc2D$Double;", "public static")]
	public partial class Double
		: Dova.JDK.java.awt.geom.Arc2D
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Double()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/geom/Arc2D$Double;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "y", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "width", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "height", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "start", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "extent", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/geom/Rectangle2D;DDI)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(DDDDDDI)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAngleStart", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAngleExtent", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setArc", "(DDDDDDI)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAngleStart", "(D)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAngleExtent", "(D)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeBounds", "(DDDD)Ljava/awt/geom/Rectangle2D;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWidth", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeight", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getY", "()D"));
		}

		[JniSignatureAttribute("D", "public")]
		public double x_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("D", "public")]
		public double y_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("D", "public")]
		public double width_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("D", "public")]
		public double height_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("D", "public")]
		public double start_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("D", "public")]
		public double extent_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Double(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/awt/geom/Rectangle2D;DDI)V", "public")]
		public Double(Dova.JDK.java.awt.geom.Rectangle2D arg0, double arg1, double arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(DDDDDDI)V", "public")]
		public Double(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, int arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
		{
		}

		[JniSignatureAttribute("(I)V", "public")]
		public Double(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Double() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/geom/Arc2D$Double;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool isEmpty()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
		public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
		public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()D", "public")]
		public double getAngleStart()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getAngleExtent()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(DDDDDDI)V", "public")]
		public void setArc(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, int arg6)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}

		[JniSignatureAttribute("(D)V", "public")]
		public void setAngleStart(double arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(D)V", "public")]
		public void setAngleExtent(double arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(DDDD)Ljava/awt/geom/Rectangle2D;", "protected")]
		public Dova.JDK.java.awt.geom.Rectangle2D makeBounds(double arg0, double arg1, double arg2, double arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
		}

		[JniSignatureAttribute("()D", "public")]
		public double getWidth()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getHeight()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getX()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getY()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/Arc2D$Float;", "public static")]
	public partial class Float
		: Dova.JDK.java.awt.geom.Arc2D
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Float()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/geom/Arc2D$Float;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "y", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "width", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "height", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "start", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "extent", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/geom/Rectangle2D;FFI)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(FFFFFFI)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAngleStart", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAngleExtent", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setArc", "(DDDDDDI)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAngleStart", "(D)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAngleExtent", "(D)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeBounds", "(DDDD)Ljava/awt/geom/Rectangle2D;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWidth", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeight", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getY", "()D"));
		}

		[JniSignatureAttribute("F", "public")]
		public float x_Property
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
		public float y_Property
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
		public float width_Property
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
		public float height_Property
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
		public float start_Property
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
		public float extent_Property
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

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Float(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/awt/geom/Rectangle2D;FFI)V", "public")]
		public Float(Dova.JDK.java.awt.geom.Rectangle2D arg0, float arg1, float arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(FFFFFFI)V", "public")]
		public Float(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, int arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
		{
		}

		[JniSignatureAttribute("(I)V", "public")]
		public Float(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Float() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/geom/Arc2D$Float;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool isEmpty()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
		public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
		public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()D", "public")]
		public double getAngleStart()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getAngleExtent()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(DDDDDDI)V", "public")]
		public void setArc(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, int arg6)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}

		[JniSignatureAttribute("(D)V", "public")]
		public void setAngleStart(double arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(D)V", "public")]
		public void setAngleExtent(double arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(DDDD)Ljava/awt/geom/Rectangle2D;", "protected")]
		public Dova.JDK.java.awt.geom.Rectangle2D makeBounds(double arg0, double arg1, double arg2, double arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
		}

		[JniSignatureAttribute("()D", "public")]
		public double getWidth()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getHeight()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getX()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getY()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}
	}
}
