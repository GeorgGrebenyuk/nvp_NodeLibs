using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a circular arc entity
///</summary>
namespace OdaX.AcadArc 
{

	[NVP_Manifest(
		Id = "89429E53-8318-4D45-91DF-45904FF36914", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.AcadArc_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "_AcadArc_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadArc_Constructor : INode 
	{
		public OdaX.IAcadArc _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadArc;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A36B8ED1-520A-4DD0-BC2E-418803EB8FB6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.AcadArc_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "_AcadArc_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadArc_ConstructorCast : INode 
	{
		public OdaX.IAcadArc _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadArc;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "709C044C-B767-4CD6-9F9A-B61A8B0DB962", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.StartPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "StartPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the x, y, and z coordinates of an arc's start point.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Returns the x, y, and z coordinates of an arc's start point.
	///</summary>
	public class StartPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartPoint);

		}
	}


	[NVP_Manifest(
		Id = "82310D63-E7D1-4450-BA81-B44268E36348", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of an arc's center point.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of an arc's center point.
	///</summary>
	public class Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Center);

		}
	}


	[NVP_Manifest(
		Id = "0E02400C-F0D3-4FA9-BF90-E92EA241E9DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.Set_Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "Set_Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of an arc's center point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadArc", typeof(object))]
	[NodeInput("CenterPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of an arc's center point.
	///</summary>
	public class Set_Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Center = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C851A864-9EB4-4395-8470-2F45EDAA10E4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.EndPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "EndPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the x, y, and z coordinates of an arc's end point.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Returns the x, y, and z coordinates of an arc's end point.
	///</summary>
	public class EndPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndPoint);

		}
	}


	[NVP_Manifest(
		Id = "EF3FB086-0A54-42CD-9AAD-458121EFFB57", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.Radius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "Radius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the radius of an arc.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Specifies or returns the radius of an arc.
	///</summary>
	public class Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Radius);

		}
	}


	[NVP_Manifest(
		Id = "A9375292-45C5-4787-BD98-77105FA319ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.Set_Radius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "Set_Radius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the radius of an arc.", 
		ViewType = "Modifier")]
	[NodeInput("AcadArc", typeof(object))]
	[NodeInput("Radius", typeof(System.Double))]

	///<summary>
	///Specifies or returns the radius of an arc.
	///</summary>
	public class Set_Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Radius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "67665BA6-3FC7-443B-BF79-88DC1000890B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.StartAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "StartAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start angle of an arc.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Specifies or returns the start angle of an arc.
	///</summary>
	public class StartAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartAngle);

		}
	}


	[NVP_Manifest(
		Id = "D42DF93F-3277-427E-9D27-04A56002A0FA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.Set_StartAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "Set_StartAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start angle of an arc.", 
		ViewType = "Modifier")]
	[NodeInput("AcadArc", typeof(object))]
	[NodeInput("Angle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the start angle of an arc.
	///</summary>
	public class Set_StartAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CAFD0B11-43F7-4AD2-8D18-1B6DC18D5398", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.EndAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "EndAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the end angle of an arc.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Specifies or returns the end angle of an arc.
	///</summary>
	public class EndAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndAngle);

		}
	}


	[NVP_Manifest(
		Id = "60ABB8FA-5FBD-41B8-A8EF-5964005E590D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.Set_EndAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "Set_EndAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the end angle of an arc.", 
		ViewType = "Modifier")]
	[NodeInput("AcadArc", typeof(object))]
	[NodeInput("Angle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the end angle of an arc.
	///</summary>
	public class Set_EndAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9C1DDA01-24F0-4009-84B1-2F60989D6BF0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.TotalAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "TotalAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the total angle of an arc.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Returns the total angle of an arc.
	///</summary>
	public class TotalAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TotalAngle);

		}
	}


	[NVP_Manifest(
		Id = "D83AED0F-4148-43A0-B944-6174B5571436", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.ArcLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "ArcLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the length of an arc.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Returns the length of an arc.
	///</summary>
	public class ArcLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArcLength);

		}
	}


	[NVP_Manifest(
		Id = "7BD467F0-8B4F-406C-804A-BB276D668672", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "z-direction value) of an arc.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///z-direction value) of an arc.
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
		Id = "42C5298A-E956-46EC-B2D0-9D6E8629C49D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.Set_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "Set_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "z-direction value) of an arc.", 
		ViewType = "Modifier")]
	[NodeInput("AcadArc", typeof(object))]
	[NodeInput("Thickness", typeof(System.Double))]

	///<summary>
	///z-direction value) of an arc.
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
		Id = "5A1FC52D-F0FA-45BA-B4C2-8099507B40D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.Offset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "Offset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Creates a new arc at a specified distance from an original arc.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Not implemented. Creates a new arc at a specified distance from an original arc.
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
		Id = "62C7E0D9-BDE2-433B-8F20-C7570FD9E406", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.Area", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "Area", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the area of an arc as if it was closed with a line.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Returns the area of an arc as if it was closed with a line.
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
		Id = "E4D2DC24-367E-4287-9A49-C8381F38ECE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

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
		Id = "77E035AF-977F-41F3-B818-29A847012F87", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadArc.Set_Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadArc", 
		NodeName = "Set_Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadArc", typeof(object))]
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
}
