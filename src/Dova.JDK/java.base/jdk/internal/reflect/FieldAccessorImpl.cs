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

namespace Dova.JDK.jdk.@internal.reflect;

[JniSignatureAttribute("Ljdk/internal/reflect/FieldAccessorImpl;", "abstract")]
public partial class FieldAccessorImpl
	: Dova.JDK.jdk.@internal.reflect.MagicAccessorImpl
	, Dova.JDK.jdk.@internal.reflect.FieldAccessor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FieldAccessorImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/reflect/FieldAccessorImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "field", "Ljava/lang/reflect/Field;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Field;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBoolean", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByte", "(Ljava/lang/Object;)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShort", "(Ljava/lang/Object;)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChar", "(Ljava/lang/Object;)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInt", "(Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "(Ljava/lang/Object;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFloat", "(Ljava/lang/Object;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDouble", "(Ljava/lang/Object;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBoolean", "(Ljava/lang/Object;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setByte", "(Ljava/lang/Object;B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setChar", "(Ljava/lang/Object;C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setShort", "(Ljava/lang/Object;S)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInt", "(Ljava/lang/Object;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLong", "(Ljava/lang/Object;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFloat", "(Ljava/lang/Object;F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDouble", "(Ljava/lang/Object;D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwSetIllegalArgumentException", "(C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwSetIllegalArgumentException", "(B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwSetIllegalArgumentException", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwSetIllegalArgumentException", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwSetIllegalArgumentException", "(F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwSetIllegalArgumentException", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwSetIllegalArgumentException", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwSetIllegalArgumentException", "(S)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwSetIllegalArgumentException", "(D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwSetIllegalArgumentException", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getQualifiedFieldName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSetMessage", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwFinalFieldIllegalAccessException", "(B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwFinalFieldIllegalAccessException", "(S)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwFinalFieldIllegalAccessException", "(C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwFinalFieldIllegalAccessException", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwFinalFieldIllegalAccessException", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwFinalFieldIllegalAccessException", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwFinalFieldIllegalAccessException", "(F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwFinalFieldIllegalAccessException", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwFinalFieldIllegalAccessException", "(D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwFinalFieldIllegalAccessException", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newGetIllegalArgumentException", "(Ljava/lang/String;)Ljava/lang/IllegalArgumentException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureObj", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newGetBooleanIllegalArgumentException", "()Ljava/lang/IllegalArgumentException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newGetByteIllegalArgumentException", "()Ljava/lang/IllegalArgumentException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newGetCharIllegalArgumentException", "()Ljava/lang/IllegalArgumentException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newGetShortIllegalArgumentException", "()Ljava/lang/IllegalArgumentException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newGetIntIllegalArgumentException", "()Ljava/lang/IllegalArgumentException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newGetLongIllegalArgumentException", "()Ljava/lang/IllegalArgumentException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newGetFloatIllegalArgumentException", "()Ljava/lang/IllegalArgumentException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newGetDoubleIllegalArgumentException", "()Ljava/lang/IllegalArgumentException;"));
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Field;", "protected final")]
	public Dova.JDK.java.lang.reflect.Field field_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FieldAccessorImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)V", "")]
	public FieldAccessorImpl(Dova.JDK.java.lang.reflect.Field arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/reflect/FieldAccessorImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
	public Dova.JDK.java.lang.Object get(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public abstract")]
	public bool getBoolean(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)B", "public abstract")]
	public byte getByte(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)S", "public abstract")]
	public short getShort(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)C", "public abstract")]
	public char getChar(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)I", "public abstract")]
	public int getInt(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)J", "public abstract")]
	public long getLong(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)F", "public abstract")]
	public float getFloat(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)D", "public abstract")]
	public double getDouble(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)V", "public abstract")]
	public void set(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Z)V", "public abstract")]
	public void setBoolean(Dova.JDK.java.lang.Object arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;B)V", "public abstract")]
	public void setByte(Dova.JDK.java.lang.Object arg0, byte arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;C)V", "public abstract")]
	public void setChar(Dova.JDK.java.lang.Object arg0, char arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;S)V", "public abstract")]
	public void setShort(Dova.JDK.java.lang.Object arg0, short arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)V", "public abstract")]
	public void setInt(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)V", "public abstract")]
	public void setLong(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;F)V", "public abstract")]
	public void setFloat(Dova.JDK.java.lang.Object arg0, float arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;D)V", "public abstract")]
	public void setDouble(Dova.JDK.java.lang.Object arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("(C)V", "protected")]
	public void throwSetIllegalArgumentException(char arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(B)V", "protected")]
	public void throwSetIllegalArgumentException(byte arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Z)V", "protected")]
	public void throwSetIllegalArgumentException(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "protected")]
	public void throwSetIllegalArgumentException(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(F)V", "protected")]
	public void throwSetIllegalArgumentException(float arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(J)V", "protected")]
	public void throwSetIllegalArgumentException(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void throwSetIllegalArgumentException(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(S)V", "protected")]
	public void throwSetIllegalArgumentException(short arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(D)V", "protected")]
	public void throwSetIllegalArgumentException(double arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "protected")]
	public void throwSetIllegalArgumentException(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String getQualifiedFieldName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String getSetMessage(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(B)V", "protected")]
	public void throwFinalFieldIllegalAccessException(byte arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(S)V", "protected")]
	public void throwFinalFieldIllegalAccessException(short arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("(C)V", "protected")]
	public void throwFinalFieldIllegalAccessException(char arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Z)V", "protected")]
	public void throwFinalFieldIllegalAccessException(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "protected")]
	public void throwFinalFieldIllegalAccessException(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void throwFinalFieldIllegalAccessException(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("(F)V", "protected")]
	public void throwFinalFieldIllegalAccessException(float arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(J)V", "protected")]
	public void throwFinalFieldIllegalAccessException(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(D)V", "protected")]
	public void throwFinalFieldIllegalAccessException(double arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "protected")]
	public void throwFinalFieldIllegalAccessException(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/IllegalArgumentException;", "protected")]
	public Dova.JDK.java.lang.IllegalArgumentException newGetIllegalArgumentException(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.IllegalArgumentException>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "protected")]
	public void ensureObj(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/IllegalArgumentException;", "protected")]
	public Dova.JDK.java.lang.IllegalArgumentException newGetBooleanIllegalArgumentException()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.IllegalArgumentException>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/IllegalArgumentException;", "protected")]
	public Dova.JDK.java.lang.IllegalArgumentException newGetByteIllegalArgumentException()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.IllegalArgumentException>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/IllegalArgumentException;", "protected")]
	public Dova.JDK.java.lang.IllegalArgumentException newGetCharIllegalArgumentException()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.IllegalArgumentException>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/IllegalArgumentException;", "protected")]
	public Dova.JDK.java.lang.IllegalArgumentException newGetShortIllegalArgumentException()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.IllegalArgumentException>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/IllegalArgumentException;", "protected")]
	public Dova.JDK.java.lang.IllegalArgumentException newGetIntIllegalArgumentException()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.IllegalArgumentException>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/IllegalArgumentException;", "protected")]
	public Dova.JDK.java.lang.IllegalArgumentException newGetLongIllegalArgumentException()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.IllegalArgumentException>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/IllegalArgumentException;", "protected")]
	public Dova.JDK.java.lang.IllegalArgumentException newGetFloatIllegalArgumentException()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.IllegalArgumentException>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/IllegalArgumentException;", "protected")]
	public Dova.JDK.java.lang.IllegalArgumentException newGetDoubleIllegalArgumentException()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.IllegalArgumentException>(ret);
	}
}
