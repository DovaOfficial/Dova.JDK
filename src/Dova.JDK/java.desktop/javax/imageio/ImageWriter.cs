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

namespace Dova.JDK.javax.imageio;

[JniSignatureAttribute("Ljavax/imageio/ImageWriter;", "public abstract")]
public partial class ImageWriter
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.imageio.ImageTranscoder
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ImageWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/imageio/ImageWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "originatingProvider", "Ljavax/imageio/spi/ImageWriterSpi;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "output", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "availableLocales", "[Ljava/util/Locale;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "locale", "Ljava/util/Locale;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "warningListeners", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "warningLocales", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "progressListeners", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "abortFlag", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/imageio/spi/ImageWriterSpi;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/IIOImage;Ljavax/imageio/ImageWriteParam;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/awt/image/RenderedImage;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/imageio/IIOImage;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unsupported", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAvailableLocales", "()[Ljava/util/Locale;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocale", "()Ljava/util/Locale;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocale", "(Ljava/util/Locale;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "abort", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeImage", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeAllIIOWriteWarningListeners", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeAllIIOWriteProgressListeners", "()V"));
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
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canReplaceStreamMetadata", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceStreamMetadata", "(Ljavax/imageio/metadata/IIOMetadata;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canReplaceImageMetadata", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceImageMetadata", "(ILjavax/imageio/metadata/IIOMetadata;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canInsertImage", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeInsert", "(ILjavax/imageio/IIOImage;Ljavax/imageio/ImageWriteParam;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canRemoveImage", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canWriteEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepareWriteEmpty", "(Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/ImageTypeSpecifier;IILjavax/imageio/metadata/IIOMetadata;Ljava/util/List;Ljavax/imageio/ImageWriteParam;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endWriteEmpty", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canInsertEmpty", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepareInsertEmpty", "(ILjavax/imageio/ImageTypeSpecifier;IILjavax/imageio/metadata/IIOMetadata;Ljava/util/List;Ljavax/imageio/ImageWriteParam;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endInsertEmpty", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canReplacePixels", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepareReplacePixels", "(ILjava/awt/Rectangle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replacePixels", "(Ljava/awt/image/RenderedImage;Ljavax/imageio/ImageWriteParam;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replacePixels", "(Ljava/awt/image/Raster;Ljavax/imageio/ImageWriteParam;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endReplacePixels", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addIIOWriteWarningListener", "(Ljavax/imageio/event/IIOWriteWarningListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeIIOWriteWarningListener", "(Ljavax/imageio/event/IIOWriteWarningListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addIIOWriteProgressListener", "(Ljavax/imageio/event/IIOWriteProgressListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeIIOWriteProgressListener", "(Ljavax/imageio/event/IIOWriteProgressListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processWriteAborted", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOriginatingProvider", "()Ljavax/imageio/spi/ImageWriterSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearAbortRequest", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutput", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "abortRequested", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processImageStarted", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processImageProgress", "(F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processImageComplete", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processThumbnailStarted", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processThumbnailProgress", "(F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processThumbnailComplete", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processWarningOccurred", "(ILjava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processWarningOccurred", "(ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOutput", "(Ljava/lang/Object;)V"));
	}

	[JniSignatureAttribute("Ljavax/imageio/spi/ImageWriterSpi;", "protected")]
	public Dova.JDK.javax.imageio.spi.ImageWriterSpi originatingProvider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.spi.ImageWriterSpi>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "protected")]
	public Dova.JDK.java.lang.Object output_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/util/Locale;", "protected")]
	public JavaArray<Dova.JDK.java.util.Locale> availableLocales_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Locale>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Locale;", "protected")]
	public Dova.JDK.java.util.Locale locale_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "protected")]
	public Dova.JDK.java.util.List warningListeners_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "protected")]
	public Dova.JDK.java.util.List warningLocales_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "protected")]
	public Dova.JDK.java.util.List progressListeners_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool abortFlag_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ImageWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/imageio/spi/ImageWriterSpi;)V", "protected")]
	public ImageWriter(Dova.JDK.javax.imageio.spi.ImageWriterSpi arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/imageio/ImageWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/IIOImage;Ljavax/imageio/ImageWriteParam;)V", "public abstract")]
	public void write(Dova.JDK.javax.imageio.metadata.IIOMetadata arg0, Dova.JDK.javax.imageio.IIOImage arg1, Dova.JDK.javax.imageio.ImageWriteParam arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/image/RenderedImage;)V", "public")]
	public void write(Dova.JDK.java.awt.image.RenderedImage arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/imageio/IIOImage;)V", "public")]
	public void write(Dova.JDK.javax.imageio.IIOImage arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void unsupported()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void reset()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()[Ljava/util/Locale;", "public")]
	public JavaArray<Dova.JDK.java.util.Locale> getAvailableLocales()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Locale>>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Locale;", "public")]
	public Dova.JDK.java.util.Locale getLocale()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)V", "public")]
	public void setLocale(Dova.JDK.java.util.Locale arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void abort()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void removeImage(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void removeAllIIOWriteWarningListeners()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void removeAllIIOWriteProgressListeners()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("()Ljavax/imageio/ImageWriteParam;", "public")]
	public Dova.JDK.javax.imageio.ImageWriteParam getDefaultWriteParam()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.ImageWriteParam>(ret);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageWriteParam;)Ljavax/imageio/metadata/IIOMetadata;", "public abstract")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadata getDefaultStreamMetadata(Dova.JDK.javax.imageio.ImageWriteParam arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadata>(ret);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageTypeSpecifier;Ljavax/imageio/ImageWriteParam;)Ljavax/imageio/metadata/IIOMetadata;", "public abstract")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadata getDefaultImageMetadata(Dova.JDK.javax.imageio.ImageTypeSpecifier arg0, Dova.JDK.javax.imageio.ImageWriteParam arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadata>(ret);
	}

	[JniSignatureAttribute("(Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/ImageWriteParam;)Ljavax/imageio/metadata/IIOMetadata;", "public abstract")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadata convertStreamMetadata(Dova.JDK.javax.imageio.metadata.IIOMetadata arg0, Dova.JDK.javax.imageio.ImageWriteParam arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadata>(ret);
	}

	[JniSignatureAttribute("(Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/ImageTypeSpecifier;Ljavax/imageio/ImageWriteParam;)Ljavax/imageio/metadata/IIOMetadata;", "public abstract")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadata convertImageMetadata(Dova.JDK.javax.imageio.metadata.IIOMetadata arg0, Dova.JDK.javax.imageio.ImageTypeSpecifier arg1, Dova.JDK.javax.imageio.ImageWriteParam arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadata>(ret);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageTypeSpecifier;Ljavax/imageio/ImageWriteParam;Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/metadata/IIOMetadata;)I", "public")]
	public int getNumThumbnailsSupported(Dova.JDK.javax.imageio.ImageTypeSpecifier arg0, Dova.JDK.javax.imageio.ImageWriteParam arg1, Dova.JDK.javax.imageio.metadata.IIOMetadata arg2, Dova.JDK.javax.imageio.metadata.IIOMetadata arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageTypeSpecifier;Ljavax/imageio/ImageWriteParam;Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/metadata/IIOMetadata;)[Ljava/awt/Dimension;", "public")]
	public JavaArray<Dova.JDK.java.awt.Dimension> getPreferredThumbnailSizes(Dova.JDK.javax.imageio.ImageTypeSpecifier arg0, Dova.JDK.javax.imageio.ImageWriteParam arg1, Dova.JDK.javax.imageio.metadata.IIOMetadata arg2, Dova.JDK.javax.imageio.metadata.IIOMetadata arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Dimension>>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool canWriteRasters()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool canWriteSequence()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/imageio/metadata/IIOMetadata;)V", "public")]
	public void prepareWriteSequence(Dova.JDK.javax.imageio.metadata.IIOMetadata arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljavax/imageio/IIOImage;Ljavax/imageio/ImageWriteParam;)V", "public")]
	public void writeToSequence(Dova.JDK.javax.imageio.IIOImage arg0, Dova.JDK.javax.imageio.ImageWriteParam arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "public")]
	public void endWriteSequence()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool canReplaceStreamMetadata()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/imageio/metadata/IIOMetadata;)V", "public")]
	public void replaceStreamMetadata(Dova.JDK.javax.imageio.metadata.IIOMetadata arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool canReplaceImageMetadata(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILjavax/imageio/metadata/IIOMetadata;)V", "public")]
	public void replaceImageMetadata(int arg0, Dova.JDK.javax.imageio.metadata.IIOMetadata arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool canInsertImage(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILjavax/imageio/IIOImage;Ljavax/imageio/ImageWriteParam;)V", "public")]
	public void writeInsert(int arg0, Dova.JDK.javax.imageio.IIOImage arg1, Dova.JDK.javax.imageio.ImageWriteParam arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool canRemoveImage(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool canWriteEmpty()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[32]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/imageio/metadata/IIOMetadata;Ljavax/imageio/ImageTypeSpecifier;IILjavax/imageio/metadata/IIOMetadata;Ljava/util/List;Ljavax/imageio/ImageWriteParam;)V", "public")]
	public void prepareWriteEmpty(Dova.JDK.javax.imageio.metadata.IIOMetadata arg0, Dova.JDK.javax.imageio.ImageTypeSpecifier arg1, int arg2, int arg3, Dova.JDK.javax.imageio.metadata.IIOMetadata arg4, Dova.JDK.java.util.List arg5, Dova.JDK.javax.imageio.ImageWriteParam arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("()V", "public")]
	public void endWriteEmpty()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34]);
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool canInsertEmpty(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILjavax/imageio/ImageTypeSpecifier;IILjavax/imageio/metadata/IIOMetadata;Ljava/util/List;Ljavax/imageio/ImageWriteParam;)V", "public")]
	public void prepareInsertEmpty(int arg0, Dova.JDK.javax.imageio.ImageTypeSpecifier arg1, int arg2, int arg3, Dova.JDK.javax.imageio.metadata.IIOMetadata arg4, Dova.JDK.java.util.List arg5, Dova.JDK.javax.imageio.ImageWriteParam arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("()V", "public")]
	public void endInsertEmpty()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37]);
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool canReplacePixels(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/awt/Rectangle;)V", "public")]
	public void prepareReplacePixels(int arg0, Dova.JDK.java.awt.Rectangle arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/image/RenderedImage;Ljavax/imageio/ImageWriteParam;)V", "public")]
	public void replacePixels(Dova.JDK.java.awt.image.RenderedImage arg0, Dova.JDK.javax.imageio.ImageWriteParam arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/image/Raster;Ljavax/imageio/ImageWriteParam;)V", "public")]
	public void replacePixels(Dova.JDK.java.awt.image.Raster arg0, Dova.JDK.javax.imageio.ImageWriteParam arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "public")]
	public void endReplacePixels()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42]);
	}

	[JniSignatureAttribute("(Ljavax/imageio/event/IIOWriteWarningListener;)V", "public")]
	public void addIIOWriteWarningListener(Dova.JDK.javax.imageio.@event.IIOWriteWarningListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
	}

	[JniSignatureAttribute("(Ljavax/imageio/event/IIOWriteWarningListener;)V", "public")]
	public void removeIIOWriteWarningListener(Dova.JDK.javax.imageio.@event.IIOWriteWarningListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
	}

	[JniSignatureAttribute("(Ljavax/imageio/event/IIOWriteProgressListener;)V", "public")]
	public void addIIOWriteProgressListener(Dova.JDK.javax.imageio.@event.IIOWriteProgressListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
	}

	[JniSignatureAttribute("(Ljavax/imageio/event/IIOWriteProgressListener;)V", "public")]
	public void removeIIOWriteProgressListener(Dova.JDK.javax.imageio.@event.IIOWriteProgressListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void processWriteAborted()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47]);
	}

	[JniSignatureAttribute("()Ljavax/imageio/spi/ImageWriterSpi;", "public")]
	public Dova.JDK.javax.imageio.spi.ImageWriterSpi getOriginatingProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.spi.ImageWriterSpi>(ret);
	}

	[JniSignatureAttribute("()V", "protected synchronized")]
	public void clearAbortRequest()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49]);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getOutput()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Z", "protected synchronized")]
	public bool abortRequested()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[51]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void processImageStarted(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
	}

	[JniSignatureAttribute("(F)V", "protected")]
	public void processImageProgress(float arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void processImageComplete()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54]);
	}

	[JniSignatureAttribute("(II)V", "protected")]
	public void processThumbnailStarted(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
	}

	[JniSignatureAttribute("(F)V", "protected")]
	public void processThumbnailProgress(float arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void processThumbnailComplete()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57]);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;)V", "protected")]
	public void processWarningOccurred(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)V", "protected")]
	public void processWarningOccurred(int arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
	public void setOutput(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
	}
}
