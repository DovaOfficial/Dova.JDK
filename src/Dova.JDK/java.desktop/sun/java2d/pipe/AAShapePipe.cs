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

[JniSignatureAttribute("Lsun/java2d/pipe/AAShapePipe;", "public final")]
public partial class AAShapePipe
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.java2d.pipe.ShapeDrawPipe
	, Dova.JDK.sun.java2d.pipe.ParallelogramPipe
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AAShapePipe()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/AAShapePipe;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RDR_ENGINE", "Lsun/java2d/pipe/RenderingEngine;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TILE_STATE_PROVIDER", "Lsun/java2d/ReentrantContextProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outpipe", "Lsun/java2d/pipe/CompositePipe;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/pipe/CompositePipe;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fill", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "renderPath", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;Ljava/awt/BasicStroke;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "renderTiles", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;Lsun/java2d/pipe/AATileGenerator;[ILsun/java2d/pipe/AAShapePipe$TileState;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillParallelogram", "(Lsun/java2d/SunGraphics2D;DDDDDDDDDD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawParallelogram", "(Lsun/java2d/SunGraphics2D;DDDDDDDDDDDD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "draw", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;)V"));
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/RenderingEngine;", "static final")]
	public static Dova.JDK.sun.java2d.pipe.RenderingEngine RDR_ENGINE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderingEngine>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/ReentrantContextProvider;", "private static final")]
	public static Dova.JDK.sun.java2d.ReentrantContextProvider TILE_STATE_PROVIDER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.ReentrantContextProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/CompositePipe;", "final")]
	public Dova.JDK.sun.java2d.pipe.CompositePipe outpipe_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.CompositePipe>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AAShapePipe(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/CompositePipe;)V", "public")]
	public AAShapePipe(Dova.JDK.sun.java2d.pipe.CompositePipe arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/pipe/AAShapePipe;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;)V", "public")]
	public void fill(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Shape arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;Ljava/awt/BasicStroke;)V", "public")]
	public void renderPath(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.java.awt.BasicStroke arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;Lsun/java2d/pipe/AATileGenerator;[ILsun/java2d/pipe/AAShapePipe$TileState;)V", "public")]
	public void renderTiles(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.sun.java2d.pipe.AATileGenerator arg2, JavaArray<int> arg3, Dova.JDK.sun.java2d.pipe.AAShapePipe.TileState arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;DDDDDDDDDD)V", "public")]
	public void fillParallelogram(Dova.JDK.sun.java2d.SunGraphics2D arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7, double arg8, double arg9, double arg10)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;DDDDDDDDDDDD)V", "public")]
	public void drawParallelogram(Dova.JDK.sun.java2d.SunGraphics2D arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7, double arg8, double arg9, double arg10, double arg11, double arg12)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;)V", "public")]
	public void draw(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Shape arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/AAShapePipe$TileState;", "static final")]
	public partial class TileState
		: Dova.JDK.sun.java2d.ReentrantContext
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TileState()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/AAShapePipe$TileState;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "theTile", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "abox", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dev", "Ljava/awt/Rectangle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bbox2D", "Ljava/awt/geom/Rectangle2D$Double;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeBBox", "(DDDD)Ljava/awt/geom/Rectangle2D;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeDevBox", "([I)Ljava/awt/Rectangle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlphaTile", "(I)[B"));
		}

		[JniSignatureAttribute("[B", "private")]
		public JavaArray<byte> theTile_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[I", "final")]
		public JavaArray<int> abox_Property
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

		[JniSignatureAttribute("Ljava/awt/Rectangle;", "private final")]
		public Dova.JDK.java.awt.Rectangle dev_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/geom/Rectangle2D$Double;", "private final")]
		public Dova.JDK.java.awt.geom.Rectangle2D.Double bbox2D_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D.Double>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TileState(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public TileState() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/pipe/AAShapePipe$TileState;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(DDDD)Ljava/awt/geom/Rectangle2D;", "")]
		public Dova.JDK.java.awt.geom.Rectangle2D computeBBox(double arg0, double arg1, double arg2, double arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
		}

		[JniSignatureAttribute("([I)Ljava/awt/Rectangle;", "")]
		public Dova.JDK.java.awt.Rectangle computeDevBox(JavaArray<int> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}

		[JniSignatureAttribute("(I)[B", "")]
		public JavaArray<byte> getAlphaTile(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
	}
}
