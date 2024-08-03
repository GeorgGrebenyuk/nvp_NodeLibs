using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Region2D 
{

	[NVP_Manifest(
		Id = "76E1DA4F-8970-4EFC-8657-1AD2321E2BE3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Region2D.Region2D_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Region2D", 
		NodeName = "_Region2D_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Region2D_Constructor : INode 
	{
		public Renga.IRegion2D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IRegion2D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "1B0087C8-33FC-488A-9581-0538EAD5E87D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Region2D.Region2D_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Region2D", 
		NodeName = "_Region2D_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Region2D_ConstructorCast : INode 
	{
		public Renga.IRegion2D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IRegion2D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "6BBA2A67-ACA1-4A63-BDFD-9C3B3C64F491", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Region2D.GetContourCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Region2D", 
		NodeName = "GetContourCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Region2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetContourCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContourCount);

		}
	}


	[NVP_Manifest(
		Id = "5857E9ED-5007-414E-9664-38C2C4565092", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Region2D.GetContour", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Region2D", 
		NodeName = "GetContour", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Region2D", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetContour : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContour(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "4207281E-6BCA-4F6E-97FF-B8C15CABDCB1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Region2D.GetOuterContour", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Region2D", 
		NodeName = "GetOuterContour", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Region2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetOuterContour : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetOuterContour);

		}
	}
}
