using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.SystemStyleManager 
{

	[NVP_Manifest(
		Id = "40DB9E4A-4710-4A59-9C82-AE3FFC1FEE57", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SystemStyleManager.SystemStyleManager_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SystemStyleManager", 
		NodeName = "_SystemStyleManager_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SystemStyleManager_Constructor : INode 
	{
		public Renga.ISystemStyleManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ISystemStyleManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "8CE60B5C-1C5D-4389-9137-FD79B95CB2C3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SystemStyleManager.SystemStyleManager_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SystemStyleManager", 
		NodeName = "_SystemStyleManager_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SystemStyleManager_ConstructorCast : INode 
	{
		public Renga.ISystemStyleManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ISystemStyleManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "0E32C096-F2FB-4C42-8821-3BDF4AF2E549", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SystemStyleManager.GetIds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SystemStyleManager", 
		NodeName = "GetIds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("SystemStyleManager", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetIds();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "349D75BC-677A-499D-88FA-CC31C2D32C63", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SystemStyleManager.Contains", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SystemStyleManager", 
		NodeName = "Contains", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("SystemStyleManager", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class Contains : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Contains(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "DB6BFAF5-9F99-46C2-AC15-F28F7E41EE80", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SystemStyleManager.GetSystemStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SystemStyleManager", 
		NodeName = "GetSystemStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("SystemStyleManager", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetSystemStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetSystemStyle(inputs[1].Value));

		}
	}
}
