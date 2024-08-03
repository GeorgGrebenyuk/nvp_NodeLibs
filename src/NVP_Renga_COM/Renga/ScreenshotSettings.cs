using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ScreenshotSettings 
{

	[NVP_Manifest(
		Id = "AA0807AF-1854-4149-BE21-32A26322DD98", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ScreenshotSettings.ScreenshotSettings_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ScreenshotSettings", 
		NodeName = "_ScreenshotSettings_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ScreenshotSettings_Constructor : INode 
	{
		public Renga.IScreenshotSettings _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IScreenshotSettings;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "37B3EE59-1ACE-44E7-A318-EEA8E9026302", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ScreenshotSettings.ScreenshotSettings_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ScreenshotSettings", 
		NodeName = "_ScreenshotSettings_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ScreenshotSettings_ConstructorCast : INode 
	{
		public Renga.IScreenshotSettings _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IScreenshotSettings;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "4F791C00-5A9C-4558-BCA3-FEA9F95BBCD9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ScreenshotSettings.Set_Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ScreenshotSettings", 
		NodeName = "Set_Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ScreenshotSettings", typeof(object))]
	[NodeInput("pWidth", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class Set_Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Width = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D7E39C48-08B1-491F-9291-D6EAB082FFCD", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ScreenshotSettings.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ScreenshotSettings", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ScreenshotSettings", typeof(object))]

	///<summary>
	///
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
		Id = "3246D8AD-5690-4DD4-8BAC-40E866E4C725", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ScreenshotSettings.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ScreenshotSettings", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ScreenshotSettings", typeof(object))]
	[NodeInput("pHeight", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B63FAB34-9C3C-4A5F-90B4-A4D788734BA5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ScreenshotSettings.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ScreenshotSettings", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ScreenshotSettings", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}
}
