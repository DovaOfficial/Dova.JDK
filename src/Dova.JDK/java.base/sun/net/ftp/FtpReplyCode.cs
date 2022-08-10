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

namespace Dova.JDK.sun.net.ftp;

[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public final")]
public partial class FtpReplyCode
	: Dova.JDK.java.lang.Enum
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FtpReplyCode()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/ftp/FtpReplyCode;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RESTART_MARKER", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SERVICE_READY_IN", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DATA_CONNECTION_ALREADY_OPEN", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FILE_STATUS_OK", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COMMAND_OK", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NOT_IMPLEMENTED", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SYSTEM_STATUS", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DIRECTORY_STATUS", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FILE_STATUS", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HELP_MESSAGE", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NAME_SYSTEM_TYPE", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SERVICE_READY", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SERVICE_CLOSING", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DATA_CONNECTION_OPEN", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CLOSING_DATA_CONNECTION", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENTERING_PASSIVE_MODE", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENTERING_EXT_PASSIVE_MODE", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LOGGED_IN", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SECURELY_LOGGED_IN", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SECURITY_EXCHANGE_OK", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SECURITY_EXCHANGE_COMPLETE", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FILE_ACTION_OK", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PATHNAME_CREATED", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NEED_PASSWORD", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NEED_ACCOUNT", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NEED_ADAT", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NEED_MORE_ADAT", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FILE_ACTION_PENDING", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SERVICE_NOT_AVAILABLE", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CANT_OPEN_DATA_CONNECTION", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CONNECTION_CLOSED", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NEED_SECURITY_RESOURCE", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FILE_ACTION_NOT_TAKEN", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ACTION_ABORTED", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INSUFFICIENT_STORAGE", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COMMAND_UNRECOGNIZED", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INVALID_PARAMETER", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BAD_SEQUENCE", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NOT_IMPLEMENTED_FOR_PARAMETER", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NOT_LOGGED_IN", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NEED_ACCOUNT_FOR_STORING", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PROT_LEVEL_DENIED", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "REQUEST_DENIED", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FAILED_SECURITY_CHECK", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "UNSUPPORTED_PROT_LEVEL", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PROT_LEVEL_NOT_SUPPORTED_BY_SECURITY", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FILE_UNAVAILABLE", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PAGE_TYPE_UNKNOWN", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXCEEDED_STORAGE", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FILE_NAME_NOT_ALLOWED", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PROTECTED_REPLY", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "UNKNOWN_ERROR", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "value", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lsun/net/ftp/FtpReplyCode;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FtpReplyCode", "(Ljava/lang/String;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lsun/net/ftp/FtpReplyCode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lsun/net/ftp/FtpReplyCode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getValue", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "find", "(I)Lsun/net/ftp/FtpReplyCode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lsun/net/ftp/FtpReplyCode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isPositivePreliminary", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isPositiveCompletion", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isPositiveIntermediate", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isTransientNegative", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isPermanentNegative", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isProtectedReply", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isSyntax", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isInformation", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isConnection", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isAuthentication", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isUnspecified", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isFileSystem", "()Z"));
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode RESTART_MARKER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode SERVICE_READY_IN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode DATA_CONNECTION_ALREADY_OPEN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode FILE_STATUS_OK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode COMMAND_OK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode NOT_IMPLEMENTED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode SYSTEM_STATUS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode DIRECTORY_STATUS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode FILE_STATUS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode HELP_MESSAGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode NAME_SYSTEM_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode SERVICE_READY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode SERVICE_CLOSING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode DATA_CONNECTION_OPEN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode CLOSING_DATA_CONNECTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode ENTERING_PASSIVE_MODE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode ENTERING_EXT_PASSIVE_MODE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode LOGGED_IN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode SECURELY_LOGGED_IN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode SECURITY_EXCHANGE_OK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode SECURITY_EXCHANGE_COMPLETE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode FILE_ACTION_OK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode PATHNAME_CREATED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode NEED_PASSWORD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode NEED_ACCOUNT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode NEED_ADAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode NEED_MORE_ADAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode FILE_ACTION_PENDING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode SERVICE_NOT_AVAILABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode CANT_OPEN_DATA_CONNECTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode CONNECTION_CLOSED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode NEED_SECURITY_RESOURCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode FILE_ACTION_NOT_TAKEN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode ACTION_ABORTED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode INSUFFICIENT_STORAGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode COMMAND_UNRECOGNIZED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode INVALID_PARAMETER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode BAD_SEQUENCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode NOT_IMPLEMENTED_FOR_PARAMETER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode NOT_LOGGED_IN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode NEED_ACCOUNT_FOR_STORING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode PROT_LEVEL_DENIED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode REQUEST_DENIED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode FAILED_SECURITY_CHECK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode UNSUPPORTED_PROT_LEVEL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode PROT_LEVEL_NOT_SUPPORTED_BY_SECURITY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode FILE_UNAVAILABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode PAGE_TYPE_UNKNOWN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode EXCEEDED_STORAGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode FILE_NAME_NOT_ALLOWED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode PROTECTED_REPLY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "public static final")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode UNKNOWN_ERROR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private final")]
	public int value_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[52]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[52], value);
	}

	[JniSignatureAttribute("[Lsun/net/ftp/FtpReplyCode;", "private static final")]
	public static JavaArray<Dova.JDK.sun.net.ftp.FtpReplyCode> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.net.ftp.FtpReplyCode>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FtpReplyCode(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
	public FtpReplyCode(Dova.JDK.java.lang.String arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/ftp/FtpReplyCode;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lsun/net/ftp/FtpReplyCode;", "public static")]
	public static JavaArray<Dova.JDK.sun.net.ftp.FtpReplyCode> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.net.ftp.FtpReplyCode>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ftp/FtpReplyCode;", "public static")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getValue()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lsun/net/ftp/FtpReplyCode;", "public static")]
	public static Dova.JDK.sun.net.ftp.FtpReplyCode find(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
	}

	[JniSignatureAttribute("()[Lsun/net/ftp/FtpReplyCode;", "private static")]
	public static JavaArray<Dova.JDK.sun.net.ftp.FtpReplyCode> _values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.net.ftp.FtpReplyCode>>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isPositivePreliminary()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isPositiveCompletion()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isPositiveIntermediate()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isTransientNegative()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isPermanentNegative()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isProtectedReply()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isSyntax()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isInformation()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isConnection()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isAuthentication()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isUnspecified()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isFileSystem()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}
}
