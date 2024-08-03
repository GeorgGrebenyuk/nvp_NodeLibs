using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSViewportFrame Interface
///</summary>
namespace mdsUnitsLib.MDSViewportFrame 
{

	[NVP_Manifest(
		Id = "0BC56B54-8B0D-4E3F-A13F-73487AE79A45", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.MDSViewportFrame_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "_MDSViewportFrame_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSViewportFrame_Constructor : INode 
	{
		public mdsUnitsLib.IMDSViewportFrame _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IMDSViewportFrame;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "D6625670-D5FD-44F8-A786-DB74C763B902", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.MDSViewportFrame_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "_MDSViewportFrame_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSViewportFrame_ConstructorCast : INode 
	{
		public mdsUnitsLib.IMDSViewportFrame _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IMDSViewportFrame;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "27DF724E-5E56-4C62-BD32-435C2CA616FD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование вида", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Наименование вида
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
		Id = "FF192A2E-082D-488F-9767-3C2F5E820768", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование вида", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Наименование вида
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
		Id = "4274F9BA-0591-4BD6-B5EA-719F3576AD64", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Profile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Profile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Профиль", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Профиль
	///</summary>
	public class Profile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Profile);

		}
	}


	[NVP_Manifest(
		Id = "B8D4EE24-6A6D-4C96-B7E2-EAA6F101F8D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_Profile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_Profile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Профиль", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Профиль
	///</summary>
	public class Set_Profile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Profile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DD36F2FA-B800-41E7-864E-455789C793BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Центральная точка", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Центральная точка
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
		Id = "1AE91B2D-D8AD-4150-89B1-A60A78154D92", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Центральная точка", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Центральная точка
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
		Id = "3F426FCA-5666-40CF-928A-5FE1629E484F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Направление", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Направление
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
		Id = "1112E94D-2EFA-4321-8C4E-87211C0AA559", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Направление", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Направление
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
		Id = "3FCE6169-89BD-4AB6-AC89-B419E376F4EA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Target", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Target", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Цель", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Цель
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
		Id = "C0980DF2-2EFD-420F-AC5F-32F72C5CB9B3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_Target", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_Target", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Цель", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Цель
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
		Id = "72007F68-AB5A-4E48-B405-B292A7FE1D6E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ширина", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

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
		Id = "65907842-75A5-4EB0-ABCD-49E581F60F39", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ширина", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
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
		Id = "101E9D86-8EDA-488A-85BE-032176F1EECA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Высота", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

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
		Id = "603EEDD8-B47E-42E5-8481-1E4F41F21240", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Высота", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
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
		Id = "F5A0C179-808F-4334-8E2F-FBE3BC971933", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.CustomScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "CustomScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Пользовательский масштаб", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Пользовательский масштаб
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
		Id = "3706D1F5-171F-4F8D-9FE0-09A7ED52958A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_CustomScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_CustomScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Пользовательский масштаб", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Пользовательский масштаб
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
		Id = "2DFFA8E9-3EE1-4064-AD38-C8AA9C5E2A9D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Scale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Scale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масштаб", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Масштаб
	///</summary>
	public class Scale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Scale);

		}
	}


	[NVP_Manifest(
		Id = "7EF5F7E2-E861-4A96-99C9-77E525839BAA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_Scale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_Scale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масштаб", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Масштаб
	///</summary>
	public class Set_Scale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Scale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8A810476-705D-4EA0-8D02-070554FD901D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.TwistAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "TwistAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол поворота", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Угол поворота
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
		Id = "CF2C6573-3437-482A-9953-F71E07A8C83C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_TwistAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_TwistAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол поворота", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Угол поворота
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
		Id = "0CC677DD-9BEB-4D2D-980F-4EE65FABAC20", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.FrontClip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "FrontClip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Обрезка по фронтальной плоскости", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Обрезка по фронтальной плоскости
	///</summary>
	public class FrontClip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FrontClip);

		}
	}


	[NVP_Manifest(
		Id = "6CF66A0D-8B14-4010-B910-433A0F49EBDA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_FrontClip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_FrontClip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Обрезка по фронтальной плоскости", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Обрезка по фронтальной плоскости
	///</summary>
	public class Set_FrontClip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FrontClip = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "22AADB59-91FC-4F7A-8C30-74E9D8663920", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.FrontClipDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "FrontClipDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние до фронтальной плоскости", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Расстояние до фронтальной плоскости
	///</summary>
	public class FrontClipDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FrontClipDistance);

		}
	}


	[NVP_Manifest(
		Id = "3411DDD2-53FF-4135-AFA4-A5BEEC400291", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_FrontClipDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_FrontClipDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние до фронтальной плоскости", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Расстояние до фронтальной плоскости
	///</summary>
	public class Set_FrontClipDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FrontClipDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9B982EC7-E645-4C30-83B9-24564F6702B2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.BackClip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "BackClip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Обрезка по задней плоскости", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Обрезка по задней плоскости
	///</summary>
	public class BackClip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackClip);

		}
	}


	[NVP_Manifest(
		Id = "50138AD4-0093-4760-AEC8-78674E6B3F61", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_BackClip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_BackClip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Обрезка по задней плоскости", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Обрезка по задней плоскости
	///</summary>
	public class Set_BackClip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackClip = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "240CB1E3-A0BC-41A1-A9DF-6EB1DD124672", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.BackClipDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "BackClipDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние до задней плоскости", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Расстояние до задней плоскости
	///</summary>
	public class BackClipDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackClipDistance);

		}
	}


	[NVP_Manifest(
		Id = "4E1F50B2-AD24-4E37-80EB-158BB2A10694", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_BackClipDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_BackClipDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние до задней плоскости", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Расстояние до задней плоскости
	///</summary>
	public class Set_BackClipDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackClipDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0516B345-A420-44D3-9CAD-13D4785F8940", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.XRefName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "XRefName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Файл внешней ссылки", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Файл внешней ссылки
	///</summary>
	public class XRefName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.XRefName);

		}
	}


	[NVP_Manifest(
		Id = "6BA69ADE-BB7B-47BD-8CD8-8FAC67188B5B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_XRefName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_XRefName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Файл внешней ссылки", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Файл внешней ссылки
	///</summary>
	public class Set_XRefName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.XRefName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A7280BCB-0982-45DD-9E2C-053B5D831F5C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.ProjectionType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "ProjectionType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип проекции", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Тип проекции
	///</summary>
	public class ProjectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProjectionType);

		}
	}


	[NVP_Manifest(
		Id = "572865AE-E79E-4465-ACB6-8CD6E1CD054D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.SelectionType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "SelectionType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Набор объектов", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Набор объектов
	///</summary>
	public class SelectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SelectionType);

		}
	}


	[NVP_Manifest(
		Id = "8D9D579B-D592-4349-8B62-4A7CF4C8124C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_SelectionType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_SelectionType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Набор объектов", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Набор объектов
	///</summary>
	public class Set_SelectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SelectionType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CFC7E7E4-1478-4310-B994-F14B82F0F895", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.ObjectFilter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "ObjectFilter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Фильтр объектов", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Фильтр объектов
	///</summary>
	public class ObjectFilter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectFilter);

		}
	}


	[NVP_Manifest(
		Id = "481216E4-60B2-4DE4-97FC-2782E95D5E2E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_ObjectFilter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_ObjectFilter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Фильтр объектов", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Фильтр объектов
	///</summary>
	public class Set_ObjectFilter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObjectFilter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "44DAD469-5D97-4116-A6D0-4004C3F4FA48", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Quality", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Quality", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Качество", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Качество
	///</summary>
	public class Quality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Quality);

		}
	}


	[NVP_Manifest(
		Id = "28B86AEE-43C1-4EA8-9EDC-31968BFAE6AD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_Quality", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_Quality", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Качество", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Качество
	///</summary>
	public class Set_Quality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Quality = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D2DBC7EE-5A8A-4533-817B-9B2267710DB3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.LOD", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "LOD", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Уровень детализации", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Уровень детализации
	///</summary>
	public class LOD : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LOD);

		}
	}


	[NVP_Manifest(
		Id = "C1FDDE53-223F-4C2F-B5C1-CA5DB6E9E418", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_LOD", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_LOD", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Уровень детализации", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Уровень детализации
	///</summary>
	public class Set_LOD : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LOD = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CC9A89CE-E4FF-4906-A773-3BCACBCB3847", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.GenerateInvisibleLines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "GenerateInvisibleLines", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Генерировать невидимые линии", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Генерировать невидимые линии
	///</summary>
	public class GenerateInvisibleLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GenerateInvisibleLines);

		}
	}


	[NVP_Manifest(
		Id = "EBD9B336-1814-4633-AB06-40922CF698C9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_GenerateInvisibleLines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_GenerateInvisibleLines", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Генерировать невидимые линии", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Генерировать невидимые линии
	///</summary>
	public class Set_GenerateInvisibleLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GenerateInvisibleLines = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D5A31705-8385-4FFE-8ADD-0DDB9CB119FD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.LabelTextVisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "LabelTextVisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Включить надписывание", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Включить надписывание
	///</summary>
	public class LabelTextVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelTextVisible);

		}
	}


	[NVP_Manifest(
		Id = "22F5B7D1-C803-4952-A31B-C23DE005DEE5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_LabelTextVisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_LabelTextVisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Включить надписывание", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Включить надписывание
	///</summary>
	public class Set_LabelTextVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelTextVisible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "02B1012F-25C4-49BF-9A44-E26FB96B5368", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.LabelTextExpression", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "LabelTextExpression", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Текст", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Текст
	///</summary>
	public class LabelTextExpression : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelTextExpression);

		}
	}


	[NVP_Manifest(
		Id = "736C4DB3-8471-4ACC-9161-900FAB8398CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_LabelTextExpression", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_LabelTextExpression", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Текст", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Текст
	///</summary>
	public class Set_LabelTextExpression : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelTextExpression = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F82E4870-A94B-4FE7-A5E0-5C20CF205EA8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.LabelTextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "LabelTextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Стиль текста", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Стиль текста
	///</summary>
	public class LabelTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelTextStyle);

		}
	}


	[NVP_Manifest(
		Id = "F90440E0-AC4C-499B-8159-91791EB3B8E1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_LabelTextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_LabelTextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Стиль текста", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Стиль текста
	///</summary>
	public class Set_LabelTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelTextStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "24C23CFD-22C9-4060-A986-9144896CF8B7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.LabelTextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "LabelTextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Высота текста", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Высота текста
	///</summary>
	public class LabelTextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelTextHeight);

		}
	}


	[NVP_Manifest(
		Id = "632274FF-A337-400A-A756-BE86600FE4FA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_LabelTextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_LabelTextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Высота текста", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Высота текста
	///</summary>
	public class Set_LabelTextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelTextHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D847350A-8A16-4C36-B875-2D029EC2B41E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.LabelTextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "LabelTextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Точка привязки", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Точка привязки
	///</summary>
	public class LabelTextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelTextPosition);

		}
	}


	[NVP_Manifest(
		Id = "92C1200C-2B51-4EC2-B692-9B2855783611", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_LabelTextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_LabelTextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Точка привязки", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Точка привязки
	///</summary>
	public class Set_LabelTextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelTextPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F45C4E56-E8E2-4BB1-A906-079A151B9DEF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.LabelTextOffsetX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "LabelTextOffsetX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Смещение текста по X", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Смещение текста по X
	///</summary>
	public class LabelTextOffsetX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelTextOffsetX);

		}
	}


	[NVP_Manifest(
		Id = "F2A66B71-3453-493F-81C9-AEC6A4605547", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_LabelTextOffsetX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_LabelTextOffsetX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Смещение текста по X", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Смещение текста по X
	///</summary>
	public class Set_LabelTextOffsetX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelTextOffsetX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "95763CCD-240F-4053-9C74-4D6A85AA89D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.LabelTextOffsetY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "LabelTextOffsetY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Смещение текста по Y", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Смещение текста по Y
	///</summary>
	public class LabelTextOffsetY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelTextOffsetY);

		}
	}


	[NVP_Manifest(
		Id = "EAF3DD03-5B77-4EF5-B6B5-3AE0011946E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_LabelTextOffsetY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_LabelTextOffsetY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Смещение текста по Y", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Смещение текста по Y
	///</summary>
	public class Set_LabelTextOffsetY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelTextOffsetY = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E111E780-46D4-4F40-832D-72021A24F10C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.LabelFrame", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "LabelFrame", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Рамка вокруг текста", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Рамка вокруг текста
	///</summary>
	public class LabelFrame : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelFrame);

		}
	}


	[NVP_Manifest(
		Id = "FBF6DAC7-908A-436F-BE6A-41F399DD177A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_LabelFrame", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_LabelFrame", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Рамка вокруг текста", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Рамка вокруг текста
	///</summary>
	public class Set_LabelFrame : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelFrame = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FC15FDC5-CE91-49B0-9859-E507724E3039", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.LabelFrameOffsX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "LabelFrameOffsX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Радиус или отступ по X для надписи", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Радиус или отступ по X для надписи
	///</summary>
	public class LabelFrameOffsX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelFrameOffsX);

		}
	}


	[NVP_Manifest(
		Id = "E0AD6E80-2603-43FE-A57D-AAEC1CB8860F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_LabelFrameOffsX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_LabelFrameOffsX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Радиус или отступ по X для надписи", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Радиус или отступ по X для надписи
	///</summary>
	public class Set_LabelFrameOffsX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelFrameOffsX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4F27F45B-F0B4-4E14-A721-06A8DA964563", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.LabelFrameOffsY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "LabelFrameOffsY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Отступ по Y для надписи", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Отступ по Y для надписи
	///</summary>
	public class LabelFrameOffsY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelFrameOffsY);

		}
	}


	[NVP_Manifest(
		Id = "ABE7B096-E4D4-4766-94FB-95097871A1A5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_LabelFrameOffsY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_LabelFrameOffsY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Отступ по Y для надписи", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Отступ по Y для надписи
	///</summary>
	public class Set_LabelFrameOffsY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelFrameOffsY = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BCA6F838-20B7-400F-9941-4600930C133C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.FrameLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "FrameLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Слой рамки", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Слой рамки
	///</summary>
	public class FrameLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FrameLayer);

		}
	}


	[NVP_Manifest(
		Id = "FEE9833F-CD6C-48E0-91F1-4BDDE945FD7F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_FrameLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_FrameLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Слой рамки", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Слой рамки
	///</summary>
	public class Set_FrameLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FrameLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8513408D-6D0E-4853-9816-1165950695E4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.PrintFrame", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "PrintFrame", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Печать рамки", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Печать рамки
	///</summary>
	public class PrintFrame : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrintFrame);

		}
	}


	[NVP_Manifest(
		Id = "B9B78A8C-FDB5-4D5D-8807-EE838F24747D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportFrame.Set_PrintFrame", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportFrame", 
		NodeName = "Set_PrintFrame", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Печать рамки", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Печать рамки
	///</summary>
	public class Set_PrintFrame : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PrintFrame = inputs[1].Value;
			return null;
		}
	}
}
