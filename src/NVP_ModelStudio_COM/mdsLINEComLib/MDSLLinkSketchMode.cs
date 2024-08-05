using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSLLinkSketchMode Interface
///</summary>
namespace mdsLINEComLib.MDSLLinkSketchMode 
{

	[NVP_Manifest(
		Id = "7A8BE0C5-0A5C-4C23-8FC6-EAA8E6D28AAB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.MDSLLinkSketchMode_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "_MDSLLinkSketchMode_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLLinkSketchMode_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLLinkSketchMode _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLLinkSketchMode;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "047D19C2-EB38-451D-8E75-73FBA425A06D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.MDSLLinkSketchMode_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "_MDSLLinkSketchMode_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLLinkSketchMode_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLLinkSketchMode _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLLinkSketchMode;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "9BC11085-A297-4525-B8AB-35AA29F13788", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.WireLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "WireLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WireLength", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

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
		Id = "E4523862-CC4B-4044-976B-1E0F96471760", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.Sigma", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "Sigma", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Sigma", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

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
		Id = "BAB3970C-B684-43BD-9133-B41B7F5396AD", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.Gamma", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "Gamma", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Gamma", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

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
		Id = "0F81D80D-08C8-49B5-9BB1-77E8E7EF1706", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.InitialModeIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "InitialModeIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property InitialModeIndex", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

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
		Id = "DEAD3B47-4657-4F60-BFC0-FA0B9FF122F2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.SpanLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "SpanLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SpanLength", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

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
		Id = "BF3DB480-53D1-4056-9045-AE117B49FF21", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.InitialSigma", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "InitialSigma", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property InitialSigma", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

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
		Id = "BF309B68-4001-402F-A82F-09B01E689EA4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.InitialGamma", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "InitialGamma", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property InitialGamma", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

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
		Id = "647400EA-6F8E-4A48-9CB4-7EE78A4FD811", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.InitialT", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "InitialT", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property InitialT", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

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
		Id = "36CC059A-F89E-443F-9555-07FE08702F5D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.GetGammaStd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "GetGammaStd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetGammaStd", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

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
		Id = "597D8169-103B-4D30-9698-637E358373CF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.MinX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "MinX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property MinX", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

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
		Id = "D097510C-80B7-433E-B7B3-4C939BA1EFDB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.MinZ", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "MinZ", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property MinZ", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

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
		Id = "D5823B43-9A62-4114-9217-AB016AC6D38E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.SlackMin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "SlackMin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SlackMin", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

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
		Id = "AC8FF635-1E78-4C03-BCFE-95D91E8EFF7F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.SlackMax", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "SlackMax", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SlackMax", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

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
		Id = "95706592-B9BD-4181-9ACE-19F02EE75FE8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.GetSlackMaxAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "GetSlackMaxAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetSlackMaxAt", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]
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
		Id = "7BE3F3B0-7061-40F6-A610-CC2C1A7ADF08", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Length", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

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
		Id = "98C202E8-A6DA-4EBE-BA42-CB858DDC9E34", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.SlackSpan", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "SlackSpan", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SlackSpan", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]
	[NodeInput("nSpanNum", typeof(System.Int32))]

	///<summary>
	///property SlackSpan
	///</summary>
	public class SlackSpan : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SlackSpan(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "05FB0CFC-BB8D-4639-B8AD-7F64B96BDA25", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.WindAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "WindAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property WindAngle", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

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
		Id = "78D33BFA-31FB-4A5D-88DF-58562F7ECB73", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.GetGammaNorm", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "GetGammaNorm", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetGammaNorm", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

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
		Id = "DBF3DC7D-8D3A-4280-BBA3-F90107BC2ED3", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchMode.GetGammaCalc", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchMode", 
		NodeName = "GetGammaCalc", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetGammaCalc", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

	///<summary>
	///method GetGammaCalc
	///</summary>
	public class GetGammaCalc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGammaCalc);

		}
	}
}
