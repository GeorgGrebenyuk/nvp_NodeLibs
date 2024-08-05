using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSLProfile Interface
///</summary>
namespace mdsLINEComLib.MDSLProfile 
{

	[NVP_Manifest(
		Id = "0B94A5D7-4F2A-4E96-B6D4-A35FD80C1035", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.MDSLProfile_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "_MDSLProfile_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLProfile_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLProfile _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLProfile;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "634DD782-B9AB-4CF2-AB78-BDAB262F91B5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.MDSLProfile_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "_MDSLProfile_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLProfile_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLProfile _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLProfile;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "AEA5733F-5482-40C9-8C98-0EC3BEBBA512", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.HorizontalScaleListBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "HorizontalScaleListBox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property HorizontalScaleListBox", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property HorizontalScaleListBox
	///</summary>
	public class HorizontalScaleListBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HorizontalScaleListBox);

		}
	}


	[NVP_Manifest(
		Id = "7242A044-ADCC-4EC4-9BA6-6B6C14320EF6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.Set_HorizontalScaleListBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "Set_HorizontalScaleListBox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property HorizontalScaleListBox", 
		ViewType = "Modifier")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("pVal", typeof(System.Int32))]

	///<summary>
	///property HorizontalScaleListBox
	///</summary>
	public class Set_HorizontalScaleListBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HorizontalScaleListBox = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8550999C-A137-4A52-B23B-C757125BE383", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.HorizontalScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "HorizontalScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property HorizontalScale", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property HorizontalScale
	///</summary>
	public class HorizontalScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HorizontalScale);

		}
	}


	[NVP_Manifest(
		Id = "321C789F-0963-4D7B-846E-694EDDB0B6FF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.Set_HorizontalScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "Set_HorizontalScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property HorizontalScale", 
		ViewType = "Modifier")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property HorizontalScale
	///</summary>
	public class Set_HorizontalScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HorizontalScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "80A009FA-2FEE-4A2E-96E2-F16AC9D4E84A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.VerticalScaleListBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "VerticalScaleListBox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property VerticalScaleListBox", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property VerticalScaleListBox
	///</summary>
	public class VerticalScaleListBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalScaleListBox);

		}
	}


	[NVP_Manifest(
		Id = "B887FE52-25E4-4D07-A8FC-3E5ADD9D12FC", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.Set_VerticalScaleListBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "Set_VerticalScaleListBox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property VerticalScaleListBox", 
		ViewType = "Modifier")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("pVal", typeof(System.Int32))]

	///<summary>
	///property VerticalScaleListBox
	///</summary>
	public class Set_VerticalScaleListBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VerticalScaleListBox = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D67B08E2-156C-459C-B6D3-AAF181383448", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.VerticalScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "VerticalScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property VerticalScale", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property VerticalScale
	///</summary>
	public class VerticalScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalScale);

		}
	}


	[NVP_Manifest(
		Id = "46BEA390-3975-4C09-BDFB-189356D6CBDC", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.Set_VerticalScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "Set_VerticalScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property VerticalScale", 
		ViewType = "Modifier")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property VerticalScale
	///</summary>
	public class Set_VerticalScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VerticalScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "97799EFF-AD8B-4E8A-969B-2F6CF5819164", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.BasePoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "BasePoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property BasePoint", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property BasePoint
	///</summary>
	public class BasePoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BasePoint);

		}
	}


	[NVP_Manifest(
		Id = "5434BCB8-781A-4815-B0EE-A360DE2C0B2B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.Set_BasePoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "Set_BasePoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property BasePoint", 
		ViewType = "Modifier")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property BasePoint
	///</summary>
	public class Set_BasePoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BasePoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F3E0E47F-18E3-4A1E-AD5D-19BE3E44206D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

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
		Id = "5389E7EB-2F34-42F3-8DC4-87119B4158C9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("MDSLProfile", typeof(object))]
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
		Id = "AC2D558A-1D9B-43E4-923F-3AFA34F01DE1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.MinLevel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "MinLevel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property MinLevel", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property MinLevel
	///</summary>
	public class MinLevel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinLevel);

		}
	}


	[NVP_Manifest(
		Id = "F53D224A-C63C-4B96-AB90-8D4BC3E6D1E5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.Set_MinLevel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "Set_MinLevel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property MinLevel", 
		ViewType = "Modifier")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property MinLevel
	///</summary>
	public class Set_MinLevel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MinLevel = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "16E7F24C-2859-45BA-8714-96C7DCEA5780", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.Supports", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "Supports", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Supports", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property Supports
	///</summary>
	public class Supports : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Supports);

		}
	}


	[NVP_Manifest(
		Id = "51E77297-FFFD-4D63-B22A-B8D7E5E10D4E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.GroundLines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "GroundLines", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property GroundLines", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property GroundLines
	///</summary>
	public class GroundLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GroundLines);

		}
	}


	[NVP_Manifest(
		Id = "2FAB2042-CFB6-45AA-8C6E-C9593EAB4B48", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.MinDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "MinDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property MinDistance", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property MinDistance
	///</summary>
	public class MinDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinDistance);

		}
	}


	[NVP_Manifest(
		Id = "45A696A4-B547-424E-8464-A4A8C47FDFDA", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.Set_MinDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "Set_MinDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property MinDistance", 
		ViewType = "Modifier")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property MinDistance
	///</summary>
	public class Set_MinDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MinDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1255A670-A1CA-475F-A1AB-213C21BDC34D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.GetScreenDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "GetScreenDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetScreenDistance", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("RealDistance", typeof(System.Double))]

	///<summary>
	///method GetScreenDistance
	///</summary>
	public class GetScreenDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetScreenDistance(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "5DC0FA02-D47B-4E74-B83D-70BDD1C6EB28", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.GetScreenHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "GetScreenHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetScreenDistance", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("RealHeight", typeof(System.Double))]

	///<summary>
	///method GetScreenDistance
	///</summary>
	public class GetScreenHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetScreenHeight(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "A8C94448-838F-487D-9652-8F3F4AC9D462", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.GetRealDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "GetRealDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetScreenDistance", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("ScreenDistance", typeof(System.Double))]

	///<summary>
	///method GetScreenDistance
	///</summary>
	public class GetRealDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRealDistance(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "FCEBE87F-23A4-4362-B7E2-35963F74E721", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.GetRealHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "GetRealHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetScreenDistance", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("ScreenHeight", typeof(System.Double))]

	///<summary>
	///method GetScreenDistance
	///</summary>
	public class GetRealHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRealHeight(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "40ABD191-2A9A-4EBC-A47B-082F9AA99DB2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.GetStation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "GetStation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetStation", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]
	[NodeInput("short", typeof(System.Object))]

	///<summary>
	///method GetStation
	///</summary>
	public class GetStation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetStation(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "A295F134-F8E0-41BE-9E06-44183C6F4653", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.LineName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "LineName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property LineName", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property LineName
	///</summary>
	public class LineName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineName);

		}
	}


	[NVP_Manifest(
		Id = "43B811A7-BA69-47B3-BDFE-92BC21827A90", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.Set_LineName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "Set_LineName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property LineName", 
		ViewType = "Modifier")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property LineName
	///</summary>
	public class Set_LineName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0A5889CB-6F34-484C-9075-122107D8B6E8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLProfile.climateData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLProfile", 
		NodeName = "climateData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method climateData", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///method climateData
	///</summary>
	public class climateData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.climateData);

		}
	}
}
