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

namespace Dova.JDK.sun.awt.X11;

[JniSignatureAttribute("Lsun/awt/X11/XErrorHandler;", "public abstract")]
public partial class XErrorHandler
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XErrorHandler()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/X11/XErrorHandler;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "XErrorHandler", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "handleError", "(JLsun/awt/X11/XErrorEvent;)I"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XErrorHandler(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XErrorHandler() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/X11/XErrorHandler;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(JLsun/awt/X11/XErrorEvent;)I", "public abstract")]
	public int handleError(long arg0, Dova.JDK.sun.awt.X11.XErrorEvent arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("Lsun/awt/X11/XErrorHandler$VerifyChangePropertyHandler;", "public static")]
	public partial class VerifyChangePropertyHandler
		: Dova.JDK.sun.awt.X11.XErrorHandler.XBaseErrorHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static VerifyChangePropertyHandler()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/X11/XErrorHandler$VerifyChangePropertyHandler;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "theInstance", "Lsun/awt/X11/XErrorHandler$VerifyChangePropertyHandler;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "VerifyChangePropertyHandler", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "()Lsun/awt/X11/XErrorHandler$VerifyChangePropertyHandler;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "handleError", "(JLsun/awt/X11/XErrorEvent;)I"));
		}

		[JniSignatureAttribute("Lsun/awt/X11/XErrorHandler$VerifyChangePropertyHandler;", "private static")]
		public static Dova.JDK.sun.awt.X11.XErrorHandler.VerifyChangePropertyHandler theInstance_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XErrorHandler.VerifyChangePropertyHandler>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public VerifyChangePropertyHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public VerifyChangePropertyHandler() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/X11/XErrorHandler$VerifyChangePropertyHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lsun/awt/X11/XErrorHandler$VerifyChangePropertyHandler;", "public static")]
		public static Dova.JDK.sun.awt.X11.XErrorHandler.VerifyChangePropertyHandler getInstance()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XErrorHandler.VerifyChangePropertyHandler>(ret);
		}

		[JniSignatureAttribute("(JLsun/awt/X11/XErrorEvent;)I", "public")]
		public int handleError(long arg0, Dova.JDK.sun.awt.X11.XErrorEvent arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XErrorHandler$IgnoreBadWindowHandler;", "public static")]
	public partial class IgnoreBadWindowHandler
		: Dova.JDK.sun.awt.X11.XErrorHandler.XBaseErrorHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IgnoreBadWindowHandler()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/X11/XErrorHandler$IgnoreBadWindowHandler;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "theInstance", "Lsun/awt/X11/XErrorHandler$IgnoreBadWindowHandler;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "IgnoreBadWindowHandler", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "()Lsun/awt/X11/XErrorHandler$IgnoreBadWindowHandler;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "handleError", "(JLsun/awt/X11/XErrorEvent;)I"));
		}

		[JniSignatureAttribute("Lsun/awt/X11/XErrorHandler$IgnoreBadWindowHandler;", "private static")]
		public static Dova.JDK.sun.awt.X11.XErrorHandler.IgnoreBadWindowHandler theInstance_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XErrorHandler.IgnoreBadWindowHandler>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IgnoreBadWindowHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public IgnoreBadWindowHandler() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/X11/XErrorHandler$IgnoreBadWindowHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lsun/awt/X11/XErrorHandler$IgnoreBadWindowHandler;", "public static")]
		public static Dova.JDK.sun.awt.X11.XErrorHandler.IgnoreBadWindowHandler getInstance()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XErrorHandler.IgnoreBadWindowHandler>(ret);
		}

		[JniSignatureAttribute("(JLsun/awt/X11/XErrorEvent;)I", "public")]
		public int handleError(long arg0, Dova.JDK.sun.awt.X11.XErrorEvent arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XErrorHandler$XBaseErrorHandler;", "public static")]
	public partial class XBaseErrorHandler
		: Dova.JDK.sun.awt.X11.XErrorHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XBaseErrorHandler()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/X11/XErrorHandler$XBaseErrorHandler;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "XBaseErrorHandler", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "handleError", "(JLsun/awt/X11/XErrorEvent;)I"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XBaseErrorHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public XBaseErrorHandler() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/X11/XErrorHandler$XBaseErrorHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(JLsun/awt/X11/XErrorEvent;)I", "public")]
		public int handleError(long arg0, Dova.JDK.sun.awt.X11.XErrorEvent arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}
	}
}