using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ColumnParams 
{

	[NVP_Manifest(
		Id = "AEBB5A75-8FE2-4C3D-A8A8-64026D98E241", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ColumnParams.ColumnParams_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ColumnParams", 
		NodeName = "_ColumnParams_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ColumnParams_Constructor : INode 
	{
		public Renga.IColumnParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IColumnParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "5DC9A7C5-511F-47A4-9684-CA939E6447F5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ColumnParams.ColumnParams_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ColumnParams", 
		NodeName = "_ColumnParams_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ColumnParams_ConstructorCast : INode 
	{
		public Renga.IColumnParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IColumnParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "60EB1649-525A-4F43-BFB3-9AF866FF6846", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ColumnParams.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ColumnParams", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ColumnParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Id = "9352F6B1-1ED2-400E-9901-EB258D8D6383", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ColumnParams.StyleId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ColumnParams", 
		NodeName = "StyleId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ColumnParams", typeof(object))]

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
		Id = "50DD6388-FD35-465E-ADBB-A46A5179A6DE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ColumnParams.GetProfilePlacement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ColumnParams", 
		NodeName = "GetProfilePlacement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ColumnParams", typeof(object))]

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
		Id = "DCCCA2C5-434E-41C9-945F-840D39A250E1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ColumnParams.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ColumnParams", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ColumnParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Id = "C71080E2-0B67-4BC5-B5F5-1171C621FAF9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ColumnParams.VerticalOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ColumnParams", 
		NodeName = "VerticalOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ColumnParams", typeof(object))]

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
