using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSLevelMark Interface
///</summary>
namespace mdsURSLib.MDSLevelMark 
{

	[NVP_Manifest(
		Id = "E588A700-8B18-4D40-8449-AB43B9212808", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.MDSLevelMark_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "_MDSLevelMark_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLevelMark_Constructor : INode 
	{
		public mdsURSLib.IMDSLevelMark _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsURSLib.IMDSLevelMark;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "5063C5C4-7B95-4C12-9554-7B4C85C68331", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.MDSLevelMark_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "_MDSLevelMark_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLevelMark_ConstructorCast : INode 
	{
		public mdsURSLib.IMDSLevelMark _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsURSLib.IMDSLevelMark;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "1105A0E4-3787-4071-88DC-3C732814904E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Location", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Location", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Location", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property Location
	///</summary>
	public class Location : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Location);

		}
	}


	[NVP_Manifest(
		Id = "DA4EDE43-5137-4697-9C63-4C8D558864ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_Location", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_Location", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Location", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Location
	///</summary>
	public class Set_Location : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Location = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5606D1EC-CAAF-46AA-ABF2-BC33F67B6EB6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Value", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property Value
	///</summary>
	public class Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Value);

		}
	}


	[NVP_Manifest(
		Id = "BE6869A0-A00C-4772-9886-3156FDCBFCBF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Value", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Value
	///</summary>
	public class Set_Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Value = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E8FD22E8-90C9-4253-9D8F-DC3F9C169257", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.IsCustom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "IsCustom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property IsCustom", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property IsCustom
	///</summary>
	public class IsCustom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsCustom);

		}
	}


	[NVP_Manifest(
		Id = "6D52292D-3A4B-430D-9645-749DF37B81BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_IsCustom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_IsCustom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property IsCustom", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property IsCustom
	///</summary>
	public class Set_IsCustom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IsCustom = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D5A14F05-40BA-47F2-8B5A-B915A8CDFBD2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Scale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Scale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Scale", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property Scale
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
		Id = "C5405052-06D8-4FCF-83A2-05055B9F9FC8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_Scale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_Scale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Scale", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Scale
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
		Id = "B02666EA-9A65-445F-A353-DE8594273757", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Base", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Base", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Base", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property Base
	///</summary>
	public class Base : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Base);

		}
	}


	[NVP_Manifest(
		Id = "C43E7074-D3C3-442F-92B8-4293790ADA1A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_Base", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_Base", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Base", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Base
	///</summary>
	public class Set_Base : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Base = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "21F20C84-D3D0-4FB1-B10C-F73E267C1F0D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.CoordinateId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "CoordinateId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property CoordinateId", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property CoordinateId
	///</summary>
	public class CoordinateId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CoordinateId);

		}
	}


	[NVP_Manifest(
		Id = "FD84A53A-BC7E-4E4F-AD59-069F180ADEBD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_CoordinateId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_CoordinateId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property CoordinateId", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property CoordinateId
	///</summary>
	public class Set_CoordinateId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CoordinateId = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7B8D4869-58A3-4E6D-A0EB-63EA3CF3CE26", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Precision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Precision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Precision", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property Precision
	///</summary>
	public class Precision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Precision);

		}
	}


	[NVP_Manifest(
		Id = "247D79D1-11D1-4F58-B98F-D93078752E05", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_Precision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_Precision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Precision", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Precision
	///</summary>
	public class Set_Precision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Precision = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AF890832-F2C5-4A81-90BE-85EB66558CDA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.SignedPositive", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "SignedPositive", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SignedPositive", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property SignedPositive
	///</summary>
	public class SignedPositive : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SignedPositive);

		}
	}


	[NVP_Manifest(
		Id = "DAD6243E-BEC3-4C3C-90EC-717B006E145B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_SignedPositive", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_SignedPositive", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SignedPositive", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property SignedPositive
	///</summary>
	public class Set_SignedPositive : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SignedPositive = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7CE47169-C35C-4B39-AE1C-85A4535167B9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.TextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "TextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property TextStyle", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property TextStyle
	///</summary>
	public class TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyle);

		}
	}


	[NVP_Manifest(
		Id = "ED13C561-8D96-4E87-9E3E-F904790EB8E3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_TextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_TextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property TextStyle", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property TextStyle
	///</summary>
	public class Set_TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "25618C64-A531-4047-841F-8A94E6FE4F49", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property TextHeight", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property TextHeight
	///</summary>
	public class TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextHeight);

		}
	}


	[NVP_Manifest(
		Id = "9F8A13A3-CBD9-45F0-AE48-1544F3EF8A74", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property TextHeight", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property TextHeight
	///</summary>
	public class Set_TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CF6379FE-BFB4-4248-A50A-17F3EFD8FF1E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.ArrowHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "ArrowHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ArrowHeight", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property ArrowHeight
	///</summary>
	public class ArrowHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowHeight);

		}
	}


	[NVP_Manifest(
		Id = "B5805312-04C8-483A-8541-BF5962D1F4F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_ArrowHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_ArrowHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ArrowHeight", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ArrowHeight
	///</summary>
	public class Set_ArrowHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1477A98B-7D8E-4AD5-A9BA-ED3E3AC23FAA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.ShelfWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "ShelfWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ShelfWidth", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property ShelfWidth
	///</summary>
	public class ShelfWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShelfWidth);

		}
	}


	[NVP_Manifest(
		Id = "807E1433-B24C-4EF7-9F1C-0CD94F43936A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_ShelfWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_ShelfWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ShelfWidth", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ShelfWidth
	///</summary>
	public class Set_ShelfWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShelfWidth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "634B96AF-199E-4733-87AC-B31FC4F97205", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.ArrowSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "ArrowSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ArrowSize", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property ArrowSize
	///</summary>
	public class ArrowSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowSize);

		}
	}


	[NVP_Manifest(
		Id = "2B6A9A9B-8393-49BB-B49B-315BFA47F138", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_ArrowSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_ArrowSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ArrowSize", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ArrowSize
	///</summary>
	public class Set_ArrowSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "18A5A385-C110-4CFC-AB8B-3E9D7AD5EE33", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.ArrowLineWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "ArrowLineWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ArrowLineWidth", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property ArrowLineWidth
	///</summary>
	public class ArrowLineWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowLineWidth);

		}
	}


	[NVP_Manifest(
		Id = "281E0FA0-33E6-40AC-A45E-D69B5C7942E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_ArrowLineWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_ArrowLineWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ArrowLineWidth", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ArrowLineWidth
	///</summary>
	public class Set_ArrowLineWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowLineWidth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BE1ECCF5-A39B-48CB-851F-82D9CDDA9240", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.ShelfOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "ShelfOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ShelfOffset", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property ShelfOffset
	///</summary>
	public class ShelfOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShelfOffset);

		}
	}


	[NVP_Manifest(
		Id = "CD8C0C52-936D-4CE4-A97C-789BA4E966B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_ShelfOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_ShelfOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ShelfOffset", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ShelfOffset
	///</summary>
	public class Set_ShelfOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShelfOffset = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "768B77A5-F7AC-4D85-949C-B09E9F07165A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.OffsetX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "OffsetX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property OffsetX", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property OffsetX
	///</summary>
	public class OffsetX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetX);

		}
	}


	[NVP_Manifest(
		Id = "9B49352A-7062-4ACB-ADDE-54028E9FA26D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_OffsetX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_OffsetX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property OffsetX", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property OffsetX
	///</summary>
	public class Set_OffsetX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6480F257-EDD7-40CC-9367-5B77091AEBB6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.BottomStrValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "BottomStrValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bottom String", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property Bottom String
	///</summary>
	public class BottomStrValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BottomStrValue);

		}
	}


	[NVP_Manifest(
		Id = "D6305FFB-2283-4941-B86E-B94222B86FF0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_BottomStrValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_BottomStrValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bottom String", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Bottom String
	///</summary>
	public class Set_BottomStrValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BottomStrValue = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9750CAFB-1C49-46B0-A784-F88A6BB926E3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.TextGap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "TextGap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property textGap", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property textGap
	///</summary>
	public class TextGap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextGap);

		}
	}


	[NVP_Manifest(
		Id = "00C91A58-6281-4DF3-9250-B4334AB394A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_TextGap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_TextGap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property textGap", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property textGap
	///</summary>
	public class Set_TextGap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextGap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F48E99D2-483E-45EA-BD6E-BD09049930F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.FreeMarkLocation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "FreeMarkLocation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property freemarklocation", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property freemarklocation
	///</summary>
	public class FreeMarkLocation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FreeMarkLocation);

		}
	}


	[NVP_Manifest(
		Id = "10BA75F0-387D-422E-936C-F61A1B2A5646", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSLevelMark.Set_FreeMarkLocation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSLevelMark", 
		NodeName = "Set_FreeMarkLocation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property freemarklocation", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property freemarklocation
	///</summary>
	public class Set_FreeMarkLocation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FreeMarkLocation = inputs[1].Value;
			return null;
		}
	}
}
