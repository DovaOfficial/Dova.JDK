/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.security.pkcs11.wrapper;

[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception;", "public")]
public partial class PKCS11Exception
	: Dova.JDK.java.lang.Exception
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PKCS11Exception()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/pkcs11/wrapper/PKCS11Exception;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "errorCode", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "errorMsg", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PKCS11Exception", "(JLjava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "lookup", "(J)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMessage", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "match", "(Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getErrorCode", "()J"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("J", "protected")]
	public long errorCode_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String errorMsg_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PKCS11Exception(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(JLjava/lang/String;)V", "public")]
	public PKCS11Exception(long arg0, Dova.JDK.java.lang.String arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/pkcs11/wrapper/PKCS11Exception;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(J)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String lookup(long arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getMessage()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;)Z", "public")]
	public bool match(Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getErrorCode()
	{
		var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
	public partial class RV
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RV()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_OK", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_CANCEL", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_HOST_MEMORY", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_SLOT_ID_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_GENERAL_ERROR", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_FUNCTION_FAILED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_ARGUMENTS_BAD", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_NO_EVENT", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_NEED_TO_CREATE_THREADS", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_CANT_LOCK", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_ATTRIBUTE_READ_ONLY", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_ATTRIBUTE_SENSITIVE", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_ATTRIBUTE_TYPE_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_ATTRIBUTE_VALUE_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_ACTION_PROHIBITED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_DATA_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_DATA_LEN_RANGE", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_DEVICE_ERROR", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_DEVICE_MEMORY", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_DEVICE_REMOVED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_ENCRYPTED_DATA_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_ENCRYPTED_DATA_LEN_RANGE", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_AEAD_DECRYPT_FAILED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_FUNCTION_CANCELED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_FUNCTION_NOT_PARALLEL", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_FUNCTION_NOT_SUPPORTED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_KEY_HANDLE_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_KEY_SIZE_RANGE", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_KEY_TYPE_INCONSISTENT", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_KEY_NOT_NEEDED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_KEY_CHANGED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_KEY_NEEDED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_KEY_INDIGESTIBLE", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_KEY_FUNCTION_NOT_PERMITTED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_KEY_NOT_WRAPPABLE", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_KEY_UNEXTRACTABLE", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_MECHANISM_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_MECHANISM_PARAM_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_OBJECT_HANDLE_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_OPERATION_ACTIVE", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_OPERATION_NOT_INITIALIZED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_PIN_INCORRECT", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_PIN_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_PIN_LEN_RANGE", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_PIN_EXPIRED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_PIN_LOCKED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_SESSION_CLOSED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_SESSION_COUNT", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_SESSION_HANDLE_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_SESSION_PARALLEL_NOT_SUPPORTED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_SESSION_READ_ONLY", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_SESSION_EXISTS", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_SESSION_READ_ONLY_EXISTS", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_SESSION_READ_WRITE_SO_EXISTS", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_SIGNATURE_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_SIGNATURE_LEN_RANGE", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_TEMPLATE_INCOMPLETE", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_TEMPLATE_INCONSISTENT", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_TOKEN_NOT_PRESENT", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_TOKEN_NOT_RECOGNIZED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_TOKEN_WRITE_PROTECTED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_UNWRAPPING_KEY_HANDLE_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_UNWRAPPING_KEY_SIZE_RANGE", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_UNWRAPPING_KEY_TYPE_INCONSISTENT", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_USER_ALREADY_LOGGED_IN", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_USER_NOT_LOGGED_IN", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_USER_PIN_NOT_INITIALIZED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_USER_TYPE_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_USER_ANOTHER_ALREADY_LOGGED_IN", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_USER_TOO_MANY_TYPES", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_WRAPPED_KEY_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_WRAPPED_KEY_LEN_RANGE", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_WRAPPING_KEY_HANDLE_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_WRAPPING_KEY_SIZE_RANGE", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_WRAPPING_KEY_TYPE_INCONSISTENT", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_RANDOM_SEED_NOT_SUPPORTED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_RANDOM_NO_RNG", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_DOMAIN_PARAMS_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_CURVE_NOT_SUPPORTED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_BUFFER_TOO_SMALL", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_SAVED_STATE_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_INFORMATION_SENSITIVE", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_STATE_UNSAVEABLE", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_CRYPTOKI_NOT_INITIALIZED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_CRYPTOKI_ALREADY_INITIALIZED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_MUTEX_BAD", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_MUTEX_NOT_LOCKED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_NEW_PIN_MODE", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_NEXT_OTP", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_EXCEEDED_MAX_ITERATIONS", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_FIPS_SELF_TEST_FAILED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_LIBRARY_LOAD_FAILED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_PIN_TOO_WEAK", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_PUBLIC_KEY_INVALID", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_FUNCTION_REJECTED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_TOKEN_RESOURCE_EXCEEDED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_OPERATION_CANCEL_FAILED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CKR_VENDOR_DEFINED", "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "value", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "RV", "(Ljava/lang/String;IJ)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;"));
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_OK_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_CANCEL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_HOST_MEMORY_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_SLOT_ID_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_GENERAL_ERROR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_FUNCTION_FAILED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_ARGUMENTS_BAD_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_NO_EVENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_NEED_TO_CREATE_THREADS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_CANT_LOCK_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_ATTRIBUTE_READ_ONLY_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_ATTRIBUTE_SENSITIVE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_ATTRIBUTE_TYPE_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_ATTRIBUTE_VALUE_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_ACTION_PROHIBITED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_DATA_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_DATA_LEN_RANGE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_DEVICE_ERROR_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_DEVICE_MEMORY_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_DEVICE_REMOVED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_ENCRYPTED_DATA_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_ENCRYPTED_DATA_LEN_RANGE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_AEAD_DECRYPT_FAILED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_FUNCTION_CANCELED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_FUNCTION_NOT_PARALLEL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_FUNCTION_NOT_SUPPORTED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_KEY_HANDLE_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_KEY_SIZE_RANGE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_KEY_TYPE_INCONSISTENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_KEY_NOT_NEEDED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_KEY_CHANGED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_KEY_NEEDED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_KEY_INDIGESTIBLE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_KEY_FUNCTION_NOT_PERMITTED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_KEY_NOT_WRAPPABLE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_KEY_UNEXTRACTABLE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_MECHANISM_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_MECHANISM_PARAM_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_OBJECT_HANDLE_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_OPERATION_ACTIVE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_OPERATION_NOT_INITIALIZED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_PIN_INCORRECT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_PIN_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_PIN_LEN_RANGE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_PIN_EXPIRED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_PIN_LOCKED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_SESSION_CLOSED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_SESSION_COUNT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_SESSION_HANDLE_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_SESSION_PARALLEL_NOT_SUPPORTED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_SESSION_READ_ONLY_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_SESSION_EXISTS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_SESSION_READ_ONLY_EXISTS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_SESSION_READ_WRITE_SO_EXISTS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_SIGNATURE_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_SIGNATURE_LEN_RANGE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_TEMPLATE_INCOMPLETE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_TEMPLATE_INCONSISTENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_TOKEN_NOT_PRESENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_TOKEN_NOT_RECOGNIZED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_TOKEN_WRITE_PROTECTED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_UNWRAPPING_KEY_HANDLE_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_UNWRAPPING_KEY_SIZE_RANGE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_UNWRAPPING_KEY_TYPE_INCONSISTENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_USER_ALREADY_LOGGED_IN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_USER_NOT_LOGGED_IN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_USER_PIN_NOT_INITIALIZED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_USER_TYPE_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_USER_ANOTHER_ALREADY_LOGGED_IN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_USER_TOO_MANY_TYPES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_WRAPPED_KEY_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_WRAPPED_KEY_LEN_RANGE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_WRAPPING_KEY_HANDLE_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_WRAPPING_KEY_SIZE_RANGE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_WRAPPING_KEY_TYPE_INCONSISTENT_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_RANDOM_SEED_NOT_SUPPORTED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_RANDOM_NO_RNG_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_DOMAIN_PARAMS_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_CURVE_NOT_SUPPORTED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_BUFFER_TOO_SMALL_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_SAVED_STATE_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_INFORMATION_SENSITIVE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_STATE_UNSAVEABLE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[82]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[82], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_CRYPTOKI_NOT_INITIALIZED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[83]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[83], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_CRYPTOKI_ALREADY_INITIALIZED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[84]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[84], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_MUTEX_BAD_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[85]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[85], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_MUTEX_NOT_LOCKED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[86]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[86], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_NEW_PIN_MODE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[87]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[87], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_NEXT_OTP_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[88]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[88], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_EXCEEDED_MAX_ITERATIONS_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[89]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[89], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_FIPS_SELF_TEST_FAILED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[90]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[90], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_LIBRARY_LOAD_FAILED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[91]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[91], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_PIN_TOO_WEAK_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[92]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[92], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_PUBLIC_KEY_INVALID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[93]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[93], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_FUNCTION_REJECTED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[94]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[94], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_TOKEN_RESOURCE_EXCEEDED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[95]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[95], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_OPERATION_CANCEL_FAILED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[96]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[96], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static final")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV CKR_VENDOR_DEFINED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[97]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[97], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("J", "private final")]
		public long value_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[98]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[98], value);
		}

		[JniSignatureAttribute("[Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "private static final")]
		public static JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV> VALUES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[99]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[99], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RV(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;IJ)V", "private")]
		public RV(Dova.JDK.java.lang.String arg0, int arg1, long arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static")]
		public static JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV> values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "public static")]
		public static Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>(ret);
		}

		[JniSignatureAttribute("()[Lsun/security/pkcs11/wrapper/PKCS11Exception$RV;", "private static")]
		public static JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV> _values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11Exception.RV>>(ret);
		}
	}
}
