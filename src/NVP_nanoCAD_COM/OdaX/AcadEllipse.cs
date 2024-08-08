using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of an elliptical arc or complete ellipse entity
///</summary>
namespace OdaX.AcadEllipse 
{

	[NVP_Manifest(
		Id = "B4264E9A-526B-49F6-A725-77AE23E18DAC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.AcadEllipse_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "_AcadEllipse_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadEllipse_Constructor : INode 
	{
		public OdaX.IAcadEllipse _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadEllipse;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "605922FA-795C-427F-B43E-23FC3E05BEEF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.AcadEllipse_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "_AcadEllipse_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadEllipse_ConstructorCast : INode 
	{
		public OdaX.IAcadEllipse _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadEllipse;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "2ABFE36D-A226-47DF-9688-C21EB00965DE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.StartPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "StartPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the x, y, and z coordinates of an ellipse's start point.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Returns the x, y, and z coordinates of an ellipse's start point.
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
		Id = "8478B4FE-4485-4FD2-B3E1-86776E42A3D4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of an ellipse's center point.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of an ellipse's center point.
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
		Id = "4F47D6BE-7E52-4D41-BD9C-01C367585BF1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.Set_Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "Set_Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of an ellipse's center point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of an ellipse's center point.
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
		Id = "3B831AF7-B58E-42AD-94C3-7E0C2087D837", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.EndPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "EndPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the x, y, and z coordinates of an ellipse's end point.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Returns the x, y, and z coordinates of an ellipse's end point.
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
		Id = "9E9D7A1A-8E64-43EA-A651-ABB803F5C9B4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.MajorRadius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "MajorRadius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the radius of the longer axis of an ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Specifies or returns the radius of the longer axis of an ellipse.
	///</summary>
	public class MajorRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MajorRadius);

		}
	}


	[NVP_Manifest(
		Id = "A80B4B09-9A60-4BD6-967F-B987C292417C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.Set_MajorRadius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "Set_MajorRadius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the radius of the longer axis of an ellipse.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("MajorRadius", typeof(System.Double))]

	///<summary>
	///Specifies or returns the radius of the longer axis of an ellipse.
	///</summary>
	public class Set_MajorRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MajorRadius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2EF8A350-614F-44A5-87EF-AA877F5D8835", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.MinorRadius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "MinorRadius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the radius of the smaller axis of an ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Specifies or returns the radius of the smaller axis of an ellipse.
	///</summary>
	public class MinorRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinorRadius);

		}
	}


	[NVP_Manifest(
		Id = "60D34B57-F6CE-4FD3-9AAA-5C64DC848D81", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.Set_MinorRadius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "Set_MinorRadius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the radius of the smaller axis of an ellipse.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("MinorRadius", typeof(System.Double))]

	///<summary>
	///Specifies or returns the radius of the smaller axis of an ellipse.
	///</summary>
	public class Set_MinorRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MinorRadius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FF3B4328-3573-4ED5-93A4-4E32CA29E31A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.RadiusRatio", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "RadiusRatio", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the ratio of the ellipse's major axis length to the minor axis length.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Specifies or returns the ratio of the ellipse's major axis length to the minor axis length.
	///</summary>
	public class RadiusRatio : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RadiusRatio);

		}
	}


	[NVP_Manifest(
		Id = "5BBA4317-399C-47EC-8938-79CAD0518F9D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.Set_RadiusRatio", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "Set_RadiusRatio", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the ratio of the ellipse's major axis length to the minor axis length.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("RadiusRatio", typeof(System.Double))]

	///<summary>
	///Specifies or returns the ratio of the ellipse's major axis length to the minor axis length.
	///</summary>
	public class Set_RadiusRatio : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RadiusRatio = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3ED33768-E4CF-4D00-A1EA-B24082AF5983", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.StartAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "StartAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start angle of an ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Specifies or returns the start angle of an ellipse.
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
		Id = "C4816FE3-D838-466D-B48C-F86265F88CEA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.Set_StartAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "Set_StartAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start angle of an ellipse.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("StartAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the start angle of an ellipse.
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
		Id = "F88CE82D-5031-4085-B7C7-D61CC7E0CD3E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.EndAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "EndAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the end angle of an ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Specifies or returns the end angle of an ellipse.
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
		Id = "D6DD2835-1E20-42DF-89CD-0D627C8D9DD4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.Set_EndAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "Set_EndAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the end angle of an ellipse.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("EndAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the end angle of an ellipse.
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
		Id = "3D80B987-E0EF-4F7E-8413-CDA7E5199CE4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.StartParameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "StartParameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start parameter of an ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Specifies or returns the start parameter of an ellipse.
	///</summary>
	public class StartParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartParameter);

		}
	}


	[NVP_Manifest(
		Id = "89363065-2E59-41AE-A538-14FFA5600511", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.Set_StartParameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "Set_StartParameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start parameter of an ellipse.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("StartParameter", typeof(System.Double))]

	///<summary>
	///Specifies or returns the start parameter of an ellipse.
	///</summary>
	public class Set_StartParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartParameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0A2FD2CF-D3F1-4A72-8D0D-B950227F20B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.EndParameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "EndParameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the end parameter of an ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Specifies or returns the end parameter of an ellipse.
	///</summary>
	public class EndParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndParameter);

		}
	}


	[NVP_Manifest(
		Id = "D7D875E7-0017-4D46-A04D-F9596FFAA4E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.Set_EndParameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "Set_EndParameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the end parameter of an ellipse.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("EndParameter", typeof(System.Double))]

	///<summary>
	///Specifies or returns the end parameter of an ellipse.
	///</summary>
	public class Set_EndParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndParameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AD6784E3-748C-4C32-8221-13EBDB600328", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.MajorAxis", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "MajorAxis", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the length of the longer axis of an ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Specifies or returns the length of the longer axis of an ellipse.
	///</summary>
	public class MajorAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MajorAxis);

		}
	}


	[NVP_Manifest(
		Id = "6E8C4C42-A462-4E1D-AFEB-C47978074242", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.Set_MajorAxis", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "Set_MajorAxis", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the length of the longer axis of an ellipse.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("MajorAxis", typeof(System.Object))]

	///<summary>
	///Specifies or returns the length of the longer axis of an ellipse.
	///</summary>
	public class Set_MajorAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MajorAxis = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "55E8F5C0-A474-4818-963E-4CE8277F1EA3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.MinorAxis", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "MinorAxis", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the length of the shorter axis of an ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Returns the length of the shorter axis of an ellipse.
	///</summary>
	public class MinorAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinorAxis);

		}
	}


	[NVP_Manifest(
		Id = "4B8D6334-B3C5-4E0C-ABE9-8C0E72258630", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

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
		Id = "0AD3C84A-00BE-4EBF-BB00-8DCF6A1F6F76", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.Set_Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "Set_Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
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
		Id = "CFD7EC2E-6D08-4ABF-88FD-6CEA040DB5E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.Area", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "Area", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the area of an ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Returns the area of an ellipse.
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
		Id = "6FF39B45-A483-45F6-9687-010531682E7A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEllipse.Offset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEllipse", 
		NodeName = "Offset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Creates a new ellipse at a specified distance from an original ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Not implemented. Creates a new ellipse at a specified distance from an original ellipse.
	///</summary>
	public class Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Offset(inputs[1].Value));

		}
	}
}
