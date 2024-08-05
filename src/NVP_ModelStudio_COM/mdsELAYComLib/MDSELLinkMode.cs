using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSELLinkMode Interface
///</summary>
namespace mdsELAYComLib.MDSELLinkMode 
{

	[NVP_Manifest(
		Id = "54AC2DED-D905-4F8E-8C82-3BE2B941A586", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.MDSELLinkMode_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "_MDSELLinkMode_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSELLinkMode_Constructor : INode 
	{
		public mdsELAYComLib.IMDSELLinkMode _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsELAYComLib.IMDSELLinkMode;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "AF970556-BF39-4B93-BB11-96FD2C45789F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.MDSELLinkMode_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "_MDSELLinkMode_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSELLinkMode_ConstructorCast : INode 
	{
		public mdsELAYComLib.IMDSELLinkMode _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsELAYComLib.IMDSELLinkMode;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "57BC8839-F0D4-450F-9DCC-F44FBB86C88E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.WireLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "WireLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WireLength", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///property WireLength
	///</summary>
	public class WireLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WireLength);

		}
	}


	[NVP_Manifest(
		Id = "D490FC6F-5E17-493C-B1C0-C6AA982619FB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.Sigma", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "Sigma", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Sigma", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///property Sigma
	///</summary>
	public class Sigma : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Sigma);

		}
	}


	[NVP_Manifest(
		Id = "7C718874-BA23-4E9A-93CC-5D78B4601E86", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.Gamma", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "Gamma", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Gamma", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///property Gamma
	///</summary>
	public class Gamma : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Gamma);

		}
	}


	[NVP_Manifest(
		Id = "3D810700-AA57-4FD7-A02C-E19DF3F36BCD", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.InitialModeIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "InitialModeIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property InitialModeIndex", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///property InitialModeIndex
	///</summary>
	public class InitialModeIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialModeIndex);

		}
	}


	[NVP_Manifest(
		Id = "40D048E2-F273-481E-BEE4-AD918050E977", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.SpanLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "SpanLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SpanLength", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///property SpanLength
	///</summary>
	public class SpanLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SpanLength);

		}
	}


	[NVP_Manifest(
		Id = "4D2713C0-5D07-41AC-8BF8-213724DA7ED2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.InitialSigma", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "InitialSigma", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property InitialSigma", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///property InitialSigma
	///</summary>
	public class InitialSigma : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialSigma);

		}
	}


	[NVP_Manifest(
		Id = "FD9E7650-4817-4608-88E7-D05155BA6BFF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.InitialGamma", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "InitialGamma", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property InitialGamma", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///property InitialGamma
	///</summary>
	public class InitialGamma : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialGamma);

		}
	}


	[NVP_Manifest(
		Id = "D260566A-1B27-4E11-AB19-B7E58A536905", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.InitialT", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "InitialT", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property InitialT", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///property InitialT
	///</summary>
	public class InitialT : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialT);

		}
	}


	[NVP_Manifest(
		Id = "8AB54C04-91F5-488E-89E3-8CB390ED4872", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.GetGammaStd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "GetGammaStd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetGammaStd", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///method GetGammaStd
	///</summary>
	public class GetGammaStd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGammaStd);

		}
	}


	[NVP_Manifest(
		Id = "62DDF39B-2ABC-493B-B6E5-A2675CC7460F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.MinX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "MinX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property MinX", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///property MinX
	///</summary>
	public class MinX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinX);

		}
	}


	[NVP_Manifest(
		Id = "6252E869-B9FE-4F61-BB88-DA5392E15739", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.MinZ", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "MinZ", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property MinZ", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///property MinZ
	///</summary>
	public class MinZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinZ);

		}
	}


	[NVP_Manifest(
		Id = "017E1CAE-76BA-4A8E-9295-83F5107DB06E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.SlackMin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "SlackMin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SlackMin", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///property SlackMin
	///</summary>
	public class SlackMin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SlackMin);

		}
	}


	[NVP_Manifest(
		Id = "1AAF2658-FA51-4B7F-A852-F4400A085CEF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.SlackMax", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "SlackMax", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SlackMax", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///property SlackMax
	///</summary>
	public class SlackMax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SlackMax);

		}
	}


	[NVP_Manifest(
		Id = "2D443E86-9205-41F5-9B40-ABBA8F82FFFF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.GetSlackMaxAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "GetSlackMaxAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetSlackMaxAt", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///method GetSlackMaxAt
	///</summary>
	public class GetSlackMaxAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetSlackMaxAt(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "771819AA-3E9E-453F-B194-93124C771D7E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Length", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///property Length
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
		Id = "F628EA81-0237-479C-B5A9-64EC729620B0", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.GetWireLengthAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "GetWireLengthAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetLengthAt", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///method GetLengthAt
	///</summary>
	public class GetWireLengthAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetWireLengthAt);

		}
	}


	[NVP_Manifest(
		Id = "8B947BCC-3FD4-4C1B-A940-2AC0CD7D6EDB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.WindAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "WindAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WindAngle", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///property WindAngle
	///</summary>
	public class WindAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindAngle);

		}
	}


	[NVP_Manifest(
		Id = "36A6853F-7BD4-4B7B-BF8F-C65DF5E9BE33", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.GetGammaNorm", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "GetGammaNorm", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetGammaNorm", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///method GetGammaNorm
	///</summary>
	public class GetGammaNorm : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGammaNorm);

		}
	}


	[NVP_Manifest(
		Id = "9B446FBA-5266-4A9A-B36B-4F630AB574A3", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.GetSlackMinAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "GetSlackMinAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetSlackMinAt", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///method GetSlackMinAt
	///</summary>
	public class GetSlackMinAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetSlackMinAt(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "009B0FA9-83E2-425E-AD9F-6CFC6BDF009A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.SlackMiddle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "SlackMiddle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SlackMiddle", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///property SlackMiddle
	///</summary>
	public class SlackMiddle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SlackMiddle);

		}
	}


	[NVP_Manifest(
		Id = "ACFE371C-0BFD-4277-833F-C156A362B2E6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.Deviation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "Deviation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Deviation", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///property Deviation
	///</summary>
	public class Deviation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Deviation);

		}
	}


	[NVP_Manifest(
		Id = "CC51BC65-38CD-40C3-BCB0-A81CCD9A8FCF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.GetDeviationAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "GetDeviationAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetDeviationAt", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///method GetDeviationAt
	///</summary>
	public class GetDeviationAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetDeviationAt(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "4A78A0C5-210A-4596-8666-466D7A72EB9F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.GetSlackMiddleAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "GetSlackMiddleAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetSlackMiddleAt", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///method GetSlackMiddleAt
	///</summary>
	public class GetSlackMiddleAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetSlackMiddleAt(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "60EB300C-BD39-451B-90EC-6878254617C6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.CalcT", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "CalcT", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property CalcT", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///property CalcT
	///</summary>
	public class CalcT : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CalcT);

		}
	}


	[NVP_Manifest(
		Id = "49FB284E-5E87-4E1A-B6CD-5D3BD24EC178", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkMode.CalcIceThickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkMode", 
		NodeName = "CalcIceThickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property CalcIceThickness", 
		ViewType = "Data")]
	[NodeInput("MDSELLinkMode", typeof(object))]

	///<summary>
	///property CalcIceThickness
	///</summary>
	public class CalcIceThickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CalcIceThickness);

		}
	}
}
