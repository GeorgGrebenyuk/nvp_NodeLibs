using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of 2D line with adjustable width composed of line and arc segments entity
///</summary>
namespace OdaX.AcadLWPolyline 
{

	[NVP_Manifest(
		Id = "59929AD1-6B4E-4737-928F-9E762896E6D9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.AcadLWPolyline_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "_AcadLWPolyline_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLWPolyline_Constructor : INode 
	{
		public OdaX.IAcadLWPolyline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadLWPolyline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "1D85B2C7-F913-4EC1-B4CA-0AE68C07F834", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.AcadLWPolyline_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "_AcadLWPolyline_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLWPolyline_ConstructorCast : INode 
	{
		public OdaX.IAcadLWPolyline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadLWPolyline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "02550052-0265-45A7-ADA3-E0711C5D81E4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.Coordinates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "Coordinates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the current vertex of a lightweight polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the current vertex of a lightweight polyline.
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
		Id = "A6BC24F7-5B82-49B6-8BE0-2A73FBA114E8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.Set_Coordinates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "Set_Coordinates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the current vertex of a lightweight polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Coordinates", typeof(System.Object))]

	///<summary>
	///Specifies or returns the current vertex of a lightweight polyline.
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
		Id = "3312D45A-E065-4CCE-85BE-CF058EA1D518", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	[NVP_Manifest(
		Id = "2FD31234-D6CB-4EAC-946E-EE2FB96A2BBC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.Set_Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "Set_Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	public class Set_Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Normal = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "37503485-7A5B-4B50-A717-71993215989D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "z-direction value) of a lightweight polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///z-direction value) of a lightweight polyline.
	///</summary>
	public class Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thickness);

		}
	}


	[NVP_Manifest(
		Id = "CEF22699-B390-4C19-9C97-43B3CF9D1D0E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.Set_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "Set_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "z-direction value) of a lightweight polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Thickness", typeof(System.Double))]

	///<summary>
	///z-direction value) of a lightweight polyline.
	///</summary>
	public class Set_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BB60D57D-3EB1-4F15-BFEF-F490F2EBDF44", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.AddVertex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "AddVertex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates and adds a new vertex to a lightweight polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("vertex", typeof(System.Object))]

	///<summary>
	///Creates and adds a new vertex to a lightweight polyline.
	///</summary>
	public class AddVertex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddVertex(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "42F1FC10-488B-4685-B58A-2216F207B97A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.Explode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "Explode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Explodes the lightweight polyline and returns the individual entities as an array of lines and arcs.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///Explodes the lightweight polyline and returns the individual entities as an array of lines and arcs.
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
		Id = "5703932B-6608-4935-AAD3-E38D398E4290", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.GetBulge", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "GetBulge", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the bulge value for a vertex of a lightweight polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Returns the bulge value for a vertex of a lightweight polyline.
	///</summary>
	public class GetBulge : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBulge(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "526444DA-A14A-48DE-8B56-3B46F2892CB6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.SetBulge", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "SetBulge", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the bulge value for a vertex of a lightweight polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("bulge", typeof(System.Double))]

	///<summary>
	///Specifies the bulge value for a vertex of a lightweight polyline.
	///</summary>
	public class SetBulge : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBulge(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "50464C22-0942-435C-B2AB-F01E3D210D28", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.GetWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "GetWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the width for a segment of a lightweight polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("StartWidth", typeof(System.Double))]
	[NodeInput("EndWidth", typeof(System.Double))]

	///<summary>
	///Returns the width for a segment of a lightweight polyline.
	///</summary>
	public class GetWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetWidth(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CFEAAB99-E569-4AEE-BB96-6D61D5E5C95E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.SetWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "SetWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the width for a segment of a lightweight polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("StartWidth", typeof(System.Double))]
	[NodeInput("EndWidth", typeof(System.Double))]

	///<summary>
	///Specifies the width for a segment of a lightweight polyline.
	///</summary>
	public class SetWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetWidth(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8CB5000D-AAED-4B2E-B990-2300CFB4DDA4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.ConstantWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "ConstantWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the width of the entire lightweight polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the width of the entire lightweight polyline.
	///</summary>
	public class ConstantWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConstantWidth);

		}
	}


	[NVP_Manifest(
		Id = "ADD970D2-2A64-4AF6-B7CD-1EC27670033A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.Set_ConstantWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "Set_ConstantWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the width of the entire lightweight polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies or returns the width of the entire lightweight polyline.
	///</summary>
	public class Set_ConstantWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ConstantWidth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7C63A7B0-8EA9-41C2-9C59-B71CA4C3DDA5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.Offset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "Offset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Creates a new lightweight polyline at a specified distance from an original lightweight polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Not implemented. Creates a new lightweight polyline at a specified distance from an original lightweight polyline.
	///</summary>
	public class Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Offset(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "7C1879DB-40D9-4E97-B9AA-EE49A3872B18", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.Elevation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "Elevation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the elevation of the lightweight polyline relative to the z-axis of the object's coordinate system.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the elevation of the lightweight polyline relative to the z-axis of the object's coordinate system.
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
		Id = "B6D8F8BC-1D2A-4A42-B298-3E9669B6226B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.Set_Elevation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "Set_Elevation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the elevation of the lightweight polyline relative to the z-axis of the object's coordinate system.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Elevation", typeof(System.Double))]

	///<summary>
	///Specifies or returns the elevation of the lightweight polyline relative to the z-axis of the object's coordinate system.
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
		Id = "C9972CF1-A6C3-4EFA-AC79-053B7CC066A7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.Area", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "Area", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the area encompassed by a lightweight polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///Returns the area encompassed by a lightweight polyline.
	///</summary>
	public class Area : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Area);

		}
	}


	[NVP_Manifest(
		Id = "7100A68D-4553-4303-8756-F1804E0DF5FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.Coordinate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "Coordinate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the coordinate of a single vertex in an object.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]
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
		Id = "A3BC13E1-7586-4740-9A11-94557AE31B75", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.Set_Coordinate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "Set_Coordinate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the coordinate of a single vertex in an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
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
		Id = "F21EE1D7-50C8-429D-9EB6-381D31B9A553", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.Closed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "Closed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a lightweight polyline is open or closed.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///Specifies or returns whether a lightweight polyline is open or closed.
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
		Id = "8D31FF4B-B2D5-4F46-8CCC-7CC3B9389BDE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.Set_Closed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "Set_Closed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a lightweight polyline is open or closed.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("fClose", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a lightweight polyline is open or closed.
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
		Id = "89C717AA-F181-4D2D-A10C-77F65E9FF68B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.LinetypeGeneration", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "LinetypeGeneration", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether linetype generation is used for a lightweight polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///Specifies or returns whether linetype generation is used for a lightweight polyline.
	///</summary>
	public class LinetypeGeneration : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinetypeGeneration);

		}
	}


	[NVP_Manifest(
		Id = "1DC2EDA7-EA01-4566-9AF9-05E2590C7678", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.Set_LinetypeGeneration", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "Set_LinetypeGeneration", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether linetype generation is used for a lightweight polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("bLinetypeGen", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether linetype generation is used for a lightweight polyline.
	///</summary>
	public class Set_LinetypeGeneration : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LinetypeGeneration = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "ABC5FE4F-5193-40C1-9022-F8FCC6C5483C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLWPolyline.Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLWPolyline", 
		NodeName = "Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the length of a lightweight polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///Specifies the length of a lightweight polyline.
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
