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

namespace Dova.JDK.jdk.@internal.org.jline.terminal.spi;

[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/spi/JansiSupport;", "public abstract interface")]
public partial interface JansiSupport
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JansiSupport()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/terminal/spi/JansiSupport;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "current", "()Ljdk/internal/org/jline/terminal/spi/Pty;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "open", "(Ljdk/internal/org/jline/terminal/Attributes;Ljdk/internal/org/jline/terminal/Size;)Ljdk/internal/org/jline/terminal/spi/Pty;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWindowsConsole", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "winSysTerminal", "(Ljava/lang/String;Ljava/lang/String;ZLjava/nio/charset/Charset;IZLjdk/internal/org/jline/terminal/Terminal$SignalHandler;Z)Ljdk/internal/org/jline/terminal/Terminal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "winSysTerminal", "(Ljava/lang/String;Ljava/lang/String;ZLjava/nio/charset/Charset;IZLjdk/internal/org/jline/terminal/Terminal$SignalHandler;)Ljdk/internal/org/jline/terminal/Terminal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConsoleInput", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConsoleOutput", "()Z"));
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/terminal/spi/Pty;", "public abstract")]
	Dova.JDK.jdk.@internal.org.jline.terminal.spi.Pty current()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.spi.Pty>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Attributes;Ljdk/internal/org/jline/terminal/Size;)Ljdk/internal/org/jline/terminal/spi/Pty;", "public abstract")]
	Dova.JDK.jdk.@internal.org.jline.terminal.spi.Pty open(Dova.JDK.jdk.@internal.org.jline.terminal.Attributes arg0, Dova.JDK.jdk.@internal.org.jline.terminal.Size arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.spi.Pty>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isWindowsConsole()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;ZLjava/nio/charset/Charset;IZLjdk/internal/org/jline/terminal/Terminal$SignalHandler;Z)Ljdk/internal/org/jline/terminal/Terminal;", "public abstract")]
	Dova.JDK.jdk.@internal.org.jline.terminal.Terminal winSysTerminal(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, bool arg2, Dova.JDK.java.nio.charset.Charset arg3, int arg4, bool arg5, Dova.JDK.jdk.@internal.org.jline.terminal.Terminal.SignalHandler arg6, bool arg7)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Terminal>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;ZLjava/nio/charset/Charset;IZLjdk/internal/org/jline/terminal/Terminal$SignalHandler;)Ljdk/internal/org/jline/terminal/Terminal;", "public abstract")]
	Dova.JDK.jdk.@internal.org.jline.terminal.Terminal winSysTerminal(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, bool arg2, Dova.JDK.java.nio.charset.Charset arg3, int arg4, bool arg5, Dova.JDK.jdk.@internal.org.jline.terminal.Terminal.SignalHandler arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Terminal>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isConsoleInput()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isConsoleOutput()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}
}
