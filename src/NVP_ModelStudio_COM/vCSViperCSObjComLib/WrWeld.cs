using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrWeld Interface
///</summary>
namespace vCSViperCSObjComLib.WrWeld 
{

	[NVP_Manifest(
		Id = "E82B1F00-1420-4B74-A50A-47029DE44507", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.WrWeld_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "_WrWeld_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrWeld_Constructor : INode 
	{
		public vCSViperCSObjComLib.IWrWeld _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as vCSViperCSObjComLib.IWrWeld;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "65D708A2-A73C-4A50-B074-B62DF3B1FFD3", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.WrWeld_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "_WrWeld_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrWeld_ConstructorCast : INode 
	{
		public vCSViperCSObjComLib.IWrWeld _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as vCSViperCSObjComLib.IWrWeld;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "56310BE9-AADC-4E66-9118-DC54A4025BF8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.PipeLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "PipeLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Слой по умолчанию", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "6B04A7BC-37E4-4B31-970D-A1FC93631D16", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_PipeLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_PipeLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Слой по умолчанию", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "7E5E9FDE-DC88-4C60-8900-33B6BB18D6CA", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры объекта", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

	///<summary>
	///Параметры объекта
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
		Id = "789E94A4-9C3B-48A9-8F80-513746868BE1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры объекта", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Параметры объекта
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
		Id = "72BB736D-302F-4C81-AA29-02920670BE54", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.OwnerSegId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "OwnerSegId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Номер сегмента", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

	///<summary>
	///Номер сегмента
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
		Id = "6405D4F7-FD2D-4D5A-ADF8-E05913AAC191", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_OwnerSegId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_OwnerSegId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Номер сегмента", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Номер сегмента
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
		Id = "498EF364-EC63-492E-A13E-EED8BFA5D536", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.ViewMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "ViewMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Режим просмотра", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

	///<summary>
	///Режим просмотра
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
		Id = "3AD3FE7F-CFB7-407D-A03F-5249331199E1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_ViewMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_ViewMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Режим просмотра", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Режим просмотра
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
		Id = "58A1402D-0FB6-41EA-9345-BF9A5DB587C3", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.ElementAxis", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "ElementAxis", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Осевая линия", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

	///<summary>
	///Осевая линия
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
		Id = "AD0C2718-F6DE-4030-AD3D-C3963E8F5165", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_ElementAxis", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_ElementAxis", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Осевая линия", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Осевая линия
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
		Id = "819838F7-4FA8-4722-819D-BDFD28BFFF08", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Положение", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

	///<summary>
	///Положение
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
		Id = "6596232A-83B9-4657-9789-DC038EB470C0", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.OrderOnLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "OrderOnLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Номер на линии", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "BC154B68-F4BF-4409-9CA5-9CADA98644ED", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Name", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "8F54465B-28D8-49AC-8462-9809D8894727", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Name", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "F4913A89-1729-4C81-A34D-A661698F9DF7", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Tag", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "3FCF70E6-DA35-4778-B54A-359FF7C50E63", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Tag", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "2E2F273B-A6F7-44B3-9063-E3EBCC5D5BDD", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Part_Manufacturer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Part_Manufacturer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Manufacturer", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "05C6CC0F-E105-445A-AD3A-649075307181", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Part_Manufacturer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Part_Manufacturer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Manufacturer", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "B5CF88D0-C1DF-4F36-817D-1AE974D00A59", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Part_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Part_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Standard", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "ABC37830-6F26-4BA5-9254-599C2FFAC32C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Part_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Part_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Standard", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "3BD166CA-73FE-40D0-9C8C-F4110C6E8413", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Refdrawing", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "531051E7-9292-4F1F-A696-E763EF9D84C2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Refdrawing", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "4320971D-D8F7-4D52-BA44-F6929BF0C527", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "BC08FAE3-0D72-421F-AC0F-CA2AA4DD685C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "5B2A3389-EED2-4481-AAAC-61005F606640", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material_Standard", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "596E9D6A-DEAE-427D-9577-205877418E38", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material_Standard", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "7C41E8F4-C544-4FAE-B827-B0C19E8BA15A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "13A3B0F4-113A-421F-B313-1C3BD42323DE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "C6BBB6D2-F59C-49D1-81E6-60E567ADA5EA", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Comment", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "48124213-F946-4EE1-AB54-BC175D5A1260", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "F0D482F1-28EF-4CBC-85B1-43F1B3D2F0E1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.PartPipe_PN", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "PartPipe_PN", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_PN", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

	///<summary>
	///property PartPipe_PN
	///</summary>
	public class PartPipe_PN : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_PN);

		}
	}


	[NVP_Manifest(
		Id = "43A049E7-27E1-4201-85DA-76D2523E8DF6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_PartPipe_PN", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_PartPipe_PN", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_PN", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PartPipe_PN
	///</summary>
	public class Set_PartPipe_PN : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_PN = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8B566537-1B4E-47F4-95FF-EB4454C667F2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.PartPipe_DN", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "PartPipe_DN", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_DN", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "6EE812C9-AD5C-4657-98AA-20AEDB71C00E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_PartPipe_DN", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_PartPipe_DN", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_DN", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "44F036B0-F121-482B-8532-AB9C7D91BAFE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.PartPipe_Diam", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "PartPipe_Diam", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Diam", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "EF3D4709-16F4-429B-8BAE-9EA78457BC11", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_PartPipe_Diam", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_PartPipe_Diam", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Diam", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "A69D3411-89D2-45E6-B3DD-2718472D921A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Part_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Part_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Group", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "F45720BA-225C-4E3E-8C32-0CF2DDDF2D59", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Part_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Part_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "B616DAF3-0E45-4A65-A5EA-D60F34AB75F1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Part_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Part_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Type", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "F0D2364E-70CD-47EE-87DD-AFE5CC325D11", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Part_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Part_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Type", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "8D16F290-955E-49EE-B840-F9780136E537", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Part_Reference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Part_Reference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Reference", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "FA72C695-6506-48F6-99AC-ABCCD1BE8145", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Part_Reference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Part_Reference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Reference", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "D223BF28-893B-4211-AE02-FBAAB7C9FB5D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Part_Weight_Netto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Part_Weight_Netto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Netto", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "783F5DF5-984B-45E8-976C-C219B3E00574", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Part_Weight_Netto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Part_Weight_Netto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Netto", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "C53EF661-83AD-45EA-B666-BAC1B5891E16", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Part_Weight_Bruto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Part_Weight_Bruto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Bruto", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "0946418A-85D4-463F-9FA1-EB87739A4FBA", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Part_Weight_Bruto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Part_Weight_Bruto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Bruto", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "5454D9BE-18F8-45DF-8F12-29EF4F38C3CB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Include", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "F5CD05FF-DF14-42D3-BAC1-18F480F2FB57", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Include", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "CD84E182-E249-495F-BC9D-1700907932C4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Number", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "3B529DC1-45B0-4DDD-8E92-E4481B52A85A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Number", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "9C014A81-0A84-463B-9AB6-E1A7CF5DE4A9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Group", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "B8E059C5-6AFD-411E-9204-33E850D6CE1B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "021E9F9C-D9FF-40B5-9C3F-932A48B5F669", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Comment", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "B1DBDFFA-295C-41A9-99DE-67C98782A2C1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "2E5B3C2E-81BB-4E7E-AB41-609E4129A72F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Include", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "0804CC6C-C379-42B4-BF9F-582C76990F63", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Include", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "787EF11A-D4B4-4692-A462-C1D387EE6D93", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Number", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "0DE1C520-A47C-400D-A360-673F3A899D5F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Number", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "87E8B65E-EEC8-4E95-A3FC-4EDB3ADBCB03", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Group", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "1ACF343E-78CA-4EC3-A28B-02C214D8E6F7", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "76133A26-071D-46EE-B21E-F72438E17384", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Qty", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "FEE6FD13-23FB-4D29-BDE4-E1ED2E8FA716", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Qty", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "B2D733D2-A9DA-4698-B2EE-F2A7EDCF37C8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Comment", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

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
		Id = "4F7FCE19-F267-4262-8E1F-543CE2F193DC", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.Set_Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "Set_Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "F7EA7792-7623-4CFB-AD35-91F6A0CC0DA6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.GetArea", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "GetArea", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetArea", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]
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
		Id = "7F8AE7E9-F973-441D-A7B8-89588FDCDF8C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.GetVolume", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "GetVolume", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetVolume", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]
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


	[NVP_Manifest(
		Id = "3E3AF836-3857-4F19-835F-4DBB1AE55371", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.PrevElement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "PrevElement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Предыдущий объект", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

	///<summary>
	///Предыдущий объект
	///</summary>
	public class PrevElement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrevElement);

		}
	}


	[NVP_Manifest(
		Id = "D95CDD25-EC9C-4C2B-9AFA-430E156AF07B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrWeld.NextElement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrWeld", 
		NodeName = "NextElement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Следующий объект", 
		ViewType = "Data")]
	[NodeInput("WrWeld", typeof(object))]

	///<summary>
	///Следующий объект
	///</summary>
	public class NextElement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NextElement);

		}
	}
}
