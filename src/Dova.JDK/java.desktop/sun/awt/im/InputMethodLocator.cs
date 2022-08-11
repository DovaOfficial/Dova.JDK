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

namespace Dova.JDK.sun.awt.im;

[JniSignatureAttribute("Lsun/awt/im/InputMethodLocator;", "final")]
public partial class InputMethodLocator
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InputMethodLocator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/im/InputMethodLocator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptor", "Ljava/awt/im/spi/InputMethodDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loader", "Ljava/lang/ClassLoader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "locale", "Ljava/util/Locale;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/im/spi/InputMethodDescriptor;Ljava/lang/ClassLoader;Ljava/util/Locale;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoader", "()Ljava/lang/ClassLoader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescriptor", "()Ljava/awt/im/spi/InputMethodDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocale", "()Ljava/util/Locale;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLocaleAvailable", "(Ljava/util/Locale;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deriveLocator", "(Ljava/util/Locale;)Lsun/awt/im/InputMethodLocator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sameInputMethod", "(Lsun/awt/im/InputMethodLocator;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActionCommandString", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljava/awt/im/spi/InputMethodDescriptor;", "private")]
	public Dova.JDK.java.awt.im.spi.InputMethodDescriptor descriptor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.im.spi.InputMethodDescriptor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private")]
	public Dova.JDK.java.lang.ClassLoader loader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Locale;", "private")]
	public Dova.JDK.java.util.Locale locale_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public InputMethodLocator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/im/spi/InputMethodDescriptor;Ljava/lang/ClassLoader;Ljava/util/Locale;)V", "")]
	public InputMethodLocator(Dova.JDK.java.awt.im.spi.InputMethodDescriptor arg0, Dova.JDK.java.lang.ClassLoader arg1, Dova.JDK.java.util.Locale arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/im/InputMethodLocator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "")]
	public Dova.JDK.java.lang.ClassLoader getClassLoader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/im/spi/InputMethodDescriptor;", "")]
	public Dova.JDK.java.awt.im.spi.InputMethodDescriptor getDescriptor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.im.spi.InputMethodDescriptor>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Locale;", "")]
	public Dova.JDK.java.util.Locale getLocale()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Z", "")]
	public bool isLocaleAvailable(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Lsun/awt/im/InputMethodLocator;", "")]
	public Dova.JDK.sun.awt.im.InputMethodLocator deriveLocator(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.im.InputMethodLocator>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/im/InputMethodLocator;)Z", "")]
	public bool sameInputMethod(Dova.JDK.sun.awt.im.InputMethodLocator arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getActionCommandString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
