using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Model 
{

	[NVP_Manifest(
		Id = "271CFB15-704F-4DB3-A837-9B995657E1AE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Model.Model_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Model", 
		NodeName = "_Model_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Model_Constructor : INode 
	{
		public Renga.IModel _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IModel;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "BF9EAAB6-77BE-4060-BA60-CDFB584AC156", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Model.Model_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Model", 
		NodeName = "_Model_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Model_ConstructorCast : INode 
	{
		public Renga.IModel _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IModel;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "A47DE1D0-4FA8-48CA-AC5C-C42F1BE97F88", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Model.GetObjects", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Model", 
		NodeName = "GetObjects", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Model", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetObjects);

		}
	}


	[NVP_Manifest(
		Id = "F2CA62B5-71BA-4B1B-8797-E1EB0FD3FFBA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Model.CreateOperation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Model", 
		NodeName = "CreateOperation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Model", typeof(object))]

	///<summary>
	///
	///</summary>
	public class CreateOperation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateOperation);

		}
	}


	[NVP_Manifest(
		Id = "C9FC844E-E385-4EFD-8D7A-9112657825BA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Model.GetIdFromUniqueId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Model", 
		NodeName = "GetIdFromUniqueId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Model", typeof(object))]
	[NodeInput("uniqueId_", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetIdFromUniqueId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIdFromUniqueId(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "A64C77E2-3653-473D-92E6-58E4658A12E4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Model.GetIdFromUniqueIdS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Model", 
		NodeName = "GetIdFromUniqueIdS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Model", typeof(object))]
	[NodeInput("uniqueId_", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetIdFromUniqueIdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIdFromUniqueIdS(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "E073B991-C308-49BC-AC0F-967968B04D79", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Model.GetUniqueIdFromId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Model", 
		NodeName = "GetUniqueIdFromId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Model", typeof(object))]
	[NodeInput("id_", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetUniqueIdFromId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetUniqueIdFromId(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "AE4874B5-B35B-46D5-94AD-79A0D6CE8A1A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Model.GetUniqueIdFromIdS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Model", 
		NodeName = "GetUniqueIdFromIdS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Model", typeof(object))]
	[NodeInput("id_", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetUniqueIdFromIdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetUniqueIdFromIdS(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "DB29FFD0-F6A9-4934-9810-FD3E95D8B07C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Model.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Model", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Model", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}
}
