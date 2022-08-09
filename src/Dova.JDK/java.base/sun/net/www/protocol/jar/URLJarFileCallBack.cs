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

namespace Dova.JDK.sun.net.www.protocol.jar;

[JniSignatureAttribute("Lsun/net/www/protocol/jar/URLJarFileCallBack;", "public abstract interface")]
public partial interface URLJarFileCallBack
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static URLJarFileCallBack()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/net/www/protocol/jar/URLJarFileCallBack;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "retrieve", "(Ljava/net/URL;)Ljava/util/jar/JarFile;"));
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljava/util/jar/JarFile;", "public abstract")]
	Dova.JDK.java.util.jar.JarFile retrieve(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarFile>(ret);
	}
}