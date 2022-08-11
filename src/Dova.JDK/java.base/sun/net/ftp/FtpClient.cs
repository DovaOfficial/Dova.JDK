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

namespace Dova.JDK.sun.net.ftp;

[JniSignatureAttribute("Lsun/net/ftp/FtpClient;", "public abstract")]
public partial class FtpClient
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Closeable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FtpClient()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/ftp/FtpClient;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FTP_PORT", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "list", "(Ljava/lang/String;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connect", "(Ljava/net/SocketAddress;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connect", "(Ljava/net/SocketAddress;I)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "(Ljava/lang/String;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "()Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/net/InetSocketAddress;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/lang/String;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFile", "(Ljava/lang/String;Ljava/io/OutputStream;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allocate", "(J)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rename", "(Ljava/lang/String;Ljava/lang/String;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listFiles", "(Ljava/lang/String;)Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastModified", "(Ljava/lang/String;)Ljava/util/Date;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeDirectory", "(Ljava/lang/String;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "abort", "()Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConnected", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reInit", "()Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putFileStream", "(Ljava/lang/String;)Ljava/io/OutputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putFileStream", "(Ljava/lang/String;Z)Ljava/io/OutputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putFile", "(Ljava/lang/String;Ljava/io/InputStream;)Lsun/net/ftp/FtpClient;"));
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
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBinaryType", "()Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAsciiType", "()Lsun/net/ftp/FtpClient;"));
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
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setConnectTimeout", "(I)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConnectTimeout", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setReadTimeout", "(I)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReadTimeout", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "defaultPort", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "login", "(Ljava/lang/String;[C)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "login", "(Ljava/lang/String;[CLjava/lang/String;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nameList", "(Ljava/lang/String;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProxy", "()Ljava/net/Proxy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setProxy", "(Ljava/net/Proxy;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeDirectory", "(Ljava/lang/String;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteFile", "(Ljava/lang/String;)Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeToParentDirectory", "()Lsun/net/ftp/FtpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType", "(Lsun/net/ftp/FtpClient$TransferType;)Lsun/net/ftp/FtpClient;"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int FTP_PORT_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FtpClient(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public FtpClient() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/ftp/FtpClient;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/InputStream;", "public abstract")]
	public Dova.JDK.java.io.InputStream list(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient connect(Dova.JDK.java.net.SocketAddress arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;I)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient connect(Dova.JDK.java.net.SocketAddress arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)J", "public abstract")]
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

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;)Lsun/net/ftp/FtpClient;", "public static")]
	public static Dova.JDK.sun.net.ftp.FtpClient create(Dova.JDK.java.net.InetSocketAddress arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ftp/FtpClient;", "public static")]
	public static Dova.JDK.sun.net.ftp.FtpClient create(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/OutputStream;)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient getFile(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.OutputStream arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(J)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient allocate(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient rename(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Iterator;", "public abstract")]
	public Dova.JDK.java.util.Iterator listFiles(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Date;", "public abstract")]
	public Dova.JDK.java.util.Date getLastModified(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Date>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient makeDirectory(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient abort()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool isConnected()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient reInit()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/OutputStream;", "public")]
	public Dova.JDK.java.io.OutputStream putFileStream(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)Ljava/io/OutputStream;", "public abstract")]
	public Dova.JDK.java.io.OutputStream putFileStream(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;)Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient putFile(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;Z)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient putFile(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Z)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient enablePassiveMode(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool isPassiveModeEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/net/SocketAddress;", "public abstract")]
	public Dova.JDK.java.net.SocketAddress getServerAddress()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool isLoggedIn()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getWorkingDirectory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(J)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient setRestartOffset(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/InputStream;", "public abstract")]
	public Dova.JDK.java.io.InputStream getFileStream(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient appendFile(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient removeDirectory(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient noop()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	public Dova.JDK.java.util.List getFeatures()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient completePending()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient setBinaryType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public")]
	public Dova.JDK.sun.net.ftp.FtpClient setAsciiType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Lsun/net/ftp/FtpDirParser;)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient setDirParser(Dova.JDK.sun.net.ftp.FtpDirParser arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient useKerberos()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getWelcomeMsg()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpReplyCode;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpReplyCode getLastReplyCode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpReplyCode>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getLastResponseString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()J", "public abstract")]
	public long getLastTransferSize()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[40]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getLastFileName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient startSecureSession()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient endSecureSession()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient structureMount(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getSystem()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getHelp(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient siteCmd(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getStatus(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient setConnectTimeout(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int getConnectTimeout()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[50]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient setReadTimeout(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int getReadTimeout()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[52]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public static final")]
	public static int defaultPort()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[53]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;[C)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient login(Dova.JDK.java.lang.String arg0, JavaArray<char> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[CLjava/lang/String;)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient login(Dova.JDK.java.lang.String arg0, JavaArray<char> arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/InputStream;", "public abstract")]
	public Dova.JDK.java.io.InputStream nameList(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/Proxy;", "public abstract")]
	public Dova.JDK.java.net.Proxy getProxy()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.Proxy>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/Proxy;)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient setProxy(Dova.JDK.java.net.Proxy arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient changeDirectory(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient deleteFile(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient changeToParentDirectory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("(Lsun/net/ftp/FtpClient$TransferType;)Lsun/net/ftp/FtpClient;", "public abstract")]
	public Dova.JDK.sun.net.ftp.FtpClient setType(Dova.JDK.sun.net.ftp.FtpClient.TransferType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient>(ret);
	}

	[JniSignatureAttribute("Lsun/net/ftp/FtpClient$TransferType;", "public static final")]
	public partial class TransferType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TransferType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/ftp/FtpClient$TransferType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASCII", "Lsun/net/ftp/FtpClient$TransferType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BINARY", "Lsun/net/ftp/FtpClient$TransferType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EBCDIC", "Lsun/net/ftp/FtpClient$TransferType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/net/ftp/FtpClient$TransferType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/net/ftp/FtpClient$TransferType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/net/ftp/FtpClient$TransferType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/net/ftp/FtpClient$TransferType;"));
		}

		[JniSignatureAttribute("Lsun/net/ftp/FtpClient$TransferType;", "public static final")]
		public static Dova.JDK.sun.net.ftp.FtpClient.TransferType ASCII_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient.TransferType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/net/ftp/FtpClient$TransferType;", "public static final")]
		public static Dova.JDK.sun.net.ftp.FtpClient.TransferType BINARY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient.TransferType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/net/ftp/FtpClient$TransferType;", "public static final")]
		public static Dova.JDK.sun.net.ftp.FtpClient.TransferType EBCDIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient.TransferType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lsun/net/ftp/FtpClient$TransferType;", "private static final")]
		public static JavaArray<Dova.JDK.sun.net.ftp.FtpClient.TransferType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.net.ftp.FtpClient.TransferType>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TransferType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public TransferType(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/net/ftp/FtpClient$TransferType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/net/ftp/FtpClient$TransferType;", "public static")]
		public static JavaArray<Dova.JDK.sun.net.ftp.FtpClient.TransferType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.net.ftp.FtpClient.TransferType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ftp/FtpClient$TransferType;", "public static")]
		public static Dova.JDK.sun.net.ftp.FtpClient.TransferType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpClient.TransferType>(ret);
		}

		[JniSignatureAttribute("()[Lsun/net/ftp/FtpClient$TransferType;", "private static")]
		public static JavaArray<Dova.JDK.sun.net.ftp.FtpClient.TransferType> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.net.ftp.FtpClient.TransferType>>(ret);
		}
	}
}
