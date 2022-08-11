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

namespace Dova.JDK.java.awt;

[JniSignatureAttribute("Ljava/awt/KeyboardFocusManager;", "public abstract")]
public partial class KeyboardFocusManager
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.awt.KeyEventDispatcher
	, Dova.JDK.java.awt.KeyEventPostProcessor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KeyboardFocusManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/KeyboardFocusManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "focusLog", "Lsun/util/logging/PlatformLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "peer", "Ljava/awt/peer/KeyboardFocusManagerPeer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "log", "Lsun/util/logging/PlatformLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORWARD_TRAVERSAL_KEYS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BACKWARD_TRAVERSAL_KEYS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UP_CYCLE_TRAVERSAL_KEYS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOWN_CYCLE_TRAVERSAL_KEYS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRAVERSAL_KEY_LENGTH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "focusOwner", "Ljava/awt/Component;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "permanentFocusOwner", "Ljava/awt/Component;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "focusedWindow", "Ljava/awt/Window;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "activeWindow", "Ljava/awt/Window;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultPolicy", "Ljava/awt/FocusTraversalPolicy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultFocusTraversalKeyPropertyNames", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultFocusTraversalKeys", "[Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "currentFocusCycleRoot", "Ljava/awt/Container;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vetoableSupport", "Ljava/beans/VetoableChangeSupport;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "changeSupport", "Ljava/beans/PropertyChangeSupport;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyEventDispatchers", "Ljava/util/LinkedList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyEventPostProcessors", "Ljava/util/LinkedList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "mostRecentFocusOwners", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "replaceKeyboardFocusManagerPermission", "Ljava/awt/AWTPermission;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentSequencedEvent", "Ljava/awt/SequencedEvent;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "heavyweightRequests", "Ljava/util/LinkedList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "currentLightweightRequests", "Ljava/util/LinkedList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "clearingCurrentLightweightRequests", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "allowSyncFocusRequests", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "newFocusOwner", "Ljava/awt/Component;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "disableRestoreFocus", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SNFH_FAILURE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SNFH_SUCCESS_HANDLED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SNFH_SUCCESS_PROCEED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initIDs", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isProxyActive", "(Ljava/awt/event/KeyEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActiveWindow", "()Ljava/awt/Window;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalFocusedWindow", "()Ljava/awt/Window;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isTemporary", "(Ljava/awt/Component;Ljava/awt/Component;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDefaultFocusTraversalPolicy", "(Ljava/awt/FocusTraversalPolicy;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addKeyEventPostProcessor", "(Ljava/awt/KeyEventPostProcessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkReplaceKFMPermission", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initPeer", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkKFMSecurity", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearGlobalFocusOwner", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "_clearGlobalFocusOwner", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "markClearGlobalFocusOwner", "()Ljava/awt/Window;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFocusedWindow", "()Ljava/awt/Window;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusNextComponent", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusNextComponent", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusPreviousComponent", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusPreviousComponent", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "upFocusCycle", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "upFocusCycle", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "downFocusCycle", "(Ljava/awt/Container;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "downFocusCycle", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalFocusOwner", "()Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLastHWRequest", "()Ljava/awt/KeyboardFocusManager$HeavyweightFocusRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeFocusOwner", "()Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "dispatchAndCatchException", "(Ljava/lang/Throwable;Ljava/awt/Component;Ljava/awt/event/FocusEvent;)Ljava/lang/Throwable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeFocusedWindow", "()Ljava/awt/Window;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "focusedWindowChanged", "(Ljava/awt/Component;Ljava/awt/Component;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFirstHWRequest", "()Ljava/awt/KeyboardFocusManager$HeavyweightFocusRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "handleException", "(Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeFirstRequest", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getHeavyweight", "(Ljava/awt/Component;)Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "retargetUnexpectedFocusEvent", "(Ljava/awt/event/FocusEvent;)Ljava/awt/event/FocusEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "processCurrentLightweightRequests", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "retargetFocusGained", "(Ljava/awt/event/FocusEvent;)Ljava/awt/event/FocusEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "retargetFocusLost", "(Ljava/awt/event/FocusEvent;)Ljava/awt/event/FocusEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearMarkers", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isProxyActiveImpl", "(Ljava/awt/event/KeyEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setCurrentKeyboardFocusManager", "(Ljava/awt/KeyboardFocusManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCurrentSequencedEvent", "(Ljava/awt/SequencedEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initFocusTraversalKeysSet", "(Ljava/lang/String;Ljava/util/Set;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGlobalFocusOwner", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearFocusOwner", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNativeFocusOwner", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalPermanentFocusOwner", "()Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGlobalFocusedWindow", "(Ljava/awt/Window;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalActiveWindow", "()Ljava/awt/Window;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGlobalActiveWindow", "(Ljava/awt/Window;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDefaultFocusTraversalKeys", "(ILjava/util/Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalCurrentFocusCycleRoot", "()Ljava/awt/Container;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGlobalCurrentFocusCycleRoot", "(Ljava/awt/Container;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addKeyEventDispatcher", "(Ljava/awt/KeyEventDispatcher;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeKeyEventDispatcher", "(Ljava/awt/KeyEventDispatcher;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeyEventDispatchers", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeKeyEventPostProcessor", "(Ljava/awt/KeyEventPostProcessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeyEventPostProcessors", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redispatchEvent", "(Ljava/awt/Component;Ljava/awt/AWTEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispatchKeyEvent", "(Ljava/awt/event/KeyEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dumpRequests", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "processSynchronousLightweightTransfer", "(Ljava/awt/Component;Ljava/awt/Component;ZZJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "shouldNativelyFocusHeavyweight", "(Ljava/awt/Component;Ljava/awt/Component;ZZJLjava/awt/event/FocusEvent$Cause;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentWaitingRequest", "(Ljava/awt/Component;)Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeLastFocusRequest", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCurrentKeyboardFocusManager", "()Ljava/awt/KeyboardFocusManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCurrentKeyboardFocusManager", "(Lsun/awt/AppContext;)Ljava/awt/KeyboardFocusManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "firePropertyChange", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireVetoableChange", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispatchEvent", "(Ljava/awt/AWTEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFocusOwner", "()Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermanentFocusOwner", "()Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMostRecentFocusOwner", "(Ljava/awt/Window;)Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processKeyEvent", "(Ljava/awt/Component;Ljava/awt/event/KeyEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addVetoableChangeListener", "(Ljava/beans/VetoableChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addVetoableChangeListener", "(Ljava/lang/String;Ljava/beans/VetoableChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeVetoableChangeListener", "(Ljava/lang/String;Ljava/beans/VetoableChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeVetoableChangeListener", "(Ljava/beans/VetoableChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVetoableChangeListeners", "(Ljava/lang/String;)[Ljava/beans/VetoableChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVetoableChangeListeners", "()[Ljava/beans/VetoableChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPropertyChangeListeners", "()[Ljava/beans/PropertyChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPropertyChangeListeners", "(Ljava/lang/String;)[Ljava/beans/PropertyChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAutoFocusTransferEnabledFor", "(Ljava/awt/Component;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "enqueueKeyEvents", "(JLjava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentSequencedEvent", "()Ljava/awt/SequencedEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dequeueKeyEvents", "(JLjava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentFocusCycleRoot", "()Ljava/awt/Container;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGlobalCurrentFocusCycleRootPriv", "(Ljava/awt/Container;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setMostRecentFocusOwner", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setMostRecentFocusOwner", "(Ljava/awt/Window;Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultFocusTraversalPolicy", "()Ljava/awt/FocusTraversalPolicy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postProcessKeyEvent", "(Ljava/awt/event/KeyEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "clearMostRecentFocusOwner", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAutoFocusTransferEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "retargetFocusEvent", "(Ljava/awt/AWTEvent;)Ljava/awt/AWTEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGlobalPermanentFocusOwner", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "discardKeyEvents", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultFocusTraversalKeys", "(I)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearGlobalFocusOwnerPriv", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removePropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V"));
	}

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static final")]
	public static Dova.JDK.sun.util.logging.PlatformLogger focusLog_Property
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

	[JniSignatureAttribute("Ljava/awt/peer/KeyboardFocusManagerPeer;", "transient")]
	public Dova.JDK.java.awt.peer.KeyboardFocusManagerPeer peer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.peer.KeyboardFocusManagerPeer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static final")]
	public static Dova.JDK.sun.util.logging.PlatformLogger log_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int FORWARD_TRAVERSAL_KEYS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int BACKWARD_TRAVERSAL_KEYS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int UP_CYCLE_TRAVERSAL_KEYS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int DOWN_CYCLE_TRAVERSAL_KEYS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int TRAVERSAL_KEY_LENGTH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Component;", "private static")]
	public static Dova.JDK.java.awt.Component focusOwner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Component;", "private static")]
	public static Dova.JDK.java.awt.Component permanentFocusOwner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Window;", "private static")]
	public static Dova.JDK.java.awt.Window focusedWindow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Window;", "private static")]
	public static Dova.JDK.java.awt.Window activeWindow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/FocusTraversalPolicy;", "private")]
	public Dova.JDK.java.awt.FocusTraversalPolicy defaultPolicy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.FocusTraversalPolicy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> defaultFocusTraversalKeyPropertyNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/util/Set;", "private")]
	public JavaArray<Dova.JDK.java.util.Set> defaultFocusTraversalKeys_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Set>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Container;", "private static")]
	public static Dova.JDK.java.awt.Container currentFocusCycleRoot_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Container>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/VetoableChangeSupport;", "private")]
	public Dova.JDK.java.beans.VetoableChangeSupport vetoableSupport_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.VetoableChangeSupport>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/PropertyChangeSupport;", "private")]
	public Dova.JDK.java.beans.PropertyChangeSupport changeSupport_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeSupport>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/LinkedList;", "private")]
	public Dova.JDK.java.util.LinkedList keyEventDispatchers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/LinkedList;", "private")]
	public Dova.JDK.java.util.LinkedList keyEventPostProcessors_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static")]
	public static Dova.JDK.java.util.Map mostRecentFocusOwners_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/AWTPermission;", "private static")]
	public static Dova.JDK.java.awt.AWTPermission replaceKeyboardFocusManagerPermission_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.AWTPermission>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/SequencedEvent;", "transient")]
	public Dova.JDK.java.awt.SequencedEvent currentSequencedEvent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.SequencedEvent>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/LinkedList;", "private static")]
	public static Dova.JDK.java.util.LinkedList heavyweightRequests_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/LinkedList;", "private static")]
	public static Dova.JDK.java.util.LinkedList currentLightweightRequests_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static")]
	public static bool clearingCurrentLightweightRequests_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("Z", "private static")]
	public static bool allowSyncFocusRequests_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Component;", "private static")]
	public static Dova.JDK.java.awt.Component newFocusOwner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static volatile")]
	public static bool disableRestoreFocus_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SNFH_FAILURE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SNFH_SUCCESS_HANDLED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SNFH_SUCCESS_PROCEED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[31]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[31], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[32]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[32], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KeyboardFocusManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public KeyboardFocusManager() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/KeyboardFocusManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "private static native")]
	public static void initIDs()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)Z", "static")]
	public static bool isProxyActive(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/Window;", "public")]
	public Dova.JDK.java.awt.Window getActiveWindow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Window;", "protected")]
	public Dova.JDK.java.awt.Window getGlobalFocusedWindow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Component;)Z", "private static")]
	public static bool isTemporary(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Component arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/FocusTraversalPolicy;)V", "public")]
	public void setDefaultFocusTraversalPolicy(Dova.JDK.java.awt.FocusTraversalPolicy arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/KeyEventPostProcessor;)V", "public")]
	public void addKeyEventPostProcessor(Dova.JDK.java.awt.KeyEventPostProcessor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void checkReplaceKFMPermission()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void initPeer()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkKFMSecurity()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void clearGlobalFocusOwner()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void _clearGlobalFocusOwner()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("()Ljava/awt/Window;", "static")]
	public static Dova.JDK.java.awt.Window markClearGlobalFocusOwner()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Window;", "public")]
	public Dova.JDK.java.awt.Window getFocusedWindow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "public abstract")]
	public void focusNextComponent(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("()V", "public final")]
	public void focusNextComponent()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "public abstract")]
	public void focusPreviousComponent(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()V", "public final")]
	public void focusPreviousComponent()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
	}

	[JniSignatureAttribute("()V", "public final")]
	public void upFocusCycle()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18]);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "public abstract")]
	public void upFocusCycle(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)V", "public abstract")]
	public void downFocusCycle(Dova.JDK.java.awt.Container arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("()V", "public final")]
	public void downFocusCycle()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21]);
	}

	[JniSignatureAttribute("()Ljava/awt/Component;", "protected")]
	public Dova.JDK.java.awt.Component getGlobalFocusOwner()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/KeyboardFocusManager$HeavyweightFocusRequest;", "private static")]
	public static Dova.JDK.java.awt.KeyboardFocusManager.HeavyweightFocusRequest getLastHWRequest()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.KeyboardFocusManager.HeavyweightFocusRequest>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Component;", "")]
	public Dova.JDK.java.awt.Component getNativeFocusOwner()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;Ljava/awt/Component;Ljava/awt/event/FocusEvent;)Ljava/lang/Throwable;", "private static")]
	public static Dova.JDK.java.lang.Throwable dispatchAndCatchException(Dova.JDK.java.lang.Throwable arg0, Dova.JDK.java.awt.Component arg1, Dova.JDK.java.awt.@event.FocusEvent arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Throwable>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Window;", "")]
	public Dova.JDK.java.awt.Window getNativeFocusedWindow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Component;)Z", "private static")]
	public static bool focusedWindowChanged(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Component arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/KeyboardFocusManager$HeavyweightFocusRequest;", "private static")]
	public static Dova.JDK.java.awt.KeyboardFocusManager.HeavyweightFocusRequest getFirstHWRequest()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.KeyboardFocusManager.HeavyweightFocusRequest>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "private static")]
	public static void handleException(Dova.JDK.java.lang.Throwable arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("()Z", "static")]
	public static bool removeFirstRequest()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[30]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Component;", "static")]
	public static Dova.JDK.java.awt.Component getHeavyweight(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)Ljava/awt/event/FocusEvent;", "static")]
	public static Dova.JDK.java.awt.@event.FocusEvent retargetUnexpectedFocusEvent(Dova.JDK.java.awt.@event.FocusEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.FocusEvent>(ret);
	}

	[JniSignatureAttribute("()V", "static")]
	public static void processCurrentLightweightRequests()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[33]);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)Ljava/awt/event/FocusEvent;", "static")]
	public static Dova.JDK.java.awt.@event.FocusEvent retargetFocusGained(Dova.JDK.java.awt.@event.FocusEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.FocusEvent>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)Ljava/awt/event/FocusEvent;", "static")]
	public static Dova.JDK.java.awt.@event.FocusEvent retargetFocusLost(Dova.JDK.java.awt.@event.FocusEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.FocusEvent>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void clearMarkers()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36]);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)Z", "private static")]
	public static bool isProxyActiveImpl(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[37], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/KeyboardFocusManager;)V", "public static")]
	public static void setCurrentKeyboardFocusManager(Dova.JDK.java.awt.KeyboardFocusManager arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/SequencedEvent;)V", "final")]
	public void setCurrentSequencedEvent(Dova.JDK.java.awt.SequencedEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Set;)Ljava/util/Set;", "static")]
	public static Dova.JDK.java.util.Set initFocusTraversalKeysSet(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Set arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "protected")]
	public void setGlobalFocusOwner(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void clearFocusOwner()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42]);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "")]
	public void setNativeFocusOwner(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Component;", "protected")]
	public Dova.JDK.java.awt.Component getGlobalPermanentFocusOwner()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Window;)V", "protected")]
	public void setGlobalFocusedWindow(Dova.JDK.java.awt.Window arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Window;", "protected")]
	public Dova.JDK.java.awt.Window getGlobalActiveWindow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Window;)V", "protected")]
	public void setGlobalActiveWindow(Dova.JDK.java.awt.Window arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("(ILjava/util/Set;)V", "public")]
	public void setDefaultFocusTraversalKeys(int arg0, Dova.JDK.java.util.Set arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/awt/Container;", "protected")]
	public Dova.JDK.java.awt.Container getGlobalCurrentFocusCycleRoot()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Container>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)V", "public")]
	public void setGlobalCurrentFocusCycleRoot(Dova.JDK.java.awt.Container arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/KeyEventDispatcher;)V", "public")]
	public void addKeyEventDispatcher(Dova.JDK.java.awt.KeyEventDispatcher arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/KeyEventDispatcher;)V", "public")]
	public void removeKeyEventDispatcher(Dova.JDK.java.awt.KeyEventDispatcher arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "protected synchronized")]
	public Dova.JDK.java.util.List getKeyEventDispatchers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/KeyEventPostProcessor;)V", "public")]
	public void removeKeyEventPostProcessor(Dova.JDK.java.awt.KeyEventPostProcessor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "protected")]
	public Dova.JDK.java.util.List getKeyEventPostProcessors()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/AWTEvent;)V", "public final")]
	public void redispatchEvent(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.AWTEvent arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)Z", "public abstract")]
	public bool dispatchKeyEvent(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "")]
	public void dumpRequests()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58]);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Component;ZZJ)Z", "static")]
	public static bool processSynchronousLightweightTransfer(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Component arg1, bool arg2, bool arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[59], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Component;ZZJLjava/awt/event/FocusEvent$Cause;)I", "static")]
	public static int shouldNativelyFocusHeavyweight(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Component arg1, bool arg2, bool arg3, long arg4, Dova.JDK.java.awt.@event.FocusEvent.Cause arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[60], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Component;", "")]
	public Dova.JDK.java.awt.Component getCurrentWaitingRequest(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "static")]
	public static void removeLastFocusRequest(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[62], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/KeyboardFocusManager;", "public static")]
	public static Dova.JDK.java.awt.KeyboardFocusManager getCurrentKeyboardFocusManager()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[63]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.KeyboardFocusManager>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/AppContext;)Ljava/awt/KeyboardFocusManager;", "static synchronized")]
	public static Dova.JDK.java.awt.KeyboardFocusManager getCurrentKeyboardFocusManager(Dova.JDK.sun.awt.AppContext arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[64], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.KeyboardFocusManager>(ret);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public")]
	public void addPropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", "public")]
	public void addPropertyChangeListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.PropertyChangeListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "protected")]
	public void firePropertyChange(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "protected")]
	public void fireVetoableChange(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)Z", "public abstract")]
	public bool dispatchEvent(Dova.JDK.java.awt.AWTEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/Component;", "public")]
	public Dova.JDK.java.awt.Component getFocusOwner()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Component;", "public")]
	public Dova.JDK.java.awt.Component getPermanentFocusOwner()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Window;)Ljava/awt/Component;", "static synchronized")]
	public static Dova.JDK.java.awt.Component getMostRecentFocusOwner(Dova.JDK.java.awt.Window arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[72], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/event/KeyEvent;)V", "public abstract")]
	public void processKeyEvent(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.@event.KeyEvent arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/beans/VetoableChangeListener;)V", "public")]
	public void addVetoableChangeListener(Dova.JDK.java.beans.VetoableChangeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/VetoableChangeListener;)V", "public")]
	public void addVetoableChangeListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.VetoableChangeListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/VetoableChangeListener;)V", "public")]
	public void removeVetoableChangeListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.VetoableChangeListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[76], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/beans/VetoableChangeListener;)V", "public")]
	public void removeVetoableChangeListener(Dova.JDK.java.beans.VetoableChangeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Ljava/beans/VetoableChangeListener;", "public synchronized")]
	public JavaArray<Dova.JDK.java.beans.VetoableChangeListener> getVetoableChangeListeners(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.VetoableChangeListener>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/beans/VetoableChangeListener;", "public synchronized")]
	public JavaArray<Dova.JDK.java.beans.VetoableChangeListener> getVetoableChangeListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.VetoableChangeListener>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/beans/PropertyChangeListener;", "public synchronized")]
	public JavaArray<Dova.JDK.java.beans.PropertyChangeListener> getPropertyChangeListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.PropertyChangeListener>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Ljava/beans/PropertyChangeListener;", "public synchronized")]
	public JavaArray<Dova.JDK.java.beans.PropertyChangeListener> getPropertyChangeListeners(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[81], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.PropertyChangeListener>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)Z", "static")]
	public static bool isAutoFocusTransferEnabledFor(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[82], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/awt/Component;)V", "protected abstract")]
	public void enqueueKeyEvents(long arg0, Dova.JDK.java.awt.Component arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[83], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/awt/SequencedEvent;", "final")]
	public Dova.JDK.java.awt.SequencedEvent getCurrentSequencedEvent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[84]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.SequencedEvent>(ret);
	}

	[JniSignatureAttribute("(JLjava/awt/Component;)V", "protected abstract")]
	public void dequeueKeyEvents(long arg0, Dova.JDK.java.awt.Component arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[85], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/awt/Container;", "public")]
	public Dova.JDK.java.awt.Container getCurrentFocusCycleRoot()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[86]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Container>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)V", "")]
	public void setGlobalCurrentFocusCycleRootPriv(Dova.JDK.java.awt.Container arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[87], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "static")]
	public static void setMostRecentFocusOwner(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[88], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Window;Ljava/awt/Component;)V", "static synchronized")]
	public static void setMostRecentFocusOwner(Dova.JDK.java.awt.Window arg0, Dova.JDK.java.awt.Component arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[89], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/awt/FocusTraversalPolicy;", "public synchronized")]
	public Dova.JDK.java.awt.FocusTraversalPolicy getDefaultFocusTraversalPolicy()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[90]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.FocusTraversalPolicy>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)Z", "public abstract")]
	public bool postProcessKeyEvent(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[91], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "static")]
	public static void clearMostRecentFocusOwner(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[92], arg0);
	}

	[JniSignatureAttribute("()Z", "static")]
	public static bool isAutoFocusTransferEnabled()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[93]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)Ljava/awt/AWTEvent;", "static")]
	public static Dova.JDK.java.awt.AWTEvent retargetFocusEvent(Dova.JDK.java.awt.AWTEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[94], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.AWTEvent>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "protected")]
	public void setGlobalPermanentFocusOwner(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[95], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "protected abstract")]
	public void discardKeyEvents(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[96], arg0);
	}

	[JniSignatureAttribute("(I)Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set getDefaultFocusTraversalKeys(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[97], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void clearGlobalFocusOwnerPriv()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[98]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", "public")]
	public void removePropertyChangeListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.PropertyChangeListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[99], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public")]
	public void removePropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[100], arg0);
	}

	[JniSignatureAttribute("Ljava/awt/KeyboardFocusManager$HeavyweightFocusRequest;", "private static final")]
	public partial class HeavyweightFocusRequest
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HeavyweightFocusRequest()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/KeyboardFocusManager$HeavyweightFocusRequest;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "heavyweight", "Ljava/awt/Component;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lightweightRequests", "Ljava/util/LinkedList;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLEAR_GLOBAL_FOCUS_OWNER", "Ljava/awt/KeyboardFocusManager$HeavyweightFocusRequest;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Component;Ljava/awt/Component;ZLjava/awt/event/FocusEvent$Cause;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addLightweightRequest", "(Ljava/awt/Component;ZLjava/awt/event/FocusEvent$Cause;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstLightweightRequest", "()Ljava/awt/KeyboardFocusManager$LightweightFocusRequest;"));
		}

		[JniSignatureAttribute("Ljava/awt/Component;", "final")]
		public Dova.JDK.java.awt.Component heavyweight_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/LinkedList;", "final")]
		public Dova.JDK.java.util.LinkedList lightweightRequests_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedList>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/KeyboardFocusManager$HeavyweightFocusRequest;", "static final")]
		public static Dova.JDK.java.awt.KeyboardFocusManager.HeavyweightFocusRequest CLEAR_GLOBAL_FOCUS_OWNER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.KeyboardFocusManager.HeavyweightFocusRequest>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HeavyweightFocusRequest(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public HeavyweightFocusRequest() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Component;ZLjava/awt/event/FocusEvent$Cause;)V", "")]
		public HeavyweightFocusRequest(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Component arg1, bool arg2, Dova.JDK.java.awt.@event.FocusEvent.Cause arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/KeyboardFocusManager$HeavyweightFocusRequest;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;ZLjava/awt/event/FocusEvent$Cause;)Z", "")]
		public bool addLightweightRequest(Dova.JDK.java.awt.Component arg0, bool arg1, Dova.JDK.java.awt.@event.FocusEvent.Cause arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/awt/KeyboardFocusManager$LightweightFocusRequest;", "")]
		public Dova.JDK.java.awt.KeyboardFocusManager.LightweightFocusRequest getFirstLightweightRequest()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.KeyboardFocusManager.LightweightFocusRequest>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/awt/KeyboardFocusManager$LightweightFocusRequest;", "private static final")]
	public partial class LightweightFocusRequest
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LightweightFocusRequest()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/KeyboardFocusManager$LightweightFocusRequest;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "component", "Ljava/awt/Component;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "temporary", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cause", "Ljava/awt/event/FocusEvent$Cause;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Component;ZLjava/awt/event/FocusEvent$Cause;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/awt/Component;", "final")]
		public Dova.JDK.java.awt.Component component_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "final")]
		public bool temporary_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Ljava/awt/event/FocusEvent$Cause;", "final")]
		public Dova.JDK.java.awt.@event.FocusEvent.Cause cause_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.FocusEvent.Cause>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LightweightFocusRequest(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/awt/Component;ZLjava/awt/event/FocusEvent$Cause;)V", "")]
		public LightweightFocusRequest(Dova.JDK.java.awt.Component arg0, bool arg1, Dova.JDK.java.awt.@event.FocusEvent.Cause arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/KeyboardFocusManager$LightweightFocusRequest;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}
}
