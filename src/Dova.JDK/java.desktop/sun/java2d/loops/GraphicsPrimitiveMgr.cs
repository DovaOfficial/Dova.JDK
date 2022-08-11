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

namespace Dova.JDK.sun.java2d.loops;

[JniSignatureAttribute("Lsun/java2d/loops/GraphicsPrimitiveMgr;", "public final")]
public partial class GraphicsPrimitiveMgr
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GraphicsPrimitiveMgr()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/GraphicsPrimitiveMgr;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "debugTrace", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "primitives", "[Lsun/java2d/loops/GraphicsPrimitive;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "generalPrimitives", "[Lsun/java2d/loops/GraphicsPrimitive;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "needssort", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "primSorter", "Ljava/util/Comparator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "primFinder", "Ljava/util/Comparator;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "main", "([Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "register", "([Lsun/java2d/loops/GraphicsPrimitive;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initIDs", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "locatePrim", "(ILsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)Lsun/java2d/loops/GraphicsPrimitive;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "registerGeneral", "(Lsun/java2d/loops/GraphicsPrimitive;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "locateGeneral", "(I)Lsun/java2d/loops/GraphicsPrimitive;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "testPrimitiveInstantiation", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "testPrimitiveInstantiation", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "registerNativeLoops", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "writeLog", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "locate", "(ILsun/java2d/loops/SurfaceType;)Lsun/java2d/loops/GraphicsPrimitive;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "locate", "(ILsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)Lsun/java2d/loops/GraphicsPrimitive;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "locate", "(Lsun/java2d/loops/GraphicsPrimitiveMgr$PrimitiveSpec;)Lsun/java2d/loops/GraphicsPrimitive;"));
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool debugTrace_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("[Lsun/java2d/loops/GraphicsPrimitive;", "private static")]
	public static JavaArray<Dova.JDK.sun.java2d.loops.GraphicsPrimitive> primitives_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.java2d.loops.GraphicsPrimitive>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/java2d/loops/GraphicsPrimitive;", "private static")]
	public static JavaArray<Dova.JDK.sun.java2d.loops.GraphicsPrimitive> generalPrimitives_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.java2d.loops.GraphicsPrimitive>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static")]
	public static bool needssort_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Comparator;", "private static")]
	public static Dova.JDK.java.util.Comparator primSorter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Comparator;", "private static")]
	public static Dova.JDK.java.util.Comparator primFinder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GraphicsPrimitiveMgr(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public GraphicsPrimitiveMgr() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/loops/GraphicsPrimitiveMgr;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljava/lang/String;)V", "public static")]
	public static void main(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("([Lsun/java2d/loops/GraphicsPrimitive;)V", "public static synchronized")]
	public static void register(JavaArray<Dova.JDK.sun.java2d.loops.GraphicsPrimitive> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)V", "private static native")]
	public static void initIDs(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.lang.Class arg3, Dova.JDK.java.lang.Class arg4, Dova.JDK.java.lang.Class arg5, Dova.JDK.java.lang.Class arg6, Dova.JDK.java.lang.Class arg7, Dova.JDK.java.lang.Class arg8, Dova.JDK.java.lang.Class arg9, Dova.JDK.java.lang.Class arg10)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
	}

	[JniSignatureAttribute("(ILsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)Lsun/java2d/loops/GraphicsPrimitive;", "public static synchronized")]
	public static Dova.JDK.sun.java2d.loops.GraphicsPrimitive locatePrim(int arg0, Dova.JDK.sun.java2d.loops.SurfaceType arg1, Dova.JDK.sun.java2d.loops.CompositeType arg2, Dova.JDK.sun.java2d.loops.SurfaceType arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.GraphicsPrimitive>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/GraphicsPrimitive;)V", "public static synchronized")]
	public static void registerGeneral(Dova.JDK.sun.java2d.loops.GraphicsPrimitive arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(I)Lsun/java2d/loops/GraphicsPrimitive;", "private static")]
	public static Dova.JDK.sun.java2d.loops.GraphicsPrimitive locateGeneral(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.GraphicsPrimitive>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public static")]
	public static void testPrimitiveInstantiation(bool arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()V", "public static")]
	public static void testPrimitiveInstantiation()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("()V", "private static native")]
	public static void registerNativeLoops()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private static")]
	public static void writeLog(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(ILsun/java2d/loops/SurfaceType;)Lsun/java2d/loops/GraphicsPrimitive;", "public static synchronized")]
	public static Dova.JDK.sun.java2d.loops.GraphicsPrimitive locate(int arg0, Dova.JDK.sun.java2d.loops.SurfaceType arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.GraphicsPrimitive>(ret);
	}

	[JniSignatureAttribute("(ILsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)Lsun/java2d/loops/GraphicsPrimitive;", "public static synchronized")]
	public static Dova.JDK.sun.java2d.loops.GraphicsPrimitive locate(int arg0, Dova.JDK.sun.java2d.loops.SurfaceType arg1, Dova.JDK.sun.java2d.loops.CompositeType arg2, Dova.JDK.sun.java2d.loops.SurfaceType arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.GraphicsPrimitive>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/GraphicsPrimitiveMgr$PrimitiveSpec;)Lsun/java2d/loops/GraphicsPrimitive;", "private static")]
	public static Dova.JDK.sun.java2d.loops.GraphicsPrimitive locate(Dova.JDK.sun.java2d.loops.GraphicsPrimitiveMgr.PrimitiveSpec arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.GraphicsPrimitive>(ret);
	}

	[JniSignatureAttribute("Lsun/java2d/loops/GraphicsPrimitiveMgr$PrimitiveSpec;", "private static")]
	public partial class PrimitiveSpec
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PrimitiveSpec()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/GraphicsPrimitiveMgr$PrimitiveSpec;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "uniqueID", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "public")]
		public int uniqueID_Property
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
		public PrimitiveSpec(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public PrimitiveSpec() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/loops/GraphicsPrimitiveMgr$PrimitiveSpec;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
