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

namespace Dova.JDK.com.sun.imageio.plugins.common;

[JniSignatureAttribute("Lcom/sun/imageio/plugins/common/PaletteBuilder;", "public")]
public partial class PaletteBuilder
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PaletteBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/common/PaletteBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAXLEVEL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "src", "Ljava/awt/image/RenderedImage;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "srcColorModel", "Ljava/awt/image/ColorModel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "srcRaster", "Ljava/awt/image/Raster;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requiredSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "root", "Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numNodes", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxNodes", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currLevel", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reduceList", "[Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "palette", "[Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transparency", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transColor", "Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/image/RenderedImage;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/image/RenderedImage;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertNode", "(Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;Ljava/awt/Color;I)Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createIndexedImage", "(Ljava/awt/image/RenderedImage;)Ljava/awt/image/RenderedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildPalette", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndexedImage", "()Ljava/awt/image/RenderedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndexColorModel", "()Ljava/awt/image/IndexColorModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSrcColor", "(II)Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findColorIndex", "(Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;Ljava/awt/Color;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBranchIndex", "(Ljava/awt/Color;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reduceTree", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findPaletteEntry", "(Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;I[B[B[B)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "freeTree", "(Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;)Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createIndexColorModel", "(Ljava/awt/image/RenderedImage;)Ljava/awt/image/IndexColorModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "canCreatePalette", "(Ljavax/imageio/ImageTypeSpecifier;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "canCreatePalette", "(Ljava/awt/image/RenderedImage;)Z"));
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int MAXLEVEL_Property
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

	[JniSignatureAttribute("Ljava/awt/image/RenderedImage;", "protected")]
	public Dova.JDK.java.awt.image.RenderedImage src_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.RenderedImage>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/image/ColorModel;", "protected")]
	public Dova.JDK.java.awt.image.ColorModel srcColorModel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ColorModel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/image/Raster;", "protected")]
	public Dova.JDK.java.awt.image.Raster srcRaster_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.Raster>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int requiredSize_Property
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

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;", "protected")]
	public Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode root_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int numNodes_Property
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

	[JniSignatureAttribute("I", "protected")]
	public int maxNodes_Property
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

	[JniSignatureAttribute("I", "protected")]
	public int currLevel_Property
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

	[JniSignatureAttribute("I", "protected")]
	public int currSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;", "protected")]
	public JavaArray<Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode> reduceList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;", "protected")]
	public JavaArray<Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode> palette_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int transparency_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;", "protected")]
	public Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode transColor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PaletteBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/image/RenderedImage;)V", "protected")]
	public PaletteBuilder(Dova.JDK.java.awt.image.RenderedImage arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/image/RenderedImage;I)V", "protected")]
	public PaletteBuilder(Dova.JDK.java.awt.image.RenderedImage arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/common/PaletteBuilder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;Ljava/awt/Color;I)Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;", "protected")]
	public Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode insertNode(Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode arg0, Dova.JDK.java.awt.Color arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/RenderedImage;)Ljava/awt/image/RenderedImage;", "public static")]
	public static Dova.JDK.java.awt.image.RenderedImage createIndexedImage(Dova.JDK.java.awt.image.RenderedImage arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.RenderedImage>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void buildPalette()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()Ljava/awt/image/RenderedImage;", "protected")]
	public Dova.JDK.java.awt.image.RenderedImage getIndexedImage()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.RenderedImage>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/image/IndexColorModel;", "protected")]
	public Dova.JDK.java.awt.image.IndexColorModel getIndexColorModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.IndexColorModel>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color getSrcColor(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;Ljava/awt/Color;)I", "protected")]
	public int findColorIndex(Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode arg0, Dova.JDK.java.awt.Color arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Color;I)I", "protected")]
	public int getBranchIndex(Dova.JDK.java.awt.Color arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "protected")]
	public void reduceTree()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;I[B[B[B)I", "protected")]
	public int findPaletteEntry(Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode arg0, int arg1, JavaArray<byte> arg2, JavaArray<byte> arg3, JavaArray<byte> arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;)Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;", "protected")]
	public Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode freeTree(Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/RenderedImage;)Ljava/awt/image/IndexColorModel;", "public static")]
	public static Dova.JDK.java.awt.image.IndexColorModel createIndexColorModel(Dova.JDK.java.awt.image.RenderedImage arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.IndexColorModel>(ret);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageTypeSpecifier;)Z", "public static")]
	public static bool canCreatePalette(Dova.JDK.javax.imageio.ImageTypeSpecifier arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/RenderedImage;)Z", "public static")]
	public static bool canCreatePalette(Dova.JDK.java.awt.image.RenderedImage arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;", "protected")]
	public partial class ColorNode
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ColorNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isLeaf", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "childCount", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "children", "[Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "colorCount", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "red", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "blue", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "green", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paletteIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "level", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextReducible", "Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/common/PaletteBuilder;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRGB", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLeafChildCount", "()I"));
		}

		[JniSignatureAttribute("Z", "public")]
		public bool isLeaf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "public")]
		public int childCount_Property
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

		[JniSignatureAttribute("[Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;", "")]
		public JavaArray<Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode> children_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "public")]
		public int colorCount_Property
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

		[JniSignatureAttribute("J", "public")]
		public long red_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("J", "public")]
		public long blue_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("J", "public")]
		public long green_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("I", "public")]
		public int paletteIndex_Property
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

		[JniSignatureAttribute("I", "public")]
		public int level_Property
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

		[JniSignatureAttribute("Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;", "")]
		public Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode nextReducible_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder.ColorNode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ColorNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/common/PaletteBuilder;)V", "public")]
		public ColorNode(Dova.JDK.com.sun.imageio.plugins.common.PaletteBuilder arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/common/PaletteBuilder$ColorNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int getRGB()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getLeafChildCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}
}
