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

namespace Dova.JDK.sun.security.timestamp;

[JniSignatureAttribute("Lsun/security/timestamp/TSResponse;", "public")]
public partial class TSResponse
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TSResponse()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/timestamp/TSResponse;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GRANTED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GRANTED_WITH_MODS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REJECTION", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WAITING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REVOCATION_WARNING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REVOCATION_NOTIFICATION", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BAD_ALG", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BAD_REQUEST", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BAD_DATA_FORMAT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TIME_NOT_AVAILABLE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNACCEPTED_POLICY", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNACCEPTED_EXTENSION", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ADD_INFO_NOT_AVAILABLE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYSTEM_FAILURE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "debug", "Lsun/security/util/Debug;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "status", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "statusString", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "failureInfo", "[Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "encodedTsToken", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tsToken", "Lsun/security/pkcs/PKCS7;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tstInfo", "Lsun/security/timestamp/TimestampToken;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSet", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getToken", "()Lsun/security/pkcs/PKCS7;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatusCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatusMessages", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFailureInfo", "()[Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatusCodeAsText", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFailureCodeAsText", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimestampToken", "()Lsun/security/timestamp/TimestampToken;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEncodedToken", "()[B"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int GRANTED_Property
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
	public static int GRANTED_WITH_MODS_Property
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
	public static int REJECTION_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int WAITING_Property
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
	public static int REVOCATION_WARNING_Property
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
	public static int REVOCATION_NOTIFICATION_Property
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
	public static int BAD_ALG_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int BAD_REQUEST_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int BAD_DATA_FORMAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int TIME_NOT_AVAILABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int UNACCEPTED_POLICY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int UNACCEPTED_EXTENSION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ADD_INFO_NOT_AVAILABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int SYSTEM_FAILURE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/Debug;", "private static final")]
	public static Dova.JDK.sun.security.util.Debug debug_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.Debug>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int status_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private")]
	public JavaArray<Dova.JDK.java.lang.String> statusString_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Z", "private")]
	public JavaArray<bool> failureInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "private")]
	public JavaArray<byte> encodedTsToken_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs/PKCS7;", "private")]
	public Dova.JDK.sun.security.pkcs.PKCS7 tsToken_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs.PKCS7>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/timestamp/TimestampToken;", "private")]
	public Dova.JDK.sun.security.timestamp.TimestampToken tstInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.timestamp.TimestampToken>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TSResponse(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([B)V", "")]
	public TSResponse(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/timestamp/TSResponse;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)Z", "private")]
	public bool isSet(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("([B)V", "private")]
	public void parse(JavaArray<byte> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Lsun/security/pkcs/PKCS7;", "public")]
	public Dova.JDK.sun.security.pkcs.PKCS7 getToken()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs.PKCS7>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getStatusCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getStatusMessages()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()[Z", "public")]
	public JavaArray<bool> getFailureInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getStatusCodeAsText()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getFailureCodeAsText()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/timestamp/TimestampToken;", "public")]
	public Dova.JDK.sun.security.timestamp.TimestampToken getTimestampToken()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.timestamp.TimestampToken>(ret);
	}

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> getEncodedToken()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("Lsun/security/timestamp/TSResponse$TimestampException;", "static final")]
	public partial class TimestampException
		: Dova.JDK.java.io.IOException
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TimestampException()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/timestamp/TSResponse$TimestampException;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TimestampException(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public TimestampException(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/timestamp/TSResponse$TimestampException;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
