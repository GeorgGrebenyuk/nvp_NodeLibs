using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.BeamParams 
{

	[NVP_Manifest(
		Id = "7A5A7973-8478-446F-B65C-37D7C2593404", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BeamParams.BeamParams_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BeamParams", 
		NodeName = "_BeamParams_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BeamParams_Constructor : INode 
	{
		public Renga.IBeamParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IBeamParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "C839B73A-45A0-4276-A009-E3F42F9AE384", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BeamParams.BeamParams_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BeamParams", 
		NodeName = "_BeamParams_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BeamParams_ConstructorCast : INode 
	{
		public Renga.IBeamParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IBeamParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "2C5DDCAE-8560-4E69-A51B-4218ECDCA9AF", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BeamParams.GetBaseline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BeamParams", 
		NodeName = "GetBaseline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("BeamParams", typeof(object))]

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


	[NVP_Manifest(
		Id = "07A7F531-AF12-43C7-A3CE-CF9171F04AD3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BeamParams.StyleId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BeamParams", 
		NodeName = "StyleId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("BeamParams", typeof(object))]

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
		Id = "0286E1A0-FB5C-4497-93E6-E1ED31DE7548", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BeamParams.GetProfilePlacement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BeamParams", 
		NodeName = "GetProfilePlacement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("BeamParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetProfilePlacement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetProfilePlacement);

		}
	}


	[NVP_Manifest(
		Id = "8F297AA3-4A42-4D2C-86F3-50D10C8C468C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BeamParams.GetProfilePlacementOnBaseline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BeamParams", 
		NodeName = "GetProfilePlacementOnBaseline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("BeamParams", typeof(object))]
	[NodeInput("param", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class GetProfilePlacementOnBaseline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetProfilePlacementOnBaseline(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "E7FCDBAF-F976-4605-BE75-EE971DDB57B2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BeamParams.VerticalOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BeamParams", 
		NodeName = "VerticalOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("BeamParams", typeof(object))]

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
}
