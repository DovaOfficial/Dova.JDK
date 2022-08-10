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

namespace Dova.JDK.sun.java2d.loops;

[JniSignatureAttribute("Lsun/java2d/loops/GraphicsPrimitive;", "public abstract")]
public partial class GraphicsPrimitive
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GraphicsPrimitive()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/GraphicsPrimitive;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "methodSignature", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "uniqueID", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "unusedPrimID", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "sourceType", "Lsun/java2d/loops/SurfaceType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "compositeType", "Lsun/java2d/loops/CompositeType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "destType", "Lsun/java2d/loops/SurfaceType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "pNativePrim", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "traceMap", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "traceflags", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "tracefile", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "traceout", "Ljava/io/PrintStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TRACELOG", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TRACETIMESTAMP", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TRACECOUNTS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cachedname", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GraphicsPrimitive", "(Ljava/lang/String;ILsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GraphicsPrimitive", "(JLjava/lang/String;ILsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSignature", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createConverter", "(Lsun/java2d/loops/SurfaceType;Lsun/java2d/loops/SurfaceType;)Lsun/java2d/loops/Blit;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNativePrim", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTraceOutputFile", "()Ljava/io/PrintStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPrimTypeID", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSourceType", "()Lsun/java2d/loops/SurfaceType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDestType", "()Lsun/java2d/loops/SurfaceType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getGeneralOp", "(ILsun/java2d/loops/CompositeType;)Lsun/java2d/loops/GraphicsPrimitive;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "convertFrom", "(Lsun/java2d/loops/Blit;Lsun/java2d/SurfaceData;IIIILsun/java2d/SurfaceData;I)Lsun/java2d/SurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "convertFrom", "(Lsun/java2d/loops/Blit;Lsun/java2d/SurfaceData;IIIILsun/java2d/SurfaceData;)Lsun/java2d/SurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "simplename", "(Lsun/java2d/loops/SurfaceType;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "simplename", "(Lsun/java2d/loops/CompositeType;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "simplename", "([Ljava/lang/reflect/Field;Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makePrimTypeID", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "satisfies", "(Ljava/lang/String;Lsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "satisfiesSameAs", "(Lsun/java2d/loops/GraphicsPrimitive;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "makePrimitive", "(Lsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)Lsun/java2d/loops/GraphicsPrimitive;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "traceWrap", "()Lsun/java2d/loops/GraphicsPrimitive;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "tracingEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "tracePrimitive", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setupGeneralBinaryOp", "(Lsun/java2d/loops/GraphicsPrimitive$GeneralBinaryOp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setupGeneralUnaryOp", "(Lsun/java2d/loops/GraphicsPrimitive$GeneralUnaryOp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "convertTo", "(Lsun/java2d/loops/Blit;Lsun/java2d/SurfaceData;Lsun/java2d/SurfaceData;Lsun/java2d/pipe/Region;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeUniqueID", "(ILsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getUniqueID", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCompositeType", "()Lsun/java2d/loops/CompositeType;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String methodSignature_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int uniqueID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("I", "private static")]
	public static int unusedPrimID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("Lsun/java2d/loops/SurfaceType;", "private")]
	public Dova.JDK.sun.java2d.loops.SurfaceType sourceType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.SurfaceType>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/java2d/loops/CompositeType;", "private")]
	public Dova.JDK.sun.java2d.loops.CompositeType compositeType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.CompositeType>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/java2d/loops/SurfaceType;", "private")]
	public Dova.JDK.sun.java2d.loops.SurfaceType destType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.SurfaceType>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "private")]
	public long pNativePrim_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "static")]
	public static Dova.JDK.java.util.HashMap traceMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "public static")]
	public static int traceflags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String tracefile_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/io/PrintStream;", "public static")]
	public static Dova.JDK.java.io.PrintStream traceout_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintStream>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int TRACELOG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int TRACETIMESTAMP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int TRACECOUNTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String cachedname_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GraphicsPrimitive(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)V", "protected")]
	public GraphicsPrimitive(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.sun.java2d.loops.SurfaceType arg2, Dova.JDK.sun.java2d.loops.CompositeType arg3, Dova.JDK.sun.java2d.loops.SurfaceType arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(JLjava/lang/String;ILsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)V", "protected")]
	public GraphicsPrimitive(long arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.sun.java2d.loops.SurfaceType arg3, Dova.JDK.sun.java2d.loops.CompositeType arg4, Dova.JDK.sun.java2d.loops.SurfaceType arg5) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/loops/GraphicsPrimitive;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String getSignature()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/SurfaceType;Lsun/java2d/loops/SurfaceType;)Lsun/java2d/loops/Blit;", "protected static")]
	public static Dova.JDK.sun.java2d.loops.Blit createConverter(Dova.JDK.sun.java2d.loops.SurfaceType arg0, Dova.JDK.sun.java2d.loops.SurfaceType arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.Blit>(ret);
	}

	[JniSignatureAttribute("()J", "public final")]
	public long getNativePrim()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/io/PrintStream;", "private static")]
	public static Dova.JDK.java.io.PrintStream getTraceOutputFile()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintStream>(ret);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int getPrimTypeID()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/java2d/loops/SurfaceType;", "public final")]
	public Dova.JDK.sun.java2d.loops.SurfaceType getSourceType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.SurfaceType>(ret);
	}

	[JniSignatureAttribute("()Lsun/java2d/loops/SurfaceType;", "public final")]
	public Dova.JDK.sun.java2d.loops.SurfaceType getDestType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.SurfaceType>(ret);
	}

	[JniSignatureAttribute("(ILsun/java2d/loops/CompositeType;)Lsun/java2d/loops/GraphicsPrimitive;", "protected static")]
	public static Dova.JDK.sun.java2d.loops.GraphicsPrimitive getGeneralOp(int arg0, Dova.JDK.sun.java2d.loops.CompositeType arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.GraphicsPrimitive>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/Blit;Lsun/java2d/SurfaceData;IIIILsun/java2d/SurfaceData;I)Lsun/java2d/SurfaceData;", "protected static")]
	public static Dova.JDK.sun.java2d.SurfaceData convertFrom(Dova.JDK.sun.java2d.loops.Blit arg0, Dova.JDK.sun.java2d.SurfaceData arg1, int arg2, int arg3, int arg4, int arg5, Dova.JDK.sun.java2d.SurfaceData arg6, int arg7)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/Blit;Lsun/java2d/SurfaceData;IIIILsun/java2d/SurfaceData;)Lsun/java2d/SurfaceData;", "protected static")]
	public static Dova.JDK.sun.java2d.SurfaceData convertFrom(Dova.JDK.sun.java2d.loops.Blit arg0, Dova.JDK.sun.java2d.SurfaceData arg1, int arg2, int arg3, int arg4, int arg5, Dova.JDK.sun.java2d.SurfaceData arg6)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/SurfaceType;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String simplename(Dova.JDK.sun.java2d.loops.SurfaceType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/CompositeType;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String simplename(Dova.JDK.sun.java2d.loops.CompositeType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Field;Ljava/lang/Object;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String simplename(JavaArray<Dova.JDK.java.lang.reflect.Field> arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public static final synchronized")]
	public static int makePrimTypeID()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)Z", "public final")]
	public bool satisfies(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.java2d.loops.SurfaceType arg1, Dova.JDK.sun.java2d.loops.CompositeType arg2, Dova.JDK.sun.java2d.loops.SurfaceType arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/GraphicsPrimitive;)Z", "final")]
	public bool satisfiesSameAs(Dova.JDK.sun.java2d.loops.GraphicsPrimitive arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)Lsun/java2d/loops/GraphicsPrimitive;", "protected")]
	public Dova.JDK.sun.java2d.loops.GraphicsPrimitive makePrimitive(Dova.JDK.sun.java2d.loops.SurfaceType arg0, Dova.JDK.sun.java2d.loops.CompositeType arg1, Dova.JDK.sun.java2d.loops.SurfaceType arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.GraphicsPrimitive>(ret);
	}

	[JniSignatureAttribute("()Lsun/java2d/loops/GraphicsPrimitive;", "public abstract")]
	public Dova.JDK.sun.java2d.loops.GraphicsPrimitive traceWrap()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.GraphicsPrimitive>(ret);
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool tracingEnabled()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public static synchronized")]
	public static void tracePrimitive(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/GraphicsPrimitive$GeneralBinaryOp;)V", "protected")]
	public void setupGeneralBinaryOp(Dova.JDK.sun.java2d.loops.GraphicsPrimitive.GeneralBinaryOp arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/GraphicsPrimitive$GeneralUnaryOp;)V", "protected")]
	public void setupGeneralUnaryOp(Dova.JDK.sun.java2d.loops.GraphicsPrimitive.GeneralUnaryOp arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/Blit;Lsun/java2d/SurfaceData;Lsun/java2d/SurfaceData;Lsun/java2d/pipe/Region;IIII)V", "protected static")]
	public static void convertTo(Dova.JDK.sun.java2d.loops.Blit arg0, Dova.JDK.sun.java2d.SurfaceData arg1, Dova.JDK.sun.java2d.SurfaceData arg2, Dova.JDK.sun.java2d.pipe.Region arg3, int arg4, int arg5, int arg6, int arg7)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(ILsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)I", "public static final synchronized")]
	public static int makeUniqueID(int arg0, Dova.JDK.sun.java2d.loops.SurfaceType arg1, Dova.JDK.sun.java2d.loops.CompositeType arg2, Dova.JDK.sun.java2d.loops.SurfaceType arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("()I", "public final")]
	public int getUniqueID()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/java2d/loops/CompositeType;", "public final")]
	public Dova.JDK.sun.java2d.loops.CompositeType getCompositeType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.CompositeType>(ret);
	}

	[JniSignatureAttribute("Lsun/java2d/loops/GraphicsPrimitive$TraceReporter;", "public static")]
	public partial class TraceReporter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Runnable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TraceReporter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/GraphicsPrimitive$TraceReporter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TraceReporter", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "run", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setShutdownHook", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TraceReporter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public TraceReporter() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/loops/GraphicsPrimitive$TraceReporter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()V", "public static")]
		public static void setShutdownHook()
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1]);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/loops/GraphicsPrimitive$GeneralBinaryOp;", "protected abstract static interface")]
	public partial interface GeneralBinaryOp
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GeneralBinaryOp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/GraphicsPrimitive$GeneralBinaryOp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSignature", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPrimTypeID", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSourceType", "()Lsun/java2d/loops/SurfaceType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDestType", "()Lsun/java2d/loops/SurfaceType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPrimitives", "(Lsun/java2d/loops/Blit;Lsun/java2d/loops/Blit;Lsun/java2d/loops/GraphicsPrimitive;Lsun/java2d/loops/Blit;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCompositeType", "()Lsun/java2d/loops/CompositeType;"));
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getSignature()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int getPrimTypeID()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Lsun/java2d/loops/SurfaceType;", "public abstract")]
		Dova.JDK.sun.java2d.loops.SurfaceType getSourceType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.SurfaceType>(ret);
		}

		[JniSignatureAttribute("()Lsun/java2d/loops/SurfaceType;", "public abstract")]
		Dova.JDK.sun.java2d.loops.SurfaceType getDestType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.SurfaceType>(ret);
		}

		[JniSignatureAttribute("(Lsun/java2d/loops/Blit;Lsun/java2d/loops/Blit;Lsun/java2d/loops/GraphicsPrimitive;Lsun/java2d/loops/Blit;)V", "public abstract")]
		void setPrimitives(Dova.JDK.sun.java2d.loops.Blit arg0, Dova.JDK.sun.java2d.loops.Blit arg1, Dova.JDK.sun.java2d.loops.GraphicsPrimitive arg2, Dova.JDK.sun.java2d.loops.Blit arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("()Lsun/java2d/loops/CompositeType;", "public abstract")]
		Dova.JDK.sun.java2d.loops.CompositeType getCompositeType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.CompositeType>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/loops/GraphicsPrimitive$GeneralUnaryOp;", "protected abstract static interface")]
	public partial interface GeneralUnaryOp
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GeneralUnaryOp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/GraphicsPrimitive$GeneralUnaryOp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSignature", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPrimTypeID", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDestType", "()Lsun/java2d/loops/SurfaceType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPrimitives", "(Lsun/java2d/loops/Blit;Lsun/java2d/loops/GraphicsPrimitive;Lsun/java2d/loops/Blit;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCompositeType", "()Lsun/java2d/loops/CompositeType;"));
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getSignature()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int getPrimTypeID()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Lsun/java2d/loops/SurfaceType;", "public abstract")]
		Dova.JDK.sun.java2d.loops.SurfaceType getDestType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.SurfaceType>(ret);
		}

		[JniSignatureAttribute("(Lsun/java2d/loops/Blit;Lsun/java2d/loops/GraphicsPrimitive;Lsun/java2d/loops/Blit;)V", "public abstract")]
		void setPrimitives(Dova.JDK.sun.java2d.loops.Blit arg0, Dova.JDK.sun.java2d.loops.GraphicsPrimitive arg1, Dova.JDK.sun.java2d.loops.Blit arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()Lsun/java2d/loops/CompositeType;", "public abstract")]
		Dova.JDK.sun.java2d.loops.CompositeType getCompositeType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.CompositeType>(ret);
		}
	}
}
