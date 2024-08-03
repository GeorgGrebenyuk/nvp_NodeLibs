using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Arc3D 
{

	[NVP_Manifest(
		Id = "CBAED661-3176-4D6D-9545-27F1CD9033CE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc3D.Arc3D_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc3D", 
		NodeName = "_Arc3D_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Arc3D_Constructor : INode 
	{
		public Renga.IArc3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IArc3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "5BAE51FD-BCE9-45F7-AA52-20E4594ACDEF", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc3D.Arc3D_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc3D", 
		NodeName = "_Arc3D_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Arc3D_ConstructorCast : INode 
	{
		public Renga.IArc3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IArc3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "CE420031-443A-4D65-A37A-F60C08D26650", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc3D.GetPlacement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc3D", 
		NodeName = "GetPlacement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetPlacement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPlacement);

		}
	}


	[NVP_Manifest(
		Id = "CE269642-EC11-4D57-B604-3B941FEA02D4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc3D.GetRadius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc3D", 
		NodeName = "GetRadius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRadius);

		}
	}


	[NVP_Manifest(
		Id = "8BD01239-49FC-417E-86F3-3B8DAE993E09", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc3D.GetRadiusA", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc3D", 
		NodeName = "GetRadiusA", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetRadiusA : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRadiusA);

		}
	}


	[NVP_Manifest(
		Id = "E3D1A41B-D17D-4ED4-B0C8-539EBDF98B77", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc3D.GetRadiusB", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc3D", 
		NodeName = "GetRadiusB", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetRadiusB : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRadiusB);

		}
	}


	[NVP_Manifest(
		Id = "D822A4DB-4583-4F4C-B261-068262200654", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc3D.GetBeginAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc3D", 
		NodeName = "GetBeginAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetBeginAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBeginAngle);

		}
	}


	[NVP_Manifest(
		Id = "C89493E3-BB85-4B49-B10D-8C9DF12263B3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc3D.GetEndAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc3D", 
		NodeName = "GetEndAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetEndAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetEndAngle);

		}
	}


	[NVP_Manifest(
		Id = "BFD612DD-777C-4004-BFF9-0941ED1BB68A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc3D.GetCenter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc3D", 
		NodeName = "GetCenter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCenter);

		}
	}


	[NVP_Manifest(
		Id = "3975E131-E60D-493C-962C-162A9560F803", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc3D.IsCircular", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc3D", 
		NodeName = "IsCircular", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IsCircular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsCircular);

		}
	}
}
