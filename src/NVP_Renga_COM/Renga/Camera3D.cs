using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Camera3D 
{

	[NVP_Manifest(
		Id = "CEB4F0A3-947D-4963-A45E-1FE6B057C3A2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Camera3D.Camera3D_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Camera3D", 
		NodeName = "_Camera3D_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Camera3D_Constructor : INode 
	{
		public Renga.ICamera3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ICamera3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "AF7FE139-6228-4294-87A9-B9A0D66ACB22", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Camera3D.Camera3D_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Camera3D", 
		NodeName = "_Camera3D_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Camera3D_ConstructorCast : INode 
	{
		public Renga.ICamera3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ICamera3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "80C0BD5F-C4BB-4F30-84EC-C74D33B2670F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Camera3D.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Camera3D", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Camera3D", typeof(object))]

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
		Id = "3532D9FF-712C-4556-969E-E173E652B98A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Camera3D.FocusPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Camera3D", 
		NodeName = "FocusPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Camera3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FocusPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FocusPoint);

		}
	}


	[NVP_Manifest(
		Id = "D0DDB920-B220-44ED-814B-9456155DFB58", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Camera3D.FovHorizontal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Camera3D", 
		NodeName = "FovHorizontal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Camera3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FovHorizontal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FovHorizontal);

		}
	}


	[NVP_Manifest(
		Id = "34A133BD-8B86-4347-9239-8854805C5A2C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Camera3D.FovVertical", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Camera3D", 
		NodeName = "FovVertical", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Camera3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FovVertical : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FovVertical);

		}
	}


	[NVP_Manifest(
		Id = "C30FCAE0-16E8-4FC5-B766-53B4AA36941E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Camera3D.LookAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Camera3D", 
		NodeName = "LookAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Camera3D", typeof(object))]
	[NodeInput("focusPoint_", typeof(System.Object))]
	[NodeInput("position_", typeof(System.Object))]
	[NodeInput("upVector_", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class LookAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LookAt(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F2EE2511-1655-48BB-87AA-3C1F51C88847", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Camera3D.UpVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Camera3D", 
		NodeName = "UpVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Camera3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class UpVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UpVector);

		}
	}
}
