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

namespace Dova.JDK.jdk.@internal.jimage.decompressor;

[JniSignatureAttribute("Ljdk/internal/jimage/decompressor/ResourceDecompressor;", "public abstract interface")]
public partial interface ResourceDecompressor
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ResourceDecompressor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jimage/decompressor/ResourceDecompressor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decompress", "(Ljdk/internal/jimage/decompressor/ResourceDecompressor$StringsProvider;[BIJ)[B"));
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jimage/decompressor/ResourceDecompressor$StringsProvider;[BIJ)[B", "public abstract")]
	JavaArray<byte> decompress(Dova.JDK.jdk.@internal.jimage.decompressor.ResourceDecompressor.StringsProvider arg0, JavaArray<byte> arg1, int arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/jimage/decompressor/ResourceDecompressor$StringsProvider;", "public abstract static interface")]
	public partial interface StringsProvider
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StringsProvider()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jimage/decompressor/ResourceDecompressor$StringsProvider;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getString", "(I)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(I)Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getString(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}
}
