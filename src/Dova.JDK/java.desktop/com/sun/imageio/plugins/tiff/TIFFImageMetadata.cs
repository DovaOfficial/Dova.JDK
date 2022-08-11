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

namespace Dova.JDK.com.sun.imageio.plugins.tiff;

[JniSignatureAttribute("Lcom/sun/imageio/plugins/tiff/TIFFImageMetadata;", "public")]
public partial class TIFFImageMetadata
	: Dova.JDK.javax.imageio.metadata.IIOMetadata
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TIFFImageMetadata()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/tiff/TIFFImageMetadata;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NATIVE_METADATA_FORMAT_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NATIVE_METADATA_FORMAT_CLASS_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tagSets", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rootIFD", "Lcom/sun/imageio/plugins/tiff/TIFFIFD;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "colorSpaceNames", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "orientationNames", "[Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/tiff/TIFFIFD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "repeat", "(Ljava/lang/String;I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReadOnly", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAttribute", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChildNode", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listToCharArray", "(Ljava/lang/String;)[C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listToIntArray", "(Ljava/lang/String;)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parseIFD", "(Lorg/w3c/dom/Node;)Lcom/sun/imageio/plugins/tiff/TIFFIFD;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeNativeTree", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeStandardTree", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializeFromStream", "(Ljavax/imageio/stream/ImageInputStream;ZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addShortOrLongField", "(IJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fatal", "(Lorg/w3c/dom/Node;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRootIFD", "()Lcom/sun/imageio/plugins/tiff/TIFFIFD;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTIFFField", "(I)Ljavax/imageio/plugins/tiff/TIFFField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeTIFFField", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeTree", "()Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShallowClone", "()Lcom/sun/imageio/plugins/tiff/TIFFImageMetadata;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIFDAsTree", "(Lcom/sun/imageio/plugins/tiff/TIFFIFD;Ljava/lang/String;I)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStandardChromaNode", "()Ljavax/imageio/metadata/IIOMetadataNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStandardCompressionNode", "()Ljavax/imageio/metadata/IIOMetadataNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStandardDataNode", "()Ljavax/imageio/metadata/IIOMetadataNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStandardDimensionNode", "()Ljavax/imageio/metadata/IIOMetadataNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStandardDocumentNode", "()Ljavax/imageio/metadata/IIOMetadataNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStandardTextNode", "()Ljavax/imageio/metadata/IIOMetadataNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStandardTransparencyNode", "()Ljavax/imageio/metadata/IIOMetadataNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeTree", "(Ljava/lang/String;Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAsTree", "(Ljava/lang/String;)Lorg/w3c/dom/Node;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String NATIVE_METADATA_FORMAT_NAME_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String NATIVE_METADATA_FORMAT_CLASS_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List tagSets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/tiff/TIFFIFD;", "")]
	public Dova.JDK.com.sun.imageio.plugins.tiff.TIFFIFD rootIFD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.tiff.TIFFIFD>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> colorSpaceNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> orientationNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TIFFImageMetadata(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
	public TIFFImageMetadata(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/imageio/plugins/tiff/TIFFIFD;)V", "public")]
	public TIFFImageMetadata(Dova.JDK.com.sun.imageio.plugins.tiff.TIFFIFD arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/tiff/TIFFImageMetadata;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String repeat(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void reset()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isReadOnly()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String getAttribute(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Ljava/lang/String;)Lorg/w3c/dom/Node;", "private")]
	public Dova.JDK.org.w3c.dom.Node getChildNode(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[C", "private")]
	public JavaArray<char> listToCharArray(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[I", "private")]
	public JavaArray<int> listToIntArray(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)Lcom/sun/imageio/plugins/tiff/TIFFIFD;", "public static")]
	public static Dova.JDK.com.sun.imageio.plugins.tiff.TIFFIFD parseIFD(Dova.JDK.org.w3c.dom.Node arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.tiff.TIFFIFD>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "private")]
	public void mergeNativeTree(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "private")]
	public void mergeStandardTree(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljavax/imageio/stream/ImageInputStream;ZZ)V", "public")]
	public void initializeFromStream(Dova.JDK.javax.imageio.stream.ImageInputStream arg0, bool arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(IJ)V", "public")]
	public void addShortOrLongField(int arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Ljava/lang/String;)V", "private static")]
	public static void fatal(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("()Lcom/sun/imageio/plugins/tiff/TIFFIFD;", "public")]
	public Dova.JDK.com.sun.imageio.plugins.tiff.TIFFIFD getRootIFD()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.tiff.TIFFIFD>(ret);
	}

	[JniSignatureAttribute("(I)Ljavax/imageio/plugins/tiff/TIFFField;", "public")]
	public Dova.JDK.javax.imageio.plugins.tiff.TIFFField getTIFFField(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.plugins.tiff.TIFFField>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void removeTIFFField(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/Node;", "private")]
	public Dova.JDK.org.w3c.dom.Node getNativeTree()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/imageio/plugins/tiff/TIFFImageMetadata;", "public")]
	public Dova.JDK.com.sun.imageio.plugins.tiff.TIFFImageMetadata getShallowClone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.tiff.TIFFImageMetadata>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/imageio/plugins/tiff/TIFFIFD;Ljava/lang/String;I)Lorg/w3c/dom/Node;", "private")]
	public Dova.JDK.org.w3c.dom.Node getIFDAsTree(Dova.JDK.com.sun.imageio.plugins.tiff.TIFFIFD arg0, Dova.JDK.java.lang.String arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("()Ljavax/imageio/metadata/IIOMetadataNode;", "public")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadataNode getStandardChromaNode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadataNode>(ret);
	}

	[JniSignatureAttribute("()Ljavax/imageio/metadata/IIOMetadataNode;", "public")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadataNode getStandardCompressionNode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadataNode>(ret);
	}

	[JniSignatureAttribute("()Ljavax/imageio/metadata/IIOMetadataNode;", "public")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadataNode getStandardDataNode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadataNode>(ret);
	}

	[JniSignatureAttribute("()Ljavax/imageio/metadata/IIOMetadataNode;", "public")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadataNode getStandardDimensionNode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadataNode>(ret);
	}

	[JniSignatureAttribute("()Ljavax/imageio/metadata/IIOMetadataNode;", "public")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadataNode getStandardDocumentNode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadataNode>(ret);
	}

	[JniSignatureAttribute("()Ljavax/imageio/metadata/IIOMetadataNode;", "public")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadataNode getStandardTextNode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadataNode>(ret);
	}

	[JniSignatureAttribute("()Ljavax/imageio/metadata/IIOMetadataNode;", "public")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadataNode getStandardTransparencyNode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadataNode>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/w3c/dom/Node;)V", "public")]
	public void mergeTree(Dova.JDK.java.lang.String arg0, Dova.JDK.org.w3c.dom.Node arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lorg/w3c/dom/Node;", "public")]
	public Dova.JDK.org.w3c.dom.Node getAsTree(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}
}
