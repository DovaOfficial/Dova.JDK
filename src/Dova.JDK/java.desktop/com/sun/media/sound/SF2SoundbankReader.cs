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

namespace Dova.JDK.com.sun.media.sound;

[JniSignatureAttribute("Lcom/sun/media/sound/SF2SoundbankReader;", "public final")]
public partial class SF2SoundbankReader
	: Dova.JDK.javax.sound.midi.spi.SoundbankReader
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SF2SoundbankReader()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/media/sound/SF2SoundbankReader;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "SF2SoundbankReader", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSoundbank", "(Ljava/io/File;)Ljavax/sound/midi/Soundbank;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSoundbank", "(Ljava/io/InputStream;)Ljavax/sound/midi/Soundbank;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSoundbank", "(Ljava/net/URL;)Ljavax/sound/midi/Soundbank;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SF2SoundbankReader(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SF2SoundbankReader() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/media/sound/SF2SoundbankReader;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/File;)Ljavax/sound/midi/Soundbank;", "public")]
	public Dova.JDK.javax.sound.midi.Soundbank getSoundbank(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Soundbank>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Ljavax/sound/midi/Soundbank;", "public")]
	public Dova.JDK.javax.sound.midi.Soundbank getSoundbank(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Soundbank>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljavax/sound/midi/Soundbank;", "public")]
	public Dova.JDK.javax.sound.midi.Soundbank getSoundbank(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sound.midi.Soundbank>(ret);
	}
}
