using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a 3D triangle or quadrilateral plane section
///</summary>
namespace OdaX.Acad3DFace 
{

	[NVP_Manifest(
		Id = "084741B1-3A4E-4C0B-B6F8-9C7F0B99CF90", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DFace.Acad3DFace_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DFace", 
		NodeName = "_Acad3DFace_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Acad3DFace_Constructor : INode 
	{
		public OdaX.IAcad3DFace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcad3DFace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "3F46FB4D-55CE-4A48-8925-A36A08CBDF03", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DFace.Acad3DFace_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DFace", 
		NodeName = "_Acad3DFace_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Acad3DFace_ConstructorCast : INode 
	{
		public OdaX.IAcad3DFace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcad3DFace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "22FB646D-3AA3-46CE-B224-268B7F03842B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DFace.Coordinates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DFace", 
		NodeName = "Coordinates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the current vertex of a 3DFace object.", 
		ViewType = "Data")]
	[NodeInput("Acad3DFace", typeof(object))]

	///<summary>
	///Specifies the current vertex of a 3DFace object.
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
		Id = "B4A17165-4A4B-41CB-B37F-4AE2368299E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DFace.Set_Coordinates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DFace", 
		NodeName = "Set_Coordinates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the current vertex of a 3DFace object.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("corners", typeof(System.Object))]

	///<summary>
	///Specifies the current vertex of a 3DFace object.
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
		Id = "8B7D0FC9-E07B-4DB2-9407-E9D80BD44F65", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DFace.VisibilityEdge1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DFace", 
		NodeName = "VisibilityEdge1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether edge 1 of a 3DFace is visible or hidden.", 
		ViewType = "Data")]
	[NodeInput("Acad3DFace", typeof(object))]

	///<summary>
	///Specifies or returns whether edge 1 of a 3DFace is visible or hidden.
	///</summary>
	public class VisibilityEdge1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VisibilityEdge1);

		}
	}


	[NVP_Manifest(
		Id = "991FC701-FFD4-4393-81A8-55D54928FFC2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DFace.Set_VisibilityEdge1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DFace", 
		NodeName = "Set_VisibilityEdge1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether edge 1 of a 3DFace is visible or hidden.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("visibility", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether edge 1 of a 3DFace is visible or hidden.
	///</summary>
	public class Set_VisibilityEdge1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VisibilityEdge1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "299924D4-AE93-4F4A-89E4-E89835CE4652", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DFace.VisibilityEdge2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DFace", 
		NodeName = "VisibilityEdge2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether edge 2 of a 3DFace is visible or hidden.", 
		ViewType = "Data")]
	[NodeInput("Acad3DFace", typeof(object))]

	///<summary>
	///Specifies or returns whether edge 2 of a 3DFace is visible or hidden.
	///</summary>
	public class VisibilityEdge2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VisibilityEdge2);

		}
	}


	[NVP_Manifest(
		Id = "72AD09DA-5ABE-498B-8279-E2695139AD99", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DFace.Set_VisibilityEdge2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DFace", 
		NodeName = "Set_VisibilityEdge2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether edge 2 of a 3DFace is visible or hidden.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("visibility", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether edge 2 of a 3DFace is visible or hidden.
	///</summary>
	public class Set_VisibilityEdge2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VisibilityEdge2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A27F28FA-A18D-4802-AF45-053F6C392A07", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DFace.VisibilityEdge3", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DFace", 
		NodeName = "VisibilityEdge3", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether edge 3 of a 3DFace is visible or hidden.", 
		ViewType = "Data")]
	[NodeInput("Acad3DFace", typeof(object))]

	///<summary>
	///Specifies or returns whether edge 3 of a 3DFace is visible or hidden.
	///</summary>
	public class VisibilityEdge3 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VisibilityEdge3);

		}
	}


	[NVP_Manifest(
		Id = "6213E576-1738-4947-B393-7A9748E1F962", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DFace.Set_VisibilityEdge3", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DFace", 
		NodeName = "Set_VisibilityEdge3", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether edge 3 of a 3DFace is visible or hidden.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("visibility", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether edge 3 of a 3DFace is visible or hidden.
	///</summary>
	public class Set_VisibilityEdge3 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VisibilityEdge3 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4B964262-3071-463A-BA55-2E25FCB0C337", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DFace.VisibilityEdge4", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DFace", 
		NodeName = "VisibilityEdge4", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether edge 4 of a 3DFace is visible or hidden.", 
		ViewType = "Data")]
	[NodeInput("Acad3DFace", typeof(object))]

	///<summary>
	///Specifies or returns whether edge 4 of a 3DFace is visible or hidden.
	///</summary>
	public class VisibilityEdge4 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VisibilityEdge4);

		}
	}


	[NVP_Manifest(
		Id = "216D180D-937D-4E14-BA79-3C9F574F056D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DFace.Set_VisibilityEdge4", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DFace", 
		NodeName = "Set_VisibilityEdge4", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether edge 4 of a 3DFace is visible or hidden.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("visibility", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether edge 4 of a 3DFace is visible or hidden.
	///</summary>
	public class Set_VisibilityEdge4 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VisibilityEdge4 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2FE1B5A3-7D08-4D1D-BC72-68053CD492D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DFace.GetInvisibleEdge", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DFace", 
		NodeName = "GetInvisibleEdge", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the visibility status of a 3DFace edge.", 
		ViewType = "Data")]
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Returns the visibility status of a 3DFace edge.
	///</summary>
	public class GetInvisibleEdge : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetInvisibleEdge(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "D32525D6-BBAC-4639-8042-7F3E2D258F77", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DFace.SetInvisibleEdge", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DFace", 
		NodeName = "SetInvisibleEdge", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the visibility status of a 3DFace edge.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("State", typeof(System.Object))]

	///<summary>
	///Specifies the visibility status of a 3DFace edge.
	///</summary>
	public class SetInvisibleEdge : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetInvisibleEdge(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A212D09B-C842-480F-9323-353DDF48A787", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DFace.Coordinate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DFace", 
		NodeName = "Coordinate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the coordinate of a single vertex in an object.", 
		ViewType = "Data")]
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Specifies the coordinate of a single vertex in an object.
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
		Id = "4FA07973-6F12-439B-80F8-D1508638452E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DFace.Set_Coordinate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DFace", 
		NodeName = "Set_Coordinate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the coordinate of a single vertex in an object.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies the coordinate of a single vertex in an object.
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
}
