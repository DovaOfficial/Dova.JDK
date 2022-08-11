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

[JniSignatureAttribute("Lsun/java2d/loops/DrawRect;", "public")]
public partial class DrawRect
	: Dova.JDK.sun.java2d.loops.GraphicsPrimitive
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DrawRect()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/DrawRect;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "methodSignature", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "primTypeID", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JLsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traceWrap", "()Lsun/java2d/loops/GraphicsPrimitive;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "DrawRect_0", "(Lsun/java2d/SunGraphics2D;Lsun/java2d/SurfaceData;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "locate", "(Lsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)Lsun/java2d/loops/DrawRect;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String methodSignature_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int primTypeID_Property
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
	public DrawRect(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(JLsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)V", "public")]
	public DrawRect(long arg0, Dova.JDK.sun.java2d.loops.SurfaceType arg1, Dova.JDK.sun.java2d.loops.CompositeType arg2, Dova.JDK.sun.java2d.loops.SurfaceType arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)V", "protected")]
	public DrawRect(Dova.JDK.sun.java2d.loops.SurfaceType arg0, Dova.JDK.sun.java2d.loops.CompositeType arg1, Dova.JDK.sun.java2d.loops.SurfaceType arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/loops/DrawRect;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/java2d/loops/GraphicsPrimitive;", "public")]
	public Dova.JDK.sun.java2d.loops.GraphicsPrimitive traceWrap()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.GraphicsPrimitive>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Lsun/java2d/SurfaceData;IIII)V", "public native")]
	public void DrawRect_0(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.sun.java2d.SurfaceData arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)Lsun/java2d/loops/DrawRect;", "public static")]
	public static Dova.JDK.sun.java2d.loops.DrawRect locate(Dova.JDK.sun.java2d.loops.SurfaceType arg0, Dova.JDK.sun.java2d.loops.CompositeType arg1, Dova.JDK.sun.java2d.loops.SurfaceType arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.DrawRect>(ret);
	}

	[JniSignatureAttribute("Lsun/java2d/loops/DrawRect$TraceDrawRect;", "private static")]
	public partial class TraceDrawRect
		: Dova.JDK.sun.java2d.loops.DrawRect
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TraceDrawRect()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/DrawRect$TraceDrawRect;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Lsun/java2d/loops/DrawRect;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/loops/DrawRect;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traceWrap", "()Lsun/java2d/loops/GraphicsPrimitive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "DrawRect", "(Lsun/java2d/SunGraphics2D;Lsun/java2d/SurfaceData;IIII)V"));
		}

		[JniSignatureAttribute("Lsun/java2d/loops/DrawRect;", "")]
		public Dova.JDK.sun.java2d.loops.DrawRect target_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.DrawRect>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TraceDrawRect(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/java2d/loops/DrawRect;)V", "public")]
		public TraceDrawRect(Dova.JDK.sun.java2d.loops.DrawRect arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/loops/DrawRect$TraceDrawRect;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lsun/java2d/loops/GraphicsPrimitive;", "public")]
		public Dova.JDK.sun.java2d.loops.GraphicsPrimitive traceWrap()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.GraphicsPrimitive>(ret);
		}

		[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Lsun/java2d/SurfaceData;IIII)V", "public")]
		public void DrawRect(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.sun.java2d.SurfaceData arg1, int arg2, int arg3, int arg4, int arg5)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
		}
	}
}
