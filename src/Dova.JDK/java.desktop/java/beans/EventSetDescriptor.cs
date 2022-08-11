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

namespace Dova.JDK.java.beans;

[JniSignatureAttribute("Ljava/beans/EventSetDescriptor;", "public")]
public partial class EventSetDescriptor
	: Dova.JDK.java.beans.FeatureDescriptor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EventSetDescriptor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/EventSetDescriptor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listenerMethodDescriptors", "[Ljava/beans/MethodDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addMethodDescriptor", "Ljava/beans/MethodDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removeMethodDescriptor", "Ljava/beans/MethodDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getMethodDescriptor", "Ljava/beans/MethodDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listenerMethodsRef", "Ljava/lang/ref/Reference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listenerTypeRef", "Ljava/lang/ref/Reference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unicast", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inDefaultEventSet", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/beans/EventSetDescriptor;Ljava/beans/EventSetDescriptor;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/Class;[Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/Class;[Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lcom/sun/beans/introspect/EventSetInfo;[Ljava/lang/reflect/Method;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/Class;[Ljava/beans/MethodDescriptor;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/beans/EventSetDescriptor;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMethod", "(Ljava/beans/MethodDescriptor;)Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMethod", "(Ljava/lang/Class;Ljava/lang/String;I)Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendTo", "(Ljava/lang/StringBuilder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getListenerType", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getListenerClassName", "(Ljava/lang/Class;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getListenerMethods", "()[Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setListenerType", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setListenerMethods", "([Ljava/lang/reflect/Method;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAddListenerMethod", "(Ljava/lang/reflect/Method;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRemoveListenerMethod", "(Ljava/lang/reflect/Method;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGetListenerMethod", "(Ljava/lang/reflect/Method;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUnicast", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setUnicast", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getListenerMethods0", "()[Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getListenerMethodDescriptors", "()[Ljava/beans/MethodDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAddListenerMethod", "()Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRemoveListenerMethod", "()Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGetListenerMethod", "()Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInDefaultEventSet", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInDefaultEventSet", "()Z"));
	}

	[JniSignatureAttribute("[Ljava/beans/MethodDescriptor;", "private")]
	public JavaArray<Dova.JDK.java.beans.MethodDescriptor> listenerMethodDescriptors_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.MethodDescriptor>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MethodDescriptor;", "private")]
	public Dova.JDK.java.beans.MethodDescriptor addMethodDescriptor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.MethodDescriptor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MethodDescriptor;", "private")]
	public Dova.JDK.java.beans.MethodDescriptor removeMethodDescriptor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.MethodDescriptor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MethodDescriptor;", "private")]
	public Dova.JDK.java.beans.MethodDescriptor getMethodDescriptor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.MethodDescriptor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/Reference;", "private")]
	public Dova.JDK.java.lang.@ref.Reference listenerMethodsRef_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.Reference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/Reference;", "private")]
	public Dova.JDK.java.lang.@ref.Reference listenerTypeRef_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.Reference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool unicast_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool inDefaultEventSet_Property
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
	public EventSetDescriptor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/beans/EventSetDescriptor;Ljava/beans/EventSetDescriptor;)V", "")]
	public EventSetDescriptor(Dova.JDK.java.beans.EventSetDescriptor arg0, Dova.JDK.java.beans.EventSetDescriptor arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;[Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V", "public")]
	public EventSetDescriptor(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.java.lang.reflect.Method> arg2, Dova.JDK.java.lang.reflect.Method arg3, Dova.JDK.java.lang.reflect.Method arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;[Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V", "public")]
	public EventSetDescriptor(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.java.lang.reflect.Method> arg2, Dova.JDK.java.lang.reflect.Method arg3, Dova.JDK.java.lang.reflect.Method arg4, Dova.JDK.java.lang.reflect.Method arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/beans/introspect/EventSetInfo;[Ljava/lang/reflect/Method;)V", "transient")]
	public EventSetDescriptor(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.beans.introspect.EventSetInfo arg1, JavaArray<Dova.JDK.java.lang.reflect.Method> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;[Ljava/beans/MethodDescriptor;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V", "public")]
	public EventSetDescriptor(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.java.beans.MethodDescriptor> arg2, Dova.JDK.java.lang.reflect.Method arg3, Dova.JDK.java.lang.reflect.Method arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/String;)V", "public")]
	public EventSetDescriptor(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[5], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/beans/EventSetDescriptor;)V", "")]
	public EventSetDescriptor(Dova.JDK.java.beans.EventSetDescriptor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[6], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public EventSetDescriptor(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Class arg2, JavaArray<Dova.JDK.java.lang.String> arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[7], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public EventSetDescriptor(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Class arg2, JavaArray<Dova.JDK.java.lang.String> arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.java.lang.String arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/beans/EventSetDescriptor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/beans/MethodDescriptor;)Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method getMethod(Dova.JDK.java.beans.MethodDescriptor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;I)Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method getMethod(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuilder;)V", "")]
	public void appendTo(Dova.JDK.java.lang.StringBuilder arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class getListenerType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String getListenerClassName(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/Method;", "public synchronized")]
	public JavaArray<Dova.JDK.java.lang.reflect.Method> getListenerMethods()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Method>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "private")]
	public void setListenerType(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Method;)V", "private")]
	public void setListenerMethods(JavaArray<Dova.JDK.java.lang.reflect.Method> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)V", "private synchronized")]
	public void setAddListenerMethod(Dova.JDK.java.lang.reflect.Method arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)V", "private synchronized")]
	public void setRemoveListenerMethod(Dova.JDK.java.lang.reflect.Method arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)V", "private synchronized")]
	public void setGetListenerMethod(Dova.JDK.java.lang.reflect.Method arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isUnicast()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setUnicast(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/Method;", "private")]
	public JavaArray<Dova.JDK.java.lang.reflect.Method> getListenerMethods0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Method>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/beans/MethodDescriptor;", "public synchronized")]
	public JavaArray<Dova.JDK.java.beans.MethodDescriptor> getListenerMethodDescriptors()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.MethodDescriptor>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Method;", "public synchronized")]
	public Dova.JDK.java.lang.reflect.Method getAddListenerMethod()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Method;", "public synchronized")]
	public Dova.JDK.java.lang.reflect.Method getRemoveListenerMethod()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Method;", "public synchronized")]
	public Dova.JDK.java.lang.reflect.Method getGetListenerMethod()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setInDefaultEventSet(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isInDefaultEventSet()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}
}
