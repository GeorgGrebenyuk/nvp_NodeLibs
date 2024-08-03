using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.WallContour 
{

	[NVP_Manifest(
		Id = "DF22925B-7E7E-4E9B-9398-98F564D15C06", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WallContour.WallContour_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WallContour", 
		NodeName = "_WallContour_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WallContour_Constructor : INode 
	{
		public Renga.IWallContour _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IWallContour;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "F18E3499-0CC2-4395-9527-9C6DBB5C509D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WallContour.WallContour_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WallContour", 
		NodeName = "_WallContour_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WallContour_ConstructorCast : INode 
	{
		public Renga.IWallContour _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IWallContour;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "98D26EAC-A8AB-4B6B-B22B-B23872A3E507", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WallContour.GetCenterLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WallContour", 
		NodeName = "GetCenterLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("WallContour", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetCenterLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCenterLine);

		}
	}


	[NVP_Manifest(
		Id = "C5A00CE3-D14A-48B0-BADA-519963CD6A64", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WallContour.GetBaseline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WallContour", 
		NodeName = "GetBaseline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("WallContour", typeof(object))]

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
		Id = "750799DB-9279-4DBF-B577-EE1F43F10967", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WallContour.GetLeftCurve", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WallContour", 
		NodeName = "GetLeftCurve", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("WallContour", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetLeftCurve : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLeftCurve);

		}
	}


	[NVP_Manifest(
		Id = "F6DFF1BE-30AB-4FD3-A12B-2BF1C628C231", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WallContour.GetRightCurve", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WallContour", 
		NodeName = "GetRightCurve", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("WallContour", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetRightCurve : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRightCurve);

		}
	}


	[NVP_Manifest(
		Id = "931B1B08-0253-4BEE-995D-E10E18B5C70B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WallContour.GetBeginCurve", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WallContour", 
		NodeName = "GetBeginCurve", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("WallContour", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetBeginCurve : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBeginCurve);

		}
	}


	[NVP_Manifest(
		Id = "7CC6600C-96CB-40BB-AB11-E1534D59B04C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WallContour.GetEndCurve", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WallContour", 
		NodeName = "GetEndCurve", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("WallContour", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetEndCurve : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetEndCurve);

		}
	}


	[NVP_Manifest(
		Id = "A7BD8225-BAA4-4351-85A0-D9654F95BFAC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WallContour.GetContour", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WallContour", 
		NodeName = "GetContour", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("WallContour", typeof(object))]

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
}
