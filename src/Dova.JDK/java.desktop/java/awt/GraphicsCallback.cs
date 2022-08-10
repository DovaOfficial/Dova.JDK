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

namespace Dova.JDK.java.awt;

[JniSignatureAttribute("Ljava/awt/GraphicsCallback;", "abstract")]
public partial class GraphicsCallback
	: Dova.JDK.sun.awt.SunGraphicsCallback
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GraphicsCallback()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/GraphicsCallback;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GraphicsCallback", "()V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GraphicsCallback(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public GraphicsCallback() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/GraphicsCallback;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("Ljava/awt/GraphicsCallback$PrintHeavyweightComponentsCallback;", "static final")]
	public partial class PrintHeavyweightComponentsCallback
		: Dova.JDK.java.awt.GraphicsCallback
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PrintHeavyweightComponentsCallback()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/GraphicsCallback$PrintHeavyweightComponentsCallback;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "instance", "Ljava/awt/GraphicsCallback$PrintHeavyweightComponentsCallback;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PrintHeavyweightComponentsCallback", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "run", "(Ljava/awt/Component;Ljava/awt/Graphics;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "()Ljava/awt/GraphicsCallback$PrintHeavyweightComponentsCallback;"));
		}

		[JniSignatureAttribute("Ljava/awt/GraphicsCallback$PrintHeavyweightComponentsCallback;", "private static")]
		public static Dova.JDK.java.awt.GraphicsCallback.PrintHeavyweightComponentsCallback instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsCallback.PrintHeavyweightComponentsCallback>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PrintHeavyweightComponentsCallback(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public PrintHeavyweightComponentsCallback() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/GraphicsCallback$PrintHeavyweightComponentsCallback;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;)V", "public")]
		public void run(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/awt/GraphicsCallback$PrintHeavyweightComponentsCallback;", "static")]
		public static Dova.JDK.java.awt.GraphicsCallback.PrintHeavyweightComponentsCallback getInstance()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsCallback.PrintHeavyweightComponentsCallback>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/awt/GraphicsCallback$PaintHeavyweightComponentsCallback;", "static final")]
	public partial class PaintHeavyweightComponentsCallback
		: Dova.JDK.java.awt.GraphicsCallback
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PaintHeavyweightComponentsCallback()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/GraphicsCallback$PaintHeavyweightComponentsCallback;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "instance", "Ljava/awt/GraphicsCallback$PaintHeavyweightComponentsCallback;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PaintHeavyweightComponentsCallback", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "run", "(Ljava/awt/Component;Ljava/awt/Graphics;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "()Ljava/awt/GraphicsCallback$PaintHeavyweightComponentsCallback;"));
		}

		[JniSignatureAttribute("Ljava/awt/GraphicsCallback$PaintHeavyweightComponentsCallback;", "private static")]
		public static Dova.JDK.java.awt.GraphicsCallback.PaintHeavyweightComponentsCallback instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsCallback.PaintHeavyweightComponentsCallback>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PaintHeavyweightComponentsCallback(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public PaintHeavyweightComponentsCallback() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/GraphicsCallback$PaintHeavyweightComponentsCallback;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;)V", "public")]
		public void run(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/awt/GraphicsCallback$PaintHeavyweightComponentsCallback;", "static")]
		public static Dova.JDK.java.awt.GraphicsCallback.PaintHeavyweightComponentsCallback getInstance()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsCallback.PaintHeavyweightComponentsCallback>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/awt/GraphicsCallback$PeerPrintCallback;", "static final")]
	public partial class PeerPrintCallback
		: Dova.JDK.java.awt.GraphicsCallback
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PeerPrintCallback()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/GraphicsCallback$PeerPrintCallback;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "instance", "Ljava/awt/GraphicsCallback$PeerPrintCallback;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PeerPrintCallback", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "run", "(Ljava/awt/Component;Ljava/awt/Graphics;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "()Ljava/awt/GraphicsCallback$PeerPrintCallback;"));
		}

		[JniSignatureAttribute("Ljava/awt/GraphicsCallback$PeerPrintCallback;", "private static")]
		public static Dova.JDK.java.awt.GraphicsCallback.PeerPrintCallback instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsCallback.PeerPrintCallback>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PeerPrintCallback(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public PeerPrintCallback() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/GraphicsCallback$PeerPrintCallback;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;)V", "public")]
		public void run(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/awt/GraphicsCallback$PeerPrintCallback;", "static")]
		public static Dova.JDK.java.awt.GraphicsCallback.PeerPrintCallback getInstance()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsCallback.PeerPrintCallback>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/awt/GraphicsCallback$PeerPaintCallback;", "static final")]
	public partial class PeerPaintCallback
		: Dova.JDK.java.awt.GraphicsCallback
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PeerPaintCallback()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/GraphicsCallback$PeerPaintCallback;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "instance", "Ljava/awt/GraphicsCallback$PeerPaintCallback;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PeerPaintCallback", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "run", "(Ljava/awt/Component;Ljava/awt/Graphics;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "()Ljava/awt/GraphicsCallback$PeerPaintCallback;"));
		}

		[JniSignatureAttribute("Ljava/awt/GraphicsCallback$PeerPaintCallback;", "private static")]
		public static Dova.JDK.java.awt.GraphicsCallback.PeerPaintCallback instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsCallback.PeerPaintCallback>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PeerPaintCallback(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public PeerPaintCallback() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/GraphicsCallback$PeerPaintCallback;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;)V", "public")]
		public void run(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/awt/GraphicsCallback$PeerPaintCallback;", "static")]
		public static Dova.JDK.java.awt.GraphicsCallback.PeerPaintCallback getInstance()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsCallback.PeerPaintCallback>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/awt/GraphicsCallback$PrintAllCallback;", "static final")]
	public partial class PrintAllCallback
		: Dova.JDK.java.awt.GraphicsCallback
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PrintAllCallback()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/GraphicsCallback$PrintAllCallback;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "instance", "Ljava/awt/GraphicsCallback$PrintAllCallback;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PrintAllCallback", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "run", "(Ljava/awt/Component;Ljava/awt/Graphics;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "()Ljava/awt/GraphicsCallback$PrintAllCallback;"));
		}

		[JniSignatureAttribute("Ljava/awt/GraphicsCallback$PrintAllCallback;", "private static")]
		public static Dova.JDK.java.awt.GraphicsCallback.PrintAllCallback instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsCallback.PrintAllCallback>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PrintAllCallback(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public PrintAllCallback() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/GraphicsCallback$PrintAllCallback;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;)V", "public")]
		public void run(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/awt/GraphicsCallback$PrintAllCallback;", "static")]
		public static Dova.JDK.java.awt.GraphicsCallback.PrintAllCallback getInstance()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsCallback.PrintAllCallback>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/awt/GraphicsCallback$PaintAllCallback;", "static final")]
	public partial class PaintAllCallback
		: Dova.JDK.java.awt.GraphicsCallback
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PaintAllCallback()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/GraphicsCallback$PaintAllCallback;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "instance", "Ljava/awt/GraphicsCallback$PaintAllCallback;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PaintAllCallback", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "run", "(Ljava/awt/Component;Ljava/awt/Graphics;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "()Ljava/awt/GraphicsCallback$PaintAllCallback;"));
		}

		[JniSignatureAttribute("Ljava/awt/GraphicsCallback$PaintAllCallback;", "private static")]
		public static Dova.JDK.java.awt.GraphicsCallback.PaintAllCallback instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsCallback.PaintAllCallback>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PaintAllCallback(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public PaintAllCallback() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/GraphicsCallback$PaintAllCallback;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;)V", "public")]
		public void run(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/awt/GraphicsCallback$PaintAllCallback;", "static")]
		public static Dova.JDK.java.awt.GraphicsCallback.PaintAllCallback getInstance()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsCallback.PaintAllCallback>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/awt/GraphicsCallback$PrintCallback;", "static final")]
	public partial class PrintCallback
		: Dova.JDK.java.awt.GraphicsCallback
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PrintCallback()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/GraphicsCallback$PrintCallback;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "instance", "Ljava/awt/GraphicsCallback$PrintCallback;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PrintCallback", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "run", "(Ljava/awt/Component;Ljava/awt/Graphics;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "()Ljava/awt/GraphicsCallback$PrintCallback;"));
		}

		[JniSignatureAttribute("Ljava/awt/GraphicsCallback$PrintCallback;", "private static")]
		public static Dova.JDK.java.awt.GraphicsCallback.PrintCallback instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsCallback.PrintCallback>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PrintCallback(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public PrintCallback() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/GraphicsCallback$PrintCallback;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;)V", "public")]
		public void run(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/awt/GraphicsCallback$PrintCallback;", "static")]
		public static Dova.JDK.java.awt.GraphicsCallback.PrintCallback getInstance()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsCallback.PrintCallback>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/awt/GraphicsCallback$PaintCallback;", "static final")]
	public partial class PaintCallback
		: Dova.JDK.java.awt.GraphicsCallback
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PaintCallback()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/GraphicsCallback$PaintCallback;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "instance", "Ljava/awt/GraphicsCallback$PaintCallback;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PaintCallback", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "run", "(Ljava/awt/Component;Ljava/awt/Graphics;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "()Ljava/awt/GraphicsCallback$PaintCallback;"));
		}

		[JniSignatureAttribute("Ljava/awt/GraphicsCallback$PaintCallback;", "private static")]
		public static Dova.JDK.java.awt.GraphicsCallback.PaintCallback instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsCallback.PaintCallback>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PaintCallback(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public PaintCallback() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/GraphicsCallback$PaintCallback;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;)V", "public")]
		public void run(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/awt/GraphicsCallback$PaintCallback;", "static")]
		public static Dova.JDK.java.awt.GraphicsCallback.PaintCallback getInstance()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsCallback.PaintCallback>(ret);
		}
	}
}
