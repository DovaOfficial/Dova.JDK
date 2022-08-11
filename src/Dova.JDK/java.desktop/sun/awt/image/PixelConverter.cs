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

namespace Dova.JDK.sun.awt.image;

[JniSignatureAttribute("Lsun/awt/image/PixelConverter;", "public")]
public partial class PixelConverter
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PixelConverter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/PixelConverter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/awt/image/PixelConverter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alphaMask", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rgbToPixel", "(ILjava/awt/image/ColorModel;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pixelToRgb", "(ILjava/awt/image/ColorModel;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlphaMask", "()I"));
	}

	[JniSignatureAttribute("Lsun/awt/image/PixelConverter;", "public static final")]
	public static Dova.JDK.sun.awt.image.PixelConverter instance_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.PixelConverter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int alphaMask_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PixelConverter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public PixelConverter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/image/PixelConverter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
	public int rgbToPixel(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
	public int pixelToRgb(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()I", "public final")]
	public int getAlphaMask()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("Lsun/awt/image/PixelConverter$UshortGray;", "public static")]
	public partial class UshortGray
		: Dova.JDK.sun.awt.image.PixelConverter.ByteGray
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UshortGray()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/PixelConverter$UshortGray;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT_MULT", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "USHORT_RED_MULT", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "USHORT_GRN_MULT", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "USHORT_BLU_MULT", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/awt/image/PixelConverter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rgbToPixel", "(ILjava/awt/image/ColorModel;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pixelToRgb", "(ILjava/awt/image/ColorModel;)I"));
		}

		[JniSignatureAttribute("D", "static final")]
		public static double SHORT_MULT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("D", "static final")]
		public static double USHORT_RED_MULT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("D", "static final")]
		public static double USHORT_GRN_MULT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("D", "static final")]
		public static double USHORT_BLU_MULT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Lsun/awt/image/PixelConverter;", "public static final")]
		public static Dova.JDK.sun.awt.image.PixelConverter instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.PixelConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UshortGray(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public UshortGray() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/PixelConverter$UshortGray;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int rgbToPixel(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int pixelToRgb(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/PixelConverter$ByteGray;", "public static")]
	public partial class ByteGray
		: Dova.JDK.sun.awt.image.PixelConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ByteGray()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/PixelConverter$ByteGray;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RED_MULT", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GRN_MULT", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BLU_MULT", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/awt/image/PixelConverter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rgbToPixel", "(ILjava/awt/image/ColorModel;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pixelToRgb", "(ILjava/awt/image/ColorModel;)I"));
		}

		[JniSignatureAttribute("D", "static final")]
		public static double RED_MULT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("D", "static final")]
		public static double GRN_MULT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("D", "static final")]
		public static double BLU_MULT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Lsun/awt/image/PixelConverter;", "public static final")]
		public static Dova.JDK.sun.awt.image.PixelConverter instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.PixelConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ByteGray(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ByteGray() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/PixelConverter$ByteGray;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int rgbToPixel(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int pixelToRgb(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/PixelConverter$ArgbBm;", "public static")]
	public partial class ArgbBm
		: Dova.JDK.sun.awt.image.PixelConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArgbBm()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/PixelConverter$ArgbBm;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/awt/image/PixelConverter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rgbToPixel", "(ILjava/awt/image/ColorModel;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pixelToRgb", "(ILjava/awt/image/ColorModel;)I"));
		}

		[JniSignatureAttribute("Lsun/awt/image/PixelConverter;", "public static final")]
		public static Dova.JDK.sun.awt.image.PixelConverter instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.PixelConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ArgbBm(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ArgbBm() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/PixelConverter$ArgbBm;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int rgbToPixel(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int pixelToRgb(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/PixelConverter$ArgbPre;", "public static")]
	public partial class ArgbPre
		: Dova.JDK.sun.awt.image.PixelConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArgbPre()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/PixelConverter$ArgbPre;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/awt/image/PixelConverter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rgbToPixel", "(ILjava/awt/image/ColorModel;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pixelToRgb", "(ILjava/awt/image/ColorModel;)I"));
		}

		[JniSignatureAttribute("Lsun/awt/image/PixelConverter;", "public static final")]
		public static Dova.JDK.sun.awt.image.PixelConverter instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.PixelConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ArgbPre(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ArgbPre() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/PixelConverter$ArgbPre;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int rgbToPixel(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int pixelToRgb(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/PixelConverter$RgbaPre;", "public static")]
	public partial class RgbaPre
		: Dova.JDK.sun.awt.image.PixelConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RgbaPre()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/PixelConverter$RgbaPre;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/awt/image/PixelConverter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rgbToPixel", "(ILjava/awt/image/ColorModel;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pixelToRgb", "(ILjava/awt/image/ColorModel;)I"));
		}

		[JniSignatureAttribute("Lsun/awt/image/PixelConverter;", "public static final")]
		public static Dova.JDK.sun.awt.image.PixelConverter instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.PixelConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RgbaPre(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public RgbaPre() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/PixelConverter$RgbaPre;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int rgbToPixel(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int pixelToRgb(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/PixelConverter$Rgba;", "public static")]
	public partial class Rgba
		: Dova.JDK.sun.awt.image.PixelConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Rgba()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/PixelConverter$Rgba;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/awt/image/PixelConverter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rgbToPixel", "(ILjava/awt/image/ColorModel;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pixelToRgb", "(ILjava/awt/image/ColorModel;)I"));
		}

		[JniSignatureAttribute("Lsun/awt/image/PixelConverter;", "public static final")]
		public static Dova.JDK.sun.awt.image.PixelConverter instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.PixelConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Rgba(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Rgba() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/PixelConverter$Rgba;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int rgbToPixel(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int pixelToRgb(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/PixelConverter$Bgrx;", "public static")]
	public partial class Bgrx
		: Dova.JDK.sun.awt.image.PixelConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Bgrx()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/PixelConverter$Bgrx;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/awt/image/PixelConverter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rgbToPixel", "(ILjava/awt/image/ColorModel;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pixelToRgb", "(ILjava/awt/image/ColorModel;)I"));
		}

		[JniSignatureAttribute("Lsun/awt/image/PixelConverter;", "public static final")]
		public static Dova.JDK.sun.awt.image.PixelConverter instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.PixelConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Bgrx(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Bgrx() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/PixelConverter$Bgrx;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int rgbToPixel(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int pixelToRgb(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/PixelConverter$Xbgr;", "public static")]
	public partial class Xbgr
		: Dova.JDK.sun.awt.image.PixelConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Xbgr()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/PixelConverter$Xbgr;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/awt/image/PixelConverter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rgbToPixel", "(ILjava/awt/image/ColorModel;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pixelToRgb", "(ILjava/awt/image/ColorModel;)I"));
		}

		[JniSignatureAttribute("Lsun/awt/image/PixelConverter;", "public static final")]
		public static Dova.JDK.sun.awt.image.PixelConverter instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.PixelConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Xbgr(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Xbgr() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/PixelConverter$Xbgr;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int rgbToPixel(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int pixelToRgb(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/PixelConverter$Ushort4444Argb;", "public static")]
	public partial class Ushort4444Argb
		: Dova.JDK.sun.awt.image.PixelConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Ushort4444Argb()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/PixelConverter$Ushort4444Argb;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/awt/image/PixelConverter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rgbToPixel", "(ILjava/awt/image/ColorModel;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pixelToRgb", "(ILjava/awt/image/ColorModel;)I"));
		}

		[JniSignatureAttribute("Lsun/awt/image/PixelConverter;", "public static final")]
		public static Dova.JDK.sun.awt.image.PixelConverter instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.PixelConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Ushort4444Argb(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Ushort4444Argb() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/PixelConverter$Ushort4444Argb;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int rgbToPixel(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int pixelToRgb(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/PixelConverter$Ushort555Rgb;", "public static")]
	public partial class Ushort555Rgb
		: Dova.JDK.sun.awt.image.PixelConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Ushort555Rgb()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/PixelConverter$Ushort555Rgb;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/awt/image/PixelConverter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rgbToPixel", "(ILjava/awt/image/ColorModel;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pixelToRgb", "(ILjava/awt/image/ColorModel;)I"));
		}

		[JniSignatureAttribute("Lsun/awt/image/PixelConverter;", "public static final")]
		public static Dova.JDK.sun.awt.image.PixelConverter instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.PixelConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Ushort555Rgb(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Ushort555Rgb() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/PixelConverter$Ushort555Rgb;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int rgbToPixel(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int pixelToRgb(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/PixelConverter$Ushort555Rgbx;", "public static")]
	public partial class Ushort555Rgbx
		: Dova.JDK.sun.awt.image.PixelConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Ushort555Rgbx()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/PixelConverter$Ushort555Rgbx;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/awt/image/PixelConverter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rgbToPixel", "(ILjava/awt/image/ColorModel;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pixelToRgb", "(ILjava/awt/image/ColorModel;)I"));
		}

		[JniSignatureAttribute("Lsun/awt/image/PixelConverter;", "public static final")]
		public static Dova.JDK.sun.awt.image.PixelConverter instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.PixelConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Ushort555Rgbx(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Ushort555Rgbx() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/PixelConverter$Ushort555Rgbx;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int rgbToPixel(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int pixelToRgb(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/PixelConverter$Ushort565Rgb;", "public static")]
	public partial class Ushort565Rgb
		: Dova.JDK.sun.awt.image.PixelConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Ushort565Rgb()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/PixelConverter$Ushort565Rgb;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/awt/image/PixelConverter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rgbToPixel", "(ILjava/awt/image/ColorModel;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pixelToRgb", "(ILjava/awt/image/ColorModel;)I"));
		}

		[JniSignatureAttribute("Lsun/awt/image/PixelConverter;", "public static final")]
		public static Dova.JDK.sun.awt.image.PixelConverter instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.PixelConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Ushort565Rgb(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Ushort565Rgb() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/PixelConverter$Ushort565Rgb;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int rgbToPixel(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int pixelToRgb(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/PixelConverter$Argb;", "public static")]
	public partial class Argb
		: Dova.JDK.sun.awt.image.PixelConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Argb()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/PixelConverter$Argb;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/awt/image/PixelConverter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rgbToPixel", "(ILjava/awt/image/ColorModel;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pixelToRgb", "(ILjava/awt/image/ColorModel;)I"));
		}

		[JniSignatureAttribute("Lsun/awt/image/PixelConverter;", "public static final")]
		public static Dova.JDK.sun.awt.image.PixelConverter instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.PixelConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Argb(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Argb() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/PixelConverter$Argb;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int rgbToPixel(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int pixelToRgb(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/PixelConverter$Xrgb;", "public static")]
	public partial class Xrgb
		: Dova.JDK.sun.awt.image.PixelConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Xrgb()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/PixelConverter$Xrgb;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/awt/image/PixelConverter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rgbToPixel", "(ILjava/awt/image/ColorModel;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pixelToRgb", "(ILjava/awt/image/ColorModel;)I"));
		}

		[JniSignatureAttribute("Lsun/awt/image/PixelConverter;", "public static final")]
		public static Dova.JDK.sun.awt.image.PixelConverter instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.PixelConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Xrgb(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Xrgb() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/PixelConverter$Xrgb;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int rgbToPixel(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int pixelToRgb(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/PixelConverter$Rgbx;", "public static")]
	public partial class Rgbx
		: Dova.JDK.sun.awt.image.PixelConverter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Rgbx()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/PixelConverter$Rgbx;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/awt/image/PixelConverter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rgbToPixel", "(ILjava/awt/image/ColorModel;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pixelToRgb", "(ILjava/awt/image/ColorModel;)I"));
		}

		[JniSignatureAttribute("Lsun/awt/image/PixelConverter;", "public static final")]
		public static Dova.JDK.sun.awt.image.PixelConverter instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.PixelConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Rgbx(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Rgbx() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/image/PixelConverter$Rgbx;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int rgbToPixel(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/awt/image/ColorModel;)I", "public")]
		public int pixelToRgb(int arg0, Dova.JDK.java.awt.image.ColorModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}
}
