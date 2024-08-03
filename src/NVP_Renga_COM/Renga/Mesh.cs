using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Mesh 
{

	[NVP_Manifest(
		Id = "521C568C-3307-4EBB-8F7A-16690F9BA3CA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Mesh.Mesh_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Mesh", 
		NodeName = "_Mesh_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Mesh_Constructor : INode 
	{
		public Renga.IMesh _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IMesh;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "6DD0EDDA-B45A-492D-BCA3-4724BF147A1A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Mesh.Mesh_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Mesh", 
		NodeName = "_Mesh_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Mesh_ConstructorCast : INode 
	{
		public Renga.IMesh _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IMesh;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "72ED898C-B090-4543-ADC8-21F7702CC8D6", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Mesh.GridCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Mesh", 
		NodeName = "GridCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Mesh", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GridCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GridCount);

		}
	}


	[NVP_Manifest(
		Id = "B6FFB600-09F4-4B46-8409-B4AC4E4AE550", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Mesh.GetGrid", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Mesh", 
		NodeName = "GetGrid", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Mesh", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetGrid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGrid(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "8ABCE59D-FBE6-418D-AED6-5F957FE7BADA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Mesh.MeshType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Mesh", 
		NodeName = "MeshType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Mesh", typeof(object))]

	///<summary>
	///
	///</summary>
	public class MeshType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MeshType);

		}
	}


	[NVP_Manifest(
		Id = "5388CF7B-D8E1-487A-89F3-3C1136757B47", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Mesh.MeshTypeS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Mesh", 
		NodeName = "MeshTypeS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Mesh", typeof(object))]

	///<summary>
	///
	///</summary>
	public class MeshTypeS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MeshTypeS);

		}
	}
}
