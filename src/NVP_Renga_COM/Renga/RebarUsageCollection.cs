using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.RebarUsageCollection 
{

	[NVP_Manifest(
		Id = "7A718098-4721-4FD0-81E0-3FEE268E5357", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RebarUsageCollection.RebarUsageCollection_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RebarUsageCollection", 
		NodeName = "_RebarUsageCollection_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class RebarUsageCollection_Constructor : INode 
	{
		public Renga.IRebarUsageCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IRebarUsageCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "613AFEC4-389F-4AD5-9407-412E51DE5ACF", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RebarUsageCollection.RebarUsageCollection_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RebarUsageCollection", 
		NodeName = "_RebarUsageCollection_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class RebarUsageCollection_ConstructorCast : INode 
	{
		public Renga.IRebarUsageCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IRebarUsageCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "53664C12-AFF9-4257-98FA-017D21EF4FF7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RebarUsageCollection.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RebarUsageCollection", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RebarUsageCollection", typeof(object))]

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


	[NVP_Manifest(
		Id = "AC53006F-DD0D-4101-8FCB-4E878E804482", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RebarUsageCollection.Get", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RebarUsageCollection", 
		NodeName = "Get", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RebarUsageCollection", typeof(object))]
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
}
