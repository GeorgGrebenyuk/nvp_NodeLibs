using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Image 
{

	[NVP_Manifest(
		Id = "4A059385-E4A3-4171-8985-9B1AA34055CB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Image.Image_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Image", 
		NodeName = "_Image_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Image_Constructor : INode 
	{
		public Renga.IImage _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IImage;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "6CFBB99E-0B99-4C02-9B7D-943A9C366A60", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Image.Image_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Image", 
		NodeName = "_Image_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Image_ConstructorCast : INode 
	{
		public Renga.IImage _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IImage;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "C8A35D61-4C2F-4B34-83E0-99E18F9D2630", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Image.LoadFromData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Image", 
		NodeName = "LoadFromData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Image", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LoadFromData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LoadFromData();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "04F19019-F8D3-4A0A-AE19-3C63ED3845D4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Image.LoadFromFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Image", 
		NodeName = "LoadFromFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Image", typeof(object))]
	[NodeInput("path_", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class LoadFromFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LoadFromFile(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C6E3B0A6-F60D-4BC8-8454-CA596CD3643D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Image.SaveToFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Image", 
		NodeName = "SaveToFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Image", typeof(object))]
	[NodeInput("path_", typeof(System.String))]
	[NodeInput("Renga.ImageFormat", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SaveToFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveToFile(inputs[1].Value,((Renga.ImageFormat)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "65B513CA-F5F7-400B-BFE1-A22FE4235094", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Image.SaveToData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Image", 
		NodeName = "SaveToData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Image", typeof(object))]
	[NodeInput("Renga.ImageFormat", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SaveToData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveToData(((Renga.ImageFormat)inputs[1].Value));
			return null;
		}
	}
}
