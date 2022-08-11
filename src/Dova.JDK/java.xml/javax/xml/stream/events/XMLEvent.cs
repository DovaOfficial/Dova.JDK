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

namespace Dova.JDK.javax.xml.stream.events;

[JniSignatureAttribute("Ljavax/xml/stream/events/XMLEvent;", "public abstract interface")]
public partial interface XMLEvent
	: IJavaObject
	, Dova.JDK.javax.xml.stream.XMLStreamConstants
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLEvent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/stream/events/XMLEvent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocation", "()Ljavax/xml/stream/Location;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAttribute", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEventType", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEndElement", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStartElement", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNamespace", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSchemaType", "()Ljavax/xml/namespace/QName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCharacters", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEntityReference", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isProcessingInstruction", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStartDocument", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEndDocument", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asStartElement", "()Ljavax/xml/stream/events/StartElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asEndElement", "()Ljavax/xml/stream/events/EndElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asCharacters", "()Ljavax/xml/stream/events/Characters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeAsEncodedUnicode", "(Ljava/io/Writer;)V"));
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/Location;", "public abstract")]
	Dova.JDK.javax.xml.stream.Location getLocation()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.Location>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isAttribute()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getEventType()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isEndElement()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isStartElement()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isNamespace()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/xml/namespace/QName;", "public abstract")]
	Dova.JDK.javax.xml.@namespace.QName getSchemaType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.@namespace.QName>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isCharacters()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isEntityReference()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isProcessingInstruction()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isStartDocument()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isEndDocument()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/events/StartElement;", "public abstract")]
	Dova.JDK.javax.xml.stream.events.StartElement asStartElement()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.StartElement>(ret);
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/events/EndElement;", "public abstract")]
	Dova.JDK.javax.xml.stream.events.EndElement asEndElement()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.EndElement>(ret);
	}

	[JniSignatureAttribute("()Ljavax/xml/stream/events/Characters;", "public abstract")]
	Dova.JDK.javax.xml.stream.events.Characters asCharacters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.events.Characters>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/Writer;)V", "public abstract")]
	void writeAsEncodedUnicode(Dova.JDK.java.io.Writer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}
}
