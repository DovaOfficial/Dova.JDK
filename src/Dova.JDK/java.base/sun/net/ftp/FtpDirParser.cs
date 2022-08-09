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

namespace Dova.JDK.sun.net.ftp;

[JniSignatureAttribute("Lsun/net/ftp/FtpDirParser;", "public abstract interface")]
public partial interface FtpDirParser
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FtpDirParser()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/net/ftp/FtpDirParser;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseLine", "(Ljava/lang/String;)Lsun/net/ftp/FtpDirEntry;"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ftp/FtpDirEntry;", "public abstract")]
	Dova.JDK.sun.net.ftp.FtpDirEntry parseLine(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ftp.FtpDirEntry>(ret);
	}
}