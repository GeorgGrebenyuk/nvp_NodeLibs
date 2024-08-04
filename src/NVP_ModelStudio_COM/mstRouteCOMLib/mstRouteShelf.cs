using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace mstRouteCOMLib.mstRouteShelf 
{

	[NVP_Manifest(
		Id = "A356334D-5CA2-44C3-9600-D477E932FB48", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelf.mstRouteShelf_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelf", 
		NodeName = "_mstRouteShelf_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class mstRouteShelf_Constructor : INode 
	{
		public mstRouteCOMLib.ImstRouteShelf _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mstRouteCOMLib.ImstRouteShelf;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "38914CE9-A4D1-4EE1-B1A5-0D8E07EE8247", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelf.mstRouteShelf_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelf", 
		NodeName = "_mstRouteShelf_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class mstRouteShelf_ConstructorCast : INode 
	{
		public mstRouteCOMLib.ImstRouteShelf _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mstRouteCOMLib.ImstRouteShelf;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "E51C1E04-194B-44C3-B9C7-218288FF9726", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelf.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelf", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры полки", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelf", typeof(object))]

	///<summary>
	///Параметры полки
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
		Id = "CC34D305-B098-46E3-8D74-0050D1B5AAEA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelf.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelf", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Номер полки", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelf", typeof(object))]

	///<summary>
	///Номер полки
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	[NVP_Manifest(
		Id = "FB906DFD-033F-4D01-BC1A-46596CDB2C81", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelf.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelf", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ширина", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelf", typeof(object))]

	///<summary>
	///Ширина
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
		Id = "82317094-E9F8-47BF-A1D2-8BCEDF790E0C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelf.Set_Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelf", 
		NodeName = "Set_Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ширина", 
		ViewType = "Modifier")]
	[NodeInput("mstRouteShelf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Ширина
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
		Id = "FDE429BE-92A2-411A-8DB1-95C228EE6FAF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelf.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelf", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Высота", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelf", typeof(object))]

	///<summary>
	///Высота
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
		Id = "616511D4-E297-4E9E-A0F5-82A7B37DC4E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelf.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelf", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Высота", 
		ViewType = "Modifier")]
	[NodeInput("mstRouteShelf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Высота
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
		Id = "E92CBF63-FC0D-466A-B440-44084AEAFB27", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelf.Offset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelf", 
		NodeName = "Offset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Смещение от оси вправо-влево", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelf", typeof(object))]

	///<summary>
	///Смещение от оси вправо-влево
	///</summary>
	public class Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Offset);

		}
	}


	[NVP_Manifest(
		Id = "337C294F-234C-4DEC-A5D5-70F54FA30041", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelf.Set_Offset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelf", 
		NodeName = "Set_Offset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Смещение от оси вправо-влево", 
		ViewType = "Modifier")]
	[NodeInput("mstRouteShelf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Смещение от оси вправо-влево
	///</summary>
	public class Set_Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Offset = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D747EE3D-D9EC-4BE2-AB88-A08AFB8597D6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelf.Elevation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelf", 
		NodeName = "Elevation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Смещение от оси вверх-вниз", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelf", typeof(object))]

	///<summary>
	///Смещение от оси вверх-вниз
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
		Id = "8E7E3850-76DF-4515-9B8B-D439961C4A7A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelf.Set_Elevation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelf", 
		NodeName = "Set_Elevation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Смещение от оси вверх-вниз", 
		ViewType = "Modifier")]
	[NodeInput("mstRouteShelf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Смещение от оси вверх-вниз
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
		Id = "3019AC1F-416B-4D64-9AA3-5D2221BD0D95", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelf.Reserve", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelf", 
		NodeName = "Reserve", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Резерв", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelf", typeof(object))]

	///<summary>
	///Резерв
	///</summary>
	public class Reserve : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Reserve);

		}
	}


	[NVP_Manifest(
		Id = "26A77891-AB89-4056-8F6F-99B7B6150AB9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelf.Set_Reserve", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelf", 
		NodeName = "Set_Reserve", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Резерв", 
		ViewType = "Modifier")]
	[NodeInput("mstRouteShelf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Резерв
	///</summary>
	public class Set_Reserve : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Reserve = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5B1CDCED-43AD-4FA0-B582-777C702AC913", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelf.Hilite", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelf", 
		NodeName = "Hilite", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Подсветка", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelf", typeof(object))]

	///<summary>
	///Подсветка
	///</summary>
	public class Hilite : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Hilite);

		}
	}


	[NVP_Manifest(
		Id = "912555FD-2745-4A4D-9655-C4BE724E7612", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelf.Set_Hilite", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelf", 
		NodeName = "Set_Hilite", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Подсветка", 
		ViewType = "Modifier")]
	[NodeInput("mstRouteShelf", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Подсветка
	///</summary>
	public class Set_Hilite : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Hilite = inputs[1].Value;
			return null;
		}
	}
}
