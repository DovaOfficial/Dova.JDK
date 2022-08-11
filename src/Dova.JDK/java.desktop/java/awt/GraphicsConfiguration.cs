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

[JniSignatureAttribute("Ljava/awt/GraphicsConfiguration;", "public abstract")]
public partial class GraphicsConfiguration
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GraphicsConfiguration()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/GraphicsConfiguration;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultBufferCaps", "Ljava/awt/BufferCapabilities;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultImageCaps", "Ljava/awt/ImageCapabilities;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColorModel", "()Ljava/awt/image/ColorModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColorModel", "(I)Ljava/awt/image/ColorModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDevice", "()Ljava/awt/GraphicsDevice;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCompatibleImage", "(III)Ljava/awt/image/BufferedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCompatibleImage", "(II)Ljava/awt/image/BufferedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCompatibleVolatileImage", "(II)Ljava/awt/image/VolatileImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCompatibleVolatileImage", "(IILjava/awt/ImageCapabilities;I)Ljava/awt/image/VolatileImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCompatibleVolatileImage", "(IILjava/awt/ImageCapabilities;)Ljava/awt/image/VolatileImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCompatibleVolatileImage", "(III)Ljava/awt/image/VolatileImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImageCapabilities", "()Ljava/awt/ImageCapabilities;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultTransform", "()Ljava/awt/geom/AffineTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNormalizingTransform", "()Ljava/awt/geom/AffineTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBufferCapabilities", "()Ljava/awt/BufferCapabilities;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTranslucencyCapable", "()Z"));
	}

	[JniSignatureAttribute("Ljava/awt/BufferCapabilities;", "private static")]
	public static Dova.JDK.java.awt.BufferCapabilities defaultBufferCaps_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.BufferCapabilities>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/ImageCapabilities;", "private static")]
	public static Dova.JDK.java.awt.ImageCapabilities defaultImageCaps_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.ImageCapabilities>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GraphicsConfiguration(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public GraphicsConfiguration() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/GraphicsConfiguration;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public abstract")]
	public Dova.JDK.java.awt.Rectangle getBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/image/ColorModel;", "public abstract")]
	public Dova.JDK.java.awt.image.ColorModel getColorModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ColorModel>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/awt/image/ColorModel;", "public abstract")]
	public Dova.JDK.java.awt.image.ColorModel getColorModel(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ColorModel>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/GraphicsDevice;", "public abstract")]
	public Dova.JDK.java.awt.GraphicsDevice getDevice()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsDevice>(ret);
	}

	[JniSignatureAttribute("(III)Ljava/awt/image/BufferedImage;", "public")]
	public Dova.JDK.java.awt.image.BufferedImage createCompatibleImage(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/awt/image/BufferedImage;", "public")]
	public Dova.JDK.java.awt.image.BufferedImage createCompatibleImage(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/awt/image/VolatileImage;", "public")]
	public Dova.JDK.java.awt.image.VolatileImage createCompatibleVolatileImage(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.VolatileImage>(ret);
	}

	[JniSignatureAttribute("(IILjava/awt/ImageCapabilities;I)Ljava/awt/image/VolatileImage;", "public")]
	public Dova.JDK.java.awt.image.VolatileImage createCompatibleVolatileImage(int arg0, int arg1, Dova.JDK.java.awt.ImageCapabilities arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.VolatileImage>(ret);
	}

	[JniSignatureAttribute("(IILjava/awt/ImageCapabilities;)Ljava/awt/image/VolatileImage;", "public")]
	public Dova.JDK.java.awt.image.VolatileImage createCompatibleVolatileImage(int arg0, int arg1, Dova.JDK.java.awt.ImageCapabilities arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.VolatileImage>(ret);
	}

	[JniSignatureAttribute("(III)Ljava/awt/image/VolatileImage;", "public")]
	public Dova.JDK.java.awt.image.VolatileImage createCompatibleVolatileImage(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.VolatileImage>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/ImageCapabilities;", "public")]
	public Dova.JDK.java.awt.ImageCapabilities getImageCapabilities()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.ImageCapabilities>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/AffineTransform;", "public abstract")]
	public Dova.JDK.java.awt.geom.AffineTransform getDefaultTransform()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/AffineTransform;", "public abstract")]
	public Dova.JDK.java.awt.geom.AffineTransform getNormalizingTransform()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/BufferCapabilities;", "public")]
	public Dova.JDK.java.awt.BufferCapabilities getBufferCapabilities()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.BufferCapabilities>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isTranslucencyCapable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("Ljava/awt/GraphicsConfiguration$DefaultBufferCapabilities;", "private static")]
	public partial class DefaultBufferCapabilities
		: Dova.JDK.java.awt.BufferCapabilities
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultBufferCapabilities()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/GraphicsConfiguration$DefaultBufferCapabilities;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/ImageCapabilities;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultBufferCapabilities(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/awt/ImageCapabilities;)V", "public")]
		public DefaultBufferCapabilities(Dova.JDK.java.awt.ImageCapabilities arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/GraphicsConfiguration$DefaultBufferCapabilities;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
