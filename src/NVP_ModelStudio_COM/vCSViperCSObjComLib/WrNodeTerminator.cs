using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrNodeTerminator Interface
///</summary>
namespace vCSViperCSObjComLib.WrNodeTerminator 
{

	[NVP_Manifest(
		Id = "8D83055A-0BF3-47BA-8339-0BFAF5DC3559", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.WrNodeTerminator_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "_WrNodeTerminator_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrNodeTerminator_Constructor : INode 
	{
		public vCSViperCSObjComLib.IWrNodeTerminator _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as vCSViperCSObjComLib.IWrNodeTerminator;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "8CAC8801-D776-4DE1-ADD7-4A9FCF0A7E08", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.WrNodeTerminator_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "_WrNodeTerminator_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrNodeTerminator_ConstructorCast : INode 
	{
		public vCSViperCSObjComLib.IWrNodeTerminator _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as vCSViperCSObjComLib.IWrNodeTerminator;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "91772D02-36FF-4628-B426-61526FECF7CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.PipeLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "PipeLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Слой по умолчанию", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///Слой по умолчанию
	///</summary>
	public class PipeLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PipeLayer);

		}
	}


	[NVP_Manifest(
		Id = "CC4E7158-E2B8-489C-AB6B-FED68891ADA2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_PipeLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_PipeLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Слой по умолчанию", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Слой по умолчанию
	///</summary>
	public class Set_PipeLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PipeLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1D221778-709C-48D4-9485-A848AEBBD283", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Element
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
		Id = "F41D4856-0ABC-4484-BE8B-98C9C70963A3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVar", typeof(System.Object))]

	///<summary>
	///property Element
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
		Id = "088AEE26-64E3-47C8-A398-0A20A7A04737", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.ViewMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "ViewMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ViewMode", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property ViewMode
	///</summary>
	public class ViewMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewMode);

		}
	}


	[NVP_Manifest(
		Id = "C9B0E160-613C-404A-8B30-F0D3A97C67EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_ViewMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_ViewMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ViewMode", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property ViewMode
	///</summary>
	public class Set_ViewMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DAAAEDA1-C1CB-4A17-BCC1-6EE537FBE13C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.ElementAxis", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "ElementAxis", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ElementAxis", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property ElementAxis
	///</summary>
	public class ElementAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElementAxis);

		}
	}


	[NVP_Manifest(
		Id = "A041BDEA-8266-4EA8-AED9-1F27A76EA4AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_ElementAxis", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_ElementAxis", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ElementAxis", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property ElementAxis
	///</summary>
	public class Set_ElementAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ElementAxis = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EFCC90B6-4066-48B0-B204-7286A9B73035", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Position", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Position
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Id = "7EB6206C-22ED-4725-8FE0-FC0DA2862300", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Position", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Position
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FA1272A8-667C-4ACC-BB04-AA6C637A3A42", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.PositionIsFixed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "PositionIsFixed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PositionIsFixed", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property PositionIsFixed
	///</summary>
	public class PositionIsFixed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PositionIsFixed);

		}
	}


	[NVP_Manifest(
		Id = "803A2015-165A-4C58-B75F-AB5854C6B376", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_PositionIsFixed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_PositionIsFixed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PositionIsFixed", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PositionIsFixed
	///</summary>
	public class Set_PositionIsFixed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PositionIsFixed = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9F8786FC-F966-4200-A569-09A20EBD9DBA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.VectorIsFixed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "VectorIsFixed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property VectorIsFixed", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property VectorIsFixed
	///</summary>
	public class VectorIsFixed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VectorIsFixed);

		}
	}


	[NVP_Manifest(
		Id = "6C78C8B2-C2D7-4E59-A1FA-23E590F9F773", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_VectorIsFixed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_VectorIsFixed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property VectorIsFixed", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property VectorIsFixed
	///</summary>
	public class Set_VectorIsFixed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VectorIsFixed = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D54FA95F-4077-4517-9C7C-C8DCC7C13121", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.ProfileIsFixed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "ProfileIsFixed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ProfileIsFixed", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property ProfileIsFixed
	///</summary>
	public class ProfileIsFixed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProfileIsFixed);

		}
	}


	[NVP_Manifest(
		Id = "3528FC5C-6F69-48DC-9E94-B935B8B61735", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_ProfileIsFixed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_ProfileIsFixed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ProfileIsFixed", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property ProfileIsFixed
	///</summary>
	public class Set_ProfileIsFixed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ProfileIsFixed = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "27551AE6-B473-4196-B64A-9FC5876B35B5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.OrderOnLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "OrderOnLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Номер на линии", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///Номер на линии
	///</summary>
	public class OrderOnLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OrderOnLine);

		}
	}


	[NVP_Manifest(
		Id = "160E75F4-5616-49D4-93F2-C5A93FDA8E43", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Insulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Insulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Объект изоляции", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///Объект изоляции
	///</summary>
	public class Insulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Insulation);

		}
	}


	[NVP_Manifest(
		Id = "B5E3808B-23BD-46CD-A90E-F2639E8E64B0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Insulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Insulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Объект изоляции", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Объект изоляции
	///</summary>
	public class Set_Insulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Insulation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8F5D2303-C6CB-4009-8AAF-9530F022F1FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.HasInsulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "HasInsulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наличие изоляции", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///Наличие изоляции
	///</summary>
	public class HasInsulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasInsulation);

		}
	}


	[NVP_Manifest(
		Id = "5301B23F-5908-4C50-A184-2940B85A92AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Name", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Part_Name
	///</summary>
	public class Part_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Name);

		}
	}


	[NVP_Manifest(
		Id = "2ADEB50F-AB8F-440B-B54A-833003B6F14C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Name", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Name
	///</summary>
	public class Set_Part_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A912F5AC-F6F6-44FE-8F20-60977140644B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Tag", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Part_Tag
	///</summary>
	public class Part_Tag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Tag);

		}
	}


	[NVP_Manifest(
		Id = "1977607B-D83D-4C81-9802-54A7464814D6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Tag", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Tag
	///</summary>
	public class Set_Part_Tag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Tag = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "98B51CC8-CCE1-4D9D-A889-856CA88DE771", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Part_Manufacturer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Part_Manufacturer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Manufacturer", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Part_Manufacturer
	///</summary>
	public class Part_Manufacturer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Manufacturer);

		}
	}


	[NVP_Manifest(
		Id = "0B50AE71-1E9D-44C9-BBA7-5D51721ACC66", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Part_Manufacturer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Part_Manufacturer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Manufacturer", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Manufacturer
	///</summary>
	public class Set_Part_Manufacturer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Manufacturer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E150EE0A-5AC4-4E69-8F02-43C2EBDB57F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Part_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Part_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Standard", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Part_Standard
	///</summary>
	public class Part_Standard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Standard);

		}
	}


	[NVP_Manifest(
		Id = "1C7F69C6-8337-426A-816A-8BDE3405783B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Part_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Part_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Standard", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Standard
	///</summary>
	public class Set_Part_Standard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Standard = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "785EA849-B05A-4522-9D30-00E04B871FAE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Refdrawing", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Part_Refdrawing
	///</summary>
	public class Part_Refdrawing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Refdrawing);

		}
	}


	[NVP_Manifest(
		Id = "66D79B90-9EEE-49CB-9200-3CB2DD9DAA71", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Refdrawing", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Refdrawing
	///</summary>
	public class Set_Part_Refdrawing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Refdrawing = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "02461103-E51B-446C-BB1B-E5CC74C74D2C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Part_Material
	///</summary>
	public class Part_Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Material);

		}
	}


	[NVP_Manifest(
		Id = "1FB94B4C-66D9-4553-A3E7-00266F6A0C1D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Material
	///</summary>
	public class Set_Part_Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Material = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1B8C59D7-31A2-4B81-ABE5-F7CC735DCBC4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material_Standard", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Part_Material_Standard
	///</summary>
	public class Part_Material_Standard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Material_Standard);

		}
	}


	[NVP_Manifest(
		Id = "9F341CE8-FA30-468F-B24E-0CCD33B7B6DF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material_Standard", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Material_Standard
	///</summary>
	public class Set_Part_Material_Standard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Material_Standard = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "72EF5E03-0448-4B88-92CB-1B44AED5DFEB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Part_Weight
	///</summary>
	public class Part_Weight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Weight);

		}
	}


	[NVP_Manifest(
		Id = "5F45686C-9BB8-45BB-A7E8-99FDA6C2E506", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Weight
	///</summary>
	public class Set_Part_Weight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Weight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1F0DAF03-788B-4D38-8D37-C9BEA9BD441E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Comment", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Part_Comment
	///</summary>
	public class Part_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Comment);

		}
	}


	[NVP_Manifest(
		Id = "3D600453-61B6-4C9C-8F34-727AE21DE2C8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Comment
	///</summary>
	public class Set_Part_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Comment = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7957F101-0D1E-44F9-B8D9-066341C3C7CA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.PartPipe_DN", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "PartPipe_DN", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_DN", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property PartPipe_DN
	///</summary>
	public class PartPipe_DN : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_DN);

		}
	}


	[NVP_Manifest(
		Id = "08A750D6-F980-4061-AD65-7DF0278F1D59", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_PartPipe_DN", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_PartPipe_DN", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_DN", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PartPipe_DN
	///</summary>
	public class Set_PartPipe_DN : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_DN = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F082CE23-0EBA-4762-AD2D-DC445CAE7478", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.PartPipe_Diam", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "PartPipe_Diam", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Diam", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property PartPipe_Diam
	///</summary>
	public class PartPipe_Diam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Diam);

		}
	}


	[NVP_Manifest(
		Id = "06EE333D-7FEF-44BE-8E98-F290D02981CE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_PartPipe_Diam", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_PartPipe_Diam", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Diam", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PartPipe_Diam
	///</summary>
	public class Set_PartPipe_Diam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Diam = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F1E101DE-DEE3-4696-A5C2-8C5665DC0667", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.PartPipe_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "PartPipe_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Thickness", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property PartPipe_Thickness
	///</summary>
	public class PartPipe_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Thickness);

		}
	}


	[NVP_Manifest(
		Id = "F7C3FB4A-8511-41D5-8EF0-9AB359184F4F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_PartPipe_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_PartPipe_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Thickness", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PartPipe_Thickness
	///</summary>
	public class Set_PartPipe_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "479D7D34-53EF-432A-8126-54CB0109D2BD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.PartPipe_Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "PartPipe_Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Length", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property PartPipe_Length
	///</summary>
	public class PartPipe_Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Length);

		}
	}


	[NVP_Manifest(
		Id = "C448C385-FE08-4459-A593-FDA123A5B937", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_PartPipe_Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_PartPipe_Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Length", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property PartPipe_Length
	///</summary>
	public class Set_PartPipe_Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Length = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7DA5CD2F-2C62-4067-A289-4DAEFA182DA4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Part_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Part_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Group", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Part_Group
	///</summary>
	public class Part_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Group);

		}
	}


	[NVP_Manifest(
		Id = "6CFE9589-8B1B-45F9-9C72-F2DE5856C01D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Part_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Part_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Group
	///</summary>
	public class Set_Part_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Group = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CE4DF50E-F2DB-44BA-979D-811C3AE6A7BC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Part_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Part_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Type", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Part_Type
	///</summary>
	public class Part_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Type);

		}
	}


	[NVP_Manifest(
		Id = "95210F59-F8E9-4C1A-BA0F-ACB7DFC526CA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Part_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Part_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Type", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Type
	///</summary>
	public class Set_Part_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Type = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "301A968C-25B0-4B81-A5F3-E0BD36822179", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Part_Reference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Part_Reference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Reference", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Part_Reference
	///</summary>
	public class Part_Reference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Reference);

		}
	}


	[NVP_Manifest(
		Id = "5E32FCCB-7430-437A-8D6A-7BB59F71DD5A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Part_Reference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Part_Reference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Reference", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Reference
	///</summary>
	public class Set_Part_Reference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Reference = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0FC5DCA2-BE91-45CC-B04C-2071B3ECAF91", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Part_Weight_Netto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Part_Weight_Netto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Netto", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Part_Weight_Netto
	///</summary>
	public class Part_Weight_Netto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Weight_Netto);

		}
	}


	[NVP_Manifest(
		Id = "460A826E-1F37-445A-A382-C2D275726F8C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Part_Weight_Netto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Part_Weight_Netto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Netto", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Weight_Netto
	///</summary>
	public class Set_Part_Weight_Netto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Weight_Netto = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "576F5000-A2A7-4BBE-B8E4-0290BF042B9C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Part_Weight_Bruto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Part_Weight_Bruto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Bruto", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Part_Weight_Bruto
	///</summary>
	public class Part_Weight_Bruto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Weight_Bruto);

		}
	}


	[NVP_Manifest(
		Id = "1526969B-2E1C-44B4-8235-7F130E0D50CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Part_Weight_Bruto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Part_Weight_Bruto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Bruto", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Weight_Bruto
	///</summary>
	public class Set_Part_Weight_Bruto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Weight_Bruto = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BD34A4CB-3B2D-44B9-893F-51893D7820B6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Part_Insulation_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Part_Insulation_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Insulation_Thickness", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Part_Insulation_Thickness
	///</summary>
	public class Part_Insulation_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Insulation_Thickness);

		}
	}


	[NVP_Manifest(
		Id = "46A7BB6F-A2D7-42E5-BC74-4F0E6C36DF3B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Part_Insulation_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Part_Insulation_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Insulation_Thickness", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Part_Insulation_Thickness
	///</summary>
	public class Set_Part_Insulation_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Insulation_Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "23AE411B-4839-4855-823A-E8B34B5D1DCF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Axis_Insulation_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Axis_Insulation_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_Thickness", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Axis_Insulation_Thickness
	///</summary>
	public class Axis_Insulation_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Axis_Insulation_Thickness);

		}
	}


	[NVP_Manifest(
		Id = "84489748-C5C0-4C60-9298-591E98C329CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Axis_Insulation_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Axis_Insulation_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_Thickness", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Axis_Insulation_Thickness
	///</summary>
	public class Set_Axis_Insulation_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Axis_Insulation_Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F4CE7364-CAB8-477A-8BDD-40AAB1BFB2AE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Axis_Insulation_Disableview", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Axis_Insulation_Disableview", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_Disableview", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Axis_Insulation_Disableview
	///</summary>
	public class Axis_Insulation_Disableview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Axis_Insulation_Disableview);

		}
	}


	[NVP_Manifest(
		Id = "2332E0D1-6973-4FC2-AB9C-2588E1A68512", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Axis_Insulation_Disableview", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Axis_Insulation_Disableview", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_Disableview", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Axis_Insulation_Disableview
	///</summary>
	public class Set_Axis_Insulation_Disableview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Axis_Insulation_Disableview = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3D807F59-ACDB-4508-9270-6C275616A02D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Axis_Insulation_LineInsulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Axis_Insulation_LineInsulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_LineInsulation", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Axis_Insulation_LineInsulation
	///</summary>
	public class Axis_Insulation_LineInsulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Axis_Insulation_LineInsulation);

		}
	}


	[NVP_Manifest(
		Id = "9C569287-D978-4839-B7EC-4CF6AB0811B0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Axis_Insulation_LineInsulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Axis_Insulation_LineInsulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_LineInsulation", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Axis_Insulation_LineInsulation
	///</summary>
	public class Set_Axis_Insulation_LineInsulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Axis_Insulation_LineInsulation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5C8DB8C6-9032-45E1-BD9F-6311D95395B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Axis_Insulation_LineTrace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Axis_Insulation_LineTrace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_LineTrace", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Axis_Insulation_LineTrace
	///</summary>
	public class Axis_Insulation_LineTrace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Axis_Insulation_LineTrace);

		}
	}


	[NVP_Manifest(
		Id = "6E0E9BBB-DE76-47E8-B1C9-5001A71AFB11", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Axis_Insulation_LineTrace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Axis_Insulation_LineTrace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_LineTrace", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Axis_Insulation_LineTrace
	///</summary>
	public class Set_Axis_Insulation_LineTrace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Axis_Insulation_LineTrace = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EF7D7131-C749-4BA8-8553-0E492288719F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.GetAxisParamValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "GetAxisParamValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetAxisParamValue", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("ParameterName", typeof(System.String))]

	///<summary>
	///method GetAxisParamValue
	///</summary>
	public class GetAxisParamValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAxisParamValue(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "713869A4-8519-46FC-BB31-E05A41D414A1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Include", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Explication_Include
	///</summary>
	public class Explication_Include : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explication_Include);

		}
	}


	[NVP_Manifest(
		Id = "D22CFF0C-FBE8-4364-8CF7-B0427301BFF1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Include", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Explication_Include
	///</summary>
	public class Set_Explication_Include : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Explication_Include = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1BFB5A63-0123-470F-BF72-BD960E9030F4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Number", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Explication_Number
	///</summary>
	public class Explication_Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explication_Number);

		}
	}


	[NVP_Manifest(
		Id = "785787EF-59AC-42C7-BB6C-21D1A9D8E167", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Number", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Explication_Number
	///</summary>
	public class Set_Explication_Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Explication_Number = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0D26EAC6-0381-40F0-B83C-CF2F8AB37F1E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Group", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Explication_Group
	///</summary>
	public class Explication_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explication_Group);

		}
	}


	[NVP_Manifest(
		Id = "55FC71D3-56DD-4871-8DDB-9BD8E3B15E9F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Explication_Group
	///</summary>
	public class Set_Explication_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Explication_Group = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "152539F2-3625-44FF-A908-42D77F0A65DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Comment", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Explication_Comment
	///</summary>
	public class Explication_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explication_Comment);

		}
	}


	[NVP_Manifest(
		Id = "5961C636-F642-4D70-AC86-AC5B0E9A2A2A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Explication_Comment
	///</summary>
	public class Set_Explication_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Explication_Comment = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A19837E7-E294-4B75-A820-A4E8251F9EB1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Include", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Bom_Include
	///</summary>
	public class Bom_Include : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Include);

		}
	}


	[NVP_Manifest(
		Id = "DD5710E2-F0FE-4B9C-84CB-6074743A7490", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Include", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Bom_Include
	///</summary>
	public class Set_Bom_Include : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Include = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F2F52561-9A29-4DAE-BE68-3A20D75F5C02", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Number", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Bom_Number
	///</summary>
	public class Bom_Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Number);

		}
	}


	[NVP_Manifest(
		Id = "D7724261-679A-412E-9603-84849662C1B5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Number", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Bom_Number
	///</summary>
	public class Set_Bom_Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Number = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B4ACDC42-A816-4153-BDEB-189737C48A58", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Group", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Bom_Group
	///</summary>
	public class Bom_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Group);

		}
	}


	[NVP_Manifest(
		Id = "C0A9CF77-1C1E-456D-BF0A-6060E759D108", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Bom_Group
	///</summary>
	public class Set_Bom_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Group = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9DC4B3C2-0882-4459-92B7-CE5BAE85E6BC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Qty", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Bom_Qty
	///</summary>
	public class Bom_Qty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Qty);

		}
	}


	[NVP_Manifest(
		Id = "8AF57F54-559F-4783-8617-D03D7980D055", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Qty", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Bom_Qty
	///</summary>
	public class Set_Bom_Qty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Qty = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8CCC3024-084F-40BB-8C50-6778993ECDE0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Comment", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property Bom_Comment
	///</summary>
	public class Bom_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Comment);

		}
	}


	[NVP_Manifest(
		Id = "C5515155-0AEC-4D56-B8C4-5690F77B8E77", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Bom_Comment
	///</summary>
	public class Set_Bom_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Comment = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C103B305-75B0-4143-A02B-0220C1CA2ADB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.HasConnectionJoin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "HasConnectionJoin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property HasConnectionJoin", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property HasConnectionJoin
	///</summary>
	public class HasConnectionJoin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasConnectionJoin);

		}
	}


	[NVP_Manifest(
		Id = "05492A09-7E28-489B-A9FD-774F6CC26918", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.ConnectionJoin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "ConnectionJoin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ConnectionJoin", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property ConnectionJoin
	///</summary>
	public class ConnectionJoin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConnectionJoin);

		}
	}


	[NVP_Manifest(
		Id = "4E547E84-CE45-47BA-9FDC-C4037D924E70", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.HasConnectionJoinStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "HasConnectionJoinStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property HasConnectionJoinStart", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property HasConnectionJoinStart
	///</summary>
	public class HasConnectionJoinStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasConnectionJoinStart);

		}
	}


	[NVP_Manifest(
		Id = "4E85D8A1-A6C7-451A-BAEC-1430A9FC3FF0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.ConnectionJoinStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "ConnectionJoinStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ConnectionJoinStart", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property ConnectionJoinStart
	///</summary>
	public class ConnectionJoinStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConnectionJoinStart);

		}
	}


	[NVP_Manifest(
		Id = "F828792E-35AE-4B47-A3E4-12D1FD327996", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.HasConnectionJoinEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "HasConnectionJoinEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property HasConnectionJoinEnd", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property HasConnectionJoinEnd
	///</summary>
	public class HasConnectionJoinEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasConnectionJoinEnd);

		}
	}


	[NVP_Manifest(
		Id = "E9F52AB8-5351-4B92-B9FC-0FE7CEB3D736", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.ConnectionJoinEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "ConnectionJoinEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ConnectionJoinEnd", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property ConnectionJoinEnd
	///</summary>
	public class ConnectionJoinEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConnectionJoinEnd);

		}
	}


	[NVP_Manifest(
		Id = "8CB4EA39-B479-4235-A87E-422411AA3F83", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.PartPipe_Lock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "PartPipe_Lock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property LockComponent", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property LockComponent
	///</summary>
	public class PartPipe_Lock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Lock);

		}
	}


	[NVP_Manifest(
		Id = "3C664D5D-D64A-4CD6-9CAE-20421B429A76", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.Set_PartPipe_Lock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "Set_PartPipe_Lock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property LockComponent", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property LockComponent
	///</summary>
	public class Set_PartPipe_Lock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Lock = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F3976912-B83D-4B28-83CF-B825A0BA9E9C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.GetArea", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "GetArea", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetArea", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("Element", typeof(System.Object))]
	[NodeInput("bodyOptions", typeof(System.Object))]

	///<summary>
	///method GetArea
	///</summary>
	public class GetArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetArea(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "1842708C-FF6C-484A-9D9F-84763338C460", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeTerminator.GetVolume", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeTerminator", 
		NodeName = "GetVolume", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetVolume", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("Element", typeof(System.Object))]
	[NodeInput("bodyOptions", typeof(System.Object))]

	///<summary>
	///method GetVolume
	///</summary>
	public class GetVolume : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetVolume(inputs[1].Value,inputs[2].Value));

		}
	}
}
