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

[JniSignatureAttribute("Lsun/awt/image/OffScreenImage;", "public")]
public partial class OffScreenImage
	: Dova.JDK.java.awt.image.BufferedImage
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static OffScreenImage()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/OffScreenImage;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "c", "Ljava/awt/Component;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "osis", "Lsun/awt/image/OffScreenImageSource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultFont", "Ljava/awt/Font;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Component;Ljava/awt/image/ColorModel;Ljava/awt/image/WritableRaster;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSource", "()Ljava/awt/image/ImageProducer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initSurface", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createGraphics", "()Ljava/awt/Graphics2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGraphics", "()Ljava/awt/Graphics;"));
	}

	[JniSignatureAttribute("Ljava/awt/Component;", "protected")]
	public Dova.JDK.java.awt.Component c_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/image/OffScreenImageSource;", "private")]
	public Dova.JDK.sun.awt.image.OffScreenImageSource osis_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.OffScreenImageSource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Font;", "private")]
	public Dova.JDK.java.awt.Font defaultFont_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public OffScreenImage(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/image/ColorModel;Ljava/awt/image/WritableRaster;Z)V", "public")]
	public OffScreenImage(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.image.ColorModel arg1, Dova.JDK.java.awt.image.WritableRaster arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/image/OffScreenImage;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/awt/image/ImageProducer;", "public")]
	public Dova.JDK.java.awt.image.ImageProducer getSource()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ImageProducer>(ret);
	}

	[JniSignatureAttribute("(II)V", "private")]
	public void initSurface(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/awt/Graphics2D;", "public")]
	public Dova.JDK.java.awt.Graphics2D createGraphics()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Graphics2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Graphics;", "public")]
	public Dova.JDK.java.awt.Graphics getGraphics()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Graphics>(ret);
	}
}
