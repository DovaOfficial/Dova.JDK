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

namespace Dova.JDK.com.sun.imageio.plugins.jpeg;

[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;", "")]
public partial class JFIFMarkerSegment
	: Dova.JDK.com.sun.imageio.plugins.jpeg.MarkerSegment
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JFIFMarkerSegment()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "majorVersion", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minorVersion", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resUnits", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "Xdensity", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "Ydensity", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thumbWidth", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thumbHeight", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thumb", "Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumbRGB;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "extSegments", "Ljava/util/ArrayList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iccSegment", "Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$ICCMarkerSegment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THUMB_JPEG", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THUMB_PALETTE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THUMB_UNASSIGNED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THUMB_RGB", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DATA_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ID_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "MAX_THUMB_WIDTH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "MAX_THUMB_HEIGHT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "debug", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inICC", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tempICCSegment", "Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$ICCMarkerSegment;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Node;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/imageio/stream/ImageOutputStream;Ljava/awt/image/BufferedImage;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/imageio/stream/ImageOutputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeThumbnailData", "(Ljavax/imageio/stream/ImageOutputStream;[ILcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeThumb", "(Ljavax/imageio/stream/ImageOutputStream;Ljava/awt/image/BufferedImage;Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFExtensionMarkerSegment;IZLcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeJFXXSegment", "(ILjava/awt/image/BufferedImage;Ljavax/imageio/stream/ImageOutputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "expandGrayThumb", "(Ljava/awt/image/BufferedImage;)Ljava/awt/image/BufferedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeWithThumbs", "(Ljavax/imageio/stream/ImageOutputStream;Ljava/util/List;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "writeICC", "(Ljava/awt/color/ICC_Profile;Ljavax/imageio/stream/ImageOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addJFXX", "(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;Lcom/sun/imageio/plugins/jpeg/JPEGImageReader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addICC", "(Ljava/awt/color/ICC_ColorSpace;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addICC", "(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "writeDefaultJFIF", "(Ljavax/imageio/stream/ImageOutputStream;Ljava/util/List;Ljava/awt/color/ICC_Profile;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateFromNativeNode", "(Lorg/w3c/dom/Node;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeNode", "()Ljavax/imageio/metadata/IIOMetadataNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThumbnailWidth", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThumbnailHeight", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThumbnail", "(Ljavax/imageio/stream/ImageInputStream;ILcom/sun/imageio/plugins/jpeg/JPEGImageReader;)Ljava/awt/image/BufferedImage;"));
	}

	[JniSignatureAttribute("I", "")]
	public int majorVersion_Property
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

	[JniSignatureAttribute("I", "")]
	public int minorVersion_Property
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

	[JniSignatureAttribute("I", "")]
	public int resUnits_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int Xdensity_Property
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

	[JniSignatureAttribute("I", "")]
	public int Ydensity_Property
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

	[JniSignatureAttribute("I", "")]
	public int thumbWidth_Property
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

	[JniSignatureAttribute("I", "")]
	public int thumbHeight_Property
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

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumbRGB;", "")]
	public Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment.JFIFThumbRGB thumb_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment.JFIFThumbRGB>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ArrayList;", "")]
	public Dova.JDK.java.util.ArrayList extSegments_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$ICCMarkerSegment;", "")]
	public Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment.ICCMarkerSegment iccSegment_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment.ICCMarkerSegment>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int THUMB_JPEG_Property
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
	public static int THUMB_PALETTE_Property
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
	public static int THUMB_UNASSIGNED_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int THUMB_RGB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DATA_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int ID_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int MAX_THUMB_WIDTH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int MAX_THUMB_HEIGHT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool debug_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool inICC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$ICCMarkerSegment;", "private")]
	public Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment.ICCMarkerSegment tempICCSegment_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment.ICCMarkerSegment>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JFIFMarkerSegment(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "")]
	public JFIFMarkerSegment(Dova.JDK.org.w3c.dom.Node arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;)V", "")]
	public JFIFMarkerSegment(Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGBuffer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("()V", "")]
	public JFIFMarkerSegment() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "protected")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/imageio/stream/ImageOutputStream;Ljava/awt/image/BufferedImage;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V", "")]
	public void write(Dova.JDK.javax.imageio.stream.ImageOutputStream arg0, Dova.JDK.java.awt.image.BufferedImage arg1, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/imageio/stream/ImageOutputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V", "")]
	public void write(Dova.JDK.javax.imageio.stream.ImageOutputStream arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "")]
	public void print()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljavax/imageio/stream/ImageOutputStream;[ILcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V", "")]
	public void writeThumbnailData(Dova.JDK.javax.imageio.stream.ImageOutputStream arg0, JavaArray<int> arg1, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/imageio/stream/ImageOutputStream;Ljava/awt/image/BufferedImage;Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFExtensionMarkerSegment;IZLcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V", "private")]
	public void writeThumb(Dova.JDK.javax.imageio.stream.ImageOutputStream arg0, Dova.JDK.java.awt.image.BufferedImage arg1, Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment.JFIFExtensionMarkerSegment arg2, int arg3, bool arg4, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(ILjava/awt/image/BufferedImage;Ljavax/imageio/stream/ImageOutputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V", "private")]
	public void writeJFXXSegment(int arg0, Dova.JDK.java.awt.image.BufferedImage arg1, Dova.JDK.javax.imageio.stream.ImageOutputStream arg2, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;)Ljava/awt/image/BufferedImage;", "private static")]
	public static Dova.JDK.java.awt.image.BufferedImage expandGrayThumb(Dova.JDK.java.awt.image.BufferedImage arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
	}

	[JniSignatureAttribute("(Ljavax/imageio/stream/ImageOutputStream;Ljava/util/List;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V", "")]
	public void writeWithThumbs(Dova.JDK.javax.imageio.stream.ImageOutputStream arg0, Dova.JDK.java.util.List arg1, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/color/ICC_Profile;Ljavax/imageio/stream/ImageOutputStream;)V", "static")]
	public static void writeICC(Dova.JDK.java.awt.color.ICC_Profile arg0, Dova.JDK.javax.imageio.stream.ImageOutputStream arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;Lcom/sun/imageio/plugins/jpeg/JPEGImageReader;)V", "")]
	public void addJFXX(Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGBuffer arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageReader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/color/ICC_ColorSpace;)V", "")]
	public void addICC(Dova.JDK.java.awt.color.ICC_ColorSpace arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;)V", "")]
	public void addICC(Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGBuffer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljavax/imageio/stream/ImageOutputStream;Ljava/util/List;Ljava/awt/color/ICC_Profile;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V", "static")]
	public static void writeDefaultJFIF(Dova.JDK.javax.imageio.stream.ImageOutputStream arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.awt.color.ICC_Profile arg2, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Z)V", "")]
	public void updateFromNativeNode(Dova.JDK.org.w3c.dom.Node arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljavax/imageio/metadata/IIOMetadataNode;", "")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadataNode getNativeNode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadataNode>(ret);
	}

	[JniSignatureAttribute("(I)I", "")]
	public int getThumbnailWidth(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "")]
	public int getThumbnailHeight(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/imageio/stream/ImageInputStream;ILcom/sun/imageio/plugins/jpeg/JPEGImageReader;)Ljava/awt/image/BufferedImage;", "")]
	public Dova.JDK.java.awt.image.BufferedImage getThumbnail(Dova.JDK.javax.imageio.stream.ImageInputStream arg0, int arg1, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageReader arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumbRGB;", "")]
	public partial class JFIFThumbRGB
		: Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment.JFIFThumbUncompressed
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JFIFThumbRGB()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumbRGB;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Ljava/awt/image/BufferedImage;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lorg/w3c/dom/Node;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLength", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/imageio/stream/ImageOutputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThumbnail", "(Ljavax/imageio/stream/ImageInputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageReader;)Ljava/awt/image/BufferedImage;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JFIFThumbRGB(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Ljava/awt/image/BufferedImage;)V", "")]
		public JFIFThumbRGB(Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment arg0, Dova.JDK.java.awt.image.BufferedImage arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lorg/w3c/dom/Node;)V", "")]
		public JFIFThumbRGB(Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment arg0, Dova.JDK.org.w3c.dom.Node arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;II)V", "")]
		public JFIFThumbRGB(Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGBuffer arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumbRGB;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "")]
		public int getLength()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/imageio/stream/ImageOutputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V", "")]
		public void write(Dova.JDK.javax.imageio.stream.ImageOutputStream arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/imageio/stream/ImageInputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageReader;)Ljava/awt/image/BufferedImage;", "")]
		public Dova.JDK.java.awt.image.BufferedImage getThumbnail(Dova.JDK.javax.imageio.stream.ImageInputStream arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageReader arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$ICCMarkerSegment;", "")]
	public partial class ICCMarkerSegment
		: Dova.JDK.com.sun.imageio.plugins.jpeg.MarkerSegment
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ICCMarkerSegment()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$ICCMarkerSegment;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chunks", "Ljava/util/ArrayList;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "profile", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ID_SIZE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chunksRead", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numChunks", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lorg/w3c/dom/Node;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Ljava/awt/color/ICC_ColorSpace;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/imageio/stream/ImageOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addData", "(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeNode", "()Ljavax/imageio/metadata/IIOMetadataNode;"));
		}

		[JniSignatureAttribute("Ljava/util/ArrayList;", "")]
		public Dova.JDK.java.util.ArrayList chunks_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[B", "")]
		public JavaArray<byte> profile_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int ID_SIZE_Property
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

		[JniSignatureAttribute("I", "")]
		public int chunksRead_Property
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

		[JniSignatureAttribute("I", "")]
		public int numChunks_Property
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

		[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;", "final")]
		public Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ICCMarkerSegment(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lorg/w3c/dom/Node;)V", "")]
		public ICCMarkerSegment(Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment arg0, Dova.JDK.org.w3c.dom.Node arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;)V", "")]
		public ICCMarkerSegment(Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGBuffer arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Ljava/awt/color/ICC_ColorSpace;)V", "")]
		public ICCMarkerSegment(Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment arg0, Dova.JDK.java.awt.color.ICC_ColorSpace arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$ICCMarkerSegment;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Object;", "protected")]
		public Dova.JDK.java.lang.Object clone()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/imageio/stream/ImageOutputStream;)V", "")]
		public void write(Dova.JDK.javax.imageio.stream.ImageOutputStream arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()V", "")]
		public void print()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;)Z", "")]
		public bool addData(Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGBuffer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/imageio/metadata/IIOMetadataNode;", "")]
		public Dova.JDK.javax.imageio.metadata.IIOMetadataNode getNativeNode()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadataNode>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFExtensionMarkerSegment;", "")]
	public partial class JFIFExtensionMarkerSegment
		: Dova.JDK.com.sun.imageio.plugins.jpeg.MarkerSegment
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JFIFExtensionMarkerSegment()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFExtensionMarkerSegment;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "code", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thumb", "Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumb;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DATA_SIZE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ID_SIZE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Ljava/awt/image/BufferedImage;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lorg/w3c/dom/Node;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;Lcom/sun/imageio/plugins/jpeg/JPEGImageReader;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/imageio/stream/ImageOutputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setThumbnail", "(Ljava/awt/image/BufferedImage;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeNode", "()Ljavax/imageio/metadata/IIOMetadataNode;"));
		}

		[JniSignatureAttribute("I", "")]
		public int code_Property
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

		[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumb;", "")]
		public Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment.JFIFThumb thumb_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment.JFIFThumb>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int DATA_SIZE_Property
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

		[JniSignatureAttribute("I", "private static final")]
		public static int ID_SIZE_Property
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

		[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;", "final")]
		public Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JFIFExtensionMarkerSegment(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Ljava/awt/image/BufferedImage;)V", "")]
		public JFIFExtensionMarkerSegment(Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment arg0, Dova.JDK.java.awt.image.BufferedImage arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lorg/w3c/dom/Node;)V", "")]
		public JFIFExtensionMarkerSegment(Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment arg0, Dova.JDK.org.w3c.dom.Node arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;Lcom/sun/imageio/plugins/jpeg/JPEGImageReader;)V", "")]
		public JFIFExtensionMarkerSegment(Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGBuffer arg1, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageReader arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFExtensionMarkerSegment;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Object;", "protected")]
		public Dova.JDK.java.lang.Object clone()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/imageio/stream/ImageOutputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V", "")]
		public void write(Dova.JDK.javax.imageio.stream.ImageOutputStream arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("()V", "")]
		public void print()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;)V", "")]
		public void setThumbnail(Dova.JDK.java.awt.image.BufferedImage arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()Ljavax/imageio/metadata/IIOMetadataNode;", "")]
		public Dova.JDK.javax.imageio.metadata.IIOMetadataNode getNativeNode()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadataNode>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumb;", "abstract static")]
	public partial class JFIFThumb
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Cloneable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JFIFThumb()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumb;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "streamPos", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLength", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/imageio/stream/ImageOutputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWidth", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeight", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeNode", "()Ljavax/imageio/metadata/IIOMetadataNode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThumbnail", "(Ljavax/imageio/stream/ImageInputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageReader;)Ljava/awt/image/BufferedImage;"));
		}

		[JniSignatureAttribute("J", "")]
		public long streamPos_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JFIFThumb(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;)V", "protected")]
		public JFIFThumb(Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGBuffer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public JFIFThumb() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumb;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Object;", "protected")]
		public Dova.JDK.java.lang.Object clone()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()I", "abstract")]
		public int getLength()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/imageio/stream/ImageOutputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V", "abstract")]
		public void write(Dova.JDK.javax.imageio.stream.ImageOutputStream arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("()V", "abstract")]
		public void print()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("()I", "abstract")]
		public int getWidth()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()I", "abstract")]
		public int getHeight()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/imageio/metadata/IIOMetadataNode;", "abstract")]
		public Dova.JDK.javax.imageio.metadata.IIOMetadataNode getNativeNode()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadataNode>(ret);
		}

		[JniSignatureAttribute("(Ljavax/imageio/stream/ImageInputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageReader;)Ljava/awt/image/BufferedImage;", "abstract")]
		public Dova.JDK.java.awt.image.BufferedImage getThumbnail(Dova.JDK.javax.imageio.stream.ImageInputStream arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageReader arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$IllegalThumbException;", "private static")]
	public partial class IllegalThumbException
		: Dova.JDK.java.lang.Exception
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IllegalThumbException()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$IllegalThumbException;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IllegalThumbException(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public IllegalThumbException() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$IllegalThumbException;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumbJPEG;", "static")]
	public partial class JFIFThumbJPEG
		: Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment.JFIFThumb
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JFIFThumbJPEG()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumbJPEG;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thumbMetadata", "Lcom/sun/imageio/plugins/jpeg/JPEGMetadata;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "data", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PREAMBLE_SIZE", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/image/BufferedImage;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Node;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;ILcom/sun/imageio/plugins/jpeg/JPEGImageReader;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLength", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/imageio/stream/ImageOutputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWidth", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeight", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeNode", "()Ljavax/imageio/metadata/IIOMetadataNode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThumbnail", "(Ljavax/imageio/stream/ImageInputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageReader;)Ljava/awt/image/BufferedImage;"));
		}

		[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JPEGMetadata;", "")]
		public Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGMetadata thumbMetadata_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGMetadata>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[B", "")]
		public JavaArray<byte> data_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int PREAMBLE_SIZE_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JFIFThumbJPEG(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;)V", "")]
		public JFIFThumbJPEG(Dova.JDK.java.awt.image.BufferedImage arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "")]
		public JFIFThumbJPEG(Dova.JDK.org.w3c.dom.Node arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;ILcom/sun/imageio/plugins/jpeg/JPEGImageReader;)V", "")]
		public JFIFThumbJPEG(Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGBuffer arg0, int arg1, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageReader arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumbJPEG;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Object;", "protected")]
		public Dova.JDK.java.lang.Object clone()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()I", "")]
		public int getLength()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/imageio/stream/ImageOutputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V", "")]
		public void write(Dova.JDK.javax.imageio.stream.ImageOutputStream arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("()V", "")]
		public void print()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("()I", "")]
		public int getWidth()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()I", "")]
		public int getHeight()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/imageio/metadata/IIOMetadataNode;", "")]
		public Dova.JDK.javax.imageio.metadata.IIOMetadataNode getNativeNode()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadataNode>(ret);
		}

		[JniSignatureAttribute("(Ljavax/imageio/stream/ImageInputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageReader;)Ljava/awt/image/BufferedImage;", "")]
		public Dova.JDK.java.awt.image.BufferedImage getThumbnail(Dova.JDK.javax.imageio.stream.ImageInputStream arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageReader arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumbJPEG$ThumbnailReadListener;", "private static")]
		public partial class ThumbnailReadListener
			: Dova.JDK.java.lang.Object
			, Dova.JDK.javax.imageio.@event.IIOReadProgressListener
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ThumbnailReadListener()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumbJPEG$ThumbnailReadListener;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reader", "Lcom/sun/imageio/plugins/jpeg/JPEGImageReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JPEGImageReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sequenceStarted", "(Ljavax/imageio/ImageReader;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sequenceComplete", "(Ljavax/imageio/ImageReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "imageStarted", "(Ljavax/imageio/ImageReader;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "imageProgress", "(Ljavax/imageio/ImageReader;F)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thumbnailStarted", "(Ljavax/imageio/ImageReader;II)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thumbnailProgress", "(Ljavax/imageio/ImageReader;F)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thumbnailComplete", "(Ljavax/imageio/ImageReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readAborted", "(Ljavax/imageio/ImageReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "imageComplete", "(Ljavax/imageio/ImageReader;)V"));
			}

			[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JPEGImageReader;", "")]
			public Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageReader reader_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageReader>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ThumbnailReadListener(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JPEGImageReader;)V", "")]
			public ThumbnailReadListener(Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumbJPEG$ThumbnailReadListener;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/imageio/ImageReader;I)V", "public")]
			public void sequenceStarted(Dova.JDK.javax.imageio.ImageReader arg0, int arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/imageio/ImageReader;)V", "public")]
			public void sequenceComplete(Dova.JDK.javax.imageio.ImageReader arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Ljavax/imageio/ImageReader;I)V", "public")]
			public void imageStarted(Dova.JDK.javax.imageio.ImageReader arg0, int arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/imageio/ImageReader;F)V", "public")]
			public void imageProgress(Dova.JDK.javax.imageio.ImageReader arg0, float arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/imageio/ImageReader;II)V", "public")]
			public void thumbnailStarted(Dova.JDK.javax.imageio.ImageReader arg0, int arg1, int arg2)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			}

			[JniSignatureAttribute("(Ljavax/imageio/ImageReader;F)V", "public")]
			public void thumbnailProgress(Dova.JDK.javax.imageio.ImageReader arg0, float arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/imageio/ImageReader;)V", "public")]
			public void thumbnailComplete(Dova.JDK.javax.imageio.ImageReader arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			}

			[JniSignatureAttribute("(Ljavax/imageio/ImageReader;)V", "public")]
			public void readAborted(Dova.JDK.javax.imageio.ImageReader arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			}

			[JniSignatureAttribute("(Ljavax/imageio/ImageReader;)V", "public")]
			public void imageComplete(Dova.JDK.javax.imageio.ImageReader arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumbPalette;", "")]
	public partial class JFIFThumbPalette
		: Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment.JFIFThumbUncompressed
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JFIFThumbPalette()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumbPalette;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PALETTE_SIZE", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Ljava/awt/image/BufferedImage;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lorg/w3c/dom/Node;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLength", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/imageio/stream/ImageOutputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThumbnail", "(Ljavax/imageio/stream/ImageInputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageReader;)Ljava/awt/image/BufferedImage;"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int PALETTE_SIZE_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JFIFThumbPalette(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Ljava/awt/image/BufferedImage;)V", "")]
		public JFIFThumbPalette(Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment arg0, Dova.JDK.java.awt.image.BufferedImage arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lorg/w3c/dom/Node;)V", "")]
		public JFIFThumbPalette(Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment arg0, Dova.JDK.org.w3c.dom.Node arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;II)V", "")]
		public JFIFThumbPalette(Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGBuffer arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumbPalette;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "")]
		public int getLength()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/imageio/stream/ImageOutputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V", "")]
		public void write(Dova.JDK.javax.imageio.stream.ImageOutputStream arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/imageio/stream/ImageInputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageReader;)Ljava/awt/image/BufferedImage;", "")]
		public Dova.JDK.java.awt.image.BufferedImage getThumbnail(Dova.JDK.javax.imageio.stream.ImageInputStream arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageReader arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumbUncompressed;", "abstract")]
	public partial class JFIFThumbUncompressed
		: Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment.JFIFThumb
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JFIFThumbUncompressed()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumbUncompressed;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thumbnail", "Ljava/awt/image/BufferedImage;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thumbWidth", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thumbHeight", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Ljava/awt/image/BufferedImage;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lorg/w3c/dom/Node;Ljava/lang/String;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;IIILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/imageio/stream/ImageOutputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readByteBuffer", "(Ljavax/imageio/stream/ImageInputStream;[BLcom/sun/imageio/plugins/jpeg/JPEGImageReader;FF)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writePixels", "(Ljavax/imageio/stream/ImageOutputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWidth", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeight", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeNode", "()Ljavax/imageio/metadata/IIOMetadataNode;"));
		}

		[JniSignatureAttribute("Ljava/awt/image/BufferedImage;", "")]
		public Dova.JDK.java.awt.image.BufferedImage thumbnail_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int thumbWidth_Property
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

		[JniSignatureAttribute("I", "")]
		public int thumbHeight_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;", "final")]
		public Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JFIFThumbUncompressed(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Ljava/awt/image/BufferedImage;)V", "")]
		public JFIFThumbUncompressed(Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment arg0, Dova.JDK.java.awt.image.BufferedImage arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lorg/w3c/dom/Node;Ljava/lang/String;)V", "")]
		public JFIFThumbUncompressed(Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment arg0, Dova.JDK.org.w3c.dom.Node arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;IIILjava/lang/String;)V", "")]
		public JFIFThumbUncompressed(Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGBuffer arg1, int arg2, int arg3, int arg4, Dova.JDK.java.lang.String arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment$JFIFThumbUncompressed;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/imageio/stream/ImageOutputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V", "")]
		public void write(Dova.JDK.javax.imageio.stream.ImageOutputStream arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("()V", "")]
		public void print()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Ljavax/imageio/stream/ImageInputStream;[BLcom/sun/imageio/plugins/jpeg/JPEGImageReader;FF)V", "")]
		public void readByteBuffer(Dova.JDK.javax.imageio.stream.ImageInputStream arg0, JavaArray<byte> arg1, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageReader arg2, float arg3, float arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		}

		[JniSignatureAttribute("(Ljavax/imageio/stream/ImageOutputStream;Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;)V", "")]
		public void writePixels(Dova.JDK.javax.imageio.stream.ImageOutputStream arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("()I", "")]
		public int getWidth()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()I", "")]
		public int getHeight()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/imageio/metadata/IIOMetadataNode;", "")]
		public Dova.JDK.javax.imageio.metadata.IIOMetadataNode getNativeNode()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadataNode>(ret);
		}
	}
}
