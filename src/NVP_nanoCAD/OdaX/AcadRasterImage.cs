using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///or raster) of small squares or dots known as pixels
///</summary>
namespace OdaX.AcadRasterImage 
{

	[NVP_Manifest(
		Id = "3B852E44-9E7D-4017-B44F-37780A897481", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.AcadRasterImage_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "_AcadRasterImage_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadRasterImage_Constructor : INode 
	{
		public OdaX.IAcadRasterImage _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadRasterImage;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "D631B1A9-1A9F-4B68-A5B9-3A267BC122FA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.AcadRasterImage_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "_AcadRasterImage_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadRasterImage_ConstructorCast : INode 
	{
		public OdaX.IAcadRasterImage _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadRasterImage;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "845ECD64-3553-48AB-A94A-2167E8F0C3B3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Brightness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Brightness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the current brightness value of the raster image", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the current brightness value of the raster image
	///</summary>
	public class Brightness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Brightness);

		}
	}


	[NVP_Manifest(
		Id = "8E930BE3-390B-4034-8789-74477FCBACE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Set_Brightness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Set_Brightness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the current brightness value of the raster image", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("Brightness", typeof(System.Object))]

	///<summary>
	///Specifies the current brightness value of the raster image
	///</summary>
	public class Set_Brightness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Brightness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DC301878-D743-477F-92D5-5C5FFA4A3961", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Contrast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Contrast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the current contrast value of the raster image", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the current contrast value of the raster image
	///</summary>
	public class Contrast : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Contrast);

		}
	}


	[NVP_Manifest(
		Id = "01C5B144-C3F8-4C77-B886-A677388BE78A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Set_Contrast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Set_Contrast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the current contrast value of the raster image", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("Contrast", typeof(System.Object))]

	///<summary>
	///Specifies the current contrast value of the raster image
	///</summary>
	public class Set_Contrast : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Contrast = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3EECFFF1-FEDD-4474-93F3-7CA80416E01A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Fade", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Fade", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the current fade value of the raster image", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the current fade value of the raster image
	///</summary>
	public class Fade : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Fade);

		}
	}


	[NVP_Manifest(
		Id = "E1F2A730-1856-4C6A-A515-00B6F1EF9F41", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Set_Fade", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Set_Fade", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the current fade value of the raster image", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("Fade", typeof(System.Object))]

	///<summary>
	///Specifies the current fade value of the raster image
	///</summary>
	public class Set_Fade : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Fade = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4C883798-709D-47C7-A462-E064B9B12162", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Origin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Origin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "lower left corner) of the raster image", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///lower left corner) of the raster image
	///</summary>
	public class Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Origin);

		}
	}


	[NVP_Manifest(
		Id = "1A3C74B7-3056-41E7-84AF-39384C85BFDD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Set_Origin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Set_Origin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "lower left corner) of the raster image", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("Origin", typeof(System.Object))]

	///<summary>
	///lower left corner) of the raster image
	///</summary>
	public class Set_Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Origin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "77C6F1D3-14F8-4297-83C7-D8799CFE0DBA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Rotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Rotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the rotation angle of the raster image", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the rotation angle of the raster image
	///</summary>
	public class Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rotation);

		}
	}


	[NVP_Manifest(
		Id = "8FF0439B-3350-4288-B4EF-2BF34E771211", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Set_Rotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Set_Rotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the rotation angle of the raster image", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies the rotation angle of the raster image
	///</summary>
	public class Set_Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1AB9522F-A116-4F48-8CB3-3EF0AD2F514C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.ImageWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "ImageWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the width of the raster image", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the width of the raster image
	///</summary>
	public class ImageWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ImageWidth);

		}
	}


	[NVP_Manifest(
		Id = "D488AB6E-927D-4E6D-8AC5-EDEB0BA332AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Set_ImageWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Set_ImageWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the width of the raster image", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies the width of the raster image
	///</summary>
	public class Set_ImageWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ImageWidth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6B6663E3-062A-425A-ADCF-883F09B086A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.ImageHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "ImageHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the height of the raster image", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the height of the raster image
	///</summary>
	public class ImageHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ImageHeight);

		}
	}


	[NVP_Manifest(
		Id = "6DE8E52A-DEB9-49CF-8CE0-766295DD7393", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Set_ImageHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Set_ImageHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the height of the raster image", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies the height of the raster image
	///</summary>
	public class Set_ImageHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ImageHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "45DBD4DA-BFE3-403E-A01B-8CD785C071A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the image file", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the name of the image file
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "FA2A1329-68E8-43F3-B8F8-584EC70A0A10", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the image file", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies the name of the image file
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "37799751-8AAE-40C4-A38B-353FFADF4110", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Set_ImageFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Set_ImageFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the path to the image file", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("imageFileName", typeof(System.String))]

	///<summary>
	///Specifies the path to the image file
	///</summary>
	public class Set_ImageFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ImageFile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "936DFAE3-98AA-41B1-AB36-001CDF15E350", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.ImageFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "ImageFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the path to the image file", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the path to the image file
	///</summary>
	public class ImageFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ImageFile);

		}
	}


	[NVP_Manifest(
		Id = "36C105F3-7590-4EE5-AD92-58C065039AF0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.ImageVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "ImageVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines whether image is visible or not", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Determines whether image is visible or not
	///</summary>
	public class ImageVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ImageVisibility);

		}
	}


	[NVP_Manifest(
		Id = "89222C01-AC51-40F4-91F2-2E1943416E3D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Set_ImageVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Set_ImageVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines whether image is visible or not", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("fVisible", typeof(System.Object))]

	///<summary>
	///Determines whether image is visible or not
	///</summary>
	public class Set_ImageVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ImageVisibility = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E9E7B542-A8A0-4AD3-B1A0-54802BE533F3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.ClippingEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "ClippingEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Enables or disables the clipping boundary of the image", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Enables or disables the clipping boundary of the image
	///</summary>
	public class ClippingEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClippingEnabled);

		}
	}


	[NVP_Manifest(
		Id = "DF8D02C4-627F-4056-8049-A23DD0DFCD5A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Set_ClippingEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Set_ClippingEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Enables or disables the clipping boundary of the image", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("kClip", typeof(System.Object))]

	///<summary>
	///Enables or disables the clipping boundary of the image
	///</summary>
	public class Set_ClippingEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClippingEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8DD0CEDA-10A4-4015-9F3D-A1B1697AC07A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Transparency", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Transparency", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines whether transparency for a bitonal image is On or Off", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Determines whether transparency for a bitonal image is On or Off
	///</summary>
	public class Transparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Transparency);

		}
	}


	[NVP_Manifest(
		Id = "509E8F98-78E4-4E17-9108-3674B3DC1F25", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Set_Transparency", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Set_Transparency", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines whether transparency for a bitonal image is On or Off", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("bTransp", typeof(System.Object))]

	///<summary>
	///Determines whether transparency for a bitonal image is On or Off
	///</summary>
	public class Set_Transparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Transparency = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F29E09B7-F614-4BE1-9CF7-AB9F6FEBDE07", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.ClipBoundary", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "ClipBoundary", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Set clipping boundary", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("boundry", typeof(System.Object))]

	///<summary>
	///Set clipping boundary
	///</summary>
	public class ClipBoundary : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClipBoundary(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0D5E0E15-E431-4129-9D0D-4CA9D91C2CAE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Height of the attribute, shape, text, or view toolbar or the main application window", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Id = "6CA21404-DA91-4587-964D-2DD02704FE49", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the width of the text boundary, view, image, toolbar, or main application window", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the width of the text boundary, view, image, toolbar, or main application window
	///</summary>
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	[NVP_Manifest(
		Id = "CF4ADB98-D29C-45F8-B834-D5F979845A6D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.ShowRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "ShowRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines if a raster image is displayed at its rotation value", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Determines if a raster image is displayed at its rotation value
	///</summary>
	public class ShowRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowRotation);

		}
	}


	[NVP_Manifest(
		Id = "23CB7C12-AC1E-4E61-8EF7-A4A26D79F6C6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Set_ShowRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Set_ShowRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines if a raster image is displayed at its rotation value", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("bShow", typeof(System.Object))]

	///<summary>
	///Determines if a raster image is displayed at its rotation value
	///</summary>
	public class Set_ShowRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowRotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8A19C2AB-4409-4546-B846-8E953AC43FE1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.ScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "ScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the scale factor of the raster image", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the scale factor of the raster image
	///</summary>
	public class ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleFactor);

		}
	}


	[NVP_Manifest(
		Id = "C9119A15-6CA1-4078-86E2-5E089C17AD99", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRasterImage.Set_ScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRasterImage", 
		NodeName = "Set_ScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the scale factor of the raster image", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("ScaleFactor", typeof(System.Object))]

	///<summary>
	///Specifies the scale factor of the raster image
	///</summary>
	public class Set_ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleFactor = inputs[1].Value;
			return null;
		}
	}
}
