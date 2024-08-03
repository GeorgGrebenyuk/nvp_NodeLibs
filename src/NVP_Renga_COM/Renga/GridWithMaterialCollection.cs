using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.GridWithMaterialCollection 
{

	[NVP_Manifest(
		Id = "F2B852AA-8DDB-49E9-8C49-370823B56243", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.GridWithMaterialCollection.GridWithMaterialCollection_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.GridWithMaterialCollection", 
		NodeName = "_GridWithMaterialCollection_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class GridWithMaterialCollection_Constructor : INode 
	{
		public Renga.IGridWithMaterialCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IGridWithMaterialCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "4D8E2460-BAD7-4EF5-9B37-0795022424A4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.GridWithMaterialCollection.GridWithMaterialCollection_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.GridWithMaterialCollection", 
		NodeName = "_GridWithMaterialCollection_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class GridWithMaterialCollection_ConstructorCast : INode 
	{
		public Renga.IGridWithMaterialCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IGridWithMaterialCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "9DA3BB20-6FC7-4957-B146-55CDD26E9834", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.GridWithMaterialCollection.Get", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.GridWithMaterialCollection", 
		NodeName = "Get", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("GridWithMaterialCollection", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class Get : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Get(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "D8769E19-1414-4CD1-853B-63FBDF554372", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.GridWithMaterialCollection.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.GridWithMaterialCollection", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("GridWithMaterialCollection", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}
}
