using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a 3D polyline of straight line segments entity
///</summary>
namespace OdaX.Acad3DPolyline 
{

	[NVP_Manifest(
		Id = "085CE6A8-BAA5-4759-8039-374F85B14F7A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DPolyline.Acad3DPolyline_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DPolyline", 
		NodeName = "_Acad3DPolyline_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Acad3DPolyline_Constructor : INode 
	{
		public OdaX.IAcad3DPolyline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcad3DPolyline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "95AF38B3-07B8-4BCA-BA97-4DCD956C1B26", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DPolyline.Acad3DPolyline_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DPolyline", 
		NodeName = "_Acad3DPolyline_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Acad3DPolyline_ConstructorCast : INode 
	{
		public OdaX.IAcad3DPolyline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcad3DPolyline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "CC6BC5F4-9995-47AA-8A78-3B58A7B309B4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DPolyline.Coordinates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DPolyline", 
		NodeName = "Coordinates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the current vertex of a 3D polyline.", 
		ViewType = "Data")]
	[NodeInput("Acad3DPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the current vertex of a 3D polyline.
	///</summary>
	public class Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Coordinates);

		}
	}


	[NVP_Manifest(
		Id = "F171563D-2B02-4E3F-A623-5737C4488789", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DPolyline.Set_Coordinates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DPolyline", 
		NodeName = "Set_Coordinates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the current vertex of a 3D polyline.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DPolyline", typeof(object))]
	[NodeInput("Coordinates", typeof(System.Object))]

	///<summary>
	///Specifies or returns the current vertex of a 3D polyline.
	///</summary>
	public class Set_Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Coordinates = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3B7F0BA7-8C09-4995-BC14-80B2DF885BF2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DPolyline.AppendVertex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DPolyline", 
		NodeName = "AppendVertex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Appends a vertex to a 3D polyline.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DPolyline", typeof(object))]
	[NodeInput("vertex", typeof(System.Object))]

	///<summary>
	///Appends a vertex to a 3D polyline.
	///</summary>
	public class AppendVertex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AppendVertex(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "20207F50-AE1F-4CA8-936F-E9E2EBF7E89D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DPolyline.Explode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DPolyline", 
		NodeName = "Explode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Explodes a 3D polyline.", 
		ViewType = "Data")]
	[NodeInput("Acad3DPolyline", typeof(object))]

	///<summary>
	///Explodes a 3D polyline.
	///</summary>
	public class Explode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explode);

		}
	}


	[NVP_Manifest(
		Id = "10D8B448-91C9-4A7D-8021-0036EC38FA57", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DPolyline.Coordinate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DPolyline", 
		NodeName = "Coordinate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the coordinate of a single vertex in an object.", 
		ViewType = "Data")]
	[NodeInput("Acad3DPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the coordinate of a single vertex in an object.
	///</summary>
	public class Coordinate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Coordinate(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "CA83C63C-D106-4C97-A544-BAB269D7ECE7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DPolyline.Set_Coordinate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DPolyline", 
		NodeName = "Set_Coordinate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the coordinate of a single vertex in an object.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the coordinate of a single vertex in an object.
	///</summary>
	public class Set_Coordinate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Coordinate[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Id = "218F1484-C376-4ED9-AAAB-EA7370ADD610", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DPolyline.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DPolyline", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the type of line or surface curve fitting.", 
		ViewType = "Data")]
	[NodeInput("Acad3DPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the type of line or surface curve fitting.
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		Id = "970954E7-2B65-4122-8D2F-18958627957A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DPolyline.Set_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DPolyline", 
		NodeName = "Set_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the type of line or surface curve fitting.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DPolyline", typeof(object))]
	[NodeInput("OdaX.Ac3DPolylineType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the type of line or surface curve fitting.
	///</summary>
	public class Set_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Type = ((OdaX.Ac3DPolylineType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FD7F19CF-BB58-4414-9B98-A00C432CB640", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DPolyline.Closed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DPolyline", 
		NodeName = "Closed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a 3D polyline is open or closed.", 
		ViewType = "Data")]
	[NodeInput("Acad3DPolyline", typeof(object))]

	///<summary>
	///Specifies or returns whether a 3D polyline is open or closed.
	///</summary>
	public class Closed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Closed);

		}
	}


	[NVP_Manifest(
		Id = "A64E134B-B384-48D7-A973-0979C18D2AA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DPolyline.Set_Closed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DPolyline", 
		NodeName = "Set_Closed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a 3D polyline is open or closed.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DPolyline", typeof(object))]
	[NodeInput("fClose", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a 3D polyline is open or closed.
	///</summary>
	public class Set_Closed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Closed = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F6CAC235-3FE5-4DF0-9119-D0C991A9F093", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DPolyline.Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DPolyline", 
		NodeName = "Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the length of a 3D polyline.", 
		ViewType = "Data")]
	[NodeInput("Acad3DPolyline", typeof(object))]

	///<summary>
	///Returns the length of a 3D polyline.
	///</summary>
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length);

		}
	}
}
