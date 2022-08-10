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

namespace Dova.JDK.jdk.@internal.reflect;

[JniSignatureAttribute("Ljdk/internal/reflect/MethodHandleObjectFieldAccessorImpl;", "")]
public partial class MethodHandleObjectFieldAccessorImpl
	: Dova.JDK.jdk.@internal.reflect.MethodHandleFieldAccessorImpl
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodHandleObjectFieldAccessorImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/reflect/MethodHandleObjectFieldAccessorImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MethodHandleObjectFieldAccessorImpl", "(Ljava/lang/reflect/Field;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;ZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBoolean", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getByte", "(Ljava/lang/Object;)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getShort", "(Ljava/lang/Object;)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getChar", "(Ljava/lang/Object;)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getInt", "(Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLong", "(Ljava/lang/Object;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFloat", "(Ljava/lang/Object;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDouble", "(Ljava/lang/Object;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "set", "(Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "fieldAccessor", "(Ljava/lang/reflect/Field;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Z)Ljdk/internal/reflect/FieldAccessorImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setBoolean", "(Ljava/lang/Object;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setByte", "(Ljava/lang/Object;B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setChar", "(Ljava/lang/Object;C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setShort", "(Ljava/lang/Object;S)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setInt", "(Ljava/lang/Object;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setLong", "(Ljava/lang/Object;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setFloat", "(Ljava/lang/Object;F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDouble", "(Ljava/lang/Object;D)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MethodHandleObjectFieldAccessorImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;ZZ)V", "")]
	public MethodHandleObjectFieldAccessorImpl(Dova.JDK.java.lang.reflect.Field arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2, bool arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/reflect/MethodHandleObjectFieldAccessorImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object get(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool getBoolean(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)B", "public")]
	public byte getByte(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)S", "public")]
	public short getShort(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)C", "public")]
	public char getChar(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)I", "public")]
	public int getInt(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)J", "public")]
	public long getLong(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)F", "public")]
	public float getFloat(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)D", "public")]
	public double getDouble(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)V", "public")]
	public void set(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Z)Ljdk/internal/reflect/FieldAccessorImpl;", "static")]
	public static Dova.JDK.jdk.@internal.reflect.FieldAccessorImpl fieldAccessor(Dova.JDK.java.lang.reflect.Field arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.FieldAccessorImpl>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Z)V", "public")]
	public void setBoolean(Dova.JDK.java.lang.Object arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;B)V", "public")]
	public void setByte(Dova.JDK.java.lang.Object arg0, byte arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;C)V", "public")]
	public void setChar(Dova.JDK.java.lang.Object arg0, char arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;S)V", "public")]
	public void setShort(Dova.JDK.java.lang.Object arg0, short arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)V", "public")]
	public void setInt(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)V", "public")]
	public void setLong(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;F)V", "public")]
	public void setFloat(Dova.JDK.java.lang.Object arg0, float arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;D)V", "public")]
	public void setDouble(Dova.JDK.java.lang.Object arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
	}
}
