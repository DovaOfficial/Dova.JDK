/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.java2d.cmm.lcms;

[JniSignatureAttribute("Lsun/java2d/cmm/lcms/LCMS;", "final")]
public partial class LCMS
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.java2d.cmm.PCMM
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LCMS()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/cmm/lcms/LCMS;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "lock", "Ljava/util/concurrent/locks/StampedLock;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "theLcms", "Lsun/java2d/cmm/lcms/LCMS;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LCMS", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getModule", "()Lsun/java2d/cmm/PCMM;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "loadProfileNative", "([BLjava/lang/Object;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getLcmsProfile", "(Lsun/java2d/cmm/Profile;)Lsun/java2d/cmm/lcms/LCMSProfile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createNativeTransform", "([JIIZIZLjava/lang/Object;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setTagDataNative", "(JI[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getProfileDataNative", "(J)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTagNative", "(JI)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getProfileID", "(Ljava/awt/color/ICC_Profile;)Lsun/java2d/cmm/lcms/LCMSProfile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createTransform", "([Lsun/java2d/cmm/ColorTransform;)Lsun/java2d/cmm/ColorTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createTransform", "(Ljava/awt/color/ICC_Profile;II)Lsun/java2d/cmm/ColorTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createTransform", "([Lsun/java2d/cmm/lcms/LCMSProfile;IIZIZLjava/lang/Object;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "colorConvert", "(JIIIIIIZZLjava/lang/Object;Ljava/lang/Object;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "loadProfile", "([B)Lsun/java2d/cmm/Profile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getProfileData", "(Lsun/java2d/cmm/Profile;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTagData", "(Lsun/java2d/cmm/Profile;I)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setTagData", "(Lsun/java2d/cmm/Profile;I[B)V"));
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock;", "private static final")]
	public static Dova.JDK.java.util.concurrent.locks.StampedLock @lock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.StampedLock>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/cmm/lcms/LCMS;", "private static")]
	public static Dova.JDK.sun.java2d.cmm.lcms.LCMS theLcms_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.cmm.lcms.LCMS>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LCMS(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public LCMS() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/cmm/lcms/LCMS;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/java2d/cmm/PCMM;", "static synchronized")]
	public static Dova.JDK.sun.java2d.cmm.PCMM getModule()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.cmm.PCMM>(ret);
	}

	[JniSignatureAttribute("([BLjava/lang/Object;)J", "private static native")]
	public static long loadProfileNative(JavaArray<byte> arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/cmm/Profile;)Lsun/java2d/cmm/lcms/LCMSProfile;", "private static")]
	public static Dova.JDK.sun.java2d.cmm.lcms.LCMSProfile getLcmsProfile(Dova.JDK.sun.java2d.cmm.Profile arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.cmm.lcms.LCMSProfile>(ret);
	}

	[JniSignatureAttribute("([JIIZIZLjava/lang/Object;)J", "private static native")]
	public static long createNativeTransform(JavaArray<long> arg0, int arg1, int arg2, bool arg3, int arg4, bool arg5, Dova.JDK.java.lang.Object arg6)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(JI[B)V", "static native")]
	public static void setTagDataNative(long arg0, int arg1, JavaArray<byte> arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J)[B", "static native")]
	public static JavaArray<byte> getProfileDataNative(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(JI)[B", "static native")]
	public static JavaArray<byte> getTagNative(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/color/ICC_Profile;)Lsun/java2d/cmm/lcms/LCMSProfile;", "static synchronized native")]
	public static Dova.JDK.sun.java2d.cmm.lcms.LCMSProfile getProfileID(Dova.JDK.java.awt.color.ICC_Profile arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.cmm.lcms.LCMSProfile>(ret);
	}

	[JniSignatureAttribute("([Lsun/java2d/cmm/ColorTransform;)Lsun/java2d/cmm/ColorTransform;", "public synchronized")]
	public Dova.JDK.sun.java2d.cmm.ColorTransform createTransform(JavaArray<Dova.JDK.sun.java2d.cmm.ColorTransform> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.cmm.ColorTransform>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/color/ICC_Profile;II)Lsun/java2d/cmm/ColorTransform;", "public")]
	public Dova.JDK.sun.java2d.cmm.ColorTransform createTransform(Dova.JDK.java.awt.color.ICC_Profile arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.cmm.ColorTransform>(ret);
	}

	[JniSignatureAttribute("([Lsun/java2d/cmm/lcms/LCMSProfile;IIZIZLjava/lang/Object;)J", "static")]
	public static long createTransform(JavaArray<Dova.JDK.sun.java2d.cmm.lcms.LCMSProfile> arg0, int arg1, int arg2, bool arg3, int arg4, bool arg5, Dova.JDK.java.lang.Object arg6)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(JIIIIIIZZLjava/lang/Object;Ljava/lang/Object;II)V", "static native")]
	public static void colorConvert(long arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, bool arg7, bool arg8, Dova.JDK.java.lang.Object arg9, Dova.JDK.java.lang.Object arg10, int arg11, int arg12)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
	}

	[JniSignatureAttribute("([B)Lsun/java2d/cmm/Profile;", "public")]
	public Dova.JDK.sun.java2d.cmm.Profile loadProfile(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.cmm.Profile>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/cmm/Profile;)[B", "public")]
	public JavaArray<byte> getProfileData(Dova.JDK.sun.java2d.cmm.Profile arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/cmm/Profile;I)[B", "public")]
	public JavaArray<byte> getTagData(Dova.JDK.sun.java2d.cmm.Profile arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/cmm/Profile;I[B)V", "public")]
	public void setTagData(Dova.JDK.sun.java2d.cmm.Profile arg0, int arg1, JavaArray<byte> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}
}
