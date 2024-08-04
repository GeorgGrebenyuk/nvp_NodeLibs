using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrSubSegment Interface
///</summary>
namespace vCSViperCSObjComLib.WrSubSegment 
{

	[NVP_Manifest(
		Id = "39B595DF-3237-40F0-A5FD-61625F5C143D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.WrSubSegment_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "_WrSubSegment_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrSubSegment_Constructor : INode 
	{
		public vCSViperCSObjComLib.IWrSubSegment _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as vCSViperCSObjComLib.IWrSubSegment;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "1915FAB5-902D-4943-86BF-0D7FBFB9998F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.WrSubSegment_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "_WrSubSegment_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrSubSegment_ConstructorCast : INode 
	{
		public vCSViperCSObjComLib.IWrSubSegment _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as vCSViperCSObjComLib.IWrSubSegment;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "F18DBF7D-6716-4C45-839E-4AA11D303865", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.PipeLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "PipeLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Слой по умолчанию", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "6CA5910C-0591-4574-BEEE-C84CF559453B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_PipeLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_PipeLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Слой по умолчанию", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "14A51633-A471-4D69-91B4-15431211F411", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.OwnerSegId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "OwnerSegId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property OwnerSegId", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

	///<summary>
	///property OwnerSegId
	///</summary>
	public class OwnerSegId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OwnerSegId);

		}
	}


	[NVP_Manifest(
		Id = "90F14BCE-4BF4-4438-93BC-0BF1C54605CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_OwnerSegId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_OwnerSegId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property OwnerSegId", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property OwnerSegId
	///</summary>
	public class Set_OwnerSegId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OwnerSegId = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "031C5F09-FFD0-4A65-B169-29EE6956406C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.ViewMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "ViewMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ViewMode", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "EED6D7B3-2E83-4193-811D-8F3B2A0BFA75", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_ViewMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_ViewMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ViewMode", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "D5250E09-18A9-48FC-9515-ADDFE7D57676", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "8B46613E-E3AB-446F-B1A8-3693038030C4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

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
		Id = "A52FCCF0-ED90-41FB-97D9-36A82726C5A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.ElementAxis", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "ElementAxis", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ElementAxis", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "690992F0-83ED-4995-BE2F-76EA55F491D6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_ElementAxis", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_ElementAxis", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ElementAxis", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "81557DC4-9F4B-4A63-8820-9C33E106812A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.OrderOnLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "OrderOnLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Номер на линии", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "22B04908-F64B-46C7-8B30-8304FDA848CE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Insulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Insulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Объект изоляции", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "BECA6A86-FDA7-4C5F-BE64-C0FB2F7EB14F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Insulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Insulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Объект изоляции", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "9A94514A-0BC7-4DC4-9E33-A61532841028", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.HasInsulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "HasInsulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наличие изоляции", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "3B2FDD24-6EB3-4611-BFD2-DFE18B2ADA32", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Name", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "9BA6B60A-34E9-42A0-9F5C-29DB1A2671D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Name", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "AF16732D-22DE-479F-A81E-A9AEB37CF525", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Tag", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "8B17C7F6-6643-4945-A0FA-6882225B7402", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Tag", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "A4D79325-4EB9-467F-9E75-B8C61B2E7C9D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Part_Manufacturer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Part_Manufacturer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Manufacturer", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "BBE9C95E-6BFF-463D-8557-D0F5ED38B62B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Part_Manufacturer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Part_Manufacturer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Manufacturer", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "19720F9E-A7DB-4B8B-9FE7-08256D736412", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Part_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Part_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Standard", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "D3D72BAD-9A9F-4A12-B72C-FAE8DB418AD9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Part_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Part_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Standard", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "4B8CFE83-0AB3-4C00-A661-55DE242497B0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Refdrawing", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "A9E3C5B1-DBE1-4302-AC34-3FC3157958F3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Refdrawing", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "6BA077E3-DD86-4910-9B4A-318749612C5D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "E2FBEC11-C149-4D6F-8F02-5D2ABBD5FBD0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "B09386B9-C8D7-47D9-870C-20EB8204B87E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material_Standard", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "0D216156-2108-4FE7-9AB1-26EF7E9890C0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material_Standard", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "94AB0AF2-D143-438E-8D45-791D32878709", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "F658278D-69B9-44A0-8A05-88E256216053", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "30998708-43C6-410B-91BB-2D1F72F39DFA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Comment", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "3DA768DF-E980-4C89-8E97-B016291DBFE8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "A84352F4-BC2B-438F-9C2E-F5950F4528DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.PartPipe_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "PartPipe_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Thickness", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "1B8A53DE-C1B0-4ED0-9FD1-74920B727127", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_PartPipe_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_PartPipe_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Thickness", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "2CD6312B-BF01-4000-9138-E9AFA09B0296", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.PartPipe_DN", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "PartPipe_DN", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_DN", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "126A499F-0EFD-4ACE-AB68-FEE6AF4357E8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_PartPipe_DN", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_PartPipe_DN", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_DN", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

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
		Id = "61A8C2D9-B143-4D9A-B9D6-25765165C3DA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.PartPipe_Diam", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "PartPipe_Diam", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Diam", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "018361B2-DFCA-4F5D-A8A5-0F6E85ACED4D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_PartPipe_Diam", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_PartPipe_Diam", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Diam", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

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
		Id = "9668DBCE-BBC5-4736-9FF1-E49D1C0867F5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.PartPipe_Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "PartPipe_Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Length", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "B02C6671-5550-4AE2-9A8B-392CBDBC3817", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_PartPipe_Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_PartPipe_Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Length", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "2539AC92-610A-4B1B-BF9A-1C4B4538872D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Part_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Part_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Group", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "4D31CB6E-640D-42D3-9AD5-AE3380B0B77B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Part_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Part_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "BACCA275-3601-44FE-9120-64B8BB639BD4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Part_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Part_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Type", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "C72B01A5-0720-46FA-AE22-6CEB23C3FDB2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Part_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Part_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Type", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "30345401-A597-45FA-A60B-AF17D55039EA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Part_Reference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Part_Reference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Reference", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "1A114194-D86A-4279-9B80-FEBA7C24C7E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Part_Reference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Part_Reference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Reference", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "3FEB8D8A-180E-4631-9E7B-DFF54E9B3E0B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Part_Weight_Netto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Part_Weight_Netto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Netto", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "DF801077-5B97-419A-8BF9-DB6343975D28", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Part_Weight_Netto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Part_Weight_Netto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Netto", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "82CEDA6B-F312-4418-8177-CA6746546D9D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Part_Weight_Bruto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Part_Weight_Bruto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Bruto", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "A4C6D586-87FE-464A-B97B-2FCC31BEF9E3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Part_Weight_Bruto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Part_Weight_Bruto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Bruto", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "2B366C14-28A2-4A2F-BAB1-8BB724410AA7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.PointStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "PointStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Начальная точка", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

	///<summary>
	///Начальная точка
	///</summary>
	public class PointStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PointStart);

		}
	}


	[NVP_Manifest(
		Id = "B9ADC4DC-21AE-4D39-AF8C-205D5C5C9A3F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.PointEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "PointEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Конечная точка", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

	///<summary>
	///Конечная точка
	///</summary>
	public class PointEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PointEnd);

		}
	}


	[NVP_Manifest(
		Id = "F46CEF1C-A23F-41F1-8A9C-342AF2EB8292", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Position", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "A0DFD9CC-3160-45B6-818B-D18FC327CF1D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Position", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "BEB7CF96-BDBE-4B77-9366-419A844F364C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Part_Insulation_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Part_Insulation_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Insulation_Thickness", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "DB67DD43-32F7-4E2F-933C-B9CE4C87169B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Part_Insulation_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Part_Insulation_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Insulation_Thickness", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "E6F725B1-C5AF-4074-96DD-85C4265EEBC5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Part_Insulation_Disableview", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Part_Insulation_Disableview", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Insulation_Disableview", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

	///<summary>
	///property Part_Insulation_Disableview
	///</summary>
	public class Part_Insulation_Disableview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Insulation_Disableview);

		}
	}


	[NVP_Manifest(
		Id = "A903AB15-EF04-42F0-A1FC-328E53E568F6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Part_Insulation_Disableview", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Part_Insulation_Disableview", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Insulation_Disableview", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Part_Insulation_Disableview
	///</summary>
	public class Set_Part_Insulation_Disableview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Insulation_Disableview = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "83A3EF76-2435-455B-844E-47502B5B7CE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Part_Insulation_Not_Start", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Part_Insulation_Not_Start", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class Part_Insulation_Not_Start : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Insulation_Not_Start);

		}
	}


	[NVP_Manifest(
		Id = "28E523B0-6C89-46C0-8054-AF9F3C4FDC5D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Part_Insulation_Not_Start", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Part_Insulation_Not_Start", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///мм)
	///</summary>
	public class Set_Part_Insulation_Not_Start : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Insulation_Not_Start = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "78694F42-E736-48F7-9944-3717775275EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Part_Insulation_Not_End", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Part_Insulation_Not_End", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class Part_Insulation_Not_End : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Insulation_Not_End);

		}
	}


	[NVP_Manifest(
		Id = "AF1AC66E-C333-4D12-B3B7-B2DA32C80515", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Part_Insulation_Not_End", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Part_Insulation_Not_End", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///мм)
	///</summary>
	public class Set_Part_Insulation_Not_End : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Insulation_Not_End = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FBC3ED79-794C-41BF-9F84-9F5EB8B2DECA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Axis_Insulation_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Axis_Insulation_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_Thickness", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "F49FFE89-8C03-434B-AD8D-8ACAE7445E46", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Axis_Insulation_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Axis_Insulation_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_Thickness", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "0DB563CD-9CBC-4BD9-AE92-CFE13AF6199C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Axis_Insulation_Disableview", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Axis_Insulation_Disableview", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_Disableview", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "DC53DD9C-3262-439A-9BE1-E17A05688E96", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Axis_Insulation_Disableview", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Axis_Insulation_Disableview", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_Disableview", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "22435C85-94FF-4C22-81E5-61E8437D68AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Axis_Insulation_LineInsulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Axis_Insulation_LineInsulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_LineInsulation", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "AD238E2D-5E18-4A0D-B63D-8A9A5F5A4969", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Axis_Insulation_LineInsulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Axis_Insulation_LineInsulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_LineInsulation", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "A9C2AADB-803C-46E1-86D0-36C712BBA106", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Axis_Insulation_LineTrace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Axis_Insulation_LineTrace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_LineTrace", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "BD109749-538A-47C2-B996-5E71DC1EE952", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Axis_Insulation_LineTrace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Axis_Insulation_LineTrace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_LineTrace", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "C279DE7E-3EC7-4B41-B47D-B6DA797AD69F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.GetAxisParamValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "GetAxisParamValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetAxisParamValue", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "FD50AA9F-CD43-46BE-B158-A6D8A7F8CC7B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Include", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "5A20A76E-1079-4201-8750-AE1E2C88445F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Include", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "31BB5F65-9D58-4996-8773-497B0603CE05", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Number", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "5444A5E3-FC70-4CFC-BE2C-76EF3B1F3344", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Number", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "2D9C5C44-C31C-4133-BBF1-B6B6DB5B155D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Group", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "A708B0B7-5262-47EC-93FC-7E494BB55767", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "400AA691-646D-4FD7-B69F-35D72A012866", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Comment", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "67A0A8A5-C569-4778-A30C-F90331EABCC9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "9DB25D0C-6AFB-457B-8DAA-AB834B55FEC4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Include", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "AC88E88D-C32B-4E93-9DE1-2E7F180C558E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Include", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "F9E3DAB3-C767-48D0-92B7-D2DB40EA06C4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Number", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "DA8F1366-052F-4FE0-873B-967EE1F43A89", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Number", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "E23B2400-5B68-4FBA-B4FA-63BBD05B4E8B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Group", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "907DDC31-AE8C-4648-8E50-3692A3A3507E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "6B94BC4D-D3A2-4B62-9043-8D5977F6D460", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Qty", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "5D570C44-BEDB-4FB0-AF67-CFC1A8C84C7E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Qty", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "967C2C8E-5054-447C-A997-848D7322D7A7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Comment", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "390B0831-03DA-45BC-BCEB-F211BBFD3F07", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "A5618287-9F84-49EB-B87F-E5A8FAB4680A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.PartPipe_Lock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "PartPipe_Lock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property LockComponent", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]

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
		Id = "220A121D-283C-4044-9120-4C2347F10BF5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.Set_PartPipe_Lock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "Set_PartPipe_Lock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property LockComponent", 
		ViewType = "Modifier")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "06DB7894-747F-415F-9F0E-08EFA7BAC42F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.GetArea", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "GetArea", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetArea", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]
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
		Id = "C7251B1E-E353-44AE-AC2C-855D022181AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSubSegment.GetVolume", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSubSegment", 
		NodeName = "GetVolume", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetVolume", 
		ViewType = "Data")]
	[NodeInput("WrSubSegment", typeof(object))]
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
