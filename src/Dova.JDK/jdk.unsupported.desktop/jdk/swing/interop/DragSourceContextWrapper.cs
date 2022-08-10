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

namespace Dova.JDK.jdk.swing.interop;

[JniSignatureAttribute("Ljdk/swing/interop/DragSourceContextWrapper;", "public abstract")]
public partial class DragSourceContextWrapper
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DragSourceContextWrapper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/swing/interop/DragSourceContextWrapper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "dsp", "Ljdk/swing/interop/DragSourceContextWrapper$DragSourceContextPeerProxy;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DragSourceContextWrapper", "(Ljava/awt/dnd/DragGestureEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setNativeCursor", "(Ljava/awt/Cursor;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "startDrag", "(Ljava/awt/datatransfer/Transferable;[JLjava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "startSecondaryEventLoop", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "convertModifiersToDropAction", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "quitSecondaryEventLoop", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dragDropFinished", "(ZIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDragSourceContext", "()Ljava/awt/dnd/DragSourceContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPeer", "()Ljava/awt/dnd/peer/DragSourceContextPeer;"));
	}

	[JniSignatureAttribute("Ljdk/swing/interop/DragSourceContextWrapper$DragSourceContextPeerProxy;", "private")]
	public Dova.JDK.jdk.swing.interop.DragSourceContextWrapper.DragSourceContextPeerProxy dsp_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.swing.interop.DragSourceContextWrapper.DragSourceContextPeerProxy>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DragSourceContextWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragGestureEvent;)V", "public")]
	public DragSourceContextWrapper(Dova.JDK.java.awt.dnd.DragGestureEvent arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/swing/interop/DragSourceContextWrapper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Cursor;I)V", "protected abstract")]
	public void setNativeCursor(Dova.JDK.java.awt.Cursor arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/datatransfer/Transferable;[JLjava/util/Map;)V", "protected abstract")]
	public void startDrag(Dova.JDK.java.awt.datatransfer.Transferable arg0, JavaArray<long> arg1, Dova.JDK.java.util.Map arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	public void startSecondaryEventLoop()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(II)I", "public static")]
	public static int convertModifiersToDropAction(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "public abstract")]
	public void quitSecondaryEventLoop()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(ZIII)V", "public")]
	public void dragDropFinished(bool arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Ljava/awt/dnd/DragSourceContext;", "public")]
	public Dova.JDK.java.awt.dnd.DragSourceContext getDragSourceContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.dnd.DragSourceContext>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/dnd/peer/DragSourceContextPeer;", "")]
	public Dova.JDK.java.awt.dnd.peer.DragSourceContextPeer getPeer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.dnd.peer.DragSourceContextPeer>(ret);
	}

	[JniSignatureAttribute("Ljdk/swing/interop/DragSourceContextWrapper$DragSourceContextPeerProxy;", "private")]
	public partial class DragSourceContextPeerProxy
		: Dova.JDK.sun.awt.dnd.SunDragSourceContextPeer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DragSourceContextPeerProxy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/swing/interop/DragSourceContextWrapper$DragSourceContextPeerProxy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljdk/swing/interop/DragSourceContextWrapper;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DragSourceContextPeerProxy", "(Ljdk/swing/interop/DragSourceContextWrapper;Ljava/awt/dnd/DragGestureEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDragSourceContextCall", "()Ljava/awt/dnd/DragSourceContext;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setNativeCursor", "(JLjava/awt/Cursor;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "startDrag", "(Ljava/awt/datatransfer/Transferable;[JLjava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "startSecondaryEventLoop", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dragDropFinishedCall", "(ZIII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "quitSecondaryEventLoop", "()V"));
		}

		[JniSignatureAttribute("Ljdk/swing/interop/DragSourceContextWrapper;", "final")]
		public Dova.JDK.jdk.swing.interop.DragSourceContextWrapper this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.swing.interop.DragSourceContextWrapper>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DragSourceContextPeerProxy(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/swing/interop/DragSourceContextWrapper;Ljava/awt/dnd/DragGestureEvent;)V", "public")]
		public DragSourceContextPeerProxy(Dova.JDK.jdk.swing.interop.DragSourceContextWrapper arg0, Dova.JDK.java.awt.dnd.DragGestureEvent arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/swing/interop/DragSourceContextWrapper$DragSourceContextPeerProxy;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/awt/dnd/DragSourceContext;", "protected")]
		public Dova.JDK.java.awt.dnd.DragSourceContext getDragSourceContextCall()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.dnd.DragSourceContext>(ret);
		}

		[JniSignatureAttribute("(JLjava/awt/Cursor;I)V", "protected")]
		public void setNativeCursor(long arg0, Dova.JDK.java.awt.Cursor arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/awt/datatransfer/Transferable;[JLjava/util/Map;)V", "protected")]
		public void startDrag(Dova.JDK.java.awt.datatransfer.Transferable arg0, JavaArray<long> arg1, Dova.JDK.java.util.Map arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()V", "public")]
		public void startSecondaryEventLoop()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(ZIII)V", "protected")]
		public void dragDropFinishedCall(bool arg0, int arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("()V", "public")]
		public void quitSecondaryEventLoop()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}
	}
}
