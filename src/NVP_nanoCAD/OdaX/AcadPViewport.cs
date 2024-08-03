using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of rectangular object created in paper space that display view
///</summary>
namespace OdaX.AcadPViewport 
{

	[NVP_Manifest(
		Id = "06759ACE-EC2B-44C2-BDBF-D5F24733EF29", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.AcadPViewport_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "_AcadPViewport_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPViewport_Constructor : INode 
	{
		public OdaX.IAcadPViewport _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadPViewport;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "201F22AD-4351-4D8B-8794-6B467A0A7686", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.AcadPViewport_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "_AcadPViewport_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPViewport_ConstructorCast : INode 
	{
		public OdaX.IAcadPViewport _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadPViewport;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "5018804F-5819-4088-BD2D-9FB8A3B6B71B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of a paperspace viewports's center point.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of a paperspace viewports's center point.
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
		Id = "19AEF047-5A53-40FD-B7D2-6DC62B5086C6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of a paperspace viewports's center point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("CenterPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of a paperspace viewports's center point.
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
		Id = "981B2AD3-A0C0-440F-9771-32DA0944F9DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the viewing direction fof a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the viewing direction fof a paperspace viewport.
	///</summary>
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}


	[NVP_Manifest(
		Id = "060446ED-2499-4869-A4F8-E5E99B9F7D4E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the viewing direction fof a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("dirVector", typeof(System.Object))]

	///<summary>
	///Specifies or returns the viewing direction fof a paperspace viewport.
	///</summary>
	public class Set_Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Direction = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "329A9E26-D9FC-4A79-A046-7B5372E2BD9D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.GridOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "GridOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the grid is on for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns whether the grid is on for a paperspace viewport.
	///</summary>
	public class GridOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GridOn);

		}
	}


	[NVP_Manifest(
		Id = "1E1073C6-A7E4-4317-B640-025A56586038", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_GridOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_GridOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the grid is on for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("bGridOn", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the grid is on for a paperspace viewport.
	///</summary>
	public class Set_GridOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GridOn = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "44610DAE-1381-4F83-BFB7-BEE069BB4644", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the height of a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the height of a paperspace viewport.
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
		Id = "B11FF3BC-1622-49B7-9B5D-3280AE58C6AB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the height of a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies or returns the height of a paperspace viewport.
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
		Id = "9AFBB938-25E6-4E3C-B1A5-3D599F9619E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the width of a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the width of a paperspace viewport.
	///</summary>
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	[NVP_Manifest(
		Id = "F1D46ACB-2901-4448-AFDF-84687E7E0643", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the width of a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies or returns the width of a paperspace viewport.
	///</summary>
	public class Set_Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Width = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C92564C2-990E-49CB-B57E-B7F1EC5289C1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.ViewportOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "ViewportOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a paperspace viewport is on.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns whether a paperspace viewport is on.
	///</summary>
	public class ViewportOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewportOn);

		}
	}


	[NVP_Manifest(
		Id = "E2E05505-E290-4270-9927-AB317B78E573", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_ViewportOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_ViewportOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a paperspace viewport is on.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("bOn", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a paperspace viewport is on.
	///</summary>
	public class Set_ViewportOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewportOn = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C5280915-14FE-477E-8308-CC21BF18A9F0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Clipped", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Clipped", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether a paperspace viewport is clipped.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Returns whether a paperspace viewport is clipped.
	///</summary>
	public class Clipped : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Clipped);

		}
	}


	[NVP_Manifest(
		Id = "24A15B43-A0A5-46C1-86A3-B440DDC35648", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.DisplayLocked", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "DisplayLocked", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a paperspace viewport is locked.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns whether a paperspace viewport is locked.
	///</summary>
	public class DisplayLocked : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayLocked);

		}
	}


	[NVP_Manifest(
		Id = "8F820F69-A75F-446E-AEDA-7B60D8FA98AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_DisplayLocked", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_DisplayLocked", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a paperspace viewport is locked.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("bLocked", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a paperspace viewport is locked.
	///</summary>
	public class Set_DisplayLocked : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplayLocked = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F0B70242-6139-4CDC-A8A9-62B6A36BA042", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.StandardScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "StandardScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the standard scale of a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the standard scale of a paperspace viewport.
	///</summary>
	public class StandardScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StandardScale);

		}
	}


	[NVP_Manifest(
		Id = "0D81DDDD-A69F-47AF-BEAF-119F93D13DEE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_StandardScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_StandardScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the standard scale of a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("OdaX.AcViewportScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the standard scale of a paperspace viewport.
	///</summary>
	public class Set_StandardScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StandardScale = ((OdaX.AcViewportScale)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F9E66220-1F60-4FBF-B410-1FBEE82D9217", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.CustomScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "CustomScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns a custom scale for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns a custom scale for a paperspace viewport.
	///</summary>
	public class CustomScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CustomScale);

		}
	}


	[NVP_Manifest(
		Id = "7FD7C7FA-8CE9-425B-8F02-B9FC7E6CC0F9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_CustomScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_CustomScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns a custom scale for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("scale", typeof(System.Double))]

	///<summary>
	///Specifies or returns a custom scale for a paperspace viewport.
	///</summary>
	public class Set_CustomScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CustomScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1EE0C5B9-A4E2-4145-9BC4-8B306A802318", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.StyleSheet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "StyleSheet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the style sheet to use for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the style sheet to use for a paperspace viewport.
	///</summary>
	public class StyleSheet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StyleSheet);

		}
	}


	[NVP_Manifest(
		Id = "6E4EF610-3941-454C-A49D-734AD1D618F9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_StyleSheet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_StyleSheet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the style sheet to use for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("pName", typeof(System.String))]

	///<summary>
	///Specifies or returns the style sheet to use for a paperspace viewport.
	///</summary>
	public class Set_StyleSheet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StyleSheet = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BBF12EEB-FBC3-4CD3-97C2-8DDB70F09A76", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.UCSPerViewport", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "UCSPerViewport", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the UCS is saved with a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns whether the UCS is saved with a paperspace viewport.
	///</summary>
	public class UCSPerViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UCSPerViewport);

		}
	}


	[NVP_Manifest(
		Id = "5DB0E2E8-952B-4D3C-AE7D-60AC9F7DE3EF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_UCSPerViewport", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_UCSPerViewport", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the UCS is saved with a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("UCSSaved", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the UCS is saved with a paperspace viewport.
	///</summary>
	public class Set_UCSPerViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UCSPerViewport = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D3DE5465-D9C4-43E5-8017-A2EDED77DC90", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.SnapBasePoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "SnapBasePoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the snap base point for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the snap base point for a paperspace viewport.
	///</summary>
	public class SnapBasePoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SnapBasePoint);

		}
	}


	[NVP_Manifest(
		Id = "D5722140-27C5-404C-AC4A-744AF8043D93", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_SnapBasePoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_SnapBasePoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the snap base point for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("lowLeft", typeof(System.Object))]

	///<summary>
	///Specifies or returns the snap base point for a paperspace viewport.
	///</summary>
	public class Set_SnapBasePoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SnapBasePoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "24759869-2568-4710-B453-F64C0E508D3A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.SnapOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "SnapOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the snap is turned on for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns whether the snap is turned on for a paperspace viewport.
	///</summary>
	public class SnapOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SnapOn);

		}
	}


	[NVP_Manifest(
		Id = "B01BF913-6862-48F3-B277-2ED8F643ECB0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_SnapOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_SnapOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the snap is turned on for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("bSnapOn", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the snap is turned on for a paperspace viewport.
	///</summary>
	public class Set_SnapOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SnapOn = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E7190E5F-7749-4F88-8E02-202D7CE9D998", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.SnapRotationAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "SnapRotationAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the snap rotation angle of a paperspace viewport relative to the current UCS.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the snap rotation angle of a paperspace viewport relative to the current UCS.
	///</summary>
	public class SnapRotationAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SnapRotationAngle);

		}
	}


	[NVP_Manifest(
		Id = "F404D3A8-06ED-42CF-ADED-94FBA4E3DFEE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_SnapRotationAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_SnapRotationAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the snap rotation angle of a paperspace viewport relative to the current UCS.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("Angle", typeof(System.Double))]

	///<summary>
	///Specifies or returns the snap rotation angle of a paperspace viewport relative to the current UCS.
	///</summary>
	public class Set_SnapRotationAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SnapRotationAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CDF7DABD-6521-4656-9303-BB526C1FA249", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.UCSIconOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "UCSIconOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the UCS icon is turned on for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns whether the UCS icon is turned on for a paperspace viewport.
	///</summary>
	public class UCSIconOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UCSIconOn);

		}
	}


	[NVP_Manifest(
		Id = "F1E34849-AB44-4C6F-A3EA-4B0D31AFB805", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_UCSIconOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_UCSIconOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the UCS icon is turned on for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("bIconOn", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the UCS icon is turned on for a paperspace viewport.
	///</summary>
	public class Set_UCSIconOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UCSIconOn = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0E5A667E-9155-4F85-A2D4-FD14625C68E1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.UCSIconAtOrigin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "UCSIconAtOrigin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the UCS icon displays at the origin for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns whether the UCS icon displays at the origin for a paperspace viewport.
	///</summary>
	public class UCSIconAtOrigin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UCSIconAtOrigin);

		}
	}


	[NVP_Manifest(
		Id = "DB4255BF-B978-4427-8007-9182FAEFFF96", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_UCSIconAtOrigin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_UCSIconAtOrigin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the UCS icon displays at the origin for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("bIconAtOrigin", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the UCS icon displays at the origin for a paperspace viewport.
	///</summary>
	public class Set_UCSIconAtOrigin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UCSIconAtOrigin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "33D82F0D-A2A5-46D4-82AB-367F61DAA38D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.GetGridSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "GetGridSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the grid spacing for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("XSpacing", typeof(System.Double))]
	[NodeInput("YSpacing", typeof(System.Double))]

	///<summary>
	///Specifies or returns the grid spacing for a paperspace viewport.
	///</summary>
	public class GetGridSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetGridSpacing(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "75B6DA8B-44EB-4407-81DC-836F035B353D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.SetGridSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "SetGridSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the grid spacing for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("XSpacing", typeof(System.Double))]
	[NodeInput("YSpacing", typeof(System.Double))]

	///<summary>
	///Specifies or returns the grid spacing for a paperspace viewport.
	///</summary>
	public class SetGridSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridSpacing(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CA632B5F-23D1-4F07-B207-2CDC411D34FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.GetSnapSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "GetSnapSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the snap spacing for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("XSpacing", typeof(System.Double))]
	[NodeInput("YSpacing", typeof(System.Double))]

	///<summary>
	///Specifies or returns the snap spacing for a paperspace viewport.
	///</summary>
	public class GetSnapSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetSnapSpacing(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C9195E0D-9494-496D-83EA-5C2F465C8BE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.SetSnapSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "SetSnapSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the snap spacing for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("XSpacing", typeof(System.Double))]
	[NodeInput("YSpacing", typeof(System.Double))]

	///<summary>
	///Specifies or returns the snap spacing for a paperspace viewport.
	///</summary>
	public class SetSnapSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetSnapSpacing(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D7D5795A-C1E0-415F-A488-E031978CBD02", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Display", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Display", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Turns the display of a paperspace viewport on or off.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("bStatus", typeof(System.Object))]

	///<summary>
	///Turns the display of a paperspace viewport on or off.
	///</summary>
	public class Display : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Display(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C43BF855-B587-406D-BC05-72F04320D199", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.TwistAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "TwistAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the twist angle, in radians, for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the twist angle, in radians, for a paperspace viewport.
	///</summary>
	public class TwistAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TwistAngle);

		}
	}


	[NVP_Manifest(
		Id = "8D2F4176-6058-4638-9744-AA72EEE4F674", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_TwistAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_TwistAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the twist angle, in radians, for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("Angle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the twist angle, in radians, for a paperspace viewport.
	///</summary>
	public class Set_TwistAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TwistAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "ECC73609-2AD8-4705-BACB-DA1894907E38", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.LensLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "LensLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lens length used in perspective viewing for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the lens length used in perspective viewing for a paperspace viewport.
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
		Id = "9A6D2E4E-10CD-411C-A042-100211766470", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_LensLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_LensLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lens length used in perspective viewing for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("Length", typeof(System.Double))]

	///<summary>
	///Specifies or returns the lens length used in perspective viewing for a paperspace viewport.
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
		Id = "38A3A2BF-FC9F-4B12-B4ED-DC7C4452BB1F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.RemoveHiddenLines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "RemoveHiddenLines", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether hidden line removal is turned on for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns whether hidden line removal is turned on for a paperspace viewport.
	///</summary>
	public class RemoveHiddenLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RemoveHiddenLines);

		}
	}


	[NVP_Manifest(
		Id = "46CDBB1C-364C-40E9-923D-80CB3BBAA9CE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_RemoveHiddenLines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_RemoveHiddenLines", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether hidden line removal is turned on for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("bRemoval", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether hidden line removal is turned on for a paperspace viewport.
	///</summary>
	public class Set_RemoveHiddenLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveHiddenLines = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B1785733-FF7F-45D2-BD51-9DFE96750498", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Target", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Target", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the target point for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the target point for a paperspace viewport.
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
		Id = "8A9B5BAF-8B39-4819-ADFA-F460B42A7D49", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_Target", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_Target", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the target point for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("targetPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the target point for a paperspace viewport.
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
		Id = "57ACA4CB-1886-40D3-A647-A25427B49409", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.ArcSmoothness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "ArcSmoothness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the smoothness of circles, arcs, and ellipses that display in a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the smoothness of circles, arcs, and ellipses that display in a paperspace viewport.
	///</summary>
	public class ArcSmoothness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArcSmoothness);

		}
	}


	[NVP_Manifest(
		Id = "3ED31F5E-E141-4201-A005-A9CFC2C0D075", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_ArcSmoothness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_ArcSmoothness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the smoothness of circles, arcs, and ellipses that display in a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("arcSmooth", typeof(System.Object))]

	///<summary>
	///Specifies or returns the smoothness of circles, arcs, and ellipses that display in a paperspace viewport.
	///</summary>
	public class Set_ArcSmoothness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArcSmoothness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4D930290-5777-4E46-93CE-DC0DF7258D61", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.VisualStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "VisualStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the visual style of a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the visual style of a paperspace viewport.
	///</summary>
	public class VisualStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VisualStyle);

		}
	}


	[NVP_Manifest(
		Id = "2BA48596-4C08-4252-A481-3B9E6529069B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_VisualStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_VisualStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the visual style of a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("pVisualStyleIndex", typeof(System.Int32))]

	///<summary>
	///Not implemented. Specifies or returns the visual style of a paperspace viewport.
	///</summary>
	public class Set_VisualStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VisualStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0F315914-24FB-4385-8467-CEDCD27689F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.ShadePlot", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "ShadePlot", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the shade plot mode of a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the shade plot mode of a paperspace viewport.
	///</summary>
	public class ShadePlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShadePlot);

		}
	}


	[NVP_Manifest(
		Id = "41F5BD70-D848-4A5C-8122-437C1F29D4D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_ShadePlot", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_ShadePlot", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the shade plot mode of a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("pShadePlotIndex", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the shade plot mode of a paperspace viewport.
	///</summary>
	public class Set_ShadePlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShadePlot = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D73E6C8F-83BC-4BD5-B34E-9BDB01670643", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.ModelView", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "ModelView", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the model view associated with the paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the model view associated with the paperspace viewport.
	///</summary>
	public class ModelView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ModelView);

		}
	}


	[NVP_Manifest(
		Id = "39D3C799-E440-4945-83B6-AB450E8554D6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_ModelView", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_ModelView", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the model view associated with the paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("View", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns the model view associated with the paperspace viewport.
	///</summary>
	public class Set_ModelView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ModelView = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B31F0804-3AEB-43BD-AB44-3371CD7AF176", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.SheetView", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "SheetView", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the sheet view associated with the paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the sheet view associated with the paperspace viewport.
	///</summary>
	public class SheetView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SheetView);

		}
	}


	[NVP_Manifest(
		Id = "3F97F256-DCE6-4196-9212-96B2751B1CD0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_SheetView", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_SheetView", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the sheet view associated with the paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("View", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns the sheet view associated with the paperspace viewport.
	///</summary>
	public class Set_SheetView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SheetView = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3956DC89-3562-4EB6-BAEA-BB933AF3DD69", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.LabelBlockId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "LabelBlockId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the label block ID associated with the paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the label block ID associated with the paperspace viewport.
	///</summary>
	public class LabelBlockId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelBlockId);

		}
	}


	[NVP_Manifest(
		Id = "E88F0D3F-4E80-4B33-B268-B964B0D01F2B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_LabelBlockId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_LabelBlockId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the label block ID associated with the paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("ObjectID", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns the label block ID associated with the paperspace viewport.
	///</summary>
	public class Set_LabelBlockId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelBlockId = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "690E97A4-2954-4210-9FD3-658CD3608BBB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.HasSheetView", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "HasSheetView", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies whether the paperspace viewport is linked to a corresponding sheet view.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Not implemented. Specifies whether the paperspace viewport is linked to a corresponding sheet view.
	///</summary>
	public class HasSheetView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasSheetView);

		}
	}


	[NVP_Manifest(
		Id = "821A5F72-AB2C-41C9-8D3E-71797A2D17D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.SyncModelView", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "SyncModelView", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Updates the paperspace viewport parameters with the parameters in the associated model view.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Not implemented. Updates the paperspace viewport parameters with the parameters in the associated model view.
	///</summary>
	public class SyncModelView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SyncModelView();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7E651446-7AF6-4B15-9E43-61146A1869A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.StandardScale2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "StandardScale2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the standard scale for the viewport", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies the standard scale for the viewport
	///</summary>
	public class StandardScale2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StandardScale2);

		}
	}


	[NVP_Manifest(
		Id = "11D4C7F3-56D2-4624-966B-8ADD6914371D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.Set_StandardScale2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "Set_StandardScale2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the standard scale for the viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("scale", typeof(System.Int32))]

	///<summary>
	///Specifies the standard scale for the viewport
	///</summary>
	public class Set_StandardScale2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StandardScale2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6DD235CE-47E2-4552-8BFB-B97BDEAB08B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPViewport.LayerPropertyOverrides", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPViewport", 
		NodeName = "LayerPropertyOverrides", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies whether the viewport has layer property overrides.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies whether the viewport has layer property overrides.
	///</summary>
	public class LayerPropertyOverrides : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayerPropertyOverrides);

		}
	}
}
