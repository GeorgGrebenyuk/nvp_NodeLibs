using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a logical grouping of data, similar to overlays.
///</summary>
namespace OdaX.AcadLayer 
{

	[NVP_Manifest(
		Id = "4718CE33-AFF0-41E6-9A47-2CDE423C8B3F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.AcadLayer_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "_AcadLayer_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLayer_Constructor : INode 
	{
		public OdaX.IAcadLayer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadLayer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "57ACEF14-28B4-4B87-B251-E19E422E600C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.AcadLayer_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "_AcadLayer_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLayer_ConstructorCast : INode 
	{
		public OdaX.IAcadLayer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadLayer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "CED77A6B-507E-484A-A9AF-FE67A2EFBFD6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.color", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "color", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of a layer.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns the color of a layer.
	///</summary>
	public class color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.color);

		}
	}


	[NVP_Manifest(
		Id = "C378A55A-A447-4C11-A496-D5ED8DC16B67", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Set_color", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Set_color", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of a layer.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("OdaX.AcColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of a layer.
	///</summary>
	public class Set_color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.color = ((OdaX.AcColor)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1AA13CD5-861B-4D3C-82B1-00740E77CDD0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.TrueColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "TrueColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the true color of a layer.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns the true color of a layer.
	///</summary>
	public class TrueColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TrueColor);

		}
	}


	[NVP_Manifest(
		Id = "6B543899-BE4A-4FD6-8A8C-C812D948F301", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Set_TrueColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Set_TrueColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the true color of a layer.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the true color of a layer.
	///</summary>
	public class Set_TrueColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TrueColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F11A94CB-F6AD-4D50-8FFB-DE0F3083CA5A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Freeze", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Freeze", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects on a layer are visible, editable, and printable.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns whether objects on a layer are visible, editable, and printable.
	///</summary>
	public class Freeze : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Freeze);

		}
	}


	[NVP_Manifest(
		Id = "57490ECB-9134-4746-940E-66C229DAA30F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Set_Freeze", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Set_Freeze", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects on a layer are visible, editable, and printable.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("bFreeze", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects on a layer are visible, editable, and printable.
	///</summary>
	public class Set_Freeze : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Freeze = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1FF89302-5FDE-4929-A839-C9DB512A0D7E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.LayerOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "LayerOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects on a layer are visible and printable.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns whether objects on a layer are visible and printable.
	///</summary>
	public class LayerOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayerOn);

		}
	}


	[NVP_Manifest(
		Id = "463B461E-A825-4AFA-A5D3-ACC03C33DBDF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Set_LayerOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Set_LayerOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects on a layer are visible and printable.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("bOn", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects on a layer are visible and printable.
	///</summary>
	public class Set_LayerOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LayerOn = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "ED7754DA-F658-4B0F-907B-C2A179262503", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Linetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Linetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of a layer.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of a layer.
	///</summary>
	public class Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Linetype);

		}
	}


	[NVP_Manifest(
		Id = "6DEBE587-7205-4C50-8CFD-1F7E5379B05B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Set_Linetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Set_Linetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of a layer.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies or returns the linetype of a layer.
	///</summary>
	public class Set_Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Linetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1330E562-E703-4ED9-83B1-DBDEA54B5B4B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Lock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Lock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects on a layer are editable.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns whether objects on a layer are editable.
	///</summary>
	public class Lock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Lock);

		}
	}


	[NVP_Manifest(
		Id = "193C0B76-D27D-482F-BAF5-8952D3B46A09", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Set_Lock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Set_Lock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects on a layer are editable.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("Block", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects on a layer are editable.
	///</summary>
	public class Set_Lock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Lock = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A64A609F-3768-4C4E-9B7A-FD62BB99EB66", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of a layer.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns the name of a layer.
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
		Id = "93413E3B-791C-4644-991F-130658A2DDAB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of a layer.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of a layer.
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
		Id = "6A081775-3297-4E93-B954-5D133878A705", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Plottable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Plottable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects of a layer can be printed.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns whether objects of a layer can be printed.
	///</summary>
	public class Plottable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Plottable);

		}
	}


	[NVP_Manifest(
		Id = "58D007FC-FA60-4C2C-91C5-5DA0C00340FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Set_Plottable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Set_Plottable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether objects of a layer can be printed.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("bPlottable", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects of a layer can be printed.
	///</summary>
	public class Set_Plottable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Plottable = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "70ACC020-9001-481B-BF0E-941983985323", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.ViewportDefault", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "ViewportDefault", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the layer is frozen in new viewports.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns whether the layer is frozen in new viewports.
	///</summary>
	public class ViewportDefault : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewportDefault);

		}
	}


	[NVP_Manifest(
		Id = "93A335CB-CFDC-41F6-BC93-D6B8AA867B2C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Set_ViewportDefault", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Set_ViewportDefault", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the layer is frozen in new viewports.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("bDefault", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the layer is frozen in new viewports.
	///</summary>
	public class Set_ViewportDefault : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewportDefault = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "47AC2D1E-0B6C-435C-92A6-E7E64D593F5D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.PlotStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "PlotStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the plot style name of a layer.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns the plot style name of a layer.
	///</summary>
	public class PlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotStyleName);

		}
	}


	[NVP_Manifest(
		Id = "24A17E6D-E7D5-46EB-87E7-F9A24CBA44ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Set_PlotStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Set_PlotStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the plot style name of a layer.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]

	///<summary>
	///Specifies or returns the plot style name of a layer.
	///</summary>
	public class Set_PlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D87A5AA1-8E04-45BD-B4E8-F71C94AFEDF7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Lineweight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Lineweight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of a layer.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of a layer.
	///</summary>
	public class Lineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Lineweight);

		}
	}


	[NVP_Manifest(
		Id = "472510E9-8170-439D-BC95-741F2C74498B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Set_Lineweight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Set_Lineweight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of a layer.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of a layer.
	///</summary>
	public class Set_Lineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Lineweight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "38D97543-10BC-4F1E-BC87-0AEA9E6B3B35", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the description of a layer.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns the description of a layer.
	///</summary>
	public class Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Description);

		}
	}


	[NVP_Manifest(
		Id = "F87A168A-2CD6-47BB-AF46-DC569A42BBE1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Set_Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Set_Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the description of a layer.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("Description", typeof(System.String))]

	///<summary>
	///Specifies or returns the description of a layer.
	///</summary>
	public class Set_Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Description = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "75962D06-7997-481F-8F50-9B5E5F1F0C13", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Used", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Used", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether the layer is in use.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Returns whether the layer is in use.
	///</summary>
	public class Used : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Used);

		}
	}


	[NVP_Manifest(
		Id = "DE1CED17-A2CE-4B11-A050-1D5DCF660806", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the material of a layer.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns the material of a layer.
	///</summary>
	public class Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Material);

		}
	}


	[NVP_Manifest(
		Id = "8B94075B-0633-4DAC-8FDB-8DCD11C16C69", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLayer.Set_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLayer", 
		NodeName = "Set_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the material of a layer.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("Material", typeof(System.String))]

	///<summary>
	///Specifies or returns the material of a layer.
	///</summary>
	public class Set_Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Material = inputs[1].Value;
			return null;
		}
	}
}
