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

namespace Dova.JDK.javax.swing.text;

[JniSignatureAttribute("Ljavax/swing/text/DefaultCaret;", "public")]
public partial class DefaultCaret
	: Dova.JDK.java.awt.Rectangle
	, Dova.JDK.javax.swing.text.Caret
	, Dova.JDK.java.awt.@event.FocusListener
	, Dova.JDK.java.awt.@event.MouseListener
	, Dova.JDK.java.awt.@event.MouseMotionListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DefaultCaret()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultCaret;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UPDATE_WHEN_ON_EDT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEVER_UPDATE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALWAYS_UPDATE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listenerList", "Ljavax/swing/event/EventListenerList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "changeEvent", "Ljavax/swing/event/ChangeEvent;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "component", "Ljavax/swing/text/JTextComponent;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "updatePolicy", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visible", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "active", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dot", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mark", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selectionTag", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selectionVisible", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flasher", "Ljavax/swing/Timer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "magicCaretPosition", "Ljava/awt/Point;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dotBias", "Ljavax/swing/text/Position$Bias;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "markBias", "Ljavax/swing/text/Position$Bias;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dotLTR", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "markLTR", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handler", "Ljavax/swing/text/DefaultCaret$Handler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flagXPoints", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flagYPoints", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filterBypass", "Ljavax/swing/text/NavigationFilter$FilterBypass;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "selectWord", "Ljavax/swing/Action;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "selectLine", "Ljavax/swing/Action;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ownsSelection", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "forceCaretPositionChange", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shouldHandleRelease", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selectedWordEvent", "Ljava/awt/event/MouseEvent;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "caretWidth", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "aspectRatio", "F"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isActive", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDot", "(ILjavax/swing/text/Position$Bias;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDot", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moveDot", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moveDot", "(ILjavax/swing/text/Position$Bias;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMark", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDot", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMarkBias", "()Ljavax/swing/text/Position$Bias;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDotBias", "()Ljavax/swing/text/Position$Bias;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlinkRate", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBlinkRate", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSelectionVisible", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectionVisible", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMagicCaretPosition", "(Ljava/awt/Point;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMagicCaretPosition", "()Ljava/awt/Point;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCaretWidth", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateSystemSelection", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectWord", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustCaret", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustFocus", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustCaretAndFocus", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moveCaret", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "positionCaret", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "_contains", "(IIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "damage", "(Ljava/awt/Rectangle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectionPainter", "()Ljavax/swing/text/Highlighter$HighlightPainter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFilterBypass", "()Ljavax/swing/text/NavigationFilter$FilterBypass;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleMoveDot", "(ILjavax/swing/text/Position$Bias;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeCaretPosition", "(ILjavax/swing/text/Position$Bias;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleSetDot", "(ILjavax/swing/text/Position$Bias;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPositionLTR", "(ILjavax/swing/text/Position$Bias;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustVisibility", "(Ljava/awt/Rectangle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClipboardOwner", "()Ljava/awt/datatransfer/ClipboardOwner;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setUpdatePolicy", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpdatePolicy", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDotLeftToRight", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMarkLeftToRight", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "guessBiasForOffset", "(ILjavax/swing/text/Position$Bias;Z)Ljavax/swing/text/Position$Bias;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "repaintNewCaret", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureValidPosition", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVisible", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addChangeListener", "(Ljavax/swing/event/ChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeChangeListener", "(Ljavax/swing/event/ChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChangeListeners", "()[Ljavax/swing/event/ChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireStateChanged", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "repaint", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusGained", "(Ljava/awt/event/FocusEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusLost", "(Ljava/awt/event/FocusEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVisible", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getListeners", "(Ljava/lang/Class;)[Ljava/util/EventListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mousePressed", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseReleased", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseClicked", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseExited", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseEntered", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseMoved", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseDragged", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponent", "()Ljavax/swing/text/JTextComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "install", "(Ljavax/swing/text/JTextComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deinstall", "(Ljavax/swing/text/JTextComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSystemSelection", "()Ljava/awt/datatransfer/Clipboard;"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int UPDATE_WHEN_ON_EDT_Property
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
	public static int NEVER_UPDATE_Property
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
	public static int ALWAYS_UPDATE_Property
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

	[JniSignatureAttribute("Ljavax/swing/event/EventListenerList;", "protected")]
	public Dova.JDK.javax.swing.@event.EventListenerList listenerList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.EventListenerList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/event/ChangeEvent;", "protected transient")]
	public Dova.JDK.javax.swing.@event.ChangeEvent changeEvent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.ChangeEvent>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/JTextComponent;", "")]
	public Dova.JDK.javax.swing.text.JTextComponent component_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.JTextComponent>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int updatePolicy_Property
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

	[JniSignatureAttribute("Z", "")]
	public bool visible_Property
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

	[JniSignatureAttribute("Z", "")]
	public bool active_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int dot_Property
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

	[JniSignatureAttribute("I", "")]
	public int mark_Property
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

	[JniSignatureAttribute("Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object selectionTag_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool selectionVisible_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/Timer;", "")]
	public Dova.JDK.javax.swing.Timer flasher_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Timer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Point;", "")]
	public Dova.JDK.java.awt.Point magicCaretPosition_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/Position$Bias;", "transient")]
	public Dova.JDK.javax.swing.text.Position.Bias dotBias_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Position.Bias>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/Position$Bias;", "transient")]
	public Dova.JDK.javax.swing.text.Position.Bias markBias_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Position.Bias>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool dotLTR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool markLTR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultCaret$Handler;", "transient")]
	public Dova.JDK.javax.swing.text.DefaultCaret.Handler handler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.DefaultCaret.Handler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private transient")]
	public JavaArray<int> flagXPoints_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private transient")]
	public JavaArray<int> flagYPoints_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/NavigationFilter$FilterBypass;", "private transient")]
	public Dova.JDK.javax.swing.text.NavigationFilter.FilterBypass filterBypass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.NavigationFilter.FilterBypass>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/Action;", "private static transient")]
	public static Dova.JDK.javax.swing.Action selectWord_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Action>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/Action;", "private static transient")]
	public static Dova.JDK.javax.swing.Action selectLine_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Action>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool ownsSelection_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool forceCaretPositionChange_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("Z", "private transient")]
	public bool shouldHandleRelease_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/MouseEvent;", "private transient")]
	public Dova.JDK.java.awt.@event.MouseEvent selectedWordEvent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseEvent>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int caretWidth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float aspectRatio_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DefaultCaret(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DefaultCaret() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultCaret;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isActive()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(ILjavax/swing/text/Position$Bias;)V", "public")]
	public void setDot(int arg0, Dova.JDK.javax.swing.text.Position.Bias arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setDot(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void moveDot(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(ILjavax/swing/text/Position$Bias;)V", "public")]
	public void moveDot(int arg0, Dova.JDK.javax.swing.text.Position.Bias arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMark()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDot()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/text/Position$Bias;", "public")]
	public Dova.JDK.javax.swing.text.Position.Bias getMarkBias()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Position.Bias>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/Position$Bias;", "public")]
	public Dova.JDK.javax.swing.text.Position.Bias getDotBias()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Position.Bias>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getBlinkRate()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setBlinkRate(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isSelectionVisible()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setSelectionVisible(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Point;)V", "public")]
	public void setMagicCaretPosition(Dova.JDK.java.awt.Point arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Point;", "public")]
	public Dova.JDK.java.awt.Point getMagicCaretPosition()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
	}

	[JniSignatureAttribute("(I)I", "")]
	public int getCaretWidth(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void updateSystemSelection()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20]);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "private")]
	public void selectWord(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "private")]
	public void adjustCaret(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Z)V", "private")]
	public void adjustFocus(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "")]
	public void adjustCaretAndFocus(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "protected")]
	public void moveCaret(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "protected")]
	public void positionCaret(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(IIII)Z", "private")]
	public bool _contains(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)V", "protected synchronized")]
	public void damage(Dova.JDK.java.awt.Rectangle arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/Highlighter$HighlightPainter;", "protected")]
	public Dova.JDK.javax.swing.text.Highlighter.HighlightPainter getSelectionPainter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Highlighter.HighlightPainter>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/NavigationFilter$FilterBypass;", "private")]
	public Dova.JDK.javax.swing.text.NavigationFilter.FilterBypass getFilterBypass()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.NavigationFilter.FilterBypass>(ret);
	}

	[JniSignatureAttribute("(ILjavax/swing/text/Position$Bias;)V", "")]
	public void handleMoveDot(int arg0, Dova.JDK.javax.swing.text.Position.Bias arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjavax/swing/text/Position$Bias;)V", "")]
	public void changeCaretPosition(int arg0, Dova.JDK.javax.swing.text.Position.Bias arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjavax/swing/text/Position$Bias;)V", "")]
	public void handleSetDot(int arg0, Dova.JDK.javax.swing.text.Position.Bias arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjavax/swing/text/Position$Bias;)Z", "")]
	public bool isPositionLTR(int arg0, Dova.JDK.javax.swing.text.Position.Bias arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)V", "protected")]
	public void adjustVisibility(Dova.JDK.java.awt.Rectangle arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/datatransfer/ClipboardOwner;", "private")]
	public Dova.JDK.java.awt.datatransfer.ClipboardOwner getClipboardOwner()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.datatransfer.ClipboardOwner>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setUpdatePolicy(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getUpdatePolicy()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[38]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isDotLeftToRight()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isMarkLeftToRight()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[40]);
		return ret;
	}

	[JniSignatureAttribute("(ILjavax/swing/text/Position$Bias;Z)Ljavax/swing/text/Position$Bias;", "")]
	public Dova.JDK.javax.swing.text.Position.Bias guessBiasForOffset(int arg0, Dova.JDK.javax.swing.text.Position.Bias arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Position.Bias>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void repaintNewCaret()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void ensureValidPosition()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isVisible()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[44]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ChangeListener;)V", "public")]
	public void addChangeListener(Dova.JDK.javax.swing.@event.ChangeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ChangeListener;)V", "public")]
	public void removeChangeListener(Dova.JDK.javax.swing.@event.ChangeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("()[Ljavax/swing/event/ChangeListener;", "public")]
	public JavaArray<Dova.JDK.javax.swing.@event.ChangeListener> getChangeListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.@event.ChangeListener>>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void fireStateChanged()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48]);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
	public void paint(Dova.JDK.java.awt.Graphics arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
	}

	[JniSignatureAttribute("()V", "protected final synchronized")]
	public void repaint()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50]);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
	public void focusGained(Dova.JDK.java.awt.@event.FocusEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
	public void focusLost(Dova.JDK.java.awt.@event.FocusEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setVisible(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)[Ljava/util/EventListener;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> getListeners(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
	public void mousePressed(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
	public void mouseReleased(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
	public void mouseClicked(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
	public void mouseExited(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
	public void mouseEntered(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
	public void mouseMoved(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
	public void mouseDragged(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/JTextComponent;", "protected final")]
	public Dova.JDK.javax.swing.text.JTextComponent getComponent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.JTextComponent>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;)V", "public")]
	public void install(Dova.JDK.javax.swing.text.JTextComponent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;)V", "public")]
	public void deinstall(Dova.JDK.javax.swing.text.JTextComponent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/datatransfer/Clipboard;", "private")]
	public Dova.JDK.java.awt.datatransfer.Clipboard getSystemSelection()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.datatransfer.Clipboard>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultCaret$Handler;", "")]
	public partial class Handler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.beans.PropertyChangeListener
		, Dova.JDK.javax.swing.@event.DocumentListener
		, Dova.JDK.java.awt.@event.ActionListener
		, Dova.JDK.java.awt.datatransfer.ClipboardOwner
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Handler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultCaret$Handler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/DefaultCaret;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/DefaultCaret;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertUpdate", "(Ljavax/swing/event/DocumentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeUpdate", "(Ljavax/swing/event/DocumentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changedUpdate", "(Ljavax/swing/event/DocumentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lostOwnership", "(Ljava/awt/datatransfer/Clipboard;Ljava/awt/datatransfer/Transferable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/DefaultCaret;", "final")]
		public Dova.JDK.javax.swing.text.DefaultCaret this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.DefaultCaret>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Handler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/DefaultCaret;)V", "")]
		public Handler(Dova.JDK.javax.swing.text.DefaultCaret arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultCaret$Handler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;)V", "public")]
		public void insertUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;)V", "public")]
		public void removeUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;)V", "public")]
		public void changedUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/datatransfer/Clipboard;Ljava/awt/datatransfer/Transferable;)V", "public")]
		public void lostOwnership(Dova.JDK.java.awt.datatransfer.Clipboard arg0, Dova.JDK.java.awt.datatransfer.Transferable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
		public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultCaret$SafeScroller;", "")]
	public partial class SafeScroller
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Runnable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SafeScroller()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultCaret$SafeScroller;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "r", "Ljava/awt/Rectangle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/DefaultCaret;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/DefaultCaret;Ljava/awt/Rectangle;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
		}

		[JniSignatureAttribute("Ljava/awt/Rectangle;", "")]
		public Dova.JDK.java.awt.Rectangle r_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/DefaultCaret;", "final")]
		public Dova.JDK.javax.swing.text.DefaultCaret this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.DefaultCaret>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SafeScroller(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/DefaultCaret;Ljava/awt/Rectangle;)V", "")]
		public SafeScroller(Dova.JDK.javax.swing.text.DefaultCaret arg0, Dova.JDK.java.awt.Rectangle arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultCaret$SafeScroller;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultCaret$DefaultFilterBypass;", "private")]
	public partial class DefaultFilterBypass
		: Dova.JDK.javax.swing.text.NavigationFilter.FilterBypass
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultFilterBypass()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultCaret$DefaultFilterBypass;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/DefaultCaret;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/DefaultCaret;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDot", "(ILjavax/swing/text/Position$Bias;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moveDot", "(ILjavax/swing/text/Position$Bias;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCaret", "()Ljavax/swing/text/Caret;"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/DefaultCaret;", "final")]
		public Dova.JDK.javax.swing.text.DefaultCaret this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.DefaultCaret>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultFilterBypass(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/DefaultCaret;)V", "private")]
		public DefaultFilterBypass(Dova.JDK.javax.swing.text.DefaultCaret arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultCaret$DefaultFilterBypass;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjavax/swing/text/Position$Bias;)V", "public")]
		public void setDot(int arg0, Dova.JDK.javax.swing.text.Position.Bias arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(ILjavax/swing/text/Position$Bias;)V", "public")]
		public void moveDot(int arg0, Dova.JDK.javax.swing.text.Position.Bias arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljavax/swing/text/Caret;", "public")]
		public Dova.JDK.javax.swing.text.Caret getCaret()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Caret>(ret);
		}
	}
}
