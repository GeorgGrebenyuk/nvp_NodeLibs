using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSWorkSpace Interface
///</summary>
namespace mdsUnitsLib.MDSWorkSpace 
{

	[NVP_Manifest(
		Id = "5322DD6A-6C88-4AA0-B20B-91D258CC734A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.MDSWorkSpace_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "_MDSWorkSpace_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSWorkSpace_Constructor : INode 
	{
		public mdsUnitsLib.IMDSWorkSpace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IMDSWorkSpace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "7CDC9E20-B308-45B0-9CC2-2D9E6D73CA34", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.MDSWorkSpace_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "_MDSWorkSpace_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSWorkSpace_ConstructorCast : INode 
	{
		public mdsUnitsLib.IMDSWorkSpace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IMDSWorkSpace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "872680E9-9DC0-4F09-A340-998912DD00AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Name", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property Name
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
		Id = "8B9F5D3B-DE36-430C-8867-86F6A16BDC84", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Name", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Name
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
		Id = "01FA50C6-A63C-46C3-9015-19905B40442B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.WSPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "WSPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WSPosition", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WSPosition
	///</summary>
	public class WSPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WSPosition);

		}
	}


	[NVP_Manifest(
		Id = "FE949532-EA41-4A57-8F65-A67FEA2C7B3F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Set_WSPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Set_WSPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WSPosition", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property WSPosition
	///</summary>
	public class Set_WSPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WSPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "866D422F-405C-47D3-9D7A-CA51ADABF34A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.RotateAroundX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "RotateAroundX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property RotateAroundX", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property RotateAroundX
	///</summary>
	public class RotateAroundX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RotateAroundX);

		}
	}


	[NVP_Manifest(
		Id = "1A53D4D6-3A73-4CB4-A02C-5A00B6AE6D5D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Set_RotateAroundX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Set_RotateAroundX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property RotateAroundX", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property RotateAroundX
	///</summary>
	public class Set_RotateAroundX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RotateAroundX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "065BAC18-D02B-4CF7-B464-8888795DB673", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.RotateAroundY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "RotateAroundY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property RotateAroundY", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property RotateAroundY
	///</summary>
	public class RotateAroundY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RotateAroundY);

		}
	}


	[NVP_Manifest(
		Id = "9E7AD3F9-5DC5-44F9-A9D1-06854F4FCDA4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Set_RotateAroundY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Set_RotateAroundY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property RotateAroundY", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property RotateAroundY
	///</summary>
	public class Set_RotateAroundY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RotateAroundY = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2F6DEABD-C421-4732-94EB-4F18E0E29068", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.RotateAroundZ", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "RotateAroundZ", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property RotateAroundZ", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property RotateAroundZ
	///</summary>
	public class RotateAroundZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RotateAroundZ);

		}
	}


	[NVP_Manifest(
		Id = "7D89C372-4F39-4AD9-AF36-893F806C4A28", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Set_RotateAroundZ", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Set_RotateAroundZ", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property RotateAroundZ", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property RotateAroundZ
	///</summary>
	public class Set_RotateAroundZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RotateAroundZ = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6C754F42-F4B2-4EC0-B634-0D5F6A0650F5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.LimitationType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "LimitationType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property LimitationType", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property LimitationType
	///</summary>
	public class LimitationType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LimitationType);

		}
	}


	[NVP_Manifest(
		Id = "AD34CA4E-96DD-46A2-9659-BC169126F735", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Set_LimitationType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Set_LimitationType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property LimitationType", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property LimitationType
	///</summary>
	public class Set_LimitationType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LimitationType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "47701EE7-7AA4-485C-BAE1-93115A7D28BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.WSShowLimitationGraphics", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "WSShowLimitationGraphics", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WSShowLimitationGraphics", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WSShowLimitationGraphics
	///</summary>
	public class WSShowLimitationGraphics : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WSShowLimitationGraphics);

		}
	}


	[NVP_Manifest(
		Id = "855B68E5-3895-4319-B718-D1296F15C050", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Set_WSShowLimitationGraphics", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Set_WSShowLimitationGraphics", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WSShowLimitationGraphics", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property WSShowLimitationGraphics
	///</summary>
	public class Set_WSShowLimitationGraphics : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WSShowLimitationGraphics = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CE6ECC6C-D5EC-43F3-A58B-618C4C6AD971", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.WSShowGraphicsUCS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "WSShowGraphicsUCS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WSShowGraphicsUCS", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WSShowGraphicsUCS
	///</summary>
	public class WSShowGraphicsUCS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WSShowGraphicsUCS);

		}
	}


	[NVP_Manifest(
		Id = "7BAB4114-541E-4082-AF94-44E99F4F33E1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Set_WSShowGraphicsUCS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Set_WSShowGraphicsUCS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WSShowGraphicsUCS", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property WSShowGraphicsUCS
	///</summary>
	public class Set_WSShowGraphicsUCS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WSShowGraphicsUCS = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "761C0363-D178-41A9-8664-BD2F8A125779", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.WSBasePointLimitation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "WSBasePointLimitation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WSBasePointLimitation", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WSBasePointLimitation
	///</summary>
	public class WSBasePointLimitation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WSBasePointLimitation);

		}
	}


	[NVP_Manifest(
		Id = "2E058CB7-B61F-424B-BEF0-444005A73FA8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Set_WSBasePointLimitation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Set_WSBasePointLimitation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WSBasePointLimitation", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property WSBasePointLimitation
	///</summary>
	public class Set_WSBasePointLimitation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WSBasePointLimitation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "390B1F8B-8603-4B75-B89B-CDFA801E7875", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.WS_LXP", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "WS_LXP", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WS_LXP", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WS_LXP
	///</summary>
	public class WS_LXP : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WS_LXP);

		}
	}


	[NVP_Manifest(
		Id = "5C48D861-4F10-48AE-B93A-B0F529ECE2BB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Set_WS_LXP", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Set_WS_LXP", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WS_LXP", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property WS_LXP
	///</summary>
	public class Set_WS_LXP : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WS_LXP = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A8852BCC-8F65-445A-AF22-27C8D15E81E7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.WS_LXM", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "WS_LXM", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WS_LXM", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WS_LXM
	///</summary>
	public class WS_LXM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WS_LXM);

		}
	}


	[NVP_Manifest(
		Id = "6A6D65F6-DBA4-46F7-B38B-A34AD1C7B290", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Set_WS_LXM", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Set_WS_LXM", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WS_LXM", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property WS_LXM
	///</summary>
	public class Set_WS_LXM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WS_LXM = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9BF3465B-D18C-4D67-A3CF-84EDA87424E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.WS_LYP", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "WS_LYP", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WS_LYP", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WS_LYP
	///</summary>
	public class WS_LYP : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WS_LYP);

		}
	}


	[NVP_Manifest(
		Id = "FC50B557-5F9C-481A-8439-EDD0A8F70909", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Set_WS_LYP", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Set_WS_LYP", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WS_LYP", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property WS_LYP
	///</summary>
	public class Set_WS_LYP : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WS_LYP = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AC6B147A-6DA1-40F9-8D74-6B749F694A79", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.WS_LYM", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "WS_LYM", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WS_LYM", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WS_LYM
	///</summary>
	public class WS_LYM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WS_LYM);

		}
	}


	[NVP_Manifest(
		Id = "C9DE74E8-6A4E-4FF0-AC8A-9F4253E1C8EA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Set_WS_LYM", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Set_WS_LYM", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WS_LYM", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property WS_LYM
	///</summary>
	public class Set_WS_LYM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WS_LYM = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "37D420CD-DB97-4ACD-826B-0F1355D5D7FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.WS_LZP", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "WS_LZP", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WS_LZP", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WS_LZP
	///</summary>
	public class WS_LZP : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WS_LZP);

		}
	}


	[NVP_Manifest(
		Id = "A4E4C231-CD17-4FB1-964C-00A0175F0EE9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Set_WS_LZP", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Set_WS_LZP", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WS_LZP", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property WS_LZP
	///</summary>
	public class Set_WS_LZP : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WS_LZP = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E74A8BC5-3E57-4869-998B-C7C28E6E5A7D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.WS_LZM", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "WS_LZM", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WS_LZM", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WS_LZM
	///</summary>
	public class WS_LZM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WS_LZM);

		}
	}


	[NVP_Manifest(
		Id = "2A897D3D-F9A8-4D89-ADF8-370B0A291481", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Set_WS_LZM", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Set_WS_LZM", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WS_LZM", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property WS_LZM
	///</summary>
	public class Set_WS_LZM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WS_LZM = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CD0125B8-A442-4259-9B40-A36D677AD7B9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.WS_LR", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "WS_LR", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WS_LR", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WS_LR
	///</summary>
	public class WS_LR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WS_LR);

		}
	}


	[NVP_Manifest(
		Id = "80D99E88-96C3-406D-9816-ED0E2FB9CFE6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Set_WS_LR", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Set_WS_LR", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WS_LR", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property WS_LR
	///</summary>
	public class Set_WS_LR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WS_LR = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "54C2BFFB-8D58-40A0-BD9D-11AF8363FFCF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

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
		Id = "79CCD194-0B80-4603-A604-9367FC4AC01D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSWorkSpace.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSWorkSpace", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
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
}
