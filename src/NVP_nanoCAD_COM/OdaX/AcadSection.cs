using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a section plane entity created at the intersection of a plane and a solid
///</summary>
namespace OdaX.AcadSection 
{

	[NVP_Manifest(
		Id = "2D17894C-584D-4FEB-83B6-75509E21FA83", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.AcadSection_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "_AcadSection_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSection_Constructor : INode 
	{
		public OdaX.IAcadSection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "B27DB2FD-87AF-44FD-8243-4149E6D41212", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.AcadSection_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "_AcadSection_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSection_ConstructorCast : INode 
	{
		public OdaX.IAcadSection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "9C61BFA5-0883-43C7-AF8F-053AA9D57F31", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of a section.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns the name of a section.
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "24E76043-60A4-4F0E-B00A-8841F06173E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pbstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of a section.
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "15BBA256-D881-412D-8940-B7F0A4CA7D60", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.State", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "State", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the type of a section.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns the type of a section.
	///</summary>
	public class State : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.State);

		}
	}


	[NVP_Manifest(
		Id = "6BE66979-BE9D-40AA-9E54-118D7110C1CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.Set_State", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "Set_State", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the type of a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("OdaX.AcSectionState", typeof(System.Object))]

	///<summary>
	///Specifies or returns the type of a section.
	///</summary>
	public class Set_State : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.State = ((OdaX.AcSectionState)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "21FB1DA5-D8A9-4887-94EE-24D098DF2717", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.ViewingDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "ViewingDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the direction in which a section is viewed.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns the direction in which a section is viewed.
	///</summary>
	public class ViewingDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewingDirection);

		}
	}


	[NVP_Manifest(
		Id = "08055AA1-A266-4DB9-A711-3F5B5B87DBF4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.Set_ViewingDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "Set_ViewingDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the direction in which a section is viewed.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the direction in which a section is viewed.
	///</summary>
	public class Set_ViewingDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewingDirection = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9457A030-478E-4DA6-9ACE-ED661897CF97", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.VerticalDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "VerticalDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the vertical direction for a section.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns the vertical direction for a section.
	///</summary>
	public class VerticalDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalDirection);

		}
	}


	[NVP_Manifest(
		Id = "31C7B5E1-D9B3-4BF4-AD52-7608926CAB50", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.Set_VerticalDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "Set_VerticalDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the vertical direction for a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the vertical direction for a section.
	///</summary>
	public class Set_VerticalDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VerticalDirection = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "775B2D10-2AD5-4D93-A8A2-8542B1690A4D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction.
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
		Id = "BB388621-D4AB-4613-BCBB-1590DD1BC41B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.LiveSectionEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "LiveSectionEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether live section is turned on for a section.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns whether live section is turned on for a section.
	///</summary>
	public class LiveSectionEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LiveSectionEnabled);

		}
	}


	[NVP_Manifest(
		Id = "F6D733D6-F920-434E-B172-DDD5D7F52C28", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.Set_LiveSectionEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "Set_LiveSectionEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether live section is turned on for a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether live section is turned on for a section.
	///</summary>
	public class Set_LiveSectionEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LiveSectionEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5EAC42F9-14F6-4457-9707-DE3C23EDADA2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.IndicatorTransparency", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "IndicatorTransparency", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a section is transparent when shading is used.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns whether a section is transparent when shading is used.
	///</summary>
	public class IndicatorTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IndicatorTransparency);

		}
	}


	[NVP_Manifest(
		Id = "7699E086-8EF0-43FE-89A5-8C4D14BEB896", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.Set_IndicatorTransparency", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "Set_IndicatorTransparency", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a section is transparent when shading is used.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pVal", typeof(System.Int32))]

	///<summary>
	///Specifies or returns whether a section is transparent when shading is used.
	///</summary>
	public class Set_IndicatorTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IndicatorTransparency = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E7DAA2A0-BC9C-4B07-A636-0469C8588C2D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.IndicatorFillColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "IndicatorFillColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of a section when shading is used.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns the color of a section when shading is used.
	///</summary>
	public class IndicatorFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IndicatorFillColor);

		}
	}


	[NVP_Manifest(
		Id = "F4ABD1CF-F75D-477F-8602-6AF73939B5B4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.Set_IndicatorFillColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "Set_IndicatorFillColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of a section when shading is used.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of a section when shading is used.
	///</summary>
	public class Set_IndicatorFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IndicatorFillColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C6DAD174-6D4F-4A26-95D8-569ADE65D781", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.Elevation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "Elevation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the elevation of a section relative to the z-axis of the object's coordinate system.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns the elevation of a section relative to the z-axis of the object's coordinate system.
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
		Id = "18A9DFD7-5237-4D48-8FE5-5F057CF6AA12", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.Set_Elevation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "Set_Elevation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the elevation of a section relative to the z-axis of the object's coordinate system.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Specifies or returns the elevation of a section relative to the z-axis of the object's coordinate system.
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
		Id = "FF616A00-492D-4909-B338-3900B0B91B44", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.TopHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "TopHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns top extents relative to the section’s elevation.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns top extents relative to the section’s elevation.
	///</summary>
	public class TopHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TopHeight);

		}
	}


	[NVP_Manifest(
		Id = "93F9BD79-A1CF-4204-9BE6-B9E50B47BEC3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.Set_TopHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "Set_TopHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns top extents relative to the section’s elevation.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Specifies or returns top extents relative to the section’s elevation.
	///</summary>
	public class Set_TopHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TopHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3DCCDC0A-4F38-40F2-A4FB-9E17981095EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.BottomHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "BottomHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns bottom extents relative to the section’s elevation.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns bottom extents relative to the section’s elevation.
	///</summary>
	public class BottomHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BottomHeight);

		}
	}


	[NVP_Manifest(
		Id = "87429171-E7B8-49BD-8ED8-55ECE6CF383D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.Set_BottomHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "Set_BottomHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns bottom extents relative to the section’s elevation.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Specifies or returns bottom extents relative to the section’s elevation.
	///</summary>
	public class Set_BottomHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BottomHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7FC98AB6-BD20-4900-BBDE-D3D1CC36B3D1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.NumVertices", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "NumVertices", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the number of vertices in the section line.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Returns the number of vertices in the section line.
	///</summary>
	public class NumVertices : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumVertices);

		}
	}


	[NVP_Manifest(
		Id = "EEC658A0-FEFE-4E77-B8E1-D89CA58BE5DF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.Vertices", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "Vertices", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the vertices in the section line.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns the vertices in the section line.
	///</summary>
	public class Vertices : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Vertices);

		}
	}


	[NVP_Manifest(
		Id = "D802CEBD-53FD-41DD-86F9-317E221ADFD5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.Set_Vertices", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "Set_Vertices", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the vertices in the section line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the vertices in the section line.
	///</summary>
	public class Set_Vertices : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Vertices = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "480C5AF6-E0F3-4803-82F6-5570962268EB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.Coordinate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "Coordinate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the coordinates of a single vertex in a section.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the coordinates of a single vertex in a section.
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
		Id = "6980596F-EC05-4DDB-A95F-F12424AF7631", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.Set_Coordinate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "Set_Coordinate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the coordinates of a single vertex in a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the coordinates of a single vertex in a section.
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
		Id = "0CD1632F-9946-4966-8515-BE568B90ACE5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.AddVertex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "AddVertex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds a new vertex to a section line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("nIndex", typeof(System.Int32))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Adds a new vertex to a section line.
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
		Id = "B9CC2DE8-2FDC-4239-8A64-09F1659AD95E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.RemoveVertex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "RemoveVertex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Removes a vertex from a section line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("nIndex", typeof(System.Int32))]

	///<summary>
	///Removes a vertex from a section line.
	///</summary>
	public class RemoveVertex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveVertex(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7193805C-05B4-49F0-BE09-791D85CACE32", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.HitTest", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "HitTest", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Determines whether a vertex is on a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("varPtHit", typeof(System.Object))]
	[NodeInput("pHit", typeof(System.Object))]
	[NodeInput("pSegmentIndex", typeof(System.Int32))]
	[NodeInput("pPtOnSegment", typeof(System.Object))]
	[NodeInput("OdaX.AcSectionSubItem", typeof(System.Object))]

	///<summary>
	///Not implemented. Determines whether a vertex is on a section.
	///</summary>
	public class HitTest : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HitTest(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,((OdaX.AcSectionSubItem)inputs[5].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6071CD7F-0EE0-4FD6-B198-474104863855", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.CreateJog", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "CreateJog", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a jog in a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("varPt", typeof(System.Object))]

	///<summary>
	///Creates a jog in a section.
	///</summary>
	public class CreateJog : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CreateJog(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "82F5C38A-9EDE-48E3-812E-B3CC642229BC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.Settings", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "Settings", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the Section Settings object for a section.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Gets the Section Settings object for a section.
	///</summary>
	public class Settings : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Settings);

		}
	}


	[NVP_Manifest(
		Id = "FFF44B17-134B-4BDE-81F9-C3FC5A2370BD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSection.GenerateSectionGeometry", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSection", 
		NodeName = "GenerateSectionGeometry", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Generates two- or three-dimensional geometry for a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pEntity", typeof(System.Object))]
	[NodeInput("pIntersectionBoundaryObjs", typeof(System.Object))]
	[NodeInput("pIntersectionFillObjs", typeof(System.Object))]
	[NodeInput("pBackgroudnObjs", typeof(System.Object))]
	[NodeInput("pForegroudObjs", typeof(System.Object))]
	[NodeInput("pCurveTangencyObjs", typeof(System.Object))]

	///<summary>
	///Not implemented. Generates two- or three-dimensional geometry for a section.
	///</summary>
	public class GenerateSectionGeometry : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GenerateSectionGeometry(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value,inputs[6].Value);
			return null;
		}
	}
}
