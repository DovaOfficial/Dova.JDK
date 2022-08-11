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

namespace Dova.JDK.sun.awt;

[JniSignatureAttribute("Lsun/awt/SunGraphicsCallback;", "public abstract")]
public partial class SunGraphicsCallback
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SunGraphicsCallback()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/SunGraphicsCallback;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HEAVYWEIGHTS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LIGHTWEIGHTS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TWO_PASSES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "log", "Lsun/util/logging/PlatformLogger;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "(Ljava/awt/Component;Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runOneComponent", "(Ljava/awt/Component;Ljava/awt/Rectangle;Ljava/awt/Graphics;Ljava/awt/Shape;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runComponents", "([Ljava/awt/Component;Ljava/awt/Graphics;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "constrainGraphics", "(Ljava/awt/Graphics;Ljava/awt/Rectangle;)V"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int HEAVYWEIGHTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int LIGHTWEIGHTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int TWO_PASSES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static final")]
	public static Dova.JDK.sun.util.logging.PlatformLogger log_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SunGraphicsCallback(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SunGraphicsCallback() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/SunGraphicsCallback;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;)V", "public abstract")]
	public void run(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Rectangle;Ljava/awt/Graphics;Ljava/awt/Shape;I)V", "public final")]
	public void runOneComponent(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Rectangle arg1, Dova.JDK.java.awt.Graphics arg2, Dova.JDK.java.awt.Shape arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("([Ljava/awt/Component;Ljava/awt/Graphics;I)V", "public final")]
	public void runComponents(JavaArray<Dova.JDK.java.awt.Component> arg0, Dova.JDK.java.awt.Graphics arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Rectangle;)V", "protected")]
	public void constrainGraphics(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Rectangle arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("Lsun/awt/SunGraphicsCallback$PrintHeavyweightComponentsCallback;", "public static final")]
	public partial class PrintHeavyweightComponentsCallback
		: Dova.JDK.sun.awt.SunGraphicsCallback
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PrintHeavyweightComponentsCallback()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/SunGraphicsCallback$PrintHeavyweightComponentsCallback;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/awt/SunGraphicsCallback$PrintHeavyweightComponentsCallback;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "(Ljava/awt/Component;Ljava/awt/Graphics;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "()Lsun/awt/SunGraphicsCallback$PrintHeavyweightComponentsCallback;"));
		}

		[JniSignatureAttribute("Lsun/awt/SunGraphicsCallback$PrintHeavyweightComponentsCallback;", "private static")]
		public static Dova.JDK.sun.awt.SunGraphicsCallback.PrintHeavyweightComponentsCallback instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.SunGraphicsCallback.PrintHeavyweightComponentsCallback>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PrintHeavyweightComponentsCallback(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public PrintHeavyweightComponentsCallback() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/SunGraphicsCallback$PrintHeavyweightComponentsCallback;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;)V", "public")]
		public void run(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("()Lsun/awt/SunGraphicsCallback$PrintHeavyweightComponentsCallback;", "public static")]
		public static Dova.JDK.sun.awt.SunGraphicsCallback.PrintHeavyweightComponentsCallback getInstance()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.SunGraphicsCallback.PrintHeavyweightComponentsCallback>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/awt/SunGraphicsCallback$PaintHeavyweightComponentsCallback;", "public static final")]
	public partial class PaintHeavyweightComponentsCallback
		: Dova.JDK.sun.awt.SunGraphicsCallback
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PaintHeavyweightComponentsCallback()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/SunGraphicsCallback$PaintHeavyweightComponentsCallback;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lsun/awt/SunGraphicsCallback$PaintHeavyweightComponentsCallback;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "(Ljava/awt/Component;Ljava/awt/Graphics;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "()Lsun/awt/SunGraphicsCallback$PaintHeavyweightComponentsCallback;"));
		}

		[JniSignatureAttribute("Lsun/awt/SunGraphicsCallback$PaintHeavyweightComponentsCallback;", "private static")]
		public static Dova.JDK.sun.awt.SunGraphicsCallback.PaintHeavyweightComponentsCallback instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.SunGraphicsCallback.PaintHeavyweightComponentsCallback>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PaintHeavyweightComponentsCallback(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public PaintHeavyweightComponentsCallback() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/SunGraphicsCallback$PaintHeavyweightComponentsCallback;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;)V", "public")]
		public void run(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("()Lsun/awt/SunGraphicsCallback$PaintHeavyweightComponentsCallback;", "public static")]
		public static Dova.JDK.sun.awt.SunGraphicsCallback.PaintHeavyweightComponentsCallback getInstance()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.SunGraphicsCallback.PaintHeavyweightComponentsCallback>(ret);
		}
	}
}
