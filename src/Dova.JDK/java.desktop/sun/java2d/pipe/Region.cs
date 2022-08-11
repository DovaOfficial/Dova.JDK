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

namespace Dova.JDK.sun.java2d.pipe;

[JniSignatureAttribute("Lsun/java2d/pipe/Region;", "public final")]
public partial class Region
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Region()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/Region;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INIT_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GROW_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_REGION", "Lsun/java2d/pipe/Region;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WHOLE_REGION", "Lsun/java2d/pipe/Region;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lox", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loy", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hix", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hiy", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bands", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INCLUDE_A", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INCLUDE_B", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INCLUDE_COMMON", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIII[II)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "([I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter", "(Lsun/java2d/pipe/SpanIterator;)Lsun/java2d/pipe/SpanIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "([I)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/awt/Rectangle;)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "([ILsun/java2d/pipe/SpanIterator;)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Lsun/java2d/pipe/Region;Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(IIII[I)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Lsun/java2d/pipe/Region;ZLjava/awt/Shape;Ljava/awt/geom/AffineTransform;)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIterator", "()Lsun/java2d/pipe/RegionIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initIDs", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHiX", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHiY", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "clipAdd", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "dimAdd", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstanceXYXY", "(IIII)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendSpans", "(Lsun/java2d/pipe/SpanIterator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendSpan", "([I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calcBBox", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "clipScale", "(ID)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSafeTranslatedRegion", "(II)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntersectionXYWH", "(IIII)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntersectionXYXY", "(IIII)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntersectionXYXY", "(DDDD)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInsideXYXY", "(IIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpanIterator", "([I)Lsun/java2d/pipe/SpanIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpanIterator", "()Lsun/java2d/pipe/SpanIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInsideQuickCheck", "(Lsun/java2d/pipe/Region;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filterSpans", "(Lsun/java2d/pipe/Region;Lsun/java2d/pipe/Region;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intersectsQuickCheck", "(Lsun/java2d/pipe/Region;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBoundsIntersectionXYWH", "(IIII)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBoundsIntersectionXYXY", "(IIII)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encompasses", "(Lsun/java2d/pipe/Region;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needSpace", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encompassesXYXY", "(IIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScaledRegion", "(DD)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExclusiveOr", "(Lsun/java2d/pipe/Region;)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBoundsIntersection", "(Lsun/java2d/pipe/Region;)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBoundsIntersection", "(Ljava/awt/Rectangle;)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRectangular", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInsideXYWH", "(IIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intersectsQuickCheckXYXY", "(IIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encompassesXYWH", "(IIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clipBoxToBounds", "([I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "clipRound", "(D)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endRow", "([I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoY", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoX", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWidth", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeight", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTranslatedRegion", "(II)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstanceXYWH", "(IIII)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDifference", "(Lsun/java2d/pipe/Region;)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntersection", "(Ljava/awt/Rectangle;)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntersection", "(Ljava/awt/geom/Rectangle2D;)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntersection", "(Lsun/java2d/pipe/Region;)Lsun/java2d/pipe/Region;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnion", "(Lsun/java2d/pipe/Region;)Lsun/java2d/pipe/Region;"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int INIT_SIZE_Property
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
	public static int GROW_SIZE_Property
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

	[JniSignatureAttribute("Lsun/java2d/pipe/Region;", "public static final")]
	public static Dova.JDK.sun.java2d.pipe.Region EMPTY_REGION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/Region;", "public static final")]
	public static Dova.JDK.sun.java2d.pipe.Region WHOLE_REGION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int lox_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int loy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int hix_Property
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

	[JniSignatureAttribute("I", "private")]
	public int hiy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int endIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("[I", "")]
	public JavaArray<int> bands_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int INCLUDE_A_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int INCLUDE_B_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int INCLUDE_COMMON_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Region(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(IIII[II)V", "private")]
	public Region(int arg0, int arg1, int arg2, int arg3, JavaArray<int> arg4, int arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(IIII)V", "private")]
	public Region(int arg0, int arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/pipe/Region;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isEmpty()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(II)Z", "public")]
	public bool contains(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([I)V", "public")]
	public void getBounds(JavaArray<int> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/SpanIterator;)Lsun/java2d/pipe/SpanIterator;", "public")]
	public Dova.JDK.sun.java2d.pipe.SpanIterator filter(Dova.JDK.sun.java2d.pipe.SpanIterator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.SpanIterator>(ret);
	}

	[JniSignatureAttribute("([I)Lsun/java2d/pipe/Region;", "public static")]
	public static Dova.JDK.sun.java2d.pipe.Region getInstance(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)Lsun/java2d/pipe/Region;", "public static")]
	public static Dova.JDK.sun.java2d.pipe.Region getInstance(Dova.JDK.java.awt.Rectangle arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("([ILsun/java2d/pipe/SpanIterator;)Lsun/java2d/pipe/Region;", "public static")]
	public static Dova.JDK.sun.java2d.pipe.Region getInstance(JavaArray<int> arg0, Dova.JDK.sun.java2d.pipe.SpanIterator arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;)Lsun/java2d/pipe/Region;", "public static")]
	public static Dova.JDK.sun.java2d.pipe.Region getInstance(Dova.JDK.java.awt.Shape arg0, Dova.JDK.java.awt.geom.AffineTransform arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/Region;Ljava/awt/Shape;Ljava/awt/geom/AffineTransform;)Lsun/java2d/pipe/Region;", "public static")]
	public static Dova.JDK.sun.java2d.pipe.Region getInstance(Dova.JDK.sun.java2d.pipe.Region arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.java.awt.geom.AffineTransform arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(IIII[I)Lsun/java2d/pipe/Region;", "static")]
	public static Dova.JDK.sun.java2d.pipe.Region getInstance(int arg0, int arg1, int arg2, int arg3, JavaArray<int> arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/Region;ZLjava/awt/Shape;Ljava/awt/geom/AffineTransform;)Lsun/java2d/pipe/Region;", "public static")]
	public static Dova.JDK.sun.java2d.pipe.Region getInstance(Dova.JDK.sun.java2d.pipe.Region arg0, bool arg1, Dova.JDK.java.awt.Shape arg2, Dova.JDK.java.awt.geom.AffineTransform arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("()Lsun/java2d/pipe/RegionIterator;", "public")]
	public Dova.JDK.sun.java2d.pipe.RegionIterator getIterator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RegionIterator>(ret);
	}

	[JniSignatureAttribute("()V", "private static native")]
	public static void initIDs()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[15]);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getHiX()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getHiY()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "public static")]
	public static int clipAdd(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "public static")]
	public static int dimAdd(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(IIII)Lsun/java2d/pipe/Region;", "public static")]
	public static Dova.JDK.sun.java2d.pipe.Region getInstanceXYXY(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/SpanIterator;)V", "private")]
	public void appendSpans(Dova.JDK.sun.java2d.pipe.SpanIterator arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("([I)V", "private")]
	public void appendSpan(JavaArray<int> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void calcBBox()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23]);
	}

	[JniSignatureAttribute("(ID)I", "public static")]
	public static int clipScale(int arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)Lsun/java2d/pipe/Region;", "private")]
	public Dova.JDK.sun.java2d.pipe.Region getSafeTranslatedRegion(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(IIII)Lsun/java2d/pipe/Region;", "public")]
	public Dova.JDK.sun.java2d.pipe.Region getIntersectionXYWH(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(IIII)Lsun/java2d/pipe/Region;", "public")]
	public Dova.JDK.sun.java2d.pipe.Region getIntersectionXYXY(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(DDDD)Lsun/java2d/pipe/Region;", "public")]
	public Dova.JDK.sun.java2d.pipe.Region getIntersectionXYXY(double arg0, double arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(IIII)Z", "public")]
	public bool isInsideXYXY(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([I)Lsun/java2d/pipe/SpanIterator;", "public")]
	public Dova.JDK.sun.java2d.pipe.SpanIterator getSpanIterator(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.SpanIterator>(ret);
	}

	[JniSignatureAttribute("()Lsun/java2d/pipe/SpanIterator;", "public")]
	public Dova.JDK.sun.java2d.pipe.SpanIterator getSpanIterator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.SpanIterator>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/Region;)Z", "public")]
	public bool isInsideQuickCheck(Dova.JDK.sun.java2d.pipe.Region arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/Region;Lsun/java2d/pipe/Region;I)V", "private")]
	public void filterSpans(Dova.JDK.sun.java2d.pipe.Region arg0, Dova.JDK.sun.java2d.pipe.Region arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/Region;)Z", "public")]
	public bool intersectsQuickCheck(Dova.JDK.sun.java2d.pipe.Region arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IIII)Lsun/java2d/pipe/Region;", "public")]
	public Dova.JDK.sun.java2d.pipe.Region getBoundsIntersectionXYWH(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(IIII)Lsun/java2d/pipe/Region;", "public")]
	public Dova.JDK.sun.java2d.pipe.Region getBoundsIntersectionXYXY(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/Region;)Z", "public")]
	public bool encompasses(Dova.JDK.sun.java2d.pipe.Region arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void needSpace(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("(IIII)Z", "public")]
	public bool encompassesXYXY(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(DD)Lsun/java2d/pipe/Region;", "public")]
	public Dova.JDK.sun.java2d.pipe.Region getScaledRegion(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/Region;)Lsun/java2d/pipe/Region;", "public")]
	public Dova.JDK.sun.java2d.pipe.Region getExclusiveOr(Dova.JDK.sun.java2d.pipe.Region arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/Region;)Lsun/java2d/pipe/Region;", "public")]
	public Dova.JDK.sun.java2d.pipe.Region getBoundsIntersection(Dova.JDK.sun.java2d.pipe.Region arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)Lsun/java2d/pipe/Region;", "public")]
	public Dova.JDK.sun.java2d.pipe.Region getBoundsIntersection(Dova.JDK.java.awt.Rectangle arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isRectangular()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[44]);
		return ret;
	}

	[JniSignatureAttribute("(IIII)Z", "public")]
	public bool isInsideXYWH(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(IIII)Z", "public")]
	public bool intersectsQuickCheckXYXY(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(IIII)Z", "public")]
	public bool encompassesXYWH(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([I)V", "public")]
	public void clipBoxToBounds(JavaArray<int> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
	}

	[JniSignatureAttribute("(D)I", "public static")]
	public static int clipRound(double arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[49], arg0);
		return ret;
	}

	[JniSignatureAttribute("([I)V", "private")]
	public void endRow(JavaArray<int> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getLoY()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[51]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getLoX()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[52]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getWidth()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[53]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getHeight()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[54]);
		return ret;
	}

	[JniSignatureAttribute("(II)Lsun/java2d/pipe/Region;", "public")]
	public Dova.JDK.sun.java2d.pipe.Region getTranslatedRegion(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(IIII)Lsun/java2d/pipe/Region;", "public static")]
	public static Dova.JDK.sun.java2d.pipe.Region getInstanceXYWH(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[56], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/Region;)Lsun/java2d/pipe/Region;", "public")]
	public Dova.JDK.sun.java2d.pipe.Region getDifference(Dova.JDK.sun.java2d.pipe.Region arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)Lsun/java2d/pipe/Region;", "public")]
	public Dova.JDK.sun.java2d.pipe.Region getIntersection(Dova.JDK.java.awt.Rectangle arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Rectangle2D;)Lsun/java2d/pipe/Region;", "public")]
	public Dova.JDK.sun.java2d.pipe.Region getIntersection(Dova.JDK.java.awt.geom.Rectangle2D arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/Region;)Lsun/java2d/pipe/Region;", "public")]
	public Dova.JDK.sun.java2d.pipe.Region getIntersection(Dova.JDK.sun.java2d.pipe.Region arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/Region;)Lsun/java2d/pipe/Region;", "public")]
	public Dova.JDK.sun.java2d.pipe.Region getUnion(Dova.JDK.sun.java2d.pipe.Region arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
	}
}
