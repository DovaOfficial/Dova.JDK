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

namespace Dova.JDK.sun.net.ftp.impl;

[JniSignatureAttribute("Lsun/net/ftp/impl/FtpClient;", "public")]
public partial class FtpClient
	: Dova.JDK.sun.net.ftp.FtpClient
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FtpClient()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/ftp/impl/FtpClient;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultSoTimeout", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultConnectTimeout", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "logger", "Lsun/util/logging/PlatformLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "proxy", "Ljava/net/Proxy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "server", "Ljava/net/Socket;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "out", "Ljava/io/PrintStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "in", "Ljava/io/InputStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readTimeout", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "connectTimeout", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "encoding", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serverAddr", "Ljava/net/InetSocketAddress;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "replyPending", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loggedIn", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "useCrypto", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sslFact", "Ljavax/net/ssl/SSLSocketFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "oldSocket", "Ljava/net/Socket;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serverResponse", "Ljava/util/Vector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastReplyCode", "Lsun/net/ftp/FtpReplyCode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "welcomeMsg", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "passiveMode", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lsun/net/ftp/FtpClient$TransferType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "restartOffset", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastTransSize", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastFileName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "patStrings", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "patternGroups", "[[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "patterns", "[Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "linkp", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "df", "Ljava/text/DateFormat;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "acceptPasvAddressVal", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parser", "Lsun/net/ftp/FtpDirParser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mlsxParser", "Lsun/net/ftp/FtpDirParser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "transPat", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "epsvPat", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "pasvPat", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERROR_MSG", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RFC3659_DATETIME_FORMAT", "Ljava/time/format/DateTimeFormatter;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "list", "(Ljava/lang/String;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connect", "(Ljava/net/SocketAddress;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connect", "(Ljava/net/SocketAddress;I)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "(Ljava/lang/String;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "()Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFile", "(Ljava/lang/String;Ljava/io/OutputStream;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allocate", "(J)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rename", "(Ljava/lang/String;Ljava/lang/String;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listFiles", "(Ljava/lang/String;)Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastModified", "(Ljava/lang/String;)Ljava/util/Date;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeDirectory", "(Ljava/lang/String;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "abort", "()Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConnected", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "disconnect", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reInit", "()Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putFileStream", "(Ljava/lang/String;Z)Ljava/io/OutputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putFile", "(Ljava/lang/String;Ljava/io/InputStream;Z)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "enablePassiveMode", "(Z)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPassiveModeEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServerAddress", "()Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLoggedIn", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWorkingDirectory", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRestartOffset", "(J)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileStream", "(Ljava/lang/String;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendFile", "(Ljava/lang/String;Ljava/io/InputStream;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeDirectory", "(Ljava/lang/String;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "noop", "()Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFeatures", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completePending", "()Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDirParser", "(Lsun/net/ftp/FtpDirParser;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "useKerberos", "()Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWelcomeMsg", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastReplyCode", "()Lsun/net/ftp/FtpReplyCode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastResponseString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastTransferSize", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastFileName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startSecureSession", "()Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endSecureSession", "()Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "structureMount", "(Ljava/lang/String;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSystem", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHelp", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "siteCmd", "(Ljava/lang/String;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatus", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doConnect", "(Ljava/net/InetSocketAddress;I)Ljava/net/Socket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isASCIISuperset", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setConnectTimeout", "(I)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConnectTimeout", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setReadTimeout", "(I)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReadTimeout", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryConnect", "(Ljava/net/InetSocketAddress;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readReply", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "login", "(Ljava/lang/String;[C)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "login", "(Ljava/lang/String;[CLjava/lang/String;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nameList", "(Ljava/lang/String;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProxy", "()Ljava/net/Proxy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setProxy", "(Ljava/net/Proxy;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeDirectory", "(Ljava/lang/String;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createOutputStream", "(Ljava/io/OutputStream;)Ljava/io/OutputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteFile", "(Ljava/lang/String;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readServerResponse", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransferName", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendServer", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "issueCommand", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResponseString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "issueCommandCheck", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validatePasvAddress", "(ILjava/lang/String;Ljava/net/InetAddress;)Ljava/net/InetSocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "privilegedLocalHost", "()Ljava/net/InetAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "privilegedGetAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openPassiveDataConnection", "(Ljava/lang/String;)Ljava/net/Socket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryLogin", "(Ljava/lang/String;[C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openDataConnection", "(Ljava/lang/String;)Ljava/net/Socket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransferSize", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResponseStrings", "()Ljava/util/Vector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parseRfc3659TimeValue", "(Ljava/lang/String;)Ljava/util/Date;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendSecurityData", "([B)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSecurityData", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeToParentDirectory", "()Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createInputStream", "(Ljava/io/InputStream;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType", "(Lsun/net/ftp/FtpClient$TransferType;)Lsun/net/ftp/FtpClient;"));
	}

	[JniSignatureAttribute("I", "private static")]
	public static int defaultSoTimeout_Property
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

	[JniSignatureAttribute("I", "private static")]
	public static int defaultConnectTimeout_Property
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

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static final")]
	public static Dova.JDK.sun.util.logging.PlatformLogger logger_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/Proxy;", "private")]
	public Dova.JDK.java.net.Proxy proxy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.Proxy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/Socket;", "private")]
	public Dova.JDK.java.net.Socket server_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.Socket>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/PrintStream;", "private")]
	public Dova.JDK.java.io.PrintStream @out_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/InputStream;", "private")]
	public Dova.JDK.java.io.InputStream @in_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int readTimeout_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int connectTimeout_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String encoding_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/InetSocketAddress;", "private")]
	public Dova.JDK.java.net.InetSocketAddress serverAddr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetSocketAddress>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool replyPending_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool loggedIn_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool useCrypto_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Ljavax/net/ssl/SSLSocketFactory;", "private")]
	public Dova.JDK.javax.net.ssl.SSLSocketFactory sslFact_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSocketFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/Socket;", "private")]
	public Dova.JDK.java.net.Socket oldSocket_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.Socket>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "private")]
	public Dova.JDK.java.util.Vector serverResponse_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpReplyCode;", "private")]
	public Dova.JDK.sun.net.ftp.FtpReplyCode lastReplyCode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String welcomeMsg_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool passiveMode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpClient$TransferType;", "private")]
	public Dova.JDK.sun.net.ftp.FtpClient.TransferType type_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient.TransferType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long restartOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long lastTransSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String lastFileName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.String> patStrings_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[I", "private static")]
	public static JavaArray<JavaArray<int>> patternGroups_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<int>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/util/regex/Pattern;", "private static")]
	public static JavaArray<Dova.JDK.java.util.regex.Pattern> patterns_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.regex.Pattern>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static")]
	public static Dova.JDK.java.util.regex.Pattern linkp_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/text/DateFormat;", "private")]
	public Dova.JDK.java.text.DateFormat df_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.text.DateFormat>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool acceptPasvAddressVal_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpDirParser;", "private")]
	public Dova.JDK.sun.net.ftp.FtpDirParser parser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpDirParser>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpDirParser;", "private")]
	public Dova.JDK.sun.net.ftp.FtpDirParser mlsxParser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpDirParser>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static")]
	public static Dova.JDK.java.util.regex.Pattern transPat_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static")]
	public static Dova.JDK.java.util.regex.Pattern epsvPat_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static")]
	public static Dova.JDK.java.util.regex.Pattern pasvPat_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String ERROR_MSG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "private static final")]
	public static Dova.JDK.java.time.format.DateTimeFormatter RFC3659_DATETIME_FORMAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FtpClient(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public FtpClient() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/ftp/impl/FtpClient;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream list(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient connect(Dova.JDK.java.net.SocketAddress arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;I)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient connect(Dova.JDK.java.net.SocketAddress arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)J", "public")]
	public long getSize(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public static")]
	public static Dova.JDK.sun.net.ftp.FtpClient create()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/OutputStream;)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient getFile(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.OutputStream arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(J)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient allocate(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient rename(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Iterator;", "public")]
	public Dova.JDK.java.util.Iterator listFiles(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Date;", "public")]
	public Dova.JDK.java.util.Date getLastModified(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Date>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient makeDirectory(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient abort()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isConnected()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void disconnect()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient reInit()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)Ljava/io/OutputStream;", "public")]
	public Dova.JDK.java.io.OutputStream putFileStream(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;Z)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient putFile(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Z)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient enablePassiveMode(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isPassiveModeEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/net/SocketAddress;", "public")]
	public Dova.JDK.java.net.SocketAddress getServerAddress()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isLoggedIn()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getWorkingDirectory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(J)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient setRestartOffset(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream getFileStream(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient appendFile(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient removeDirectory(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient noop()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getFeatures()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient completePending()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Lsun/net/ftp/FtpDirParser;)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient setDirParser(Dova.JDK.sun.net.ftp.FtpDirParser arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient useKerberos()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getWelcomeMsg()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpReplyCode;", "public")]
	public Dova.JDK.sun.net.ftp.FtpReplyCode getLastReplyCode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getLastResponseString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getLastTransferSize()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[35]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getLastFileName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient startSecureSession()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient endSecureSession()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient structureMount(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getSystem()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getHelp(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient siteCmd(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getStatus(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;I)Ljava/net/Socket;", "private")]
	public Dova.JDK.java.net.Socket doConnect(Dova.JDK.java.net.InetSocketAddress arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.Socket>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private static")]
	public static bool isASCIISuperset(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[45], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient setConnectTimeout(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getConnectTimeout()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[47]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient setReadTimeout(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getReadTimeout()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[49]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;I)V", "private")]
	public void tryConnect(Dova.JDK.java.net.InetSocketAddress arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool readReply()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[51]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;[C)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient login(Dova.JDK.java.lang.String arg0, JavaArray<char> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[CLjava/lang/String;)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient login(Dova.JDK.java.lang.String arg0, JavaArray<char> arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream nameList(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/Proxy;", "public")]
	public Dova.JDK.java.net.Proxy getProxy()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.Proxy>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/Proxy;)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient setProxy(Dova.JDK.java.net.Proxy arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient changeDirectory(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/OutputStream;)Ljava/io/OutputStream;", "private")]
	public Dova.JDK.java.io.OutputStream createOutputStream(Dova.JDK.java.io.OutputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient deleteFile(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()I", "private")]
	public int readServerResponse()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[60]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void getTransferName()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public void sendServer(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool issueCommand(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getResponseString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public void issueCommandCheck(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/net/InetAddress;)Ljava/net/InetSocketAddress;", "private")]
	public Dova.JDK.java.net.InetSocketAddress validatePasvAddress(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.net.InetAddress arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetSocketAddress>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/InetAddress;", "private static")]
	public static Dova.JDK.java.net.InetAddress privilegedLocalHost()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[67]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetAddress>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Ljava/net/InetAddress;", "private static")]
	public static JavaArray<Dova.JDK.java.net.InetAddress> privilegedGetAllByName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[68], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.InetAddress>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/Socket;", "private")]
	public Dova.JDK.java.net.Socket openPassiveDataConnection(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.Socket>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[C)V", "private")]
	public void tryLogin(Dova.JDK.java.lang.String arg0, JavaArray<char> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/Socket;", "private")]
	public Dova.JDK.java.net.Socket openDataConnection(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.Socket>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void getTransferSize()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[72]);
	}

	[JniSignatureAttribute("()Ljava/util/Vector;", "private")]
	public Dova.JDK.java.util.Vector getResponseStrings()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Date;", "private static")]
	public static Dova.JDK.java.util.Date parseRfc3659TimeValue(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[74], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Date>(ret);
	}

	[JniSignatureAttribute("([B)Z", "private")]
	public bool sendSecurityData(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[75], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[B", "private")]
	public JavaArray<byte> getSecurityData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient changeToParentDirectory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljava/io/InputStream;", "private")]
	public Dova.JDK.java.io.InputStream createInputStream(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Lsun/net/ftp/FtpClient$TransferType;)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient setType(Dova.JDK.sun.net.ftp.FtpClient.TransferType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("Lsun/net/ftp/impl/FtpClient$DefaultParser;", "private")]
	public partial class DefaultParser
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.net.ftp.FtpDirParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/ftp/impl/FtpClient$DefaultParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/net/ftp/impl/FtpClient;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/net/ftp/impl/FtpClient;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseLine", "(Ljava/lang/String;)Lsun/net/ftp/FtpDirEntry;"));
		}

		[JniSignatureAttribute("Lsun/net/ftp/impl/FtpClient;", "final")]
		public Dova.JDK.sun.net.ftp.impl.FtpClient this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.impl.FtpClient>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/net/ftp/impl/FtpClient;)V", "private")]
		public DefaultParser(Dova.JDK.sun.net.ftp.impl.FtpClient arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/net/ftp/impl/FtpClient$DefaultParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ftp/FtpDirEntry;", "public")]
		public Dova.JDK.sun.net.ftp.FtpDirEntry parseLine(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpDirEntry>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/net/ftp/impl/FtpClient$MLSxParser;", "private static")]
	public partial class MLSxParser
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.net.ftp.FtpDirParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MLSxParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/ftp/impl/FtpClient$MLSxParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseLine", "(Ljava/lang/String;)Lsun/net/ftp/FtpDirEntry;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MLSxParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public MLSxParser() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/net/ftp/impl/FtpClient$MLSxParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ftp/FtpDirEntry;", "public")]
		public Dova.JDK.sun.net.ftp.FtpDirEntry parseLine(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpDirEntry>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/net/ftp/impl/FtpClient$FtpFileIterator;", "private static")]
	public partial class FtpFileIterator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Iterator
		, Dova.JDK.java.io.Closeable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FtpFileIterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/ftp/impl/FtpClient$FtpFileIterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "in", "Ljava/io/BufferedReader;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextFile", "Lsun/net/ftp/FtpDirEntry;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fparser", "Lsun/net/ftp/FtpDirParser;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eof", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/net/ftp/FtpDirParser;Ljava/io/BufferedReader;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNext", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_1", "()Lsun/net/ftp/FtpDirEntry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readNext", "()V"));
		}

		[JniSignatureAttribute("Ljava/io/BufferedReader;", "private")]
		public Dova.JDK.java.io.BufferedReader @in_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.BufferedReader>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/net/ftp/FtpDirEntry;", "private")]
		public Dova.JDK.sun.net.ftp.FtpDirEntry nextFile_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpDirEntry>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/net/ftp/FtpDirParser;", "private")]
		public Dova.JDK.sun.net.ftp.FtpDirParser fparser_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpDirParser>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool eof_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FtpFileIterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/net/ftp/FtpDirParser;Ljava/io/BufferedReader;)V", "public")]
		public FtpFileIterator(Dova.JDK.sun.net.ftp.FtpDirParser arg0, Dova.JDK.java.io.BufferedReader arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/net/ftp/impl/FtpClient$FtpFileIterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void remove()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasNext()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object next_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lsun/net/ftp/FtpDirEntry;", "public")]
		public Dova.JDK.sun.net.ftp.FtpDirEntry next_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpDirEntry>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("()V", "private")]
		public void readNext()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}
	}
}
