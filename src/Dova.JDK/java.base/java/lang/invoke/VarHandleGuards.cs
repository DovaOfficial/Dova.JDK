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

namespace Dova.JDK.java.lang.invoke;

[JniSignatureAttribute("Ljava/lang/invoke/VarHandleGuards;", "final")]
public partial class VarHandleGuards
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static VarHandleGuards()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/VarHandleGuards;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_L_L", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LL_V", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LLL_Z", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LLL_L", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LL_L", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_L_I", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LI_V", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/invoke/VarHandle$AccessDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LII_Z", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IILjava/lang/invoke/VarHandle$AccessDescriptor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LII_I", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IILjava/lang/invoke/VarHandle$AccessDescriptor;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LI_I", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/invoke/VarHandle$AccessDescriptor;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_L_J", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LJ_V", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JLjava/lang/invoke/VarHandle$AccessDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LJJ_Z", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JJLjava/lang/invoke/VarHandle$AccessDescriptor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LJJ_J", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JJLjava/lang/invoke/VarHandle$AccessDescriptor;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LJ_J", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JLjava/lang/invoke/VarHandle$AccessDescriptor;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_L_F", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LF_V", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FLjava/lang/invoke/VarHandle$AccessDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LFF_Z", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FFLjava/lang/invoke/VarHandle$AccessDescriptor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LFF_F", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FFLjava/lang/invoke/VarHandle$AccessDescriptor;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LF_F", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FLjava/lang/invoke/VarHandle$AccessDescriptor;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_L_D", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LD_V", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;DLjava/lang/invoke/VarHandle$AccessDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LDD_Z", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;DDLjava/lang/invoke/VarHandle$AccessDescriptor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LDD_D", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;DDLjava/lang/invoke/VarHandle$AccessDescriptor;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LD_D", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;DLjava/lang/invoke/VarHandle$AccessDescriptor;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard__L", "(Ljava/lang/invoke/VarHandle;Ljava/lang/invoke/VarHandle$AccessDescriptor;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_L_V", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LL_Z", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard__I", "(Ljava/lang/invoke/VarHandle;Ljava/lang/invoke/VarHandle$AccessDescriptor;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_I_V", "(Ljava/lang/invoke/VarHandle;ILjava/lang/invoke/VarHandle$AccessDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_II_Z", "(Ljava/lang/invoke/VarHandle;IILjava/lang/invoke/VarHandle$AccessDescriptor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_II_I", "(Ljava/lang/invoke/VarHandle;IILjava/lang/invoke/VarHandle$AccessDescriptor;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_I_I", "(Ljava/lang/invoke/VarHandle;ILjava/lang/invoke/VarHandle$AccessDescriptor;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard__J", "(Ljava/lang/invoke/VarHandle;Ljava/lang/invoke/VarHandle$AccessDescriptor;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_J_V", "(Ljava/lang/invoke/VarHandle;JLjava/lang/invoke/VarHandle$AccessDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_JJ_Z", "(Ljava/lang/invoke/VarHandle;JJLjava/lang/invoke/VarHandle$AccessDescriptor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_JJ_J", "(Ljava/lang/invoke/VarHandle;JJLjava/lang/invoke/VarHandle$AccessDescriptor;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_J_J", "(Ljava/lang/invoke/VarHandle;JLjava/lang/invoke/VarHandle$AccessDescriptor;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard__F", "(Ljava/lang/invoke/VarHandle;Ljava/lang/invoke/VarHandle$AccessDescriptor;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_F_V", "(Ljava/lang/invoke/VarHandle;FLjava/lang/invoke/VarHandle$AccessDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_FF_Z", "(Ljava/lang/invoke/VarHandle;FFLjava/lang/invoke/VarHandle$AccessDescriptor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_FF_F", "(Ljava/lang/invoke/VarHandle;FFLjava/lang/invoke/VarHandle$AccessDescriptor;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_F_F", "(Ljava/lang/invoke/VarHandle;FLjava/lang/invoke/VarHandle$AccessDescriptor;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard__D", "(Ljava/lang/invoke/VarHandle;Ljava/lang/invoke/VarHandle$AccessDescriptor;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_D_V", "(Ljava/lang/invoke/VarHandle;DLjava/lang/invoke/VarHandle$AccessDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_DD_Z", "(Ljava/lang/invoke/VarHandle;DDLjava/lang/invoke/VarHandle$AccessDescriptor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_DD_D", "(Ljava/lang/invoke/VarHandle;DDLjava/lang/invoke/VarHandle$AccessDescriptor;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_D_D", "(Ljava/lang/invoke/VarHandle;DLjava/lang/invoke/VarHandle$AccessDescriptor;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LI_L", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/invoke/VarHandle$AccessDescriptor;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LIL_V", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LILL_Z", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LILL_L", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LIL_L", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LII_V", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IILjava/lang/invoke/VarHandle$AccessDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LIII_Z", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IIILjava/lang/invoke/VarHandle$AccessDescriptor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LIII_I", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IIILjava/lang/invoke/VarHandle$AccessDescriptor;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LI_J", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/invoke/VarHandle$AccessDescriptor;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LIJ_V", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJLjava/lang/invoke/VarHandle$AccessDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LIJJ_Z", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJLjava/lang/invoke/VarHandle$AccessDescriptor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LIJJ_J", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJLjava/lang/invoke/VarHandle$AccessDescriptor;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LIJ_J", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJLjava/lang/invoke/VarHandle$AccessDescriptor;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LI_F", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/invoke/VarHandle$AccessDescriptor;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LIF_V", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFLjava/lang/invoke/VarHandle$AccessDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LIFF_Z", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFFLjava/lang/invoke/VarHandle$AccessDescriptor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LIFF_F", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFFLjava/lang/invoke/VarHandle$AccessDescriptor;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LIF_F", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFLjava/lang/invoke/VarHandle$AccessDescriptor;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LI_D", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/invoke/VarHandle$AccessDescriptor;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LID_V", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IDLjava/lang/invoke/VarHandle$AccessDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LIDD_Z", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IDDLjava/lang/invoke/VarHandle$AccessDescriptor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LIDD_D", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IDDLjava/lang/invoke/VarHandle$AccessDescriptor;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LID_D", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IDLjava/lang/invoke/VarHandle$AccessDescriptor;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LJ_I", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JLjava/lang/invoke/VarHandle$AccessDescriptor;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LJI_V", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JILjava/lang/invoke/VarHandle$AccessDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LJII_Z", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JIILjava/lang/invoke/VarHandle$AccessDescriptor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LJII_I", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JIILjava/lang/invoke/VarHandle$AccessDescriptor;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LJI_I", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JILjava/lang/invoke/VarHandle$AccessDescriptor;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LJJ_V", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JJLjava/lang/invoke/VarHandle$AccessDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LJJJ_Z", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JJJLjava/lang/invoke/VarHandle$AccessDescriptor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guard_LJJJ_J", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JJJLjava/lang/invoke/VarHandle$AccessDescriptor;)J"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public VarHandleGuards(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public VarHandleGuards() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/invoke/VarHandleGuards;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)Ljava/lang/Object;", "static final")]
	public static Dova.JDK.java.lang.Object guard_L_L(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)V", "static final")]
	public static void guard_LL_V(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)Z", "static final")]
	public static bool guard_LLL_Z(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)Ljava/lang/Object;", "static final")]
	public static Dova.JDK.java.lang.Object guard_LLL_L(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)Ljava/lang/Object;", "static final")]
	public static Dova.JDK.java.lang.Object guard_LL_L(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)I", "static final")]
	public static int guard_L_I(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/invoke/VarHandle$AccessDescriptor;)V", "static final")]
	public static void guard_LI_V(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IILjava/lang/invoke/VarHandle$AccessDescriptor;)Z", "static final")]
	public static bool guard_LII_Z(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IILjava/lang/invoke/VarHandle$AccessDescriptor;)I", "static final")]
	public static int guard_LII_I(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/invoke/VarHandle$AccessDescriptor;)I", "static final")]
	public static int guard_LI_I(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)J", "static final")]
	public static long guard_L_J(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg2)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JLjava/lang/invoke/VarHandle$AccessDescriptor;)V", "static final")]
	public static void guard_LJ_V(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JJLjava/lang/invoke/VarHandle$AccessDescriptor;)Z", "static final")]
	public static bool guard_LJJ_Z(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JJLjava/lang/invoke/VarHandle$AccessDescriptor;)J", "static final")]
	public static long guard_LJJ_J(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JLjava/lang/invoke/VarHandle$AccessDescriptor;)J", "static final")]
	public static long guard_LJ_J(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)F", "static final")]
	public static float guard_L_F(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg2)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FLjava/lang/invoke/VarHandle$AccessDescriptor;)V", "static final")]
	public static void guard_LF_V(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FFLjava/lang/invoke/VarHandle$AccessDescriptor;)Z", "static final")]
	public static bool guard_LFF_Z(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2, float arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FFLjava/lang/invoke/VarHandle$AccessDescriptor;)F", "static final")]
	public static float guard_LFF_F(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2, float arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;FLjava/lang/invoke/VarHandle$AccessDescriptor;)F", "static final")]
	public static float guard_LF_F(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, float arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)D", "static final")]
	public static double guard_L_D(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg2)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;DLjava/lang/invoke/VarHandle$AccessDescriptor;)V", "static final")]
	public static void guard_LD_V(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, double arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;DDLjava/lang/invoke/VarHandle$AccessDescriptor;)Z", "static final")]
	public static bool guard_LDD_Z(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, double arg2, double arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;DDLjava/lang/invoke/VarHandle$AccessDescriptor;)D", "static final")]
	public static double guard_LDD_D(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, double arg2, double arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;DLjava/lang/invoke/VarHandle$AccessDescriptor;)D", "static final")]
	public static double guard_LD_D(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, double arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/invoke/VarHandle$AccessDescriptor;)Ljava/lang/Object;", "static final")]
	public static Dova.JDK.java.lang.Object guard__L(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)V", "static final")]
	public static void guard_L_V(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)Z", "static final")]
	public static bool guard_LL_Z(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/invoke/VarHandle$AccessDescriptor;)I", "static final")]
	public static int guard__I(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;ILjava/lang/invoke/VarHandle$AccessDescriptor;)V", "static final")]
	public static void guard_I_V(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;IILjava/lang/invoke/VarHandle$AccessDescriptor;)Z", "static final")]
	public static bool guard_II_Z(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1, int arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;IILjava/lang/invoke/VarHandle$AccessDescriptor;)I", "static final")]
	public static int guard_II_I(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1, int arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;ILjava/lang/invoke/VarHandle$AccessDescriptor;)I", "static final")]
	public static int guard_I_I(Dova.JDK.java.lang.invoke.VarHandle arg0, int arg1, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/invoke/VarHandle$AccessDescriptor;)J", "static final")]
	public static long guard__J(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;JLjava/lang/invoke/VarHandle$AccessDescriptor;)V", "static final")]
	public static void guard_J_V(Dova.JDK.java.lang.invoke.VarHandle arg0, long arg1, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;JJLjava/lang/invoke/VarHandle$AccessDescriptor;)Z", "static final")]
	public static bool guard_JJ_Z(Dova.JDK.java.lang.invoke.VarHandle arg0, long arg1, long arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;JJLjava/lang/invoke/VarHandle$AccessDescriptor;)J", "static final")]
	public static long guard_JJ_J(Dova.JDK.java.lang.invoke.VarHandle arg0, long arg1, long arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[36], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;JLjava/lang/invoke/VarHandle$AccessDescriptor;)J", "static final")]
	public static long guard_J_J(Dova.JDK.java.lang.invoke.VarHandle arg0, long arg1, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg2)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/invoke/VarHandle$AccessDescriptor;)F", "static final")]
	public static float guard__F(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg1)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[38], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;FLjava/lang/invoke/VarHandle$AccessDescriptor;)V", "static final")]
	public static void guard_F_V(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;FFLjava/lang/invoke/VarHandle$AccessDescriptor;)Z", "static final")]
	public static bool guard_FF_Z(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1, float arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;FFLjava/lang/invoke/VarHandle$AccessDescriptor;)F", "static final")]
	public static float guard_FF_F(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1, float arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;FLjava/lang/invoke/VarHandle$AccessDescriptor;)F", "static final")]
	public static float guard_F_F(Dova.JDK.java.lang.invoke.VarHandle arg0, float arg1, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg2)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/invoke/VarHandle$AccessDescriptor;)D", "static final")]
	public static double guard__D(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg1)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[43], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;DLjava/lang/invoke/VarHandle$AccessDescriptor;)V", "static final")]
	public static void guard_D_V(Dova.JDK.java.lang.invoke.VarHandle arg0, double arg1, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[44], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;DDLjava/lang/invoke/VarHandle$AccessDescriptor;)Z", "static final")]
	public static bool guard_DD_Z(Dova.JDK.java.lang.invoke.VarHandle arg0, double arg1, double arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[45], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;DDLjava/lang/invoke/VarHandle$AccessDescriptor;)D", "static final")]
	public static double guard_DD_D(Dova.JDK.java.lang.invoke.VarHandle arg0, double arg1, double arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[46], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;DLjava/lang/invoke/VarHandle$AccessDescriptor;)D", "static final")]
	public static double guard_D_D(Dova.JDK.java.lang.invoke.VarHandle arg0, double arg1, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg2)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[47], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/invoke/VarHandle$AccessDescriptor;)Ljava/lang/Object;", "static final")]
	public static Dova.JDK.java.lang.Object guard_LI_L(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[48], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)V", "static final")]
	public static void guard_LIL_V(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[49], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)Z", "static final")]
	public static bool guard_LILL_Z(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.java.lang.Object arg4, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg5)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[50], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)Ljava/lang/Object;", "static final")]
	public static Dova.JDK.java.lang.Object guard_LILL_L(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.java.lang.Object arg4, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[51], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/Object;Ljava/lang/invoke/VarHandle$AccessDescriptor;)Ljava/lang/Object;", "static final")]
	public static Dova.JDK.java.lang.Object guard_LIL_L(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[52], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IILjava/lang/invoke/VarHandle$AccessDescriptor;)V", "static final")]
	public static void guard_LII_V(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[53], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IIILjava/lang/invoke/VarHandle$AccessDescriptor;)Z", "static final")]
	public static bool guard_LIII_Z(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3, int arg4, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg5)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[54], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IIILjava/lang/invoke/VarHandle$AccessDescriptor;)I", "static final")]
	public static int guard_LIII_I(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3, int arg4, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[55], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/invoke/VarHandle$AccessDescriptor;)J", "static final")]
	public static long guard_LI_J(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[56], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJLjava/lang/invoke/VarHandle$AccessDescriptor;)V", "static final")]
	public static void guard_LIJ_V(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[57], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJLjava/lang/invoke/VarHandle$AccessDescriptor;)Z", "static final")]
	public static bool guard_LIJJ_Z(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, long arg4, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg5)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[58], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJJLjava/lang/invoke/VarHandle$AccessDescriptor;)J", "static final")]
	public static long guard_LIJJ_J(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, long arg4, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg5)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[59], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IJLjava/lang/invoke/VarHandle$AccessDescriptor;)J", "static final")]
	public static long guard_LIJ_J(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, long arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[60], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/invoke/VarHandle$AccessDescriptor;)F", "static final")]
	public static float guard_LI_F(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[61], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFLjava/lang/invoke/VarHandle$AccessDescriptor;)V", "static final")]
	public static void guard_LIF_V(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[62], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFFLjava/lang/invoke/VarHandle$AccessDescriptor;)Z", "static final")]
	public static bool guard_LIFF_Z(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3, float arg4, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg5)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[63], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFFLjava/lang/invoke/VarHandle$AccessDescriptor;)F", "static final")]
	public static float guard_LIFF_F(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3, float arg4, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg5)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[64], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IFLjava/lang/invoke/VarHandle$AccessDescriptor;)F", "static final")]
	public static float guard_LIF_F(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, float arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[65], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;ILjava/lang/invoke/VarHandle$AccessDescriptor;)D", "static final")]
	public static double guard_LI_D(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[66], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IDLjava/lang/invoke/VarHandle$AccessDescriptor;)V", "static final")]
	public static void guard_LID_V(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, double arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[67], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IDDLjava/lang/invoke/VarHandle$AccessDescriptor;)Z", "static final")]
	public static bool guard_LIDD_Z(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, double arg3, double arg4, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg5)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[68], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IDDLjava/lang/invoke/VarHandle$AccessDescriptor;)D", "static final")]
	public static double guard_LIDD_D(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, double arg3, double arg4, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg5)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[69], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;IDLjava/lang/invoke/VarHandle$AccessDescriptor;)D", "static final")]
	public static double guard_LID_D(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, int arg2, double arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[70], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JLjava/lang/invoke/VarHandle$AccessDescriptor;)I", "static final")]
	public static int guard_LJ_I(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[71], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JILjava/lang/invoke/VarHandle$AccessDescriptor;)V", "static final")]
	public static void guard_LJI_V(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[72], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JIILjava/lang/invoke/VarHandle$AccessDescriptor;)Z", "static final")]
	public static bool guard_LJII_Z(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, int arg4, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg5)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[73], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JIILjava/lang/invoke/VarHandle$AccessDescriptor;)I", "static final")]
	public static int guard_LJII_I(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, int arg4, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[74], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JILjava/lang/invoke/VarHandle$AccessDescriptor;)I", "static final")]
	public static int guard_LJI_I(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[75], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JJLjava/lang/invoke/VarHandle$AccessDescriptor;)V", "static final")]
	public static void guard_LJJ_V(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[76], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JJJLjava/lang/invoke/VarHandle$AccessDescriptor;)Z", "static final")]
	public static bool guard_LJJJ_Z(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, long arg4, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg5)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[77], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JJJLjava/lang/invoke/VarHandle$AccessDescriptor;)J", "static final")]
	public static long guard_LJJJ_J(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, long arg4, Dova.JDK.java.lang.invoke.VarHandle.AccessDescriptor arg5)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[78], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}
}
