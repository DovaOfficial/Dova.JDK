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

[JniSignatureAttribute("Lsun/awt/GlobalCursorManager;", "public abstract")]
public partial class GlobalCursorManager
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GlobalCursorManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/GlobalCursorManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nativeUpdater", "Lsun/awt/GlobalCursorManager$NativeUpdater;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastUpdateMillis", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastUpdateLock", "Ljava/lang/Object;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationOnScreen", "(Ljava/awt/Component;)Ljava/awt/Point;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateCursorImmediately", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateCursorImmediately", "(Ljava/awt/event/InputEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCursor", "(Ljava/awt/Component;Ljava/awt/Cursor;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateCursorLater", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findHeavyweightUnderCursor", "(Z)Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateCursorOutOfJava", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCursorPos", "(Ljava/awt/Point;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "_updateCursor", "(Z)V"));
	}

	[JniSignatureAttribute("Lsun/awt/GlobalCursorManager$NativeUpdater;", "private final")]
	public Dova.JDK.sun.awt.GlobalCursorManager.NativeUpdater nativeUpdater_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.GlobalCursorManager.NativeUpdater>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long lastUpdateMillis_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
	public Dova.JDK.java.lang.Object lastUpdateLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GlobalCursorManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public GlobalCursorManager() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/GlobalCursorManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Point;", "protected abstract")]
	public Dova.JDK.java.awt.Point getLocationOnScreen(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void updateCursorImmediately()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljava/awt/event/InputEvent;)V", "public")]
	public void updateCursorImmediately(Dova.JDK.java.awt.@event.InputEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Cursor;Z)V", "protected abstract")]
	public void setCursor(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Cursor arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "public")]
	public void updateCursorLater(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Z)Ljava/awt/Component;", "protected abstract")]
	public Dova.JDK.java.awt.Component findHeavyweightUnderCursor(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void updateCursorOutOfJava()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(Ljava/awt/Point;)V", "protected abstract")]
	public void getCursorPos(Dova.JDK.java.awt.Point arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Z)V", "private")]
	public void _updateCursor(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("Lsun/awt/GlobalCursorManager$NativeUpdater;", "")]
	public partial class NativeUpdater
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Runnable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NativeUpdater()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/GlobalCursorManager$NativeUpdater;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pending", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/awt/GlobalCursorManager;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/awt/GlobalCursorManager;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postIfNotPending", "(Ljava/awt/Component;Ljava/awt/event/InvocationEvent;)V"));
		}

		[JniSignatureAttribute("Z", "")]
		public bool pending_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Lsun/awt/GlobalCursorManager;", "final")]
		public Dova.JDK.sun.awt.GlobalCursorManager this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.GlobalCursorManager>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NativeUpdater(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/awt/GlobalCursorManager;)V", "")]
		public NativeUpdater(Dova.JDK.sun.awt.GlobalCursorManager arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/GlobalCursorManager$NativeUpdater;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/event/InvocationEvent;)V", "public")]
		public void postIfNotPending(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.@event.InvocationEvent arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}
	}
}
