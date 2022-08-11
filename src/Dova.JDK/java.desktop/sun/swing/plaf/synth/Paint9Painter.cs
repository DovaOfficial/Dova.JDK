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

namespace Dova.JDK.sun.swing.plaf.synth;

[JniSignatureAttribute("Lsun/swing/plaf/synth/Paint9Painter;", "public")]
public partial class Paint9Painter
	: Dova.JDK.sun.swing.CachedPainter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Paint9Painter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/swing/plaf/synth/Paint9Painter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_INSETS", "Ljava/awt/Insets;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PAINT_TOP_LEFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PAINT_TOP", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PAINT_TOP_RIGHT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PAINT_LEFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PAINT_CENTER", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PAINT_RIGHT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PAINT_BOTTOM_RIGHT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PAINT_BOTTOM", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PAINT_BOTTOM_LEFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PAINT_ALL", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint9", "(Ljava/awt/Graphics;IIIILjava/awt/Image;Ljava/awt/Insets;Ljava/awt/Insets;Lsun/swing/plaf/synth/Paint9Painter$PaintType;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "validImage", "(Ljava/awt/Image;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawChunk", "(Ljava/awt/Image;Ljava/awt/Graphics;ZIIIIIIIIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintToImage", "(Ljava/awt/Component;Ljava/awt/Image;Ljava/awt/Graphics;II[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Component;Ljava/awt/Graphics;IIIILjava/awt/Image;Ljava/awt/Insets;Ljava/awt/Insets;Lsun/swing/plaf/synth/Paint9Painter$PaintType;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createImage", "(Ljava/awt/Component;IILjava/awt/GraphicsConfiguration;[Ljava/lang/Object;)Ljava/awt/Image;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/Image;Ljava/awt/Graphics;IIIIIIII)V"));
	}

	[JniSignatureAttribute("Ljava/awt/Insets;", "private static final")]
	public static Dova.JDK.java.awt.Insets EMPTY_INSETS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int PAINT_TOP_LEFT_Property
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
	public static int PAINT_TOP_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int PAINT_TOP_RIGHT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int PAINT_LEFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int PAINT_CENTER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int PAINT_RIGHT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int PAINT_BOTTOM_RIGHT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int PAINT_BOTTOM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int PAINT_BOTTOM_LEFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int PAINT_ALL_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Paint9Painter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public Paint9Painter(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/swing/plaf/synth/Paint9Painter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Graphics;IIIILjava/awt/Image;Ljava/awt/Insets;Ljava/awt/Insets;Lsun/swing/plaf/synth/Paint9Painter$PaintType;I)V", "protected")]
	public void paint9(Dova.JDK.java.awt.Graphics arg0, int arg1, int arg2, int arg3, int arg4, Dova.JDK.java.awt.Image arg5, Dova.JDK.java.awt.Insets arg6, Dova.JDK.java.awt.Insets arg7, Dova.JDK.sun.swing.plaf.synth.Paint9Painter.PaintType arg8, int arg9)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("(Ljava/awt/Image;)Z", "public static")]
	public static bool validImage(Dova.JDK.java.awt.Image arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Image;Ljava/awt/Graphics;ZIIIIIIIIZ)V", "private")]
	public void drawChunk(Dova.JDK.java.awt.Image arg0, Dova.JDK.java.awt.Graphics arg1, bool arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10, bool arg11)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Image;Ljava/awt/Graphics;II[Ljava/lang/Object;)V", "protected")]
	public void paintToImage(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Image arg1, Dova.JDK.java.awt.Graphics arg2, int arg3, int arg4, JavaArray<Dova.JDK.java.lang.Object> arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;IIIILjava/awt/Image;Ljava/awt/Insets;Ljava/awt/Insets;Lsun/swing/plaf/synth/Paint9Painter$PaintType;I)V", "public")]
	public void paint(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3, int arg4, int arg5, Dova.JDK.java.awt.Image arg6, Dova.JDK.java.awt.Insets arg7, Dova.JDK.java.awt.Insets arg8, Dova.JDK.sun.swing.plaf.synth.Paint9Painter.PaintType arg9, int arg10)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;IILjava/awt/GraphicsConfiguration;[Ljava/lang/Object;)Ljava/awt/Image;", "protected")]
	public Dova.JDK.java.awt.Image createImage(Dova.JDK.java.awt.Component arg0, int arg1, int arg2, Dova.JDK.java.awt.GraphicsConfiguration arg3, JavaArray<Dova.JDK.java.lang.Object> arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Image>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Image;Ljava/awt/Graphics;IIIIIIII)V", "private")]
	public void drawImage(Dova.JDK.java.awt.Image arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("Lsun/swing/plaf/synth/Paint9Painter$PaintType;", "public static final")]
	public partial class PaintType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PaintType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/swing/plaf/synth/Paint9Painter$PaintType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CENTER", "Lsun/swing/plaf/synth/Paint9Painter$PaintType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TILE", "Lsun/swing/plaf/synth/Paint9Painter$PaintType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PAINT9_STRETCH", "Lsun/swing/plaf/synth/Paint9Painter$PaintType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PAINT9_TILE", "Lsun/swing/plaf/synth/Paint9Painter$PaintType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/swing/plaf/synth/Paint9Painter$PaintType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/swing/plaf/synth/Paint9Painter$PaintType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/swing/plaf/synth/Paint9Painter$PaintType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/swing/plaf/synth/Paint9Painter$PaintType;"));
		}

		[JniSignatureAttribute("Lsun/swing/plaf/synth/Paint9Painter$PaintType;", "public static final")]
		public static Dova.JDK.sun.swing.plaf.synth.Paint9Painter.PaintType CENTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.Paint9Painter.PaintType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/swing/plaf/synth/Paint9Painter$PaintType;", "public static final")]
		public static Dova.JDK.sun.swing.plaf.synth.Paint9Painter.PaintType TILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.Paint9Painter.PaintType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/swing/plaf/synth/Paint9Painter$PaintType;", "public static final")]
		public static Dova.JDK.sun.swing.plaf.synth.Paint9Painter.PaintType PAINT9_STRETCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.Paint9Painter.PaintType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/swing/plaf/synth/Paint9Painter$PaintType;", "public static final")]
		public static Dova.JDK.sun.swing.plaf.synth.Paint9Painter.PaintType PAINT9_TILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.Paint9Painter.PaintType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lsun/swing/plaf/synth/Paint9Painter$PaintType;", "private static final")]
		public static JavaArray<Dova.JDK.sun.swing.plaf.synth.Paint9Painter.PaintType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.swing.plaf.synth.Paint9Painter.PaintType>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PaintType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public PaintType(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/swing/plaf/synth/Paint9Painter$PaintType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/swing/plaf/synth/Paint9Painter$PaintType;", "public static")]
		public static JavaArray<Dova.JDK.sun.swing.plaf.synth.Paint9Painter.PaintType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.swing.plaf.synth.Paint9Painter.PaintType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/swing/plaf/synth/Paint9Painter$PaintType;", "public static")]
		public static Dova.JDK.sun.swing.plaf.synth.Paint9Painter.PaintType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.Paint9Painter.PaintType>(ret);
		}

		[JniSignatureAttribute("()[Lsun/swing/plaf/synth/Paint9Painter$PaintType;", "private static")]
		public static JavaArray<Dova.JDK.sun.swing.plaf.synth.Paint9Painter.PaintType> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.swing.plaf.synth.Paint9Painter.PaintType>>(ret);
		}
	}
}
