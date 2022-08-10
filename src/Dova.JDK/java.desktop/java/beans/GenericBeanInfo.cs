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

namespace Dova.JDK.java.beans;

[JniSignatureAttribute("Ljava/beans/GenericBeanInfo;", "")]
public partial class GenericBeanInfo
	: Dova.JDK.java.beans.SimpleBeanInfo
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GenericBeanInfo()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/GenericBeanInfo;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "beanDescriptor", "Ljava/beans/BeanDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "events", "[Ljava/beans/EventSetDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "defaultEvent", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "properties", "[Ljava/beans/PropertyDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "defaultProperty", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "methods", "[Ljava/beans/MethodDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "targetBeanInfoRef", "Ljava/lang/ref/Reference;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GenericBeanInfo", "(Ljava/beans/BeanDescriptor;[Ljava/beans/EventSetDescriptor;I[Ljava/beans/PropertyDescriptor;I[Ljava/beans/MethodDescriptor;Ljava/beans/BeanInfo;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GenericBeanInfo", "(Ljava/beans/GenericBeanInfo;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTargetBeanInfo", "()Ljava/beans/BeanInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getEventSetDescriptors", "()[Ljava/beans/EventSetDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDefaultEventIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMethodDescriptors", "()[Ljava/beans/MethodDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBeanDescriptor", "()Ljava/beans/BeanDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPropertyDescriptors", "()[Ljava/beans/PropertyDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDefaultPropertyIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getIcon", "(I)Ljava/awt/Image;"));
	}

	[JniSignatureAttribute("Ljava/beans/BeanDescriptor;", "private")]
	public Dova.JDK.java.beans.BeanDescriptor beanDescriptor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.BeanDescriptor>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/beans/EventSetDescriptor;", "private")]
	public JavaArray<Dova.JDK.java.beans.EventSetDescriptor> events_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.EventSetDescriptor>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int defaultEvent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("[Ljava/beans/PropertyDescriptor;", "private")]
	public JavaArray<Dova.JDK.java.beans.PropertyDescriptor> properties_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.PropertyDescriptor>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int defaultProperty_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("[Ljava/beans/MethodDescriptor;", "private")]
	public JavaArray<Dova.JDK.java.beans.MethodDescriptor> methods_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.MethodDescriptor>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/ref/Reference;", "private")]
	public Dova.JDK.java.lang.@ref.Reference targetBeanInfoRef_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.Reference>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GenericBeanInfo(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/beans/BeanDescriptor;[Ljava/beans/EventSetDescriptor;I[Ljava/beans/PropertyDescriptor;I[Ljava/beans/MethodDescriptor;Ljava/beans/BeanInfo;)V", "public")]
	public GenericBeanInfo(Dova.JDK.java.beans.BeanDescriptor arg0, JavaArray<Dova.JDK.java.beans.EventSetDescriptor> arg1, int arg2, JavaArray<Dova.JDK.java.beans.PropertyDescriptor> arg3, int arg4, JavaArray<Dova.JDK.java.beans.MethodDescriptor> arg5, Dova.JDK.java.beans.BeanInfo arg6) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	[JniSignatureAttribute("(Ljava/beans/GenericBeanInfo;)V", "")]
	public GenericBeanInfo(Dova.JDK.java.beans.GenericBeanInfo arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/beans/GenericBeanInfo;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/beans/BeanInfo;", "private")]
	public Dova.JDK.java.beans.BeanInfo getTargetBeanInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.beans.BeanInfo>(ret);
	}

	[JniSignatureAttribute("()[Ljava/beans/EventSetDescriptor;", "public")]
	public JavaArray<Dova.JDK.java.beans.EventSetDescriptor> getEventSetDescriptors()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.EventSetDescriptor>>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDefaultEventIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/beans/MethodDescriptor;", "public")]
	public JavaArray<Dova.JDK.java.beans.MethodDescriptor> getMethodDescriptors()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.MethodDescriptor>>(ret);
	}

	[JniSignatureAttribute("()Ljava/beans/BeanDescriptor;", "public")]
	public Dova.JDK.java.beans.BeanDescriptor getBeanDescriptor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.beans.BeanDescriptor>(ret);
	}

	[JniSignatureAttribute("()[Ljava/beans/PropertyDescriptor;", "public")]
	public JavaArray<Dova.JDK.java.beans.PropertyDescriptor> getPropertyDescriptors()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.PropertyDescriptor>>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDefaultPropertyIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/awt/Image;", "public")]
	public Dova.JDK.java.awt.Image getIcon(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Image>(ret);
	}
}
