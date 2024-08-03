using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.FlowSegmentPlacement 
{

	[NVP_Manifest(
		Id = "9ADC8619-2A55-4E66-A2C3-7FE616E8DDBE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.FlowSegmentPlacement.FlowSegmentPlacement_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.FlowSegmentPlacement", 
		NodeName = "_FlowSegmentPlacement_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class FlowSegmentPlacement_Constructor : INode 
	{
		public Renga.IFlowSegmentPlacement _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IFlowSegmentPlacement;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "041184BD-AC13-4FD8-9155-B1CD62882C92", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.FlowSegmentPlacement.FlowSegmentPlacement_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.FlowSegmentPlacement", 
		NodeName = "_FlowSegmentPlacement_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class FlowSegmentPlacement_ConstructorCast : INode 
	{
		public Renga.IFlowSegmentPlacement _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IFlowSegmentPlacement;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "A779CD5A-887A-42BB-B428-20B2E7E250E3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.FlowSegmentPlacement.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.FlowSegmentPlacement", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("FlowSegmentPlacement", typeof(object))]

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


	[NVP_Manifest(
		Id = "71A2CCC6-1F02-4273-A924-B004A2528448", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.FlowSegmentPlacement.GetBaseline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.FlowSegmentPlacement", 
		NodeName = "GetBaseline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("FlowSegmentPlacement", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetBaseline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBaseline);

		}
	}
}
