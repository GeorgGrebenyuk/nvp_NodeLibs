using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface for an additional Raster Image funtionality
///</summary>
namespace OdaX.OdaRasterImage 
{

	[NVP_Manifest(
		Id = "024F44AE-14F3-495E-9A86-49974A15B13F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaRasterImage.OdaRasterImage_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaRasterImage", 
		NodeName = "_OdaRasterImage_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaRasterImage_Constructor : INode 
	{
		public OdaX.IOdaRasterImage _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaRasterImage;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "5B71E915-E930-466A-A04B-0B616A52F498", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaRasterImage.OdaRasterImage_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaRasterImage", 
		NodeName = "_OdaRasterImage_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaRasterImage_ConstructorCast : INode 
	{
		public OdaX.IOdaRasterImage _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaRasterImage;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "58169077-BFF7-4DCB-819A-B26C230FBBD2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaRasterImage.Loaded", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaRasterImage", 
		NodeName = "Loaded", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns true if this Raster Image is currently loaded", 
		ViewType = "Data")]
	[NodeInput("OdaRasterImage", typeof(object))]

	///<summary>
	///Returns true if this Raster Image is currently loaded
	///</summary>
	public class Loaded : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Loaded);

		}
	}
}
