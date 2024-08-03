using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///The set of methods and properties used for plotting layouts
///</summary>
namespace nanoCAD.nanoCADPlotArea2 
{

	[NVP_Manifest(
		Id = "EAD9E124-6179-41B5-BBDC-F798ACDE5590", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.nanoCADPlotArea2_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "_nanoCADPlotArea2_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPlotArea2_Constructor : INode 
	{
		public nanoCAD.InanoCADPlotArea2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPlotArea2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "52349CEB-8D39-4C8E-862F-F83BCBD8E490", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.nanoCADPlotArea2_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "_nanoCADPlotArea2_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPlotArea2_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPlotArea2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPlotArea2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "A48141EC-3392-44EC-A5F1-C560F4516F97", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves position val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves position val
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
		Id = "132EA705-F047-4151-B542-C945421D0843", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves position val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves position val
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "44ADF58B-82F6-4106-A202-7712C1F4D333", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.Target", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "Target", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves target val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves target val
	///</summary>
	public class Target : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Target);

		}
	}


	[NVP_Manifest(
		Id = "EA61C79B-3574-4A58-A5E9-79842F85B63C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.Set_Target", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "Set_Target", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves target val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves target val
	///</summary>
	public class Set_Target : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Target = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BC456C17-9E5D-47DA-9393-4257979FB604", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.UpVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "UpVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves upVector val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves upVector val
	///</summary>
	public class UpVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UpVector);

		}
	}


	[NVP_Manifest(
		Id = "FBEE13B7-1AFC-4E0F-89F8-44CBB783855C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.Set_UpVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "Set_UpVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves upVector val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves upVector val
	///</summary>
	public class Set_UpVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UpVector = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "06DE850C-3A0D-4AC8-8EB4-41979F84067A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.Field", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "Field", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves field val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves field val
	///</summary>
	public class Field : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Field);

		}
	}


	[NVP_Manifest(
		Id = "F5223C40-F49C-4480-98EA-BF1478389708", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.Set_Field", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "Set_Field", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves field val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves field val
	///</summary>
	public class Set_Field : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Field = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "071D19B8-C035-40B9-9EBD-CD862F4559F9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.Perspective", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "Perspective", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves Perspective val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves Perspective val
	///</summary>
	public class Perspective : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Perspective);

		}
	}


	[NVP_Manifest(
		Id = "66CA3C52-714A-4C5B-825E-C99F1FBA60CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.Set_Perspective", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "Set_Perspective", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves Perspective val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves Perspective val
	///</summary>
	public class Set_Perspective : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Perspective = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "384E5104-33BF-4EDD-AA8C-77E99CD88841", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.LensLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "LensLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves lensLength val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves lensLength val
	///</summary>
	public class LensLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LensLength);

		}
	}


	[NVP_Manifest(
		Id = "0D791850-060E-4CF2-B6AB-7560EDBAE1F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.Set_LensLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "Set_LensLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves lensLength val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Double))]

	///<summary>
	///Retrieves lensLength val
	///</summary>
	public class Set_LensLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LensLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AC5E9F44-19D1-4400-9B45-615502FD8C57", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.Elevation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "Elevation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves elevation val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves elevation val
	///</summary>
	public class Elevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Elevation);

		}
	}


	[NVP_Manifest(
		Id = "D8E02FF7-5AFB-4221-AD35-67318E270E81", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.Set_Elevation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "Set_Elevation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves elevation val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Double))]

	///<summary>
	///Retrieves elevation val
	///</summary>
	public class Set_Elevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Elevation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D30DF4D2-F7B3-4173-AB6D-556F9D76F22D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.ViewOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "ViewOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves viewOffset val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves viewOffset val
	///</summary>
	public class ViewOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewOffset);

		}
	}


	[NVP_Manifest(
		Id = "5204597E-BCFD-41D2-A32C-1CECF5DE5032", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.Set_ViewOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "Set_ViewOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves viewOffset val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves viewOffset val
	///</summary>
	public class Set_ViewOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewOffset = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8880117E-4A4B-42BE-9BC1-BBA7E242798D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.ptWindow1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "ptWindow1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves ptWindow1 val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves ptWindow1 val
	///</summary>
	public class ptWindow1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ptWindow1);

		}
	}


	[NVP_Manifest(
		Id = "7A8FD2D1-4760-4979-AC81-F6806156A5AC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.Set_ptWindow1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "Set_ptWindow1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves ptWindow1 val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves ptWindow1 val
	///</summary>
	public class Set_ptWindow1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ptWindow1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "76A535F4-87AE-4A0D-8928-C1B5A58D0B1E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.ptWindow2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "ptWindow2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves ptWindow2 val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves ptWindow2 val
	///</summary>
	public class ptWindow2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ptWindow2);

		}
	}


	[NVP_Manifest(
		Id = "5E811ACA-C386-4208-99EC-6C41F9B75214", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea2.Set_ptWindow2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea2", 
		NodeName = "Set_ptWindow2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves ptWindow2 val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves ptWindow2 val
	///</summary>
	public class Set_ptWindow2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ptWindow2 = inputs[1].Value;
			return null;
		}
	}
}
