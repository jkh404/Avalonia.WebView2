namespace OpenGL;

public enum Version11
{
	False = 0,
	NoError = 0,
	None = 0,
	Zero = 0,
	Points = 0,
	DepthBufferBit = 256,
	StencilBufferBit = 1024,
	ColorBufferBit = 16384,
	Lines = 1,
	LineLoop = 2,
	LineStrip = 3,
	Triangles = 4,
	TriangleStrip = 5,
	TriangleFan = 6,
	Never = 512,
	Less = 513,
	Equal = 514,
	Lequal = 515,
	Greater = 516,
	Notequal = 517,
	Gequal = 518,
	Always = 519,
	SrcColor = 768,
	OneMinusSrcColor = 769,
	SrcAlpha = 770,
	OneMinusSrcAlpha = 771,
	DstAlpha = 772,
	OneMinusDstAlpha = 773,
	DstColor = 774,
	OneMinusDstColor = 775,
	SrcAlphaSaturate = 776,
	FrontLeft = 1024,
	FrontRight = 1025,
	BackLeft = 1026,
	BackRight = 1027,
	Front = 1028,
	Back = 1029,
	Left = 1030,
	Right = 1031,
	FrontAndBack = 1032,
	InvalidEnum = 1280,
	InvalidValue = 1281,
	InvalidOperation = 1282,
	OutOfMemory = 1285,
	Cw = 2304,
	Ccw = 2305,
	PointSize = 2833,
	PointSizeRange = 2834,
	PointSizeGranularity = 2835,
	LineSmooth = 2848,
	LineWidth = 2849,
	LineWidthRange = 2850,
	LineWidthGranularity = 2851,
	PolygonSmooth = 2881,
	CullFace = 2884,
	CullFaceMode = 2885,
	FrontFace = 2886,
	DepthRange = 2928,
	DepthTest = 2929,
	DepthWritemask = 2930,
	DepthClearValue = 2931,
	DepthFunc = 2932,
	StencilTest = 2960,
	StencilClearValue = 2961,
	StencilFunc = 2962,
	StencilValueMask = 2963,
	StencilFail = 2964,
	StencilPassDepthFail = 2965,
	StencilPassDepthPass = 2966,
	StencilRef = 2967,
	StencilWritemask = 2968,
	Viewport = 2978,
	Dither = 3024,
	BlendDst = 3040,
	BlendSrc = 3041,
	Blend = 3042,
	LogicOpMode = 3056,
	ColorLogicOp = 3058,
	DrawBuffer = 3073,
	ReadBuffer = 3074,
	ScissorBox = 3088,
	ScissorTest = 3089,
	ColorClearValue = 3106,
	ColorWritemask = 3107,
	Doublebuffer = 3122,
	Stereo = 3123,
	LineSmoothHint = 3154,
	PolygonSmoothHint = 3155,
	UnpackSwapBytes = 3312,
	UnpackLsbFirst = 3313,
	UnpackRowLength = 3314,
	UnpackSkipRows = 3315,
	UnpackSkipPixels = 3316,
	UnpackAlignment = 3317,
	PackSwapBytes = 3328,
	PackLsbFirst = 3329,
	PackRowLength = 3330,
	PackSkipRows = 3331,
	PackSkipPixels = 3332,
	PackAlignment = 3333,
	MaxTextureSize = 3379,
	MaxViewportDims = 3386,
	SubpixelBits = 3408,
	Texture1D = 3552,
	Texture2D = 3553,
	TextureWidth = 4096,
	TextureHeight = 4097,
	TextureInternalFormat = 4099,
	TextureBorderColor = 4100,
	DontCare = 4352,
	Fastest = 4353,
	Nicest = 4354,
	Byte = 5120,
	UnsignedByte = 5121,
	Short = 5122,
	UnsignedShort = 5123,
	Int = 5124,
	UnsignedInt = 5125,
	Float = 5126,
	Double = 5130,
	Clear = 5376,
	And = 5377,
	AndReverse = 5378,
	Copy = 5379,
	AndInverted = 5380,
	Noop = 5381,
	Xor = 5382,
	Or = 5383,
	Nor = 5384,
	Equiv = 5385,
	Invert = 5386,
	OrReverse = 5387,
	CopyInverted = 5388,
	OrInverted = 5389,
	Nand = 5390,
	Set = 5391,
	Texture = 5890,
	Color = 6144,
	Depth = 6145,
	Stencil = 6146,
	StencilIndex = 6401,
	DepthComponent = 6402,
	Red = 6403,
	Green = 6404,
	Blue = 6405,
	Alpha = 6406,
	Rgb = 6407,
	Rgba = 6408,
	Point = 6912,
	Line = 6913,
	Fill = 6914,
	Keep = 7680,
	Replace = 7681,
	Incr = 7682,
	Decr = 7683,
	Vendor = 7936,
	Renderer = 7937,
	Version = 7938,
	Extensions = 7939,
	Nearest = 9728,
	Linear = 9729,
	NearestMipmapNearest = 9984,
	LinearMipmapNearest = 9985,
	NearestMipmapLinear = 9986,
	LinearMipmapLinear = 9987,
	TextureMagFilter = 10240,
	TextureMinFilter = 10241,
	TextureWrapS = 10242,
	TextureWrapT = 10243,
	Repeat = 10497,
	PolygonOffsetUnits = 10752,
	PolygonOffsetPoint = 10753,
	PolygonOffsetLine = 10754,
	R3G3B2 = 10768,
	PolygonOffsetFill = 32823,
	PolygonOffsetFactor = 32824,
	Rgb4 = 32847,
	Rgb5 = 32848,
	Rgb8 = 32849,
	Rgb10 = 32850,
	Rgb12 = 32851,
	Rgb16 = 32852,
	Rgba2 = 32853,
	Rgba4 = 32854,
	Rgb5A1 = 32855,
	Rgba8 = 32856,
	Rgb10A2 = 32857,
	Rgba12 = 32858,
	Rgba16 = 32859,
	TextureRedSize = 32860,
	TextureGreenSize = 32861,
	TextureBlueSize = 32862,
	TextureAlphaSize = 32863,
	ProxyTexture1D = 32867,
	ProxyTexture2D = 32868,
	TextureBinding1D = 32872,
	TextureBinding2D = 32873,
	One = 1,
	True = 1
}
