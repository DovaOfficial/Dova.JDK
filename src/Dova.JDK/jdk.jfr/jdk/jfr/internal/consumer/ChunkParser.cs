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

namespace Dova.JDK.jdk.jfr.@internal.consumer;

[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ChunkParser;", "public final")]
public partial class ChunkParser
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ChunkParser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/ChunkParser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLUSH_MARKER", "Ljdk/jfr/consumer/RecordedEvent;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_POOL_TYPE_ID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "input", "Ljdk/jfr/internal/consumer/RecordingInput;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chunkHeader", "Ljdk/jfr/internal/consumer/ChunkHeader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "timeConverter", "Ljdk/jfr/internal/consumer/TimeConverter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parserState", "Ljdk/jfr/internal/consumer/ParserState;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constantLookups", "Ljdk/jfr/internal/LongMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeMap", "Ljdk/jfr/internal/LongMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parsers", "Ljdk/jfr/internal/LongMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chunkFinished", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "configuration", "Ljdk/jfr/internal/consumer/ChunkParser$ParserConfiguration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "previousMetadata", "Ljdk/jfr/internal/MetadataDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "metadata", "Ljdk/jfr/internal/MetadataDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "staleMetadata", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/jfr/internal/consumer/RecordingInput;Ljdk/jfr/internal/consumer/ParserState;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/jfr/internal/consumer/ChunkHeader;Ljdk/jfr/internal/consumer/ChunkParser;Ljdk/jfr/internal/consumer/ChunkParser$ParserConfiguration;Ljdk/jfr/internal/consumer/ParserState;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/jfr/internal/consumer/ChunkParser;Ljdk/jfr/internal/consumer/ParserState;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/jfr/internal/consumer/RecordingInput;Ljdk/jfr/internal/consumer/ChunkParser$ParserConfiguration;Ljdk/jfr/internal/consumer/ParserState;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "(J)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateConfiguration", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateConfiguration", "(Ljdk/jfr/internal/consumer/ChunkParser$ParserConfiguration;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStaleMetadata", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillConstantPools", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "awaitUpdatedHeader", "(JJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseCheckpointType", "()B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "logConstant", "(JLjava/lang/Object;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "textify", "(Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLastChunk", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFinalChunk", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChunkDuration", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetCache", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextChunkParser", "()Ljdk/jfr/internal/consumer/ChunkParser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readStreamingEvent", "()Ljdk/jfr/consumer/RecordedEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreviousEventTypes", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newChunkParser", "()Ljdk/jfr/internal/consumer/ChunkParser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isChunkFinished", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndNanos", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasStaleMetadata", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readEvent", "()Ljdk/jfr/consumer/RecordedEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEventTypes", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartNanos", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypes", "()Ljava/util/Collection;"));
	}

	[JniSignatureAttribute("Ljdk/jfr/consumer/RecordedEvent;", "public static final")]
	public static Dova.JDK.jdk.jfr.consumer.RecordedEvent FLUSH_MARKER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.consumer.RecordedEvent>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long CONSTANT_POOL_TYPE_ID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/RecordingInput;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput input_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ChunkHeader;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.consumer.ChunkHeader chunkHeader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ChunkHeader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/TimeConverter;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.consumer.TimeConverter timeConverter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.TimeConverter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ParserState;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.consumer.ParserState parserState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ParserState>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/LongMap;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.LongMap constantLookups_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.LongMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/LongMap;", "private")]
	public Dova.JDK.jdk.jfr.@internal.LongMap typeMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.LongMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/LongMap;", "private")]
	public Dova.JDK.jdk.jfr.@internal.LongMap parsers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.LongMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool chunkFinished_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ChunkParser$ParserConfiguration;", "private")]
	public Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.ParserConfiguration configuration_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.ParserConfiguration>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/MetadataDescriptor;", "private")]
	public Dova.JDK.jdk.jfr.@internal.MetadataDescriptor previousMetadata_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.MetadataDescriptor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/MetadataDescriptor;", "private")]
	public Dova.JDK.jdk.jfr.@internal.MetadataDescriptor metadata_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.MetadataDescriptor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool staleMetadata_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ChunkParser(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;Ljdk/jfr/internal/consumer/ParserState;)V", "public")]
	public ChunkParser(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0, Dova.JDK.jdk.jfr.@internal.consumer.ParserState arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/ChunkHeader;Ljdk/jfr/internal/consumer/ChunkParser;Ljdk/jfr/internal/consumer/ChunkParser$ParserConfiguration;Ljdk/jfr/internal/consumer/ParserState;)V", "private")]
	public ChunkParser(Dova.JDK.jdk.jfr.@internal.consumer.ChunkHeader arg0, Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser arg1, Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.ParserConfiguration arg2, Dova.JDK.jdk.jfr.@internal.consumer.ParserState arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/ChunkParser;Ljdk/jfr/internal/consumer/ParserState;)V", "private")]
	public ChunkParser(Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser arg0, Dova.JDK.jdk.jfr.@internal.consumer.ParserState arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;Ljdk/jfr/internal/consumer/ChunkParser$ParserConfiguration;Ljdk/jfr/internal/consumer/ParserState;)V", "")]
	public ChunkParser(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0, Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.ParserConfiguration arg1, Dova.JDK.jdk.jfr.@internal.consumer.ParserState arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/ChunkParser;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(J)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getName(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void updateConfiguration()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/ChunkParser$ParserConfiguration;Z)V", "")]
	public void updateConfiguration(Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.ParserConfiguration arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setStaleMetadata(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(J)V", "private")]
	public void fillConstantPools(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(JJ)Z", "private")]
	public bool awaitUpdatedHeader(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()B", "private")]
	public byte parseCheckpointType()
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/lang/Object;Z)V", "private")]
	public void logConstant(long arg0, Dova.JDK.java.lang.Object arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String textify(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isLastChunk()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isFinalChunk()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getChunkDuration()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void resetCache()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("()Ljdk/jfr/internal/consumer/ChunkParser;", "public")]
	public Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser nextChunkParser()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jfr/consumer/RecordedEvent;", "")]
	public Dova.JDK.jdk.jfr.consumer.RecordedEvent readStreamingEvent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.consumer.RecordedEvent>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getPreviousEventTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jfr/internal/consumer/ChunkParser;", "")]
	public Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser newChunkParser()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isChunkFinished()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getEndNanos()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasStaleMetadata()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/jfr/consumer/RecordedEvent;", "public")]
	public Dova.JDK.jdk.jfr.consumer.RecordedEvent readEvent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.consumer.RecordedEvent>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getEventTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getStartNanos()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Collection;", "public")]
	public Dova.JDK.java.util.Collection getTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ChunkParser$ParserConfiguration;", "static final")]
	public partial class ParserConfiguration
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ParserConfiguration()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/ChunkParser$ParserConfiguration;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reuse", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ordered", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eventFilter", "Ljdk/jfr/internal/consumer/ParserFilter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filterStart", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filterEnd", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JJZZLjdk/jfr/internal/consumer/ParserFilter;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOrdered", "()Z"));
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool reuse_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool ordered_Property
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

		[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ParserFilter;", "private final")]
		public Dova.JDK.jdk.jfr.@internal.consumer.ParserFilter eventFilter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ParserFilter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("J", "")]
		public long filterStart_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("J", "")]
		public long filterEnd_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ParserConfiguration(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(JJZZLjdk/jfr/internal/consumer/ParserFilter;)V", "")]
		public ParserConfiguration(long arg0, long arg1, bool arg2, bool arg3, Dova.JDK.jdk.jfr.@internal.consumer.ParserFilter arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ParserConfiguration() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/ChunkParser$ParserConfiguration;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool isOrdered()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;", "private static final")]
	public partial class CheckPointType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CheckPointType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLUSH", "Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHUNK_HEADER", "Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATICS", "Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THREAD", "Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mask", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "is", "(I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;"));
		}

		[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;", "public static final")]
		public static Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.CheckPointType FLUSH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.CheckPointType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;", "public static final")]
		public static Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.CheckPointType CHUNK_HEADER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.CheckPointType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;", "public static final")]
		public static Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.CheckPointType STATICS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.CheckPointType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;", "public static final")]
		public static Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.CheckPointType THREAD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.CheckPointType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int mask_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("[Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.CheckPointType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.CheckPointType>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CheckPointType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
		public CheckPointType(Dova.JDK.java.lang.String arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;", "public static")]
		public static JavaArray<Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.CheckPointType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.CheckPointType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;", "public static")]
		public static Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.CheckPointType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.CheckPointType>(ret);
		}

		[JniSignatureAttribute("(I)Z", "private")]
		public bool @is(int arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("()[Ljdk/jfr/internal/consumer/ChunkParser$CheckPointType;", "private static")]
		public static JavaArray<Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.CheckPointType> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jfr.@internal.consumer.ChunkParser.CheckPointType>>(ret);
		}
	}
}
