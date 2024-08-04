using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrIronBoltJoint Interface
///</summary>
namespace ironObjComLib.WrIronBoltJoint 
{

	[NVP_Manifest(
		Id = "2C034E6A-5368-4E2F-8525-6987B9D6B526", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.WrIronBoltJoint_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "_WrIronBoltJoint_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrIronBoltJoint_Constructor : INode 
	{
		public ironObjComLib.IWrIronBoltJoint _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrIronBoltJoint;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A9AA9DE7-B39C-4CC4-A2AD-D910674AA441", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.WrIronBoltJoint_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "_WrIronBoltJoint_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrIronBoltJoint_ConstructorCast : INode 
	{
		public ironObjComLib.IWrIronBoltJoint _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrIronBoltJoint;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "E408EF98-C236-4FA5-B4AF-9FE129820B6F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///Параметры
	///</summary>
	public class Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Element);

		}
	}


	[NVP_Manifest(
		Id = "76242459-A732-44F2-97AE-B5F3594FD897", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Параметры
	///</summary>
	public class Set_Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Element = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "22FF8F34-F016-4ABD-ADCF-193BF8FFBF0F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Class", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Class", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Class", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Class
	///</summary>
	public class Class : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Class);

		}
	}


	[NVP_Manifest(
		Id = "21CDC838-6A6E-4309-AD05-54F6527901CA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Set_Class", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Set_Class", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Class", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Class
	///</summary>
	public class Set_Class : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Class = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "688D0360-C8BF-467F-81E6-72502D9AC7E4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.ArrayMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "ArrayMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Array or Single creation type mode", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Array or Single creation type mode
	///</summary>
	public class ArrayMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrayMode);

		}
	}


	[NVP_Manifest(
		Id = "1D3CFFB5-C0B7-4F99-A7DF-F0E165B18AE5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Set_ArrayMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Set_ArrayMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Array or Single creation type mode", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("plVal", typeof(System.Object))]

	///<summary>
	///property Array or Single creation type mode
	///</summary>
	public class Set_ArrayMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrayMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "51AB4EE3-4F06-4839-9737-7320A5CFE4EF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.ChessMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "ChessMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property of Chess order", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property of Chess order
	///</summary>
	public class ChessMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ChessMode);

		}
	}


	[NVP_Manifest(
		Id = "FFA302A6-85D3-4EE4-A018-7853A329F7C2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Set_ChessMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Set_ChessMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property of Chess order", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("plMode", typeof(System.Object))]

	///<summary>
	///property of Chess order
	///</summary>
	public class Set_ChessMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ChessMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "93A8AD84-3A9F-40FD-B0A1-98B3452F1CBC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Strength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Strength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property of Strength of Chees order", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property of Strength of Chees order
	///</summary>
	public class Strength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Strength);

		}
	}


	[NVP_Manifest(
		Id = "1CE9BFD2-9292-45B8-AE21-3196F9DACBCB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Set_Strength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Set_Strength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property of Strength of Chees order", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("plMode", typeof(System.Object))]

	///<summary>
	///property of Strength of Chees order
	///</summary>
	public class Set_Strength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Strength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8D663220-8D61-4919-A559-C4C0188F1321", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Rows", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Rows", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Rows count", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Rows count
	///</summary>
	public class Rows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rows);

		}
	}


	[NVP_Manifest(
		Id = "D5E66257-601E-4389-87F6-144EE27FC744", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Set_Rows", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Set_Rows", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Rows count", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("plRows", typeof(System.Object))]

	///<summary>
	///property Rows count
	///</summary>
	public class Set_Rows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rows = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E747AE8D-E0F9-497C-9184-A070655754FE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.RowDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "RowDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Row distance", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Row distance
	///</summary>
	public class RowDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RowDistance);

		}
	}


	[NVP_Manifest(
		Id = "DDF09FA0-2036-42ED-BC8D-4C879E89C67A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Set_RowDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Set_RowDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Row distance", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("pdRowDist", typeof(System.Double))]

	///<summary>
	///property Row distance
	///</summary>
	public class Set_RowDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RowDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0A4848B0-01A0-46BE-BE68-EADB0E2F127C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Columns", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Columns", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Columns count", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Columns count
	///</summary>
	public class Columns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Columns);

		}
	}


	[NVP_Manifest(
		Id = "E7F62924-91B8-462F-8D7F-708D9937ED98", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Set_Columns", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Set_Columns", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Columns count", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("plColumns", typeof(System.Object))]

	///<summary>
	///property Columns count
	///</summary>
	public class Set_Columns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Columns = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DC89EFA0-786C-44CE-94C5-50FE509BC632", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.ColumnDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "ColumnDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Column distance", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Column distance
	///</summary>
	public class ColumnDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColumnDistance);

		}
	}


	[NVP_Manifest(
		Id = "51D46164-BC63-4802-91AF-3B0EE1C6B5A9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Set_ColumnDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Set_ColumnDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Column distance", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("pdColumnDist", typeof(System.Double))]

	///<summary>
	///property Column distance
	///</summary>
	public class Set_ColumnDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColumnDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "ABFD926F-47EB-4AA7-8452-1A35114447F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Length", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Length
	///</summary>
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length);

		}
	}


	[NVP_Manifest(
		Id = "160C1505-5AF3-4117-9C23-3B0D0E263762", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Boltheight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Boltheight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bolthead height", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Bolthead height
	///</summary>
	public class Boltheight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Boltheight);

		}
	}


	[NVP_Manifest(
		Id = "5BC71E78-2DA8-4E93-9896-6B6A547C18F0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.ShimExternalDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "ShimExternalDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Shim external diameter", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Shim external diameter
	///</summary>
	public class ShimExternalDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShimExternalDiameter);

		}
	}


	[NVP_Manifest(
		Id = "7E156CE1-2813-4A9C-A0FC-EDB8A77BB7F1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.ShimWebDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "ShimWebDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Shim web diameter", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Shim web diameter
	///</summary>
	public class ShimWebDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShimWebDiameter);

		}
	}


	[NVP_Manifest(
		Id = "AF7CB324-101F-430C-AAE2-E9CB72168871", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.ShimHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "ShimHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Shim height", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Shim height
	///</summary>
	public class ShimHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShimHeight);

		}
	}


	[NVP_Manifest(
		Id = "9BAFA31C-EB59-4843-B331-E6C62D72036D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.NutDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "NutDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Nut diameter", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Nut diameter
	///</summary>
	public class NutDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NutDiameter);

		}
	}


	[NVP_Manifest(
		Id = "C5F93425-2BC8-42F1-B54B-C080D065A313", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.NutHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "NutHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Nut height", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Nut height
	///</summary>
	public class NutHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NutHeight);

		}
	}


	[NVP_Manifest(
		Id = "DF758708-1420-4F6A-BF4C-0DA1EB7373B0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.NutLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "NutLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Nut length", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Nut length
	///</summary>
	public class NutLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NutLength);

		}
	}


	[NVP_Manifest(
		Id = "EA8DC839-FCAE-40DB-920C-D6B44AC294F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Nut1Enabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Nut1Enabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property First nut was enabled", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property First nut was enabled
	///</summary>
	public class Nut1Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Nut1Enabled);

		}
	}


	[NVP_Manifest(
		Id = "39B617D1-2347-440E-BEAB-21EB24B5E3C5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Set_Nut1Enabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Set_Nut1Enabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property First nut was enabled", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property First nut was enabled
	///</summary>
	public class Set_Nut1Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Nut1Enabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F87A78B8-12BF-4135-A31C-35667BC80B5C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Nut2Enabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Nut2Enabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Second nut was enabled", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Second nut was enabled
	///</summary>
	public class Nut2Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Nut2Enabled);

		}
	}


	[NVP_Manifest(
		Id = "0248F1F7-3BAB-44BE-8E8E-A171E7794072", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Set_Nut2Enabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Set_Nut2Enabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Second nut was enabled", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Second nut was enabled
	///</summary>
	public class Set_Nut2Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Nut2Enabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8269ADBD-7C2E-4642-9568-1710BC5C91D8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.ShimheadEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "ShimheadEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Shim bolthead was enabled", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Shim bolthead was enabled
	///</summary>
	public class ShimheadEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShimheadEnabled);

		}
	}


	[NVP_Manifest(
		Id = "1F983DDE-CE34-4C8E-8E6B-EE034EA2183D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Set_ShimheadEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Set_ShimheadEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Shim bolthead was enabled", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Shim bolthead was enabled
	///</summary>
	public class Set_ShimheadEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShimheadEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A25BE72B-FF6C-42D8-A79B-255FB4E7886D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.ShimArray", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "ShimArray", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Shim array count", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Shim array count
	///</summary>
	public class ShimArray : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShimArray);

		}
	}


	[NVP_Manifest(
		Id = "BEB8EE52-F6FF-4F53-B9F3-F99F52F44704", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.Set_ShimArray", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "Set_ShimArray", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Shim array count", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Shim array count
	///</summary>
	public class Set_ShimArray : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShimArray = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "43A5BE0D-E23B-4457-B0DB-4710786540A9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronBoltJoint.PackLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronBoltJoint", 
		NodeName = "PackLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Packet length", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Packet length
	///</summary>
	public class PackLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PackLength);

		}
	}
}
