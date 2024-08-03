using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of Helix entity
///</summary>
namespace OdaX.AcadHelix 
{

	[NVP_Manifest(
		Id = "FE726994-D241-49BE-ABBC-279D1FC34E82", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.AcadHelix_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "_AcadHelix_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadHelix_Constructor : INode 
	{
		public OdaX.IAcadHelix _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadHelix;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "555E3125-ACEC-4930-8579-B212A8F59511", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.AcadHelix_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "_AcadHelix_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadHelix_ConstructorCast : INode 
	{
		public OdaX.IAcadHelix _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadHelix;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "3C6E2C96-556F-4520-98D1-A4C4ECA08869", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates for the base center point of a helix.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates for the base center point of a helix.
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
		Id = "C3B5712A-55AA-4FBA-871C-DA191C146B8F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates for the base center point of a helix.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("StartPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates for the base center point of a helix.
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
		Id = "F3A65415-9C17-4E97-B02D-151B2B819949", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.Constrain", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "Constrain", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the property that is contrained to remain constant when changing other properties of a helix.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Specifies or returns the property that is contrained to remain constant when changing other properties of a helix.
	///</summary>
	public class Constrain : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Constrain);

		}
	}


	[NVP_Manifest(
		Id = "833905CC-8286-42E0-8102-468B9B04D0B9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.Set_Constrain", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "Set_Constrain", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the property that is contrained to remain constant when changing other properties of a helix.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("OdaX.AcHelixConstrainType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the property that is contrained to remain constant when changing other properties of a helix.
	///</summary>
	public class Set_Constrain : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Constrain = ((OdaX.AcHelixConstrainType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7C8FC9DB-6953-4AEF-B240-0377FA2FE192", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the height of a helix.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Specifies or returns the height of a helix.
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
		Id = "7D963BAC-0A59-46BC-9746-F0FEE34A984D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the height of a helix.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("Length", typeof(System.Double))]

	///<summary>
	///Specifies or returns the height of a helix.
	///</summary>
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "77841B2F-9FDA-484C-9F2F-22DA164B3BC1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.Turns", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "Turns", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of turns for a helix.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Specifies or returns the number of turns for a helix.
	///</summary>
	public class Turns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Turns);

		}
	}


	[NVP_Manifest(
		Id = "CD0E96C6-DF05-44F9-B351-9375206E3C00", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.Set_Turns", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "Set_Turns", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of turns for a helix.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("Turns", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of turns for a helix.
	///</summary>
	public class Set_Turns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Turns = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DD939219-B36A-4D64-819C-2028BE212181", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.TurnHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "TurnHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the height of a single turn for a helix.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Specifies or returns the height of a single turn for a helix.
	///</summary>
	public class TurnHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TurnHeight);

		}
	}


	[NVP_Manifest(
		Id = "888DCA84-E9A8-4A43-B5E5-30AF1E3A4206", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.Set_TurnHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "Set_TurnHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the height of a single turn for a helix.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Specifies or returns the height of a single turn for a helix.
	///</summary>
	public class Set_TurnHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TurnHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E646D865-5398-4A02-968D-681B9818B44F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.BaseRadius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "BaseRadius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the radius of the base of a helix.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Specifies or returns the radius of the base of a helix.
	///</summary>
	public class BaseRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BaseRadius);

		}
	}


	[NVP_Manifest(
		Id = "3DF4B8EF-F57F-4B1D-9BFD-7B2AA0EF82ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.Set_BaseRadius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "Set_BaseRadius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the radius of the base of a helix.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("Radius", typeof(System.Double))]

	///<summary>
	///Specifies or returns the radius of the base of a helix.
	///</summary>
	public class Set_BaseRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BaseRadius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E4F6FEEA-3079-4475-9384-9C19590B4DCA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.TopRadius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "TopRadius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the radius of the top of a helix.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Specifies or returns the radius of the top of a helix.
	///</summary>
	public class TopRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TopRadius);

		}
	}


	[NVP_Manifest(
		Id = "738F038D-71CE-4203-8A82-F988846F2FE4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.Set_TopRadius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "Set_TopRadius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the radius of the top of a helix.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("Radius", typeof(System.Double))]

	///<summary>
	///Specifies or returns the radius of the top of a helix.
	///</summary>
	public class Set_TopRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TopRadius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5F4C8268-8BD4-493E-B5BE-91AB8F2830A1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.Twist", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "Twist", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the direction in which a helix turns.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Specifies or returns the direction in which a helix turns.
	///</summary>
	public class Twist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Twist);

		}
	}


	[NVP_Manifest(
		Id = "FCDCAB92-18A6-4C08-9781-DDA3A7725868", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.Set_Twist", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "Set_Twist", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the direction in which a helix turns.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("OdaX.AcHelixTwistType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the direction in which a helix turns.
	///</summary>
	public class Set_Twist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Twist = ((OdaX.AcHelixTwistType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "ED06098D-49FE-46E1-B34D-DDA0CB33988B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.TurnSlope", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "TurnSlope", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the slope angle in which a helix turns along a path.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Returns the slope angle in which a helix turns along a path.
	///</summary>
	public class TurnSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TurnSlope);

		}
	}


	[NVP_Manifest(
		Id = "07A8B80D-D8A7-45BB-86FA-04EDED6BD0EC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHelix.TotalLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHelix", 
		NodeName = "TotalLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the length of a helix.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Specifies the length of a helix.
	///</summary>
	public class TotalLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TotalLength);

		}
	}
}
