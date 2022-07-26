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

namespace Dova.JDK.javax.swing;

[JniSignatureAttribute("Ljavax/swing/BufferStrategyPaintManager;", "")]
public partial class BufferStrategyPaintManager
	: Dova.JDK.javax.swing.RepaintManager.PaintManager
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BufferStrategyPaintManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/BufferStrategyPaintManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOGGER", "Lsun/util/logging/PlatformLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bufferInfos", "Ljava/util/ArrayList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "painting", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "showing", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accumulatedX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accumulatedY", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accumulatedMaxX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accumulatedMaxY", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rootJ", "Ljavax/swing/JComponent;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xOffset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "yOffset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bsg", "Ljava/awt/Graphics;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bufferStrategy", "Ljava/awt/image/BufferStrategy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bufferInfo", "Ljavax/swing/BufferStrategyPaintManager$BufferInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "disposeBufferOnEnd", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Ljavax/swing/JComponent;Ljava/awt/Container;ZIIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "beginPaint", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endPaint", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBufferInfo", "(Ljava/awt/Container;)Ljavax/swing/BufferStrategyPaintManager$BufferInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fetchRoot", "(Ljavax/swing/JComponent;)Ljava/awt/Container;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accumulate", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flushAccumulatedRegion", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetAccumulated", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetDoubleBufferPerWindow", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doubleBufferingChanged0", "(Ljavax/swing/JRootPane;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doubleBufferingChanged", "(Ljavax/swing/JRootPane;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljavax/swing/JComponent;Ljavax/swing/JComponent;Ljava/awt/Graphics;IIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "show", "(Ljava/awt/Container;IIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyArea", "(Ljavax/swing/JComponent;Ljava/awt/Graphics;IIIIIIZ)V"));
	}

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static final")]
	public static Dova.JDK.sun.util.logging.PlatformLogger LOGGER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ArrayList;", "private")]
	public Dova.JDK.java.util.ArrayList bufferInfos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool painting_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool showing_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int accumulatedX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int accumulatedY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int accumulatedMaxX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int accumulatedMaxY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JComponent;", "private")]
	public Dova.JDK.javax.swing.JComponent rootJ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComponent>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int xOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int yOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Graphics;", "private")]
	public Dova.JDK.java.awt.Graphics bsg_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Graphics>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/image/BufferStrategy;", "private")]
	public Dova.JDK.java.awt.image.BufferStrategy bufferStrategy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferStrategy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/BufferStrategyPaintManager$BufferInfo;", "private")]
	public Dova.JDK.javax.swing.BufferStrategyPaintManager.BufferInfo bufferInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.BufferStrategyPaintManager.BufferInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool disposeBufferOnEnd_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BufferStrategyPaintManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public BufferStrategyPaintManager() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/BufferStrategyPaintManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljava/awt/Container;ZIIII)Z", "private")]
	public bool prepare(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.java.awt.Container arg1, bool arg2, int arg3, int arg4, int arg5, int arg6)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("()V", "protected")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "private")]
	public void dispose(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void beginPaint()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void endPaint()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)Ljavax/swing/BufferStrategyPaintManager$BufferInfo;", "private")]
	public Dova.JDK.javax.swing.BufferStrategyPaintManager.BufferInfo getBufferInfo(Dova.JDK.java.awt.Container arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.BufferStrategyPaintManager.BufferInfo>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Container;", "private")]
	public Dova.JDK.java.awt.Container fetchRoot(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Container>(ret);
	}

	[JniSignatureAttribute("(IIII)V", "private")]
	public void accumulate(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool flushAccumulatedRegion()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void resetAccumulated()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void resetDoubleBufferPerWindow()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("(Ljavax/swing/JRootPane;)V", "private")]
	public void doubleBufferingChanged0(Dova.JDK.javax.swing.JRootPane arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JRootPane;)V", "public")]
	public void doubleBufferingChanged(Dova.JDK.javax.swing.JRootPane arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/JComponent;Ljava/awt/Graphics;IIII)Z", "public")]
	public bool paint(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.JComponent arg1, Dova.JDK.java.awt.Graphics arg2, int arg3, int arg4, int arg5, int arg6)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Container;IIII)Z", "public")]
	public bool show(Dova.JDK.java.awt.Container arg0, int arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljava/awt/Graphics;IIIIIIZ)V", "public")]
	public void copyArea(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, bool arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("Ljavax/swing/BufferStrategyPaintManager$BufferInfo;", "private")]
	public partial class BufferInfo
		: Dova.JDK.java.awt.@event.ComponentAdapter
		, Dova.JDK.java.awt.@event.WindowListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BufferInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/BufferStrategyPaintManager$BufferInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "weakBS", "Ljava/lang/ref/WeakReference;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "root", "Ljava/lang/ref/WeakReference;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inSync", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contentsLostDuringExpose", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paintAllOnExpose", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/BufferStrategyPaintManager;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/BufferStrategyPaintManager;Ljava/awt/Container;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRoot", "()Ljava/awt/Container;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInSync", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPaintAllOnExpose", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPaintAllOnExpose", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setContentsLostDuringExpose", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInSync", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasBufferStrategyChanged", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContentsLostDuringExpose", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createBufferStrategy", "(Ljava/awt/Container;Z)Ljava/awt/image/BufferStrategy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createBufferStrategy", "()Ljava/awt/image/BufferStrategy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentHidden", "(Ljava/awt/event/ComponentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBufferStrategy", "(Z)Ljava/awt/image/BufferStrategy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowOpened", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowClosing", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowClosed", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowIconified", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowDeiconified", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowActivated", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowDeactivated", "(Ljava/awt/event/WindowEvent;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/ref/WeakReference;", "private")]
		public Dova.JDK.java.lang.@ref.WeakReference weakBS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.WeakReference>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/ref/WeakReference;", "private")]
		public Dova.JDK.java.lang.@ref.WeakReference root_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.WeakReference>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool inSync_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool contentsLostDuringExpose_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool paintAllOnExpose_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/BufferStrategyPaintManager;", "final")]
		public Dova.JDK.javax.swing.BufferStrategyPaintManager this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.BufferStrategyPaintManager>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BufferInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/BufferStrategyPaintManager;Ljava/awt/Container;)V", "public")]
		public BufferInfo(Dova.JDK.javax.swing.BufferStrategyPaintManager arg0, Dova.JDK.java.awt.Container arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/BufferStrategyPaintManager$BufferInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/awt/Container;", "public")]
		public Dova.JDK.java.awt.Container getRoot()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Container>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void dispose()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isInSync()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool getPaintAllOnExpose()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Z)V", "public")]
		public void setPaintAllOnExpose(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Z)V", "public")]
		public void setContentsLostDuringExpose(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Z)V", "public")]
		public void setInSync(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasBufferStrategyChanged()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool getContentsLostDuringExpose()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Container;Z)Ljava/awt/image/BufferStrategy;", "private")]
		public Dova.JDK.java.awt.image.BufferStrategy createBufferStrategy(Dova.JDK.java.awt.Container arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferStrategy>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/image/BufferStrategy;", "private")]
		public Dova.JDK.java.awt.image.BufferStrategy createBufferStrategy()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferStrategy>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public")]
		public void componentHidden(Dova.JDK.java.awt.@event.ComponentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}

		[JniSignatureAttribute("(Z)Ljava/awt/image/BufferStrategy;", "public")]
		public Dova.JDK.java.awt.image.BufferStrategy getBufferStrategy(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferStrategy>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowOpened(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowClosing(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowClosed(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowIconified(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowDeiconified(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowActivated(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowDeactivated(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		}
	}
}
