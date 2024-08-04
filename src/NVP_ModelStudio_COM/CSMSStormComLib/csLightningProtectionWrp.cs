using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IcsLightningProtectionWrp Interface
///</summary>
namespace CSMSStormComLib.csLightningProtectionWrp 
{

	[NVP_Manifest(
		Id = "1AF09759-2646-41E2-B4C7-298D35292A9C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.csLightningProtectionWrp_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "_csLightningProtectionWrp_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class csLightningProtectionWrp_Constructor : INode 
	{
		public CSMSStormComLib.IcsLightningProtectionWrp _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as CSMSStormComLib.IcsLightningProtectionWrp;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "31D57CD2-3268-4A6C-8C27-EEB1B1D58E29", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.csLightningProtectionWrp_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "_csLightningProtectionWrp_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class csLightningProtectionWrp_ConstructorCast : INode 
	{
		public CSMSStormComLib.IcsLightningProtectionWrp _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as CSMSStormComLib.IcsLightningProtectionWrp;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "1F262B7E-8943-464F-9928-378A00E878F4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.ZoneType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "ZoneType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ZoneType", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property ZoneType
	///</summary>
	public class ZoneType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ZoneType);

		}
	}


	[NVP_Manifest(
		Id = "69F262BD-E8F3-41AA-8C42-AE2EFF3974EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

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
		Id = "9256D070-8F81-4093-9664-99495F1530C0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
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
		Id = "7BEADF97-A325-4D70-B1C5-F532B7EA5FF5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.Reliability", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "Reliability", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Reliability", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property Reliability
	///</summary>
	public class Reliability : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Reliability);

		}
	}


	[NVP_Manifest(
		Id = "85E349C0-83F3-4CE7-A521-8F79BFAA129F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.SingleRodName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "SingleRodName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SingleRodName", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleRodName
	///</summary>
	public class SingleRodName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleRodName);

		}
	}


	[NVP_Manifest(
		Id = "BB7FA9A7-9891-44FC-952B-765C3FAE7C9C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.Set_SingleRodName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "Set_SingleRodName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SingleRodName", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property SingleRodName
	///</summary>
	public class Set_SingleRodName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SingleRodName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "27E52426-53D8-436A-9914-7F3F4B6D9E4C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.SingleRodHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "SingleRodHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SingleRodHeight", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleRodHeight
	///</summary>
	public class SingleRodHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleRodHeight);

		}
	}


	[NVP_Manifest(
		Id = "8CDF784B-AF03-4F93-900E-6608415AB326", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.SingleRodHeight0", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "SingleRodHeight0", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SingleRodHeight0", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleRodHeight0
	///</summary>
	public class SingleRodHeight0 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleRodHeight0);

		}
	}


	[NVP_Manifest(
		Id = "A421FDC3-27D7-4A96-9F22-35B9E746F86C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.SingleRodRadius0", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "SingleRodRadius0", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SingleRodRadius0", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleRodRadius0
	///</summary>
	public class SingleRodRadius0 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleRodRadius0);

		}
	}


	[NVP_Manifest(
		Id = "AC4F36D1-8A38-4CAF-925C-329AF60E5909", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.SingleRodRadiusX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "SingleRodRadiusX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SingleRodRadiusX", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleRodRadiusX
	///</summary>
	public class SingleRodRadiusX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleRodRadiusX);

		}
	}


	[NVP_Manifest(
		Id = "99A545F5-7661-4FE0-A263-72B3AEF4839D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleRodName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleRodName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleRodName", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodName
	///</summary>
	public class DoubleRodName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodName);

		}
	}


	[NVP_Manifest(
		Id = "13C3B80E-311A-41B8-B16B-81B685441B9B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.Set_DoubleRodName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "Set_DoubleRodName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleRodName", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property DoubleRodName
	///</summary>
	public class Set_DoubleRodName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DoubleRodName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "09F4A4D8-A93D-402B-81E6-C30920F59C07", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleRodL", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleRodL", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleRodL", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodL
	///</summary>
	public class DoubleRodL : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodL);

		}
	}


	[NVP_Manifest(
		Id = "814B5C7C-4968-42C8-A87E-B3A751A0EBF2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleRodLMax1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleRodLMax1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleRodLMax1", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodLMax1
	///</summary>
	public class DoubleRodLMax1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodLMax1);

		}
	}


	[NVP_Manifest(
		Id = "F51579E2-63B8-430A-8714-9566C111438A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleRodLMax2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleRodLMax2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleRodLMax2", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodLMax2
	///</summary>
	public class DoubleRodLMax2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodLMax2);

		}
	}


	[NVP_Manifest(
		Id = "535C6EE2-6635-47CE-A5B3-BEAF50F6052F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleRodLC1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleRodLC1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleRodLC1", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodLC1
	///</summary>
	public class DoubleRodLC1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodLC1);

		}
	}


	[NVP_Manifest(
		Id = "A7265AAF-4C80-4C03-A5A4-BD03E673DC9E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleRodLC2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleRodLC2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleRodLC2", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodLC2
	///</summary>
	public class DoubleRodLC2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodLC2);

		}
	}


	[NVP_Manifest(
		Id = "8A9A4129-F4A8-43DB-8B13-29FD741DC45C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleRodHeightC", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleRodHeightC", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleRodHeightC", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodHeightC
	///</summary>
	public class DoubleRodHeightC : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodHeightC);

		}
	}


	[NVP_Manifest(
		Id = "63E5CAF0-314D-4346-973A-5CE70BD29FC2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleRodHeightC1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleRodHeightC1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleRodHeightC1", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodHeightC1
	///</summary>
	public class DoubleRodHeightC1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodHeightC1);

		}
	}


	[NVP_Manifest(
		Id = "9A3D990A-0E80-431C-809D-2042F0358EB5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleRodHeightC2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleRodHeightC2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleRodHeightC2", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodHeightC2
	///</summary>
	public class DoubleRodHeightC2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodHeightC2);

		}
	}


	[NVP_Manifest(
		Id = "6CA06AA0-456B-496B-86A8-A641AD32AF17", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleRodRadiusC", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleRodRadiusC", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleRodRadiusC", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodRadiusC
	///</summary>
	public class DoubleRodRadiusC : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodRadiusC);

		}
	}


	[NVP_Manifest(
		Id = "9B9F60F5-F090-4539-ABE6-BC726EB76698", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleRodRadiusCX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleRodRadiusCX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleRodRadiusCX", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodRadiusCX
	///</summary>
	public class DoubleRodRadiusCX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodRadiusCX);

		}
	}


	[NVP_Manifest(
		Id = "9E15CB21-5F1E-426F-9692-75BB5A1C28E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleRodLX1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleRodLX1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleRodLX1", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodLX1
	///</summary>
	public class DoubleRodLX1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodLX1);

		}
	}


	[NVP_Manifest(
		Id = "36720EF7-749A-4338-81AB-55075D0BA9FE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleRodLX2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleRodLX2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleRodLX2", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodLX2
	///</summary>
	public class DoubleRodLX2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodLX2);

		}
	}


	[NVP_Manifest(
		Id = "DEAF65FB-3C4C-46E7-B618-430F7A40DBA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.SingleTrosName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "SingleTrosName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SingleTrosName", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleTrosName
	///</summary>
	public class SingleTrosName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleTrosName);

		}
	}


	[NVP_Manifest(
		Id = "4A45823E-7CEC-49E3-AD9D-0970FE575750", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.Set_SingleTrosName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "Set_SingleTrosName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SingleTrosName", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property SingleTrosName
	///</summary>
	public class Set_SingleTrosName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SingleTrosName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C268A2A0-B24E-46BD-8EC6-9004FCE8009A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.SingleTrosL", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "SingleTrosL", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SingleTrosL", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleTrosL
	///</summary>
	public class SingleTrosL : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleTrosL);

		}
	}


	[NVP_Manifest(
		Id = "623D13BF-A0EC-4653-94C1-A1E0F1BD24A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.SingleTrosMinHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "SingleTrosMinHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SingleTrosMinHeight", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleTrosMinHeight
	///</summary>
	public class SingleTrosMinHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleTrosMinHeight);

		}
	}


	[NVP_Manifest(
		Id = "1284EB24-C99E-4E98-8F13-C397713C5741", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.SingleTrosHeight0", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "SingleTrosHeight0", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SingleTrosHeight0", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleTrosHeight0
	///</summary>
	public class SingleTrosHeight0 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleTrosHeight0);

		}
	}


	[NVP_Manifest(
		Id = "221BC201-9E9E-4A8F-BE82-01871B05AC47", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.SingleTrosRadius0", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "SingleTrosRadius0", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SingleTrosRadius0", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleTrosRadius0
	///</summary>
	public class SingleTrosRadius0 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleTrosRadius0);

		}
	}


	[NVP_Manifest(
		Id = "00F3548A-F2DD-4432-884C-67898E0365A3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.SingleTrosRadiusX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "SingleTrosRadiusX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SingleTrosRadiusX", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleTrosRadiusX
	///</summary>
	public class SingleTrosRadiusX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleTrosRadiusX);

		}
	}


	[NVP_Manifest(
		Id = "0980B5FF-8E6C-494F-801A-7F34F6356D64", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosName", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosName
	///</summary>
	public class DoubleTrosName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosName);

		}
	}


	[NVP_Manifest(
		Id = "FA530EF3-9A69-4889-9141-577D76EEE1E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.Set_DoubleTrosName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "Set_DoubleTrosName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosName", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property DoubleTrosName
	///</summary>
	public class Set_DoubleTrosName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DoubleTrosName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3D0FF077-E01E-47F7-B8BC-19F0407112FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosL", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosL", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosL", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosL
	///</summary>
	public class DoubleTrosL : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosL);

		}
	}


	[NVP_Manifest(
		Id = "DBA978CB-6C0F-4C24-8643-A1C156AE2208", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosLmax", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosLmax", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosLmax", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosLmax
	///</summary>
	public class DoubleTrosLmax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosLmax);

		}
	}


	[NVP_Manifest(
		Id = "D5BB5BA2-D87D-44DC-8D29-00D0276A1446", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosLmax1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosLmax1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosLmax1", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosLmax1
	///</summary>
	public class DoubleTrosLmax1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosLmax1);

		}
	}


	[NVP_Manifest(
		Id = "23321188-94BB-4A64-AF07-1C2233D5CC43", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosLc", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosLc", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosLc", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosLc
	///</summary>
	public class DoubleTrosLc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosLc);

		}
	}


	[NVP_Manifest(
		Id = "C1367D96-772C-45E5-91DC-02E74110EB19", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosMinHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosMinHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosMinHeight", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosMinHeight
	///</summary>
	public class DoubleTrosMinHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosMinHeight);

		}
	}


	[NVP_Manifest(
		Id = "8F4E6ACC-F767-4287-A393-952DB6CBEA54", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosMinHeight1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosMinHeight1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosMinHeight1", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosMinHeight1
	///</summary>
	public class DoubleTrosMinHeight1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosMinHeight1);

		}
	}


	[NVP_Manifest(
		Id = "61BFCB24-ECDA-4C3A-B8E7-0AFF8B29EC3F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosHeight0", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosHeight0", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosHeight0", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosHeight0
	///</summary>
	public class DoubleTrosHeight0 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosHeight0);

		}
	}


	[NVP_Manifest(
		Id = "FE915E45-2B11-4AF1-B9E5-96611E9A10BC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosHeight01", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosHeight01", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosHeight01", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosHeight01
	///</summary>
	public class DoubleTrosHeight01 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosHeight01);

		}
	}


	[NVP_Manifest(
		Id = "FE1AA9FB-B209-4A1D-9C59-F6D4ABE3E1D0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosRadius0", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosRadius0", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosRadius0", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosRadius0
	///</summary>
	public class DoubleTrosRadius0 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosRadius0);

		}
	}


	[NVP_Manifest(
		Id = "615D4C62-4B90-4D71-8182-C72082AACFAB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosRadius01", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosRadius01", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosRadius01", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosRadius01
	///</summary>
	public class DoubleTrosRadius01 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosRadius01);

		}
	}


	[NVP_Manifest(
		Id = "2F40278D-5444-4FBC-8F55-C0FF5411C009", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosRadiusX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosRadiusX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosRadiusX", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosRadiusX
	///</summary>
	public class DoubleTrosRadiusX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosRadiusX);

		}
	}


	[NVP_Manifest(
		Id = "784F8E9A-B27F-4FD2-8FF6-5DCD6EFDB0B7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosRadiusX1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosRadiusX1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosRadiusX1", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosRadiusX1
	///</summary>
	public class DoubleTrosRadiusX1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosRadiusX1);

		}
	}


	[NVP_Manifest(
		Id = "7789607E-61B3-4605-BB37-75E9A50E7649", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosLx", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosLx", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosLx", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosLx
	///</summary>
	public class DoubleTrosLx : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosLx);

		}
	}


	[NVP_Manifest(
		Id = "CEEA7AD2-CB31-4AA4-B502-38BAD0AD9318", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosLx1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosLx1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosLx1", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosLx1
	///</summary>
	public class DoubleTrosLx1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosLx1);

		}
	}


	[NVP_Manifest(
		Id = "E9EFDE7C-4086-4C51-90CC-62AD6822BE76", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosLmax2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosLmax2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosLmax2", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosLmax2
	///</summary>
	public class DoubleTrosLmax2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosLmax2);

		}
	}


	[NVP_Manifest(
		Id = "3BAADEA4-0B2C-4F94-A149-91229405371A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosMinHeight2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosMinHeight2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosMinHeight2", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosMinHeight2
	///</summary>
	public class DoubleTrosMinHeight2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosMinHeight2);

		}
	}


	[NVP_Manifest(
		Id = "757D80DB-007B-462E-985E-AF929438B030", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosHeight02", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosHeight02", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosHeight02", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosHeight02
	///</summary>
	public class DoubleTrosHeight02 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosHeight02);

		}
	}


	[NVP_Manifest(
		Id = "24C9A0F1-DD4C-4039-807B-D3324B7BF773", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosRadius02", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosRadius02", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosRadius02", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosRadius02
	///</summary>
	public class DoubleTrosRadius02 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosRadius02);

		}
	}


	[NVP_Manifest(
		Id = "77384869-7927-4EE4-AC86-13A40C9BD598", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosRadiusX2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosRadiusX2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosRadiusX2", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosRadiusX2
	///</summary>
	public class DoubleTrosRadiusX2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosRadiusX2);

		}
	}


	[NVP_Manifest(
		Id = "7BD516FB-3F8B-48CC-8D9F-7B6CDED61770", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosLx2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosLx2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosLx2", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosLx2
	///</summary>
	public class DoubleTrosLx2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosLx2);

		}
	}


	[NVP_Manifest(
		Id = "5AC20EA5-0D6C-4FDA-A421-22EE8B371721", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosHeightC", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosHeightC", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosHeightC", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosHeightC
	///</summary>
	public class DoubleTrosHeightC : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosHeightC);

		}
	}


	[NVP_Manifest(
		Id = "DD56C160-7003-4B9F-BFCE-7450BCA83141", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosRadiusC", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosRadiusC", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosRadiusC", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosRadiusC
	///</summary>
	public class DoubleTrosRadiusC : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosRadiusC);

		}
	}


	[NVP_Manifest(
		Id = "2F7E95B3-BDC8-41B6-93D8-F60A96B37D57", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.DoubleTrosRadiusCX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "DoubleTrosRadiusCX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DoubleTrosRadiusCX", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosRadiusCX
	///</summary>
	public class DoubleTrosRadiusCX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosRadiusCX);

		}
	}


	[NVP_Manifest(
		Id = "2C5EA80C-9053-41E2-ABD7-9C86DED90D37", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.ClosedTrosName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "ClosedTrosName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ClosedTrosName", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property ClosedTrosName
	///</summary>
	public class ClosedTrosName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClosedTrosName);

		}
	}


	[NVP_Manifest(
		Id = "E9C60697-B58D-4E05-BEBF-BAB9ED19F5DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.Set_ClosedTrosName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "Set_ClosedTrosName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ClosedTrosName", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property ClosedTrosName
	///</summary>
	public class Set_ClosedTrosName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClosedTrosName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6DA7F3BE-D559-4ACF-9C1F-F183F7C96569", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.ClosedTrosMinHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "ClosedTrosMinHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ClosedTrosMinHeight", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property ClosedTrosMinHeight
	///</summary>
	public class ClosedTrosMinHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClosedTrosMinHeight);

		}
	}


	[NVP_Manifest(
		Id = "C00D1C84-49F2-466B-B0E7-8467C9A425B6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.ClosedTrosHeight0", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "ClosedTrosHeight0", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ClosedTrosHeight0", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property ClosedTrosHeight0
	///</summary>
	public class ClosedTrosHeight0 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClosedTrosHeight0);

		}
	}


	[NVP_Manifest(
		Id = "082302DF-F49C-4EA8-A895-C0C33F343A27", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.ClosedTrosD", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "ClosedTrosD", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ClosedTrosD", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property ClosedTrosD
	///</summary>
	public class ClosedTrosD : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClosedTrosD);

		}
	}


	[NVP_Manifest(
		Id = "F95CD5C7-ACBC-4C79-88C6-872FB027E1D6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.Set_ClosedTrosD", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "Set_ClosedTrosD", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ClosedTrosD", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ClosedTrosD
	///</summary>
	public class Set_ClosedTrosD : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClosedTrosD = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7BB5E7C6-8AF1-4A3F-9A58-098DD4F3FBB9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.ClosedTrosS0", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "ClosedTrosS0", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ClosedTrosS0", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property ClosedTrosS0
	///</summary>
	public class ClosedTrosS0 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClosedTrosS0);

		}
	}


	[NVP_Manifest(
		Id = "9E1424D5-D30E-45D6-906B-976E22A8BB2F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.ClosedTrosA", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "ClosedTrosA", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ClosedTrosA", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property ClosedTrosA
	///</summary>
	public class ClosedTrosA : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClosedTrosA);

		}
	}


	[NVP_Manifest(
		Id = "316E9242-E391-48D8-8D81-8413ABF888E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.ClosedTrosB", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "ClosedTrosB", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ClosedTrosB", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property ClosedTrosB
	///</summary>
	public class ClosedTrosB : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClosedTrosB);

		}
	}


	[NVP_Manifest(
		Id = "C9010404-5901-4F41-A2F0-E11CA3EFECDB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.MultyRodName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "MultyRodName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property MultyRodName", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property MultyRodName
	///</summary>
	public class MultyRodName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MultyRodName);

		}
	}


	[NVP_Manifest(
		Id = "F8537358-AA52-4A87-88F5-28D4AAB5F9CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.Set_MultyRodName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "Set_MultyRodName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property MultyRodName", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property MultyRodName
	///</summary>
	public class Set_MultyRodName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MultyRodName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A7E71C6C-E2D6-494B-98CF-1DBBA04D16E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.HeigthX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "HeigthX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property HeigthX", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property HeigthX
	///</summary>
	public class HeigthX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HeigthX);

		}
	}


	[NVP_Manifest(
		Id = "F4E0CCE7-33A4-45A9-BCEC-D9466681E171", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.Set_HeigthX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "Set_HeigthX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property HeigthX", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property HeigthX
	///</summary>
	public class Set_HeigthX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HeigthX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5FE7CB1F-E7FD-467D-BA8A-CC3789F01C08", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.SectionEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "SectionEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SectionEnabled", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SectionEnabled
	///</summary>
	public class SectionEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SectionEnabled);

		}
	}


	[NVP_Manifest(
		Id = "83C9CE89-1F76-4A40-AE33-EA86426850DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.Set_SectionEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "Set_SectionEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SectionEnabled", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property SectionEnabled
	///</summary>
	public class Set_SectionEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SectionEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "370FAED1-9A3B-4DBA-A8FB-4E55DB03AE50", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "CSMSStormComLib.csLightningProtectionWrp.ConductorParameterCalc", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.CSMSStormComLib.csLightningProtectionWrp", 
		NodeName = "ConductorParameterCalc", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method ConductorParameterCalc", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("nameParam", typeof(System.String))]
	[NodeInput("nConductor", typeof(System.Object))]
	[NodeInput("nMethod", typeof(System.Object))]
	[NodeInput("fReliability", typeof(System.Double))]

	///<summary>
	///method ConductorParameterCalc
	///</summary>
	public class ConductorParameterCalc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConductorParameterCalc(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}
}
