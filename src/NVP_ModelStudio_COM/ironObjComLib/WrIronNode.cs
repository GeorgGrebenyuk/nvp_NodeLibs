using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrIronNode Interface
///</summary>
namespace ironObjComLib.WrIronNode 
{

	[NVP_Manifest(
		Id = "14A2DACE-9F10-4655-96CB-AD8C88AAED63", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.WrIronNode_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "_WrIronNode_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrIronNode_Constructor : INode 
	{
		public ironObjComLib.IWrIronNode _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrIronNode;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "B7FA7527-181B-4103-923D-CB378093D080", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.WrIronNode_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "_WrIronNode_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrIronNode_ConstructorCast : INode 
	{
		public ironObjComLib.IWrIronNode _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrIronNode;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "BE844037-9915-4864-83E9-6966483E00E6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Item", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]

	///<summary>
	///method Item
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item);

		}
	}


	[NVP_Manifest(
		Id = "5279F5EB-5CD7-4170-9F9A-39CBFCF4591D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]

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
		Id = "F93469EC-A29F-4F97-96C8-C974D452D515", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("WrIronNode", typeof(object))]
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
		Id = "C54A343D-789B-4233-B363-2AC49920E038", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.UnitName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "UnitName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property UnitName", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]

	///<summary>
	///property UnitName
	///</summary>
	public class UnitName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnitName);

		}
	}


	[NVP_Manifest(
		Id = "F92BB394-7ACC-4B2D-927D-98F5673674E4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.Set_UnitName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "Set_UnitName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property UnitName", 
		ViewType = "Modifier")]
	[NodeInput("WrIronNode", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property UnitName
	///</summary>
	public class Set_UnitName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnitName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "346FF75A-E501-479D-8BB2-4F631058BBC7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.GetAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "GetAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property GetAngle", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]
	[NodeInput("axis1", typeof(System.Object))]
	[NodeInput("axis2", typeof(System.Object))]

	///<summary>
	///property GetAngle
	///</summary>
	public class GetAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAngle(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "5989D117-C94E-41F1-AADE-A6E2F1BDE32D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.GetAngleXY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "GetAngleXY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property GetAngleXY", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]
	[NodeInput("axis1", typeof(System.Object))]
	[NodeInput("axis2", typeof(System.Object))]

	///<summary>
	///property GetAngleXY
	///</summary>
	public class GetAngleXY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAngleXY(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "73D87F01-CE58-44AF-9B53-5C4E11C5A51F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.GetAngleXZ", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "GetAngleXZ", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property GetAngleXZ", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]
	[NodeInput("axis1", typeof(System.Object))]
	[NodeInput("axis2", typeof(System.Object))]

	///<summary>
	///property GetAngleXZ
	///</summary>
	public class GetAngleXZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAngleXZ(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "CA69F9AC-C06E-4E9D-839C-1CB7AD9505DE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Базовая точка", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]

	///<summary>
	///Базовая точка
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
		Id = "5380F195-441D-4349-B02F-06266ED5F878", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.BasePositionType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "BasePositionType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип положения базовой точки", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]

	///<summary>
	///Тип положения базовой точки
	///</summary>
	public class BasePositionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BasePositionType);

		}
	}


	[NVP_Manifest(
		Id = "F8184244-4F54-4674-826D-D2C20ED00553", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.Set_BasePositionType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "Set_BasePositionType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип положения базовой точки", 
		ViewType = "Modifier")]
	[NodeInput("WrIronNode", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип положения базовой точки
	///</summary>
	public class Set_BasePositionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BasePositionType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0A53EDD2-7D03-4D3C-8F0E-BA1EC010ADE9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.BasePositionValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "BasePositionValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Положение базовой точки на металле", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]

	///<summary>
	///Положение базовой точки на металле
	///</summary>
	public class BasePositionValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BasePositionValue);

		}
	}


	[NVP_Manifest(
		Id = "43858F39-0938-4B8F-8D32-13F7C7BEA1D4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.Set_BasePositionValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "Set_BasePositionValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Положение базовой точки на металле", 
		ViewType = "Modifier")]
	[NodeInput("WrIronNode", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Положение базовой точки на металле
	///</summary>
	public class Set_BasePositionValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BasePositionValue = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A27A6208-47CD-4980-872F-3EA689AE1F46", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.AxisDirectionType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "AxisDirectionType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип направления оси Z", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]

	///<summary>
	///Тип направления оси Z
	///</summary>
	public class AxisDirectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxisDirectionType);

		}
	}


	[NVP_Manifest(
		Id = "83EDE260-093F-44EB-873A-A75B3A7EECFE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.Set_AxisDirectionType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "Set_AxisDirectionType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип направления оси Z", 
		ViewType = "Modifier")]
	[NodeInput("WrIronNode", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип направления оси Z
	///</summary>
	public class Set_AxisDirectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AxisDirectionType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4CD8EA60-400C-4FF7-9809-C93614C054D4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.GetArea", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "GetArea", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetArea", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]
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
		Id = "2E876C59-5EFB-4385-BAB6-2AFAE42FECC2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronNode.GetVolume", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronNode", 
		NodeName = "GetVolume", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetVolume", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]
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
