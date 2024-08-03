using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.WindowParams 
{

	[NVP_Manifest(
		Id = "7C0B0FB5-712D-4E3D-8E37-D35DF6D5E985", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WindowParams.WindowParams_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WindowParams", 
		NodeName = "_WindowParams_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WindowParams_Constructor : INode 
	{
		public Renga.IWindowParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IWindowParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "B52713DD-E762-409B-9FD3-38B94B7CDC5D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WindowParams.WindowParams_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WindowParams", 
		NodeName = "_WindowParams_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WindowParams_ConstructorCast : INode 
	{
		public Renga.IWindowParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IWindowParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "276AC288-5CFB-49D0-B8BC-7CE308CBD2B2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WindowParams.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WindowParams", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("WindowParams", typeof(object))]

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
		Id = "D611136A-8F0B-45C7-B878-10BC8AA09CBE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WindowParams.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WindowParams", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("WindowParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	[NVP_Manifest(
		Id = "59F6E442-FCF1-42B4-AC43-FE88244944BB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WindowParams.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WindowParams", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("WindowParams", typeof(object))]

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
		Id = "A9C96ACF-3262-4470-B85B-C78F9983BF38", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WindowParams.VerticalOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WindowParams", 
		NodeName = "VerticalOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("WindowParams", typeof(object))]

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


	[NVP_Manifest(
		Id = "A1499E64-42A9-4E90-943E-E35A469D313A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WindowParams.GetAffectedObjectIds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WindowParams", 
		NodeName = "GetAffectedObjectIds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("WindowParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetAffectedObjectIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetAffectedObjectIds();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "08BFCFB1-B632-4387-A48A-289746F1A1B3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WindowParams.CalculateProjection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WindowParams", 
		NodeName = "CalculateProjection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("WindowParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class CalculateProjection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CalculateProjection);

		}
	}
}
