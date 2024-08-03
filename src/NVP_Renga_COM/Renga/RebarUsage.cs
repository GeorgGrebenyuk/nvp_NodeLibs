using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.RebarUsage 
{

	[NVP_Manifest(
		Id = "05CF1F49-9997-4CC1-BA45-D6ACCB421358", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RebarUsage.RebarUsage_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RebarUsage", 
		NodeName = "_RebarUsage_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class RebarUsage_Constructor : INode 
	{
		public Renga.IRebarUsage _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IRebarUsage;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "38D78E53-9D31-4B68-A081-0F9F56A04842", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RebarUsage.RebarUsage_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RebarUsage", 
		NodeName = "_RebarUsage_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class RebarUsage_ConstructorCast : INode 
	{
		public Renga.IRebarUsage _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IRebarUsage;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "A209C736-5410-498B-A5A7-79FDE80E3D95", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RebarUsage.StyleId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RebarUsage", 
		NodeName = "StyleId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RebarUsage", typeof(object))]

	///<summary>
	///
	///</summary>
	public class StyleId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StyleId);

		}
	}


	[NVP_Manifest(
		Id = "25578C8F-4715-4C56-8C26-E75A91706C2A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RebarUsage.GetQuantities", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RebarUsage", 
		NodeName = "GetQuantities", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RebarUsage", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetQuantities : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetQuantities);

		}
	}


	[NVP_Manifest(
		Id = "73D87513-420F-4F65-BF9A-C5933AFBA4C9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RebarUsage.GetRebarGeometry", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RebarUsage", 
		NodeName = "GetRebarGeometry", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RebarUsage", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetRebarGeometry : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRebarGeometry);

		}
	}


	[NVP_Manifest(
		Id = "7E6BDAB8-F63D-4767-89AF-9A65F49225AC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RebarUsage.GetPlacements", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RebarUsage", 
		NodeName = "GetPlacements", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RebarUsage", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetPlacements : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPlacements);

		}
	}
}
