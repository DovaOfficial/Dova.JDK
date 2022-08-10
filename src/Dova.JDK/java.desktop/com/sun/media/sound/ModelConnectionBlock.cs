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

namespace Dova.JDK.com.sun.media.sound;

[JniSignatureAttribute("Lcom/sun/media/sound/ModelConnectionBlock;", "public final")]
public partial class ModelConnectionBlock
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ModelConnectionBlock()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/media/sound/ModelConnectionBlock;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "no_sources", "[Lcom/sun/media/sound/ModelSource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "sources", "[Lcom/sun/media/sound/ModelSource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "scale", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "destination", "Lcom/sun/media/sound/ModelDestination;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ModelConnectionBlock", "(Lcom/sun/media/sound/ModelSource;Lcom/sun/media/sound/ModelSource;DLcom/sun/media/sound/ModelDestination;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ModelConnectionBlock", "(Lcom/sun/media/sound/ModelSource;Lcom/sun/media/sound/ModelSource;Lcom/sun/media/sound/ModelDestination;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ModelConnectionBlock", "(Lcom/sun/media/sound/ModelSource;DLcom/sun/media/sound/ModelDestination;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ModelConnectionBlock", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ModelConnectionBlock", "(DLcom/sun/media/sound/ModelDestination;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ModelConnectionBlock", "(Lcom/sun/media/sound/ModelSource;Lcom/sun/media/sound/ModelDestination;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setScale", "(D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addSource", "(Lcom/sun/media/sound/ModelSource;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSources", "()[Lcom/sun/media/sound/ModelSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDestination", "()Lcom/sun/media/sound/ModelDestination;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getScale", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDestination", "(Lcom/sun/media/sound/ModelDestination;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setSources", "([Lcom/sun/media/sound/ModelSource;)V"));
	}

	[JniSignatureAttribute("[Lcom/sun/media/sound/ModelSource;", "private static final")]
	public static JavaArray<Dova.JDK.com.sun.media.sound.ModelSource> no_sources_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.media.sound.ModelSource>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Lcom/sun/media/sound/ModelSource;", "private")]
	public JavaArray<Dova.JDK.com.sun.media.sound.ModelSource> sources_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.media.sound.ModelSource>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("D", "private")]
	public double scale_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("Lcom/sun/media/sound/ModelDestination;", "private")]
	public Dova.JDK.com.sun.media.sound.ModelDestination destination_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelDestination>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ModelConnectionBlock(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/ModelSource;Lcom/sun/media/sound/ModelSource;DLcom/sun/media/sound/ModelDestination;)V", "public")]
	public ModelConnectionBlock(Dova.JDK.com.sun.media.sound.ModelSource arg0, Dova.JDK.com.sun.media.sound.ModelSource arg1, double arg2, Dova.JDK.com.sun.media.sound.ModelDestination arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/ModelSource;Lcom/sun/media/sound/ModelSource;Lcom/sun/media/sound/ModelDestination;)V", "public")]
	public ModelConnectionBlock(Dova.JDK.com.sun.media.sound.ModelSource arg0, Dova.JDK.com.sun.media.sound.ModelSource arg1, Dova.JDK.com.sun.media.sound.ModelDestination arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/ModelSource;DLcom/sun/media/sound/ModelDestination;)V", "public")]
	public ModelConnectionBlock(Dova.JDK.com.sun.media.sound.ModelSource arg0, double arg1, Dova.JDK.com.sun.media.sound.ModelDestination arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ModelConnectionBlock() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3]))
	{
	}

	[JniSignatureAttribute("(DLcom/sun/media/sound/ModelDestination;)V", "public")]
	public ModelConnectionBlock(double arg0, Dova.JDK.com.sun.media.sound.ModelDestination arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[4], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/ModelSource;Lcom/sun/media/sound/ModelDestination;)V", "public")]
	public ModelConnectionBlock(Dova.JDK.com.sun.media.sound.ModelSource arg0, Dova.JDK.com.sun.media.sound.ModelDestination arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[5], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/ModelConnectionBlock;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(D)V", "public")]
	public void setScale(double arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/ModelSource;)V", "public")]
	public void addSource(Dova.JDK.com.sun.media.sound.ModelSource arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()[Lcom/sun/media/sound/ModelSource;", "public")]
	public JavaArray<Dova.JDK.com.sun.media.sound.ModelSource> getSources()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.media.sound.ModelSource>>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/media/sound/ModelDestination;", "public")]
	public Dova.JDK.com.sun.media.sound.ModelDestination getDestination()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.media.sound.ModelDestination>(ret);
	}

	[JniSignatureAttribute("()D", "public")]
	public double getScale()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/media/sound/ModelDestination;)V", "public")]
	public void setDestination(Dova.JDK.com.sun.media.sound.ModelDestination arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("([Lcom/sun/media/sound/ModelSource;)V", "public")]
	public void setSources(JavaArray<Dova.JDK.com.sun.media.sound.ModelSource> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}
}
