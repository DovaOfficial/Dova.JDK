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

[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/spi/Pty;", "public abstract interface")]
public partial interface Pty
	: IJavaObject
	, Dova.JDK.java.io.Closeable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Pty()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/terminal/spi/Pty;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "()Ljdk/internal/org/jline/terminal/Size;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSize", "(Ljdk/internal/org/jline/terminal/Size;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAttr", "(Ljdk/internal/org/jline/terminal/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSlaveOutput", "()Ljava/io/OutputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttr", "()Ljdk/internal/org/jline/terminal/Attributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMasterInput", "()Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMasterOutput", "()Ljava/io/OutputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSlaveInput", "()Ljava/io/InputStream;"));
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/terminal/Size;", "public abstract")]
	Dova.JDK.jdk.@internal.org.jline.terminal.Size getSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Size>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Size;)V", "public abstract")]
	void setSize(Dova.JDK.jdk.@internal.org.jline.terminal.Size arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Attributes;)V", "public abstract")]
	void setAttr(Dova.JDK.jdk.@internal.org.jline.terminal.Attributes arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Ljava/io/OutputStream;", "public abstract")]
	Dova.JDK.java.io.OutputStream getSlaveOutput()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/terminal/Attributes;", "public abstract")]
	Dova.JDK.jdk.@internal.org.jline.terminal.Attributes getAttr()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/InputStream;", "public abstract")]
	Dova.JDK.java.io.InputStream getMasterInput()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/OutputStream;", "public abstract")]
	Dova.JDK.java.io.OutputStream getMasterOutput()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/InputStream;", "public abstract")]
	Dova.JDK.java.io.InputStream getSlaveInput()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}
}
