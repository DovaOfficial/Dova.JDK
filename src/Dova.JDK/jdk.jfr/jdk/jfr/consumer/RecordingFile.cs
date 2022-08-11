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

namespace Dova.JDK.jdk.jfr.consumer;

[JniSignatureAttribute("Ljdk/jfr/consumer/RecordingFile;", "public final")]
public partial class RecordingFile
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Closeable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RecordingFile()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/consumer/RecordingFile;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parserState", "Ljdk/jfr/internal/consumer/ParserState;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isLastEventInChunk", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "file", "Ljava/io/File;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "input", "Ljdk/jfr/internal/consumer/RecordingInput;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chunkParser", "Ljdk/jfr/internal/consumer/ChunkParser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextEvent", "Ljdk/jfr/consumer/RecordedEvent;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eof", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/file/Path;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFile", "()Ljava/io/File;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureOpen", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasMoreEvents", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findNext", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "aggregateEventTypeForChunk", "(Ljdk/jfr/internal/consumer/ChunkHeader;Ljdk/jfr/internal/MetadataDescriptor;Ljava/util/List;Ljava/util/HashSet;)Ljdk/jfr/internal/MetadataDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "aggregateTypeForChunk", "(Ljdk/jfr/internal/consumer/ChunkHeader;Ljdk/jfr/internal/MetadataDescriptor;Ljava/util/List;Ljava/util/HashSet;)Ljdk/jfr/internal/MetadataDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readEventTypes", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readAllEvents", "(Ljava/nio/file/Path;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readTypes", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLastEventInChunk", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readEvent", "()Ljdk/jfr/consumer/RecordedEvent;"));
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ParserState;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.consumer.ParserState parserState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ParserState>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isLastEventInChunk_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/io/File;", "private final")]
	public Dova.JDK.java.io.File file_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/RecordingInput;", "private")]
	public Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput input_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ChunkParser;", "private")]
	public Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser chunkParser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/consumer/RecordedEvent;", "private")]
	public Dova.JDK.jdk.jfr.consumer.RecordedEvent nextEvent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.consumer.RecordedEvent>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool eof_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RecordingFile(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)V", "public")]
	public RecordingFile(Dova.JDK.java.nio.file.Path arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/consumer/RecordingFile;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Ljava/io/File;", "")]
	public Dova.JDK.java.io.File getFile()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void ensureOpen()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasMoreEvents()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void findNext()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/ChunkHeader;Ljdk/jfr/internal/MetadataDescriptor;Ljava/util/List;Ljava/util/HashSet;)Ljdk/jfr/internal/MetadataDescriptor;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.MetadataDescriptor aggregateEventTypeForChunk(Dova.JDK.jdk.jfr.@internal.consumer.ChunkHeader arg0, Dova.JDK.jdk.jfr.@internal.MetadataDescriptor arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.HashSet arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.MetadataDescriptor>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/ChunkHeader;Ljdk/jfr/internal/MetadataDescriptor;Ljava/util/List;Ljava/util/HashSet;)Ljdk/jfr/internal/MetadataDescriptor;", "private")]
	public Dova.JDK.jdk.jfr.@internal.MetadataDescriptor aggregateTypeForChunk(Dova.JDK.jdk.jfr.@internal.consumer.ChunkHeader arg0, Dova.JDK.jdk.jfr.@internal.MetadataDescriptor arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.HashSet arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.MetadataDescriptor>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List readEventTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/util/List;", "public static")]
	public static Dova.JDK.java.util.List readAllEvents(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "")]
	public Dova.JDK.java.util.List readTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isLastEventInChunk()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/jfr/consumer/RecordedEvent;", "public")]
	public Dova.JDK.jdk.jfr.consumer.RecordedEvent readEvent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.consumer.RecordedEvent>(ret);
	}
}
