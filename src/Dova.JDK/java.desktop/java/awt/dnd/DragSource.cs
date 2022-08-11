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

namespace Dova.JDK.java.awt.dnd;

[JniSignatureAttribute("Ljava/awt/dnd/DragSource;", "public")]
public partial class DragSource
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DragSource()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/dnd/DragSource;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DefaultCopyDrop", "Ljava/awt/Cursor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DefaultMoveDrop", "Ljava/awt/Cursor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DefaultLinkDrop", "Ljava/awt/Cursor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DefaultCopyNoDrop", "Ljava/awt/Cursor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DefaultMoveNoDrop", "Ljava/awt/Cursor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DefaultLinkNoDrop", "Ljava/awt/Cursor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "dflt", "Ljava/awt/dnd/DragSource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "dragSourceListenerK", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "dragSourceMotionListenerK", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flavorMap", "Ljava/awt/datatransfer/FlavorMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listener", "Ljava/awt/dnd/DragSourceListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "motionListener", "Ljava/awt/dnd/DragSourceMotionListener;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "load", "(Ljava/lang/String;)Ljava/awt/Cursor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDragGestureRecognizer", "(Ljava/lang/Class;Ljava/awt/Component;ILjava/awt/dnd/DragGestureListener;)Ljava/awt/dnd/DragGestureRecognizer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startDrag", "(Ljava/awt/dnd/DragGestureEvent;Ljava/awt/Cursor;Ljava/awt/Image;Ljava/awt/Point;Ljava/awt/datatransfer/Transferable;Ljava/awt/dnd/DragSourceListener;Ljava/awt/datatransfer/FlavorMap;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startDrag", "(Ljava/awt/dnd/DragGestureEvent;Ljava/awt/Cursor;Ljava/awt/datatransfer/Transferable;Ljava/awt/dnd/DragSourceListener;Ljava/awt/datatransfer/FlavorMap;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startDrag", "(Ljava/awt/dnd/DragGestureEvent;Ljava/awt/Cursor;Ljava/awt/Image;Ljava/awt/Point;Ljava/awt/datatransfer/Transferable;Ljava/awt/dnd/DragSourceListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startDrag", "(Ljava/awt/dnd/DragGestureEvent;Ljava/awt/Cursor;Ljava/awt/datatransfer/Transferable;Ljava/awt/dnd/DragSourceListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDragSourceContext", "(Ljava/awt/dnd/DragGestureEvent;Ljava/awt/Cursor;Ljava/awt/Image;Ljava/awt/Point;Ljava/awt/datatransfer/Transferable;Ljava/awt/dnd/DragSourceListener;)Ljava/awt/dnd/DragSourceContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDragSourceListener", "(Ljava/awt/dnd/DragSourceListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDragSourceMotionListener", "(Ljava/awt/dnd/DragSourceMotionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefaultDragSource", "()Ljava/awt/dnd/DragSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDragImageSupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDefaultDragGestureRecognizer", "(Ljava/awt/Component;ILjava/awt/dnd/DragGestureListener;)Ljava/awt/dnd/DragGestureRecognizer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeDragSourceListener", "(Ljava/awt/dnd/DragSourceListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDragSourceListeners", "()[Ljava/awt/dnd/DragSourceListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeDragSourceMotionListener", "(Ljava/awt/dnd/DragSourceMotionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDragSourceMotionListeners", "()[Ljava/awt/dnd/DragSourceMotionListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processDragEnter", "(Ljava/awt/dnd/DragSourceDragEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processDragOver", "(Ljava/awt/dnd/DragSourceDragEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processDropActionChanged", "(Ljava/awt/dnd/DragSourceDragEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processDragExit", "(Ljava/awt/dnd/DragSourceEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processDragDropEnd", "(Ljava/awt/dnd/DragSourceDropEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processDragMouseMoved", "(Ljava/awt/dnd/DragSourceDragEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDragThreshold", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFlavorMap", "()Ljava/awt/datatransfer/FlavorMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getListeners", "(Ljava/lang/Class;)[Ljava/util/EventListener;"));
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

	[JniSignatureAttribute("Ljava/awt/Cursor;", "public static final")]
	public static Dova.JDK.java.awt.Cursor DefaultCopyDrop_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Cursor;", "public static final")]
	public static Dova.JDK.java.awt.Cursor DefaultMoveDrop_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Cursor;", "public static final")]
	public static Dova.JDK.java.awt.Cursor DefaultLinkDrop_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Cursor;", "public static final")]
	public static Dova.JDK.java.awt.Cursor DefaultCopyNoDrop_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Cursor;", "public static final")]
	public static Dova.JDK.java.awt.Cursor DefaultMoveNoDrop_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Cursor;", "public static final")]
	public static Dova.JDK.java.awt.Cursor DefaultLinkNoDrop_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/dnd/DragSource;", "private static final")]
	public static Dova.JDK.java.awt.dnd.DragSource dflt_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.dnd.DragSource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String dragSourceListenerK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String dragSourceMotionListenerK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/datatransfer/FlavorMap;", "private transient")]
	public Dova.JDK.java.awt.datatransfer.FlavorMap flavorMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.datatransfer.FlavorMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/dnd/DragSourceListener;", "private transient")]
	public Dova.JDK.java.awt.dnd.DragSourceListener listener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.dnd.DragSourceListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/dnd/DragSourceMotionListener;", "private transient")]
	public Dova.JDK.java.awt.dnd.DragSourceMotionListener motionListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.dnd.DragSourceMotionListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DragSource(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DragSource() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/dnd/DragSource;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/awt/Cursor;", "private static")]
	public static Dova.JDK.java.awt.Cursor load(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/awt/Component;ILjava/awt/dnd/DragGestureListener;)Ljava/awt/dnd/DragGestureRecognizer;", "public")]
	public Dova.JDK.java.lang.Object createDragGestureRecognizer(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.awt.Component arg1, int arg2, Dova.JDK.java.awt.dnd.DragGestureListener arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragGestureEvent;Ljava/awt/Cursor;Ljava/awt/Image;Ljava/awt/Point;Ljava/awt/datatransfer/Transferable;Ljava/awt/dnd/DragSourceListener;Ljava/awt/datatransfer/FlavorMap;)V", "public")]
	public void startDrag(Dova.JDK.java.awt.dnd.DragGestureEvent arg0, Dova.JDK.java.awt.Cursor arg1, Dova.JDK.java.awt.Image arg2, Dova.JDK.java.awt.Point arg3, Dova.JDK.java.awt.datatransfer.Transferable arg4, Dova.JDK.java.awt.dnd.DragSourceListener arg5, Dova.JDK.java.awt.datatransfer.FlavorMap arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragGestureEvent;Ljava/awt/Cursor;Ljava/awt/datatransfer/Transferable;Ljava/awt/dnd/DragSourceListener;Ljava/awt/datatransfer/FlavorMap;)V", "public")]
	public void startDrag(Dova.JDK.java.awt.dnd.DragGestureEvent arg0, Dova.JDK.java.awt.Cursor arg1, Dova.JDK.java.awt.datatransfer.Transferable arg2, Dova.JDK.java.awt.dnd.DragSourceListener arg3, Dova.JDK.java.awt.datatransfer.FlavorMap arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragGestureEvent;Ljava/awt/Cursor;Ljava/awt/Image;Ljava/awt/Point;Ljava/awt/datatransfer/Transferable;Ljava/awt/dnd/DragSourceListener;)V", "public")]
	public void startDrag(Dova.JDK.java.awt.dnd.DragGestureEvent arg0, Dova.JDK.java.awt.Cursor arg1, Dova.JDK.java.awt.Image arg2, Dova.JDK.java.awt.Point arg3, Dova.JDK.java.awt.datatransfer.Transferable arg4, Dova.JDK.java.awt.dnd.DragSourceListener arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragGestureEvent;Ljava/awt/Cursor;Ljava/awt/datatransfer/Transferable;Ljava/awt/dnd/DragSourceListener;)V", "public")]
	public void startDrag(Dova.JDK.java.awt.dnd.DragGestureEvent arg0, Dova.JDK.java.awt.Cursor arg1, Dova.JDK.java.awt.datatransfer.Transferable arg2, Dova.JDK.java.awt.dnd.DragSourceListener arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragGestureEvent;Ljava/awt/Cursor;Ljava/awt/Image;Ljava/awt/Point;Ljava/awt/datatransfer/Transferable;Ljava/awt/dnd/DragSourceListener;)Ljava/awt/dnd/DragSourceContext;", "protected")]
	public Dova.JDK.java.awt.dnd.DragSourceContext createDragSourceContext(Dova.JDK.java.awt.dnd.DragGestureEvent arg0, Dova.JDK.java.awt.Cursor arg1, Dova.JDK.java.awt.Image arg2, Dova.JDK.java.awt.Point arg3, Dova.JDK.java.awt.datatransfer.Transferable arg4, Dova.JDK.java.awt.dnd.DragSourceListener arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.dnd.DragSourceContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceListener;)V", "public")]
	public void addDragSourceListener(Dova.JDK.java.awt.dnd.DragSourceListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceMotionListener;)V", "public")]
	public void addDragSourceMotionListener(Dova.JDK.java.awt.dnd.DragSourceMotionListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/dnd/DragSource;", "public static")]
	public static Dova.JDK.java.awt.dnd.DragSource getDefaultDragSource()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.dnd.DragSource>(ret);
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isDragImageSupported()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Component;ILjava/awt/dnd/DragGestureListener;)Ljava/awt/dnd/DragGestureRecognizer;", "public")]
	public Dova.JDK.java.awt.dnd.DragGestureRecognizer createDefaultDragGestureRecognizer(Dova.JDK.java.awt.Component arg0, int arg1, Dova.JDK.java.awt.dnd.DragGestureListener arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.dnd.DragGestureRecognizer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceListener;)V", "public")]
	public void removeDragSourceListener(Dova.JDK.java.awt.dnd.DragSourceListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("()[Ljava/awt/dnd/DragSourceListener;", "public")]
	public JavaArray<Dova.JDK.java.awt.dnd.DragSourceListener> getDragSourceListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.dnd.DragSourceListener>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceMotionListener;)V", "public")]
	public void removeDragSourceMotionListener(Dova.JDK.java.awt.dnd.DragSourceMotionListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()[Ljava/awt/dnd/DragSourceMotionListener;", "public")]
	public JavaArray<Dova.JDK.java.awt.dnd.DragSourceMotionListener> getDragSourceMotionListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.dnd.DragSourceMotionListener>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceDragEvent;)V", "")]
	public void processDragEnter(Dova.JDK.java.awt.dnd.DragSourceDragEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceDragEvent;)V", "")]
	public void processDragOver(Dova.JDK.java.awt.dnd.DragSourceDragEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceDragEvent;)V", "")]
	public void processDropActionChanged(Dova.JDK.java.awt.dnd.DragSourceDragEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceEvent;)V", "")]
	public void processDragExit(Dova.JDK.java.awt.dnd.DragSourceEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceDropEvent;)V", "")]
	public void processDragDropEnd(Dova.JDK.java.awt.dnd.DragSourceDropEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceDragEvent;)V", "")]
	public void processDragMouseMoved(Dova.JDK.java.awt.dnd.DragSourceDragEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("()I", "public static")]
	public static int getDragThreshold()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/datatransfer/FlavorMap;", "public")]
	public Dova.JDK.java.awt.datatransfer.FlavorMap getFlavorMap()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.datatransfer.FlavorMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)[Ljava/util/EventListener;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> getListeners(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}
}
