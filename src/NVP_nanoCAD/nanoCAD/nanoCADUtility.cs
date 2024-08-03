using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///A series of methods provided for utility purposes
///</summary>
namespace nanoCAD.nanoCADUtility 
{

	[NVP_Manifest(
		Id = "CD55B3AE-3A8D-4F37-9D05-43155592C941", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.nanoCADUtility_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "_nanoCADUtility_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADUtility_Constructor : INode 
	{
		public nanoCAD.InanoCADUtility _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADUtility;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "837916B5-4019-44D7-9B0F-ED18E9790E34", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.nanoCADUtility_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "_nanoCADUtility_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADUtility_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADUtility _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADUtility;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "8A541D06-1090-4A69-A894-05EDF7B38AB2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.AngleToReal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "AngleToReal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "double) value", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Angle", typeof(System.String))]
	[NodeInput("Unit", typeof(System.Object))]

	///<summary>
	///double) value
	///</summary>
	public class AngleToReal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AngleToReal(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "4E2A9122-0E04-4FCE-A5D2-52E611E7FD3B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.AngleToString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "AngleToString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "double) value to a string", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Angle", typeof(System.Double))]
	[NodeInput("Unit", typeof(System.Object))]
	[NodeInput("precision", typeof(System.Int32))]

	///<summary>
	///double) value to a string
	///</summary>
	public class AngleToString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AngleToString(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "D028AA6A-4FBD-4E41-877F-CEB282832EAC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.DistanceToReal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "DistanceToReal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "double) value", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Distance", typeof(System.String))]
	[NodeInput("nanoCAD.AcUnits", typeof(System.Object))]

	///<summary>
	///double) value
	///</summary>
	public class DistanceToReal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DistanceToReal(inputs[1].Value,((nanoCAD.AcUnits)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		Id = "5781C067-AF4F-43E0-A6D5-7629FEF463B0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.RealToString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "RealToString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "double) value to a string", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Value", typeof(System.Double))]
	[NodeInput("nanoCAD.AcUnits", typeof(System.Object))]
	[NodeInput("precision", typeof(System.Int32))]

	///<summary>
	///double) value to a string
	///</summary>
	public class RealToString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RealToString(inputs[1].Value,((nanoCAD.AcUnits)inputs[2].Value),inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "82C595CD-D5AC-4F2C-BC09-66F53FC96A81", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.TranslateCoordinates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "TranslateCoordinates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Translates a point from one coordinate system to another coordinate system", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("nanoCAD.AcCoordinateSystem", typeof(System.Object))]
	[NodeInput("nanoCAD.AcCoordinateSystem", typeof(System.Object))]
	[NodeInput("Displacement", typeof(System.Int32))]
	[NodeInput("OCSNormal", typeof(System.Object))]

	///<summary>
	///Translates a point from one coordinate system to another coordinate system
	///</summary>
	public class TranslateCoordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TranslateCoordinates(inputs[1].Value,((nanoCAD.AcCoordinateSystem)inputs[2].Value),((nanoCAD.AcCoordinateSystem)inputs[3].Value),inputs[4].Value,inputs[5].Value));

		}
	}


	[NVP_Manifest(
		Id = "851549FA-AE57-454B-823D-85ED4738FB4B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.InitializeUserInput", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "InitializeUserInput", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Initializes the GetKeyword method", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Bits", typeof(System.Int32))]
	[NodeInput("KeyWordList", typeof(System.Object))]

	///<summary>
	///Initializes the GetKeyword method
	///</summary>
	public class InitializeUserInput : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InitializeUserInput(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F1358486-6E8A-4D16-A18C-A60A7F5CFEEB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.GetInteger", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "GetInteger", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets an integer value from the user", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets an integer value from the user
	///</summary>
	public class GetInteger : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetInteger(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "FE0AF87C-0CFA-4E0D-AD8D-FF350AC950BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.GetReal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "GetReal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "double) value from the user", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///double) value from the user
	///</summary>
	public class GetReal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetReal(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "619D4785-29AA-480D-B878-F383A1CF9A8A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.GetInput", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "GetInput", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Converts an input string from the user into a keyword index", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]

	///<summary>
	///Converts an input string from the user into a keyword index
	///</summary>
	public class GetInput : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetInput);

		}
	}


	[NVP_Manifest(
		Id = "BC08985B-C7D8-4E15-A438-73E326BF5EC9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.GetKeyword", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "GetKeyword", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets a keyword string from the user", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets a keyword string from the user
	///</summary>
	public class GetKeyword : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetKeyword(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "48F1B524-9722-4929-AB81-E51E3C3FD779", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.GetString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "GetString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets a string from the user", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("HasSpaces", typeof(System.Int32))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets a string from the user
	///</summary>
	public class GetString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetString(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "A32A4195-43B5-41F2-AEE8-27E570ED95E6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.GetAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "GetAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the angle specified. Considers the setting of the ANGBASE system variable", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets the angle specified. Considers the setting of the ANGBASE system variable
	///</summary>
	public class GetAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAngle(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "D7040C14-1CFC-429A-9E68-00F1568B7665", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.AngleFromXAxis", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "AngleFromXAxis", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the angle of a line from the X axis", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("StartPoint", typeof(System.Object))]
	[NodeInput("EndPoint", typeof(System.Object))]

	///<summary>
	///Gets the angle of a line from the X axis
	///</summary>
	public class AngleFromXAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AngleFromXAxis(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "C816734D-FE2D-462D-91FB-90ACCDDBA4CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.GetCorner", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "GetCorner", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets a corner of a rectangle", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets a corner of a rectangle
	///</summary>
	public class GetCorner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCorner(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "31A512A0-F754-44CC-B03E-A857D0D282BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.GetDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "GetDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the distance from the prompt line or a selected set of points on the screen", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets the distance from the prompt line or a selected set of points on the screen
	///</summary>
	public class GetDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetDistance(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "A59D520B-B0E0-4A7C-AAEB-3A7F6060B4B2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.GetOrientation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "GetOrientation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the angle specified. Ignores the setting of the ANGBASE system variable", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets the angle specified. Ignores the setting of the ANGBASE system variable
	///</summary>
	public class GetOrientation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetOrientation(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "E8F28C48-F0CC-419E-8738-508DA2366538", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.GetPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "GetPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the point selected", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets the point selected
	///</summary>
	public class GetPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPoint(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "81B4DB71-BE80-42D6-9992-3DCC28B11FC3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.PolarPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "PolarPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the point at a specified angle and distance from a given point", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Angle", typeof(System.Double))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Gets the point at a specified angle and distance from a given point
	///</summary>
	public class PolarPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PolarPoint(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "B45069BE-D1D4-4912-91D3-323DE5539DB6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.CreateTypedArray", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "CreateTypedArray", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a variant that contains an array of typed arguments", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("varArr", typeof(System.Object))]
	[NodeInput("Type", typeof(System.Int32))]

	///<summary>
	///Creates a variant that contains an array of typed arguments
	///</summary>
	public class CreateTypedArray : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateTypedArray(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "6B8D31C5-4114-4DFE-B4AF-F85B7B5AC0E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.GetEntity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "GetEntity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets an object interactively", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Object", typeof(System.Object))]
	[NodeInput("PickedPoint", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets an object interactively
	///</summary>
	public class GetEntity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetEntity(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5A06D6C5-6322-4839-B8C1-33EFBA9C4EE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.Prompt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "Prompt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Posts a prompt to the command line", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Message", typeof(System.String))]

	///<summary>
	///Posts a prompt to the command line
	///</summary>
	public class Prompt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Prompt(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "91662FA8-8FE2-4426-88FE-4F0CA64DA3FB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.GetSubEntity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "GetSubEntity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets an object or subentity interactively", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Object", typeof(System.Object))]
	[NodeInput("PickedPoint", typeof(System.Object))]
	[NodeInput("transMatrix", typeof(System.Object))]
	[NodeInput("ContextData", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets an object or subentity interactively
	///</summary>
	public class GetSubEntity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetSubEntity(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9CCC71F7-8DCC-4926-BEA1-3691E6CACE3B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.IsURL", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "IsURL", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Validates a given URL", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("URL", typeof(System.String))]

	///<summary>
	///Validates a given URL
	///</summary>
	public class IsURL : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsURL(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "BEEB69A3-3209-4D20-BA74-CF1C3ADB3EAA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.GetRemoteFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "GetRemoteFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Downloads the file specified by a URL", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("URL", typeof(System.String))]
	[NodeInput("LocalFile", typeof(System.String))]
	[NodeInput("IgnoreCache", typeof(System.Object))]

	///<summary>
	///Downloads the file specified by a URL
	///</summary>
	public class GetRemoteFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetRemoteFile(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "82EB8B43-D6AA-4FD2-A5BE-5E124FC00CB1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.PutRemoteFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "PutRemoteFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Uploads a file to a remote location specified by a URL", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("URL", typeof(System.String))]
	[NodeInput("LocalFile", typeof(System.String))]

	///<summary>
	///Uploads a file to a remote location specified by a URL
	///</summary>
	public class PutRemoteFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PutRemoteFile(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C3A887AB-DC0E-4609-9D73-6415191CC3D5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.IsRemoteFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "IsRemoteFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the URL that a remote file was downloaded from", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("LocalFile", typeof(System.String))]
	[NodeInput("URL", typeof(System.Object))]

	///<summary>
	///Returns the URL that a remote file was downloaded from
	///</summary>
	public class IsRemoteFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsRemoteFile(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "AF8C135F-F7B8-4800-A914-1D434A9C7158", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.LaunchBrowserDialog", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "LaunchBrowserDialog", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Launches the Web Browser dialog that allows the user to navigate to any URL and select a URL", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("SelectedURL", typeof(System.String))]
	[NodeInput("DialogTitle", typeof(System.String))]
	[NodeInput("OpenButtonCaption", typeof(System.String))]
	[NodeInput("StartPageURL", typeof(System.String))]
	[NodeInput("RegistryRootKey", typeof(System.String))]
	[NodeInput("OpenButtonAlwaysEnabled", typeof(System.Object))]

	///<summary>
	///Launches the Web Browser dialog that allows the user to navigate to any URL and select a URL
	///</summary>
	public class LaunchBrowserDialog : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LaunchBrowserDialog(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value,inputs[6].Value));

		}
	}


	[NVP_Manifest(
		Id = "EAF62618-3CA7-4823-B682-E48BBEF2E6CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.CreateSafeArrayFromVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "CreateSafeArrayFromVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a safearray from variant", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("varVec", typeof(System.Object))]

	///<summary>
	///Creates a safearray from variant
	///</summary>
	public class CreateSafeArrayFromVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CreateSafeArrayFromVector(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3B9910D1-EBA8-4E57-93E2-E234BD4104CA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.CreateTypedArrayFromJSArray", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "CreateTypedArrayFromJSArray", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a safearray from variant", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Type", typeof(System.Int32))]
	[NodeInput("varJSArray", typeof(System.Object))]

	///<summary>
	///Creates a safearray from variant
	///</summary>
	public class CreateTypedArrayFromJSArray : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateTypedArrayFromJSArray(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "67A8AB65-2B6F-47F9-AE36-24F2F42222FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.AnalyzeEnt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "AnalyzeEnt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Analyze an ent", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("ent", typeof(System.Object))]

	///<summary>
	///Analyze an ent
	///</summary>
	public class AnalyzeEnt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AnalyzeEnt(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A6360517-B477-4023-B8BE-4981F42466B9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.GetPolyline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "GetPolyline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Analyze an ent", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Prompt", typeof(System.Object))]
	[NodeInput("secondPrompt", typeof(System.Object))]
	[NodeInput("closed", typeof(System.Object))]

	///<summary>
	///Analyze an ent
	///</summary>
	public class GetPolyline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPolyline(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "F1E4BF23-9646-40A6-9F9A-84667586619D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.Matrix4x4", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "Matrix4x4", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Create Matrix - safe array", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("str", typeof(System.String))]

	///<summary>
	///Create Matrix - safe array
	///</summary>
	public class Matrix4x4 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Matrix4x4(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "1495A771-7BE3-4E1B-AF6C-832174E45E23", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.TranslateString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "TranslateString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Translates string", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("inStr", typeof(System.String))]

	///<summary>
	///Translates string
	///</summary>
	public class TranslateString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TranslateString(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "29CA37ED-034F-446A-B728-831DB3FFF8EC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.ChooseFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "ChooseFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Displays ChooseFile dialog", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("title", typeof(System.String))]
	[NodeInput("format", typeof(System.String))]
	[NodeInput("flags", typeof(System.Object))]
	[NodeInput("folder", typeof(System.String))]

	///<summary>
	///Displays ChooseFile dialog
	///</summary>
	public class ChooseFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ChooseFile(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "3EAC9D99-D65D-4B76-89AE-7538BC5BB0EF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.ChooseFolder", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "ChooseFolder", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Displays ChooseFolder dialog", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("title", typeof(System.String))]
	[NodeInput("inifolder", typeof(System.String))]

	///<summary>
	///Displays ChooseFolder dialog
	///</summary>
	public class ChooseFolder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ChooseFolder(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "395666E8-0F78-4288-B78B-CF6F8E631B90", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.ShellExec", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "ShellExec", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "ShellExec", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("op", typeof(System.String))]
	[NodeInput("file", typeof(System.String))]
	[NodeInput("param", typeof(System.String))]
	[NodeInput("dir", typeof(System.String))]
	[NodeInput("flags", typeof(System.Object))]

	///<summary>
	///ShellExec
	///</summary>
	public class ShellExec : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShellExec(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A82DB865-4C34-462F-B766-F1171F59B215", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.NewDatabase", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "NewDatabase", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Create new empty database", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]

	///<summary>
	///Create new empty database
	///</summary>
	public class NewDatabase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NewDatabase);

		}
	}


	[NVP_Manifest(
		Id = "DBD0F0EC-3D58-4271-BD83-49215671C3B5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.OpenDatabase", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "OpenDatabase", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Open database", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Open database
	///</summary>
	public class OpenDatabase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OpenDatabase(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "51A9FE7C-D43F-45B2-A265-409CB178AA53", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.SaveDatabase", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "SaveDatabase", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Save database", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("FullFileName", typeof(System.String))]
	[NodeInput("SaveAsType", typeof(System.Object))]
	[NodeInput("vSecurityParams", typeof(System.Object))]

	///<summary>
	///Save database
	///</summary>
	public class SaveDatabase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveDatabase(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "844FA270-6576-4DCF-9CCE-CA92E94D71CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.ShowMenu", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "ShowMenu", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Show menu", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("menu", typeof(System.Object))]
	[NodeInput("x", typeof(System.Object))]
	[NodeInput("y", typeof(System.Object))]

	///<summary>
	///Show menu
	///</summary>
	public class ShowMenu : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowMenu(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "751748C5-7690-4A8E-9821-D29D97BB920E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.GetWinNum", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "GetWinNum", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "hostGetWinNum", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]

	///<summary>
	///hostGetWinNum
	///</summary>
	public class GetWinNum : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetWinNum(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "26580C3D-BAD7-4570-9D8A-E4B511DE6763", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.CoordFromPixelToWorld", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "CoordFromPixelToWorld", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "hostCoordFromPixelToWorld", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("num", typeof(System.Object))]
	[NodeInput("Point", typeof(System.Object))]

	///<summary>
	///hostCoordFromPixelToWorld
	///</summary>
	public class CoordFromPixelToWorld : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CoordFromPixelToWorld(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "78B8100A-9705-4784-BE0F-A339E62063A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.CoordFromWorldToPixel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "CoordFromWorldToPixel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "hostCoordFromWorldToPixel", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("num", typeof(System.Object))]
	[NodeInput("Point", typeof(System.Object))]

	///<summary>
	///hostCoordFromWorldToPixel
	///</summary>
	public class CoordFromWorldToPixel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CoordFromWorldToPixel(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "EB86F53A-AF10-4A0C-BCE5-3AAAFA54FD43", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADUtility.GetObjectIdString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADUtility", 
		NodeName = "GetObjectIdString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Converts ObjectId to string", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Object", typeof(System.Object))]
	[NodeInput("asHex", typeof(System.Object))]

	///<summary>
	///Converts ObjectId to string
	///</summary>
	public class GetObjectIdString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetObjectIdString(inputs[1].Value,inputs[2].Value));

		}
	}
}
