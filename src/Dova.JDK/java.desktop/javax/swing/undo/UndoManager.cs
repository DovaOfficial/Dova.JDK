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

namespace Dova.JDK.javax.swing.undo;

[JniSignatureAttribute("Ljavax/swing/undo/UndoManager;", "public")]
public partial class UndoManager
	: Dova.JDK.javax.swing.undo.CompoundEdit
	, Dova.JDK.javax.swing.@event.UndoableEditListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UndoManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/undo/UndoManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "indexOfNextAdd", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "limit", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "end", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trimEdits", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trimForLimit", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryUndoOrRedo", "(Ljavax/swing/undo/UndoManager$Action;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "editToBeUndone", "()Ljavax/swing/undo/UndoableEdit;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "editToBeRedone", "()Ljavax/swing/undo/UndoableEdit;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEditLockSupport", "(Ljavax/swing/undo/UndoableEdit;)Lsun/swing/text/UndoableEditLockSupport;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "undoTo", "(Ljavax/swing/undo/UndoableEdit;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redoTo", "(Ljavax/swing/undo/UndoableEdit;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUndoPresentationName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRedoPresentationName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "discardAllEdits", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "undoOrRedo", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canUndoOrRedo", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUndoOrRedoPresentationName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLimit", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLimit", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canUndo", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canRedo", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redo", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "undo", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addEdit", "(Ljavax/swing/undo/UndoableEdit;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "undoableEditHappened", "(Ljavax/swing/event/UndoableEditEvent;)V"));
	}

	[JniSignatureAttribute("I", "")]
	public int indexOfNextAdd_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int limit_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UndoManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public UndoManager() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/undo/UndoManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void end()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(II)V", "protected")]
	public void trimEdits(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void trimForLimit()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljavax/swing/undo/UndoManager$Action;)V", "private")]
	public void tryUndoOrRedo(Dova.JDK.javax.swing.undo.UndoManager.Action arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/undo/UndoableEdit;", "protected")]
	public Dova.JDK.javax.swing.undo.UndoableEdit editToBeUndone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.undo.UndoableEdit>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/undo/UndoableEdit;", "protected")]
	public Dova.JDK.javax.swing.undo.UndoableEdit editToBeRedone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.undo.UndoableEdit>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/undo/UndoableEdit;)Lsun/swing/text/UndoableEditLockSupport;", "private")]
	public Dova.JDK.sun.swing.text.UndoableEditLockSupport getEditLockSupport(Dova.JDK.javax.swing.undo.UndoableEdit arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.text.UndoableEditLockSupport>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/undo/UndoableEdit;)V", "protected")]
	public void undoTo(Dova.JDK.javax.swing.undo.UndoableEdit arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/undo/UndoableEdit;)V", "protected")]
	public void redoTo(Dova.JDK.javax.swing.undo.UndoableEdit arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public synchronized")]
	public Dova.JDK.java.lang.String getUndoPresentationName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public synchronized")]
	public Dova.JDK.java.lang.String getRedoPresentationName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void discardAllEdits()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void undoOrRedo()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("()Z", "public synchronized")]
	public bool canUndoOrRedo()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public synchronized")]
	public Dova.JDK.java.lang.String getUndoOrRedoPresentationName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)V", "public synchronized")]
	public void setLimit(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()I", "public synchronized")]
	public int getLimit()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public synchronized")]
	public bool canUndo()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public synchronized")]
	public bool canRedo()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void redo()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void undo()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21]);
	}

	[JniSignatureAttribute("(Ljavax/swing/undo/UndoableEdit;)Z", "public synchronized")]
	public bool addEdit(Dova.JDK.javax.swing.undo.UndoableEdit arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/event/UndoableEditEvent;)V", "public")]
	public void undoableEditHappened(Dova.JDK.javax.swing.@event.UndoableEditEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("Ljavax/swing/undo/UndoManager$Action;", "private static final")]
	public partial class Action
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Action()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/undo/UndoManager$Action;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNDO", "Ljavax/swing/undo/UndoManager$Action;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REDO", "Ljavax/swing/undo/UndoManager$Action;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANY", "Ljavax/swing/undo/UndoManager$Action;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljavax/swing/undo/UndoManager$Action;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljavax/swing/undo/UndoManager$Action;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljavax/swing/undo/UndoManager$Action;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljavax/swing/undo/UndoManager$Action;"));
		}

		[JniSignatureAttribute("Ljavax/swing/undo/UndoManager$Action;", "public static final")]
		public static Dova.JDK.javax.swing.undo.UndoManager.Action UNDO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.undo.UndoManager.Action>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/undo/UndoManager$Action;", "public static final")]
		public static Dova.JDK.javax.swing.undo.UndoManager.Action REDO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.undo.UndoManager.Action>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/undo/UndoManager$Action;", "public static final")]
		public static Dova.JDK.javax.swing.undo.UndoManager.Action ANY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.undo.UndoManager.Action>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljavax/swing/undo/UndoManager$Action;", "private static final")]
		public static JavaArray<Dova.JDK.javax.swing.undo.UndoManager.Action> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.undo.UndoManager.Action>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Action(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Action(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/undo/UndoManager$Action;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljavax/swing/undo/UndoManager$Action;", "public static")]
		public static JavaArray<Dova.JDK.javax.swing.undo.UndoManager.Action> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.undo.UndoManager.Action>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/swing/undo/UndoManager$Action;", "public static")]
		public static Dova.JDK.javax.swing.undo.UndoManager.Action valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.undo.UndoManager.Action>(ret);
		}

		[JniSignatureAttribute("()[Ljavax/swing/undo/UndoManager$Action;", "private static")]
		public static JavaArray<Dova.JDK.javax.swing.undo.UndoManager.Action> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.undo.UndoManager.Action>>(ret);
		}
	}
}
