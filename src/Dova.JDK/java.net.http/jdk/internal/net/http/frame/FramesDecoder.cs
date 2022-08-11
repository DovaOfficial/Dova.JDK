/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.@internal.net.http.frame;

[JniSignatureAttribute("Ljdk/internal/net/http/frame/FramesDecoder;", "public")]
public partial class FramesDecoder
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FramesDecoder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/frame/FramesDecoder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "debug", "Ljdk/internal/net/http/common/Logger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frameProcessor", "Ljdk/internal/net/http/frame/FramesDecoder$FrameProcessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxFrameSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentBuffer", "Ljava/nio/ByteBuffer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tailBuffers", "Ljava/util/ArrayDeque;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tailSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "slicedToDataFrame", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prepareToRelease", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frameHeaderParsed", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frameLength", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frameType", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frameFlags", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frameStreamid", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closed", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COPY_THRESHOLD", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/frame/FramesDecoder$FrameProcessor;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/net/http/frame/FramesDecoder$FrameProcessor;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByte", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShort", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInt", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decode", "(Ljava/nio/ByteBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBytes", "(I)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextFrame", "()Ljdk/internal/net/http/frame/Http2Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skipBytes", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "frameProcessed", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseFrameHeader", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseFrameBody", "()Ljdk/internal/net/http/frame/Http2Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseDataFrame", "(III)Ljdk/internal/net/http/frame/Http2Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseHeadersFrame", "(III)Ljdk/internal/net/http/frame/Http2Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parsePriorityFrame", "(III)Ljdk/internal/net/http/frame/Http2Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseResetFrame", "(III)Ljdk/internal/net/http/frame/Http2Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseSettingsFrame", "(III)Ljdk/internal/net/http/frame/Http2Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parsePushPromiseFrame", "(III)Ljdk/internal/net/http/frame/Http2Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parsePingFrame", "(III)Ljdk/internal/net/http/frame/Http2Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseGoAwayFrame", "(III)Ljdk/internal/net/http/frame/Http2Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseWindowUpdateFrame", "(III)Ljdk/internal/net/http/frame/Http2Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseContinuationFrame", "(III)Ljdk/internal/net/http/frame/Http2Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBuffers", "(ZI)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextBuffer", "()V"));
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/common/Logger;", "static final")]
	public static Dova.JDK.jdk.@internal.net.http.common.Logger debug_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.common.Logger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/frame/FramesDecoder$FrameProcessor;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.frame.FramesDecoder.FrameProcessor frameProcessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.frame.FramesDecoder.FrameProcessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int maxFrameSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Ljava/nio/ByteBuffer;", "private")]
	public Dova.JDK.java.nio.ByteBuffer currentBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ArrayDeque;", "private final")]
	public Dova.JDK.java.util.ArrayDeque tailBuffers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayDeque>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int tailSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool slicedToDataFrame_Property
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

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List prepareToRelease_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool frameHeaderParsed_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int frameLength_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int frameType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int frameFlags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int frameStreamid_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool closed_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int COPY_THRESHOLD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FramesDecoder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/frame/FramesDecoder$FrameProcessor;)V", "public")]
	public FramesDecoder(Dova.JDK.jdk.@internal.net.http.frame.FramesDecoder.FrameProcessor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/frame/FramesDecoder$FrameProcessor;I)V", "public")]
	public FramesDecoder(Dova.JDK.jdk.@internal.net.http.frame.FramesDecoder.FrameProcessor arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/frame/FramesDecoder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()I", "public")]
	public int getByte()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getShort()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getInt()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)V", "public")]
	public void decode(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(I)[B", "public")]
	public JavaArray<byte> getBytes(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void close(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/frame/Http2Frame;", "private")]
	public Dova.JDK.jdk.@internal.net.http.frame.Http2Frame nextFrame()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.frame.Http2Frame>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void skipBytes(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void frameProcessed()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void parseFrameHeader()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()Ljdk/internal/net/http/frame/Http2Frame;", "private")]
	public Dova.JDK.jdk.@internal.net.http.frame.Http2Frame parseFrameBody()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.frame.Http2Frame>(ret);
	}

	[JniSignatureAttribute("(III)Ljdk/internal/net/http/frame/Http2Frame;", "private")]
	public Dova.JDK.jdk.@internal.net.http.frame.Http2Frame parseDataFrame(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.frame.Http2Frame>(ret);
	}

	[JniSignatureAttribute("(III)Ljdk/internal/net/http/frame/Http2Frame;", "private")]
	public Dova.JDK.jdk.@internal.net.http.frame.Http2Frame parseHeadersFrame(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.frame.Http2Frame>(ret);
	}

	[JniSignatureAttribute("(III)Ljdk/internal/net/http/frame/Http2Frame;", "private")]
	public Dova.JDK.jdk.@internal.net.http.frame.Http2Frame parsePriorityFrame(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.frame.Http2Frame>(ret);
	}

	[JniSignatureAttribute("(III)Ljdk/internal/net/http/frame/Http2Frame;", "private")]
	public Dova.JDK.jdk.@internal.net.http.frame.Http2Frame parseResetFrame(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.frame.Http2Frame>(ret);
	}

	[JniSignatureAttribute("(III)Ljdk/internal/net/http/frame/Http2Frame;", "private")]
	public Dova.JDK.jdk.@internal.net.http.frame.Http2Frame parseSettingsFrame(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.frame.Http2Frame>(ret);
	}

	[JniSignatureAttribute("(III)Ljdk/internal/net/http/frame/Http2Frame;", "private")]
	public Dova.JDK.jdk.@internal.net.http.frame.Http2Frame parsePushPromiseFrame(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.frame.Http2Frame>(ret);
	}

	[JniSignatureAttribute("(III)Ljdk/internal/net/http/frame/Http2Frame;", "private")]
	public Dova.JDK.jdk.@internal.net.http.frame.Http2Frame parsePingFrame(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.frame.Http2Frame>(ret);
	}

	[JniSignatureAttribute("(III)Ljdk/internal/net/http/frame/Http2Frame;", "private")]
	public Dova.JDK.jdk.@internal.net.http.frame.Http2Frame parseGoAwayFrame(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.frame.Http2Frame>(ret);
	}

	[JniSignatureAttribute("(III)Ljdk/internal/net/http/frame/Http2Frame;", "private")]
	public Dova.JDK.jdk.@internal.net.http.frame.Http2Frame parseWindowUpdateFrame(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.frame.Http2Frame>(ret);
	}

	[JniSignatureAttribute("(III)Ljdk/internal/net/http/frame/Http2Frame;", "private")]
	public Dova.JDK.jdk.@internal.net.http.frame.Http2Frame parseContinuationFrame(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.frame.Http2Frame>(ret);
	}

	[JniSignatureAttribute("(ZI)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getBuffers(bool arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void nextBuffer()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22]);
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/frame/FramesDecoder$FrameProcessor;", "public abstract static interface")]
	public partial interface FrameProcessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FrameProcessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/frame/FramesDecoder$FrameProcessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processFrame", "(Ljdk/internal/net/http/frame/Http2Frame;)V"));
		}

		[JniSignatureAttribute("(Ljdk/internal/net/http/frame/Http2Frame;)V", "public abstract")]
		void processFrame(Dova.JDK.jdk.@internal.net.http.frame.Http2Frame arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}
}
