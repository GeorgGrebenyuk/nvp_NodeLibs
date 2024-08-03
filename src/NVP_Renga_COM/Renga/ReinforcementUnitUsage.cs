using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ReinforcementUnitUsage 
{

	[NVP_Manifest(
		Id = "73DFBAA1-7077-45B9-8415-5CABBA927115", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitUsage.ReinforcementUnitUsage_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitUsage", 
		NodeName = "_ReinforcementUnitUsage_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ReinforcementUnitUsage_Constructor : INode 
	{
		public Renga.IReinforcementUnitUsage _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IReinforcementUnitUsage;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "4BE72210-1E22-43BA-8303-BD1B92961CCE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitUsage.ReinforcementUnitUsage_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitUsage", 
		NodeName = "_ReinforcementUnitUsage_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ReinforcementUnitUsage_ConstructorCast : INode 
	{
		public Renga.IReinforcementUnitUsage _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IReinforcementUnitUsage;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "FFC5BBC4-6F49-4400-82FD-BECCB1B3D428", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitUsage.StyleId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitUsage", 
		NodeName = "StyleId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ReinforcementUnitUsage", typeof(object))]

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
		Id = "EA9E6FAC-C0E3-47B6-9A12-DEA9AAA4B621", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitUsage.GetQuantities", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitUsage", 
		NodeName = "GetQuantities", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ReinforcementUnitUsage", typeof(object))]

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
		Id = "C1C80B64-F867-4250-92CD-949731526A6C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitUsage.GetPlacements", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitUsage", 
		NodeName = "GetPlacements", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ReinforcementUnitUsage", typeof(object))]

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
