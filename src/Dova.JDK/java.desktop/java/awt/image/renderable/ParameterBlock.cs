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

[JniSignatureAttribute("Ljava/awt/image/renderable/ParameterBlock;", "public")]
public partial class ParameterBlock
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.Cloneable
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ParameterBlock()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/image/renderable/ParameterBlock;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sources", "Ljava/util/Vector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameters", "Ljava/util/Vector;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Vector;Ljava/util/Vector;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Vector;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(S)Ljava/awt/image/renderable/ParameterBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(C)Ljava/awt/image/renderable/ParameterBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(B)Ljava/awt/image/renderable/ParameterBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/lang/Object;)Ljava/awt/image/renderable/ParameterBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(D)Ljava/awt/image/renderable/ParameterBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(F)Ljava/awt/image/renderable/ParameterBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(J)Ljava/awt/image/renderable/ParameterBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(I)Ljava/awt/image/renderable/ParameterBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(II)Ljava/awt/image/renderable/ParameterBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(JI)Ljava/awt/image/renderable/ParameterBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(FI)Ljava/awt/image/renderable/ParameterBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(SI)Ljava/awt/image/renderable/ParameterBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(CI)Ljava/awt/image/renderable/ParameterBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(Ljava/lang/Object;I)Ljava/awt/image/renderable/ParameterBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(BI)Ljava/awt/image/renderable/ParameterBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(DI)Ljava/awt/image/renderable/ParameterBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters", "()Ljava/util/Vector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setParameters", "(Ljava/util/Vector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSource", "(I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSources", "(Ljava/util/Vector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumParameters", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObjectParameter", "(I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shallowClone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSource", "(Ljava/lang/Object;)Ljava/awt/image/renderable/ParameterBlock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRenderedSource", "(I)Ljava/awt/image/RenderedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRenderableSource", "(I)Ljava/awt/image/renderable/RenderableImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumSources", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeSources", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeParameters", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByteParameter", "(I)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharParameter", "(I)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShortParameter", "(I)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntParameter", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLongParameter", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFloatParameter", "(I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDoubleParameter", "(I)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParamClasses", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSources", "()Ljava/util/Vector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSource", "(Ljava/lang/Object;I)Ljava/awt/image/renderable/ParameterBlock;"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "protected")]
	public Dova.JDK.java.util.Vector sources_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "protected")]
	public Dova.JDK.java.util.Vector parameters_Property
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
	public ParameterBlock(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/Vector;Ljava/util/Vector;)V", "public")]
	public ParameterBlock(Dova.JDK.java.util.Vector arg0, Dova.JDK.java.util.Vector arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/util/Vector;)V", "public")]
	public ParameterBlock(Dova.JDK.java.util.Vector arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ParameterBlock() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/image/renderable/ParameterBlock;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(S)Ljava/awt/image/renderable/ParameterBlock;", "public")]
	public Dova.JDK.java.awt.image.renderable.ParameterBlock add(short arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.ParameterBlock>(ret);
	}

	[JniSignatureAttribute("(C)Ljava/awt/image/renderable/ParameterBlock;", "public")]
	public Dova.JDK.java.awt.image.renderable.ParameterBlock add(char arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.ParameterBlock>(ret);
	}

	[JniSignatureAttribute("(B)Ljava/awt/image/renderable/ParameterBlock;", "public")]
	public Dova.JDK.java.awt.image.renderable.ParameterBlock add(byte arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.ParameterBlock>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/awt/image/renderable/ParameterBlock;", "public")]
	public Dova.JDK.java.awt.image.renderable.ParameterBlock add(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.ParameterBlock>(ret);
	}

	[JniSignatureAttribute("(D)Ljava/awt/image/renderable/ParameterBlock;", "public")]
	public Dova.JDK.java.awt.image.renderable.ParameterBlock add(double arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.ParameterBlock>(ret);
	}

	[JniSignatureAttribute("(F)Ljava/awt/image/renderable/ParameterBlock;", "public")]
	public Dova.JDK.java.awt.image.renderable.ParameterBlock add(float arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.ParameterBlock>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/awt/image/renderable/ParameterBlock;", "public")]
	public Dova.JDK.java.awt.image.renderable.ParameterBlock add(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.ParameterBlock>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/awt/image/renderable/ParameterBlock;", "public")]
	public Dova.JDK.java.awt.image.renderable.ParameterBlock add(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.ParameterBlock>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/awt/image/renderable/ParameterBlock;", "public")]
	public Dova.JDK.java.awt.image.renderable.ParameterBlock set(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.ParameterBlock>(ret);
	}

	[JniSignatureAttribute("(JI)Ljava/awt/image/renderable/ParameterBlock;", "public")]
	public Dova.JDK.java.awt.image.renderable.ParameterBlock set(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.ParameterBlock>(ret);
	}

	[JniSignatureAttribute("(FI)Ljava/awt/image/renderable/ParameterBlock;", "public")]
	public Dova.JDK.java.awt.image.renderable.ParameterBlock set(float arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.ParameterBlock>(ret);
	}

	[JniSignatureAttribute("(SI)Ljava/awt/image/renderable/ParameterBlock;", "public")]
	public Dova.JDK.java.awt.image.renderable.ParameterBlock set(short arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.ParameterBlock>(ret);
	}

	[JniSignatureAttribute("(CI)Ljava/awt/image/renderable/ParameterBlock;", "public")]
	public Dova.JDK.java.awt.image.renderable.ParameterBlock set(char arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.ParameterBlock>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)Ljava/awt/image/renderable/ParameterBlock;", "public")]
	public Dova.JDK.java.awt.image.renderable.ParameterBlock set(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.ParameterBlock>(ret);
	}

	[JniSignatureAttribute("(BI)Ljava/awt/image/renderable/ParameterBlock;", "public")]
	public Dova.JDK.java.awt.image.renderable.ParameterBlock set(byte arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.ParameterBlock>(ret);
	}

	[JniSignatureAttribute("(DI)Ljava/awt/image/renderable/ParameterBlock;", "public")]
	public Dova.JDK.java.awt.image.renderable.ParameterBlock set(double arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.ParameterBlock>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Vector;", "public")]
	public Dova.JDK.java.util.Vector getParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Vector;)V", "public")]
	public void setParameters(Dova.JDK.java.util.Vector arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(I)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getSource(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Vector;)V", "public")]
	public void setSources(Dova.JDK.java.util.Vector arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNumParameters()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getObjectParameter(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object shallowClone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/awt/image/renderable/ParameterBlock;", "public")]
	public Dova.JDK.java.awt.image.renderable.ParameterBlock addSource(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.ParameterBlock>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/awt/image/RenderedImage;", "public")]
	public Dova.JDK.java.awt.image.RenderedImage getRenderedSource(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.RenderedImage>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/awt/image/renderable/RenderableImage;", "public")]
	public Dova.JDK.java.awt.image.renderable.RenderableImage getRenderableSource(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.RenderableImage>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNumSources()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void removeSources()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void removeParameters()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29]);
	}

	[JniSignatureAttribute("(I)B", "public")]
	public byte getByteParameter(int arg0)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)C", "public")]
	public char getCharParameter(int arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)S", "public")]
	public short getShortParameter(int arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getIntParameter(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)J", "public")]
	public long getLongParameter(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)F", "public")]
	public float getFloatParameter(int arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)D", "public")]
	public double getDoubleParameter(int arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "public")]
	public JavaArray<Dova.JDK.java.lang.Class> getParamClasses()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Vector;", "public")]
	public Dova.JDK.java.util.Vector getSources()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)Ljava/awt/image/renderable/ParameterBlock;", "public")]
	public Dova.JDK.java.awt.image.renderable.ParameterBlock setSource(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.ParameterBlock>(ret);
	}
}
