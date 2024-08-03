using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.FloorParams 
{

	[NVP_Manifest(
		Id = "680C5023-F9AE-4A7F-BEF9-B6F645A21ED2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.FloorParams.FloorParams_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.FloorParams", 
		NodeName = "_FloorParams_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class FloorParams_Constructor : INode 
	{
		public Renga.IFloorParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IFloorParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "58BFE7B5-E930-43F5-84E4-37BCD5224C4B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.FloorParams.FloorParams_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.FloorParams", 
		NodeName = "_FloorParams_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class FloorParams_ConstructorCast : INode 
	{
		public Renga.IFloorParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IFloorParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "1C782445-A9FE-4906-82AF-F00FDE3A6E6E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.FloorParams.GetContour", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.FloorParams", 
		NodeName = "GetContour", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("FloorParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetContour : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContour);

		}
	}


	[NVP_Manifest(
		Id = "55FEFEB7-6C5C-40D3-B13B-38B01AAB63C8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.FloorParams.Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.FloorParams", 
		NodeName = "Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("FloorParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thickness);

		}
	}


	[NVP_Manifest(
		Id = "80625B31-099B-44FD-8A31-2C8478D4A48B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.FloorParams.VerticalOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.FloorParams", 
		NodeName = "VerticalOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("FloorParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class VerticalOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalOffset);

		}
	}


	[NVP_Manifest(
		Id = "31AE4675-F8EF-48DA-B09B-360FD240126B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.FloorParams.GetDependentObjectIds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.FloorParams", 
		NodeName = "GetDependentObjectIds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("FloorParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetDependentObjectIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetDependentObjectIds();
			return null;
		}
	}
}
