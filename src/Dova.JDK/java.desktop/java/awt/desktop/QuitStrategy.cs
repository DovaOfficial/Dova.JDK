/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.java.awt.desktop;

[JniSignatureAttribute("Ljava/awt/desktop/QuitStrategy;", "public final")]
public partial class QuitStrategy
	: Dova.JDK.java.lang.Enum
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static QuitStrategy()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/awt/desktop/QuitStrategy;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NORMAL_EXIT", "Ljava/awt/desktop/QuitStrategy;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CLOSE_ALL_WINDOWS", "Ljava/awt/desktop/QuitStrategy;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljava/awt/desktop/QuitStrategy;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "QuitStrategy", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljava/awt/desktop/QuitStrategy;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljava/awt/desktop/QuitStrategy;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljava/awt/desktop/QuitStrategy;"));
	}

	[JniSignatureAttribute("Ljava/awt/desktop/QuitStrategy;", "public static final")]
	public static Dova.JDK.java.awt.desktop.QuitStrategy NORMAL_EXIT_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.desktop.QuitStrategy>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/awt/desktop/QuitStrategy;", "public static final")]
	public static Dova.JDK.java.awt.desktop.QuitStrategy CLOSE_ALL_WINDOWS_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.desktop.QuitStrategy>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/awt/desktop/QuitStrategy;", "private static final")]
	public static JavaArray<Dova.JDK.java.awt.desktop.QuitStrategy> VALUES_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.desktop.QuitStrategy>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public QuitStrategy(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
	public QuitStrategy(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/desktop/QuitStrategy;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Ljava/awt/desktop/QuitStrategy;", "public static")]
	public static JavaArray<Dova.JDK.java.awt.desktop.QuitStrategy> values()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.desktop.QuitStrategy>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/awt/desktop/QuitStrategy;", "public static")]
	public static Dova.JDK.java.awt.desktop.QuitStrategy valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.desktop.QuitStrategy>(ret);
	}

	[JniSignatureAttribute("()[Ljava/awt/desktop/QuitStrategy;", "private static")]
	public static JavaArray<Dova.JDK.java.awt.desktop.QuitStrategy> _values()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.desktop.QuitStrategy>>(ret);
	}
}