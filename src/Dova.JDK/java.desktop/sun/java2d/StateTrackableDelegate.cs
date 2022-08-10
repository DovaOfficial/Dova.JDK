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

namespace Dova.JDK.sun.java2d;

[JniSignatureAttribute("Lsun/java2d/StateTrackableDelegate;", "public final")]
public partial class StateTrackableDelegate
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.java2d.StateTrackable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StateTrackableDelegate()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/StateTrackableDelegate;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "UNTRACKABLE_DELEGATE", "Lsun/java2d/StateTrackableDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "IMMUTABLE_DELEGATE", "Lsun/java2d/StateTrackableDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "theState", "Lsun/java2d/StateTrackable$State;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "theTracker", "Lsun/java2d/StateTracker;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "numDynamicAgents", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StateTrackableDelegate", "(Lsun/java2d/StateTrackable$State;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getState", "()Lsun/java2d/StateTrackable$State;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createInstance", "(Lsun/java2d/StateTrackable$State;)Lsun/java2d/StateTrackableDelegate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getStateTracker", "()Lsun/java2d/StateTracker;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "markDirty", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setImmutable", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setUntrackable", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addDynamicAgent", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeDynamicAgent", "()V"));
	}

	[JniSignatureAttribute("Lsun/java2d/StateTrackableDelegate;", "public static final")]
	public static Dova.JDK.sun.java2d.StateTrackableDelegate UNTRACKABLE_DELEGATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.StateTrackableDelegate>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/java2d/StateTrackableDelegate;", "public static final")]
	public static Dova.JDK.sun.java2d.StateTrackableDelegate IMMUTABLE_DELEGATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.StateTrackableDelegate>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/java2d/StateTrackable$State;", "private")]
	public Dova.JDK.sun.java2d.StateTrackable.State theState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.StateTrackable.State>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/java2d/StateTracker;", "")]
	public Dova.JDK.sun.java2d.StateTracker theTracker_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.StateTracker>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int numDynamicAgents_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StateTrackableDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/java2d/StateTrackable$State;)V", "private")]
	public StateTrackableDelegate(Dova.JDK.sun.java2d.StateTrackable.State arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/StateTrackableDelegate;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/java2d/StateTrackable$State;", "public")]
	public Dova.JDK.sun.java2d.StateTrackable.State getState()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.StateTrackable.State>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/StateTrackable$State;)Lsun/java2d/StateTrackableDelegate;", "public static")]
	public static Dova.JDK.sun.java2d.StateTrackableDelegate createInstance(Dova.JDK.sun.java2d.StateTrackable.State arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.StateTrackableDelegate>(ret);
	}

	[JniSignatureAttribute("()Lsun/java2d/StateTracker;", "public synchronized")]
	public Dova.JDK.sun.java2d.StateTracker getStateTracker()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.StateTracker>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void markDirty()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void setImmutable()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void setUntrackable()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void addDynamicAgent()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()V", "protected synchronized")]
	public void removeDynamicAgent()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}
}
