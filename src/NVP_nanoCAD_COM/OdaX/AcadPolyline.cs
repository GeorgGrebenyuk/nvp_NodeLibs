using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a 2D line of adjustable width or a 3D line or mesh of nonadjustable width composed of line and arc segments
///</summary>
namespace OdaX.AcadPolyline 
{

	[NVP_Manifest(
		Id = "6ADA932D-F991-47AC-A267-79B10AE82FA7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.AcadPolyline_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "_AcadPolyline_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPolyline_Constructor : INode 
	{
		public OdaX.IAcadPolyline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadPolyline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "12033D69-D210-4954-9AD8-4EAA57D98387", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.AcadPolyline_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "_AcadPolyline_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPolyline_ConstructorCast : INode 
	{
		public OdaX.IAcadPolyline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadPolyline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "BA65A189-C710-4ED4-BB06-31B810A58E98", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Coordinates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Coordinates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the current vertex of a polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the current vertex of a polyline.
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
		Id = "D4FFE6EB-4DE4-4DEB-AE2E-CC21F35638EC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Set_Coordinates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Set_Coordinates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the current vertex of a polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("Coordinates", typeof(System.Object))]

	///<summary>
	///Specifies or returns the current vertex of a polyline.
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
		Id = "35D7B065-1F2C-4E66-99F3-7E233A9D20BB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

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
		Id = "3F3612FC-DE66-45F2-8FBF-30E250C13AF2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Set_Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Set_Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
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
		Id = "A4F07ADE-1439-414E-8F5F-912E54AEFF0C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "z-direction value) of a polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///z-direction value) of a polyline.
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
		Id = "67570706-BA49-42B0-B788-0DADE30DEA04", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Set_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Set_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "z-direction value) of a polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("Thickness", typeof(System.Double))]

	///<summary>
	///z-direction value) of a polyline.
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
		Id = "A40ADBA9-E4C2-4A4B-8915-E5F615AF1194", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.AppendVertex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "AppendVertex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Appends a new vertex to a polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("vertex", typeof(System.Object))]

	///<summary>
	///Appends a new vertex to a polyline.
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
		Id = "15BC3E17-7C2D-41E5-BA9C-C97E6D3FA239", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Explode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Explode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Explodes the polyline and returns the individual entities as an array of the object.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///Explodes the polyline and returns the individual entities as an array of the object.
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
		Id = "31B131AC-4C60-48E6-9375-F60710978A57", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.GetBulge", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "GetBulge", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the bulge value for a vertex of a polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Returns the bulge value for a vertex of a polyline.
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
		Id = "BEF19893-4B5B-470C-97F7-24F9CB8AC5C6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.SetBulge", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "SetBulge", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the bulge value for a vertex of a polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("bulge", typeof(System.Double))]

	///<summary>
	///Specifies the bulge value for a vertex of a polyline.
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
		Id = "FFCF642B-F2A4-43D7-A762-6F3F071349FE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.GetWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "GetWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the width for a segment of a polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("StartWidth", typeof(System.Double))]

	///<summary>
	///Returns the width for a segment of a polyline.
	///</summary>
	public class GetWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetWidth(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "95EC3642-257B-4838-B087-BBC0AB1BE045", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.SetWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "SetWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the width for a segment of a polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("StartWidth", typeof(System.Double))]

	///<summary>
	///Specifies the width for a segment of a polyline.
	///</summary>
	public class SetWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetWidth(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "768EAC12-34E6-46AD-9F23-2680B85578A7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.ConstantWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "ConstantWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the width of the entire polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the width of the entire polyline.
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
		Id = "17F30157-4AEB-4E14-BDB4-55843CC8680A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Set_ConstantWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Set_ConstantWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the width of the entire polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies or returns the width of the entire polyline.
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
		Id = "92958C5C-BF80-4BFF-8092-1B29F7FA6232", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Offset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Offset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Creates a new polyline at a specified distance from an original lightweight polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Not implemented. Creates a new polyline at a specified distance from an original lightweight polyline.
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
		Id = "2C8E1B08-883E-410A-B79D-6DA3734D2F87", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Elevation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Elevation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the elevation of the polyline relative to the z-axis of the object's coordinate system.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the elevation of the polyline relative to the z-axis of the object's coordinate system.
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
		Id = "4135B48E-BE40-4E4D-9347-3B501D868BF9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Set_Elevation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Set_Elevation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the elevation of the polyline relative to the z-axis of the object's coordinate system.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("Elevation", typeof(System.Double))]

	///<summary>
	///Specifies or returns the elevation of the polyline relative to the z-axis of the object's coordinate system.
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
		Id = "2333DA86-2627-466C-AFF2-277C4E92A8D3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the type of polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the type of polyline.
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
		Id = "B3B21849-043B-41AA-8D5B-A4097EB04F39", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Set_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Set_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the type of polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("OdaX.AcPolylineType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the type of polyline.
	///</summary>
	public class Set_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Type = ((OdaX.AcPolylineType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B2EC00E3-BA7F-48A8-96D0-79D4B695640E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Closed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Closed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a polyline is open or closed.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///Specifies or returns whether a polyline is open or closed.
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
		Id = "F56D55C1-D7C7-449C-A2BF-001753EE58C7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Set_Closed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Set_Closed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a polyline is open or closed.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("fClose", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a polyline is open or closed.
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
		Id = "302EB2E8-8FDB-443A-96FE-7E867CAD36D5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.LinetypeGeneration", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "LinetypeGeneration", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether linetype generation is used for a polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///Specifies or returns whether linetype generation is used for a polyline.
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
		Id = "E9EB8297-7DD0-4BF5-97E9-312E0E9C6D00", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Set_LinetypeGeneration", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Set_LinetypeGeneration", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether linetype generation is used for a polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("bLinetypeGen", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether linetype generation is used for a polyline.
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
		Id = "EE3CE585-FCC4-48FE-BCE9-7D68716462BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Area", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Area", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the area of a polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///Specifies the area of a polyline.
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
		Id = "9B600950-2A95-4225-972A-4D0385A3F1A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Coordinate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Coordinate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the coordinate of a single vertex in an object.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]
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
		Id = "E5BB5E24-DDFD-4CD9-82A9-ED26DFFE9192", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Set_Coordinate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Set_Coordinate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the coordinate of a single vertex in an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
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
		Id = "167F716B-6CD5-4C4D-BC99-B3C823B42A1D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyline.Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyline", 
		NodeName = "Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the length of a polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///Specifies the length of a polyline.
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
