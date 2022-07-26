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

namespace Dova.JDK.java.awt.image.renderable;

[JniSignatureAttribute("Ljava/awt/image/renderable/RenderableImageProducer;", "public")]
public partial class RenderableImageProducer
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.awt.image.ImageProducer
	, Dova.JDK.java.lang.Runnable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RenderableImageProducer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/image/renderable/RenderableImageProducer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rdblImage", "Ljava/awt/image/renderable/RenderableImage;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rc", "Ljava/awt/image/renderable/RenderContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ics", "Ljava/util/Vector;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/image/renderable/RenderableImage;Ljava/awt/image/renderable/RenderContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRenderContext", "(Ljava/awt/image/renderable/RenderContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConsumer", "(Ljava/awt/image/ImageConsumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConsumer", "(Ljava/awt/image/ImageConsumer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeConsumer", "(Ljava/awt/image/ImageConsumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startProduction", "(Ljava/awt/image/ImageConsumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestTopDownLeftRightResend", "(Ljava/awt/image/ImageConsumer;)V"));
	}

	[JniSignatureAttribute("Ljava/awt/image/renderable/RenderableImage;", "")]
	public Dova.JDK.java.awt.image.renderable.RenderableImage rdblImage_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.RenderableImage>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/image/renderable/RenderContext;", "")]
	public Dova.JDK.java.awt.image.renderable.RenderContext rc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.RenderContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "")]
	public Dova.JDK.java.util.Vector ics_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RenderableImageProducer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/image/renderable/RenderableImage;Ljava/awt/image/renderable/RenderContext;)V", "public")]
	public RenderableImageProducer(Dova.JDK.java.awt.image.renderable.RenderableImage arg0, Dova.JDK.java.awt.image.renderable.RenderContext arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/image/renderable/RenderableImageProducer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void run()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/awt/image/renderable/RenderContext;)V", "public synchronized")]
	public void setRenderContext(Dova.JDK.java.awt.image.renderable.RenderContext arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ImageConsumer;)V", "public synchronized")]
	public void addConsumer(Dova.JDK.java.awt.image.ImageConsumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ImageConsumer;)Z", "public synchronized")]
	public bool isConsumer(Dova.JDK.java.awt.image.ImageConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/ImageConsumer;)V", "public synchronized")]
	public void removeConsumer(Dova.JDK.java.awt.image.ImageConsumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ImageConsumer;)V", "public synchronized")]
	public void startProduction(Dova.JDK.java.awt.image.ImageConsumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ImageConsumer;)V", "public")]
	public void requestTopDownLeftRightResend(Dova.JDK.java.awt.image.ImageConsumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}
}
