using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ImstRoutePrototype Interface
///</summary>
namespace mstRouteCOMLib.mstRoutePrototype 
{

	[NVP_Manifest(
		Id = "A1980669-7404-4300-8E2D-155B8803ACCF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.mstRoutePrototype_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "_mstRoutePrototype_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class mstRoutePrototype_Constructor : INode 
	{
		public mstRouteCOMLib.ImstRoutePrototype _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mstRouteCOMLib.ImstRoutePrototype;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "F17A6A27-87B6-447F-8D26-1D1087F96A9C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.mstRoutePrototype_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "_mstRoutePrototype_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class mstRoutePrototype_ConstructorCast : INode 
	{
		public mstRouteCOMLib.ImstRoutePrototype _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mstRouteCOMLib.ImstRoutePrototype;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "4E9756D9-BF8C-4FDD-92CE-503AC3645991", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.StartPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "StartPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "StartPoint", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///StartPoint
	///</summary>
	public class StartPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartPosition);

		}
	}


	[NVP_Manifest(
		Id = "2F370381-16D3-4A8A-B2DB-65048A1A535C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.Set_StartPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "Set_StartPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "StartPoint", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///StartPoint
	///</summary>
	public class Set_StartPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "83E9D0E8-8B07-424E-8403-3D98758A956A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.EndPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "EndPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "EndPoint", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///EndPoint
	///</summary>
	public class EndPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndPosition);

		}
	}


	[NVP_Manifest(
		Id = "9E047657-B184-49DC-A60A-0AE26AB2B3BC", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.Set_EndPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "Set_EndPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "EndPoint", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///EndPoint
	///</summary>
	public class Set_EndPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "690DEC75-A8EA-4999-A3EF-A1C35BF9BF5D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

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
		Id = "CBC4449A-706F-49DE-8911-64C6E066EA56", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
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
		Id = "A19FC422-DE07-4ED0-8CD2-207FF6D4D6FB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.Shelves", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "Shelves", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Полки", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///Полки
	///</summary>
	public class Shelves : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Shelves);

		}
	}


	[NVP_Manifest(
		Id = "541F0303-4F9A-4AD1-81E4-8DE4F495D45C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.Set_Shelves", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "Set_Shelves", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Полки", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Полки
	///</summary>
	public class Set_Shelves : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Shelves = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9C895CAD-99E7-4D4E-86E9-0C74893266F4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Normal", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///Normal
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
		Id = "3AE41DA1-3AFA-48FA-93AE-B24564A697E0", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.Set_Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "Set_Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Normal", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Normal
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
		Id = "FABC5689-4FE6-404C-A2BA-827D68616A98", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///Длина
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
		Id = "3EF601A5-DF0F-4585-85F3-08C1BE53AB19", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.Set_Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "Set_Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Длина
	///</summary>
	public class Set_Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Length = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0B505629-D279-4B6C-BA07-2B0D56C557E1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.Radius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "Radius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Радиус", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///Радиус
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
		Id = "70298D29-67BA-4576-85CB-5C4A35E4E992", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.Set_Radius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "Set_Radius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Радиус", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Радиус
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
		Id = "149AF047-2DAD-49AC-9B2A-905FE4DC6C2D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.ProfileType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "ProfileType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип профиля", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///Тип профиля
	///</summary>
	public class ProfileType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProfileType);

		}
	}


	[NVP_Manifest(
		Id = "3A27069F-5563-49CE-AB56-94DB164B150C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.Set_ProfileType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "Set_ProfileType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип профиля", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип профиля
	///</summary>
	public class Set_ProfileType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ProfileType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "706DF5C0-956A-4691-AC45-6D7D9F67BBBC", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.BendType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "BendType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Плоскость изгиба", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///Плоскость изгиба
	///</summary>
	public class BendType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BendType);

		}
	}


	[NVP_Manifest(
		Id = "123CFF26-05C6-4FF0-B828-378EE790C3CD", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.Set_BendType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "Set_BendType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Плоскость изгиба", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Плоскость изгиба
	///</summary>
	public class Set_BendType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BendType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "46819FFB-11AD-43D3-888E-96DF09710A01", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.ShowDir", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "ShowDir", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Показывать направление", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///Показывать направление
	///</summary>
	public class ShowDir : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowDir);

		}
	}


	[NVP_Manifest(
		Id = "B5FB6608-AE92-4276-AF8D-CB2C171F353A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRoutePrototype.Set_ShowDir", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRoutePrototype", 
		NodeName = "Set_ShowDir", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Показывать направление", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Показывать направление
	///</summary>
	public class Set_ShowDir : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowDir = inputs[1].Value;
			return null;
		}
	}
}
