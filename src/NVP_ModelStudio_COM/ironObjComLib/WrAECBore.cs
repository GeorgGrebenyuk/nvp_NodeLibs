using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrAECBore Interface
///</summary>
namespace ironObjComLib.WrAECBore 
{

	[NVP_Manifest(
		Id = "E630ABA2-6028-4D7D-BFDF-EB7D23AC5A9A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.WrAECBore_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "_WrAECBore_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECBore_Constructor : INode 
	{
		public ironObjComLib.IWrAECBore _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrAECBore;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "4CF01904-E2DF-4955-87DF-3C69EFA888F4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.WrAECBore_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "_WrAECBore_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECBore_ConstructorCast : INode 
	{
		public ironObjComLib.IWrAECBore _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrAECBore;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "5DA43D4C-58A1-42F3-98D3-8A14CC57D7B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

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
		Id = "D652ADF6-B0BD-4376-9F02-A9C8EF7F6C44", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("WrAECBore", typeof(object))]
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
		Id = "E184F18D-DDFC-44CB-9606-655917FAA17F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.BoreType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "BoreType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип скважины", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

	///<summary>
	///Тип скважины
	///</summary>
	public class BoreType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BoreType);

		}
	}


	[NVP_Manifest(
		Id = "AFE3572C-4779-49EC-9F7A-3CE74065BF1D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.Set_BoreType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "Set_BoreType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип скважины", 
		ViewType = "Modifier")]
	[NodeInput("WrAECBore", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип скважины
	///</summary>
	public class Set_BoreType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BoreType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4F3E012F-F4C6-410C-9E89-22398097D02C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.BoreVolume", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "BoreVolume", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Объем,м3", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

	///<summary>
	///Объем,м3
	///</summary>
	public class BoreVolume : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BoreVolume);

		}
	}


	[NVP_Manifest(
		Id = "F003A175-FAB8-46CF-AF3F-43FCC0C0C674", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.BoreAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "BoreAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол откоса, град", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

	///<summary>
	///Угол откоса, град
	///</summary>
	public class BoreAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BoreAngle);

		}
	}


	[NVP_Manifest(
		Id = "974D5B82-BE7C-431B-B005-26A0A0EC0961", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.Set_BoreAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "Set_BoreAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол откоса, град", 
		ViewType = "Modifier")]
	[NodeInput("WrAECBore", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Угол откоса, град
	///</summary>
	public class Set_BoreAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BoreAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F9C8C72C-C0DB-4376-A628-59D3CCC8DD28", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.BoreDepthTop", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "BoreDepthTop", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "До верха от базовой", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

	///<summary>
	///До верха от базовой
	///</summary>
	public class BoreDepthTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BoreDepthTop);

		}
	}


	[NVP_Manifest(
		Id = "F9AFE382-1FCB-469A-8ADF-25F0273E708F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.Set_BoreDepthTop", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "Set_BoreDepthTop", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "До верха от базовой", 
		ViewType = "Modifier")]
	[NodeInput("WrAECBore", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///До верха от базовой
	///</summary>
	public class Set_BoreDepthTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BoreDepthTop = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D415DC5A-340B-44B7-AEEA-E5DFBFE704DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.BoreDepthBottom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "BoreDepthBottom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "До низа от базовой", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

	///<summary>
	///До низа от базовой
	///</summary>
	public class BoreDepthBottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BoreDepthBottom);

		}
	}


	[NVP_Manifest(
		Id = "81040484-D2C1-4D73-A8AD-DE957BDCE51E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.Set_BoreDepthBottom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "Set_BoreDepthBottom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "До низа от базовой", 
		ViewType = "Modifier")]
	[NodeInput("WrAECBore", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///До низа от базовой
	///</summary>
	public class Set_BoreDepthBottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BoreDepthBottom = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7D4CF815-1D3A-4600-814B-642BB4EAB0AD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.BoreSize1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "BoreSize1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Размер 1", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

	///<summary>
	///Размер 1
	///</summary>
	public class BoreSize1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BoreSize1);

		}
	}


	[NVP_Manifest(
		Id = "C72AB1E1-1831-4F7D-BE89-64AEBD7ACEE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.Set_BoreSize1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "Set_BoreSize1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Размер 1", 
		ViewType = "Modifier")]
	[NodeInput("WrAECBore", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Размер 1
	///</summary>
	public class Set_BoreSize1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BoreSize1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EF596008-F3F0-4440-B63E-C5CE5E3BA1B9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.BoreSize2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "BoreSize2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Размер 2", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

	///<summary>
	///Размер 2
	///</summary>
	public class BoreSize2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BoreSize2);

		}
	}


	[NVP_Manifest(
		Id = "AB999EBB-C854-4659-922D-6C4ADDA34259", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.Set_BoreSize2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "Set_BoreSize2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Размер 2", 
		ViewType = "Modifier")]
	[NodeInput("WrAECBore", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Размер 2
	///</summary>
	public class Set_BoreSize2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BoreSize2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1C469742-10C0-4934-8633-47269C269A35", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.BoreDiam", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "BoreDiam", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Диаметр", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

	///<summary>
	///Диаметр
	///</summary>
	public class BoreDiam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BoreDiam);

		}
	}


	[NVP_Manifest(
		Id = "DFD17057-6CCF-45B5-86D4-FD2FA463C689", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.Set_BoreDiam", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "Set_BoreDiam", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Диаметр", 
		ViewType = "Modifier")]
	[NodeInput("WrAECBore", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Диаметр
	///</summary>
	public class Set_BoreDiam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BoreDiam = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6DB16A67-ED7B-4A35-A4AC-163BEBE09823", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.BoreAngleXY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "BoreAngleXY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол в плане", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

	///<summary>
	///Угол в плане
	///</summary>
	public class BoreAngleXY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BoreAngleXY);

		}
	}


	[NVP_Manifest(
		Id = "136D9E65-F4FA-438E-A30B-6FB51E70630E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECBore.Set_BoreAngleXY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECBore", 
		NodeName = "Set_BoreAngleXY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол в плане", 
		ViewType = "Modifier")]
	[NodeInput("WrAECBore", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Угол в плане
	///</summary>
	public class Set_BoreAngleXY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BoreAngleXY = inputs[1].Value;
			return null;
		}
	}
}
