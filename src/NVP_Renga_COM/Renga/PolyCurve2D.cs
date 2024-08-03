using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.PolyCurve2D 
{

	[NVP_Manifest(
		Id = "175E2485-6D39-4784-B53F-7EBFB9AC201A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PolyCurve2D.PolyCurve2D_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PolyCurve2D", 
		NodeName = "_PolyCurve2D_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PolyCurve2D_Constructor : INode 
	{
		public Renga.IPolyCurve2D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IPolyCurve2D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "50230BAF-08FC-44DC-A1A7-D5F2053BF45A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PolyCurve2D.PolyCurve2D_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PolyCurve2D", 
		NodeName = "_PolyCurve2D_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PolyCurve2D_ConstructorCast : INode 
	{
		public Renga.IPolyCurve2D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IPolyCurve2D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "ECC68F99-C36C-4798-A290-F217984AD66B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PolyCurve2D.GetSegmentCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PolyCurve2D", 
		NodeName = "GetSegmentCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PolyCurve2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetSegmentCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetSegmentCount);

		}
	}


	[NVP_Manifest(
		Id = "1E424A81-2C7B-45D0-9B7B-57473D64D7D8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PolyCurve2D.GetSegment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PolyCurve2D", 
		NodeName = "GetSegment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PolyCurve2D", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetSegment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetSegment(inputs[1].Value));

		}
	}
}
