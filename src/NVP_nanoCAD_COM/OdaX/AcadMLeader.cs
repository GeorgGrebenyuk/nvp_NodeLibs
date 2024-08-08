using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Multi-Leader Interface
///</summary>
namespace OdaX.AcadMLeader 
{

	[NVP_Manifest(
		Id = "BC523307-1406-4E87-A226-B4345EDAD3EB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.AcadMLeader_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "_AcadMLeader_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMLeader_Constructor : INode 
	{
		public OdaX.IAcadMLeader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadMLeader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "CACCD628-305E-4604-AAB3-D8DA9B9B6801", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.AcadMLeader_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "_AcadMLeader_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMLeader_ConstructorCast : INode 
	{
		public OdaX.IAcadMLeader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadMLeader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "3A920090-8E7C-42D6-A3BF-8EFAC4DBDF3C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.ScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "ScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the scale factor of a multileader.
	///</summary>
	public class ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleFactor);

		}
	}


	[NVP_Manifest(
		Id = "2CF4E130-04DD-4A42-8B9E-3CACEAE01014", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_ScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_ScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("scale", typeof(System.Double))]

	///<summary>
	///Specifies or returns the scale factor of a multileader.
	///</summary>
	public class Set_ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E51C5177-7C9F-4CD7-8992-962D4DE646AE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.LeaderType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "LeaderType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the type of multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the type of multileader.
	///</summary>
	public class LeaderType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderType);

		}
	}


	[NVP_Manifest(
		Id = "D8831177-8063-485A-A8EB-4B16FBAAE49B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_LeaderType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_LeaderType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the type of multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcMLeaderType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the type of multileader.
	///</summary>
	public class Set_LeaderType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderType = ((OdaX.AcMLeaderType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4DB53B6E-1B4E-4444-A7D2-EECF620E62C3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.LeaderLineColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "LeaderLineColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the color of a multileader.
	///</summary>
	public class LeaderLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineColor);

		}
	}


	[NVP_Manifest(
		Id = "641FE55D-9B54-4682-B3C6-D69FD132FF6F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_LeaderLineColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_LeaderLineColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of a multileader.
	///</summary>
	public class Set_LeaderLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "28387867-6ED9-47D5-AD2F-C734D4EE8805", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.LeaderLineType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "LeaderLineType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of a multileader.
	///</summary>
	public class LeaderLineType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineType);

		}
	}


	[NVP_Manifest(
		Id = "42360CAE-44CC-40A0-BB1A-B59DAA26C49E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_LeaderLineType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_LeaderLineType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("Linetype", typeof(System.Object))]

	///<summary>
	///Specifies or returns the linetype of a multileader.
	///</summary>
	public class Set_LeaderLineType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8418128C-F965-42C2-A267-18C74439CAC2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.LeaderLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "LeaderLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of a multileader.
	///</summary>
	public class LeaderLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "B070632A-6A5A-4714-B4D2-93A965352FA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_LeaderLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_LeaderLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of a multileader.
	///</summary>
	public class Set_LeaderLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "225731F9-65A0-4D07-9506-0253DE632556", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.ArrowheadType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "ArrowheadType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead type of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the arrowhead type of a multileader.
	///</summary>
	public class ArrowheadType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadType);

		}
	}


	[NVP_Manifest(
		Id = "5E7F5B3A-C4C7-44D1-8581-442934C17909", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_ArrowheadType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_ArrowheadType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead type of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcDimArrowheadType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the arrowhead type of a multileader.
	///</summary>
	public class Set_ArrowheadType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadType = ((OdaX.AcDimArrowheadType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3F459403-9499-4EF5-AA3E-261FE0A59572", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.ArrowheadSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "ArrowheadSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead size of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the arrowhead size of a multileader.
	///</summary>
	public class ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadSize);

		}
	}


	[NVP_Manifest(
		Id = "7DE6528E-126E-4B71-804D-4C8B248E9344", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_ArrowheadSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_ArrowheadSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead size of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("size", typeof(System.Double))]

	///<summary>
	///Specifies or returns the arrowhead size of a multileader.
	///</summary>
	public class Set_ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "64D8F7AF-321F-4440-A47D-0C6287B9A6E7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.DogLegged", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "DogLegged", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a dog leg is used for a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns whether a dog leg is used for a multileader.
	///</summary>
	public class DogLegged : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DogLegged);

		}
	}


	[NVP_Manifest(
		Id = "42F6372F-BFB3-4275-8241-BF3057AC3AEC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_DogLegged", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_DogLegged", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a dog leg is used for a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a dog leg is used for a multileader.
	///</summary>
	public class Set_DogLegged : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DogLegged = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "71B1A3CA-A5FA-4D21-9975-63BFEC69E93B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.DoglegLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "DoglegLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the dog leg length of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the dog leg length of a multileader.
	///</summary>
	public class DoglegLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoglegLength);

		}
	}


	[NVP_Manifest(
		Id = "CB851384-D8B4-406E-865C-4AD32BD86042", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_DoglegLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_DoglegLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the dog leg length of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("DoglegLength", typeof(System.Double))]

	///<summary>
	///Specifies or returns the dog leg length of a multileader.
	///</summary>
	public class Set_DoglegLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DoglegLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "13CB2CA2-6036-46D7-890F-2954907B6070", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.ContentBlockName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "ContentBlockName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the block name of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the block name of a multileader.
	///</summary>
	public class ContentBlockName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ContentBlockName);

		}
	}


	[NVP_Manifest(
		Id = "D380FB47-D409-46DA-A498-3F091341A62D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_ContentBlockName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_ContentBlockName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the block name of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("BlockName", typeof(System.String))]

	///<summary>
	///Specifies or returns the block name of a multileader.
	///</summary>
	public class Set_ContentBlockName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ContentBlockName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BAEBFEA4-A999-46B7-9743-C18899AF18DA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.BlockConnectionType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "BlockConnectionType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how a block connects with lines of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns how a block connects with lines of a multileader.
	///</summary>
	public class BlockConnectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BlockConnectionType);

		}
	}


	[NVP_Manifest(
		Id = "9F113206-F17F-4A6F-BC23-E7210B4ECAEA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_BlockConnectionType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_BlockConnectionType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how a block connects with lines of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcBlockConnectionType", typeof(System.Object))]

	///<summary>
	///Specifies or returns how a block connects with lines of a multileader.
	///</summary>
	public class Set_BlockConnectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BlockConnectionType = ((OdaX.AcBlockConnectionType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "35F676E2-D9E8-4AB8-824B-5900C7E23BA0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.BlockScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "BlockScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specify how leaders connect with content block", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specify how leaders connect with content block
	///</summary>
	public class BlockScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BlockScale);

		}
	}


	[NVP_Manifest(
		Id = "67493547-BE37-4296-8B2B-B54AD51B5888", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_BlockScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_BlockScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specify how leaders connect with content block", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("factor", typeof(System.Object))]

	///<summary>
	///Specify how leaders connect with content block
	///</summary>
	public class Set_BlockScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BlockScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FBE12BBC-118F-4495-B163-881C5F1BD632", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.TextString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "TextString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text string of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the text string of a multileader.
	///</summary>
	public class TextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextString);

		}
	}


	[NVP_Manifest(
		Id = "9BC76698-726B-4703-9FA6-6ADAA03AABB2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_TextString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_TextString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text string of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]

	///<summary>
	///Specifies or returns the text string of a multileader.
	///</summary>
	public class Set_TextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextString = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "44673162-6F52-4734-8226-2F6918484A39", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.TextStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "TextStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the style for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the style for text of a multileader.
	///</summary>
	public class TextStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyleName);

		}
	}


	[NVP_Manifest(
		Id = "9CD3C308-15D6-4E29-9F29-B56DC54DC9EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_TextStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_TextStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the style for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the style for text of a multileader.
	///</summary>
	public class Set_TextStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "49258E5D-9836-4B29-BF06-988DE8ABF52E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.TextJustify", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "TextJustify", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the attachment point for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the attachment point for text of a multileader.
	///</summary>
	public class TextJustify : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextJustify);

		}
	}


	[NVP_Manifest(
		Id = "AFFA0C8C-A6BA-4B6E-84AD-4F4BBE9CBBCA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_TextJustify", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_TextJustify", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the attachment point for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcAttachmentPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the attachment point for text of a multileader.
	///</summary>
	public class Set_TextJustify : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextJustify = ((OdaX.AcAttachmentPoint)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9C848F74-3557-4965-9D90-7F841CA88970", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.TextDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "TextDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text direction for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the text direction for text of a multileader.
	///</summary>
	public class TextDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextDirection);

		}
	}


	[NVP_Manifest(
		Id = "5A9F3BCE-6877-42B5-B08D-BED96131D61C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_TextDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_TextDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text direction for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcDrawingDirection", typeof(System.Object))]

	///<summary>
	///Specifies or returns the text direction for text of a multileader.
	///</summary>
	public class Set_TextDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextDirection = ((OdaX.AcDrawingDirection)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B3D04668-4650-4329-B4D1-C4BA385DB129", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.TextWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "TextWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns text width for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns text width for text of a multileader.
	///</summary>
	public class TextWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextWidth);

		}
	}


	[NVP_Manifest(
		Id = "D3C8E7E2-2AC8-4E9B-8B7E-2714916CF670", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_TextWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_TextWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns text width for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies or returns text width for text of a multileader.
	///</summary>
	public class Set_TextWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextWidth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A189092F-F9CD-4209-8C1C-2417CBFA50C8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns text height for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns text height for text of a multileader.
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
		Id = "7A0A6BEE-E7A9-4420-BE5F-581C7DD06391", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns text height for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies or returns text height for text of a multileader.
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
		Id = "DFF61913-5378-4439-9885-12AFF56ECA63", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.TextRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "TextRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the rotation for text of a multileader.
	///</summary>
	public class TextRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextRotation);

		}
	}


	[NVP_Manifest(
		Id = "9F3858DA-3849-43D8-AC8B-3DB5A535086A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_TextRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_TextRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation for text of a multileader.
	///</summary>
	public class Set_TextRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextRotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E2875E59-9C98-4542-83DC-894D11533332", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.TextLineSpacingFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "TextLineSpacingFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the line spacing factor for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the line spacing factor for text of a multileader.
	///</summary>
	public class TextLineSpacingFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextLineSpacingFactor);

		}
	}


	[NVP_Manifest(
		Id = "D1007581-4C54-4B44-8DF4-1A7F62C36356", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_TextLineSpacingFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_TextLineSpacingFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the line spacing factor for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("factor", typeof(System.Double))]

	///<summary>
	///Specifies or returns the line spacing factor for text of a multileader.
	///</summary>
	public class Set_TextLineSpacingFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextLineSpacingFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D77AD026-CAE7-4519-B7B4-654FFF5ACDB9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.TextLineSpacingDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "TextLineSpacingDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the line spacing distance for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the line spacing distance for text of a multileader.
	///</summary>
	public class TextLineSpacingDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextLineSpacingDistance);

		}
	}


	[NVP_Manifest(
		Id = "8E0E1730-EFF1-403B-9AA5-7FBB6F2F884E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_TextLineSpacingDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_TextLineSpacingDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the line spacing distance for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("Value", typeof(System.Double))]

	///<summary>
	///Specifies or returns the line spacing distance for text of a multileader.
	///</summary>
	public class Set_TextLineSpacingDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextLineSpacingDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9AB70C0C-7446-4472-8A2B-579A26515E65", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.TextLineSpacingStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "TextLineSpacingStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the line spacing style for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the line spacing style for text of a multileader.
	///</summary>
	public class TextLineSpacingStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextLineSpacingStyle);

		}
	}


	[NVP_Manifest(
		Id = "2C9206E1-CED5-4DDD-9213-A60CCF3B5659", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_TextLineSpacingStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_TextLineSpacingStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the line spacing style for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcLineSpacingStyle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the line spacing style for text of a multileader.
	///</summary>
	public class Set_TextLineSpacingStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextLineSpacingStyle = ((OdaX.AcLineSpacingStyle)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "18B77F23-C51F-495A-9BD3-2CA2CB1C295C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.TextBackgroundFill", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "TextBackgroundFill", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a background is used used for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns whether a background is used used for text of a multileader.
	///</summary>
	public class TextBackgroundFill : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextBackgroundFill);

		}
	}


	[NVP_Manifest(
		Id = "CC642AEE-86FE-43B3-87EC-52F73DDF1164", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_TextBackgroundFill", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_TextBackgroundFill", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a background is used used for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("bUseBackgroundFill", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a background is used used for text of a multileader.
	///</summary>
	public class Set_TextBackgroundFill : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextBackgroundFill = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2C7D8D6D-FAE7-44F5-9EE1-97AF14AE9050", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.TextAttachmentDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "TextAttachmentDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies if leaders connect with the text horizontally or vertically", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies if leaders connect with the text horizontally or vertically
	///</summary>
	public class TextAttachmentDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextAttachmentDirection);

		}
	}


	[NVP_Manifest(
		Id = "77260417-EBB5-452F-950E-5F36EBB64CF7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_TextAttachmentDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_TextAttachmentDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies if leaders connect with the text horizontally or vertically", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcTextAttachmentDirection", typeof(System.Object))]

	///<summary>
	///Specifies if leaders connect with the text horizontally or vertically
	///</summary>
	public class Set_TextAttachmentDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextAttachmentDirection = ((OdaX.AcTextAttachmentDirection)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "53E599A5-406B-4E98-BF4B-181E9E36C8BC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.TextLeftAttachmentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "TextLeftAttachmentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how leaders on the left connect with text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns how leaders on the left connect with text of a multileader.
	///</summary>
	public class TextLeftAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextLeftAttachmentType);

		}
	}


	[NVP_Manifest(
		Id = "685DD241-A7E9-4459-B53C-976935E50F5E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_TextLeftAttachmentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_TextLeftAttachmentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how leaders on the left connect with text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcTextAttachmentType", typeof(System.Object))]

	///<summary>
	///Specifies or returns how leaders on the left connect with text of a multileader.
	///</summary>
	public class Set_TextLeftAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextLeftAttachmentType = ((OdaX.AcTextAttachmentType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5AE5F60C-48D3-485D-AA92-45CE7E914C61", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.TextRightAttachmentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "TextRightAttachmentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how leaders on the right connect with text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns how leaders on the right connect with text of a multileader.
	///</summary>
	public class TextRightAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextRightAttachmentType);

		}
	}


	[NVP_Manifest(
		Id = "0D68DD41-1BBE-4ACE-9C6D-F7443C267F24", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_TextRightAttachmentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_TextRightAttachmentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how leaders on the right connect with text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcTextAttachmentType", typeof(System.Object))]

	///<summary>
	///Specifies or returns how leaders on the right connect with text of a multileader.
	///</summary>
	public class Set_TextRightAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextRightAttachmentType = ((OdaX.AcTextAttachmentType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C19C0663-EC41-4BDC-ACC6-E3693DA48C04", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.TextTopAttachmentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "TextTopAttachmentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies how leaders on the top connect with the text", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies how leaders on the top connect with the text
	///</summary>
	public class TextTopAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextTopAttachmentType);

		}
	}


	[NVP_Manifest(
		Id = "BB530F55-D0A7-451E-85E8-E725B62F672D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_TextTopAttachmentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_TextTopAttachmentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies how leaders on the top connect with the text", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcVerticalTextAttachmentType", typeof(System.Object))]

	///<summary>
	///Specifies how leaders on the top connect with the text
	///</summary>
	public class Set_TextTopAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextTopAttachmentType = ((OdaX.AcVerticalTextAttachmentType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E88DC860-4318-40A1-84B7-1073C04AD1B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.TextBottomAttachmentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "TextBottomAttachmentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies how leaders on the bottom connect with the text", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies how leaders on the bottom connect with the text
	///</summary>
	public class TextBottomAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextBottomAttachmentType);

		}
	}


	[NVP_Manifest(
		Id = "42A931AD-88B1-43BF-A4CB-EBB39B194A8B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_TextBottomAttachmentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_TextBottomAttachmentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies how leaders on the bottom connect with the text", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcVerticalTextAttachmentType", typeof(System.Object))]

	///<summary>
	///Specifies how leaders on the bottom connect with the text
	///</summary>
	public class Set_TextBottomAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextBottomAttachmentType = ((OdaX.AcVerticalTextAttachmentType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FA4A3E87-E3EE-4D3E-8679-B810BD817F89", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.LandingGap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "LandingGap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specify or returns the landing gap for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specify or returns the landing gap for text of a multileader.
	///</summary>
	public class LandingGap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LandingGap);

		}
	}


	[NVP_Manifest(
		Id = "19FBF12E-18F7-495B-841E-3FC4EA22E896", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_LandingGap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_LandingGap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specify or returns the landing gap for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("gap", typeof(System.Double))]

	///<summary>
	///Specify or returns the landing gap for text of a multileader.
	///</summary>
	public class Set_LandingGap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LandingGap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "643E6759-C226-4EF1-9133-7440C0AE0CAB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.ArrowheadBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "ArrowheadBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the block to use as the custom arrowhead of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the block to use as the custom arrowhead of a multileader.
	///</summary>
	public class ArrowheadBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadBlock);

		}
	}


	[NVP_Manifest(
		Id = "20072665-C4DE-4C77-99F5-46B53AEF1447", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_ArrowheadBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_ArrowheadBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the block to use as the custom arrowhead of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("BlockName", typeof(System.String))]

	///<summary>
	///Specifies or returns the block to use as the custom arrowhead of a multileader.
	///</summary>
	public class Set_ArrowheadBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadBlock = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "764284CB-217C-4B47-98D8-DD0A3066C1ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.ContentBlockType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "ContentBlockType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the type of block used as the custom arrowhead of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the type of block used as the custom arrowhead of a multileader.
	///</summary>
	public class ContentBlockType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ContentBlockType);

		}
	}


	[NVP_Manifest(
		Id = "E97C64A8-3382-442F-8B76-6FE22A776241", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_ContentBlockType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_ContentBlockType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the type of block used as the custom arrowhead of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcPredefBlockType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the type of block used as the custom arrowhead of a multileader.
	///</summary>
	public class Set_ContentBlockType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ContentBlockType = ((OdaX.AcPredefBlockType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F22E30F5-2668-413D-A926-E5156F01AAF0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.LeaderCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "LeaderCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the number of leader lines for a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Returns the number of leader lines for a multileader.
	///</summary>
	public class LeaderCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderCount);

		}
	}


	[NVP_Manifest(
		Id = "DF0827AE-2857-47E4-800D-9AACE584AC3D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.AddLeader", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "AddLeader", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds a new cluster of leader lines to a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Adds a new cluster of leader lines to a multileader.
	///</summary>
	public class AddLeader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddLeader);

		}
	}


	[NVP_Manifest(
		Id = "1F9338A9-AF0F-4D19-94B2-2B213A876165", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.RemoveLeader", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "RemoveLeader", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Deletes a cluster of leader lines from a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderIndex", typeof(System.Int32))]

	///<summary>
	///Deletes a cluster of leader lines from a multileader.
	///</summary>
	public class RemoveLeader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveLeader(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "10A82F50-5E4A-496D-B8DA-EBCD32BBF144", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.AddLeaderLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "AddLeaderLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds a leader line to the leader cluster of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderIndex", typeof(System.Int32))]
	[NodeInput("pointArray", typeof(System.Object))]

	///<summary>
	///Adds a leader line to the leader cluster of a multileader.
	///</summary>
	public class AddLeaderLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddLeaderLine(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "275F1921-C88F-4424-9FD3-6910E9F479AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.AddLeaderLineEx", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "AddLeaderLineEx", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds a new leader line to a multileader using a start vertex for the leader line.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("pointArray", typeof(System.Object))]

	///<summary>
	///Adds a new leader line to a multileader using a start vertex for the leader line.
	///</summary>
	public class AddLeaderLineEx : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddLeaderLineEx(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "6704C60C-32A2-4181-A985-6EA6775268BB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.RemoveLeaderLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "RemoveLeaderLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Deletes a leader line from a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderLineIndex", typeof(System.Int32))]

	///<summary>
	///Deletes a leader line from a multileader.
	///</summary>
	public class RemoveLeaderLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveLeaderLine(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C85CE872-4D6D-4A28-846E-C58861DE2B03", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.SetLeaderLineVertices", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "SetLeaderLineVertices", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the vertices for a leader line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderLineIndex", typeof(System.Int32))]
	[NodeInput("pointArray", typeof(System.Object))]

	///<summary>
	///Specifies the vertices for a leader line.
	///</summary>
	public class SetLeaderLineVertices : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetLeaderLineVertices(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "795DA1FB-B599-400B-AC3C-BC6472859413", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.GetLeaderLineVertices", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "GetLeaderLineVertices", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the vertices for a leader line.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderLineIndex", typeof(System.Int32))]

	///<summary>
	///Specifies the vertices for a leader line.
	///</summary>
	public class GetLeaderLineVertices : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLeaderLineVertices(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "AB7B3CF3-A65F-4979-BCBE-DAED2C44C572", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_ContentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_ContentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the content type of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcMLeaderContentType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the content type of a multileader.
	///</summary>
	public class Set_ContentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ContentType = ((OdaX.AcMLeaderContentType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "24BC99B0-736E-4156-9F6D-14E34E64216D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.ContentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "ContentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the content type of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the content type of a multileader.
	///</summary>
	public class ContentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ContentType);

		}
	}


	[NVP_Manifest(
		Id = "2784C247-4B70-4050-92DC-D8544DAD0D07", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.GetLeaderIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "GetLeaderIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the index of the leader cluster to which a specified leader line belongs.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderLineIndex", typeof(System.Int32))]

	///<summary>
	///Returns the index of the leader cluster to which a specified leader line belongs.
	///</summary>
	public class GetLeaderIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLeaderIndex(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "4F39687A-FAA2-4147-B368-EA3B23E289A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.GetLeaderLineIndexes", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "GetLeaderLineIndexes", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the index of a leader line.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderIndex", typeof(System.Int32))]

	///<summary>
	///Returns the index of a leader line.
	///</summary>
	public class GetLeaderLineIndexes : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLeaderLineIndexes(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "D6B64805-0F74-43A1-8481-7B5EA7889398", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.GetVertexCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "GetVertexCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the number of vertices in a leader line of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderLineIndex", typeof(System.Int32))]

	///<summary>
	///Returns the number of vertices in a leader line of a multileader.
	///</summary>
	public class GetVertexCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetVertexCount(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "013B6360-1166-4215-B10B-B5ACF3D49E8D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.TextFrameDisplay", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "TextFrameDisplay", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a text frame displays for a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns whether a text frame displays for a multileader.
	///</summary>
	public class TextFrameDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextFrameDisplay);

		}
	}


	[NVP_Manifest(
		Id = "E7EE032E-6985-430C-B2A9-6A8A63E09B40", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_TextFrameDisplay", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_TextFrameDisplay", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a text frame displays for a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a text frame displays for a multileader.
	///</summary>
	public class Set_TextFrameDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextFrameDisplay = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "037138A2-E295-40D6-85DD-D2FE02D5FAC3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.StyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "StyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the style name of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the style name of a multileader.
	///</summary>
	public class StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StyleName);

		}
	}


	[NVP_Manifest(
		Id = "C0C3E4DC-5C3C-4D7E-AE60-DA28EA26F406", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.Set_StyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "Set_StyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the style name of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies or returns the style name of a multileader.
	///</summary>
	public class Set_StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E003B52A-9BCA-4A17-9B8B-CE5208012890", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.GetDoglegDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "GetDoglegDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the dog leg direction of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderIndex", typeof(System.Int32))]

	///<summary>
	///Returns the dog leg direction of a multileader.
	///</summary>
	public class GetDoglegDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetDoglegDirection(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "0AFDC3D0-585D-453A-9DD7-C7A0572B4EC3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.SetDoglegDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "SetDoglegDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the dog leg direction of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderIndex", typeof(System.Int32))]
	[NodeInput("dirVec", typeof(System.Object))]

	///<summary>
	///Specifies the dog leg direction of a multileader.
	///</summary>
	public class SetDoglegDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetDoglegDirection(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "22E65F70-F89B-4A73-882D-D02DAF8B15F4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.GetBlockAttributeValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "GetBlockAttributeValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the attribute value of a block.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("attdefId", typeof(System.Object))]

	///<summary>
	///Returns the attribute value of a block.
	///</summary>
	public class GetBlockAttributeValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBlockAttributeValue(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "FDF06A4A-1F06-4D52-80A0-E2B7D7F3377B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeader.SetBlockAttributeValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeader", 
		NodeName = "SetBlockAttributeValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the attribute value of a block.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("attdefId", typeof(System.Object))]
	[NodeInput("Value", typeof(System.String))]

	///<summary>
	///Specifies the attribute value of a block.
	///</summary>
	public class SetBlockAttributeValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBlockAttributeValue(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}
}
