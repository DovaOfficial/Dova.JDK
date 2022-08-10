/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
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

[JniSignatureAttribute("Lsun/awt/image/InputStreamImageSource;", "public abstract")]
public partial class InputStreamImageSource
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.awt.image.ImageProducer
	, Dova.JDK.sun.awt.image.ImageFetchable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InputStreamImageSource()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/image/InputStreamImageSource;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "consumers", "Lsun/awt/image/ImageConsumerQueue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "decoder", "Lsun/awt/image/ImageDecoder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "decoders", "Lsun/awt/image/ImageDecoder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "awaitingFetch", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "InputStreamImageSource", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "flush", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkSecurity", "(Ljava/lang/Object;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "countConsumers", "(Lsun/awt/image/ImageConsumerQueue;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "countConsumers", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printQueue", "(Lsun/awt/image/ImageConsumerQueue;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "errorConsumer", "(Lsun/awt/image/ImageConsumerQueue;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "errorAllConsumers", "(Lsun/awt/image/ImageConsumerQueue;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "badDecoder", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDecoder", "(Lsun/awt/image/ImageDecoder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeDecoder", "(Lsun/awt/image/ImageDecoder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "doneDecoding", "(Lsun/awt/image/ImageDecoder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printQueues", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "stopProduction", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "decoderForType", "(Ljava/io/InputStream;Ljava/lang/String;)Lsun/awt/image/ImageDecoder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "doFetch", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "latchConsumers", "(Lsun/awt/image/ImageDecoder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDecoder", "()Lsun/awt/image/ImageDecoder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDecoder", "(Ljava/io/InputStream;)Lsun/awt/image/ImageDecoder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addConsumer", "(Ljava/awt/image/ImageConsumer;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addConsumer", "(Ljava/awt/image/ImageConsumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isConsumer", "(Ljava/awt/image/ImageConsumer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeConsumer", "(Ljava/awt/image/ImageConsumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "startProduction", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "startProduction", "(Ljava/awt/image/ImageConsumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "requestTopDownLeftRightResend", "(Ljava/awt/image/ImageConsumer;)V"));
	}

	[JniSignatureAttribute("Lsun/awt/image/ImageConsumerQueue;", "")]
	public Dova.JDK.sun.awt.image.ImageConsumerQueue consumers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.ImageConsumerQueue>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/image/ImageDecoder;", "")]
	public Dova.JDK.sun.awt.image.ImageDecoder decoder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.ImageDecoder>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/awt/image/ImageDecoder;", "")]
	public Dova.JDK.sun.awt.image.ImageDecoder decoders_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.ImageDecoder>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "")]
	public bool awaitingFetch_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public InputStreamImageSource(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public InputStreamImageSource() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/image/InputStreamImageSource;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "synchronized")]
	public void flush()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Z)Z", "abstract")]
	public bool checkSecurity(Dova.JDK.java.lang.Object arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/image/ImageConsumerQueue;)I", "")]
	public int countConsumers(Dova.JDK.sun.awt.image.ImageConsumerQueue arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "synchronized")]
	public int countConsumers()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/image/ImageConsumerQueue;Ljava/lang/String;)V", "synchronized")]
	public void printQueue(Dova.JDK.sun.awt.image.ImageConsumerQueue arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/awt/image/ImageConsumerQueue;Z)V", "private")]
	public void errorConsumer(Dova.JDK.sun.awt.image.ImageConsumerQueue arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/awt/image/ImageConsumerQueue;Z)V", "private")]
	public void errorAllConsumers(Dova.JDK.sun.awt.image.ImageConsumerQueue arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void badDecoder()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("(Lsun/awt/image/ImageDecoder;)V", "private")]
	public void setDecoder(Dova.JDK.sun.awt.image.ImageDecoder arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/image/ImageDecoder;)V", "private synchronized")]
	public void removeDecoder(Dova.JDK.sun.awt.image.ImageDecoder arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/image/ImageDecoder;)V", "synchronized")]
	public void doneDecoding(Dova.JDK.sun.awt.image.ImageDecoder arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "synchronized")]
	public void printQueues(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("()V", "private synchronized")]
	public void stopProduction()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/lang/String;)Lsun/awt/image/ImageDecoder;", "protected")]
	public Dova.JDK.sun.awt.image.ImageDecoder decoderForType(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.ImageDecoder>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void doFetch()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
	}

	[JniSignatureAttribute("(Lsun/awt/image/ImageDecoder;)V", "")]
	public void latchConsumers(Dova.JDK.sun.awt.image.ImageDecoder arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/image/ImageDecoder;", "protected abstract")]
	public Dova.JDK.sun.awt.image.ImageDecoder getDecoder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.ImageDecoder>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Lsun/awt/image/ImageDecoder;", "protected")]
	public Dova.JDK.sun.awt.image.ImageDecoder getDecoder(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.image.ImageDecoder>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ImageConsumer;Z)V", "synchronized")]
	public void addConsumer(Dova.JDK.java.awt.image.ImageConsumer arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ImageConsumer;)V", "public")]
	public void addConsumer(Dova.JDK.java.awt.image.ImageConsumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ImageConsumer;)Z", "public synchronized")]
	public bool isConsumer(Dova.JDK.java.awt.image.ImageConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/ImageConsumer;)V", "public synchronized")]
	public void removeConsumer(Dova.JDK.java.awt.image.ImageConsumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("()V", "private synchronized")]
	public void startProduction()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22]);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ImageConsumer;)V", "public")]
	public void startProduction(Dova.JDK.java.awt.image.ImageConsumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ImageConsumer;)V", "public")]
	public void requestTopDownLeftRightResend(Dova.JDK.java.awt.image.ImageConsumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}
}
