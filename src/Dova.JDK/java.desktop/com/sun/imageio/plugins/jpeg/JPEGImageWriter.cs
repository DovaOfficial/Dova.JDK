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

[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;", "public")]
public partial class JPEGImageWriter
	: Dova.JDK.javax.imageio.ImageWriter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JPEGImageWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "debug", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "structPointer", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ios", "Ljavax/imageio/stream/ImageOutputStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "srcRas", "Ljava/awt/image/Raster;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "raster", "Ljava/awt/image/WritableRaster;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "indexed", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "indexCM", "Ljava/awt/image/IndexColorModel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "convertTosRGB", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "converted", "Ljava/awt/image/WritableRaster;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isAlphaPremultiplied", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "srcCM", "Ljava/awt/image/ColorModel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thumbnails", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iccProfile", "Ljava/awt/color/ICC_Profile;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceXOffset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceYOffset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceWidth", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "srcBands", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceHeight", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentImage", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "convertOp", "Ljava/awt/image/ColorConvertOp;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "streamQTables", "[Ljavax/imageio/plugins/jpeg/JPEGQTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "streamDCHuffmanTables", "[Ljavax/imageio/plugins/jpeg/JPEGHuffmanTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "streamACHuffmanTables", "[Ljavax/imageio/plugins/jpeg/JPEGHuffmanTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ignoreJFIF", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "forceJFIF", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ignoreAdobe", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "newAdobeTransform", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writeDefaultJFIF", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writeAdobe", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "metadata", "Lcom/sun/imageio/plugins/jpeg/JPEGMetadata;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sequencePrepared", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numScans", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "disposerReferent", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "disposerRecord", "Lsun/java2d/DisposerRecord;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARNING_DEST_IGNORED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARNING_STREAM_METADATA_IGNORED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARNING_DEST_METADATA_COMP_MISMATCH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARNING_DEST_METADATA_JFIF_MISMATCH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARNING_DEST_METADATA_ADOBE_MISMATCH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARNING_IMAGE_METADATA_JFIF_MISMATCH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARNING_IMAGE_METADATA_ADOBE_MISMATCH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARNING_METADATA_NOT_JPEG_FOR_RASTER", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARNING_NO_BANDS_ON_INDEXED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARNING_ILLEGAL_THUMBNAIL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARNING_IGNORING_THUMBS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARNING_FORCING_JFIF", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARNING_THUMB_CLIPPED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARNING_METADATA_ADJUSTED_FOR_THUMB", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARNING_NO_RGB_THUMB_AS_INDEXED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARNING_NO_GRAY_THUMB_AS_INDEXED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_WARNING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "preferredThumbSizes", "[Ljava/awt/Dimension;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "theThread", "Ljava/lang/Thread;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "theLockCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cbLock", "Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/imageio/spi/ImageWriterSpi;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/IIOImage;Ljavax/imageio/ImageWriteParam;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initStatic", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "abort", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeImage", "(J[BIII[IIIIII[Ljavax/imageio/plugins/jpeg/JPEGQTable;Z[Ljavax/imageio/plugins/jpeg/JPEGHuffmanTable;[Ljavax/imageio/plugins/jpeg/JPEGHuffmanTable;ZZZI[I[I[I[I[IZI)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initWriterIDs", "(Ljava/lang/Class;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initJPEGImageWriter", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setThreadLock", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetInternalState", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDest", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearThreadLock", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertImageMetadataOnThread", "(Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/ImageTypeSpecifier;Ljavax/imageio/ImageWriteParam;)Ljavax/imageio/metadata/IIOMetadata;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "jfifOK", "(Ljavax/imageio/ImageTypeSpecifier;Ljavax/imageio/ImageWriteParam;Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/metadata/IIOMetadata;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeOnThread", "(Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/IIOImage;Ljavax/imageio/ImageWriteParam;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkSOFBands", "(Lcom/sun/imageio/plugins/jpeg/SOFMarkerSegment;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkJFIF", "(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Ljavax/imageio/ImageTypeSpecifier;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkAdobe", "(Lcom/sun/imageio/plugins/jpeg/AdobeMarkerSegment;Ljavax/imageio/ImageTypeSpecifier;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSrcCSType", "(Ljava/awt/image/RenderedImage;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSrcCSType", "(Ljava/awt/image/ColorModel;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSrcCSType", "(Ljavax/imageio/ImageTypeSpecifier;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultDestCSType", "(Ljava/awt/image/RenderedImage;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultDestCSType", "(Ljavax/imageio/ImageTypeSpecifier;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultDestCSType", "(Ljava/awt/image/ColorModel;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSubsampled", "([Lcom/sun/imageio/plugins/jpeg/SOFMarkerSegment$ComponentSpec;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "collectScans", "(Lcom/sun/imageio/plugins/jpeg/JPEGMetadata;Lcom/sun/imageio/plugins/jpeg/SOFMarkerSegment;)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "collectQTablesFromMetadata", "(Lcom/sun/imageio/plugins/jpeg/JPEGMetadata;)[Ljavax/imageio/plugins/jpeg/JPEGQTable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "collectHTablesFromMetadata", "(Lcom/sun/imageio/plugins/jpeg/JPEGMetadata;Z)[Ljavax/imageio/plugins/jpeg/JPEGHuffmanTable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepareWriteSequenceOnThread", "(Ljavax/imageio/metadata/IIOMetadata;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeTables", "(J[Ljavax/imageio/plugins/jpeg/JPEGQTable;[Ljavax/imageio/plugins/jpeg/JPEGHuffmanTable;[Ljavax/imageio/plugins/jpeg/JPEGHuffmanTable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "abortWrite", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetWriter", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warningWithMessage", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDestCSType", "(Ljavax/imageio/ImageTypeSpecifier;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeMetadata", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "disposeWriter", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeOutputData", "([BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "grabPixels", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultWriteParam", "()Ljavax/imageio/ImageWriteParam;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultStreamMetadata", "(Ljavax/imageio/ImageWriteParam;)Ljavax/imageio/metadata/IIOMetadata;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultImageMetadata", "(Ljavax/imageio/ImageTypeSpecifier;Ljavax/imageio/ImageWriteParam;)Ljavax/imageio/metadata/IIOMetadata;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertStreamMetadata", "(Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/ImageWriteParam;)Ljavax/imageio/metadata/IIOMetadata;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertImageMetadata", "(Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/ImageTypeSpecifier;Ljavax/imageio/ImageWriteParam;)Ljavax/imageio/metadata/IIOMetadata;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumThumbnailsSupported", "(Ljavax/imageio/ImageTypeSpecifier;Ljavax/imageio/ImageWriteParam;Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/metadata/IIOMetadata;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredThumbnailSizes", "(Ljavax/imageio/ImageTypeSpecifier;Ljavax/imageio/ImageWriteParam;Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/metadata/IIOMetadata;)[Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canWriteRasters", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canWriteSequence", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepareWriteSequence", "(Ljavax/imageio/metadata/IIOMetadata;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeToSequence", "(Ljavax/imageio/IIOImage;Ljavax/imageio/ImageWriteParam;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endWriteSequence", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thumbnailStarted", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thumbnailProgress", "(F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thumbnailComplete", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warningOccurred", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearAbortRequest", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOutput", "(Ljava/lang/Object;)V"));
	}

	[JniSignatureAttribute("Z", "private")]
	public bool debug_Property
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

	[JniSignatureAttribute("J", "private")]
	public long structPointer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljavax/imageio/stream/ImageOutputStream;", "private")]
	public Dova.JDK.javax.imageio.stream.ImageOutputStream ios_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.stream.ImageOutputStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/image/Raster;", "private")]
	public Dova.JDK.java.awt.image.Raster srcRas_Property
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

	[JniSignatureAttribute("Ljava/awt/image/WritableRaster;", "private")]
	public Dova.JDK.java.awt.image.WritableRaster raster_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.WritableRaster>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool indexed_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/image/IndexColorModel;", "private")]
	public Dova.JDK.java.awt.image.IndexColorModel indexCM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.IndexColorModel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool convertTosRGB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/image/WritableRaster;", "private")]
	public Dova.JDK.java.awt.image.WritableRaster converted_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.WritableRaster>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isAlphaPremultiplied_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/image/ColorModel;", "private")]
	public Dova.JDK.java.awt.image.ColorModel srcCM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ColorModel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List thumbnails_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/color/ICC_Profile;", "private")]
	public Dova.JDK.java.awt.color.ICC_Profile iccProfile_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.color.ICC_Profile>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int sourceXOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int sourceYOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int sourceWidth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> srcBands_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int sourceHeight_Property
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

	[JniSignatureAttribute("I", "private")]
	public int currentImage_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/image/ColorConvertOp;", "private")]
	public Dova.JDK.java.awt.image.ColorConvertOp convertOp_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ColorConvertOp>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljavax/imageio/plugins/jpeg/JPEGQTable;", "private")]
	public JavaArray<Dova.JDK.javax.imageio.plugins.jpeg.JPEGQTable> streamQTables_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.imageio.plugins.jpeg.JPEGQTable>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljavax/imageio/plugins/jpeg/JPEGHuffmanTable;", "private")]
	public JavaArray<Dova.JDK.javax.imageio.plugins.jpeg.JPEGHuffmanTable> streamDCHuffmanTables_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.imageio.plugins.jpeg.JPEGHuffmanTable>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljavax/imageio/plugins/jpeg/JPEGHuffmanTable;", "private")]
	public JavaArray<Dova.JDK.javax.imageio.plugins.jpeg.JPEGHuffmanTable> streamACHuffmanTables_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.imageio.plugins.jpeg.JPEGHuffmanTable>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool ignoreJFIF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool forceJFIF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool ignoreAdobe_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int newAdobeTransform_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool writeDefaultJFIF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool writeAdobe_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JPEGMetadata;", "private")]
	public Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGMetadata metadata_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGMetadata>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool sequencePrepared_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int numScans_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[31]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[31], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object disposerReferent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/DisposerRecord;", "private")]
	public Dova.JDK.sun.java2d.DisposerRecord disposerRecord_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.DisposerRecord>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int WARNING_DEST_IGNORED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[34]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[34], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int WARNING_STREAM_METADATA_IGNORED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[35]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[35], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int WARNING_DEST_METADATA_COMP_MISMATCH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[36]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[36], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int WARNING_DEST_METADATA_JFIF_MISMATCH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[37]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[37], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int WARNING_DEST_METADATA_ADOBE_MISMATCH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[38]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[38], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int WARNING_IMAGE_METADATA_JFIF_MISMATCH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[39]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[39], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int WARNING_IMAGE_METADATA_ADOBE_MISMATCH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[40]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[40], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int WARNING_METADATA_NOT_JPEG_FOR_RASTER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[41]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[41], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int WARNING_NO_BANDS_ON_INDEXED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[42]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[42], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int WARNING_ILLEGAL_THUMBNAIL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[43]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[43], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int WARNING_IGNORING_THUMBS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[44]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[44], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int WARNING_FORCING_JFIF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[45]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[45], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int WARNING_THUMB_CLIPPED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[46]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[46], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int WARNING_METADATA_ADJUSTED_FOR_THUMB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[47]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[47], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int WARNING_NO_RGB_THUMB_AS_INDEXED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[48]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[48], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int WARNING_NO_GRAY_THUMB_AS_INDEXED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[49]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[49], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MAX_WARNING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[50]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[50], value);
		}
	}

	[JniSignatureAttribute("[Ljava/awt/Dimension;", "static final")]
	public static JavaArray<Dova.JDK.java.awt.Dimension> preferredThumbSizes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Dimension>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Thread;", "private")]
	public Dova.JDK.java.lang.Thread theThread_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[52]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int theLockCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[53]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[53], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock;", "private")]
	public Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter.CallBackLock cbLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[54]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter.CallBackLock>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JPEGImageWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/imageio/spi/ImageWriterSpi;)V", "public")]
	public JPEGImageWriter(Dova.JDK.javax.imageio.spi.ImageWriterSpi arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/IIOImage;Ljavax/imageio/ImageWriteParam;)V", "public")]
	public void write(Dova.JDK.javax.imageio.metadata.IIOMetadata arg0, Dova.JDK.javax.imageio.IIOImage arg1, Dova.JDK.javax.imageio.ImageWriteParam arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "public")]
	public void reset()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void initStatic()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void abort()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(J[BIII[IIIIII[Ljavax/imageio/plugins/jpeg/JPEGQTable;Z[Ljavax/imageio/plugins/jpeg/JPEGHuffmanTable;[Ljavax/imageio/plugins/jpeg/JPEGHuffmanTable;ZZZI[I[I[I[I[IZI)Z", "private native")]
	public bool writeImage(long arg0, JavaArray<byte> arg1, int arg2, int arg3, int arg4, JavaArray<int> arg5, int arg6, int arg7, int arg8, int arg9, int arg10, JavaArray<Dova.JDK.javax.imageio.plugins.jpeg.JPEGQTable> arg11, bool arg12, JavaArray<Dova.JDK.javax.imageio.plugins.jpeg.JPEGHuffmanTable> arg13, JavaArray<Dova.JDK.javax.imageio.plugins.jpeg.JPEGHuffmanTable> arg14, bool arg15, bool arg16, bool arg17, int arg18, JavaArray<int> arg19, JavaArray<int> arg20, JavaArray<int> arg21, JavaArray<int> arg22, JavaArray<int> arg23, bool arg24, int arg25)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;)V", "private static native")]
	public static void initWriterIDs(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("()J", "private native")]
	public long initJPEGImageWriter()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private synchronized")]
	public void setThreadLock()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void resetInternalState()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("(J)V", "private native")]
	public void setDest(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()V", "private synchronized")]
	public void clearThreadLock()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("(Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/ImageTypeSpecifier;Ljavax/imageio/ImageWriteParam;)Ljavax/imageio/metadata/IIOMetadata;", "private")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadata convertImageMetadataOnThread(Dova.JDK.javax.imageio.metadata.IIOMetadata arg0, Dova.JDK.javax.imageio.ImageTypeSpecifier arg1, Dova.JDK.javax.imageio.ImageWriteParam arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadata>(ret);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageTypeSpecifier;Ljavax/imageio/ImageWriteParam;Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/metadata/IIOMetadata;)Z", "private")]
	public bool jfifOK(Dova.JDK.javax.imageio.ImageTypeSpecifier arg0, Dova.JDK.javax.imageio.ImageWriteParam arg1, Dova.JDK.javax.imageio.metadata.IIOMetadata arg2, Dova.JDK.javax.imageio.metadata.IIOMetadata arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/IIOImage;Ljavax/imageio/ImageWriteParam;)V", "private")]
	public void writeOnThread(Dova.JDK.javax.imageio.metadata.IIOMetadata arg0, Dova.JDK.javax.imageio.IIOImage arg1, Dova.JDK.javax.imageio.ImageWriteParam arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/SOFMarkerSegment;I)V", "private")]
	public void checkSOFBands(Dova.JDK.com.sun.imageio.plugins.jpeg.SOFMarkerSegment arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JFIFMarkerSegment;Ljavax/imageio/ImageTypeSpecifier;Z)V", "private")]
	public void checkJFIF(Dova.JDK.com.sun.imageio.plugins.jpeg.JFIFMarkerSegment arg0, Dova.JDK.javax.imageio.ImageTypeSpecifier arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/AdobeMarkerSegment;Ljavax/imageio/ImageTypeSpecifier;Z)V", "private")]
	public void checkAdobe(Dova.JDK.com.sun.imageio.plugins.jpeg.AdobeMarkerSegment arg0, Dova.JDK.javax.imageio.ImageTypeSpecifier arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/image/RenderedImage;)I", "private")]
	public int getSrcCSType(Dova.JDK.java.awt.image.RenderedImage arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/ColorModel;)I", "private")]
	public int getSrcCSType(Dova.JDK.java.awt.image.ColorModel arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageTypeSpecifier;)I", "private")]
	public int getSrcCSType(Dova.JDK.javax.imageio.ImageTypeSpecifier arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/RenderedImage;)I", "private")]
	public int getDefaultDestCSType(Dova.JDK.java.awt.image.RenderedImage arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageTypeSpecifier;)I", "private")]
	public int getDefaultDestCSType(Dova.JDK.javax.imageio.ImageTypeSpecifier arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/ColorModel;)I", "private")]
	public int getDefaultDestCSType(Dova.JDK.java.awt.image.ColorModel arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Lcom/sun/imageio/plugins/jpeg/SOFMarkerSegment$ComponentSpec;)Z", "private")]
	public bool isSubsampled(JavaArray<Dova.JDK.com.sun.imageio.plugins.jpeg.SOFMarkerSegment.ComponentSpec> arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JPEGMetadata;Lcom/sun/imageio/plugins/jpeg/SOFMarkerSegment;)[I", "private")]
	public JavaArray<int> collectScans(Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGMetadata arg0, Dova.JDK.com.sun.imageio.plugins.jpeg.SOFMarkerSegment arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JPEGMetadata;)[Ljavax/imageio/plugins/jpeg/JPEGQTable;", "private")]
	public JavaArray<Dova.JDK.javax.imageio.plugins.jpeg.JPEGQTable> collectQTablesFromMetadata(Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGMetadata arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.imageio.plugins.jpeg.JPEGQTable>>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JPEGMetadata;Z)[Ljavax/imageio/plugins/jpeg/JPEGHuffmanTable;", "private")]
	public JavaArray<Dova.JDK.javax.imageio.plugins.jpeg.JPEGHuffmanTable> collectHTablesFromMetadata(Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGMetadata arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.imageio.plugins.jpeg.JPEGHuffmanTable>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/imageio/metadata/IIOMetadata;)V", "private")]
	public void prepareWriteSequenceOnThread(Dova.JDK.javax.imageio.metadata.IIOMetadata arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(J[Ljavax/imageio/plugins/jpeg/JPEGQTable;[Ljavax/imageio/plugins/jpeg/JPEGHuffmanTable;[Ljavax/imageio/plugins/jpeg/JPEGHuffmanTable;)V", "private native")]
	public void writeTables(long arg0, JavaArray<Dova.JDK.javax.imageio.plugins.jpeg.JPEGQTable> arg1, JavaArray<Dova.JDK.javax.imageio.plugins.jpeg.JPEGHuffmanTable> arg2, JavaArray<Dova.JDK.javax.imageio.plugins.jpeg.JPEGHuffmanTable> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J)V", "private native")]
	public void abortWrite(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(J)V", "private native")]
	public void resetWriter(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
	public void warningWithMessage(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageTypeSpecifier;)I", "private")]
	public int getDestCSType(Dova.JDK.javax.imageio.ImageTypeSpecifier arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void writeMetadata()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34]);
	}

	[JniSignatureAttribute("(J)V", "private static native")]
	public static void disposeWriter(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("([BII)V", "private")]
	public void writeOutputData(JavaArray<byte> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void grabPixels(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("()Ljavax/imageio/ImageWriteParam;", "public")]
	public Dova.JDK.javax.imageio.ImageWriteParam getDefaultWriteParam()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.ImageWriteParam>(ret);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageWriteParam;)Ljavax/imageio/metadata/IIOMetadata;", "public")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadata getDefaultStreamMetadata(Dova.JDK.javax.imageio.ImageWriteParam arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadata>(ret);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageTypeSpecifier;Ljavax/imageio/ImageWriteParam;)Ljavax/imageio/metadata/IIOMetadata;", "public")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadata getDefaultImageMetadata(Dova.JDK.javax.imageio.ImageTypeSpecifier arg0, Dova.JDK.javax.imageio.ImageWriteParam arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadata>(ret);
	}

	[JniSignatureAttribute("(Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/ImageWriteParam;)Ljavax/imageio/metadata/IIOMetadata;", "public")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadata convertStreamMetadata(Dova.JDK.javax.imageio.metadata.IIOMetadata arg0, Dova.JDK.javax.imageio.ImageWriteParam arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadata>(ret);
	}

	[JniSignatureAttribute("(Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/ImageTypeSpecifier;Ljavax/imageio/ImageWriteParam;)Ljavax/imageio/metadata/IIOMetadata;", "public")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadata convertImageMetadata(Dova.JDK.javax.imageio.metadata.IIOMetadata arg0, Dova.JDK.javax.imageio.ImageTypeSpecifier arg1, Dova.JDK.javax.imageio.ImageWriteParam arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadata>(ret);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageTypeSpecifier;Ljavax/imageio/ImageWriteParam;Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/metadata/IIOMetadata;)I", "public")]
	public int getNumThumbnailsSupported(Dova.JDK.javax.imageio.ImageTypeSpecifier arg0, Dova.JDK.javax.imageio.ImageWriteParam arg1, Dova.JDK.javax.imageio.metadata.IIOMetadata arg2, Dova.JDK.javax.imageio.metadata.IIOMetadata arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageTypeSpecifier;Ljavax/imageio/ImageWriteParam;Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/metadata/IIOMetadata;)[Ljava/awt/Dimension;", "public")]
	public JavaArray<Dova.JDK.java.awt.Dimension> getPreferredThumbnailSizes(Dova.JDK.javax.imageio.ImageTypeSpecifier arg0, Dova.JDK.javax.imageio.ImageWriteParam arg1, Dova.JDK.javax.imageio.metadata.IIOMetadata arg2, Dova.JDK.javax.imageio.metadata.IIOMetadata arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Dimension>>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool canWriteRasters()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[45]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool canWriteSequence()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[46]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/imageio/metadata/IIOMetadata;)V", "public")]
	public void prepareWriteSequence(Dova.JDK.javax.imageio.metadata.IIOMetadata arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("(Ljavax/imageio/IIOImage;Ljavax/imageio/ImageWriteParam;)V", "public")]
	public void writeToSequence(Dova.JDK.javax.imageio.IIOImage arg0, Dova.JDK.javax.imageio.ImageWriteParam arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "public")]
	public void endWriteSequence()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49]);
	}

	[JniSignatureAttribute("(I)V", "")]
	public void thumbnailStarted(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
	}

	[JniSignatureAttribute("(F)V", "")]
	public void thumbnailProgress(float arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
	}

	[JniSignatureAttribute("()V", "")]
	public void thumbnailComplete()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52]);
	}

	[JniSignatureAttribute("(I)V", "")]
	public void warningOccurred(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
	}

	[JniSignatureAttribute("()V", "protected synchronized")]
	public void clearAbortRequest()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54]);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
	public void setOutput(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock;", "private static")]
	public partial class CallBackLock
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CallBackLock()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lockState", "Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock$State;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lock", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "check", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unlock", "()V"));
		}

		[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock$State;", "private")]
		public Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter.CallBackLock.State lockState_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter.CallBackLock.State>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CallBackLock(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public CallBackLock() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "private")]
		public void @lock()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()V", "")]
		public void check()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("()V", "private")]
		public void unlock()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock$State;", "private static final")]
		public partial class State
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static State()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock$State;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Unlocked", "Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock$State;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Locked", "Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock$State;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock$State;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock$State;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock$State;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock$State;"));
			}

			[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock$State;", "public static final")]
			public static Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter.CallBackLock.State Unlocked_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter.CallBackLock.State>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock$State;", "public static final")]
			public static Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter.CallBackLock.State Locked_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter.CallBackLock.State>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock$State;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter.CallBackLock.State> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter.CallBackLock.State>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public State(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public State(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock$State;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock$State;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter.CallBackLock.State> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter.CallBackLock.State>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock$State;", "public static")]
			public static Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter.CallBackLock.State valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter.CallBackLock.State>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$CallBackLock$State;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter.CallBackLock.State> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGImageWriter.CallBackLock.State>>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$JPEGWriterDisposerRecord;", "private static")]
	public partial class JPEGWriterDisposerRecord
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.java2d.DisposerRecord
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JPEGWriterDisposerRecord()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$JPEGWriterDisposerRecord;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pData", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		}

		[JniSignatureAttribute("J", "private")]
		public long pData_Property
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
		public JPEGWriterDisposerRecord(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(J)V", "public")]
		public JPEGWriterDisposerRecord(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/jpeg/JPEGImageWriter$JPEGWriterDisposerRecord;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public synchronized")]
		public void dispose()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}
}
