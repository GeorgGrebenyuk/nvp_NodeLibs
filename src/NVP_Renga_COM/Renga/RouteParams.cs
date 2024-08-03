using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.RouteParams 
{

	[NVP_Manifest(
		Id = "18E74BAC-34CB-4945-886B-F7FE320A7CC8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RouteParams.RouteParams_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RouteParams", 
		NodeName = "_RouteParams_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class RouteParams_Constructor : INode 
	{
		public Renga.IRouteParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IRouteParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "63D2EB36-A4E1-4CE4-B78E-DEF3B0DEDD86", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RouteParams.RouteParams_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RouteParams", 
		NodeName = "_RouteParams_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class RouteParams_ConstructorCast : INode 
	{
		public Renga.IRouteParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IRouteParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "8790CA31-8507-4D30-9BCE-66DCEBFC7EE2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RouteParams.GetContour", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RouteParams", 
		NodeName = "GetContour", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetContour : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContour);

		}
	}


	[NVP_Manifest(
		Id = "E657BF53-1723-454F-B93F-44A438217C9C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RouteParams.SourceModelObjectId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RouteParams", 
		NodeName = "SourceModelObjectId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SourceModelObjectId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SourceModelObjectId);

		}
	}


	[NVP_Manifest(
		Id = "2C198355-432C-4E2E-801D-5846336CB95F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RouteParams.TargetModelObjectId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RouteParams", 
		NodeName = "TargetModelObjectId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class TargetModelObjectId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TargetModelObjectId);

		}
	}


	[NVP_Manifest(
		Id = "264617F8-91C5-42B3-961A-C647600E60EC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RouteParams.SystemStyleId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RouteParams", 
		NodeName = "SystemStyleId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SystemStyleId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SystemStyleId);

		}
	}


	[NVP_Manifest(
		Id = "B2C40031-E89B-4914-9386-C95DBE9DD61F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RouteParams.GetJointCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RouteParams", 
		NodeName = "GetJointCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetJointCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetJointCount);

		}
	}


	[NVP_Manifest(
		Id = "3BF62F81-D1C6-48D5-830C-47B49E096924", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RouteParams.GetJointParams", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RouteParams", 
		NodeName = "GetJointParams", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetJointParams : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetJointParams);

		}
	}


	[NVP_Manifest(
		Id = "82C07D83-22E6-40A3-8F21-12A22AF71DBA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RouteParams.GetObjectOnRouteCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RouteParams", 
		NodeName = "GetObjectOnRouteCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetObjectOnRouteCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetObjectOnRouteCount);

		}
	}


	[NVP_Manifest(
		Id = "73EA3AD3-182B-42DF-93C1-537954C95CD5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RouteParams.GetObjectOnRoutePlacement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RouteParams", 
		NodeName = "GetObjectOnRoutePlacement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetObjectOnRoutePlacement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetObjectOnRoutePlacement);

		}
	}


	[NVP_Manifest(
		Id = "F9FCB980-3835-4322-9944-5DBFBAA7CE13", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RouteParams.GetFlowSegmentCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RouteParams", 
		NodeName = "GetFlowSegmentCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetFlowSegmentCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFlowSegmentCount);

		}
	}


	[NVP_Manifest(
		Id = "DD65957F-5012-4C0B-9458-CD9C80DBF2FD", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RouteParams.GetFlowSegmentPlacement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RouteParams", 
		NodeName = "GetFlowSegmentPlacement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetFlowSegmentPlacement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFlowSegmentPlacement);

		}
	}
}
